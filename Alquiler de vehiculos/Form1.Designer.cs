namespace Alquiler_de_vehiculos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            chkCorporativo = new CheckBox();
            txtCliente = new TextBox();
            dtpSalida = new DateTimePicker();
            txtVehiculo = new TextBox();
            txtTarifa = new TextBox();
            groupBox1 = new GroupBox();
            rbtCompleto = new RadioButton();
            rbtBasico = new RadioButton();
            chkGps = new CheckBox();
            groupBox2 = new GroupBox();
            rbtDomicilio = new RadioButton();
            rbtSucursal = new RadioButton();
            Cliente = new Label();
            salida = new Label();
            carro = new Label();
            label1 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            lstAlquileres = new ListBox();
            btnAgregar = new Label();
            subtotal = new Label();
            descuento = new Label();
            ITEBiS = new Label();
            domicilio = new Label();
            btnCalcular = new Button();
            btnLimpiar = new Button();
            btnsalir = new Button();
            lblSubtotal = new TextBox();
            lblDescuento = new TextBox();
            lblDomicilio = new TextBox();
            lblItbis = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ibiTotal = new Label();
            lblTotal = new TextBox();
            label7 = new Label();
            nudDias = new NumericUpDown();
            Dias = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudDias).BeginInit();
            SuspendLayout();
            // 
            // chkCorporativo
            // 
            chkCorporativo.AutoSize = true;
            chkCorporativo.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkCorporativo.Location = new Point(27, 92);
            chkCorporativo.Name = "chkCorporativo";
            chkCorporativo.Size = new Size(189, 27);
            chkCorporativo.TabIndex = 0;
            chkCorporativo.Text = "Cliente Corporativo";
            chkCorporativo.UseVisualStyleBackColor = true;
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(84, 37);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(231, 27);
            txtCliente.TabIndex = 1;
            // 
            // dtpSalida
            // 
            dtpSalida.Location = new Point(84, 138);
            dtpSalida.Name = "dtpSalida";
            dtpSalida.Size = new Size(291, 27);
            dtpSalida.TabIndex = 2;
            // 
            // txtVehiculo
            // 
            txtVehiculo.Location = new Point(103, 188);
            txtVehiculo.Name = "txtVehiculo";
            txtVehiculo.Size = new Size(134, 27);
            txtVehiculo.TabIndex = 3;
            // 
            // txtTarifa
            // 
            txtTarifa.Location = new Point(84, 236);
            txtTarifa.Name = "txtTarifa";
            txtTarifa.Size = new Size(125, 27);
            txtTarifa.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbtCompleto);
            groupBox1.Controls.Add(rbtBasico);
            groupBox1.Font = new Font("Nirmala UI", 9F, FontStyle.Bold);
            groupBox1.Location = new Point(27, 336);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(205, 135);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Seguro";
            // 
            // rbtCompleto
            // 
            rbtCompleto.AutoSize = true;
            rbtCompleto.Location = new Point(17, 78);
            rbtCompleto.Name = "rbtCompleto";
            rbtCompleto.Size = new Size(182, 24);
            rbtCompleto.TabIndex = 8;
            rbtCompleto.TabStop = true;
            rbtCompleto.Text = "Completo (+RD$300)";
            rbtCompleto.UseVisualStyleBackColor = true;
            // 
            // rbtBasico
            // 
            rbtBasico.AutoSize = true;
            rbtBasico.Location = new Point(17, 36);
            rbtBasico.Name = "rbtBasico";
            rbtBasico.Size = new Size(75, 24);
            rbtBasico.TabIndex = 7;
            rbtBasico.TabStop = true;
            rbtBasico.Text = "Basico";
            rbtBasico.UseVisualStyleBackColor = true;
            // 
            // chkGps
            // 
            chkGps.AutoSize = true;
            chkGps.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkGps.Location = new Point(60, 486);
            chkGps.Name = "chkGps";
            chkGps.Size = new Size(220, 27);
            chkGps.TabIndex = 7;
            chkGps.Text = "GPS (+RD$100 por dia)";
            chkGps.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rbtDomicilio);
            groupBox2.Controls.Add(rbtSucursal);
            groupBox2.Font = new Font("Nirmala UI", 9F, FontStyle.Bold);
            groupBox2.Location = new Point(246, 336);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(216, 135);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Entrega";
            // 
            // rbtDomicilio
            // 
            rbtDomicilio.AutoSize = true;
            rbtDomicilio.Location = new Point(30, 78);
            rbtDomicilio.Name = "rbtDomicilio";
            rbtDomicilio.Size = new Size(180, 24);
            rbtDomicilio.TabIndex = 1;
            rbtDomicilio.TabStop = true;
            rbtDomicilio.Text = "Domicilio (+RD$500)";
            rbtDomicilio.UseVisualStyleBackColor = true;
            // 
            // rbtSucursal
            // 
            rbtSucursal.AutoSize = true;
            rbtSucursal.Location = new Point(30, 36);
            rbtSucursal.Name = "rbtSucursal";
            rbtSucursal.Size = new Size(108, 24);
            rbtSucursal.TabIndex = 0;
            rbtSucursal.TabStop = true;
            rbtSucursal.Text = "En sucursal";
            rbtSucursal.UseVisualStyleBackColor = true;
            // 
            // Cliente
            // 
            Cliente.AutoSize = true;
            Cliente.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Cliente.Location = new Point(12, 40);
            Cliente.Name = "Cliente";
            Cliente.Size = new Size(71, 23);
            Cliente.TabIndex = 9;
            Cliente.Text = "Cliente:";
            // 
            // salida
            // 
            salida.AutoSize = true;
            salida.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold);
            salida.Location = new Point(15, 143);
            salida.Name = "salida";
            salida.Size = new Size(64, 23);
            salida.TabIndex = 10;
            salida.Text = "Salida:";
            // 
            // carro
            // 
            carro.AutoSize = true;
            carro.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold);
            carro.Location = new Point(15, 189);
            carro.Name = "carro";
            carro.Size = new Size(82, 23);
            carro.TabIndex = 11;
            carro.Text = "Vehiculo:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold);
            label1.Location = new Point(17, 239);
            label1.Name = "label1";
            label1.Size = new Size(60, 23);
            label1.TabIndex = 12;
            label1.Text = "Tarifa:";
            // 
            // lstAlquileres
            // 
            lstAlquileres.BorderStyle = BorderStyle.FixedSingle;
            lstAlquileres.FormattingEnabled = true;
            lstAlquileres.Location = new Point(512, 138);
            lstAlquileres.Name = "lstAlquileres";
            lstAlquileres.Size = new Size(393, 142);
            lstAlquileres.TabIndex = 14;
            lstAlquileres.SelectedIndexChanged += lstAlquileres_SelectedIndexChanged;
            // 
            // btnAgregar
            // 
            btnAgregar.AutoSize = true;
            btnAgregar.BackColor = SystemColors.ActiveCaption;
            btnAgregar.BorderStyle = BorderStyle.FixedSingle;
            btnAgregar.Font = new Font("Nirmala UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.Location = new Point(579, 40);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(263, 40);
            btnAgregar.TabIndex = 15;
            btnAgregar.Text = "Agregar el alquiler";
            btnAgregar.Click += btnAgregar_Click;
            // 
            // subtotal
            // 
            subtotal.AutoSize = true;
            subtotal.Font = new Font("Nirmala UI", 10.8F, FontStyle.Bold);
            subtotal.Location = new Point(482, 311);
            subtotal.Name = "subtotal";
            subtotal.Size = new Size(84, 25);
            subtotal.TabIndex = 16;
            subtotal.Text = "Subtotal";
            // 
            // descuento
            // 
            descuento.AutoSize = true;
            descuento.Font = new Font("Nirmala UI", 10.8F, FontStyle.Bold);
            descuento.Location = new Point(483, 353);
            descuento.Name = "descuento";
            descuento.Size = new Size(102, 25);
            descuento.TabIndex = 17;
            descuento.Text = "Descuento";
            // 
            // ITEBiS
            // 
            ITEBiS.AutoSize = true;
            ITEBiS.Font = new Font("Nirmala UI", 10.8F, FontStyle.Bold);
            ITEBiS.Location = new Point(482, 436);
            ITEBiS.Name = "ITEBiS";
            ITEBiS.Size = new Size(112, 25);
            ITEBiS.TabIndex = 18;
            ITEBiS.Text = "ITBIS (18%)";
            // 
            // domicilio
            // 
            domicilio.AutoSize = true;
            domicilio.Font = new Font("Nirmala UI", 10.8F, FontStyle.Bold);
            domicilio.Location = new Point(483, 393);
            domicilio.Name = "domicilio";
            domicilio.Size = new Size(92, 25);
            domicilio.TabIndex = 19;
            domicilio.Text = "Domicilio";
            // 
            // btnCalcular
            // 
            btnCalcular.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold);
            btnCalcular.Location = new Point(44, 538);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(149, 37);
            btnCalcular.TabIndex = 20;
            btnCalcular.Text = "Calcular total";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold);
            btnLimpiar.Location = new Point(205, 539);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(170, 36);
            btnLimpiar.TabIndex = 21;
            btnLimpiar.Text = "Nuevo alquiler";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnsalir
            // 
            btnsalir.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold);
            btnsalir.Location = new Point(388, 539);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(97, 36);
            btnsalir.TabIndex = 22;
            btnsalir.Text = "Salir";
            btnsalir.UseVisualStyleBackColor = true;
            btnsalir.Click += btnSalir_Click;
            // 
            // lblSubtotal
            // 
            lblSubtotal.Location = new Point(644, 309);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(160, 27);
            lblSubtotal.TabIndex = 23;
            // 
            // lblDescuento
            // 
            lblDescuento.Location = new Point(644, 354);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(160, 27);
            lblDescuento.TabIndex = 24;
            // 
            // lblDomicilio
            // 
            lblDomicilio.Location = new Point(644, 394);
            lblDomicilio.Name = "lblDomicilio";
            lblDomicilio.Size = new Size(160, 27);
            lblDomicilio.TabIndex = 25;
            // 
            // lblItbis
            // 
            lblItbis.Location = new Point(644, 434);
            lblItbis.Name = "lblItbis";
            lblItbis.Size = new Size(160, 27);
            lblItbis.TabIndex = 26;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Nirmala UI", 10.8F, FontStyle.Bold);
            label3.Location = new Point(520, 106);
            label3.Name = "label3";
            label3.Size = new Size(53, 25);
            label3.TabIndex = 27;
            label3.Text = "Dias ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Nirmala UI", 10.8F, FontStyle.Bold);
            label4.Location = new Point(599, 106);
            label4.Name = "label4";
            label4.Size = new Size(93, 25);
            label4.TabIndex = 28;
            label4.Text = "Vehiculos";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Nirmala UI", 10.8F, FontStyle.Bold);
            label5.Location = new Point(744, 106);
            label5.Name = "label5";
            label5.Size = new Size(60, 25);
            label5.TabIndex = 29;
            label5.Text = "Tarifa";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Nirmala UI", 10.8F, FontStyle.Bold);
            label6.Location = new Point(832, 106);
            label6.Name = "label6";
            label6.Size = new Size(54, 25);
            label6.TabIndex = 30;
            label6.Text = "Total";
            // 
            // ibiTotal
            // 
            ibiTotal.AutoSize = true;
            ibiTotal.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ibiTotal.Location = new Point(530, 503);
            ibiTotal.Name = "ibiTotal";
            ibiTotal.Size = new Size(0, 23);
            ibiTotal.TabIndex = 31;
            // 
            // lblTotal
            // 
            lblTotal.Location = new Point(679, 503);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(161, 27);
            lblTotal.TabIndex = 32;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(520, 503);
            label7.Name = "label7";
            label7.Size = new Size(139, 23);
            label7.TabIndex = 33;
            label7.Text = "TOTAL A PAGAR";
            // 
            // nudDias
            // 
            nudDias.Location = new Point(82, 281);
            nudDias.Name = "nudDias";
            nudDias.Size = new Size(150, 27);
            nudDias.TabIndex = 34;
            // 
            // Dias
            // 
            Dias.AutoSize = true;
            Dias.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold);
            Dias.Location = new Point(17, 281);
            Dias.Name = "Dias";
            Dias.Size = new Size(49, 23);
            Dias.TabIndex = 35;
            Dias.Text = "Dias:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1038, 646);
            Controls.Add(Dias);
            Controls.Add(nudDias);
            Controls.Add(lstAlquileres);
            Controls.Add(label7);
            Controls.Add(lblTotal);
            Controls.Add(ibiTotal);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lblItbis);
            Controls.Add(lblDomicilio);
            Controls.Add(lblDescuento);
            Controls.Add(lblSubtotal);
            Controls.Add(btnsalir);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCalcular);
            Controls.Add(domicilio);
            Controls.Add(ITEBiS);
            Controls.Add(descuento);
            Controls.Add(subtotal);
            Controls.Add(btnAgregar);
            Controls.Add(label1);
            Controls.Add(carro);
            Controls.Add(salida);
            Controls.Add(Cliente);
            Controls.Add(groupBox2);
            Controls.Add(chkGps);
            Controls.Add(groupBox1);
            Controls.Add(txtTarifa);
            Controls.Add(txtVehiculo);
            Controls.Add(dtpSalida);
            Controls.Add(txtCliente);
            Controls.Add(chkCorporativo);
            Name = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudDias).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox chkCorporativo;
        private TextBox txtCliente;
        private DateTimePicker dtpSalida;
        private TextBox txtVehiculo;
        private TextBox txtTarifa;
        private GroupBox groupBox1;
        private RadioButton rbtBasico;
        private RadioButton rbtCompleto;
        private CheckBox chkGps;
        private GroupBox groupBox2;
        private RadioButton rbtDomicilio;
        private RadioButton rbtSucursal;
        private Label Cliente;
        private Label salida;
        private Label carro;
        private Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ListBox lstAlquileres;
        private Label btnAgregar;
        private Label subtotal;
        private Label descuento;
        private Label ITEBiS;
        private Label domicilio;
        private Button btnCalcular;
        private Button btnLimpiar;
        private Button btnsalir;
        private TextBox lblSubtotal;
        private TextBox lblDescuento;
        private TextBox lblDomicilio;
        private TextBox lblItbis;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label ibiTotal;
        private TextBox lblTotal;
        private Label label7;
        private NumericUpDown nudDias;
        private Label Dias;
    }
}
