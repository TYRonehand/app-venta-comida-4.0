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
	
	public partial class empleado : Form
	{
		private string nombre,apellido,rut,correo,pass,fono,nacimiento;
		private	int id_row = -1, id_empleado;
		
		public empleado()
		{
			InitializeComponent();
			carga_empleado();
			form_center_screen();
		}
		
		//centra la form al centro
		private void form_center_screen()
		{
			this.TopMost = true;
			this.Location = new System.Drawing.Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
                          (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
		}
		
		//cargar datos de empleados
		void carga_empleado()
		{
			base_datos conexionbd;
			conexionbd = new base_datos();
			
			string query;
			query = "SELECT id_usuario as id, rut, nombre, apellido, correo, pass, nacimiento, fono FROM trabajador WHERE tipo = 'NORMAL' ";
			conexionbd.Actualizar_malla(Agenda_dgv_todos_empleados, query);
			Agenda_dgv_todos_empleados.Font= new Font("Tahoma",8, FontStyle.Regular);
		}
		
		//crear nuevo empleado
		void Btn_nuevo_empleadoClick(object sender, EventArgs e)
		{
			nuevo_empleado aux = new nuevo_empleado();
			aux.Show();
		}
		
		//eliminar empleado seleccionado
		void Btn_eliminar_empleadoClick(object sender, EventArgs e)
		{
			if(Agenda_dgv_todos_empleados.RowCount>0)
			{
				if(id_row!=-1)
				{
					var closeMsg = MessageBox.Show( "Eliminar Usuario?", "Advertencia!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question );
					if (closeMsg == DialogResult.Yes) 
					{
							DataGridViewRow row = Agenda_dgv_todos_empleados.Rows[id_row];//total filas
							
							//id del empleado que se eliminara
							id_empleado = Int32.Parse(row.Cells[1].Value.ToString());//columna apellido empleado
							//eliminar
							
							base_datos conexionbd;
							conexionbd = new base_datos();
							string query ="DELETE FROM trabajador WHERE rut = '"+id_empleado+"' ";
							conexionbd.update(query);
							
					}
				}
				else
					MessageBox.Show("Selecione un usuario");
			}
			else
				MessageBox.Show("No Existen Usuarios");
			
			//liveramos linea del empleado
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
		
		//doble click en empleado
		private void Agenda_dgv_todos_empleadosCellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			//liberamos fila del usuario
			id_row = -1;
			
			//leemos la fila con datos seleccionados
			id_empleado = Int32.Parse(Agenda_dgv_todos_empleados.Rows[e.RowIndex].Cells[0].Value.ToString());
            rut = Agenda_dgv_todos_empleados.Rows[e.RowIndex].Cells[1].Value.ToString();
            nombre = Agenda_dgv_todos_empleados.Rows[e.RowIndex].Cells[2].Value.ToString();
            apellido = Agenda_dgv_todos_empleados.Rows[e.RowIndex].Cells[3].Value.ToString();
            correo = Agenda_dgv_todos_empleados.Rows[e.RowIndex].Cells[4].Value.ToString();
            pass = Agenda_dgv_todos_empleados.Rows[e.RowIndex].Cells[5].Value.ToString();
            nacimiento = Agenda_dgv_todos_empleados.Rows[e.RowIndex].Cells[6].Value.ToString();
            fono = Agenda_dgv_todos_empleados.Rows[e.RowIndex].Cells[7].Value.ToString();
			
			//llamamos al editor
			editar_empleado aux = new editar_empleado(id_empleado,nombre,apellido,rut,correo,pass,fono,nacimiento);
			aux.Show();
			carga_empleado();
		}
		
		//filtrar empleado
		void Btn_buscar_empleadoClick(object sender, EventArgs e)
		{
			carga_empleado();
		}
		void Agenda_dgv_todos_empleadosCellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			id_row = e.RowIndex;
		}
		
	}
}
