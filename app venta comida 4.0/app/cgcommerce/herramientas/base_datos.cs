/*
 * Created by SharpDevelop.
 * User: Carlos Gutierrez Acevedo
 * Date: 21/09/2015
 * Time: 23:03
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;

namespace cgcommerce.herramientas
{
	
	public class base_datos
	{
		//variable de ingrediente 
		public int columna_elemento = 2;
		const string ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=lib/bd/venta.accdb;Persist Security Info=False;";
				
		/*DATOS USUARIO*/
		
		public base_datos()
		{
		}
		
		//ACTUALIZAR GRID CON DATO PEDIDOS
		public void Actualizar_malla(DataGridView aux, string query)
        {
			try
			{
				OleDbConnection con;
				con = new OleDbConnection(ConnectionString);
			
				con.Open();
				OleDbCommand command = new OleDbCommand();
				command.Connection = con;
				command.CommandText = query;
				OleDbDataAdapter DA = new OleDbDataAdapter(command);
				DataTable DT = new DataTable();
				DA.Fill(DT);
				aux.DataSource = DT;
				con.Close();
			}
			catch(Exception e)
			{ 
				MessageBox.Show(e.Message,"datagridview");
			}
        }
		
		//CARGAR DATOS EN UN COMBOBOX
		public void LoadDataOnCombo(string query, ComboBox aux)
        {	
            try
            {
                OleDbConnection con;
				con = new OleDbConnection(ConnectionString);
				con.Open();
                OleDbDataAdapter adapter = new OleDbDataAdapter(new OleDbCommand(query, con));
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                aux.DataSource = ds.Tables[0];
                aux.DisplayMember = "Fullname";
                aux.ValueMember = "Fullname";
                
            	con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Combobox DB");
            }
        }
		
		//ACTUALIZAR, INGERSAR O ELIMINAR DATO EN BASEDATO
        public void update(string query)
        {
        	try{
	            OleDbConnection con;
				con = new OleDbConnection(ConnectionString);
				con.Open();
				
	            OleDbCommand com = new OleDbCommand(query, con);
	            com.ExecuteNonQuery();
	            con.Close();
	            
        	}catch(Exception e){
		            MessageBox.Show(e.Message,"Error: al actualizar");
        	}
        }
        
        
        public int existe_dato(string str)
		{
			int resultado =0;
			try
			{
	            OleDbConnection con;
				con = new OleDbConnection(ConnectionString);
			    con.Open();
			    
				OleDbCommand com = new OleDbCommand(str,con);
				
				com.ExecuteNonQuery();
				
				using (OleDbDataReader myReader = com.ExecuteReader())
			    {
			        DataTable dt = new DataTable();
			        dt.Load(myReader);
			        resultado = dt.Rows.Count;
			    }
				con.Close();
			
			}catch(Exception e){
		            MessageBox.Show(e.Message,"existe datos");
        	}
			
	        if (resultado>0)
	        {
	            return 1;
	        }
	        return 0;
		}
        
        public string consulta_dato(string query)
		{
			string resultado = string.Empty;
			
			try
			{
	            OleDbConnection con;
				con = new OleDbConnection(ConnectionString);
			    con.Open();
			    
				OleDbCommand com = new OleDbCommand(query,con);
				
				com.ExecuteNonQuery();
				
				using (OleDbDataReader myReader = com.ExecuteReader())
			    {
			        DataTable dt = new DataTable();
			        dt.Load(myReader);
			        resultado = dt.Rows[0].ItemArray[0].ToString();
			    }
				con.Close();
			
			}catch(Exception e){
		            MessageBox.Show(e.Message,"consulta dato");
        	}
			
	        return resultado;
	        
		}
        
        
	}
}
