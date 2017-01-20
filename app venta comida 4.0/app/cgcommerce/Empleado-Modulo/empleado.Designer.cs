/*
 * Created by SharpDevelop.
 * User: ratondepc
 * Date: 10/09/2015
 * Time: 0:23
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace cgcommerce
{
	partial class empleado
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			Bloom bloom1 = new Bloom();
			Bloom bloom2 = new Bloom();
			Bloom bloom3 = new Bloom();
			Bloom bloom4 = new Bloom();
			Bloom bloom5 = new Bloom();
			Bloom bloom6 = new Bloom();
			Bloom bloom7 = new Bloom();
			Bloom bloom8 = new Bloom();
			Bloom bloom9 = new Bloom();
			Bloom bloom10 = new Bloom();
			Bloom bloom11 = new Bloom();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			ManiXButton.Office2010Blue office2010Blue1 = new ManiXButton.Office2010Blue();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(empleado));
			Bloom bloom12 = new Bloom();
			Bloom bloom13 = new Bloom();
			Bloom bloom14 = new Bloom();
			Bloom bloom15 = new Bloom();
			Bloom bloom16 = new Bloom();
			Bloom bloom17 = new Bloom();
			Bloom bloom18 = new Bloom();
			Bloom bloom19 = new Bloom();
			this.fusionTheme1 = new FusionTheme();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.Agenda_dgv_todos_empleados = new System.Windows.Forms.DataGridView();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btn_listo = new ManiXButton.XButton();
			this.btn_buscar_empleado = new System.Windows.Forms.Button();
			this.btn_eliminar_empleado = new System.Windows.Forms.Button();
			this.btn_nuevo_empleado = new System.Windows.Forms.Button();
			this.btn_salir = new FusionButton();
			this.fusionTheme1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Agenda_dgv_todos_empleados)).BeginInit();
			this.SuspendLayout();
			// 
			// fusionTheme1
			// 
			this.fusionTheme1.BackColor = System.Drawing.Color.White;
			this.fusionTheme1.BorderStyle = System.Windows.Forms.FormBorderStyle.None;
			bloom1.Name = "Sides";
			bloom1.Value = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(50)))));
			bloom2.Name = "Gradient1";
			bloom2.Value = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
			bloom3.Name = "Gradient2";
			bloom3.Value = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(50)))));
			bloom4.Name = "Text";
			bloom4.Value = System.Drawing.Color.White;
			bloom5.Name = "Back";
			bloom5.Value = System.Drawing.Color.White;
			bloom6.Name = "Border1";
			bloom6.Value = System.Drawing.Color.Black;
			bloom7.Name = "Border2";
			bloom7.Value = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(63)))));
			bloom8.Name = "Border3";
			bloom8.Value = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(63)))));
			bloom9.Name = "Border4";
			bloom9.Value = System.Drawing.Color.Black;
			bloom10.Name = "Blend1";
			bloom10.Value = System.Drawing.Color.Transparent;
			bloom11.Name = "Blend2";
			bloom11.Value = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(63)))));
			this.fusionTheme1.Colors = new Bloom[] {
		bloom1,
		bloom2,
		bloom3,
		bloom4,
		bloom5,
		bloom6,
		bloom7,
		bloom8,
		bloom9,
		bloom10,
		bloom11};
			this.fusionTheme1.Controls.Add(this.splitContainer1);
			this.fusionTheme1.Controls.Add(this.btn_salir);
			this.fusionTheme1.Customization = "Mi8v/zc0NP8yLy////////////8AAAD/Pzw8/z88PP8AAAD/////AD88PP8=";
			this.fusionTheme1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fusionTheme1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.fusionTheme1.Image = null;
			this.fusionTheme1.Location = new System.Drawing.Point(0, 0);
			this.fusionTheme1.Movable = true;
			this.fusionTheme1.Name = "fusionTheme1";
			this.fusionTheme1.NoRounding = false;
			this.fusionTheme1.Sizable = false;
			this.fusionTheme1.Size = new System.Drawing.Size(752, 538);
			this.fusionTheme1.SmartBounds = true;
			this.fusionTheme1.TabIndex = 5;
			this.fusionTheme1.Text = "Empleados";
			this.fusionTheme1.TransparencyKey = System.Drawing.Color.Fuchsia;
			// 
			// splitContainer1
			// 
			this.splitContainer1.Location = new System.Drawing.Point(10, 31);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.Agenda_dgv_todos_empleados);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.label4);
			this.splitContainer1.Panel2.Controls.Add(this.label3);
			this.splitContainer1.Panel2.Controls.Add(this.label1);
			this.splitContainer1.Panel2.Controls.Add(this.btn_listo);
			this.splitContainer1.Panel2.Controls.Add(this.btn_buscar_empleado);
			this.splitContainer1.Panel2.Controls.Add(this.btn_eliminar_empleado);
			this.splitContainer1.Panel2.Controls.Add(this.btn_nuevo_empleado);
			this.splitContainer1.Size = new System.Drawing.Size(731, 496);
			this.splitContainer1.SplitterDistance = 648;
			this.splitContainer1.SplitterWidth = 3;
			this.splitContainer1.TabIndex = 63;
			// 
			// Agenda_dgv_todos_empleados
			// 
			this.Agenda_dgv_todos_empleados.AllowUserToAddRows = false;
			this.Agenda_dgv_todos_empleados.AllowUserToDeleteRows = false;
			this.Agenda_dgv_todos_empleados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.Agenda_dgv_todos_empleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.Agenda_dgv_todos_empleados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.Agenda_dgv_todos_empleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.Agenda_dgv_todos_empleados.DefaultCellStyle = dataGridViewCellStyle1;
			this.Agenda_dgv_todos_empleados.Location = new System.Drawing.Point(3, 4);
			this.Agenda_dgv_todos_empleados.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Agenda_dgv_todos_empleados.Name = "Agenda_dgv_todos_empleados";
			this.Agenda_dgv_todos_empleados.ReadOnly = true;
			this.Agenda_dgv_todos_empleados.Size = new System.Drawing.Size(641, 488);
			this.Agenda_dgv_todos_empleados.TabIndex = 0;
			this.Agenda_dgv_todos_empleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Agenda_dgv_todos_empleadosCellContentClick);
			this.Agenda_dgv_todos_empleados.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Agenda_dgv_todos_empleadosCellContentDoubleClick);
			// 
			// label4
			// 
			this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(11, 210);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(63, 16);
			this.label4.TabIndex = 71;
			this.label4.Text = "Refrescar";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(11, 111);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(63, 16);
			this.label3.TabIndex = 70;
			this.label3.Text = "Eliminar";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(11, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(63, 16);
			this.label1.TabIndex = 68;
			this.label1.Text = "Agregar";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btn_listo
			// 
			this.btn_listo.Anchor = System.Windows.Forms.AnchorStyles.Right;
			office2010Blue1.BorderColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(72)))), ((int)(((byte)(161)))));
			office2010Blue1.BorderColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(135)))), ((int)(((byte)(228)))));
			office2010Blue1.ButtonMouseOverColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(199)))), ((int)(((byte)(87)))));
			office2010Blue1.ButtonMouseOverColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(243)))), ((int)(((byte)(215)))));
			office2010Blue1.ButtonMouseOverColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(225)))), ((int)(((byte)(137)))));
			office2010Blue1.ButtonMouseOverColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(249)))), ((int)(((byte)(224)))));
			office2010Blue1.ButtonNormalColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(72)))), ((int)(((byte)(161)))));
			office2010Blue1.ButtonNormalColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(135)))), ((int)(((byte)(228)))));
			office2010Blue1.ButtonNormalColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(97)))), ((int)(((byte)(181)))));
			office2010Blue1.ButtonNormalColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(125)))), ((int)(((byte)(219)))));
			office2010Blue1.ButtonSelectedColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(199)))), ((int)(((byte)(87)))));
			office2010Blue1.ButtonSelectedColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(243)))), ((int)(((byte)(215)))));
			office2010Blue1.ButtonSelectedColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(117)))));
			office2010Blue1.ButtonSelectedColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(216)))), ((int)(((byte)(107)))));
			office2010Blue1.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
			office2010Blue1.SelectedTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
			office2010Blue1.TextColor = System.Drawing.Color.White;
			this.btn_listo.ColorTable = office2010Blue1;
			this.btn_listo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_listo.Location = new System.Drawing.Point(11, 447);
			this.btn_listo.Name = "btn_listo";
			this.btn_listo.Size = new System.Drawing.Size(63, 44);
			this.btn_listo.TabIndex = 67;
			this.btn_listo.Text = "Atrás";
			this.btn_listo.Theme = ManiXButton.Theme.MSOffice2010_BLUE;
			this.btn_listo.UseVisualStyleBackColor = true;
			this.btn_listo.Click += new System.EventHandler(this.FusionButton1Click);
			// 
			// btn_buscar_empleado
			// 
			this.btn_buscar_empleado.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.btn_buscar_empleado.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_buscar_empleado.BackgroundImage")));
			this.btn_buscar_empleado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btn_buscar_empleado.Location = new System.Drawing.Point(12, 228);
			this.btn_buscar_empleado.Name = "btn_buscar_empleado";
			this.btn_buscar_empleado.Size = new System.Drawing.Size(64, 64);
			this.btn_buscar_empleado.TabIndex = 66;
			this.btn_buscar_empleado.UseVisualStyleBackColor = true;
			this.btn_buscar_empleado.Click += new System.EventHandler(this.Btn_buscar_empleadoClick);
			// 
			// btn_eliminar_empleado
			// 
			this.btn_eliminar_empleado.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.btn_eliminar_empleado.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_eliminar_empleado.BackgroundImage")));
			this.btn_eliminar_empleado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btn_eliminar_empleado.Location = new System.Drawing.Point(11, 130);
			this.btn_eliminar_empleado.Name = "btn_eliminar_empleado";
			this.btn_eliminar_empleado.Size = new System.Drawing.Size(64, 64);
			this.btn_eliminar_empleado.TabIndex = 65;
			this.btn_eliminar_empleado.UseVisualStyleBackColor = true;
			this.btn_eliminar_empleado.Click += new System.EventHandler(this.Btn_eliminar_empleadoClick);
			// 
			// btn_nuevo_empleado
			// 
			this.btn_nuevo_empleado.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.btn_nuevo_empleado.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_nuevo_empleado.BackgroundImage")));
			this.btn_nuevo_empleado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btn_nuevo_empleado.ForeColor = System.Drawing.Color.Black;
			this.btn_nuevo_empleado.Location = new System.Drawing.Point(11, 32);
			this.btn_nuevo_empleado.Name = "btn_nuevo_empleado";
			this.btn_nuevo_empleado.Size = new System.Drawing.Size(64, 64);
			this.btn_nuevo_empleado.TabIndex = 63;
			this.btn_nuevo_empleado.UseVisualStyleBackColor = true;
			this.btn_nuevo_empleado.Click += new System.EventHandler(this.Btn_nuevo_empleadoClick);
			// 
			// btn_salir
			// 
			bloom12.Name = "DownGradient1";
			bloom12.Value = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(1)))));
			bloom13.Name = "DownGradient2";
			bloom13.Value = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(175)))), ((int)(((byte)(12)))));
			bloom14.Name = "NoneGradient1";
			bloom14.Value = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(175)))), ((int)(((byte)(12)))));
			bloom15.Name = "NoneGradient2";
			bloom15.Value = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(1)))));
			bloom16.Name = "TextShade";
			bloom16.Value = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			bloom17.Name = "Text";
			bloom17.Value = System.Drawing.Color.White;
			bloom18.Name = "Border1";
			bloom18.Value = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(197)))), ((int)(((byte)(19)))));
			bloom19.Name = "Border2";
			bloom19.Value = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(133)))), ((int)(((byte)(0)))));
			this.btn_salir.Colors = new Bloom[] {
		bloom12,
		bloom13,
		bloom14,
		bloom15,
		bloom16,
		bloom17,
		bloom18,
		bloom19};
			this.btn_salir.Customization = "AX///wyv//8Mr///AX///wAAAB7/////E8X//wCF/v8=";
			this.btn_salir.Font = new System.Drawing.Font("Verdana", 8F);
			this.btn_salir.Image = null;
			this.btn_salir.Location = new System.Drawing.Point(782, 3);
			this.btn_salir.Name = "btn_salir";
			this.btn_salir.NoRounding = false;
			this.btn_salir.Size = new System.Drawing.Size(22, 24);
			this.btn_salir.TabIndex = 52;
			this.btn_salir.Text = "x";
			this.btn_salir.Transparent = false;
			// 
			// empleado
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(752, 538);
			this.ControlBox = false;
			this.Controls.Add(this.fusionTheme1);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "empleado";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Clientes";
			this.TransparencyKey = System.Drawing.Color.Fuchsia;
			this.fusionTheme1.ResumeLayout(false);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.Agenda_dgv_todos_empleados)).EndInit();
			this.ResumeLayout(false);

		}
		
		private System.Windows.Forms.Button btn_nuevo_empleado;
		private System.Windows.Forms.Button btn_eliminar_empleado;
		private System.Windows.Forms.Button btn_buscar_empleado;
		private ManiXButton.XButton btn_listo;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private FusionButton btn_salir;
		private FusionTheme fusionTheme1;
		private System.Windows.Forms.DataGridView Agenda_dgv_todos_empleados;
	}
}
