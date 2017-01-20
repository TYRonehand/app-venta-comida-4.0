/*
 * Created by SharpDevelop.
 * User: Carlos Gutierrez Acevedo
 * Date: 21/09/2015
 * Time: 17:23
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace cgcommerce.herramientas
{
	
	public class licencia
	{
		private string licencia_lc;
		private string emp_config;
		private string directorio_licencia;
		private string directorio_config;
		private int suma1,suma2;
		
		static readonly string PasswordHash = "P@@Sw0rd";
		static readonly string SaltKey = "S@LT&KEY";
		static readonly string VIKey = "@1B2c3D4e5F6g7H8";
		
		public licencia()
		{
			
		}
		
		
		public string get_directorio_licencia()
		{
			return directorio_licencia;
		}
		
		public string get_directorio_config()
		{
			return directorio_config;
		}
		
		public string get_config()
		{
			return emp_config;
		}
		
		public string get_licencia()
		{
			return licencia_lc;
		}
		
		
		
		public bool get_validar()
		{
			cargar_archivo();
			if(suma1==1 && suma2==1)
				return validar(emp_config, licencia_lc);
			else
				return false;
		}
		
		public int get_suma()
		{
			if(suma1 == 1 && suma2 == 1)
				return 1;
			else
				return 0;
		}
		
		public void cargar_archivo(  )
		{
			string line;
			suma1 = 0;
			suma2 = 0;
			
			//licencia-----------------------------------------------------------
			directorio_config = Directory.GetCurrentDirectory().ToString()+@"\config.cfg";
			
			if(File.Exists(directorio_config))
			{
				
				emp_config ="";
				StreamReader file = new StreamReader(directorio_config);
				
				if((line = file.ReadToEnd()) != null)
				{
					this.emp_config+=line;	
					suma1 = 1;
				}
			}
			else
				suma1 = -1;
			
			//configuraciontxt--------------------------------------------------
			directorio_licencia = Directory.GetCurrentDirectory().ToString()+@"\licencia.lc";
			
			if(File.Exists(directorio_licencia))
			{
				
				licencia_lc="";
				StreamReader file = new StreamReader(directorio_licencia);
				
				if((line = file.ReadLine()) != null)
				{
					this.licencia_lc = Decrypt(line);
					suma2 = 1;
				}
			}
			else
				suma2 = -1;
			
		}
		
		protected bool validar(string emp_config, string licencia_lc)
		{
			
			if(emp_config.Length >0 &&  licencia_lc.Length > 0)
			{
				if(emp_config.Length == licencia_lc.Length)
				{
					if (emp_config.Contains( licencia_lc) )
					{
						return true;//iguales!!!!!
					} 
					else
						return false;//distintas
				}
				else
					return false;//distintas
			}
			else
				return false;
		}
		
		public static string Encrypt(string plainText)
		{
			byte[] plainTextBytes = Encoding.UTF8.GetBytes(plainText);

			byte[] keyBytes = new Rfc2898DeriveBytes(PasswordHash, Encoding.ASCII.GetBytes(SaltKey)).GetBytes(256 / 8);
			var symmetricKey = new RijndaelManaged() { Mode = CipherMode.CBC, Padding = PaddingMode.Zeros };
			var encryptor = symmetricKey.CreateEncryptor(keyBytes, Encoding.ASCII.GetBytes(VIKey));
			
			byte[] cipherTextBytes;

			using (var memoryStream = new MemoryStream())
			{
				using (var cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write))
				{
					cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);
					cryptoStream.FlushFinalBlock();
					cipherTextBytes = memoryStream.ToArray();
					cryptoStream.Close();
				}
				memoryStream.Close();
			}
			return Convert.ToBase64String(cipherTextBytes);
		}
		
		public static string Decrypt(string encryptedText)
		{
			byte[] cipherTextBytes = Convert.FromBase64String(encryptedText);
			byte[] keyBytes = new Rfc2898DeriveBytes(PasswordHash, Encoding.ASCII.GetBytes(SaltKey)).GetBytes(256 / 8);
			var symmetricKey = new RijndaelManaged() { Mode = CipherMode.CBC, Padding = PaddingMode.None };

			var decryptor = symmetricKey.CreateDecryptor(keyBytes, Encoding.ASCII.GetBytes(VIKey));
			var memoryStream = new MemoryStream(cipherTextBytes);
			var cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read);
			byte[] plainTextBytes = new byte[cipherTextBytes.Length];

			int decryptedByteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);
			memoryStream.Close();
			cryptoStream.Close();
			return Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount).TrimEnd("\0".ToCharArray());
		}
		
		//consultar registro en localmachine
		public void registro_version(string version)
		{
			try
			{
			    using (Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("Software\\Wow6432Node\\MySQL AB\\MySQL Connector\\Net"))
			    {
			        if (key != null)
			        {
			            Object o = key.GetValue("Version");
			            if (o != null)
			            {
			                //Version version = new Version(o as String);  //"as" because it's REG_SZ...otherwise ToString() might be safe(r)
			                //do what you like with version
			            }
			        }
			    }
			}catch(Exception e){
				Console.WriteLine(e);
			}
		}
		
	}
}
