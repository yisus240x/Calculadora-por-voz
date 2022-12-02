namespace Calculadora_por_voz
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.button1 = new System.Windows.Forms.Button();
            this.lblOperacion = new System.Windows.Forms.Label();
            this.lblsigno = new System.Windows.Forms.Label();
            this.BtmLimpiarHistorial = new System.Windows.Forms.Button();
            this.Historial = new System.Windows.Forms.ListBox();
            this.BtmPi = new System.Windows.Forms.Button();
            this.BtmRaizEnecima = new System.Windows.Forms.Button();
            this.BtmRaiz = new System.Windows.Forms.Button();
            this.BtmPunto = new System.Windows.Forms.Button();
            this.Btm00 = new System.Windows.Forms.Button();
            this.Btm0 = new System.Windows.Forms.Button();
            this.BtmIgual = new System.Windows.Forms.Button();
            this.BtmPorcentaje = new System.Windows.Forms.Button();
            this.BtmDivision = new System.Windows.Forms.Button();
            this.BtmMultiplicacion = new System.Windows.Forms.Button();
            this.Btm7 = new System.Windows.Forms.Button();
            this.Btm9 = new System.Windows.Forms.Button();
            this.Btm8 = new System.Windows.Forms.Button();
            this.BtmResta = new System.Windows.Forms.Button();
            this.Btm6 = new System.Windows.Forms.Button();
            this.Btm5 = new System.Windows.Forms.Button();
            this.Btm4 = new System.Windows.Forms.Button();
            this.BtmSuma = new System.Windows.Forms.Button();
            this.Btm3 = new System.Windows.Forms.Button();
            this.Btm2 = new System.Windows.Forms.Button();
            this.Btm1 = new System.Windows.Forms.Button();
            this.BtmBorrarTodo = new System.Windows.Forms.Button();
            this.BtmPositivoNegativo = new System.Windows.Forms.Button();
            this.BtmPotencia = new System.Windows.Forms.Button();
            this.BtmCuadrado = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(28, 466);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 26);
            this.button1.TabIndex = 61;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // lblOperacion
            // 
            this.lblOperacion.AutoSize = true;
            this.lblOperacion.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperacion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblOperacion.Location = new System.Drawing.Point(393, 59);
            this.lblOperacion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOperacion.Name = "lblOperacion";
            this.lblOperacion.Size = new System.Drawing.Size(0, 16);
            this.lblOperacion.TabIndex = 60;
            // 
            // lblsigno
            // 
            this.lblsigno.AutoSize = true;
            this.lblsigno.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsigno.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblsigno.Location = new System.Drawing.Point(418, 59);
            this.lblsigno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblsigno.Name = "lblsigno";
            this.lblsigno.Size = new System.Drawing.Size(0, 16);
            this.lblsigno.TabIndex = 59;
            this.lblsigno.Click += new System.EventHandler(this.lblsigno_Click);
            // 
            // BtmLimpiarHistorial
            // 
            this.BtmLimpiarHistorial.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtmLimpiarHistorial.FlatAppearance.BorderSize = 0;
            this.BtmLimpiarHistorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtmLimpiarHistorial.Location = new System.Drawing.Point(49, 448);
            this.BtmLimpiarHistorial.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtmLimpiarHistorial.Name = "BtmLimpiarHistorial";
            this.BtmLimpiarHistorial.Size = new System.Drawing.Size(74, 23);
            this.BtmLimpiarHistorial.TabIndex = 58;
            this.BtmLimpiarHistorial.UseVisualStyleBackColor = true;
            this.BtmLimpiarHistorial.Click += new System.EventHandler(this.BtmLimpiarHistorial_Click_1);
            // 
            // Historial
            // 
            this.Historial.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Historial.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Historial.FormattingEnabled = true;
            this.Historial.ItemHeight = 19;
            this.Historial.Location = new System.Drawing.Point(17, 78);
            this.Historial.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Historial.Name = "Historial";
            this.Historial.Size = new System.Drawing.Size(143, 365);
            this.Historial.TabIndex = 57;
            this.Historial.SelectedIndexChanged += new System.EventHandler(this.Historial_SelectedIndexChanged);
            // 
            // BtmPi
            // 
            this.BtmPi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtmPi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtmPi.BackgroundImage")));
            this.BtmPi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtmPi.FlatAppearance.BorderSize = 0;
            this.BtmPi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtmPi.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtmPi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(99)))), ((int)(((byte)(108)))));
            this.BtmPi.Location = new System.Drawing.Point(338, 143);
            this.BtmPi.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtmPi.Name = "BtmPi";
            this.BtmPi.Size = new System.Drawing.Size(68, 55);
            this.BtmPi.TabIndex = 56;
            this.BtmPi.Text = "π";
            this.BtmPi.UseVisualStyleBackColor = true;
            this.BtmPi.Click += new System.EventHandler(this.BtmPi_Click_1);
            // 
            // BtmRaizEnecima
            // 
            this.BtmRaizEnecima.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtmRaizEnecima.BackColor = System.Drawing.Color.Transparent;
            this.BtmRaizEnecima.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtmRaizEnecima.BackgroundImage")));
            this.BtmRaizEnecima.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtmRaizEnecima.FlatAppearance.BorderSize = 0;
            this.BtmRaizEnecima.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtmRaizEnecima.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtmRaizEnecima.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(99)))), ((int)(((byte)(108)))));
            this.BtmRaizEnecima.Location = new System.Drawing.Point(415, 388);
            this.BtmRaizEnecima.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtmRaizEnecima.Name = "BtmRaizEnecima";
            this.BtmRaizEnecima.Size = new System.Drawing.Size(68, 55);
            this.BtmRaizEnecima.TabIndex = 55;
            this.BtmRaizEnecima.Text = "x√x";
            this.BtmRaizEnecima.UseVisualStyleBackColor = false;
            this.BtmRaizEnecima.Click += new System.EventHandler(this.BtmRaizEnecima_Click_1);
            // 
            // BtmRaiz
            // 
            this.BtmRaiz.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtmRaiz.BackColor = System.Drawing.Color.Transparent;
            this.BtmRaiz.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtmRaiz.BackgroundImage")));
            this.BtmRaiz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtmRaiz.FlatAppearance.BorderSize = 0;
            this.BtmRaiz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtmRaiz.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtmRaiz.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(99)))), ((int)(((byte)(108)))));
            this.BtmRaiz.Location = new System.Drawing.Point(412, 326);
            this.BtmRaiz.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtmRaiz.Name = "BtmRaiz";
            this.BtmRaiz.Size = new System.Drawing.Size(68, 55);
            this.BtmRaiz.TabIndex = 54;
            this.BtmRaiz.Text = "√x";
            this.BtmRaiz.UseVisualStyleBackColor = false;
            this.BtmRaiz.Click += new System.EventHandler(this.BtmRaiz_Click_1);
            // 
            // BtmPunto
            // 
            this.BtmPunto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtmPunto.FlatAppearance.BorderSize = 0;
            this.BtmPunto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtmPunto.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtmPunto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtmPunto.Location = new System.Drawing.Point(338, 387);
            this.BtmPunto.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtmPunto.Name = "BtmPunto";
            this.BtmPunto.Size = new System.Drawing.Size(68, 55);
            this.BtmPunto.TabIndex = 53;
            this.BtmPunto.Text = ".";
            this.BtmPunto.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtmPunto.UseVisualStyleBackColor = true;
            this.BtmPunto.Click += new System.EventHandler(this.BtmPunto_Click_1);
            // 
            // Btm00
            // 
            this.Btm00.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btm00.FlatAppearance.BorderSize = 0;
            this.Btm00.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btm00.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btm00.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btm00.Location = new System.Drawing.Point(265, 387);
            this.Btm00.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Btm00.Name = "Btm00";
            this.Btm00.Size = new System.Drawing.Size(68, 55);
            this.Btm00.TabIndex = 52;
            this.Btm00.Text = "00";
            this.Btm00.UseVisualStyleBackColor = true;
            this.Btm00.Click += new System.EventHandler(this.Btm00_Click_1);
            // 
            // Btm0
            // 
            this.Btm0.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btm0.FlatAppearance.BorderSize = 0;
            this.Btm0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btm0.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btm0.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btm0.Location = new System.Drawing.Point(190, 387);
            this.Btm0.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Btm0.Name = "Btm0";
            this.Btm0.Size = new System.Drawing.Size(68, 55);
            this.Btm0.TabIndex = 51;
            this.Btm0.Text = "0";
            this.Btm0.UseVisualStyleBackColor = true;
            this.Btm0.Click += new System.EventHandler(this.Btm0_Click_1);
            // 
            // BtmIgual
            // 
            this.BtmIgual.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtmIgual.BackgroundImage = global::Calculadora_por_voz.Properties.Resources._1211_2x;
            this.BtmIgual.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtmIgual.FlatAppearance.BorderSize = 0;
            this.BtmIgual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtmIgual.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtmIgual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(99)))), ((int)(((byte)(108)))));
            this.BtmIgual.Location = new System.Drawing.Point(488, 387);
            this.BtmIgual.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtmIgual.Name = "BtmIgual";
            this.BtmIgual.Size = new System.Drawing.Size(68, 55);
            this.BtmIgual.TabIndex = 50;
            this.BtmIgual.Text = "=";
            this.BtmIgual.UseVisualStyleBackColor = true;
            this.BtmIgual.Click += new System.EventHandler(this.BtmIgual_Click_1);
            // 
            // BtmPorcentaje
            // 
            this.BtmPorcentaje.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtmPorcentaje.BackColor = System.Drawing.Color.Transparent;
            this.BtmPorcentaje.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtmPorcentaje.BackgroundImage")));
            this.BtmPorcentaje.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtmPorcentaje.FlatAppearance.BorderSize = 0;
            this.BtmPorcentaje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtmPorcentaje.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtmPorcentaje.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(99)))), ((int)(((byte)(108)))));
            this.BtmPorcentaje.Location = new System.Drawing.Point(488, 326);
            this.BtmPorcentaje.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtmPorcentaje.Name = "BtmPorcentaje";
            this.BtmPorcentaje.Size = new System.Drawing.Size(68, 55);
            this.BtmPorcentaje.TabIndex = 49;
            this.BtmPorcentaje.Text = "%";
            this.BtmPorcentaje.UseVisualStyleBackColor = false;
            this.BtmPorcentaje.Click += new System.EventHandler(this.BtmPorcentaje_Click_1);
            // 
            // BtmDivision
            // 
            this.BtmDivision.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtmDivision.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtmDivision.BackgroundImage")));
            this.BtmDivision.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtmDivision.FlatAppearance.BorderSize = 0;
            this.BtmDivision.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtmDivision.Font = new System.Drawing.Font("Bahnschrift", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtmDivision.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(99)))), ((int)(((byte)(108)))));
            this.BtmDivision.Location = new System.Drawing.Point(488, 265);
            this.BtmDivision.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtmDivision.Name = "BtmDivision";
            this.BtmDivision.Size = new System.Drawing.Size(68, 55);
            this.BtmDivision.TabIndex = 48;
            this.BtmDivision.Text = "÷";
            this.BtmDivision.UseVisualStyleBackColor = true;
            this.BtmDivision.Click += new System.EventHandler(this.BtmDivision_Click_1);
            // 
            // BtmMultiplicacion
            // 
            this.BtmMultiplicacion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtmMultiplicacion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtmMultiplicacion.BackgroundImage")));
            this.BtmMultiplicacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtmMultiplicacion.FlatAppearance.BorderSize = 0;
            this.BtmMultiplicacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtmMultiplicacion.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtmMultiplicacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(99)))), ((int)(((byte)(108)))));
            this.BtmMultiplicacion.Location = new System.Drawing.Point(488, 205);
            this.BtmMultiplicacion.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtmMultiplicacion.Name = "BtmMultiplicacion";
            this.BtmMultiplicacion.Size = new System.Drawing.Size(68, 55);
            this.BtmMultiplicacion.TabIndex = 47;
            this.BtmMultiplicacion.Text = "x";
            this.BtmMultiplicacion.UseVisualStyleBackColor = true;
            this.BtmMultiplicacion.Click += new System.EventHandler(this.BtmMultiplicacion_Click_1);
            // 
            // Btm7
            // 
            this.Btm7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btm7.FlatAppearance.BorderSize = 0;
            this.Btm7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btm7.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btm7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btm7.Location = new System.Drawing.Point(190, 326);
            this.Btm7.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Btm7.Name = "Btm7";
            this.Btm7.Size = new System.Drawing.Size(68, 55);
            this.Btm7.TabIndex = 46;
            this.Btm7.Text = "7";
            this.Btm7.UseVisualStyleBackColor = true;
            this.Btm7.Click += new System.EventHandler(this.Btm7_Click_1);
            // 
            // Btm9
            // 
            this.Btm9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btm9.FlatAppearance.BorderSize = 0;
            this.Btm9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btm9.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btm9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btm9.Location = new System.Drawing.Point(338, 326);
            this.Btm9.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Btm9.Name = "Btm9";
            this.Btm9.Size = new System.Drawing.Size(68, 55);
            this.Btm9.TabIndex = 45;
            this.Btm9.Text = "9";
            this.Btm9.UseVisualStyleBackColor = true;
            this.Btm9.Click += new System.EventHandler(this.Btm9_Click_1);
            // 
            // Btm8
            // 
            this.Btm8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btm8.FlatAppearance.BorderSize = 0;
            this.Btm8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btm8.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btm8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btm8.Location = new System.Drawing.Point(265, 326);
            this.Btm8.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Btm8.Name = "Btm8";
            this.Btm8.Size = new System.Drawing.Size(68, 55);
            this.Btm8.TabIndex = 44;
            this.Btm8.Text = "8";
            this.Btm8.UseVisualStyleBackColor = true;
            this.Btm8.Click += new System.EventHandler(this.Btm8_Click_1);
            // 
            // BtmResta
            // 
            this.BtmResta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtmResta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtmResta.BackgroundImage")));
            this.BtmResta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtmResta.FlatAppearance.BorderSize = 0;
            this.BtmResta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtmResta.Font = new System.Drawing.Font("Bahnschrift", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtmResta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(99)))), ((int)(((byte)(108)))));
            this.BtmResta.Location = new System.Drawing.Point(412, 266);
            this.BtmResta.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtmResta.Name = "BtmResta";
            this.BtmResta.Size = new System.Drawing.Size(68, 55);
            this.BtmResta.TabIndex = 43;
            this.BtmResta.Text = "-";
            this.BtmResta.UseVisualStyleBackColor = true;
            this.BtmResta.Click += new System.EventHandler(this.BtmResta_Click_1);
            // 
            // Btm6
            // 
            this.Btm6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btm6.FlatAppearance.BorderSize = 0;
            this.Btm6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btm6.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btm6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btm6.Location = new System.Drawing.Point(338, 265);
            this.Btm6.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Btm6.Name = "Btm6";
            this.Btm6.Size = new System.Drawing.Size(68, 55);
            this.Btm6.TabIndex = 42;
            this.Btm6.Text = "6";
            this.Btm6.UseVisualStyleBackColor = true;
            this.Btm6.Click += new System.EventHandler(this.Btm6_Click_1);
            // 
            // Btm5
            // 
            this.Btm5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btm5.FlatAppearance.BorderSize = 0;
            this.Btm5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btm5.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btm5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btm5.Location = new System.Drawing.Point(265, 265);
            this.Btm5.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Btm5.Name = "Btm5";
            this.Btm5.Size = new System.Drawing.Size(68, 55);
            this.Btm5.TabIndex = 41;
            this.Btm5.Text = "5";
            this.Btm5.UseVisualStyleBackColor = true;
            this.Btm5.Click += new System.EventHandler(this.Btm5_Click_1);
            // 
            // Btm4
            // 
            this.Btm4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btm4.FlatAppearance.BorderSize = 0;
            this.Btm4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btm4.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btm4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btm4.Location = new System.Drawing.Point(190, 265);
            this.Btm4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Btm4.Name = "Btm4";
            this.Btm4.Size = new System.Drawing.Size(68, 55);
            this.Btm4.TabIndex = 40;
            this.Btm4.Text = "4";
            this.Btm4.UseVisualStyleBackColor = true;
            this.Btm4.Click += new System.EventHandler(this.Btm4_Click_1);
            // 
            // BtmSuma
            // 
            this.BtmSuma.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtmSuma.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtmSuma.BackgroundImage")));
            this.BtmSuma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtmSuma.FlatAppearance.BorderSize = 0;
            this.BtmSuma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtmSuma.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtmSuma.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(99)))), ((int)(((byte)(108)))));
            this.BtmSuma.Location = new System.Drawing.Point(412, 204);
            this.BtmSuma.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtmSuma.Name = "BtmSuma";
            this.BtmSuma.Size = new System.Drawing.Size(68, 55);
            this.BtmSuma.TabIndex = 39;
            this.BtmSuma.Text = "+";
            this.BtmSuma.UseVisualStyleBackColor = true;
            this.BtmSuma.Click += new System.EventHandler(this.BtmSuma_Click_1);
            // 
            // Btm3
            // 
            this.Btm3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btm3.FlatAppearance.BorderSize = 0;
            this.Btm3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btm3.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btm3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btm3.Location = new System.Drawing.Point(338, 204);
            this.Btm3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Btm3.Name = "Btm3";
            this.Btm3.Size = new System.Drawing.Size(68, 55);
            this.Btm3.TabIndex = 38;
            this.Btm3.Text = "3";
            this.Btm3.UseVisualStyleBackColor = true;
            this.Btm3.Click += new System.EventHandler(this.Btm3_Click_1);
            // 
            // Btm2
            // 
            this.Btm2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btm2.FlatAppearance.BorderSize = 0;
            this.Btm2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btm2.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btm2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btm2.Location = new System.Drawing.Point(265, 204);
            this.Btm2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Btm2.Name = "Btm2";
            this.Btm2.Size = new System.Drawing.Size(68, 55);
            this.Btm2.TabIndex = 37;
            this.Btm2.Text = "2";
            this.Btm2.UseVisualStyleBackColor = true;
            this.Btm2.Click += new System.EventHandler(this.Btm2_Click_1);
            // 
            // Btm1
            // 
            this.Btm1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btm1.FlatAppearance.BorderSize = 0;
            this.Btm1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btm1.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btm1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btm1.Location = new System.Drawing.Point(190, 204);
            this.Btm1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Btm1.Name = "Btm1";
            this.Btm1.Size = new System.Drawing.Size(68, 55);
            this.Btm1.TabIndex = 36;
            this.Btm1.Text = "1";
            this.Btm1.UseVisualStyleBackColor = true;
            this.Btm1.Click += new System.EventHandler(this.Btm1_Click_1);
            // 
            // BtmBorrarTodo
            // 
            this.BtmBorrarTodo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtmBorrarTodo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtmBorrarTodo.BackgroundImage")));
            this.BtmBorrarTodo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtmBorrarTodo.FlatAppearance.BorderSize = 0;
            this.BtmBorrarTodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtmBorrarTodo.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtmBorrarTodo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(99)))), ((int)(((byte)(108)))));
            this.BtmBorrarTodo.Location = new System.Drawing.Point(488, 143);
            this.BtmBorrarTodo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtmBorrarTodo.Name = "BtmBorrarTodo";
            this.BtmBorrarTodo.Size = new System.Drawing.Size(68, 55);
            this.BtmBorrarTodo.TabIndex = 35;
            this.BtmBorrarTodo.Text = "C";
            this.BtmBorrarTodo.UseVisualStyleBackColor = true;
            this.BtmBorrarTodo.Click += new System.EventHandler(this.BtmBorrarTodo_Click_1);
            // 
            // BtmPositivoNegativo
            // 
            this.BtmPositivoNegativo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtmPositivoNegativo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtmPositivoNegativo.BackgroundImage")));
            this.BtmPositivoNegativo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtmPositivoNegativo.FlatAppearance.BorderSize = 0;
            this.BtmPositivoNegativo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtmPositivoNegativo.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtmPositivoNegativo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(99)))), ((int)(((byte)(108)))));
            this.BtmPositivoNegativo.Location = new System.Drawing.Point(412, 143);
            this.BtmPositivoNegativo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtmPositivoNegativo.Name = "BtmPositivoNegativo";
            this.BtmPositivoNegativo.Size = new System.Drawing.Size(68, 55);
            this.BtmPositivoNegativo.TabIndex = 34;
            this.BtmPositivoNegativo.Text = "+/-";
            this.BtmPositivoNegativo.UseVisualStyleBackColor = true;
            this.BtmPositivoNegativo.Click += new System.EventHandler(this.BtmPositivoNegativo_Click_1);
            // 
            // BtmPotencia
            // 
            this.BtmPotencia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtmPotencia.BackColor = System.Drawing.Color.Transparent;
            this.BtmPotencia.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtmPotencia.BackgroundImage")));
            this.BtmPotencia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtmPotencia.FlatAppearance.BorderSize = 0;
            this.BtmPotencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtmPotencia.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtmPotencia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(99)))), ((int)(((byte)(108)))));
            this.BtmPotencia.Location = new System.Drawing.Point(265, 143);
            this.BtmPotencia.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtmPotencia.Name = "BtmPotencia";
            this.BtmPotencia.Size = new System.Drawing.Size(68, 55);
            this.BtmPotencia.TabIndex = 33;
            this.BtmPotencia.Text = "(χ)x";
            this.BtmPotencia.UseVisualStyleBackColor = false;
            this.BtmPotencia.Click += new System.EventHandler(this.BtmPotencia_Click_1);
            // 
            // BtmCuadrado
            // 
            this.BtmCuadrado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtmCuadrado.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtmCuadrado.BackgroundImage")));
            this.BtmCuadrado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtmCuadrado.FlatAppearance.BorderSize = 0;
            this.BtmCuadrado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtmCuadrado.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtmCuadrado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(99)))), ((int)(((byte)(108)))));
            this.BtmCuadrado.Location = new System.Drawing.Point(190, 142);
            this.BtmCuadrado.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtmCuadrado.Name = "BtmCuadrado";
            this.BtmCuadrado.Size = new System.Drawing.Size(68, 55);
            this.BtmCuadrado.TabIndex = 32;
            this.BtmCuadrado.Text = "χ²";
            this.BtmCuadrado.UseVisualStyleBackColor = true;
            this.BtmCuadrado.Click += new System.EventHandler(this.BtmCuadrado_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(188, 78);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(366, 40);
            this.textBox1.TabIndex = 31;
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(324, 449);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 23);
            this.label1.TabIndex = 62;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(186, 449);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 23);
            this.label2.TabIndex = 63;
            this.label2.Text = "Último comando:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(52, 50);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 25);
            this.label3.TabIndex = 64;
            this.label3.Text = "Historial";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(150, 19);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(283, 25);
            this.label4.TabIndex = 65;
            this.label4.Text = "Calculadora Científica Básica";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(575, 493);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblOperacion);
            this.Controls.Add(this.lblsigno);
            this.Controls.Add(this.BtmLimpiarHistorial);
            this.Controls.Add(this.Historial);
            this.Controls.Add(this.BtmPi);
            this.Controls.Add(this.BtmRaizEnecima);
            this.Controls.Add(this.BtmRaiz);
            this.Controls.Add(this.BtmPunto);
            this.Controls.Add(this.Btm00);
            this.Controls.Add(this.Btm0);
            this.Controls.Add(this.BtmIgual);
            this.Controls.Add(this.BtmPorcentaje);
            this.Controls.Add(this.BtmDivision);
            this.Controls.Add(this.BtmMultiplicacion);
            this.Controls.Add(this.Btm7);
            this.Controls.Add(this.Btm9);
            this.Controls.Add(this.Btm8);
            this.Controls.Add(this.BtmResta);
            this.Controls.Add(this.Btm6);
            this.Controls.Add(this.Btm5);
            this.Controls.Add(this.Btm4);
            this.Controls.Add(this.BtmSuma);
            this.Controls.Add(this.Btm3);
            this.Controls.Add(this.Btm2);
            this.Controls.Add(this.Btm1);
            this.Controls.Add(this.BtmBorrarTodo);
            this.Controls.Add(this.BtmPositivoNegativo);
            this.Controls.Add(this.BtmPotencia);
            this.Controls.Add(this.BtmCuadrado);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2";
            this.Text = "Calculadora cientifica basica";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblOperacion;
        private System.Windows.Forms.Label lblsigno;
        private System.Windows.Forms.Button BtmLimpiarHistorial;
        private System.Windows.Forms.ListBox Historial;
        private System.Windows.Forms.Button BtmPi;
        private System.Windows.Forms.Button BtmRaizEnecima;
        private System.Windows.Forms.Button BtmRaiz;
        private System.Windows.Forms.Button BtmPunto;
        private System.Windows.Forms.Button Btm00;
        private System.Windows.Forms.Button Btm0;
        private System.Windows.Forms.Button BtmIgual;
        private System.Windows.Forms.Button BtmPorcentaje;
        private System.Windows.Forms.Button BtmDivision;
        private System.Windows.Forms.Button BtmMultiplicacion;
        private System.Windows.Forms.Button Btm7;
        private System.Windows.Forms.Button Btm9;
        private System.Windows.Forms.Button Btm8;
        private System.Windows.Forms.Button BtmResta;
        private System.Windows.Forms.Button Btm6;
        private System.Windows.Forms.Button Btm5;
        private System.Windows.Forms.Button Btm4;
        private System.Windows.Forms.Button BtmSuma;
        private System.Windows.Forms.Button Btm3;
        private System.Windows.Forms.Button Btm2;
        private System.Windows.Forms.Button Btm1;
        private System.Windows.Forms.Button BtmBorrarTodo;
        private System.Windows.Forms.Button BtmPositivoNegativo;
        private System.Windows.Forms.Button BtmPotencia;
        private System.Windows.Forms.Button BtmCuadrado;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}