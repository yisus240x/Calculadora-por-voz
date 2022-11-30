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
    public partial class PPP : Form
    {
        public PPP()
        {
            InitializeComponent();
        }

        //producto punto 
        private void Button3_Click_1(object sender, EventArgs e)
        {
            int i1, i2, j1, j2, k1, k2;

            i1 = System.Int32.Parse(txti1.Text);
            j1 = System.Int32.Parse(txtj1.Text);
            k1 = System.Int32.Parse(txtk1.Text);
            i2 = System.Int32.Parse(txti2.Text);
            j2 = System.Int32.Parse(txtj2.Text);
            k2 = System.Int32.Parse(txtk2.Text);

            Resultante = i1 * i2;
            Resp = j1 * j2;
            Res = k1 * k2;
            double suma = Resultante + Resp + Res;
            double elevacion_i1 = Math.Pow(i1, 2), elevacion_j1 = Math.Pow(j1, 2), elevacion_k1 = Math.Pow(k1, 2);
            double sum_elevaciones1 = elevacion_i1 + elevacion_j1 + elevacion_k1;
            double elevacion_i2 = Math.Pow(i2, 2), elevacion_j2 = Math.Pow(j2, 2), elevacion_k2 = Math.Pow(k2, 2);
            double sum_elevaciones2 = elevacion_i2 + elevacion_j2 + elevacion_k2;
            double magnitudA = Math.Sqrt(sum_elevaciones1);
            double magnitudB = Math.Sqrt(sum_elevaciones2);
            double multi_mag = magnitudA * magnitudB;
            double div = suma / multi_mag;
            double angulo = div * (1 / Math.Cos(div));

            Resultado.Text = (Resultante + "i   " + Resp + "j   " + Res + "k  ");

        }
        //producto cruz
        private void Button4_Click_1(object sender, EventArgs e)
        {
            int i1, i2, j1, j2, k1, k2;

            i1 = System.Int32.Parse(txti1.Text);
            j1 = System.Int32.Parse(txtj1.Text);
            k1 = System.Int32.Parse(txtk1.Text);
            i2 = System.Int32.Parse(txti2.Text);
            j2 = System.Int32.Parse(txtj2.Text);
            k2 = System.Int32.Parse(txtk2.Text);

            int multi_i = j1 * k2;
            int multi_i_sig = j2 * -k1;
            Resultante = multi_i + multi_i_sig;
            int multi_j = i1 * k2;
            int multi_j_sig = i2 * -k1;
            int suma_multi_j = multi_j + multi_j_sig;
            int multi_k = i1 * j2;
            int multi_k_sig = i2 * -j1;
            Res = multi_k + multi_k_sig;
            Resp = -1 * suma_multi_j;

            Resultado.Text = Resultante + "i  " + Resp + "j  " + Res + "k  ";
        }
        //suma 
        int Resultante = 0, Resp = 0, Res = 0;
        private void Button1_Click_1(object sender, EventArgs e)
        {
            int I, J, K, I2, J2, K2;
            string signo2, signo3;

            //Asiganacion de valores 
            I = System.Int32.Parse(txti1.Text);
            J = System.Int32.Parse(txtj1.Text);
            K = System.Int32.Parse(txtk1.Text);
            I2 = System.Int32.Parse(txti2.Text);
            J2 = System.Int32.Parse(txtj2.Text);
            K2 = System.Int32.Parse(txtk2.Text);

            Resultante = I + I2;
            Resp = J + J2;
            Res = K + K2;

            if (Resp > 0)
            {
                signo2 = "+";
            }
            else
            {
                signo2 = " ";
            }
            if (Res > 0)
            {
                signo3 = "+";
            }
            else
            {
                signo3 = " ";
            }
            Resultado.Text = (Resultante + "i   " + signo2 + Resp + "j   " + signo3 + Res + "k  ");
        }

        private void Button5_Click_1(object sender, EventArgs e)
        {
            txti1.Clear();
            txti2.Clear();
            txtj1.Clear();
            txtj2.Clear();
            txtk1.Clear();
            txtk2.Clear();
            Resultado.Clear();
        }

        private void Button6_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        //resta
        private void Button2_Click_1(object sender, EventArgs e)
        {
            int I, J, K, I2, J2, K2;
            string signob, signoc;

            //Asiganacion de valores 
            I = System.Int32.Parse(txti1.Text);
            J = System.Int32.Parse(txtj1.Text);
            K = System.Int32.Parse(txtk1.Text);
            I2 = System.Int32.Parse(txti2.Text);
            J2 = System.Int32.Parse(txtj2.Text);
            K2 = System.Int32.Parse(txtk2.Text);

            Resultante = I - I2;
            Resp = J - J2;
            Res = K - K2;

            if (Resp > 0)
            {
                signob = "+";
            }
            else
            {
                signob = "";
            }
            if (Res > 0)
            {
                signoc = "+";
            }
            else
            {
                signoc = "";
            }

            Resultado.Text = (Resultante + "i   " + signob + Resp + "j   " + signoc + Res + "k  ");

        }

        SpeechRecognitionEngine Hablar = new SpeechRecognitionEngine();

        private void Grafica_Click_1(object sender, EventArgs e)
        {
            Grafica hola = new Grafica(Resultante, Resp, Res);
            hola.Show();
        }
        private void PPP_Load(object sender, EventArgs e)
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

        private void Txti1_TextChanged(object sender, EventArgs e)
        {

        }

        public static Grammar Migra()
        {
            Grammar Migra = new Grammar(AppDomain.CurrentDomain.BaseDirectory + "//palabras.xml");
            Migra.Name = "Migra";
            return Migra;
        }
        public void Hablar_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            foreach (RecognizedWordUnit palabra in e.Result.Words)
            {
                label1.Text = palabra.Text;
                if (palabra.Text == "salir")
                {
                    Application.Exit(); ;
                }
                
                if (palabra.Text == "suma")
                {
                    int I, J, K, I2, J2, K2;
                    string signo2, signo3;

                    //Asiganacion de valores 
                    I = System.Int32.Parse(txti1.Text);
                    J = System.Int32.Parse(txtj1.Text);
                    K = System.Int32.Parse(txtk1.Text);
                    I2 = System.Int32.Parse(txti2.Text);
                    J2 = System.Int32.Parse(txtj2.Text);
                    K2 = System.Int32.Parse(txtk2.Text);

                    Resultante = I + I2;
                    Resp = J + J2;
                    Res = K + K2;

                    if (Resp > 0)
                    {
                        signo2 = "+";
                    }
                    else
                    {
                        signo2 = " ";
                    }
                    if (Res > 0)
                    {
                        signo3 = "+";
                    }
                    else
                    {
                        signo3 = " ";
                    }
                    Resultado.Text = (Resultante + "i   " + signo2 + Resp + "j   " + signo3 + Res + "k  ");
                }
                if (palabra.Text == "resta")
                {
                    int I, J, K, I2, J2, K2;
                    string signob, signoc;

                    //Asiganacion de valores 
                    I = System.Int32.Parse(txti1.Text);
                    J = System.Int32.Parse(txtj1.Text);
                    K = System.Int32.Parse(txtk1.Text);
                    I2 = System.Int32.Parse(txti2.Text);
                    J2 = System.Int32.Parse(txtj2.Text);
                    K2 = System.Int32.Parse(txtk2.Text);

                    Resultante = I - I2;
                    Resp = J - J2;
                    Res = K - K2;

                    if (Resp > 0)
                    {
                        signob = "+";
                    }
                    else
                    {
                        signob = "";
                    }
                    if (Res > 0)
                    {
                        signoc = "+";
                    }
                    else
                    {
                        signoc = "";
                    }

                    Resultado.Text = (Resultante + "i   " + signob + Resp + "j   " + signoc + Res + "k  ");
                }
                if (palabra.Text == "punto")
                {
                    int i1, i2, j1, j2, k1, k2;

                    i1 = System.Int32.Parse(txti1.Text);
                    j1 = System.Int32.Parse(txtj1.Text);
                    k1 = System.Int32.Parse(txtk1.Text);
                    i2 = System.Int32.Parse(txti2.Text);
                    j2 = System.Int32.Parse(txtj2.Text);
                    k2 = System.Int32.Parse(txtk2.Text);

                    Resultante = i1 * i2;
                    Resp = j1 * j2;
                    Res = k1 * k2;
                    double suma = Resultante + Resp + Res;
                    double elevacion_i1 = Math.Pow(i1, 2), elevacion_j1 = Math.Pow(j1, 2), elevacion_k1 = Math.Pow(k1, 2);
                    double sum_elevaciones1 = elevacion_i1 + elevacion_j1 + elevacion_k1;
                    double elevacion_i2 = Math.Pow(i2, 2), elevacion_j2 = Math.Pow(j2, 2), elevacion_k2 = Math.Pow(k2, 2);
                    double sum_elevaciones2 = elevacion_i2 + elevacion_j2 + elevacion_k2;
                    double magnitudA = Math.Sqrt(sum_elevaciones1);
                    double magnitudB = Math.Sqrt(sum_elevaciones2);
                    double multi_mag = magnitudA * magnitudB;
                    double div = suma / multi_mag;
                    double angulo = div * (1 / Math.Cos(div));

                    Resultado.Text = (Resultante + "i   " + Resp + "j   " + Res + "k  ");
                }
                if (palabra.Text == "grafica")
                {
                    Grafica hola = new Grafica(Resultante, Resp, Res);
                    hola.Show();
                }
                if (palabra.Text == "borrar") {
                    txti1.Clear();
                    txti2.Clear();
                    txtj1.Clear();
                    txtj2.Clear();
                    txtk1.Clear();
                    txtk2.Clear();
                    Resultado.Clear();
                }
                if (palabra.Text == "cruz")
                {
                    int i1, i2, j1, j2, k1, k2;

                    i1 = System.Int32.Parse(txti1.Text);
                    j1 = System.Int32.Parse(txtj1.Text);
                    k1 = System.Int32.Parse(txtk1.Text);
                    i2 = System.Int32.Parse(txti2.Text);
                    j2 = System.Int32.Parse(txtj2.Text);
                    k2 = System.Int32.Parse(txtk2.Text);

                    int multi_i = j1 * k2;
                    int multi_i_sig = j2 * -k1;
                    Resultante = multi_i + multi_i_sig;
                    int multi_j = i1 * k2;
                    int multi_j_sig = i2 * -k1;
                    int suma_multi_j = multi_j + multi_j_sig;
                    int multi_k = i1 * j2;
                    int multi_k_sig = i2 * -j1;
                    Res = multi_k + multi_k_sig;
                    Resp = -1 * suma_multi_j;

                    Resultado.Text = Resultante + "i  " + Resp + "j  " + Res + "k  ";
                }
            }
        }
    }
}
