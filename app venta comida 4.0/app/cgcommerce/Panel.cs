/*
 * Created by SharpDevelop.
 * User: Carlos Gutierrez Acevedo
 * Date: 09/09/2015
 * Time: 15:11
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using cgcommerce.Caja_Modulo;
using cgcommerce.Config_Modulo;
using cgcommerce.Producto_Modulo;
using cgcommerce.herramientas;
using cgcommerce.Administracion___Modulo;

namespace cgcommerce
{
	
	public partial class Panel : Form
	{
		//public string rut_empleado, pass_empleado;
		private bool SWregistrado = false;
		private const int tiempo_cierre = 1;//minutos
		private string estado_caja = "CERRADO";
		private string caja_actual;
		
		public string nombre_empresa;
		public string numero_serie;
		public string Version;
		
		public Panel()
		{
			InitializeComponent();
			readfile();
			validar_soft();
			inicializar();
			caja_abierta();
			this.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size;
			this.WindowState = FormWindowState.Maximized;
			
		}
		
		//carga los datos del empleado
		public void set_empleado( string id, string pass)
		{
			this.menu_lb_usuario.Text = id;
			this.menu_lb_pass.Text = pass;
			
			base_datos con = new base_datos();
			
			if(con.existe_dato("SELECT * FROM trabajador WHERE rut = '"+id+"' AND pass = '"+pass+"' AND tipo = 'ADMIN' ")==1)
			{	
				this.menu_lb_tipo.Text = "ADMINISTRADOR";
				
				//esconde elementos que son de administracion
				lb_empleado.Visible = true;
				menu_btn_empleados.Visible = true;
				lb_finanza.Visible = true;
				menu_btn_finanza.Visible = true;
				lb_config.Visible = true;
				menu_btn_config.Visible = true;
				
			}
			else
			{
				this.menu_lb_tipo.Text = "NORMAL";
				
				//esconde elementos que son de administracion
				lb_empleado.Visible = false;
				menu_btn_empleados.Visible = false;
				lb_finanza.Visible = false;
				menu_btn_finanza.Visible = false;
				lb_config.Visible = false;
				menu_btn_config.Visible = false;
				
			}
		}
		
		//validar software
		private void validar_soft()
		{
			licencia aux = new licencia();
			if(aux.get_validar())
			{
				Forma_principal.Text +=  " - Version Completa";
				timer1.Dispose();
				SWregistrado = true;
			}
			else
			{
				Forma_principal.Text += " - Version Prueba de "+tiempo_cierre+" min.";
				timer1.Interval = tiempo_cierre*60000;
				timer1.Tick += new EventHandler(timer_Tick);
				timer1.Start();
			}
		}
		
		//timer cierre sesion
		public void timer_Tick(object sender, EventArgs e)
		{
			MessageBox.Show("Version de Prueba. Ingrese la licencia!");
		  	Application.Exit();
		}
		
		//cargar archivo configuracion
		private void readfile()
		{
			cargar_config aux = new cargar_config();
			aux.guarda_variables(@"\config.cfg");
			
			//titulo
			Forma_principal.Text = "Soft Venta - "+aux.get_nombre_empresa();
			
			//color fondo
			picture_logo1.BackColor = ColorTranslator.FromHtml(aux.get_color4());
			
			//fecha actual
			menu_lb_leyenda.BackColor = ColorTranslator.FromHtml(aux.get_color4());
			menu_lb_leyenda.Text = aux.get_nombre_empresa() +" - "+String.Format("{0:dddd, MMMM d, yyyy}",DateTime.Now);
			
			//color contenedor1
			contenedor1.BackColor = ColorTranslator.FromHtml(aux.get_color4());
			contenedor1.Panel2.BackColor = ColorTranslator.FromHtml(aux.get_color4());
			
			//datos empleado
			menu_lb_usuario.BackColor = ColorTranslator.FromHtml(aux.get_color4());
			menu_lb_tipo.BackColor = ColorTranslator.FromHtml(aux.get_color4());
			
			//estado caja
			lb_estado_caja.BackColor = ColorTranslator.FromHtml(aux.get_color4());
			
		}
		
		//inicializar
		private void inicializar()
		{
			//cargar logotipo e icono
			string imagenes;
			imagenes = System.IO.Directory.GetCurrentDirectory()+@"\logo.bmp";
			if(System.IO.File.Exists(imagenes))
			{
				//MessageBox.Show(imagenes[0]);
				picture_logo1.BackgroundImage = Image.FromFile(imagenes);
			}
			else
			{
				MessageBox.Show("Logo no existe","Atención");
			}
		}
		
		//nuevo pedido
		void Btn_pedidoClick(object sender, EventArgs e)
		{
			if(SWregistrado)
			{
				if(estado_caja=="ABIERTO")
				{
					add_pedido aux = new add_pedido();
					aux.Show();
					aux.set_vendedor(menu_lb_usuario.Text,caja_actual);
				}
				else
					MessageBox.Show("Abra Caja Primero","Atención");
	
			}else
				MessageBox.Show("ACTIVE EL PRODUCTO!!", "VERSION PRUEBA");	
		}
		
		//acceso a clientes
		void Btn_clienteClick(object sender, EventArgs e)
		{
			if(SWregistrado)
			{
				clientes aux = new clientes();
				aux.ShowDialog(this);
			}
			else
				MessageBox.Show("ACTIVE EL PRODUCTO!!", "VERSION PRUEBA");
		}
		
		//accesso a productos
		void Btn_productoClick(object sender, EventArgs e)
		{
			if(SWregistrado)
			{
				productos aux = new productos();
				aux.ShowDialog(this);
			}
			else
				MessageBox.Show("ACTIVE EL PRODUCTO!!", "VERSION PRUEBA");	
		}
		
		//acceso a agregados
		void Btn_agregadoClick(object sender, EventArgs e)
		{
			if(SWregistrado)
			{
				nuevo_agregado aux = new nuevo_agregado();
				aux.ShowDialog(this);
			}
			else
				MessageBox.Show("ACTIVE EL PRODUCTO!!", "VERSION PRUEBA");	
		}
		
		//Tooltip para botones
		void hoverButton(object sender, EventArgs e)
		{
			System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
			Button aux = (Button)sender;
			ToolTip1.SetToolTip(aux , aux.AccessibleDescription.ToString());
		}
		
		//acceso a empleados
		void Menu_btn_empleadosClick(object sender, EventArgs e)
		{
			if(SWregistrado)
			{
				empleado aux = new empleado();
				aux.ShowDialog(this);
			}
			else
				MessageBox.Show("ACTIVE EL PRODUCTO!!", "VERSION PRUEBA");	
		}
		
		//acceso a finanzas
		void Menu_btn_finanzaClick(object sender, EventArgs e)
		{
			if(SWregistrado)
			{
	            finanza aux = new finanza();
	            aux.ShowDialog(this);
			}
			else
				MessageBox.Show("ACTIVE EL PRODUCTO!!", "VERSION PRUEBA");	
		}
		
		//acceso a configuraciones
		void Menu_btn_configClick(object sender, EventArgs e)
		{
			if(SWregistrado)
			{
				config_menu aux = new config_menu();
				aux.ShowDialog(this);
			}
			else
				MessageBox.Show("ACTIVE EL PRODUCTO!!", "VERSION PRUEBA");	
		}
		
		//boton cierra (X)
		void Menu_btn_salirClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		//boton salida
		void Btn_salirClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		//evento contro de cierre panel
		void PanelFormClosing(object sender, FormClosingEventArgs e)
		{
			if(SWregistrado)
			{
				var closeMsg = MessageBox.Show( "Cerrar Sesión?", "Advertencia!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question );
				if (closeMsg == DialogResult.Yes) 
				{
					Application.OpenForms["MainForm"].Show();
				}
				else
				{
					e.Cancel = true;
					return;
				}
			}
			else
				Application.OpenForms["MainForm"].Close();
				
		}
		
		//verificar cajas abiertas
		private void caja_abierta()
		{
			base_datos con = new base_datos();
			
			if(con.existe_dato("SELECT * FROM caja WHERE estado = 'ABIERTO' ORDER BY fapertura ASC")==1)
			{
				estado_caja = "ABIERTO";
				
				//id caja abierta
				caja_actual = con.consulta_dato("SELECT id_caja FROM caja WHERE estado = 'ABIERTO' ");
				
			}
			else
			{
				estado_caja = "CERRADO";
				//consulta si existe cajas
				if(con.existe_dato("SELECT * FROM caja")==1)
				{
					//nueva id
					caja_actual = con.consulta_dato("SELECT MAX(id_caja)+1 FROM caja WHERE estado = 'CERRADO' ");
				}
				else//si no existe sera la primera
					caja_actual = "1";
			}
			
			//titulo
			lb_estado_caja.Text = "ESTADO: "+estado_caja;
		}
		
		//abrir o cerra caja
		void Menu_btn_cajaClick(object sender, EventArgs e)
		{
			if(SWregistrado)
			{
				//caja abierta
				if(estado_caja.Equals( "ABIERTO"))
				{
					//cerrar caja
					cierre aux = new cierre();
					aux.Show();
					aux.set_caja(caja_actual,menu_lb_usuario.Text);
					
					estado_caja = "CERRADO";
					
				}
				//caja cerrada
				else{
					//abrir caja
					apertura aux = new apertura();
					aux.Show();
					aux.set_caja(caja_actual,menu_lb_usuario.Text);
					
					estado_caja = "ABIERTO";
				}
				
				//titulo
				lb_estado_caja.Text = "ESTADO: "+estado_caja;
			}
		}
		
		
	}
}
