namespace Calculadora_por_voz
{
    partial class Grafica
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
            this.Calcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Calcular
            // 
            this.Calcular.Location = new System.Drawing.Point(761, 510);
            this.Calcular.Name = "Calcular";
            this.Calcular.Size = new System.Drawing.Size(106, 41);
            this.Calcular.TabIndex = 1;
            this.Calcular.Text = "Grafica";
            this.Calcular.UseVisualStyleBackColor = true;
            this.Calcular.Click += new System.EventHandler(this.Calcular_Click_1);
            // 
            // Grafica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 563);
            this.Controls.Add(this.Calcular);
            this.Name = "Grafica";
            this.Text = "Grafica";
            this.Load += new System.EventHandler(this.Grafica_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Calcular;
    }
}