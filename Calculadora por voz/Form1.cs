using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Recognition;


namespace Calculadora_por_voz
{
    public partial class Form1 : Form
    {
        SpeechRecognitionEngine Hablar = new SpeechRecognitionEngine();

        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                Hablar.SetInputToDefaultAudioDevice();
                Hablar.LoadGrammar(Migra());
                Hablar.SpeechRecognized += Hablar_SpeechRecognized;
                Hablar.RecognizeAsync(RecognizeMode.Multiple);
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("no se puede carnal");
            }
        }
        public static Grammar Migra()
        {
            Grammar Migra = new Grammar(AppDomain.CurrentDomain.BaseDirectory + "//palabras.xml");
            Migra.Name = "Migra";
            return Migra;
        }

        public void Hablar_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            foreach (RecognizedWordUnit palabra in e.Result.Words) {
                //label1.Text = palabra.Text;
                if (palabra.Text == "close") {
                    Application.Exit(); ;
                }
                if (palabra.Text == "minimizar") {
                    this.WindowState = FormWindowState.Minimized;
                }
                if (palabra.Text == "normal")
                {
                    openformhijo(new CalcNormal());
                    label1.Visible = false;
                }
                if (palabra.Text == "basica")
                {
                    openformhijo(new Form2());
                    label1.Visible = false;
                }
            }
        }



        private void Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Hola_Click(object sender, EventArgs e)
        {

        }

        private void openformhijo(object formhijo) {
            if (this.panel1.Controls.Count > 0)
                this.panel1.Controls.RemoveAt(0);
            Form fh = formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(fh);
            this.panel1.Tag = fh;
            fh.Show();
        }

        private void BtnNormal_Click(object sender, EventArgs e)
        {
            openformhijo(new CalcNormal());
        }

        private void BtnCientifica_Click(object sender, EventArgs e)
        {
            openformhijo(new Form2());
        }

        private void PPP_Click(object sender, EventArgs e)
        {
            openformhijo(new PPP());
        }

        private void FPP_Click(object sender, EventArgs e)
        {
            openformhijo(new FPP());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlSeleccion_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

