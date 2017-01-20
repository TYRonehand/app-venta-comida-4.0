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
	public partial class editar_cliente : Form
	{
		private base_datos conexionbd;
		private int id_cliente_registro;
		
		public editar_cliente(int id_cliente,string nombre,string apellido, string ciudad, string direccion,string fono1,string fono2,string comentario)
		{
			conexionbd = new base_datos();
			InitializeComponent();
		
			form_center_screen();
			id_cliente_registro = id_cliente;
			a_tb_nombre.Text = nombre;
			a_tb_apellido.Text = apellido;
			a_cb_ciudad.Text = ciudad;
			a_tb_direccion.Text = direccion;
			a_tb_fono1.Text = fono1;
			a_tb_fono2.Text = fono2;
			a_tb_comentario.Text = comentario;
			
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
			if(a_tb_nombre.Text !="" && a_tb_apellido.Text!="" && a_tb_nombre.Text!="" && a_tb_direccion.Text!="" && a_tb_fono1.Text!="")
			{
				string query;
				query = " UPDATE cliente "+
						" SET nombre = '"+a_tb_nombre.Text+"' , apellido = '"+a_tb_apellido.Text+"' , ciudad = UCase('"+a_cb_ciudad.Text+"'), direccion = '"+a_tb_direccion.Text+"', fono1 = '"+a_tb_fono1.Text+"' , fono2 = '"+a_tb_fono2.Text+"' , comentario = '"+a_tb_comentario.Text
						+"' WHERE id_cliente = "+id_cliente_registro;
				
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
