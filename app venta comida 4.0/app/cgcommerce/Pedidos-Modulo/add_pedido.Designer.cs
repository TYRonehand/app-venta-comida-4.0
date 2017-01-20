/*
 * Created by SharpDevelop.
 * User: ratondepc
 * Date: 09/09/2015
 * Time: 17:01
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace cgcommerce
{
	partial class add_pedido
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TabControl TabPrincipal;
		private System.Windows.Forms.TabPage tabPedido;
		private ManiXButton.XButton btn_limpiar_todo;
		private ManiXButton.XButton btn_pedido_listo;
		private System.Windows.Forms.GroupBox groupBox6;
		private System.Windows.Forms.DataGridView data_base;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.Label label_precio_total;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.CheckedListBox lista_pedidos_armado;
		private System.Windows.Forms.GroupBox groupBox3;
		private ManiXButton.XButton btn_quitar_ingrediente;
		private ManiXButton.XButton btn_listo_ingrediente;
		private System.Windows.Forms.CheckedListBox lista_ingredientes;
		private System.Windows.Forms.GroupBox groupBox2;
		private ManiXButton.XButton btn_add_agregados;
		private System.Windows.Forms.ComboBox cbo_agregados;
		private System.Windows.Forms.TabPage tabCliente;
		private System.Windows.Forms.Panel panel1;
		private ManiXButton.XButton btn_filtrar_cliente;
		private ManiXButton.XButton btn_nuevocliente;
		private System.Windows.Forms.GroupBox groupBox8;
		private ManiXButton.XButton Btn_cliente_listo;
		private System.Windows.Forms.Label label_precio_total3;
		private System.Windows.Forms.TextBox cliente_filtro_nombre;
		private System.Windows.Forms.GroupBox groupBox7;
		private System.Windows.Forms.DataGridView data_cliente;
		private System.Windows.Forms.TabPage tabOrden;
		private ManiXButton.XButton btn_generar_pedido;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox orden_lista_pedidos;
		private System.Windows.Forms.TextBox orden_direcioncliente;
		private System.Windows.Forms.TextBox orden_telefonocliente;
		private System.Windows.Forms.TextBox orden_nombrecliente;
		private System.Windows.Forms.TextBox orden_rut_vendedor;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.PictureBox picture_logo;
		
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
			Bloom bloom12 = new Bloom();
			Bloom bloom13 = new Bloom();
			Bloom bloom14 = new Bloom();
			Bloom bloom15 = new Bloom();
			Bloom bloom16 = new Bloom();
			Bloom bloom17 = new Bloom();
			Bloom bloom18 = new Bloom();
			Bloom bloom19 = new Bloom();
			ManiXButton.Office2010Blue office2010Blue1 = new ManiXButton.Office2010Blue();
			ManiXButton.Office2010Red office2010Red1 = new ManiXButton.Office2010Red();
			ManiXButton.Office2010Green office2010Green1 = new ManiXButton.Office2010Green();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.picture_logo = new System.Windows.Forms.PictureBox();
			this.fusionTheme1 = new FusionTheme();
			this.btn_salir = new FusionButton();
			this.TabPrincipal = new System.Windows.Forms.TabControl();
			this.tabPedido = new System.Windows.Forms.TabPage();
			this.tb_id_pedido = new System.Windows.Forms.TextBox();
			this.tb_contador_pedido = new System.Windows.Forms.TextBox();
			this.tb_nombre_pedido = new System.Windows.Forms.TextBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btn_add_agregados = new ManiXButton.XButton();
			this.cbo_agregados = new System.Windows.Forms.ComboBox();
			this.tb_precio_espera = new System.Windows.Forms.TextBox();
			this.btn_limpiar_todo = new ManiXButton.XButton();
			this.btn_pedido_listo = new ManiXButton.XButton();
			this.groupBox6 = new System.Windows.Forms.GroupBox();
			this.data_base = new System.Windows.Forms.DataGridView();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.label_precio_total = new System.Windows.Forms.Label();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.lista_pedidos_armado = new System.Windows.Forms.CheckedListBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.btn_quitar_ingrediente = new ManiXButton.XButton();
			this.btn_listo_ingrediente = new ManiXButton.XButton();
			this.lista_ingredientes = new System.Windows.Forms.CheckedListBox();
			this.tabCliente = new System.Windows.Forms.TabPage();
			this.groupBox14 = new System.Windows.Forms.GroupBox();
			this.label_precio_total3 = new System.Windows.Forms.Label();
			this.groupBox13 = new System.Windows.Forms.GroupBox();
			this.button4 = new System.Windows.Forms.Button();
			this.num_descuento = new System.Windows.Forms.NumericUpDown();
			this.button3 = new System.Windows.Forms.Button();
			this.label13 = new System.Windows.Forms.Label();
			this.groupBox9 = new System.Windows.Forms.GroupBox();
			this.rb_tarjeta = new System.Windows.Forms.RadioButton();
			this.rb_efectivo = new System.Windows.Forms.RadioButton();
			this.groupBox11 = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.num_efectivo_cliente = new System.Windows.Forms.NumericUpDown();
			this.panel1 = new System.Windows.Forms.Panel();
			this.groupBox8 = new System.Windows.Forms.GroupBox();
			this.btn_filtrar_cliente = new ManiXButton.XButton();
			this.cliente_filtro_nombre = new System.Windows.Forms.TextBox();
			this.btn_actualizar_clientes = new ManiXButton.XButton();
			this.btn_nuevocliente = new ManiXButton.XButton();
			this.Btn_cliente_listo = new ManiXButton.XButton();
			this.groupBox7 = new System.Windows.Forms.GroupBox();
			this.data_cliente = new System.Windows.Forms.DataGridView();
			this.tabOrden = new System.Windows.Forms.TabPage();
			this.groupBox12 = new System.Windows.Forms.GroupBox();
			this.vuelto_cliente = new System.Windows.Forms.Label();
			this.groupBox10 = new System.Windows.Forms.GroupBox();
			this.label_precio_real = new System.Windows.Forms.Label();
			this.orden_nombre_vendedor = new System.Windows.Forms.ComboBox();
			this.label11 = new System.Windows.Forms.Label();
			this.orden_idcliente = new System.Windows.Forms.TextBox();
			this.orden_cb_nro_orden = new System.Windows.Forms.ComboBox();
			this.btn_generar_pedido = new ManiXButton.XButton();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label_precio_total2 = new System.Windows.Forms.Label();
			this.orden_lista_pedidos = new System.Windows.Forms.TextBox();
			this.orden_direcioncliente = new System.Windows.Forms.TextBox();
			this.orden_telefonocliente = new System.Windows.Forms.TextBox();
			this.orden_nombrecliente = new System.Windows.Forms.TextBox();
			this.orden_rut_vendedor = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.picture_logo)).BeginInit();
			this.fusionTheme1.SuspendLayout();
			this.TabPrincipal.SuspendLayout();
			this.tabPedido.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox6.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.data_base)).BeginInit();
			this.groupBox5.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.tabCliente.SuspendLayout();
			this.groupBox14.SuspendLayout();
			this.groupBox13.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.num_descuento)).BeginInit();
			this.groupBox9.SuspendLayout();
			this.groupBox11.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.num_efectivo_cliente)).BeginInit();
			this.panel1.SuspendLayout();
			this.groupBox8.SuspendLayout();
			this.groupBox7.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.data_cliente)).BeginInit();
			this.tabOrden.SuspendLayout();
			this.groupBox12.SuspendLayout();
			this.groupBox10.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// picture_logo
			// 
			this.picture_logo.BackColor = System.Drawing.SystemColors.ControlDark;
			this.picture_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.picture_logo.Location = new System.Drawing.Point(878, 25);
			this.picture_logo.Name = "picture_logo";
			this.picture_logo.Size = new System.Drawing.Size(254, 241);
			this.picture_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picture_logo.TabIndex = 102;
			this.picture_logo.TabStop = false;
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
			this.fusionTheme1.Controls.Add(this.btn_salir);
			this.fusionTheme1.Controls.Add(this.TabPrincipal);
			this.fusionTheme1.Customization = "Mi8v/zc0NP8yLy////////////8AAAD/Pzw8/z88PP8AAAD/////AD88PP8=";
			this.fusionTheme1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fusionTheme1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.fusionTheme1.Image = null;
			this.fusionTheme1.Location = new System.Drawing.Point(0, 0);
			this.fusionTheme1.MaximumSize = new System.Drawing.Size(902, 560);
			this.fusionTheme1.MinimumSize = new System.Drawing.Size(902, 560);
			this.fusionTheme1.Movable = true;
			this.fusionTheme1.Name = "fusionTheme1";
			this.fusionTheme1.NoRounding = false;
			this.fusionTheme1.Sizable = true;
			this.fusionTheme1.Size = new System.Drawing.Size(902, 560);
			this.fusionTheme1.SmartBounds = true;
			this.fusionTheme1.TabIndex = 0;
			this.fusionTheme1.Text = "Tomar Pedido";
			this.fusionTheme1.TransparencyKey = System.Drawing.Color.Fuchsia;
			// 
			// btn_salir
			// 
			this.btn_salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
			this.btn_salir.Location = new System.Drawing.Point(863, 6);
			this.btn_salir.Name = "btn_salir";
			this.btn_salir.NoRounding = false;
			this.btn_salir.Size = new System.Drawing.Size(28, 26);
			this.btn_salir.TabIndex = 103;
			this.btn_salir.Text = "x";
			this.btn_salir.Transparent = false;
			this.btn_salir.Click += new System.EventHandler(this.Btn_salirClick);
			// 
			// TabPrincipal
			// 
			this.TabPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.TabPrincipal.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
			this.TabPrincipal.Controls.Add(this.tabPedido);
			this.TabPrincipal.Controls.Add(this.tabCliente);
			this.TabPrincipal.Controls.Add(this.tabOrden);
			this.TabPrincipal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TabPrincipal.Location = new System.Drawing.Point(12, 38);
			this.TabPrincipal.Multiline = true;
			this.TabPrincipal.Name = "TabPrincipal";
			this.TabPrincipal.RightToLeftLayout = true;
			this.TabPrincipal.SelectedIndex = 0;
			this.TabPrincipal.Size = new System.Drawing.Size(877, 510);
			this.TabPrincipal.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
			this.TabPrincipal.TabIndex = 0;
			// 
			// tabPedido
			// 
			this.tabPedido.Controls.Add(this.tb_id_pedido);
			this.tabPedido.Controls.Add(this.tb_contador_pedido);
			this.tabPedido.Controls.Add(this.tb_nombre_pedido);
			this.tabPedido.Controls.Add(this.groupBox2);
			this.tabPedido.Controls.Add(this.tb_precio_espera);
			this.tabPedido.Controls.Add(this.btn_limpiar_todo);
			this.tabPedido.Controls.Add(this.btn_pedido_listo);
			this.tabPedido.Controls.Add(this.groupBox6);
			this.tabPedido.Controls.Add(this.groupBox5);
			this.tabPedido.Controls.Add(this.groupBox4);
			this.tabPedido.Controls.Add(this.groupBox3);
			this.tabPedido.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tabPedido.Location = new System.Drawing.Point(4, 25);
			this.tabPedido.Name = "tabPedido";
			this.tabPedido.Padding = new System.Windows.Forms.Padding(3);
			this.tabPedido.Size = new System.Drawing.Size(869, 481);
			this.tabPedido.TabIndex = 0;
			this.tabPedido.Text = "Pedido";
			this.tabPedido.UseVisualStyleBackColor = true;
			// 
			// tb_id_pedido
			// 
			this.tb_id_pedido.Enabled = false;
			this.tb_id_pedido.Location = new System.Drawing.Point(11, 277);
			this.tb_id_pedido.Name = "tb_id_pedido";
			this.tb_id_pedido.Size = new System.Drawing.Size(38, 21);
			this.tb_id_pedido.TabIndex = 21;
			this.tb_id_pedido.Text = "0";
			this.tb_id_pedido.Visible = false;
			// 
			// tb_contador_pedido
			// 
			this.tb_contador_pedido.Enabled = false;
			this.tb_contador_pedido.Location = new System.Drawing.Point(219, 277);
			this.tb_contador_pedido.Name = "tb_contador_pedido";
			this.tb_contador_pedido.Size = new System.Drawing.Size(73, 21);
			this.tb_contador_pedido.TabIndex = 20;
			this.tb_contador_pedido.Text = "0";
			this.tb_contador_pedido.Visible = false;
			// 
			// tb_nombre_pedido
			// 
			this.tb_nombre_pedido.Enabled = false;
			this.tb_nombre_pedido.Location = new System.Drawing.Point(55, 277);
			this.tb_nombre_pedido.Name = "tb_nombre_pedido";
			this.tb_nombre_pedido.Size = new System.Drawing.Size(158, 21);
			this.tb_nombre_pedido.TabIndex = 19;
			this.tb_nombre_pedido.Text = "nombre";
			this.tb_nombre_pedido.Visible = false;
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.groupBox2.Controls.Add(this.btn_add_agregados);
			this.groupBox2.Controls.Add(this.cbo_agregados);
			this.groupBox2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(303, 304);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(208, 171);
			this.groupBox2.TabIndex = 18;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "AGREGADOS";
			// 
			// btn_add_agregados
			// 
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
			this.btn_add_agregados.ColorTable = office2010Blue1;
			this.btn_add_agregados.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_add_agregados.Location = new System.Drawing.Point(101, 121);
			this.btn_add_agregados.Name = "btn_add_agregados";
			this.btn_add_agregados.Size = new System.Drawing.Size(100, 41);
			this.btn_add_agregados.TabIndex = 0;
			this.btn_add_agregados.Text = "Agregar";
			this.btn_add_agregados.Theme = ManiXButton.Theme.MSOffice2010_BLUE;
			this.btn_add_agregados.Click += new System.EventHandler(this.Btn_add_agregadosClick);
			// 
			// cbo_agregados
			// 
			this.cbo_agregados.FormattingEnabled = true;
			this.cbo_agregados.Location = new System.Drawing.Point(5, 20);
			this.cbo_agregados.Name = "cbo_agregados";
			this.cbo_agregados.Size = new System.Drawing.Size(197, 21);
			this.cbo_agregados.TabIndex = 1;
			// 
			// tb_precio_espera
			// 
			this.tb_precio_espera.Enabled = false;
			this.tb_precio_espera.Location = new System.Drawing.Point(475, 277);
			this.tb_precio_espera.Name = "tb_precio_espera";
			this.tb_precio_espera.Size = new System.Drawing.Size(86, 21);
			this.tb_precio_espera.TabIndex = 17;
			this.tb_precio_espera.Text = "0";
			this.tb_precio_espera.Visible = false;
			// 
			// btn_limpiar_todo
			// 
			this.btn_limpiar_todo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			office2010Red1.BorderColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(72)))), ((int)(((byte)(161)))));
			office2010Red1.BorderColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(135)))), ((int)(((byte)(228)))));
			office2010Red1.ButtonMouseOverColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(199)))), ((int)(((byte)(87)))));
			office2010Red1.ButtonMouseOverColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(243)))), ((int)(((byte)(215)))));
			office2010Red1.ButtonMouseOverColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(225)))), ((int)(((byte)(137)))));
			office2010Red1.ButtonMouseOverColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(249)))), ((int)(((byte)(224)))));
			office2010Red1.ButtonNormalColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(77)))), ((int)(((byte)(45)))));
			office2010Red1.ButtonNormalColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(148)))), ((int)(((byte)(64)))));
			office2010Red1.ButtonNormalColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(77)))), ((int)(((byte)(45)))));
			office2010Red1.ButtonNormalColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(148)))), ((int)(((byte)(64)))));
			office2010Red1.ButtonSelectedColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(199)))), ((int)(((byte)(87)))));
			office2010Red1.ButtonSelectedColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(243)))), ((int)(((byte)(215)))));
			office2010Red1.ButtonSelectedColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(117)))));
			office2010Red1.ButtonSelectedColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(216)))), ((int)(((byte)(107)))));
			office2010Red1.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
			office2010Red1.SelectedTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
			office2010Red1.TextColor = System.Drawing.Color.White;
			this.btn_limpiar_todo.ColorTable = office2010Red1;
			this.btn_limpiar_todo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_limpiar_todo.Location = new System.Drawing.Point(570, 425);
			this.btn_limpiar_todo.Name = "btn_limpiar_todo";
			this.btn_limpiar_todo.Size = new System.Drawing.Size(100, 41);
			this.btn_limpiar_todo.TabIndex = 7;
			this.btn_limpiar_todo.Text = "Limpiar Todo";
			this.btn_limpiar_todo.Theme = ManiXButton.Theme.MSOffice2010_RED;
			this.btn_limpiar_todo.UseVisualStyleBackColor = true;
			this.btn_limpiar_todo.Click += new System.EventHandler(this.Btn_limpiar_todoClick);
			// 
			// btn_pedido_listo
			// 
			this.btn_pedido_listo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			office2010Green1.BorderColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(72)))), ((int)(((byte)(161)))));
			office2010Green1.BorderColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(135)))), ((int)(((byte)(228)))));
			office2010Green1.ButtonMouseOverColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(199)))), ((int)(((byte)(87)))));
			office2010Green1.ButtonMouseOverColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(243)))), ((int)(((byte)(215)))));
			office2010Green1.ButtonMouseOverColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(225)))), ((int)(((byte)(137)))));
			office2010Green1.ButtonMouseOverColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(249)))), ((int)(((byte)(224)))));
			office2010Green1.ButtonNormalColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(126)))), ((int)(((byte)(43)))));
			office2010Green1.ButtonNormalColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(184)))), ((int)(((byte)(67)))));
			office2010Green1.ButtonNormalColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(126)))), ((int)(((byte)(43)))));
			office2010Green1.ButtonNormalColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(184)))), ((int)(((byte)(67)))));
			office2010Green1.ButtonSelectedColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(199)))), ((int)(((byte)(87)))));
			office2010Green1.ButtonSelectedColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(243)))), ((int)(((byte)(215)))));
			office2010Green1.ButtonSelectedColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(117)))));
			office2010Green1.ButtonSelectedColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(216)))), ((int)(((byte)(107)))));
			office2010Green1.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
			office2010Green1.SelectedTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
			office2010Green1.TextColor = System.Drawing.Color.White;
			this.btn_pedido_listo.ColorTable = office2010Green1;
			this.btn_pedido_listo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_pedido_listo.Location = new System.Drawing.Point(766, 425);
			this.btn_pedido_listo.Name = "btn_pedido_listo";
			this.btn_pedido_listo.Size = new System.Drawing.Size(100, 41);
			this.btn_pedido_listo.TabIndex = 8;
			this.btn_pedido_listo.Text = "Siguiente";
			this.btn_pedido_listo.Theme = ManiXButton.Theme.MSOffice2010_Green;
			this.btn_pedido_listo.Click += new System.EventHandler(this.Btn_pedido_listoClick);
			// 
			// groupBox6
			// 
			this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left)));
			this.groupBox6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.groupBox6.Controls.Add(this.data_base);
			this.groupBox6.Location = new System.Drawing.Point(3, 3);
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.Size = new System.Drawing.Size(561, 254);
			this.groupBox6.TabIndex = 16;
			this.groupBox6.TabStop = false;
			this.groupBox6.Text = "ALTERNATIVAS";
			// 
			// data_base
			// 
			this.data_base.AllowUserToAddRows = false;
			this.data_base.AllowUserToDeleteRows = false;
			this.data_base.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.data_base.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.data_base.BackgroundColor = System.Drawing.Color.RoyalBlue;
			this.data_base.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.data_base.DefaultCellStyle = dataGridViewCellStyle1;
			this.data_base.Dock = System.Windows.Forms.DockStyle.Fill;
			this.data_base.Location = new System.Drawing.Point(3, 17);
			this.data_base.Name = "data_base";
			this.data_base.ReadOnly = true;
			this.data_base.Size = new System.Drawing.Size(555, 234);
			this.data_base.TabIndex = 0;
			this.data_base.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Data_baseCellContentClick);
			// 
			// groupBox5
			// 
			this.groupBox5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.groupBox5.Controls.Add(this.label_precio_total);
			this.groupBox5.Location = new System.Drawing.Point(570, 293);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(295, 65);
			this.groupBox5.TabIndex = 15;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "TOTAL:";
			// 
			// label_precio_total
			// 
			this.label_precio_total.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label_precio_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_precio_total.Location = new System.Drawing.Point(3, 17);
			this.label_precio_total.Name = "label_precio_total";
			this.label_precio_total.Size = new System.Drawing.Size(289, 45);
			this.label_precio_total.TabIndex = 0;
			this.label_precio_total.Text = "0";
			this.label_precio_total.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// groupBox4
			// 
			this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.groupBox4.Controls.Add(this.lista_pedidos_armado);
			this.groupBox4.Location = new System.Drawing.Point(570, 3);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(295, 284);
			this.groupBox4.TabIndex = 14;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "PEDIDOS";
			// 
			// lista_pedidos_armado
			// 
			this.lista_pedidos_armado.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lista_pedidos_armado.Enabled = false;
			this.lista_pedidos_armado.FormattingEnabled = true;
			this.lista_pedidos_armado.HorizontalScrollbar = true;
			this.lista_pedidos_armado.Location = new System.Drawing.Point(3, 17);
			this.lista_pedidos_armado.Name = "lista_pedidos_armado";
			this.lista_pedidos_armado.Size = new System.Drawing.Size(289, 264);
			this.lista_pedidos_armado.TabIndex = 6;
			// 
			// groupBox3
			// 
			this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.groupBox3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.groupBox3.Controls.Add(this.btn_quitar_ingrediente);
			this.groupBox3.Controls.Add(this.btn_listo_ingrediente);
			this.groupBox3.Controls.Add(this.lista_ingredientes);
			this.groupBox3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox3.Location = new System.Drawing.Point(6, 304);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(291, 171);
			this.groupBox3.TabIndex = 13;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "INGREDIENTES";
			// 
			// btn_quitar_ingrediente
			// 
			this.btn_quitar_ingrediente.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btn_quitar_ingrediente.ColorTable = office2010Blue1;
			this.btn_quitar_ingrediente.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_quitar_ingrediente.Location = new System.Drawing.Point(81, 116);
			this.btn_quitar_ingrediente.Name = "btn_quitar_ingrediente";
			this.btn_quitar_ingrediente.Size = new System.Drawing.Size(100, 41);
			this.btn_quitar_ingrediente.TabIndex = 0;
			this.btn_quitar_ingrediente.Text = "Quitar";
			this.btn_quitar_ingrediente.Theme = ManiXButton.Theme.MSOffice2010_BLUE;
			this.btn_quitar_ingrediente.Click += new System.EventHandler(this.Btn_quitar_ingredienteClick);
			// 
			// btn_listo_ingrediente
			// 
			this.btn_listo_ingrediente.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btn_listo_ingrediente.ColorTable = office2010Blue1;
			this.btn_listo_ingrediente.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_listo_ingrediente.Location = new System.Drawing.Point(186, 116);
			this.btn_listo_ingrediente.Name = "btn_listo_ingrediente";
			this.btn_listo_ingrediente.Size = new System.Drawing.Size(100, 41);
			this.btn_listo_ingrediente.TabIndex = 1;
			this.btn_listo_ingrediente.Text = "Listo";
			this.btn_listo_ingrediente.Theme = ManiXButton.Theme.MSOffice2010_BLUE;
			this.btn_listo_ingrediente.Click += new System.EventHandler(this.Btn_listo_ingredienteClick);
			// 
			// lista_ingredientes
			// 
			this.lista_ingredientes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.lista_ingredientes.FormattingEnabled = true;
			this.lista_ingredientes.Location = new System.Drawing.Point(5, 19);
			this.lista_ingredientes.MultiColumn = true;
			this.lista_ingredientes.Name = "lista_ingredientes";
			this.lista_ingredientes.Size = new System.Drawing.Size(280, 84);
			this.lista_ingredientes.TabIndex = 3;
			// 
			// tabCliente
			// 
			this.tabCliente.Controls.Add(this.groupBox14);
			this.tabCliente.Controls.Add(this.groupBox13);
			this.tabCliente.Controls.Add(this.groupBox9);
			this.tabCliente.Controls.Add(this.groupBox11);
			this.tabCliente.Controls.Add(this.panel1);
			this.tabCliente.Controls.Add(this.groupBox7);
			this.tabCliente.Location = new System.Drawing.Point(4, 25);
			this.tabCliente.Name = "tabCliente";
			this.tabCliente.Padding = new System.Windows.Forms.Padding(3);
			this.tabCliente.Size = new System.Drawing.Size(869, 481);
			this.tabCliente.TabIndex = 1;
			this.tabCliente.Text = "Cliente";
			this.tabCliente.UseVisualStyleBackColor = true;
			// 
			// groupBox14
			// 
			this.groupBox14.Controls.Add(this.label_precio_total3);
			this.groupBox14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox14.Location = new System.Drawing.Point(674, 277);
			this.groupBox14.Name = "groupBox14";
			this.groupBox14.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.groupBox14.Size = new System.Drawing.Size(189, 80);
			this.groupBox14.TabIndex = 27;
			this.groupBox14.TabStop = false;
			this.groupBox14.Text = "TOTAL $ con dcto.";
			// 
			// label_precio_total3
			// 
			this.label_precio_total3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label_precio_total3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_precio_total3.Location = new System.Drawing.Point(3, 18);
			this.label_precio_total3.Name = "label_precio_total3";
			this.label_precio_total3.Size = new System.Drawing.Size(183, 59);
			this.label_precio_total3.TabIndex = 1;
			this.label_precio_total3.Text = "0";
			this.label_precio_total3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// groupBox13
			// 
			this.groupBox13.Controls.Add(this.button4);
			this.groupBox13.Controls.Add(this.num_descuento);
			this.groupBox13.Controls.Add(this.button3);
			this.groupBox13.Controls.Add(this.label13);
			this.groupBox13.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox13.Location = new System.Drawing.Point(674, 6);
			this.groupBox13.Name = "groupBox13";
			this.groupBox13.Size = new System.Drawing.Size(189, 92);
			this.groupBox13.TabIndex = 26;
			this.groupBox13.TabStop = false;
			this.groupBox13.Text = "Descuento";
			// 
			// button4
			// 
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
			this.button4.Location = new System.Drawing.Point(104, 56);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(77, 26);
			this.button4.TabIndex = 31;
			this.button4.Text = "Deshacer";
			this.button4.UseVisualStyleBackColor = true;
			// 
			// num_descuento
			// 
			this.num_descuento.DecimalPlaces = 1;
			this.num_descuento.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.num_descuento.Location = new System.Drawing.Point(6, 20);
			this.num_descuento.Name = "num_descuento";
			this.num_descuento.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.num_descuento.Size = new System.Drawing.Size(142, 27);
			this.num_descuento.TabIndex = 27;
			this.num_descuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// button3
			// 
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
			this.button3.Location = new System.Drawing.Point(8, 56);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(77, 26);
			this.button3.TabIndex = 29;
			this.button3.Text = "Aplicar";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// label13
			// 
			this.label13.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(154, 20);
			this.label13.Name = "label13";
			this.label13.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label13.Size = new System.Drawing.Size(29, 27);
			this.label13.TabIndex = 30;
			this.label13.Text = "%";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// groupBox9
			// 
			this.groupBox9.Controls.Add(this.rb_tarjeta);
			this.groupBox9.Controls.Add(this.rb_efectivo);
			this.groupBox9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox9.Location = new System.Drawing.Point(674, 104);
			this.groupBox9.Name = "groupBox9";
			this.groupBox9.Size = new System.Drawing.Size(189, 92);
			this.groupBox9.TabIndex = 25;
			this.groupBox9.TabStop = false;
			this.groupBox9.Text = "Medio Pago";
			// 
			// rb_tarjeta
			// 
			this.rb_tarjeta.Location = new System.Drawing.Point(15, 57);
			this.rb_tarjeta.Name = "rb_tarjeta";
			this.rb_tarjeta.Size = new System.Drawing.Size(104, 24);
			this.rb_tarjeta.TabIndex = 1;
			this.rb_tarjeta.Text = "Red Compra";
			this.rb_tarjeta.UseVisualStyleBackColor = true;
			this.rb_tarjeta.CheckedChanged += new System.EventHandler(this.Rb_tarjetaCheckedChanged);
			// 
			// rb_efectivo
			// 
			this.rb_efectivo.Checked = true;
			this.rb_efectivo.Location = new System.Drawing.Point(15, 20);
			this.rb_efectivo.Name = "rb_efectivo";
			this.rb_efectivo.Size = new System.Drawing.Size(104, 24);
			this.rb_efectivo.TabIndex = 0;
			this.rb_efectivo.TabStop = true;
			this.rb_efectivo.Text = "Efectivo";
			this.rb_efectivo.UseVisualStyleBackColor = true;
			this.rb_efectivo.CheckedChanged += new System.EventHandler(this.Rb_efectivoCheckedChanged);
			// 
			// groupBox11
			// 
			this.groupBox11.Controls.Add(this.label1);
			this.groupBox11.Controls.Add(this.num_efectivo_cliente);
			this.groupBox11.Location = new System.Drawing.Point(674, 202);
			this.groupBox11.Name = "groupBox11";
			this.groupBox11.Size = new System.Drawing.Size(189, 69);
			this.groupBox11.TabIndex = 26;
			this.groupBox11.TabStop = false;
			this.groupBox11.Text = "Cancela $";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(152, 26);
			this.label1.Name = "label1";
			this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label1.Size = new System.Drawing.Size(29, 27);
			this.label1.TabIndex = 32;
			this.label1.Text = "$";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// num_efectivo_cliente
			// 
			this.num_efectivo_cliente.Font = new System.Drawing.Font("Tahoma", 10.25F);
			this.num_efectivo_cliente.Increment = new decimal(new int[] {
			10,
			0,
			0,
			0});
			this.num_efectivo_cliente.Location = new System.Drawing.Point(17, 29);
			this.num_efectivo_cliente.Maximum = new decimal(new int[] {
			100000,
			0,
			0,
			0});
			this.num_efectivo_cliente.Name = "num_efectivo_cliente";
			this.num_efectivo_cliente.Size = new System.Drawing.Size(131, 24);
			this.num_efectivo_cliente.TabIndex = 0;
			this.num_efectivo_cliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.groupBox8);
			this.panel1.Controls.Add(this.btn_actualizar_clientes);
			this.panel1.Controls.Add(this.btn_nuevocliente);
			this.panel1.Controls.Add(this.Btn_cliente_listo);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.panel1.Location = new System.Drawing.Point(3, 358);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(863, 120);
			this.panel1.TabIndex = 7;
			// 
			// groupBox8
			// 
			this.groupBox8.Controls.Add(this.btn_filtrar_cliente);
			this.groupBox8.Controls.Add(this.cliente_filtro_nombre);
			this.groupBox8.Location = new System.Drawing.Point(5, 6);
			this.groupBox8.Name = "groupBox8";
			this.groupBox8.Size = new System.Drawing.Size(190, 106);
			this.groupBox8.TabIndex = 14;
			this.groupBox8.TabStop = false;
			this.groupBox8.Text = "Palabra Clave";
			// 
			// btn_filtrar_cliente
			// 
			this.btn_filtrar_cliente.ColorTable = office2010Blue1;
			this.btn_filtrar_cliente.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
			this.btn_filtrar_cliente.Location = new System.Drawing.Point(67, 55);
			this.btn_filtrar_cliente.Name = "btn_filtrar_cliente";
			this.btn_filtrar_cliente.Size = new System.Drawing.Size(100, 41);
			this.btn_filtrar_cliente.TabIndex = 0;
			this.btn_filtrar_cliente.Text = "Filtrar";
			this.btn_filtrar_cliente.Theme = ManiXButton.Theme.MSOffice2010_BLUE;
			this.btn_filtrar_cliente.Click += new System.EventHandler(this.Btn_filtrar_clienteClick);
			// 
			// cliente_filtro_nombre
			// 
			this.cliente_filtro_nombre.AcceptsReturn = true;
			this.cliente_filtro_nombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.cliente_filtro_nombre.Location = new System.Drawing.Point(10, 28);
			this.cliente_filtro_nombre.Name = "cliente_filtro_nombre";
			this.cliente_filtro_nombre.Size = new System.Drawing.Size(169, 21);
			this.cliente_filtro_nombre.TabIndex = 0;
			// 
			// btn_actualizar_clientes
			// 
			this.btn_actualizar_clientes.ColorTable = office2010Blue1;
			this.btn_actualizar_clientes.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
			this.btn_actualizar_clientes.Location = new System.Drawing.Point(415, 14);
			this.btn_actualizar_clientes.Name = "btn_actualizar_clientes";
			this.btn_actualizar_clientes.Size = new System.Drawing.Size(100, 41);
			this.btn_actualizar_clientes.TabIndex = 3;
			this.btn_actualizar_clientes.Text = "Recargar Clientes";
			this.btn_actualizar_clientes.Theme = ManiXButton.Theme.MSOffice2010_BLUE;
			this.btn_actualizar_clientes.Click += new System.EventHandler(this.Btn_actualizar_clientesClick);
			// 
			// btn_nuevocliente
			// 
			this.btn_nuevocliente.ColorTable = office2010Green1;
			this.btn_nuevocliente.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
			this.btn_nuevocliente.Location = new System.Drawing.Point(563, 14);
			this.btn_nuevocliente.Name = "btn_nuevocliente";
			this.btn_nuevocliente.Size = new System.Drawing.Size(100, 41);
			this.btn_nuevocliente.TabIndex = 1;
			this.btn_nuevocliente.Text = "Nuevo Cliente";
			this.btn_nuevocliente.Theme = ManiXButton.Theme.MSOffice2010_Green;
			this.btn_nuevocliente.Click += new System.EventHandler(this.Btn_nuevoclienteClick);
			// 
			// Btn_cliente_listo
			// 
			this.Btn_cliente_listo.ColorTable = office2010Blue1;
			this.Btn_cliente_listo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
			this.Btn_cliente_listo.Location = new System.Drawing.Point(760, 64);
			this.Btn_cliente_listo.Name = "Btn_cliente_listo";
			this.Btn_cliente_listo.Size = new System.Drawing.Size(100, 41);
			this.Btn_cliente_listo.TabIndex = 2;
			this.Btn_cliente_listo.Text = "Siguiente";
			this.Btn_cliente_listo.Theme = ManiXButton.Theme.MSOffice2010_BLUE;
			this.Btn_cliente_listo.Click += new System.EventHandler(this.Btn_cliente_listoClick);
			// 
			// groupBox7
			// 
			this.groupBox7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left)));
			this.groupBox7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.groupBox7.Controls.Add(this.data_cliente);
			this.groupBox7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox7.Location = new System.Drawing.Point(8, 6);
			this.groupBox7.Name = "groupBox7";
			this.groupBox7.Size = new System.Drawing.Size(663, 351);
			this.groupBox7.TabIndex = 6;
			this.groupBox7.TabStop = false;
			this.groupBox7.Text = "INFORMACIÓN";
			// 
			// data_cliente
			// 
			this.data_cliente.AllowUserToAddRows = false;
			this.data_cliente.AllowUserToDeleteRows = false;
			this.data_cliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.data_cliente.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.data_cliente.BackgroundColor = System.Drawing.Color.RoyalBlue;
			this.data_cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.data_cliente.DefaultCellStyle = dataGridViewCellStyle2;
			this.data_cliente.Location = new System.Drawing.Point(5, 15);
			this.data_cliente.Name = "data_cliente";
			this.data_cliente.ReadOnly = true;
			this.data_cliente.Size = new System.Drawing.Size(653, 330);
			this.data_cliente.TabIndex = 0;
			this.data_cliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Data_clienteCellContentClick);
			this.data_cliente.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Data_clienteCellContentDoubleClick);
			// 
			// tabOrden
			// 
			this.tabOrden.BackgroundImage = global::cgcommerce.imagenes.Cashbox_256;
			this.tabOrden.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.tabOrden.Controls.Add(this.groupBox12);
			this.tabOrden.Controls.Add(this.groupBox10);
			this.tabOrden.Controls.Add(this.orden_nombre_vendedor);
			this.tabOrden.Controls.Add(this.label11);
			this.tabOrden.Controls.Add(this.orden_idcliente);
			this.tabOrden.Controls.Add(this.orden_cb_nro_orden);
			this.tabOrden.Controls.Add(this.btn_generar_pedido);
			this.tabOrden.Controls.Add(this.groupBox1);
			this.tabOrden.Controls.Add(this.orden_lista_pedidos);
			this.tabOrden.Controls.Add(this.orden_direcioncliente);
			this.tabOrden.Controls.Add(this.orden_telefonocliente);
			this.tabOrden.Controls.Add(this.orden_nombrecliente);
			this.tabOrden.Controls.Add(this.orden_rut_vendedor);
			this.tabOrden.Controls.Add(this.label9);
			this.tabOrden.Controls.Add(this.label8);
			this.tabOrden.Controls.Add(this.label7);
			this.tabOrden.Controls.Add(this.label6);
			this.tabOrden.Controls.Add(this.label5);
			this.tabOrden.Controls.Add(this.label4);
			this.tabOrden.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tabOrden.Location = new System.Drawing.Point(4, 25);
			this.tabOrden.Name = "tabOrden";
			this.tabOrden.Padding = new System.Windows.Forms.Padding(3);
			this.tabOrden.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.tabOrden.Size = new System.Drawing.Size(869, 481);
			this.tabOrden.TabIndex = 2;
			this.tabOrden.Text = "Orden";
			this.tabOrden.UseVisualStyleBackColor = true;
			// 
			// groupBox12
			// 
			this.groupBox12.Controls.Add(this.vuelto_cliente);
			this.groupBox12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox12.Location = new System.Drawing.Point(272, 323);
			this.groupBox12.Name = "groupBox12";
			this.groupBox12.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.groupBox12.Size = new System.Drawing.Size(153, 50);
			this.groupBox12.TabIndex = 15;
			this.groupBox12.TabStop = false;
			this.groupBox12.Text = "VUELTO CLIENTE";
			// 
			// vuelto_cliente
			// 
			this.vuelto_cliente.Dock = System.Windows.Forms.DockStyle.Fill;
			this.vuelto_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.vuelto_cliente.Location = new System.Drawing.Point(3, 18);
			this.vuelto_cliente.Name = "vuelto_cliente";
			this.vuelto_cliente.Size = new System.Drawing.Size(147, 29);
			this.vuelto_cliente.TabIndex = 1;
			this.vuelto_cliente.Text = "0";
			this.vuelto_cliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// groupBox10
			// 
			this.groupBox10.Controls.Add(this.label_precio_real);
			this.groupBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox10.Location = new System.Drawing.Point(95, 323);
			this.groupBox10.Name = "groupBox10";
			this.groupBox10.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.groupBox10.Size = new System.Drawing.Size(148, 50);
			this.groupBox10.TabIndex = 14;
			this.groupBox10.TabStop = false;
			this.groupBox10.Text = "TOTAL $";
			// 
			// label_precio_real
			// 
			this.label_precio_real.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label_precio_real.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_precio_real.Location = new System.Drawing.Point(3, 18);
			this.label_precio_real.Name = "label_precio_real";
			this.label_precio_real.Size = new System.Drawing.Size(142, 29);
			this.label_precio_real.TabIndex = 1;
			this.label_precio_real.Text = "0";
			this.label_precio_real.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// orden_nombre_vendedor
			// 
			this.orden_nombre_vendedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
			this.orden_nombre_vendedor.Enabled = false;
			this.orden_nombre_vendedor.FormattingEnabled = true;
			this.orden_nombre_vendedor.Location = new System.Drawing.Point(219, 36);
			this.orden_nombre_vendedor.Name = "orden_nombre_vendedor";
			this.orden_nombre_vendedor.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.orden_nombre_vendedor.Size = new System.Drawing.Size(206, 21);
			this.orden_nombre_vendedor.TabIndex = 18;
			this.orden_nombre_vendedor.TabStop = false;
			// 
			// label11
			// 
			this.label11.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(8, 63);
			this.label11.Name = "label11";
			this.label11.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label11.Size = new System.Drawing.Size(83, 15);
			this.label11.TabIndex = 17;
			this.label11.Text = "Nro. Cliente (*)";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// orden_idcliente
			// 
			this.orden_idcliente.Enabled = false;
			this.orden_idcliente.Location = new System.Drawing.Point(95, 61);
			this.orden_idcliente.Name = "orden_idcliente";
			this.orden_idcliente.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.orden_idcliente.Size = new System.Drawing.Size(330, 21);
			this.orden_idcliente.TabIndex = 16;
			// 
			// orden_cb_nro_orden
			// 
			this.orden_cb_nro_orden.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
			this.orden_cb_nro_orden.Enabled = false;
			this.orden_cb_nro_orden.FormattingEnabled = true;
			this.orden_cb_nro_orden.Location = new System.Drawing.Point(95, 8);
			this.orden_cb_nro_orden.Name = "orden_cb_nro_orden";
			this.orden_cb_nro_orden.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.orden_cb_nro_orden.Size = new System.Drawing.Size(330, 21);
			this.orden_cb_nro_orden.TabIndex = 0;
			// 
			// btn_generar_pedido
			// 
			this.btn_generar_pedido.ColorTable = office2010Blue1;
			this.btn_generar_pedido.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
			this.btn_generar_pedido.Image = global::cgcommerce.imagenes.Printer_blue_256;
			this.btn_generar_pedido.Location = new System.Drawing.Point(623, 393);
			this.btn_generar_pedido.Name = "btn_generar_pedido";
			this.btn_generar_pedido.Size = new System.Drawing.Size(202, 64);
			this.btn_generar_pedido.TabIndex = 11;
			this.btn_generar_pedido.Text = "Guardar Pedido";
			this.btn_generar_pedido.Theme = ManiXButton.Theme.MSOffice2010_BLUE;
			this.btn_generar_pedido.Click += new System.EventHandler(this.Btn_generar_pedidoClick);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label_precio_total2);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(95, 393);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.groupBox1.Size = new System.Drawing.Size(330, 64);
			this.groupBox1.TabIndex = 13;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "TOTAL $ con dcto.";
			// 
			// label_precio_total2
			// 
			this.label_precio_total2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label_precio_total2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_precio_total2.Location = new System.Drawing.Point(3, 18);
			this.label_precio_total2.Name = "label_precio_total2";
			this.label_precio_total2.Size = new System.Drawing.Size(324, 43);
			this.label_precio_total2.TabIndex = 1;
			this.label_precio_total2.Text = "0";
			this.label_precio_total2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// orden_lista_pedidos
			// 
			this.orden_lista_pedidos.Location = new System.Drawing.Point(95, 178);
			this.orden_lista_pedidos.MaxLength = 255;
			this.orden_lista_pedidos.Multiline = true;
			this.orden_lista_pedidos.Name = "orden_lista_pedidos";
			this.orden_lista_pedidos.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.orden_lista_pedidos.Size = new System.Drawing.Size(330, 131);
			this.orden_lista_pedidos.TabIndex = 9;
			// 
			// orden_direcioncliente
			// 
			this.orden_direcioncliente.Location = new System.Drawing.Point(95, 139);
			this.orden_direcioncliente.Name = "orden_direcioncliente";
			this.orden_direcioncliente.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.orden_direcioncliente.Size = new System.Drawing.Size(330, 21);
			this.orden_direcioncliente.TabIndex = 7;
			// 
			// orden_telefonocliente
			// 
			this.orden_telefonocliente.Location = new System.Drawing.Point(95, 113);
			this.orden_telefonocliente.Name = "orden_telefonocliente";
			this.orden_telefonocliente.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.orden_telefonocliente.Size = new System.Drawing.Size(330, 21);
			this.orden_telefonocliente.TabIndex = 5;
			// 
			// orden_nombrecliente
			// 
			this.orden_nombrecliente.Enabled = false;
			this.orden_nombrecliente.Location = new System.Drawing.Point(95, 87);
			this.orden_nombrecliente.Name = "orden_nombrecliente";
			this.orden_nombrecliente.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.orden_nombrecliente.Size = new System.Drawing.Size(330, 21);
			this.orden_nombrecliente.TabIndex = 3;
			// 
			// orden_rut_vendedor
			// 
			this.orden_rut_vendedor.Location = new System.Drawing.Point(95, 36);
			this.orden_rut_vendedor.Name = "orden_rut_vendedor";
			this.orden_rut_vendedor.ReadOnly = true;
			this.orden_rut_vendedor.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.orden_rut_vendedor.Size = new System.Drawing.Size(118, 21);
			this.orden_rut_vendedor.TabIndex = 1;
			this.orden_rut_vendedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(6, 181);
			this.label9.Name = "label9";
			this.label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label9.Size = new System.Drawing.Size(83, 15);
			this.label9.TabIndex = 10;
			this.label9.Text = "Pedido (*) ";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(6, 142);
			this.label8.Name = "label8";
			this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label8.Size = new System.Drawing.Size(83, 15);
			this.label8.TabIndex = 8;
			this.label8.Text = "Dirección (*) ";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(6, 116);
			this.label7.Name = "label7";
			this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label7.Size = new System.Drawing.Size(83, 15);
			this.label7.TabIndex = 6;
			this.label7.Text = "Telefono (*) ";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(6, 90);
			this.label6.Name = "label6";
			this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label6.Size = new System.Drawing.Size(83, 15);
			this.label6.TabIndex = 4;
			this.label6.Text = "Cliente (*) ";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(6, 38);
			this.label5.Name = "label5";
			this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label5.Size = new System.Drawing.Size(83, 15);
			this.label5.TabIndex = 2;
			this.label5.Text = "Vendedor :";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(7, 9);
			this.label4.Name = "label4";
			this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label4.Size = new System.Drawing.Size(86, 17);
			this.label4.TabIndex = 0;
			this.label4.Text = "Nro. Orden ";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// add_pedido
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(902, 560);
			this.Controls.Add(this.fusionTheme1);
			this.Controls.Add(this.picture_logo);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximumSize = new System.Drawing.Size(902, 560);
			this.MinimumSize = new System.Drawing.Size(902, 560);
			this.Name = "add_pedido";
			this.Text = "PEDIDOS";
			this.TransparencyKey = System.Drawing.Color.Fuchsia;
			((System.ComponentModel.ISupportInitialize)(this.picture_logo)).EndInit();
			this.fusionTheme1.ResumeLayout(false);
			this.TabPrincipal.ResumeLayout(false);
			this.tabPedido.ResumeLayout(false);
			this.tabPedido.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox6.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.data_base)).EndInit();
			this.groupBox5.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.tabCliente.ResumeLayout(false);
			this.groupBox14.ResumeLayout(false);
			this.groupBox13.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.num_descuento)).EndInit();
			this.groupBox9.ResumeLayout(false);
			this.groupBox11.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.num_efectivo_cliente)).EndInit();
			this.panel1.ResumeLayout(false);
			this.groupBox8.ResumeLayout(false);
			this.groupBox8.PerformLayout();
			this.groupBox7.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.data_cliente)).EndInit();
			this.tabOrden.ResumeLayout(false);
			this.tabOrden.PerformLayout();
			this.groupBox12.ResumeLayout(false);
			this.groupBox10.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		private FusionTheme fusionTheme1;
		private FusionButton btn_salir;
		private System.Windows.Forms.ComboBox orden_cb_nro_orden;
		private System.Windows.Forms.Label label_precio_total2;
		private System.Windows.Forms.TextBox tb_precio_espera;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox orden_idcliente;
		private ManiXButton.XButton btn_actualizar_clientes;
		private System.Windows.Forms.ComboBox orden_nombre_vendedor;
		private System.Windows.Forms.GroupBox groupBox9;
		private System.Windows.Forms.RadioButton rb_tarjeta;
		private System.Windows.Forms.RadioButton rb_efectivo;
		private System.Windows.Forms.GroupBox groupBox10;
		private System.Windows.Forms.Label label_precio_real;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.NumericUpDown num_descuento;
		private System.Windows.Forms.GroupBox groupBox11;
		private System.Windows.Forms.NumericUpDown num_efectivo_cliente;
		private System.Windows.Forms.GroupBox groupBox12;
		private System.Windows.Forms.Label vuelto_cliente;
		private System.Windows.Forms.GroupBox groupBox13;
		private System.Windows.Forms.GroupBox groupBox14;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tb_nombre_pedido;
		private System.Windows.Forms.TextBox tb_contador_pedido;
		private System.Windows.Forms.TextBox tb_id_pedido;
	}
}
