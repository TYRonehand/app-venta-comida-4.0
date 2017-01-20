/*
 * Created by SharpDevelop.
 * User: ratondepc
 * Date: 09/09/2015
 * Time: 15:11
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace cgcommerce
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private FusionButton btn_salir;
		private System.Windows.Forms.Timer timer1;
		private FlowTheme flowTheme1;
		private System.Windows.Forms.LinkLabel sesion_nombre_propiedad;
		private System.Windows.Forms.LinkLabel linklabel2;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private FlowButton sesion_btn_conectar;
		public System.Windows.Forms.TextBox sesion_tb_pass;
		private System.Windows.Forms.PictureBox sesion_pb_logo;
		public System.Windows.Forms.TextBox sesion_tb_rut;
		private System.Windows.Forms.Panel panel_central;
		
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
			this.components = new System.ComponentModel.Container();
			Bloom bloom1 = new Bloom();
			Bloom bloom2 = new Bloom();
			Bloom bloom3 = new Bloom();
			Bloom bloom4 = new Bloom();
			Bloom bloom5 = new Bloom();
			Bloom bloom6 = new Bloom();
			Bloom bloom7 = new Bloom();
			Bloom bloom8 = new Bloom();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			Bloom bloom9 = new Bloom();
			Bloom bloom10 = new Bloom();
			Bloom bloom11 = new Bloom();
			Bloom bloom12 = new Bloom();
			Bloom bloom13 = new Bloom();
			Bloom bloom14 = new Bloom();
			Bloom bloom15 = new Bloom();
			Bloom bloom16 = new Bloom();
			Bloom bloom17 = new Bloom();
			Bloom bloom18 = new Bloom();
			Bloom bloom19 = new Bloom();
			Bloom bloom20 = new Bloom();
			Bloom bloom21 = new Bloom();
			Bloom bloom22 = new Bloom();
			Bloom bloom23 = new Bloom();
			Bloom bloom24 = new Bloom();
			Bloom bloom25 = new Bloom();
			Bloom bloom26 = new Bloom();
			Bloom bloom27 = new Bloom();
			Bloom bloom28 = new Bloom();
			Bloom bloom29 = new Bloom();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.btn_salir = new FusionButton();
			this.sesion_nombre_propiedad = new System.Windows.Forms.LinkLabel();
			this.panel_central = new System.Windows.Forms.Panel();
			this.sesion_tb_pass = new System.Windows.Forms.TextBox();
			this.sesion_tb_rut = new System.Windows.Forms.TextBox();
			this.sesion_pb_logo = new System.Windows.Forms.PictureBox();
			this.linklabel2 = new System.Windows.Forms.LinkLabel();
			this.sesion_btn_conectar = new FlowButton();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.flowTheme1 = new FlowTheme();
			this.panel_central.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.sesion_pb_logo)).BeginInit();
			this.flowTheme1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btn_salir
			// 
			this.btn_salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			bloom1.Name = "DownGradient1";
			bloom1.Value = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(1)))));
			bloom2.Name = "DownGradient2";
			bloom2.Value = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(175)))), ((int)(((byte)(12)))));
			bloom3.Name = "NoneGradient1";
			bloom3.Value = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(175)))), ((int)(((byte)(12)))));
			bloom4.Name = "NoneGradient2";
			bloom4.Value = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(1)))));
			bloom5.Name = "TextShade";
			bloom5.Value = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			bloom6.Name = "Text";
			bloom6.Value = System.Drawing.Color.White;
			bloom7.Name = "Border1";
			bloom7.Value = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(197)))), ((int)(((byte)(19)))));
			bloom8.Name = "Border2";
			bloom8.Value = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(133)))), ((int)(((byte)(0)))));
			this.btn_salir.Colors = new Bloom[] {
		bloom1,
		bloom2,
		bloom3,
		bloom4,
		bloom5,
		bloom6,
		bloom7,
		bloom8};
			this.btn_salir.Customization = "AX///wyv//8Mr///AX///wAAAB7/////E8X//wCF/v8=";
			this.btn_salir.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_salir.Image = null;
			this.btn_salir.Location = new System.Drawing.Point(341, 0);
			this.btn_salir.Name = "btn_salir";
			this.btn_salir.NoRounding = false;
			this.btn_salir.Size = new System.Drawing.Size(26, 23);
			this.btn_salir.TabIndex = 52;
			this.btn_salir.TabStop = false;
			this.btn_salir.Text = "x";
			this.btn_salir.Transparent = false;
			this.btn_salir.Click += new System.EventHandler(this.Btn_salirClick);
			// 
			// sesion_nombre_propiedad
			// 
			this.sesion_nombre_propiedad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.sesion_nombre_propiedad.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.sesion_nombre_propiedad.LinkColor = System.Drawing.Color.Gainsboro;
			this.sesion_nombre_propiedad.Location = new System.Drawing.Point(12, 382);
			this.sesion_nombre_propiedad.Name = "sesion_nombre_propiedad";
			this.sesion_nombre_propiedad.Size = new System.Drawing.Size(351, 12);
			this.sesion_nombre_propiedad.TabIndex = 2;
			this.sesion_nombre_propiedad.TabStop = true;
			this.sesion_nombre_propiedad.Text = "Propietario Licencia xxxx.";
			// 
			// panel_central
			// 
			this.panel_central.Controls.Add(this.sesion_tb_pass);
			this.panel_central.Controls.Add(this.sesion_tb_rut);
			this.panel_central.Controls.Add(this.sesion_pb_logo);
			this.panel_central.Controls.Add(this.linklabel2);
			this.panel_central.Controls.Add(this.sesion_btn_conectar);
			this.panel_central.Controls.Add(this.linkLabel1);
			this.panel_central.Location = new System.Drawing.Point(67, 25);
			this.panel_central.Name = "panel_central";
			this.panel_central.Size = new System.Drawing.Size(240, 354);
			this.panel_central.TabIndex = 54;
			// 
			// sesion_tb_pass
			// 
			this.sesion_tb_pass.Location = new System.Drawing.Point(21, 265);
			this.sesion_tb_pass.MaxLength = 10;
			this.sesion_tb_pass.Name = "sesion_tb_pass";
			this.sesion_tb_pass.PasswordChar = '*';
			this.sesion_tb_pass.Size = new System.Drawing.Size(197, 22);
			this.sesion_tb_pass.TabIndex = 1;
			this.sesion_tb_pass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Tb_passKeyDown);
			// 
			// sesion_tb_rut
			// 
			this.sesion_tb_rut.Location = new System.Drawing.Point(21, 227);
			this.sesion_tb_rut.MaxLength = 45;
			this.sesion_tb_rut.Name = "sesion_tb_rut";
			this.sesion_tb_rut.Size = new System.Drawing.Size(197, 22);
			this.sesion_tb_rut.TabIndex = 0;
			this.sesion_tb_rut.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Cb_ayudantesKeyDown);
			// 
			// sesion_pb_logo
			// 
			this.sesion_pb_logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sesion_pb_logo.BackgroundImage")));
			this.sesion_pb_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.sesion_pb_logo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.sesion_pb_logo.Location = new System.Drawing.Point(21, 10);
			this.sesion_pb_logo.Name = "sesion_pb_logo";
			this.sesion_pb_logo.Size = new System.Drawing.Size(197, 197);
			this.sesion_pb_logo.TabIndex = 1;
			this.sesion_pb_logo.TabStop = false;
			// 
			// linklabel2
			// 
			this.linklabel2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.linklabel2.LinkColor = System.Drawing.Color.White;
			this.linklabel2.Location = new System.Drawing.Point(21, 251);
			this.linklabel2.Name = "linklabel2";
			this.linklabel2.Size = new System.Drawing.Size(197, 12);
			this.linklabel2.TabIndex = 4;
			this.linklabel2.TabStop = true;
			this.linklabel2.Text = "Contraseña";
			this.linklabel2.VisitedLinkColor = System.Drawing.Color.White;
			// 
			// sesion_btn_conectar
			// 
			bloom9.Name = "DownGradient1";
			bloom9.Value = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
			bloom10.Name = "DownGradient2";
			bloom10.Value = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
			bloom11.Name = "NoneGradient1";
			bloom11.Value = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
			bloom12.Name = "NoneGradient2";
			bloom12.Value = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
			bloom13.Name = "Text";
			bloom13.Value = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
			bloom14.Name = "Border1";
			bloom14.Value = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
			bloom15.Name = "Border2A";
			bloom15.Value = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
			bloom16.Name = "Border2B";
			bloom16.Value = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
			this.sesion_btn_conectar.Colors = new Bloom[] {
		bloom9,
		bloom10,
		bloom11,
		bloom12,
		bloom13,
		bloom14,
		bloom15,
		bloom16};
			this.sesion_btn_conectar.Customization = "GBgY/yYmJv8mJib/GBgY//+EAP8WFhb/PDw8/yQkJP8=";
			this.sesion_btn_conectar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.sesion_btn_conectar.Image = null;
			this.sesion_btn_conectar.Location = new System.Drawing.Point(21, 306);
			this.sesion_btn_conectar.Name = "sesion_btn_conectar";
			this.sesion_btn_conectar.NoRounding = false;
			this.sesion_btn_conectar.Size = new System.Drawing.Size(197, 40);
			this.sesion_btn_conectar.TabIndex = 2;
			this.sesion_btn_conectar.Text = "Conectar";
			this.sesion_btn_conectar.Transparent = false;
			this.sesion_btn_conectar.Click += new System.EventHandler(this.Sesion_btn_conectarClick);
			// 
			// linkLabel1
			// 
			this.linkLabel1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.linkLabel1.LinkColor = System.Drawing.Color.White;
			this.linkLabel1.Location = new System.Drawing.Point(21, 212);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(197, 12);
			this.linkLabel1.TabIndex = 4;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "Rut";
			this.linkLabel1.VisitedLinkColor = System.Drawing.Color.White;
			// 
			// flowTheme1
			// 
			this.flowTheme1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
			this.flowTheme1.BorderStyle = System.Windows.Forms.FormBorderStyle.None;
			bloom17.Name = "Sides";
			bloom17.Value = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			bloom18.Name = "Gradient";
			bloom18.Value = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
			bloom19.Name = "Text";
			bloom19.Value = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
			bloom20.Name = "Border1";
			bloom20.Value = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			bloom21.Name = "Border2";
			bloom21.Value = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
			bloom22.Name = "Border3";
			bloom22.Value = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
			bloom23.Name = "Border4";
			bloom23.Value = System.Drawing.Color.Black;
			bloom24.Name = "Hatch1";
			bloom24.Value = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
			bloom25.Name = "Hatch2";
			bloom25.Value = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
			bloom26.Name = "Hatch3";
			bloom26.Value = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
			bloom27.Name = "Hatch4";
			bloom27.Value = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
			bloom28.Name = "Shade1";
			bloom28.Value = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(7)))));
			bloom29.Name = "Shade2";
			bloom29.Value = System.Drawing.Color.Transparent;
			this.flowTheme1.Colors = new Bloom[] {
		bloom17,
		bloom18,
		bloom19,
		bloom20,
		bloom21,
		bloom22,
		bloom23,
		bloom24,
		bloom25,
		bloom26,
		bloom27,
		bloom28,
		bloom29};
			this.flowTheme1.Controls.Add(this.panel_central);
			this.flowTheme1.Controls.Add(this.sesion_nombre_propiedad);
			this.flowTheme1.Controls.Add(this.btn_salir);
			this.flowTheme1.Customization = "KCgo/xISEv//hAD/KCgo/xYWFv9BQUH/AAAA/ycnJ/8jIyP/HR0d/xoaGv8HBwcy////AA==";
			this.flowTheme1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowTheme1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.flowTheme1.Image = null;
			this.flowTheme1.Location = new System.Drawing.Point(0, 0);
			this.flowTheme1.Movable = false;
			this.flowTheme1.Name = "flowTheme1";
			this.flowTheme1.NoRounding = false;
			this.flowTheme1.Sizable = false;
			this.flowTheme1.Size = new System.Drawing.Size(375, 404);
			this.flowTheme1.SmartBounds = true;
			this.flowTheme1.TabIndex = 0;
			this.flowTheme1.TabStop = false;
			this.flowTheme1.Text = "Iniciar sesión ";
			this.flowTheme1.TransparencyKey = System.Drawing.Color.Fuchsia;
			this.flowTheme1.VisibleChanged += new System.EventHandler(this.FlowTheme1VisibleChanged);
			this.flowTheme1.Resize += new System.EventHandler(this.FlowTheme1Resize);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
			this.ClientSize = new System.Drawing.Size(375, 404);
			this.Controls.Add(this.flowTheme1);
			this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = global::cgcommerce.imagenes.Paomedia_Small_N_Flat_Shop;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = " MisVentas.";
			this.TransparencyKey = System.Drawing.Color.Fuchsia;
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.panel_central.ResumeLayout(false);
			this.panel_central.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.sesion_pb_logo)).EndInit();
			this.flowTheme1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}
