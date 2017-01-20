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
	public partial class cierre : Form
	{
		private string id_caja;
		private string rut_empleado;
		
		public cierre()
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
			//base datos cerramos caja
			base_datos con = new base_datos();
			con.update("UPDATE caja SET estado = 'CERRADO', fcierre = '"+DateTime.Now.ToShortDateString()+"', hcierre = '"+DateTime.Now.ToShortTimeString()+"', dinero_real = "+num_dinero.Value+", rut_cierra = '"+rut_empleado+"'  WHERE id_caja = "+id_caja);
			this.Close();
		}
		//salir
		void FusionButton1Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
