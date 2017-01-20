/*
 * Created by SharpDevelop.
 * User: ratondepc
 * Date: 24/09/2015
 * Time: 23:10
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;
using cgcommerce.herramientas;

namespace cgcommerce.Agregado_Modulo
{
	
	public partial class datos_agregado : Form
	{
		public string tipo = "insertar";
		private base_datos conexionbd;
		
		public datos_agregado()
		{
			InitializeComponent();
			form_center_screen();
			conexionbd = new base_datos();
		}
		//carga dato seleccionado de datagrid para actualizar
		public void cargar_datos(string tip, string nombre,string precio,string disp, string id)
		{
			this.cb_id.Text = id;
			this.tb_nombre.Text = nombre;
			this.tb_precio.Text = precio;
			this.nmu_disponible.Text = disp;
			this.tipo = tip;
		}
		
		//centra la form al centro
		private void form_center_screen()
		{
			this.TopMost = true;
			this.Location = new System.Drawing.Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
                          (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
		}
		
		//click agrega o actualiza elemento
		void Btn_agregarClick(object sender, EventArgs e)
		{
			
			if(tipo=="insertar")
			{
				//insertar
				if(tb_nombre.Text !="" && tb_precio.Text!=""  &&  nmu_disponible.Text!="")
				{
					string query;
					query = "INSERT INTO agregado (nombre,precio,disponible)" +
					"VALUES( '"+tb_nombre.Text+"' , '"+tb_precio.Text+"' , '"+nmu_disponible.Text+"');";
					
					conexionbd.update(query);
					
					this.Close();
				}
				else
					MessageBox.Show("Llene los campos obligatorios (*).");
			}
			else
			{
				//actualizar
				if(tb_nombre.Text !="" && tb_precio.Text!="" && cb_id.Text!="" &&  nmu_disponible.Text!="")
				{
					string query;
					query = " UPDATE agregado ";
					query +=" SET cantidad = 10 , nombre = '"+tb_nombre.Text+"' , precio = "+tb_precio.Text+" , disponible = "+nmu_disponible.Text+" ";
					query +=" WHERE id_agregado = "+cb_id.Text+" ";
					
					conexionbd.update(query);
					
					this.Close();
				}
				else
					MessageBox.Show("Llene los campos obligatorios (*).");
			
			}
		}
		//cierrra el form
		void Btn_cancelarClick(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
