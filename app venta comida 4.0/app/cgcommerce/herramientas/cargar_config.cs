/*
 * Created by SharpDevelop.
 * User: Carlos Gutierrez Acevedo
 * Date: 20/09/2015
 * Time: 17:55
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;

namespace cgcommerce
{
	
	public class cargar_config
	{
		private const string programador_creador_dueño = "CARLOS ALFREDO GUTIERREZ ACEVEDO";
		private string nombre_empresa;
		private string nombre_dueño;
		private string color1;
		private string color2;
		private string color3;
		private string color4;
		private string serial;
		private string licencia;
		private int suma;
		private string directorio;
		private string direccion;
		private string fono;
		private string web;
		
		public cargar_config()
		{}
		
		public void guarda_variables( string nombre_archivo )
		{
			string line;
			suma = 0;
			directorio = Directory.GetCurrentDirectory().ToString()+nombre_archivo;
			
			if(File.Exists(directorio))
			{
				
				StreamReader file = new StreamReader(directorio);
				//nombre_empresa
				if((line = file.ReadLine()) != null)
				{
					this.nombre_empresa = line;	
				}
				else
					this.suma++;
				//nombre dueño
				if((line = file.ReadLine()) != null)
				{
					this.nombre_dueño = line;	
				}
				else
					this.suma++;
				//color1
				if((line = file.ReadLine()) != null)
				{
					this.color1 = line;	
				}
				else
					this.suma++;
				
				if((line = file.ReadLine()) != null)
				{
					this.color2 = line;	
				}
				else
					this.suma++;
				
				if((line = file.ReadLine()) != null)
				{
					this.color3 = line;	
				}
				else
					this.suma++;
				
				if((line = file.ReadLine()) != null)
				{
					this.color4 = line;	
				}
				else
					this.suma++;
				
				if((line = file.ReadLine()) != null)
				{
					this.serial = line;	
				}
				else
					this.suma++;
				
				if((line = file.ReadLine()) != null)
				{
					this.licencia = line;	
				}
				else
					this.suma++;
				if((line = file.ReadLine()) != null)
				{
					this.direccion = line;	
				}
				else
					this.suma++;
				if((line = file.ReadLine()) != null)
				{
					this.fono = line;	
				}
				else
					this.suma++;
				if((line = file.ReadLine()) != null)
				{
					this.web = line;	
				}
				else
					this.suma++;
				
				file.Close();
			
			}
			else
				suma=-1;
			
		}
		public string get_nombre_empresa()
		{
			return nombre_empresa;
		}
		public string get_nombre_dueno()
		{
			return nombre_dueño;
		}
		public string get_color1()
		{
			return color1;
		}
		public string get_color2()
		{
			return color2;
		}
		public string get_color3()
		{
			return color3;
		}
		public string get_color4()
		{
			return color4;
		}
		public string get_serial()
		{
			return serial;
		}
		public string get_licencia()
		{
			return licencia;
		}
		public int get_suma()
		{
			return suma;
		}
		public string get_directorio()
		{
			return directorio;
		}
		public string get_direccion()
		{
			return direccion;
		}
		public string get_fono()
		{
			return fono;
		}
		public string get_web()
		{
			return web;
		}
		
		//guardar
		public void escribirTexto(string directorio, string texto, int linea_editar)
		{
		}
		
	}
}
