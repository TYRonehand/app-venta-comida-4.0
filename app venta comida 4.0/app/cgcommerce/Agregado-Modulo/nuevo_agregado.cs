/*
 * Created by SharpDevelop.
 * User: ratondepc
 * Date: 15/09/2015
 * Time: 1:14
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;
using cgcommerce.Agregado_Modulo;
using cgcommerce.herramientas;

namespace cgcommerce
{
	public partial class nuevo_agregado : Form
	{
		private int id_row=-1;
		
		public nuevo_agregado()
		{
			InitializeComponent();
			form_center_screen();
			cargar_agregados();
		}
		
		//centra la form al centro
		private void form_center_screen()
		{
			this.TopMost = true;
			this.Location = new System.Drawing.Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
                          (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
		}
		
		//carga listado de agregados 
		private void cargar_agregados()
		{
			base_datos conexionbd;
			conexionbd = new base_datos();
			
			string query;
			query = "SELECT id_agregado as oid, nombre, precio, disponible FROM agregado ORDER BY nombre";
			conexionbd.Actualizar_malla(agregado_dgv_listado, query);
		}
		
		void hoverButton(object sender, EventArgs e)
		{
			System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
			Button aux = (Button)sender;
			ToolTip1.SetToolTip(aux , aux.AccessibleDescription.ToString());
		}
		
		void Btn_salirClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void Btn_agregarClick(object sender, EventArgs e)
		{
			datos_agregado aux = new datos_agregado();
			aux.Show();
		}
		
		void Agregado_dgv_listadoCellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			//carga form
			datos_agregado aux = new datos_agregado();
			
			//carga elemento del datagrid seleccionado
			DataGridViewRow row = agregado_dgv_listado.Rows[e.RowIndex];
			
			//pasamos datos al nuevo form
			string id = row.Cells[0].Value.ToString();
			string nombre = row.Cells[1].Value.ToString();
			string precio = row.Cells[2].Value.ToString();
			string disponible = row.Cells[3].Value.ToString();
			
			//abre form
			aux.Show();	
			aux.cargar_datos("actualizar", nombre, precio, disponible, id);
			
		}
		void Btn_refreshClick(object sender, EventArgs e)
		{
			cargar_agregados();
		}
		void Btn_cancelarClick(object sender, EventArgs e)
		{
			this.Close();
		}
		void Btn_eliminarClick(object sender, EventArgs e)
		{
			if(agregado_dgv_listado.RowCount>0)
			{
				if(id_row!=-1)
				{
					var closeMsg = MessageBox.Show( "Eliminar Agregado?", "Advertencia!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question );
					if (closeMsg == DialogResult.Yes) 
					{
							DataGridViewRow row = agregado_dgv_listado.Rows[id_row];//total filas
							
							//eliminar
							base_datos conexionbd = new base_datos();
							
							string query ="DELETE FROM agregado WHERE id_agregado = "+row.Cells[0].Value.ToString()+" ";
							conexionbd.update(query);
					}
				}
				else
					MessageBox.Show("Selecione un agregado");
			}
			else
				MessageBox.Show("No Existen Agregados");
			
			//liveramos linea del cliente
			id_row=-1;
		}
		void Agregado_dgv_listadoCellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			id_row = e.RowIndex;
		}
	}
}
