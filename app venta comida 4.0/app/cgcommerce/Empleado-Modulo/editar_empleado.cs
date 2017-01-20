/*
 * Created by SharpDevelop.
 * User: ratondepc
 * Date: 15/09/2015
 * Time: 1:05
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;
using cgcommerce.herramientas;

namespace cgcommerce
{
	public partial class editar_empleado : Form
	{
		private base_datos conexionbd;
		private int id_cliente_registro;
		
		public editar_empleado(int id_usuario,string nombre, string apellido,string rut,string correo,string pass,string fono,string nacimiento)
		{
			conexionbd = new base_datos();
			InitializeComponent();
		
			form_center_screen();
			
			id_cliente_registro = id_usuario;
			nc_tb_nombre.Text = nombre;
			nc_tb_apellido.Text = apellido;
			nc_tb_rut.Text = rut;
			nc_tb_pass.Text = pass;
			nc_tb_fono.Text = fono;
			nc_tb_email.Text = correo;
			
		}
		//centra la form al centro
		private void form_center_screen()
		{
			this.TopMost = true;
			this.Location = new System.Drawing.Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
                          (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
		}
		//editar ARREGLAR!!!!
		void Btn_agregarClick(object sender, EventArgs e)
		{
			if(nc_tb_nombre.Text !="" && nc_tb_apellido.Text!="" && nc_tb_rut.Text!="" && nc_tb_email.Text!="" && nc_tb_fono.Text!="")
			{
				string query;
				query = " UPDATE trabajador "+
					" SET nombre = '"+nc_tb_nombre.Text+"' , apellido = '"+nc_tb_apellido.Text+"' , rut = UCase('"+nc_tb_rut.Text+"'), correo = '"+nc_tb_email.Text+"', fono = '"+nc_tb_fono.Text+"' , pass = '"+nc_tb_pass.Text+"' WHERE id_usuario = "+id_cliente_registro;
				
				conexionbd.update(query);
				this.Close();
			}
			else
				MessageBox.Show("Llene los campos obligatorios (*).");
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
	}
}
