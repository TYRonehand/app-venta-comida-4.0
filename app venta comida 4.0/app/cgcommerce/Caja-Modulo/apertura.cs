/*
 * Created by SharpDevelop.
 * User: queteimporta
 * Date: 30/10/2015
 * Time: 0:56
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using cgcommerce.herramientas;

namespace cgcommerce.Caja_Modulo
{
	public partial class apertura : Form
	{
		private string id_caja;
		private string rut_empleado;
		
		public apertura()
		{
			InitializeComponent();
			form_center_screen();
			
		}
		
		//recuperar id de la caja nueva
		public void set_caja(string id,string rut)
		{
			this.id_caja = id;
			this.rut_empleado = rut;
			
		}
		
		//centra la form al centro
		private void form_center_screen()
		{
			this.TopMost = true;
			this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
                          (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
		}
		
		//abrir caja
		void Btn_abrir_cajaClick(object sender, EventArgs e)
		{
			//base datos abrimos caja
			base_datos con = new base_datos();
			con.update(" INSERT INTO caja (estado, fapertura, hapertura, dinero_inicio, flujo, rut_abre) VALUES ('ABIERTO' , '"+DateTime.Now.ToShortDateString()+"', '"+DateTime.Now.ToShortTimeString()+"', "+num_dinero.Value+", "+num_dinero.Value+",'"+rut_empleado+"')");
			this.Close();
		}
		//salir
		void FusionButton1Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
