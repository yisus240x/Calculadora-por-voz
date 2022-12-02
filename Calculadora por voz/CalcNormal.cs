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
    public partial class CalcNormal : Form
    {
        double num1, num2;
        string operaciones;

        SpeechRecognitionEngine Hablar = new SpeechRecognitionEngine();
        public CalcNormal()
        {
            InitializeComponent();
        }

        Clases.ClassSuma Obj = new Clases.ClassSuma();
        Clases.ClassResta Obje = new Clases.ClassResta();
        Clases.ClassMultiplicacion Objet = new Clases.ClassMultiplicacion();
        Clases.ClassDividir Objeto = new Clases.ClassDividir();

        private void CalcNormal_Load(object sender, EventArgs e)
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
                MessageBox.Show("No se pudo completar la operación");
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
            try
            {


                foreach (RecognizedWordUnit palabra in e.Result.Words)
                {
                    label1.Text = palabra.Text;
                    if (palabra.Text == "close")
                    {
                        Application.Exit(); ;
                    }
                    if (palabra.Text == "cero")
                    {
                        txtBarradeOperaciones.Text = txtBarradeOperaciones.Text + "0";
                    }
                    if (palabra.Text == "zero")
                    {
                        txtBarradeOperaciones.Text = txtBarradeOperaciones.Text + "0";
                    }
                    if (palabra.Text == "uno")
                    {
                        txtBarradeOperaciones.Text = txtBarradeOperaciones.Text + "1";
                    }
                    if (palabra.Text == "one")
                    {
                        txtBarradeOperaciones.Text = txtBarradeOperaciones.Text + "1";
                    }
                    if (palabra.Text == "dos")
                    {
                        txtBarradeOperaciones.Text = txtBarradeOperaciones.Text + "2";
                    }
                    if (palabra.Text == "two")
                    {
                        txtBarradeOperaciones.Text = txtBarradeOperaciones.Text + "2";
                    }
                    if (palabra.Text == "tres")
                    {
                        txtBarradeOperaciones.Text = txtBarradeOperaciones.Text + "3";
                    }
                    if (palabra.Text == "three")
                    {
                        txtBarradeOperaciones.Text = txtBarradeOperaciones.Text + "3";
                    }
                    if (palabra.Text == "cuatro")
                    {
                        txtBarradeOperaciones.Text = txtBarradeOperaciones.Text + "4";
                    }
                    if (palabra.Text == "four")
                    {
                        txtBarradeOperaciones.Text = txtBarradeOperaciones.Text + "4";
                    }
                    if (palabra.Text == "cinco")
                    {
                        txtBarradeOperaciones.Text = txtBarradeOperaciones.Text + "5";
                    }
                    if (palabra.Text == "five")
                    {
                        txtBarradeOperaciones.Text = txtBarradeOperaciones.Text + "5";
                    }
                    if (palabra.Text == "seis")
                    {
                        txtBarradeOperaciones.Text = txtBarradeOperaciones.Text + "6";
                    }
                    if (palabra.Text == "six")
                    {
                        txtBarradeOperaciones.Text = txtBarradeOperaciones.Text + "6";
                    }
                    if (palabra.Text == "siete")
                    {
                        txtBarradeOperaciones.Text = txtBarradeOperaciones.Text + "7";
                    }
                    if (palabra.Text == "seven")
                    {
                        txtBarradeOperaciones.Text = txtBarradeOperaciones.Text + "7";
                    }
                    if (palabra.Text == "ocho")
                    {
                        txtBarradeOperaciones.Text = txtBarradeOperaciones.Text + "8";
                    }
                    if (palabra.Text == "eight")
                    {
                        txtBarradeOperaciones.Text = txtBarradeOperaciones.Text + "8";
                    }
                    if (palabra.Text == "nueve")
                    {
                        txtBarradeOperaciones.Text = txtBarradeOperaciones.Text + "9";
                    }
                    if (palabra.Text == "nine")
                    {
                        txtBarradeOperaciones.Text = txtBarradeOperaciones.Text + "9";
                    }
                    if (palabra.Text == "diez")
                    {
                        txtBarradeOperaciones.Text = txtBarradeOperaciones.Text + "10";
                    }
                    if (palabra.Text == "ten")
                    {
                        txtBarradeOperaciones.Text = txtBarradeOperaciones.Text + "10";
                    }
                    if (palabra.Text == "once")
                    {
                        txtBarradeOperaciones.Text = txtBarradeOperaciones.Text + "11";
                    }
                    if (palabra.Text == "eleven")
                    {
                        txtBarradeOperaciones.Text = txtBarradeOperaciones.Text + "11";
                    }
                    if (palabra.Text == "doce")
                    {
                        txtBarradeOperaciones.Text = txtBarradeOperaciones.Text + "12";
                    }
                    if (palabra.Text == "twelve")
                    {
                        txtBarradeOperaciones.Text = txtBarradeOperaciones.Text + "12";
                    }
                    if (palabra.Text == "trece")
                    {
                        txtBarradeOperaciones.Text = txtBarradeOperaciones.Text + "13";
                    }
                    if (palabra.Text == "thirteen")
                    {
                        txtBarradeOperaciones.Text = txtBarradeOperaciones.Text + "13";
                    }
                    if (palabra.Text == "catorce")
                    {
                        txtBarradeOperaciones.Text = txtBarradeOperaciones.Text + "14";
                    }
                    if (palabra.Text == "fourteen")
                    {
                        txtBarradeOperaciones.Text = txtBarradeOperaciones.Text + "14";
                    }
                    if (palabra.Text == "quince")
                    {
                        txtBarradeOperaciones.Text = txtBarradeOperaciones.Text + "15";
                    }
                    if (palabra.Text == "fifteen")
                    {
                        txtBarradeOperaciones.Text = txtBarradeOperaciones.Text + "15";
                    }
                    if (palabra.Text == "dieciseis")
                    {
                        txtBarradeOperaciones.Text = txtBarradeOperaciones.Text + "16";
                    }
                    if (palabra.Text == "sixteen")
                    {
                        txtBarradeOperaciones.Text = txtBarradeOperaciones.Text + "16";
                    }
                    if (palabra.Text == "diecisiete")
                    {
                        txtBarradeOperaciones.Text = txtBarradeOperaciones.Text + "17";
                    }
                    if (palabra.Text == "seventeen")
                    {
                        txtBarradeOperaciones.Text = txtBarradeOperaciones.Text + "17";
                    }
                    if (palabra.Text == "dieciocho")
                    {
                        txtBarradeOperaciones.Text = txtBarradeOperaciones.Text + "18";
                    }
                    if (palabra.Text == "eighteen")
                    {
                        txtBarradeOperaciones.Text = txtBarradeOperaciones.Text + "18";
                    }
                    if (palabra.Text == "diecinueve")
                    {
                        txtBarradeOperaciones.Text = txtBarradeOperaciones.Text + "19";
                    }
                    if (palabra.Text == "nineteen")
                    {
                        txtBarradeOperaciones.Text = txtBarradeOperaciones.Text + "19";
                    }
                    if (palabra.Text == "veinte")
                    {
                        txtBarradeOperaciones.Text = txtBarradeOperaciones.Text + "20";
                    }
                    if (palabra.Text == "twenty")
                    {
                        txtBarradeOperaciones.Text = txtBarradeOperaciones.Text + "20";
                    }
                    if (palabra.Text == "mas")
                    {
                        operaciones = "+";
                        num1 = Convert.ToDouble(txtBarradeOperaciones.Text);
                        txtBarradeOperaciones.Clear();
                    }
                    if (palabra.Text == "plus")
                    {
                        operaciones = "+";
                        num1 = Convert.ToDouble(txtBarradeOperaciones.Text);
                        txtBarradeOperaciones.Clear();
                    }
                    if (palabra.Text == "limpiar")
                    {
                        txtBarradeOperaciones.Clear();
                    }
                    if (palabra.Text == "clear")
                    {
                        txtBarradeOperaciones.Clear();
                    }
                    if (palabra.Text == "menos")
                    {
                        operaciones = "-";
                        num1 = Convert.ToDouble(txtBarradeOperaciones.Text);
                        txtBarradeOperaciones.Clear();
                    }
                    if (palabra.Text == "minus")
                    {
                        operaciones = "-";
                        num1 = Convert.ToDouble(txtBarradeOperaciones.Text);
                        txtBarradeOperaciones.Clear();
                    }
                    if (palabra.Text == "por")
                    {
                        operaciones = "*";
                        num1 = Convert.ToDouble(txtBarradeOperaciones.Text);
                        txtBarradeOperaciones.Clear();
                    }
                    if (palabra.Text == "times")
                    {
                        operaciones = "*";
                        num1 = Convert.ToDouble(txtBarradeOperaciones.Text);
                        txtBarradeOperaciones.Clear();
                    }
                    if (palabra.Text == "entre")
                    {
                        operaciones = "/";
                        num1 = Convert.ToDouble(txtBarradeOperaciones.Text);
                        txtBarradeOperaciones.Clear();
                    }
                    if (palabra.Text == "divide")
                    {
                        operaciones = "/";
                        num1 = Convert.ToDouble(txtBarradeOperaciones.Text);
                        txtBarradeOperaciones.Clear();
                    }
                    if (palabra.Text == "resultado")
                    {
                        num2 = Convert.ToDouble(txtBarradeOperaciones.Text);
                        double Sum, Rest, Multi, Div;

                        switch (operaciones)
                        {
                            case "+":
                                Sum = Obj.Suma(num1, num2);
                                txtBarradeOperaciones.Text = Sum.ToString();
                                break;
                            case "-":
                                Rest = Obje.Resta(num1, num2);
                                txtBarradeOperaciones.Text = Rest.ToString();
                                break;
                            case "*":
                                Multi = Objet.Multiplicacion(num1, num2);
                                txtBarradeOperaciones.Text = Multi.ToString();
                                break;
                            case "/":
                                Div = Objeto.Division(num1, num2);
                                txtBarradeOperaciones.Text = Div.ToString();
                                break;
                        }
                    }
                    if (palabra.Text == "equals")
                    {
                        num2 = Convert.ToDouble(txtBarradeOperaciones.Text);
                        double Sum, Rest, Multi, Div;

                        switch (operaciones)
                        {
                            case "+":
                                Sum = Obj.Suma(num1, num2);
                                txtBarradeOperaciones.Text = Sum.ToString();
                                break;
                            case "-":
                                Rest = Obje.Resta(num1, num2);
                                txtBarradeOperaciones.Text = Rest.ToString();
                                break;
                            case "*":
                                Multi = Objet.Multiplicacion(num1, num2);
                                txtBarradeOperaciones.Text = Multi.ToString();
                                break;
                            case "/":
                                Div = Objeto.Division(num1, num2);
                                txtBarradeOperaciones.Text = Div.ToString();
                                break;
                        }
                    }





                }
            }catch(System.FormatException)
            {

            }
        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            txtBarradeOperaciones.Text = txtBarradeOperaciones.Text + "0";
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            txtBarradeOperaciones.Text = txtBarradeOperaciones.Text + "1";
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            txtBarradeOperaciones.Text = txtBarradeOperaciones.Text + "2";
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            txtBarradeOperaciones.Text = txtBarradeOperaciones.Text + "3";
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            txtBarradeOperaciones.Text = txtBarradeOperaciones.Text + "4";
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            txtBarradeOperaciones.Text = txtBarradeOperaciones.Text + "5";
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            txtBarradeOperaciones.Text = txtBarradeOperaciones.Text + "6";
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            txtBarradeOperaciones.Text = txtBarradeOperaciones.Text + "7";
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            txtBarradeOperaciones.Text = txtBarradeOperaciones.Text + "8";
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            txtBarradeOperaciones.Text = txtBarradeOperaciones.Text + "9";
        }

        private void BtnPunto_Click(object sender, EventArgs e)
        {
            txtBarradeOperaciones.Text = txtBarradeOperaciones.Text + ".";
        }

        private void BtnResta_Click(object sender, EventArgs e)
        {
            operaciones = "-";
            num1 = Convert.ToDouble(txtBarradeOperaciones.Text);
            txtBarradeOperaciones.Clear();
        }

        private void BtnMultiplicacion_Click(object sender, EventArgs e)
        {
            operaciones = "*";
            num1 = Convert.ToDouble(txtBarradeOperaciones.Text);
            txtBarradeOperaciones.Clear();
        }

        private void BtnDivision_Click(object sender, EventArgs e)
        {
            operaciones = "/";
            num1 = Convert.ToDouble(txtBarradeOperaciones.Text);
            txtBarradeOperaciones.Clear();
        }
        private void BtnSuma_Click(object sender, EventArgs e)
        {
            operaciones = "+";
            num1 = Convert.ToDouble(txtBarradeOperaciones.Text);
            txtBarradeOperaciones.Clear();
        }

        private void BtnCE_Click(object sender, EventArgs e)
        {
            txtBarradeOperaciones.Clear();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void BtnIgual_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(txtBarradeOperaciones.Text);
            double Sum, Rest, Multi, Div;

            switch (operaciones) {
                case "+":
                    Sum = Obj.Suma(num1,num2);
                    txtBarradeOperaciones.Text = Sum.ToString();
                    break;
                case "-":
                    Rest = Obje.Resta(num1, num2);
                    txtBarradeOperaciones.Text = Rest.ToString();
                    break;
                case "*":
                    Multi = Objet.Multiplicacion(num1, num2);
                    txtBarradeOperaciones.Text = Multi.ToString();
                    break;
                case "/":
                    Div = Objeto.Division(num1, num2);
                    txtBarradeOperaciones.Text = Div.ToString();
                    break;
            }
        }
    }
}
