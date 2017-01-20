/*
 * Created by SharpDevelop.
 * User: ratondepc
 * Date: 10/09/2015
 * Time: 0:23
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using cgcommerce.herramientas;

namespace cgcommerce
{
	
	public partial class clientes : Form
	{
		private string nombre,apellido,ciudad,direccion,fono1,fono2,comentario;
		private	int id_row = -1, id_cliente;
		
		public clientes()
		{
			InitializeComponent();
			carga_cliente();
			form_center_screen();
		}
		//centra la form al centro
		private void form_center_screen()
		{
			this.TopMost = true;
			this.Location = new System.Drawing.Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
                          (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
		}
		
		//cargar datos de clientes
		void carga_cliente()
		{
			base_datos conexionbd;
			conexionbd = new base_datos();
			
			string query;
			query = "SELECT id_cliente as id, nombre, apellido, ciudad, direccion, fono1, fono2, comentario FROM cliente";
			conexionbd.Actualizar_malla(Agenda_dgv_todos_clientes, query);
			Agenda_dgv_todos_clientes.Font= new Font("Tahoma",8, FontStyle.Regular);
		}
		
		//crear nuevo cliente
		void Btn_nuevo_clienteClick(object sender, EventArgs e)
		{
			nuevo_cliente aux = new nuevo_cliente();
			aux.Show();
		}
		
		//eliminar cliente seleccionado
		void Btn_eliminar_clienteClick(object sender, EventArgs e)
		{
			if(Agenda_dgv_todos_clientes.RowCount>0)
			{
				if(id_row!=-1)
				{
					var closeMsg = MessageBox.Show( "Eliminar Usuario?", "Advertencia!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question );
					if (closeMsg == DialogResult.Yes) 
					{
							DataGridViewRow row = Agenda_dgv_todos_clientes.Rows[id_row];//total filas
							
							//id del cliente que se eliminara
							id_cliente = Int32.Parse(row.Cells[0].Value.ToString());//columna apellido cliente
							//eliminar
							
							base_datos conexionbd;
							conexionbd = new base_datos();
							string query ="DELETE FROM cliente WHERE id_cliente = "+id_cliente+" ";
							conexionbd.update(query);
							
					}
				}
				else
					MessageBox.Show("Selecione un usuario");
			}
			else
				MessageBox.Show("No Existen Usuarios");
			
			//liveramos linea del cliente
			id_row=-1;
		}
		
		//tooltip
		void hoverButton(object sender, EventArgs e)
		{
			System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
			Button aux = (Button)sender;
			ToolTip1.SetToolTip(aux , aux.AccessibleDescription.ToString());
		}
		
		//cerrar ventana
		private void FusionButton1Click(object sender, EventArgs e)
		{
			this.Close();
		}
		
		//doble click en cliente
		private void Agenda_dgv_todos_clientesCellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			//liberamos fila del usuario
			id_row = -1;
			
			//leemos la fila con datos seleccionados
			id_cliente = Int32.Parse(Agenda_dgv_todos_clientes.Rows[e.RowIndex].Cells[0].Value.ToString());
            nombre = Agenda_dgv_todos_clientes.Rows[e.RowIndex].Cells[1].Value.ToString();
            apellido = Agenda_dgv_todos_clientes.Rows[e.RowIndex].Cells[2].Value.ToString();
            ciudad = Agenda_dgv_todos_clientes.Rows[e.RowIndex].Cells[3].Value.ToString();
            direccion = Agenda_dgv_todos_clientes.Rows[e.RowIndex].Cells[4].Value.ToString();
            fono1 = Agenda_dgv_todos_clientes.Rows[e.RowIndex].Cells[5].Value.ToString();
            fono2 = Agenda_dgv_todos_clientes.Rows[e.RowIndex].Cells[6].Value.ToString();
            comentario = Agenda_dgv_todos_clientes.Rows[e.RowIndex].Cells[7].Value.ToString();
			
			//llamamos al editor
			editar_cliente aux = new editar_cliente(id_cliente,nombre,apellido,ciudad,direccion,fono1,fono2,comentario);
			aux.Show();
			carga_cliente();
		}
		
		//filtrar cliente
		void Btn_buscar_clienteClick(object sender, EventArgs e)
		{
			carga_cliente();
		}
		void Agenda_dgv_todos_clientesCellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			id_row = e.RowIndex;
		}
		void Btn_listoClick(object sender, EventArgs e)
		{
			this. Close();
		}
		
	}
}
