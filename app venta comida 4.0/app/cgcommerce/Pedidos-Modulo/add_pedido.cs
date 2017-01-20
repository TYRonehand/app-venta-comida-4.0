/*
 * Created by SharpDevelop.
 * User: Carlos Gutierrez Acevedo
 * Date: 09/09/2015
 * Time: 17:01
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;
using cgcommerce.herramientas;

namespace cgcommerce
{
	
	public partial class add_pedido : Form
	{
		//hoja
		private int hoja_ancho = 470, hoja_alto = 350;
		private Font font1, font2, font3, font4;
		
		//variable de ingrediente 
		private int precio_total_orden_valor;
		private string id_caja = string.Empty;
		
		/*DATOS USUARIO*/
		public string mail;
		public string clave;
		
		/*DATOS CONEXION  Y TABLA*/
		
		public add_pedido()
		{
			InitializeComponent();
			inicializar();
			form_center_screen();
			TamPrinter();
		}
		
		//cargar tamaño hoja
		private void TamPrinter()
		{
			//datos boleta
			string datos = System.IO.Directory.GetCurrentDirectory()+@"\config.cfg";
			
			if(System.IO.File.Exists(datos))//personal
			{
				cargar_config aux = new cargar_config();
				aux.guarda_variables(@"\printer.ini");
				
				hoja_alto = Int32.Parse(aux.get_nombre_empresa());
				hoja_ancho = Int32.Parse(aux.get_nombre_dueno());
				font1 = new Font("Courier new", Int32.Parse(aux.get_color1()));
				font2 = new Font("Courier new", Int32.Parse(aux.get_color2()));
				font3 = new Font("Courier new", Int32.Parse(aux.get_color3()));
				font4 = new Font("Courier new", Int32.Parse(aux.get_color4()));
			}
			else//default
			{
				hoja_alto = 350;
				hoja_ancho = 302;
				font1 = new Font("Courier new", 10);
				font2 = new Font("Courier new", 12);
				font3 = new Font("Courier new", 16);
				font4 = new Font("Courier new", 18);
			}
		}
		
		//setea el vendedor
		public void set_vendedor(string rut_vendedor, string id)
		{
			//guardamos la caja actual
			this.id_caja = id;
			
			base_datos conexionbd;
			conexionbd = new base_datos();
			
			orden_rut_vendedor.Text = rut_vendedor;
			string query = "SELECT (nombre &' '& apellido) as FullName FROM trabajador WHERE rut = '"+rut_vendedor+"'";
			conexionbd.LoadDataOnCombo(query, orden_nombre_vendedor);
			
		}
		
		//centra la form al centro
		private void form_center_screen()
		{
			this.TopMost = true;
			this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
                          (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
		}
		
		/* PRIMERA CARGA */
		private void inicializar()
		{
			//carga el numero de orden nuevo
			cargar_nro_orden_actual();
			
			//carga alternativas base
			cargar_alternativas();
			
			//cargar clientes
			cargar_clientes();
			
			//llenamos el combobox con los agregados
			cargar_agregados();
		
			//cargar logotipo e icono
			string imagenes;
			imagenes = System.IO.Directory.GetCurrentDirectory()+@"\logo.bmp";
			if(System.IO.File.Exists(imagenes))
			{
				//MessageBox.Show(imagenes[0]);
				picture_logo .Image = Image.FromFile(imagenes);
			}
			else
			{
				MessageBox.Show("Logo no existe","Atención");
			}
			
		}
		
		private void cargar_nro_orden_actual()
		{
			
			base_datos conexionbd;
			conexionbd = new base_datos();
			
			string query;
			query = "SELECT (MAX(id_orden)+1) as Fullname FROM orden";
			conexionbd.LoadDataOnCombo(query,orden_cb_nro_orden);
		}
		
		private void cargar_alternativas()
		{
			
			base_datos conexionbd;
			conexionbd = new base_datos();
			
			string query;
			query = "SELECT id, nombre, ingredientes, precio, contador FROM alternativa WHERE disponible=1";
			conexionbd.Actualizar_malla(data_base, query);
			data_base.Columns["contador"].Visible = false;
			data_base.Columns["id"].Width = 55;
			
		}
		
		private void cargar_clientes()
		{
			
			base_datos conexionbd;
			conexionbd = new base_datos();
			
			string query;
			query = "SELECT apellido, nombre, direccion, fono1, fono2, id_cliente as oid FROM cliente ORDER BY apellido";
			conexionbd.Actualizar_malla(data_cliente, query);
		}
		
		private void cargar_agregados()
		{
			
			base_datos conexionbd;
			conexionbd = new base_datos();
			
			string query;
			query = "SELECT nombre &'-'& precio as Fullname FROM agregado WHERE disponible <> 0";
			conexionbd.LoadDataOnCombo(query, cbo_agregados);
		}
		
		//ACTUALIZA EN LOS LABEL EL PRECIO CALCULADO
		private void actualizar_precio_pedido(int valor)
		{
			label_precio_total.Text = valor.ToString();
			label_precio_total2.Text = valor.ToString();
			label_precio_total3.Text = valor.ToString();
			label_precio_real.Text = valor.ToString();
		}
		
		/* ORDENES PARA BOTONES SIMPLES */
		
		//CAMBIA PAGINA(PASO-2)
		private void Btn_pedido_listoClick(object sender, EventArgs e)
		{
			TabPrincipal.SelectedTab = tabCliente;
		}
		
		//CAMBIA PAGINA(PASO-3)
		private void Btn_cliente_listoClick(object sender, EventArgs e)
		{
			TabPrincipal.SelectedTab = tabOrden;
			vuelto_cliente.Text = (Int32.Parse(num_efectivo_cliente.Text) - Int32.Parse(label_precio_total2.Text)).ToString();
		}
		
		//INGRESA INGREDIENTE SELECCIONADO
		private void Btn_add_agregadosClick(object sender, EventArgs e)
		{
			if(lista_ingredientes.Items.Count>0)
			{
				lista_ingredientes.Items.Insert(0, cbo_agregados.SelectedValue);
				lista_ingredientes.SetItemChecked(0,true);
			}
			
		}
		
		//SACA INGREDIENTES MARCADOS
		private void Btn_quitar_ingredienteClick(object sender, EventArgs e)
		{
			int lastIndex =lista_ingredientes.Items.Count-1;
			for(int i=lastIndex ; i>=0 ; i--)
			{
			    if (lista_ingredientes.GetItemCheckState(i) != CheckState.Checked)
			    {
			             lista_ingredientes.Items.RemoveAt(i);
			    }
			}
		}
		
		//CREA UN ARTICULO
		private void Btn_listo_ingredienteClick(object sender, EventArgs e)
		{
			if(lista_ingredientes.Items.Count>0)
			{
				//aumenta el contador
				base_datos con = new base_datos();
				con.update("UPDATE alternativa SET contador = 1+"+tb_contador_pedido.Text+" WHERE id = "+tb_id_pedido.Text);
				
				//agrega pedido
				string elementos;
				elementos = tb_nombre_pedido.Text+":";
				
				precio_total_orden_valor += Int32.Parse( tb_precio_espera.Text );
				foreach(object item in lista_ingredientes.CheckedItems)
				{
					string[] aux = item.ToString().Split('-');
					elementos = elementos + aux[0]+", " ;
					precio_total_orden_valor += Int32.Parse(aux[1]);
					actualizar_precio_pedido(precio_total_orden_valor);
				}
				
				orden_lista_pedidos.Text += string.Format("\n{0} ({1}) ", " ", elementos, Environment.NewLine );
				
				lista_pedidos_armado.Items.Insert(0,elementos);
				lista_pedidos_armado.SetItemChecked(0,true);
			}
			lista_ingredientes.Items.Clear();
		}
		
		//LLAMA FORM PARA CREAR NUEVO CLIENTE
		void Btn_nuevoclienteClick(object sender, EventArgs e)
		{
			nuevo_cliente aux = new nuevo_cliente();
			aux.Show();
		}
		
		//LIMPIA LAS LISTAS DE INGREDIENTES, PRECIOS Y PEDIDOS
		void Btn_limpiar_todoClick(object sender, EventArgs e)
		{
			//resta contador a item
			foreach (object item in lista_pedidos_armado.SelectedItems )
			{
				string[] pedido;
				pedido = item.ToString().Split(':');
				base_datos con = new base_datos();
				
				string contador = con.consulta_dato("SELECT contador FROM alternativa WHERE nombre = '"+pedido[0]+"'");
				
				con.update("UPDATE alternativa SET contador = "+contador+"-1 WHERE nombre = '"+pedido[0]+"'");
				
			}
			
			//limpia todo
			lista_ingredientes.Items.Clear();
			lista_pedidos_armado.Items.Clear();
			tb_precio_espera.Text = "0";
			label_precio_total.Text = "0";
			label_precio_total2.Text = "0";
			label_precio_total3.Text = "0";
			label_precio_real.Text = "0";
			precio_total_orden_valor = 0;
			orden_lista_pedidos.Text = "";
		}
		
		//CLICK SOBRE TABLA CLIENTES
		void Data_clienteCellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if(e.RowIndex>=0)//existen elementos
			{
				DataGridViewRow row = data_cliente.Rows[e.RowIndex];//total filas
				
				//apellido, nombre, ciudad, direccion, fono1, fono2, comentario
				string id,nombre,apellido,direccion,fono1,fono2;
				
				apellido = row.Cells[0].Value.ToString();//columna apellido cliente
				nombre = row.Cells[1].Value.ToString();//columna nombre cliente
				direccion = row.Cells[2].Value.ToString();//columna direccion cliente
				fono1 = row.Cells[3].Value.ToString();//columna fono1 cliente
				fono2 = row.Cells[4].Value.ToString();//columna fono2 cliente
				id = row.Cells[5].Value.ToString();//columna id cliente
					
				orden_nombrecliente.Text = nombre+" "+apellido;
				orden_telefonocliente.Text = fono1+" - "+fono2;
				orden_direcioncliente.Text = direccion;
				orden_idcliente.Text = id;
				TabPrincipal.SelectedTab = tabOrden;
				
				if(rb_efectivo.Checked)
					vuelto_cliente.Text = (Int32.Parse(num_efectivo_cliente.Text) - Int32.Parse(label_precio_total2.Text)).ToString();
			}
		}
		
		//CLICK SOBRE TABLA DE PRODUCTOS PRE-ARMADOS
		void Data_baseCellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if(e.RowIndex>=0)//existen elementos
			{
				//id, nombre, ingredientes,precio
				const int index_ingrediente = 2;
				const int index_precio = 3;
				
				lista_ingredientes.Items.Clear();//limia la lista de ingredientes
				
				DataGridViewRow row = data_base.Rows[e.RowIndex];//total filas
				
				//guardamos id pedido
				tb_id_pedido.Text = row.Cells["id"].Value.ToString();
				
				//guardamos nombre pedido
				tb_nombre_pedido.Text = row.Cells["nombre"].Value.ToString();
				
				//guardamos contador
				tb_contador_pedido.Text = row.Cells["contador"].Value.ToString();
				
				string todo = row.Cells[index_ingrediente].Value.ToString();//columna de la consulta que usaremos
				string[] partes = todo.Split('-');//divide cadena con los ingredientes
				
				tb_precio_espera.Text = row.Cells[index_precio].Value.ToString();
				
				//ingresa cada ingrediente de una alternativa
				foreach(string ele in partes)
				{
					lista_ingredientes.Items.Insert(0,ele+"-0");
					lista_ingredientes.SetItemChecked(0,true);
				}
			}
		}
		
		//salir form
		void Btn_salirClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		//consulta
		void Btn_filtrar_clienteClick(object sender, EventArgs e)
		{
			
			base_datos conexionbd;
			conexionbd = new base_datos();
			
			string query;
			query = "SELECT nombre, apellido, ciudad, direccion, fono1, fono2, comentario FROM cliente WHERE id_cliente <> NULL " ;
			
			if(cliente_filtro_nombre.Text != "")
				query += " AND nombre  LIKE '%"+cliente_filtro_nombre.Text+"%' ";
			
			if(cliente_filtro_nombre.Text != "")
				query += " OR apellido LIKE '%"+cliente_filtro_nombre.Text+"%' ";
			
			if(cliente_filtro_nombre.Text != "")
				query += " OR direccion LIKE '%"+cliente_filtro_nombre.Text+"%' ";
			
			if(cliente_filtro_nombre.Text != "")
				query += " OR fono1 = '"+cliente_filtro_nombre.Text+"' OR fono2 = '"+cliente_filtro_nombre.Text+"' ";
			
			query += " ORDER BY apellido";
			
			conexionbd.Actualizar_malla(data_cliente, query);
		}
		
		//actualiza lista clientes
		void Btn_actualizar_clientesClick(object sender, EventArgs e)
		{
			cargar_clientes();
		}
		
		//crea la orden
		void Btn_generar_pedidoClick(object sender, EventArgs e)
		{
			if(orden_nombrecliente.Text!="" && orden_telefonocliente.Text!="" && orden_direcioncliente.Text!="" && orden_idcliente.Text!="" && orden_lista_pedidos.Text!="")
			{
				string mediopago;
				if(rb_efectivo.Checked)
					mediopago = "EFECTIVO";
				else
					mediopago = "CREDITO";
				
				base_datos conexionbd;
				conexionbd = new base_datos();
			
				//variables tiempo
				DateTime ahora = DateTime.Now;
				string hora = String.Format("{0:HH:mm:ss}", ahora);
				string fecha = String.Format("{0:dd/MM/yyyy}", ahora);
				
				if(id_caja == string.Empty)
				{
					id_caja = conexionbd.consulta_dato("SELECT MAX(id_caja) FROM caja WHERE estado = 'ABIERTO' ");
				}
				
				//query
				string query;
				query  = " INSERT INTO orden (id_cliente , rut_vendedor, total, fecha, hora, pedido, direccion, fono, descuento, mediopago, id_caja)";
				query += " VALUES ( "+orden_idcliente.Text+" , '"+orden_rut_vendedor.Text+"' , '"+label_precio_total2.Text+"' , '"+fecha+"' , '"+hora+"' , '"+orden_lista_pedidos.Text+"', '"+orden_direcioncliente.Text+"', '"+orden_telefonocliente.Text+"', "+num_descuento.Value+",'"+mediopago+"', "+id_caja+")";
				conexionbd.update(query);
				
				//actualiza flujo caja
				flujo_caja(Int32.Parse(label_precio_total2.Text),id_caja);
				
				/*impresion PrintReceipt(bool cocina, bool caja, bool repartidor)*/
				PrintReceipt(true, true, true);
				//PrintReceipt(false,true,false);
				this.Close();
			}
			else
				MessageBox.Show("Llene los campos obligatorios (*).");
		}

		//boleta caja----------------------------------------------------------------------------
		void caja_PrintPage(object sender, PrintPageEventArgs e)
		{
			MessageBox.Show("boleta caja: alto="+hoja_alto+" ancho="+hoja_ancho+" ");
			
			Graphics graphic = e.Graphics;
			StringFormat sf = new StringFormat();
			sf.LineAlignment = StringAlignment.Center;
			sf.Alignment = StringAlignment.Center;
			
			float fontHeight = font1.GetHeight();
			int startX = 10;
			int startY = 10;
			int offset = 20;
			
			//datos boleta
			string datos = System.IO.Directory.GetCurrentDirectory()+@"\config.cfg";
			
			if(System.IO.File.Exists(datos))
			{
				cargar_config aux = new cargar_config();
				aux.guarda_variables(@"\config.cfg");
				
				//logo
				if(System.IO.File.Exists(System.IO.Directory.GetCurrentDirectory()+@"\lib\resources\logo_boleta.ico") )
				{
					// Create image.
				    Image newImage = Image.FromFile(System.IO.Directory.GetCurrentDirectory()+@"\lib\resources\logo_boleta.ico");
				
				    // Create rectangle for displaying image.
				    int alto = 80+startY/2;
				    int ancho = 80+startY/2;
				    
				    Rectangle destRect = new Rectangle(98, 0, alto, ancho);
				    
				    // Create rectangle for source image.
				    Rectangle srcRect = new Rectangle(50, 50, 150, 150);
				    
				    GraphicsUnit units = GraphicsUnit.Pixel;
				
				    // Draw image to screen.
				    graphic.DrawImage(newImage, destRect, srcRect, units);
					offset += 50;
				}
				else//nombre
				{
					graphic.DrawString(aux.get_nombre_empresa().PadLeft(5), font4, new SolidBrush(Color.Black), startX, startY+offset);
					offset += (int)fontHeight +5;
					
				}
				graphic.DrawString(aux.get_direccion().PadLeft(5), font4, new SolidBrush(Color.Black), startX, startY+offset);
				offset += (int)fontHeight +2;
				graphic.DrawString(aux.get_fono().PadLeft(4), font4, new SolidBrush(Color.Black), startX, startY+offset);
				offset += (int)fontHeight +2;
				graphic.DrawString(aux.get_web().PadLeft(5), font4, new SolidBrush(Color.Black), startX, startY+offset);
				offset += (int)fontHeight +15;
			}
			else
			{
				graphic.DrawString("VERSION PIRATA", font4, new SolidBrush(Color.Black), startX, startY+offset);
				offset += (int)fontHeight +2;
				graphic.DrawString("INGRESE LICENCIA", font4, new SolidBrush(Color.Black), startX, startY+offset);
				offset += (int)fontHeight +2;
				graphic.DrawString("FONO: 79207762", font4, new SolidBrush(Color.Black), startX, startY+offset);
				offset += (int)fontHeight +2;
				graphic.DrawString("SIN WEB", font4, new SolidBrush(Color.Black), startX, startY+offset);
				offset += (int)fontHeight +15;
			}
			
			
			graphic.DrawString("Fecha".PadRight(10)+DateTime.Now.ToShortDateString()+" "+DateTime.Now.ToShortTimeString(), font1, new SolidBrush(Color.Black), startX, startY+offset);
			offset += (int)fontHeight +2;
			graphic.DrawString("Nro".PadRight(10)+orden_cb_nro_orden.Text, font1, new SolidBrush(Color.Black), startX, startY+offset);
			offset += (int)fontHeight +2;
			graphic.DrawString("Vendedor".PadRight(10)+orden_nombre_vendedor.Text, font1, new SolidBrush(Color.Black), startX, startY+offset);
			offset += (int)fontHeight +2;
			graphic.DrawString("Cliente".PadRight(10)+orden_nombrecliente.Text, font1, new SolidBrush(Color.Black), startX, startY+offset);
			offset += (int)fontHeight +2;
			graphic.DrawString("Pedido", font1, new SolidBrush(Color.Black), startX, startY+offset);
			
			if(lista_pedidos_armado.Items.Count>0)
			{
				
				offset += ((int)fontHeight +2);
				
				foreach(object item in lista_pedidos_armado.CheckedItems)
				{
					MessageBox.Show("-"+item.ToString());
					
					int count =(int)(item.ToString().Length/35) ;
					
					graphic.DrawString("-"+item.ToString(), font1, new SolidBrush(Color.Black), new Rectangle(startX, startY+offset, 290, (int)fontHeight + (int)fontHeight*(count+1)));
                    
					offset +=( (int)fontHeight + 2)*count;
					offset += (int)fontHeight + 2;
				}
				
			}
			
			offset += (int)font1.Height * 2;
			
			graphic.DrawString("TOTAL".PadRight(30)+label_precio_total2.Text, font1, new SolidBrush(Color.Black), startX, startY+offset);
			offset += (int)fontHeight +2;
			
			graphic.DrawString("efectivo".PadRight(30)+num_efectivo_cliente.Value.ToString(), font1, new SolidBrush(Color.Black), startX, startY+offset);
			offset += (int)fontHeight +2;
			
			graphic.DrawString("Vuelto".PadRight(30)+vuelto_cliente.Text, font1, new SolidBrush(Color.Black), startX, startY+offset);
			offset += (int)fontHeight*3;
			
			graphic.DrawString(" ", font1, new SolidBrush(Color.Black), startX, startY+offset);
			
		}
		
		//boleta cocina--------------------------------------------------------------------------
		void cocina_PrintPage(object sender, PrintPageEventArgs e)
		{
			Graphics graphic =e.Graphics;
			float fontHeight = font1.GetHeight();
			int startX = 10;
			int startY = 10;
			int offset = 5;
			
			//datos boleta
			string datos;
			datos = System.IO.Directory.GetCurrentDirectory()+@"\config.cfg";
			
			if(System.IO.File.Exists(datos))
			{
				cargar_config aux = new cargar_config();
				aux.guarda_variables(@"\config.cfg");
				
				graphic.DrawString(aux.get_nombre_empresa().PadLeft(5), font4, new SolidBrush(Color.Black), startX, startY+offset);
				offset += (int)fontHeight +2;
				graphic.DrawString("Copia Cocina".PadLeft(5), font4, new SolidBrush(Color.Black), startX, startY+offset);
				offset += (int)fontHeight +2;
				graphic.DrawString("------------------------------------".PadLeft(5), font4, new SolidBrush(Color.Black), startX, startY+offset);
				offset += (int)fontHeight +2;
			}
			else
			{
				graphic.DrawString("VERSION PIRATA".PadLeft(5), font4, new SolidBrush(Color.Black), startX, startY+offset);
				offset += (int)fontHeight +2;
				graphic.DrawString("INGRESE LICENCIA".PadLeft(5),font4, new SolidBrush(Color.Black), startX, startY+offset);
				offset += (int)fontHeight +2;
				graphic.DrawString("79207762".PadLeft(5), font4, new SolidBrush(Color.Black), startX, startY+offset);
				offset += (int)fontHeight +2;
				graphic.DrawString("SIN WEB".PadLeft(5), font4, new SolidBrush(Color.Black), startX, startY+offset);
				offset += (int)fontHeight +15;
			}
			
			
			graphic.DrawString("Fecha".PadRight(10)+DateTime.Now.ToShortDateString()+" "+DateTime.Now.ToShortTimeString(), font1, new SolidBrush(Color.Black), startX, startY+offset);
			offset += (int)fontHeight +2;
			graphic.DrawString("Nro".PadRight(10)+orden_cb_nro_orden.Text, font1, new SolidBrush(Color.Black), startX, startY+offset);
			offset += (int)fontHeight +2;
			graphic.DrawString("Cliente".PadRight(10)+orden_nombrecliente.Text, font1, new SolidBrush(Color.Black), startX, startY+offset);
			offset += (int)fontHeight +2;
			graphic.DrawString("Pedido".PadRight(6)+orden_lista_pedidos.Text, font1, new SolidBrush(Color.Black), startX, startY+offset);
			
			if(lista_pedidos_armado.Items.Count>0)
			{
				
				offset += ((int)fontHeight +2);
				
				foreach(object item in lista_pedidos_armado.CheckedItems)
				{
					MessageBox.Show("-"+item.ToString());
					
					int count =(int)(item.ToString().Length/35) ;
					
					graphic.DrawString("-"+item.ToString(), font1, new SolidBrush(Color.Black), new Rectangle(startX, startY+offset, 290, (int)fontHeight + (int)fontHeight*(count+1)));
                    
					offset +=( (int)fontHeight + 2)*count;
					offset += (int)fontHeight + 2;
				}
				
			}
				
		}
		
		//boleta repartidor----------------------------------------------------------------------
		void repartidor_PrintPage(object sender, PrintPageEventArgs e)
		{
			Graphics graphic =e.Graphics;
			float fontHeight = font1.GetHeight();
			int startX = 10;
			int startY = 10;
			int offset = 0;
			
			//datos boleta
			string datos;
			datos = System.IO.Directory.GetCurrentDirectory()+@"\config.cfg";
			
			if(System.IO.File.Exists(datos))
			{
				cargar_config aux = new cargar_config();
				aux.guarda_variables(@"\config.cfg");
				
				graphic.DrawString(aux.get_nombre_empresa(), font1, new SolidBrush(Color.Black), startX, startY+offset);
				offset += (int)fontHeight +2;
				graphic.DrawString(aux.get_direccion(), font1, new SolidBrush(Color.Black), startX, startY+offset);
				offset += (int)fontHeight +2;
				graphic.DrawString(aux.get_fono(), font1, new SolidBrush(Color.Black), startX, startY+offset);
				offset += (int)fontHeight +2;
				graphic.DrawString(aux.get_web(), font1, new SolidBrush(Color.Black), startX, startY+offset);
				offset += (int)fontHeight +15;
			}
			else
			{
				graphic.DrawString("VERSION PIRATA", font1, new SolidBrush(Color.Black), startX, startY+offset);
				offset += (int)fontHeight +2;
				graphic.DrawString("INGRESE LICENCIA SOFTWARE", font1, new SolidBrush(Color.Black), startX, startY+offset);
				offset += (int)fontHeight +2;
				graphic.DrawString("LLAME AL 79207762", font1, new SolidBrush(Color.Black), startX, startY+offset);
				offset += (int)fontHeight +2;
				graphic.DrawString("SIN WEB", font1, new SolidBrush(Color.Black), startX, startY+offset);
				offset += (int)fontHeight +15;
			}
			
			graphic.DrawString("Fecha".PadRight(10)+DateTime.Now.ToShortDateString()+" "+DateTime.Now.ToShortTimeString(), font1, new SolidBrush(Color.Black), startX, startY+offset);
			offset += (int)fontHeight +2;
			graphic.DrawString("Nro".PadRight(10)+orden_cb_nro_orden.Text, font1, new SolidBrush(Color.Black), startX, startY+offset);
			offset += (int)fontHeight +2;
			graphic.DrawString("Vendedor".PadRight(10)+orden_nombre_vendedor.Text,font1, new SolidBrush(Color.Black), startX, startY+offset);
			offset += (int)fontHeight +2;
			graphic.DrawString("Cliente".PadRight(10)+orden_nombrecliente.Text, font1, new SolidBrush(Color.Black), startX, startY+offset);
			offset += (int)fontHeight +2;
			graphic.DrawString("Direccion".PadRight(10)+orden_direcioncliente.Text, font1, new SolidBrush(Color.Black), startX, startY+offset);
			offset += (int)fontHeight +20;
			
			graphic.DrawString("TOTAL".PadRight(30)+label_precio_total2.Text, font1, new SolidBrush(Color.Black), startX, startY+offset);
			offset += (int)fontHeight +2;
			graphic.DrawString("efectivo".PadRight(30)+num_efectivo_cliente.Value.ToString(), font1, new SolidBrush(Color.Black), startX, startY+offset);
			offset += (int)fontHeight +2;
			graphic.DrawString("Vuelto".PadRight(30)+vuelto_cliente.Text, font1, new SolidBrush(Color.Black), startX, startY+offset);
			offset += (int)fontHeight +5;
			
			
		}
		
		//seleccion de imprecion
		private void PrintReceipt(bool cocina, bool caja, bool repartidor)
		{
			PrintDialog printDialog = new PrintDialog();
			
			DialogResult result = printDialog.ShowDialog();
			if(result == DialogResult.OK)
			{
				if(caja)
				{	
					PrintDocument printDocument = new PrintDocument();
					printDialog.Document = printDocument;
					printDocument.DefaultPageSettings.PaperSize =new PaperSize("boleta", hoja_ancho,hoja_alto);
					printDocument.PrintPage += new PrintPageEventHandler(caja_PrintPage);
					printDocument.Print();
				}
				if(cocina)
				{
					PrintDocument printDocument = new PrintDocument();
					printDialog.Document = printDocument;
					printDocument.DefaultPageSettings.PaperSize =new PaperSize("boleta", hoja_ancho,hoja_alto);
					printDocument.PrintPage += new PrintPageEventHandler(cocina_PrintPage);
					printDocument.Print();
				}
				if(repartidor)
				{	
					PrintDocument printDocument = new PrintDocument();
					printDialog.Document = printDocument;
					printDocument.DefaultPageSettings.PaperSize =new PaperSize("boleta", hoja_ancho,hoja_alto);
					printDocument.PrintPage += new PrintPageEventHandler(repartidor_PrintPage);
					printDocument.Print();
				}
			}
		}
		
		//actualiza ingreso a caja
		private void flujo_caja(int entrada,string id)
		{
			base_datos con = new base_datos();
			
			string flujo;
			flujo = con.consulta_dato("SELECT flujo FROM caja WHERE id_caja="+id);
			int total = Int32.Parse(flujo) + entrada;
			string query;
			query = "UPDATE caja SET flujo = "+total+" WHERE id_caja = "+id;
			con.update(query);
			
		}
		
		//activar descuento
		void Button3Click(object sender, EventArgs e)
		{
			int precioaux = 0;
			precioaux = (int)(Int32.Parse(label_precio_real.Text) - Int32.Parse(label_precio_real.Text) * (num_descuento.Value / 100));
			label_precio_total2.Text =  precioaux.ToString();
			label_precio_total3.Text =  precioaux.ToString();
			
			if(rb_efectivo.Checked)
				vuelto_cliente.Text = (Int32.Parse(num_efectivo_cliente.Text) - Int32.Parse(label_precio_total2.Text)).ToString();
			
		}
		
		//deshacer descuento
		void Button4Click(object sender, EventArgs e)
		{
			num_descuento.Value = 0;
			label_precio_total2.Text = label_precio_real.Text;
			label_precio_total3.Text = label_precio_real.Text;
		}
		
		//se marca efectivo
		void Rb_efectivoCheckedChanged(object sender, EventArgs e)
		{
			num_efectivo_cliente.Enabled = true;
			vuelto_cliente.Text = (Int32.Parse(num_efectivo_cliente.Text) - Int32.Parse(label_precio_total2.Text)).ToString();
		}
		
		//se marca credito
		void Rb_tarjetaCheckedChanged(object sender, EventArgs e)
		{
			num_efectivo_cliente.Enabled = false;
			vuelto_cliente.Text = "0";
			num_efectivo_cliente.Value = Int32.Parse(label_precio_total2.Text);
		}
		
		//1click cliente
		void Data_clienteCellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if(e.RowIndex>=0)//existen elementos
			{
				DataGridViewRow row = data_cliente.Rows[e.RowIndex];//total filas
				
				//apellido, nombre, ciudad, direccion, fono1, fono2, comentario
				string id,nombre,apellido,direccion,fono1,fono2;
				
				apellido = row.Cells[0].Value.ToString();//columna apellido cliente
				nombre = row.Cells[1].Value.ToString();//columna nombre cliente
				direccion = row.Cells[2].Value.ToString();//columna direccion cliente
				fono1 = row.Cells[3].Value.ToString();//columna fono1 cliente
				fono2 = row.Cells[4].Value.ToString();//columna fono2 cliente
				id = row.Cells[5].Value.ToString();//columna id cliente
					
				orden_nombrecliente.Text = nombre+" "+apellido;
				orden_telefonocliente.Text = fono1+" - "+fono2;
				orden_direcioncliente.Text = direccion;
				orden_idcliente.Text = id;
				
				if(rb_efectivo.Checked)
					vuelto_cliente.Text = (Int32.Parse(num_efectivo_cliente.Text) - Int32.Parse(label_precio_total2.Text)).ToString();
			}
		}
		
	}
}
