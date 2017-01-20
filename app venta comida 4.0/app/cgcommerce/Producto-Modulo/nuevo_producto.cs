/*
 * Created by SharpDevelop.
 * User: Carlos Gutierrez Acevedo
 * Date: 15/09/2015
 * Time: 1:19
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using cgcommerce.herramientas;

namespace cgcommerce
{
	public partial class nuevo_producto : Form
	{
		
		public nuevo_producto()
		{
			InitializeComponent();
			form_center_screen();
			cargar_agregado();
		}
		//centra la form al centro
		private void form_center_screen()
		{
			this.TopMost = true;
			this.Location = new System.Drawing.Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
                          (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
		}
		private void cargar_agregado() 
		{
			
			base_datos conexionbd;
			conexionbd = new base_datos();
			
			//producto_dgv_agregados
			conexionbd.Actualizar_malla(producto_dgv_agregados, "SELECT nombre FROM agregado");
		}
		
		//cierrra el form
		void Btn_cancelarClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void Producto_btn_limpiarClick(object sender, EventArgs e)
		{
			producto_lb_ingredientes.Items.Clear();
			producto_tb_nombre.Text = "";
			producto_num_precio.Value = 0;
		}
		
		void Producto_dgv_agregadosCellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if(e.RowIndex>=0)//existen elementos
			{
				
				//producto_lb_ingredientes.Items.Clear();//limia la lista de ingredientes
				
				DataGridViewRow row = producto_dgv_agregados.Rows[e.RowIndex];//total filas
				
				string todo = row.Cells[0].Value.ToString();//columna de la consulta que usaremos
				
				//ingresa cada ingrediente de una alternativa
				producto_lb_ingredientes.Items.Insert(0, todo);
				producto_lb_ingredientes.SetItemChecked(0,true);
			
			}
		}
		
		void FusionButton1Click(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void Producto_btn_agregarClick(object sender, EventArgs e)
		{
			string ingredientes = string.Empty;
			
			foreach(object itemChecked in producto_lb_ingredientes.CheckedItems)
				ingredientes += itemChecked.ToString()+"-";
			
			string query = " INSERT INTO alternativa (nombre, ingredientes, precio, disponible)";
			query       += " VALUES ('"+producto_tb_nombre.Text+"', '"+ingredientes+"', '"+producto_num_precio.Value.ToString()+"', "+producto_num_disponible.Value.ToString()+")";
		
			base_datos conexionbd = new base_datos();
			conexionbd.update(query);
			this.Close();
		}
		
	}
}
