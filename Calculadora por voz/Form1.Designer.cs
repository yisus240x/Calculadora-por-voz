namespace Calculadora_por_voz
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnlSuperior = new System.Windows.Forms.Panel();
            this.pnlHola = new System.Windows.Forms.Panel();
            this.min = new System.Windows.Forms.PictureBox();
            this.guardar = new System.Windows.Forms.PictureBox();
            this.max = new System.Windows.Forms.PictureBox();
            this.cerrar = new System.Windows.Forms.PictureBox();
            this.pnlSeleccion = new System.Windows.Forms.Panel();
            this.btnCientifica = new System.Windows.Forms.Button();
            this.btnNormal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cerrar)).BeginInit();
            this.pnlSeleccion.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSuperior
            // 
            this.pnlSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlSuperior.Controls.Add(this.label2);
            this.pnlSuperior.Controls.Add(this.pnlHola);
            this.pnlSuperior.Controls.Add(this.min);
            this.pnlSuperior.Controls.Add(this.guardar);
            this.pnlSuperior.Controls.Add(this.max);
            this.pnlSuperior.Controls.Add(this.cerrar);
            this.pnlSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlSuperior.Margin = new System.Windows.Forms.Padding(4);
            this.pnlSuperior.Name = "pnlSuperior";
            this.pnlSuperior.Size = new System.Drawing.Size(1329, 47);
            this.pnlSuperior.TabIndex = 0;
            // 
            // pnlHola
            // 
            this.pnlHola.Location = new System.Drawing.Point(267, 50);
            this.pnlHola.Name = "pnlHola";
            this.pnlHola.Size = new System.Drawing.Size(1062, 631);
            this.pnlHola.TabIndex = 2;
            // 
            // min
            // 
            this.min.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.min.BackgroundImage = global::Calculadora_por_voz.Properties.Resources.minimizar;
            this.min.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.min.Cursor = System.Windows.Forms.Cursors.Hand;
            this.min.Location = new System.Drawing.Point(1251, 5);
            this.min.Margin = new System.Windows.Forms.Padding(4);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(33, 31);
            this.min.TabIndex = 3;
            this.min.TabStop = false;
            this.min.Visible = false;
            this.min.Click += new System.EventHandler(this.Min_Click);
            // 
            // guardar
            // 
            this.guardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guardar.BackgroundImage = global::Calculadora_por_voz.Properties.Resources.guardar;
            this.guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.guardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guardar.Location = new System.Drawing.Point(1209, 5);
            this.guardar.Margin = new System.Windows.Forms.Padding(4);
            this.guardar.Name = "guardar";
            this.guardar.Size = new System.Drawing.Size(33, 31);
            this.guardar.TabIndex = 2;
            this.guardar.TabStop = false;
            this.guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // max
            // 
            this.max.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.max.BackgroundImage = global::Calculadora_por_voz.Properties.Resources.maximo;
            this.max.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.max.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.max.Cursor = System.Windows.Forms.Cursors.Hand;
            this.max.Location = new System.Drawing.Point(1251, 5);
            this.max.Margin = new System.Windows.Forms.Padding(4);
            this.max.Name = "max";
            this.max.Size = new System.Drawing.Size(33, 30);
            this.max.TabIndex = 1;
            this.max.TabStop = false;
            this.max.Click += new System.EventHandler(this.Max_Click);
            // 
            // cerrar
            // 
            this.cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cerrar.BackgroundImage = global::Calculadora_por_voz.Properties.Resources.x;
            this.cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cerrar.Location = new System.Drawing.Point(1292, 5);
            this.cerrar.Margin = new System.Windows.Forms.Padding(4);
            this.cerrar.Name = "cerrar";
            this.cerrar.Size = new System.Drawing.Size(33, 31);
            this.cerrar.TabIndex = 0;
            this.cerrar.TabStop = false;
            this.cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // pnlSeleccion
            // 
            this.pnlSeleccion.BackColor = System.Drawing.Color.Gray;
            this.pnlSeleccion.Controls.Add(this.btnCientifica);
            this.pnlSeleccion.Controls.Add(this.btnNormal);
            this.pnlSeleccion.Controls.Add(this.label1);
            this.pnlSeleccion.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSeleccion.Location = new System.Drawing.Point(0, 47);
            this.pnlSeleccion.Margin = new System.Windows.Forms.Padding(4);
            this.pnlSeleccion.Name = "pnlSeleccion";
            this.pnlSeleccion.Size = new System.Drawing.Size(267, 637);
            this.pnlSeleccion.TabIndex = 1;
            // 
            // btnCientifica
            // 
            this.btnCientifica.Location = new System.Drawing.Point(3, 59);
            this.btnCientifica.Name = "btnCientifica";
            this.btnCientifica.Size = new System.Drawing.Size(258, 46);
            this.btnCientifica.TabIndex = 4;
            this.btnCientifica.Text = "Cientifica Basica";
            this.btnCientifica.UseVisualStyleBackColor = true;
            this.btnCientifica.Click += new System.EventHandler(this.BtnCientifica_Click);
            // 
            // btnNormal
            // 
            this.btnNormal.Location = new System.Drawing.Point(3, 7);
            this.btnNormal.Name = "btnNormal";
            this.btnNormal.Size = new System.Drawing.Size(258, 46);
            this.btnNormal.TabIndex = 3;
            this.btnNormal.Text = "Normal";
            this.btnNormal.UseVisualStyleBackColor = true;
            this.btnNormal.Click += new System.EventHandler(this.BtnNormal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 505);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Location = new System.Drawing.Point(318, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(955, 627);
            this.panel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(12, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(281, 36);
            this.label2.TabIndex = 4;
            this.label2.Text = "Calculadora por voz";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1329, 684);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlSeleccion);
            this.Controls.Add(this.pnlSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlSuperior.ResumeLayout(false);
            this.pnlSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cerrar)).EndInit();
            this.pnlSeleccion.ResumeLayout(false);
            this.pnlSeleccion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSuperior;
        private System.Windows.Forms.Panel pnlSeleccion;
        private System.Windows.Forms.PictureBox cerrar;
        private System.Windows.Forms.PictureBox max;
        private System.Windows.Forms.PictureBox guardar;
        private System.Windows.Forms.PictureBox min;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNormal;
        private System.Windows.Forms.Button btnCientifica;
        private System.Windows.Forms.Panel pnlHola;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
    }
}

