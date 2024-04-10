namespace reparaciones_UI
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCargarPresupuesto = new System.Windows.Forms.Button();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.btnAddVehiculo = new System.Windows.Forms.Button();
            this.panMoto = new System.Windows.Forms.Panel();
            this.lblCilindrada = new System.Windows.Forms.Label();
            this.txtCilindrada = new System.Windows.Forms.TextBox();
            this.panAuto = new System.Windows.Forms.Panel();
            this.lblPuertas = new System.Windows.Forms.Label();
            this.txtPuertas = new System.Windows.Forms.TextBox();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.lblTipoAuto = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.optMoto = new System.Windows.Forms.RadioButton();
            this.optAuto = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPatente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtPatenteTitle = new System.Windows.Forms.Label();
            this.txtModeloTitle = new System.Windows.Forms.Label();
            this.txtMarcaTitle = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numDias = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgRepuestos = new System.Windows.Forms.DataGridView();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAddDesperfecto = new System.Windows.Forms.Button();
            this.txtManoDeObra = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.dgDesperfectos = new System.Windows.Forms.DataGridView();
            this.printer = new System.Drawing.Printing.PrintDocument();
            this.tabMain.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panMoto.SuspendLayout();
            this.panAuto.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDias)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgRepuestos)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDesperfectos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCargarPresupuesto
            // 
            this.btnCargarPresupuesto.Location = new System.Drawing.Point(570, 424);
            this.btnCargarPresupuesto.Name = "btnCargarPresupuesto";
            this.btnCargarPresupuesto.Size = new System.Drawing.Size(110, 28);
            this.btnCargarPresupuesto.TabIndex = 15;
            this.btnCargarPresupuesto.Text = "Presupuesto";
            this.btnCargarPresupuesto.UseVisualStyleBackColor = true;
            this.btnCargarPresupuesto.Click += new System.EventHandler(this.btnCargarPresupuesto_Click);
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabPage1);
            this.tabMain.Controls.Add(this.tabPage2);
            this.tabMain.Location = new System.Drawing.Point(3, 3);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(712, 499);
            this.tabMain.TabIndex = 18;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.btnAddVehiculo);
            this.tabPage1.Controls.Add(this.panMoto);
            this.tabPage1.Controls.Add(this.panAuto);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtPatente);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtModelo);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtMarca);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(704, 473);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Vehículo";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(15, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 17);
            this.label10.TabIndex = 28;
            this.label10.Text = "Ingresar Vehículo";
            // 
            // btnAddVehiculo
            // 
            this.btnAddVehiculo.Location = new System.Drawing.Point(527, 248);
            this.btnAddVehiculo.Name = "btnAddVehiculo";
            this.btnAddVehiculo.Size = new System.Drawing.Size(110, 28);
            this.btnAddVehiculo.TabIndex = 7;
            this.btnAddVehiculo.Text = "Agregar Vehículo";
            this.btnAddVehiculo.UseVisualStyleBackColor = true;
            this.btnAddVehiculo.Click += new System.EventHandler(this.btnAddVehiculo_Click);
            // 
            // panMoto
            // 
            this.panMoto.Controls.Add(this.lblCilindrada);
            this.panMoto.Controls.Add(this.txtCilindrada);
            this.panMoto.Location = new System.Drawing.Point(336, 156);
            this.panMoto.Name = "panMoto";
            this.panMoto.Size = new System.Drawing.Size(328, 37);
            this.panMoto.TabIndex = 0;
            this.panMoto.Visible = false;
            // 
            // lblCilindrada
            // 
            this.lblCilindrada.AutoSize = true;
            this.lblCilindrada.Location = new System.Drawing.Point(21, 6);
            this.lblCilindrada.Name = "lblCilindrada";
            this.lblCilindrada.Size = new System.Drawing.Size(53, 13);
            this.lblCilindrada.TabIndex = 17;
            this.lblCilindrada.Text = "Cilindrada";
            // 
            // txtCilindrada
            // 
            this.txtCilindrada.Location = new System.Drawing.Point(130, 6);
            this.txtCilindrada.Name = "txtCilindrada";
            this.txtCilindrada.Size = new System.Drawing.Size(171, 20);
            this.txtCilindrada.TabIndex = 6;
            // 
            // panAuto
            // 
            this.panAuto.Controls.Add(this.lblPuertas);
            this.panAuto.Controls.Add(this.txtPuertas);
            this.panAuto.Controls.Add(this.cboTipo);
            this.panAuto.Controls.Add(this.lblTipoAuto);
            this.panAuto.Location = new System.Drawing.Point(356, 156);
            this.panAuto.Name = "panAuto";
            this.panAuto.Size = new System.Drawing.Size(293, 73);
            this.panAuto.TabIndex = 25;
            // 
            // lblPuertas
            // 
            this.lblPuertas.AutoSize = true;
            this.lblPuertas.Location = new System.Drawing.Point(1, 39);
            this.lblPuertas.Name = "lblPuertas";
            this.lblPuertas.Size = new System.Drawing.Size(103, 13);
            this.lblPuertas.TabIndex = 14;
            this.lblPuertas.Text = "Cantidad de Puertas";
            // 
            // txtPuertas
            // 
            this.txtPuertas.Location = new System.Drawing.Point(110, 36);
            this.txtPuertas.Name = "txtPuertas";
            this.txtPuertas.Size = new System.Drawing.Size(171, 20);
            this.txtPuertas.TabIndex = 5;
            this.txtPuertas.TextChanged += new System.EventHandler(this.txtPuertas_TextChanged);
            // 
            // cboTipo
            // 
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Location = new System.Drawing.Point(110, 4);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(171, 21);
            this.cboTipo.TabIndex = 4;
            // 
            // lblTipoAuto
            // 
            this.lblTipoAuto.AutoSize = true;
            this.lblTipoAuto.Location = new System.Drawing.Point(1, 6);
            this.lblTipoAuto.Name = "lblTipoAuto";
            this.lblTipoAuto.Size = new System.Drawing.Size(28, 13);
            this.lblTipoAuto.TabIndex = 5;
            this.lblTipoAuto.Text = "Tipo";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.optMoto);
            this.panel1.Controls.Add(this.optAuto);
            this.panel1.Location = new System.Drawing.Point(52, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 36);
            this.panel1.TabIndex = 24;
            // 
            // optMoto
            // 
            this.optMoto.AutoSize = true;
            this.optMoto.Location = new System.Drawing.Point(158, 10);
            this.optMoto.Name = "optMoto";
            this.optMoto.Size = new System.Drawing.Size(49, 17);
            this.optMoto.TabIndex = 17;
            this.optMoto.TabStop = true;
            this.optMoto.Text = "Moto";
            this.optMoto.UseVisualStyleBackColor = true;
            this.optMoto.CheckedChanged += new System.EventHandler(this.optMoto_CheckedChanged);
            // 
            // optAuto
            // 
            this.optAuto.AutoSize = true;
            this.optAuto.Location = new System.Drawing.Point(36, 10);
            this.optAuto.Name = "optAuto";
            this.optAuto.Size = new System.Drawing.Size(71, 17);
            this.optAuto.TabIndex = 0;
            this.optAuto.TabStop = true;
            this.optAuto.Text = "Automóvil";
            this.optAuto.UseVisualStyleBackColor = true;
            this.optAuto.CheckedChanged += new System.EventHandler(this.optAuto_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Patente";
            // 
            // txtPatente
            // 
            this.txtPatente.Location = new System.Drawing.Point(159, 160);
            this.txtPatente.Name = "txtPatente";
            this.txtPatente.Size = new System.Drawing.Size(171, 20);
            this.txtPatente.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(353, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Modelo";
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(466, 116);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(171, 20);
            this.txtModelo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Marca";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(161, 116);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(171, 20);
            this.txtMarca.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtPatenteTitle);
            this.tabPage2.Controls.Add(this.txtModeloTitle);
            this.tabPage2.Controls.Add(this.txtMarcaTitle);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.btnCargarPresupuesto);
            this.tabPage2.Controls.Add(this.dgDesperfectos);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(704, 473);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Presupuesto";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtPatenteTitle
            // 
            this.txtPatenteTitle.AutoSize = true;
            this.txtPatenteTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatenteTitle.Location = new System.Drawing.Point(545, 71);
            this.txtPatenteTitle.Name = "txtPatenteTitle";
            this.txtPatenteTitle.Size = new System.Drawing.Size(0, 17);
            this.txtPatenteTitle.TabIndex = 37;
            this.txtPatenteTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtModeloTitle
            // 
            this.txtModeloTitle.AutoSize = true;
            this.txtModeloTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModeloTitle.Location = new System.Drawing.Point(545, 45);
            this.txtModeloTitle.Name = "txtModeloTitle";
            this.txtModeloTitle.Size = new System.Drawing.Size(0, 17);
            this.txtModeloTitle.TabIndex = 36;
            this.txtModeloTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtMarcaTitle
            // 
            this.txtMarcaTitle.AutoSize = true;
            this.txtMarcaTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarcaTitle.Location = new System.Drawing.Point(545, 18);
            this.txtMarcaTitle.Name = "txtMarcaTitle";
            this.txtMarcaTitle.Size = new System.Drawing.Size(0, 17);
            this.txtMarcaTitle.TabIndex = 35;
            this.txtMarcaTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numDias);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.txtDescripcion);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.btnAddDesperfecto);
            this.groupBox2.Controls.Add(this.txtManoDeObra);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(6, 119);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(674, 196);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Desperfecto";
            // 
            // numDias
            // 
            this.numDias.Location = new System.Drawing.Point(367, 69);
            this.numDias.Name = "numDias";
            this.numDias.Size = new System.Drawing.Size(172, 20);
            this.numDias.TabIndex = 11;
            this.numDias.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgRepuestos);
            this.groupBox3.Location = new System.Drawing.Point(18, 97);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(520, 93);
            this.groupBox3.TabIndex = 33;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Repuestos";
            // 
            // dgRepuestos
            // 
            this.dgRepuestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRepuestos.Location = new System.Drawing.Point(9, 13);
            this.dgRepuestos.Name = "dgRepuestos";
            this.dgRepuestos.Size = new System.Drawing.Size(505, 74);
            this.dgRepuestos.TabIndex = 12;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(18, 41);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(236, 41);
            this.txtDescripcion.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Descripción de la Falla";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(286, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 32);
            this.label9.TabIndex = 32;
            this.label9.Text = "Tiempo (en días)";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddDesperfecto
            // 
            this.btnAddDesperfecto.Location = new System.Drawing.Point(558, 162);
            this.btnAddDesperfecto.Name = "btnAddDesperfecto";
            this.btnAddDesperfecto.Size = new System.Drawing.Size(110, 28);
            this.btnAddDesperfecto.TabIndex = 13;
            this.btnAddDesperfecto.Text = "Agregar";
            this.btnAddDesperfecto.UseVisualStyleBackColor = true;
            this.btnAddDesperfecto.Click += new System.EventHandler(this.btnAddDesperfecto_Click);
            // 
            // txtManoDeObra
            // 
            this.txtManoDeObra.Location = new System.Drawing.Point(367, 41);
            this.txtManoDeObra.Name = "txtManoDeObra";
            this.txtManoDeObra.Size = new System.Drawing.Size(171, 20);
            this.txtManoDeObra.TabIndex = 10;
            this.txtManoDeObra.TextChanged += new System.EventHandler(this.txtManoDeObra_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(286, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Mano de Obra";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtApellido);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 107);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cliente";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(84, 74);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(171, 20);
            this.txtEmail.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Apellido";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(84, 48);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(171, 20);
            this.txtApellido.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(84, 22);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(171, 20);
            this.txtNombre.TabIndex = 6;
            // 
            // dgDesperfectos
            // 
            this.dgDesperfectos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDesperfectos.Location = new System.Drawing.Point(6, 321);
            this.dgDesperfectos.Name = "dgDesperfectos";
            this.dgDesperfectos.Size = new System.Drawing.Size(519, 131);
            this.dgDesperfectos.TabIndex = 14;
            // 
            // printer
            // 
            this.printer.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.Imprimir);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 508);
            this.Controls.Add(this.tabMain);
            this.Name = "frmMain";
            this.Text = "PRESUPUESTO";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tabMain.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panMoto.ResumeLayout(false);
            this.panMoto.PerformLayout();
            this.panAuto.ResumeLayout(false);
            this.panAuto.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDias)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgRepuestos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDesperfectos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCargarPresupuesto;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panMoto;
        private System.Windows.Forms.Label lblCilindrada;
        private System.Windows.Forms.TextBox txtCilindrada;
        private System.Windows.Forms.Panel panAuto;
        private System.Windows.Forms.Label lblPuertas;
        private System.Windows.Forms.TextBox txtPuertas;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.Label lblTipoAuto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton optMoto;
        private System.Windows.Forms.RadioButton optAuto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPatente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Button btnAddVehiculo;
        private System.Windows.Forms.Button btnAddDesperfecto;
        private System.Windows.Forms.DataGridView dgDesperfectos;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtManoDeObra;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgRepuestos;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label txtPatenteTitle;
        private System.Windows.Forms.Label txtModeloTitle;
        private System.Windows.Forms.Label txtMarcaTitle;
        private System.Windows.Forms.NumericUpDown numDias;
        private System.Drawing.Printing.PrintDocument printer;
    }
}

