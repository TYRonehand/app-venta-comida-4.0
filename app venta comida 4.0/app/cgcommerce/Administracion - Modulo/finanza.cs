/*
 * Created by SharpDevelop.
 * User: queteimporta
 * Date: 27/10/2015
 * Time: 9:16
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using cgcommerce.herramientas;

namespace cgcommerce.Administracion___Modulo
{
	
	public partial class finanza : Form
	{
		public finanza()
		{
			
			InitializeComponent();
			this.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size;
			this.WindowState = FormWindowState.Maximized;
			
		}
		//centrar ventana
		private void form_center_screen()
		{
			this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
                          (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
		}
		
		//al cargar el load
        private void finanza_Load(object sender, EventArgs e)
        {
        	datos_semana();
        	datos_mes();
        	pedidos(); 
        	cajas();
        	datos_productos();
        }
        
        //cargar datos de la semana
		private void datos_semana()
		{
			string query;
			query  = "  SELECT o.[fecha], ";
			query += "  	UCASE(Format(o.[fecha],'ddd dd')) as Día, " ;
			query += "  	COUNT(id_orden) as ordenes, SUM(o.[total]) as total";
			query += "	FROM  orden o";
			query += "	WHERE DATEDIFF('d', o.[fecha], DATE()) < 8";
			query += "	GROUP BY o.[fecha], UCASE(Format(o.[fecha],'ddd dd')) ";
			query += "  ORDER BY o.[fecha] ASC";
		
			base_datos con = new base_datos();
			con.Actualizar_malla(dgv_datos,query);
			
			//GRAFICA
			Chart_7dias.Series.Clear();
			Chart_7dias.Titles.Clear();
			
			Chart_7dias.Palette = ChartColorPalette.Excel;
			Chart_7dias.Titles.Add("Ventas últimos 7 Días");
			
			foreach (DataGridViewRow row in dgv_datos.Rows)
	        {
				Series se = Chart_7dias.Series.Add(row.Cells[1].Value.ToString());
				se.Label = row.Cells[2].Value.ToString();
        		se.Points.Add((int)row.Cells[2].Value);
	        }
		}
		
		//cargar datos del mes
		private void datos_mes()
		{
			string query;
			query  = " SELECT Format(o.[fecha],'mm'), UCASE(Format(o.[fecha],'MMM yyyy')) AS fecha, COUNT(id_orden) AS ordenes, SUM(o.[total]) AS total";
			query += " FROM  orden o ";
			query += " WHERE Format(o.[fecha],'mm') ";
			query += " IN (  Format(DateAdd('m', -3, DATE()),'mm'), ";
			query += "       Format(DateAdd('m', -2, DATE()),'mm'), ";
			query += "       Format(DateAdd('m', -1, DATE()),'mm'), " ;
			query += "       Format(DATE() ,'mm'))";
			query += " GROUP BY Format(o.[fecha],'mm'), UCASE(Format(o.[fecha],'MMM yyyy'))";
			query += " ORDER BY Format(o.[fecha],'mm')";
		
			base_datos con = new base_datos();
			con.Actualizar_malla(dgv_datos2,query);
			dgv_datos2.Columns[0].Visible = false;
			
			//GRAFICA
			Chart_3meses.Series.Clear();
			Chart_3meses.Titles.Clear();
			
			//Chart_3meses.Palette = ChartColorPalette.Excel;
			Chart_3meses.Titles.Add("Ventas últimos 3 meses");
			
			foreach (DataGridViewRow row in dgv_datos2.Rows)
	        {
				Series se = Chart_3meses.Series.Add(row.Cells[1].Value.ToString());
				se.Label = row.Cells[2].Value.ToString();
        		se.Points.Add((int)row.Cells[2].Value);
	        }
			
		}
		
		//cargar datos de productos
		private void datos_productos()
		{
			string query;
			query  = " SELECT p.[id], p.[nombre], p.[precio], p.[contador] as vendidos, p.[precio]*p.[contador] as Ganancia_Aprox, p.[ingredientes], p.[disponible]";
			query += " FROM alternativa p";
		
			base_datos con = new base_datos();
			con.Actualizar_malla(dgv_producto,query);
			
			
		}
		
		//boton cerrar
		void FusionButton1Click(object sender, EventArgs e)
		{
			this.Close();
		}
		
		//pedidos - filtrar
		void Datos1_filtrarClick(object sender, EventArgs e)
		{
			pedidos();
		}
		
		//pedidos - todas
		void Datos1_todosClick(object sender, EventArgs e)
		{
			string query;
			
			query  = " SELECT  o.[id_orden] as OID, FORMAT(o.[fecha],'dd/mm/yyyy') as fecha, ";
			query += "        FORMAT(o.[hora],'hh:nn AM/PM') as hora,  ";
			query += "        (SELECT t.[nombre]+' '+t.[apellido] FROM trabajador t WHERE t.[rut] = o.[rut_vendedor]) as vendedor, ";
			query += "        (SELECT c.[nombre]+' '+c.[apellido] FROM cliente c WHERE c.[id_cliente] = o.[id_cliente]) as cliente, ";
			query += "       o.[pedido], o.[direccion], o.[fono],o.[descuento], o.[total] as cancelado, (o.[total]*100) /(100 - o.[descuento]) as total_real";
			query += " FROM  orden o ";
			
			base_datos con = new base_datos();
			con.Actualizar_malla(dgv_Pedidos,query);
		}
		
		//recperar pedidos
		private void pedidos()
		{
			string query;
			
			query  = " SELECT  o.[id_orden] as OID, FORMAT(o.[fecha],'dd/mm/yyyy') as fecha, ";
			query += "        FORMAT(o.[hora],'hh:nn AM/PM') as hora,  ";
			query += "        (SELECT t.[nombre]+' '+t.[apellido] FROM trabajador t WHERE t.[rut] = o.[rut_vendedor]) as vendedor, ";
			query += "        (SELECT c.[nombre]+' '+c.[apellido] FROM cliente c WHERE c.[id_cliente] = o.[id_cliente]) as cliente, ";
			query += "       o.[pedido], o.[direccion], o.[fono],o.[descuento], o.[total] as cancelado, (o.[total]*100) /(100 - o.[descuento]) as total_real";
			query += " FROM  orden o ";
			query += " WHERE  Format(o.[fecha],'dd/mm/yyyy') ";
			query += " BETWEEN Format('"+data1_fecha1.Value.ToShortDateString()+"','dd/mm/yyyy') ";
			query += " AND Format('"+data1_fecha2.Value.ToShortDateString()+"','dd/mm/yyyy') ";
			
			base_datos con = new base_datos();
			con.Actualizar_malla(dgv_Pedidos,query);
		}
		
		//recperar cajas
		private void cajas()
		{
			string query;
			
			query  = " SELECT c.[id_caja] as id, c.[estado], c.[fapertura] as fecha1, format(c.[hapertura],'hh:nn:ss AM/PM') as hora1, c.[dinero_inicio] as efectivo, c.[fcierre] as fecha2, format(c.[hcierre],'hh:nn:ss AM/PM') as hora2, c.[flujo] as efectivo2, c.[dinero_real] as efectivo_real, ";
			query += " (SELECT t.[nombre]+' '+t.[apellido] FROM trabajador t WHERE t.[rut] = c.[rut_abre]) as inicia, ";
			query += " (SELECT t.[nombre]+' '+t.[apellido] FROM trabajador t WHERE t.[rut] = c.[rut_cierra]) as termina  ";
			query += " FROM caja c";
			
			base_datos con = new base_datos();
			con.Actualizar_malla(dgv_cajas,query);
		}
		
		void Btn_filtrarClick(object sender, EventArgs e)
		{
	
		}
		
		//pedios a excel
		void XButton2Click(object sender, EventArgs e)
		{
			ImportarExcel(dgv_Pedidos);
		}
		
		//producto a excel
		void XButton3Click(object sender, EventArgs e)
		{
			ImportarExcel(dgv_cajas);
		}
		
		//funcion importar dgv a excel
		private void ImportarExcel(DataGridView dgv_Excel)
		{
			try
			{
				Microsoft.Office.Interop.Excel.ApplicationClass XcelApp = new Microsoft.Office.Interop.Excel.ApplicationClass();
			    XcelApp.Application.Workbooks.Add(Type.Missing);
			    
			    for (int i = 1; i < dgv_Excel.Columns.Count + 1; i++)
				{
				    XcelApp.Cells[1, i] = dgv_Excel.Columns[i - 1].HeaderText;
				}
		        for (int i = 0; i < dgv_Excel.Rows.Count; i++)
				{
				    for (int j = 0; j < dgv_Excel.Columns.Count; j++)
				    {
				        XcelApp.Cells[i + 2, j + 1] = dgv_Excel.Rows[i].Cells[j].Value.ToString();
				     }
				}
		        
		        XcelApp.Columns.AutoFit();
		        
		        XcelApp.Rows.Characters.Font.Bold = true;
		        
		        XcelApp.Visible = true;
		
			}
			catch(Exception ex){
				MessageBox.Show("Verifique tener excel y/o Abrir programa como Administrador.","Atención!");
			}
		}
		
		
    }
}
