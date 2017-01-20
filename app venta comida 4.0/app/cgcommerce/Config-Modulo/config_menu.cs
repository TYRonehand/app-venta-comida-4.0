/*
 * Created by SharpDevelop.
 * User: queteimporta
 * Date: 28/10/2015
 * Time: 21:32
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using cgcommerce.herramientas;

namespace cgcommerce.Config_Modulo
{
	public partial class config_menu : Form
	{
		public config_menu()
		{
			InitializeComponent();
			form_center_screen();
			cargar_configuracion();
		}
		
		
		//centrar ventana
		private void form_center_screen()
		{
			this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
                          (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
		}
		private void cargar_configuracion()
		{
			
			if( System.IO.File.Exists( System.IO.Directory.GetCurrentDirectory()+@"\user.cfg") )
			{
				cargar_config aux = new cargar_config();
				aux.guarda_variables(@"\user.cfg");
				lic_tb_codigo.Text = aux.get_nombre_dueno();
				lic_tb_serial.Text = aux.get_nombre_empresa();
				
			}
			if( System.IO.File.Exists( System.IO.Directory.GetCurrentDirectory()+@"\config.cfg") )
			{
				cargar_config aux = new cargar_config();
				aux.guarda_variables(@"\config.cfg");
				lic_tb_dueno.Text = aux.get_nombre_dueno();
				lic_tb_empresa.Text = aux.get_nombre_empresa();
				
			}
		
		}
		
		//cerrar
		void FusionButton1Click(object sender, EventArgs e)
		{
			this.Close();
		}
		
		//guardar datos propietario
		void Button3Click(object sender, EventArgs e)
		{
	
		}
		
		//origen conexion bd
		void Button6Click(object sender, EventArgs e)
		{
			base_datos con = new base_datos();
			con.update("UPDATE trabajador SET pass ='"+bd_tb_pass.Text+"' WHERE tipo = 'ADMIN'  AND editable  = 0");
			MessageBox.Show("contraseña cambiada con exito!","Administración");
			bd_tb_pass.Text = string.Empty;
		}
		
		//destino backup
		void Button4Click(object sender, EventArgs e)
		{
			FolderBrowserDialog fbd = new FolderBrowserDialog();
 			DialogResult result = fbd.ShowDialog();
 			bd_tb_destino.Text = fbd.SelectedPath;
 			
		}
		
		//seleccion directorio licencia
	
		
		//activara software
	
				
		
		
		
	}
}
