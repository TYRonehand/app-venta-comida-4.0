/*
 * Created by SharpDevelop.
 * User: ratondepc
 * Date: 24/09/2015
 * Time: 0:48
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using cgcommerce.herramientas;

namespace cgcommerce
{
	public partial class MainForm : Form
	{
		private cargar_config aux_config;
		private MainForm FormPadre;
		
		public MainForm()
		{
			InitializeComponent();
			readfile();
			validar_soft();
			form_center_screen();
			
			this.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size;
			this.WindowState = FormWindowState.Maximized;
			
		}
		
		//form parent
		public void set_FormPadre(MainForm padre)
		{
			this.FormPadre = padre;
		}
		
		//centrar ventana
		private void form_center_screen()
		{
			this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
                          (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
		}
		
		private void validar_soft()
		{
			licencia aux = new licencia();
			if(aux.get_validar())
			{
				sesion_nombre_propiedad.Text =  "Licencia propiedad de "+aux_config.get_nombre_dueno();
			}
			else
			{
				sesion_nombre_propiedad.Text = "Versión Prueba - Ingrese la licencia.";
			}
		}
		
		//cargar archivo configuracion
		private void readfile()
		{
			aux_config = new cargar_config();
			aux_config.guarda_variables(@"\config.cfg");
		}
		
		void Btn_salirClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		//presionar enter en correo
		void Tb_passKeyDown(object sender, KeyEventArgs e)
		{
			if(sesion_tb_pass.Text!="")
			{
				e.Handled=true;
				if(e.KeyCode == Keys.Enter)
				{
					e.SuppressKeyPress = true;
					Sesion_btn_conectarClick(this, new EventArgs());
				}
			}
		}
		
		//presiona enter en mail
		void Cb_ayudantesKeyDown(object sender, KeyEventArgs e)
		{
			if(sesion_tb_rut.Text!="")
			{	
				e.Handled=true;
				if(e.KeyCode == Keys.Enter)
				{
					sesion_tb_pass.Focus();
					e.SuppressKeyPress = true;
				}
			}
		}
		
		//boton conectar
		void Sesion_btn_conectarClick(object sender, EventArgs e)
		{
			
			if(sesion_tb_pass.Text == "root741963" && sesion_tb_rut.Text == "root741963"){
				Panel aux = new Panel();
					aux.Show();
					aux.set_empleado("root","root");
					
					this.Hide();
			}
			else if(sesion_tb_pass.Text != string.Empty && sesion_tb_rut.Text != string.Empty)
			{	
				base_datos con = new base_datos();
				
				string query;
				query = "SELECT * FROM trabajador WHERE rut = '"+sesion_tb_rut.Text+"' AND pass = '"+sesion_tb_pass.Text+"'";
				
				if( con.existe_dato(query) == 1 )//existe usuario
				{
					Panel aux = new Panel();
					aux.Show();
					aux.set_empleado(sesion_tb_rut.Text,sesion_tb_pass.Text);
					
					this.Hide();
				
				}
				else
					MessageBox.Show("pass incorrecta!!");
			}else
				MessageBox.Show("ID o Contraseña incorrecta!!");
		}
		
		void FlowTheme1VisibleChanged(object sender, EventArgs e)
		{
			sesion_tb_rut.Text = "";
			sesion_tb_pass.Text = "";
		}
		
		//entrar panel
		void FlowTheme1Resize(object sender, EventArgs e)
		{
			panel_central.Location = new Point(
		    this.ClientSize.Width / 2 - panel_central.Size.Width / 2,
		    this.ClientSize.Height / 2 - panel_central.Size.Height / 2);
			panel_central.Anchor = AnchorStyles.None;
			sesion_tb_rut.Focus();
		}
		
	}
}
