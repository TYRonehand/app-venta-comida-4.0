/*
 * Created by SharpDevelop.
 * User: carlos gutierrez acevedo
 * Date: 15/09/2015
 * Time: 0:37
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;
using cgcommerce.herramientas;

namespace cgcommerce
{
	public partial class nuevo_cliente : Form
	{
		private base_datos conexionbd;
		
		//iniciar form
		public nuevo_cliente()
		{
			//control de sesion
			conexionbd = new base_datos();
			InitializeComponent();
			form_center_screen();
		}
		//centra la form al centro
		private void form_center_screen()
		{
			this.TopMost = true;
			this.Location = new System.Drawing.Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
                          (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
		}
		//mensaje posicionar sobre boton
		void hoverButton(object sender, EventArgs e)
		{
			System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
			Button aux = (Button)sender;
			ToolTip1.SetToolTip(aux , aux.AccessibleDescription.ToString());
		}
		//salir form
		void Btn_salirClick(object sender, EventArgs e)
		{
			this.Close();
		}
		//limpiar datos
		void Nc_btn_limpiarClick(object sender, EventArgs e)
		{
			nc_cb_ciudad.Text = "";
			nc_tb_direccion.Text = "";
			nc_tb_fono1.Text = "";
			nc_tb_fono2.Text = "";
			nc_tb_comentario.Text = "";
			nc_tb_nombre.Text = "";
			nc_tb_apellido.Text = "";			
		}
		
        
		void Nc_btn_agregarClick(object sender, EventArgs e)
		{
			if(nc_cb_ciudad.Text!="" && nc_tb_apellido.Text!="" && nc_tb_nombre.Text!="" && nc_tb_direccion.Text!="" && nc_tb_fono1.Text!="")
			{
				string query;
				query = "INSERT INTO cliente (nombre,apellido,ciudad,direccion,fono1,fono2,comentario)" +
				"VALUES( '"+nc_tb_nombre.Text+"' , '"+nc_tb_apellido.Text+"' , UCase('"+nc_cb_ciudad.Text+"') , '"+nc_tb_direccion.Text+"' , '"+nc_tb_fono1.Text+"','"+nc_tb_fono2.Text+"','"+nc_tb_comentario.Text+"');";
				conexionbd.update(query);
				this.Close();
			}
			else
				MessageBox.Show("Llene los campos obligatorios (*).");
		}
	}
}
