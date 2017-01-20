/*
 * Created by SharpDevelop.
 * User: Carlos Gutierrez Acevedo
 * Date: 25/09/2015
 * Time: 2:05
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;
using cgcommerce.herramientas;

namespace cgcommerce.Producto_Modulo
{
	
	public partial class productos : Form
	{
		private base_datos conexionbd;
		private int id_row=-1;
		
		public productos()
		{
			InitializeComponent();
			conexionbd = new base_datos();
			form_center_screen();
			cargar_producto();
		}
		
		//centra la form al centro
		private void form_center_screen()
		{
			this.TopMost = true;
			this.Location = new System.Drawing.Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
                          (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
		}
		
		//esta carga productos en la malla
		private void cargar_producto() 
		{
			//producto_producto_dgv_prod
			conexionbd.Actualizar_malla(producto_dgv_prod, "select id, nombre, ingredientes from alternativa");
			
		}
		
		//seleccion de elemento
		void Producto_dgv_prodCellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			id_row = e.RowIndex;
		}
		
		void Producto_btn_agregarClick(object sender, EventArgs e)
		{
			nuevo_producto aux = new nuevo_producto();
			aux.ShowDialog(this);
		}
		
		//Cerrar Ventana
		void FusionButton1Click(object sender, EventArgs e)
		{
			this.Close();
		}
		//eliminar elemento
		void Producto_btn_borrarClick(object sender, EventArgs e)
		{
			if(producto_dgv_prod.RowCount>0)
			{
				if(id_row!=-1)
				{
					var closeMsg = MessageBox.Show( "Eliminar Producto?", "Advertencia!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question );
					if (closeMsg == DialogResult.Yes) 
					{
							DataGridViewRow row = producto_dgv_prod.Rows[id_row];//total filas
							
							//eliminar
							base_datos conexionbd = new base_datos();
							
							string query =" DELETE FROM alternativa WHERE id = "+row.Cells[0].Value.ToString()+" ";
							conexionbd.update(query);
					}
				}
				else
					MessageBox.Show("Selecione un producto");
			}
			else
				MessageBox.Show("No Existen productos");
			
			//liveramos linea del cliente
			id_row=-1;
		}
		
		void Btn_cancelarClick(object sender, EventArgs e)
		{
			this.Close();
		}
		void Btn_refreshClick(object sender, EventArgs e)
		{
			cargar_producto() ;
		}
	}
}
