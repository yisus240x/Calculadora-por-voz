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
using System.Speech.Synthesis;
using System.Threading;

namespace Calculadora_por_voz
{
    public partial class Form2 : Form
    {

        SpeechRecognitionEngine Hablar = new SpeechRecognitionEngine();


        public Form2()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        double A = 0, B = 0;
        private void BorrarTodo()
        {
            /*esto borra el texbox y las variables 
            y pone espacios en la listbox para no confundir series de operaciones*/
            textBox1.Clear();
            A = 0;
            B = 0;
            Historial.Items.Add("");
            Historial.Items.Add("");
            Historial.Items.Add("");
            lblsigno.Text = "";
            lblOperacion.Text = "";
        }
        private void CambiarBorrarC()
        {
            // este cambia el texto de el boton de borrar a ¨C¨
            if (BtmBorrarTodo.Text != "C")
                BtmBorrarTodo.Text = "C";
        }
        private void CambiarBorrarCE()
        {
            // este cambia el texto de el boton de borrar a ¨CE¨
            if (BtmBorrarTodo.Text != "CE")
                BtmBorrarTodo.Text = "CE";
        }
        private double SacarA(string C)
        {
            //hacer que guarde el valor de A en lo de igualar para poder
            //hacer operaciones sin tener que presionar igual

            //esto guarda el valor de el textbox en ¨A¨ y si no esta en la listbox la guarda
            A = System.Double.Parse(C);
            textBox1.Clear();
            return A;

        }
        private void RaizEnecima(string C)
        {
            //este Saca B de la textbox y saca la raiz B de A y lo escribe en la listbox
            B = System.Double.Parse(C);
            A = Math.Pow(A, (1 / B));
            Historial.Items.Add("x√");
            Historial.Items.Add(B);
            Historial.Items.Add("=");
            Historial.Items.Add(A);

        }
        private void Sumar(string C)
        {
            //esto saca B de la texbox y suma A y B y lo escribe en la listbox
            B = System.Double.Parse(C);
            Historial.Items.Add($"{A} + {B} = ");
            A = A + B;
            Historial.Items.Add(A);
        }
        private void Restar(string C)
        {//esto saca B de la texbox y resta B de A y lo escribe en la listbox
            B = System.Double.Parse(C);
            Historial.Items.Add($"{A} - {B} = ");
            A = A - B;
            Historial.Items.Add(A);
        }
        private void Multiplicar(string C)
        {
            //esto saca B de la texbox y Multiplica A y B y lo escribe en la listbox
            B = System.Double.Parse(C);
            Historial.Items.Add($"{A} x {B} = ");
            A = A * B;
            Historial.Items.Add(A);
        }
        private void Dividir(string C)
        {
            //esto saca B de la texbox y divide A entre B y lo escribe en la listbox
            B = System.Double.Parse(C);
            Historial.Items.Add($"{A} / {B} = ");
            A = A / B;
            Historial.Items.Add(A);
        }
        private void Porcentaje(string C)
        {
            //esto saca B de la texbox y Saca el B por ciento de A y lo escribe en la listbox
            B = System.Double.Parse(C);
            Historial.Items.Add($"{A} % {B} = ");
            B = B / 100;
            A = A * B;
            Historial.Items.Add(A);
        }
        private void Potencia(string C)
        {
            //esto saca B de la texbox y eleva A a la B y lo escribe en la listbox
            B = System.Double.Parse(C);
            Historial.Items.Add($"{A} x^x {B} = ");
            double Aux = A;
            for (int i = 1; i < B; i++)
            {
                A = A * Aux;
            }
            Historial.Items.Add(A);
        }
        private void Igualar()
        {
            /*si hay algun boton presionado y la textbox 
             * no esta vacio hace la operacion del boton presionado*/
            if (textBox1.Text != "" && lblsigno.Text != "")
            {
                if (lblsigno.Text == "+")
                {
                    Sumar(textBox1.Text);
                }
                if (lblsigno.Text == "-")
                {
                    Restar(textBox1.Text);
                }
                if (lblsigno.Text == "x")
                {
                    Multiplicar(textBox1.Text);
                }
                if (lblsigno.Text == "/")
                {
                    Dividir(textBox1.Text);
                }
                if (lblsigno.Text == "x^x")
                {
                    Potencia(textBox1.Text);
                }
                if (lblsigno.Text == "%")
                {
                    Porcentaje(textBox1.Text);
                }
                if (lblsigno.Text == "x√")
                {
                    RaizEnecima(textBox1.Text);
                }
            }
        }

        private void hablar(object textBox1)
        {
            SpeechSynthesizer voz = new SpeechSynthesizer();
            voz.SetOutputToDefaultAudioDevice();
            voz.Speak(textBox1.ToString());
        }

        private void BtmCuadrado_Click_1(object sender, EventArgs e)
        {
            //cuadrado
            //esto saca el cuadrado del numero escrito en la textbox
            double c;
            c = SacarA(textBox1.Text);
            Historial.Items.Add($"{c}²  = ");
            c = c * c;
            Historial.Items.Add(c);
            textBox1.Text = c.ToString();
            Thread tarea = new Thread(new ParameterizedThreadStart(hablar));
            tarea.Start(textBox1.Text);
            CambiarBorrarCE();

        }

        private void BtmPotencia_Click_1(object sender, EventArgs e)
        {
            //Potencia enecima
            //deshabilita el boton de potencia y habilita los otros
            if (textBox1.Text != "")
            {
                if (lblsigno.Text != "")
                {
                    Igualar();
                    textBox1.Clear();
                }
                else
                {
                    A = SacarA(textBox1.Text);

                }
                lblsigno.Text = "x^x";
                lblOperacion.Text = A.ToString();
                CambiarBorrarC();

            }


        }

        private void BtmPi_Click_1(object sender, EventArgs e)
        {
            // escribir pi
            //esto suma PI al numero de la textbox
            if (textBox1.Text != "")
            {
                A = SacarA(textBox1.Text);
                Sumar("3.141592");
                textBox1.Text = A.ToString();
            }
            else
            {
                textBox1.Text = "3.141592";
            }
            CambiarBorrarC();
        }

        private void BtmBorrarTodo_Click_1(object sender, EventArgs e)
        {
            //Borrar
            //esto borra un digito o todo dependiendo de si el boton dice C o CE
            if (BtmBorrarTodo.Text == "C")
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = A.ToString();
                    Historial.Items.Remove(A);
                }
                else if (textBox1.Text != "")
                {
                    string Text = "";
                    Text = textBox1.Text;
                    Text = Text.Remove(Text.Length - 1);
                    textBox1.Text = Text;
                }
            }
            else if (BtmBorrarTodo.Text == "CE" && textBox1.Text != "")
            {
                BorrarTodo();

            }
        }

        private void BtmSuma_Click_1(object sender, EventArgs e)
        {
            //sumar
            if (textBox1.Text != "")
            {
                if (lblsigno.Text != "")
                {
                    Igualar();
                    textBox1.Clear();
                }
                else
                {
                    A = SacarA(textBox1.Text);

                }
                lblsigno.Text = "+";
                lblOperacion.Text = A.ToString();
                CambiarBorrarC();

            }

        }

        private void BtmMultiplicacion_Click_1(object sender, EventArgs e)
        {
            //Multiplicar
            //deshabilita el boton de Multiplicacion y habilita los otros
            if (textBox1.Text != "")
            {
                if (lblsigno.Text != "")
                {
                    Igualar();
                    textBox1.Clear();
                }
                else
                {
                    A = SacarA(textBox1.Text);

                }
                lblsigno.Text = "x";
                lblOperacion.Text = A.ToString();
                CambiarBorrarC();

            }

        }

        private void BtmResta_Click_1(object sender, EventArgs e)
        {
            //Restar
            //deshabilita el boton de resta y habilita los otros
            if (textBox1.Text != "")
            {
                if (lblsigno.Text != "")
                {
                    Igualar();
                    textBox1.Clear();
                }
                else
                {
                    A = SacarA(textBox1.Text);

                }
                lblsigno.Text = "-";
                lblOperacion.Text = A.ToString();
                CambiarBorrarC();

            }

        }

        private void BtmDivision_Click_1(object sender, EventArgs e)
        {
            //Dividir
            //deshabilita el boton de division y habilita los otros

            if (textBox1.Text != "")
            {
                if (lblsigno.Text != "")
                {
                    Igualar();
                    textBox1.Clear();
                }
                else
                {
                    A = SacarA(textBox1.Text);

                }
                lblsigno.Text = "/";
                lblOperacion.Text = A.ToString();
                CambiarBorrarC();

            }

        }


        private void BtmRaiz_Click_1(object sender, EventArgs e)
        {
            //Raiz cuadrada
            //saca la raiz cuadrada del numero de la textbox
            double c = SacarA(textBox1.Text);
            Historial.Items.Add($"{c} x^x {c} = ");
            c = Math.Sqrt(c);
            Historial.Items.Add(c);
            textBox1.Text = c.ToString();
            CambiarBorrarCE();
        }

        private void BtmRaizEnecima_Click_1(object sender, EventArgs e)
        {
            //Raiz enecima
            //deshabilita el boton de Raiz enecima y habilita los otros
            if (textBox1.Text != "")
            {
                if (lblsigno.Text != "")
                {
                    Igualar();
                    textBox1.Clear();
                }
                else
                {
                    A = SacarA(textBox1.Text);

                }
                lblsigno.Text = "x√";
                lblOperacion.Text = A.ToString();
                CambiarBorrarC();

            }
        }

        private void BtmPorcentaje_Click_1(object sender, EventArgs e)
        {
            //deshabilita el boton de porcentaje y habilita los otros
            if (textBox1.Text != "")
            {
                if (lblsigno.Text != "")
                {
                    Igualar();
                    textBox1.Clear();
                }
                else
                {
                    A = SacarA(textBox1.Text);

                }
                lblOperacion.Text = A.ToString();
                lblsigno.Text = "%";
                CambiarBorrarC();

            }
        }

        private void BtmIgual_Click_1(object sender, EventArgs e)
        {
            //dar resultado
            if (textBox1.Text != "")
            {
                Igualar();
                textBox1.Text = A.ToString();
                lblOperacion.Text = "";
                lblsigno.Text = "";
                CambiarBorrarCE();
            }
        }

        private void Btm1_Click_1(object sender, EventArgs e)
        {
            //escribir 1
            textBox1.Text = textBox1.Text + "1";
            CambiarBorrarC();
        }

        private void Btm2_Click_1(object sender, EventArgs e)
        {
            //escribir 2
            textBox1.Text = textBox1.Text + "2";
            CambiarBorrarC();
        }

        private void Btm3_Click_1(object sender, EventArgs e)
        {
            //escribir 3
            textBox1.Text = textBox1.Text + "3";
            CambiarBorrarC();
        }

        private void Btm4_Click_1(object sender, EventArgs e)
        {
            //escribir 4
            textBox1.Text = textBox1.Text + "4";
            CambiarBorrarC();
        }

        private void Btm5_Click_1(object sender, EventArgs e)
        {
            //escribir 5
            textBox1.Text = textBox1.Text + "5";
            CambiarBorrarC();
        }

        private void Btm6_Click_1(object sender, EventArgs e)
        {
            //escribir 6
            textBox1.Text = textBox1.Text + "6";
            CambiarBorrarC();
        }

        private void Btm7_Click_1(object sender, EventArgs e)
        {
            //escribir 7
            textBox1.Text = textBox1.Text + "7";
            CambiarBorrarC();
        }

        private void Btm8_Click_1(object sender, EventArgs e)
        {
            //escribir 8
            textBox1.Text = textBox1.Text + "8";
            CambiarBorrarC();
        }

        private void Btm9_Click_1(object sender, EventArgs e)
        {
            //escribir 9
            textBox1.Text = textBox1.Text + "9";
            CambiarBorrarC();
        }

        private void Btm0_Click_1(object sender, EventArgs e)
        {
            //escribir 0
            if (textBox1.Text != "0")
            {
                textBox1.Text = textBox1.Text + "0";
                CambiarBorrarC();
            }
        }

        private void Btm00_Click_1(object sender, EventArgs e)
        {
            //escribir 00
            if (textBox1.Text != "0")
            {
                textBox1.Text = textBox1.Text + "00";
                CambiarBorrarC();
            }
        }

        private void BtmPunto_Click_1(object sender, EventArgs e)
        {
            //escribir punto
            if (textBox1.Text.Contains(".") == false)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = textBox1.Text + "0.";
                    CambiarBorrarC();
                }
                else
                {
                    textBox1.Text = textBox1.Text + ".";
                    CambiarBorrarC();
                }
            }

        }

        private void BtmPositivoNegativo_Click_1(object sender, EventArgs e)
        {
            // cambiar el valor de la textbox a positivo o negativo
            if (textBox1.Text != "0" && textBox1.Text != "")
            {
                double C = 0;
                C = System.Double.Parse(textBox1.Text);
                if (C > 0)
                    textBox1.Text = "-" + textBox1.Text;
                else if (C < 0)
                {
                    C = C * -1;
                    textBox1.Text = C.ToString();
                }
                CambiarBorrarC();
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void Historial_SelectedIndexChanged(object sender, EventArgs e)
        {
            //pone en la textbox el valor que selecciones de la listbox
            textBox1.Text = Historial.SelectedItem.ToString();
        }

        private void BtmLimpiarHistorial_Click_1(object sender, EventArgs e)
        {
            //limpia la textbox
            Historial.Items.Clear();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            lblOperacion.Text = "";
            lblsigno.Text = "";
            textBox1.Text = "";
        }

        private void Form2_Load(object sender, EventArgs e)
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

        private void lblsigno_Click(object sender, EventArgs e)
        {

        }

        public void Hablar_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
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
                    textBox1.Text = textBox1.Text + "0";
                }
                if (palabra.Text == "zero")
                {
                    textBox1.Text = textBox1.Text + "0";
                }
                if (palabra.Text == "uno")
                {
                    textBox1.Text = textBox1.Text + "1";
                }
                if (palabra.Text == "one")
                {
                    textBox1.Text = textBox1.Text + "1";
                }
                if (palabra.Text == "dos")
                {
                    textBox1.Text = textBox1.Text + "2";
                }
                if (palabra.Text == "two")
                {
                    textBox1.Text = textBox1.Text + "2";
                }
                if (palabra.Text == "tres")
                {
                    textBox1.Text = textBox1.Text + "3";
                }
                if (palabra.Text == "three")
                {
                    textBox1.Text = textBox1.Text + "3";
                }
                if (palabra.Text == "cuatro")
                {
                    textBox1.Text = textBox1.Text + "4";
                }
                if (palabra.Text == "four")
                {
                    textBox1.Text = textBox1.Text + "4";
                }
                if (palabra.Text == "cinco")
                {
                    textBox1.Text = textBox1.Text + "5";
                }
                if (palabra.Text == "five")
                {
                    textBox1.Text = textBox1.Text + "5";
                }
                if (palabra.Text == "seis")
                {
                    textBox1.Text = textBox1.Text + "6";
                }
                if (palabra.Text == "six")
                {
                    textBox1.Text = textBox1.Text + "6";
                }
                if (palabra.Text == "siete")
                {
                    textBox1.Text = textBox1.Text + "7";
                }
                if (palabra.Text == "seven")
                {
                    textBox1.Text = textBox1.Text + "7";
                }
                if (palabra.Text == "ocho")
                {
                    textBox1.Text = textBox1.Text + "8";
                }
                if (palabra.Text == "eight")
                {
                    textBox1.Text = textBox1.Text + "8";
                }
                if (palabra.Text == "nueve")
                {
                    textBox1.Text = textBox1.Text + "9";
                }
                if (palabra.Text == "nine")
                {
                    textBox1.Text = textBox1.Text + "9";
                }
                if (palabra.Text == "diez")
                {
                    textBox1.Text = textBox1.Text + "10";
                }
                if (palabra.Text == "ten")
                {
                    textBox1.Text = textBox1.Text + "10";
                }
                if (palabra.Text == "once")
                {
                    textBox1.Text = textBox1.Text + "11";
                }
                if (palabra.Text == "eleven")
                {
                    textBox1.Text = textBox1.Text + "11";
                }
                if (palabra.Text == "doce")
                {
                    textBox1.Text = textBox1.Text + "12";
                }
                if (palabra.Text == "twelve")
                {
                    textBox1.Text = textBox1.Text + "12";
                }
                if (palabra.Text == "trece")
                {
                    textBox1.Text = textBox1.Text + "13";
                }
                if (palabra.Text == "thirteen")
                {
                    textBox1.Text = textBox1.Text + "13";
                }
                if (palabra.Text == "catorce")
                {
                    textBox1.Text = textBox1.Text + "14";
                }
                if (palabra.Text == "fourteen")
                {
                    textBox1.Text = textBox1.Text + "14";
                }
                if (palabra.Text == "quince")
                {
                    textBox1.Text = textBox1.Text + "15";
                }
                if (palabra.Text == "fifteen")
                {
                    textBox1.Text = textBox1.Text + "15";
                }
                if (palabra.Text == "dieciseis")
                {
                    textBox1.Text = textBox1.Text + "16";
                }
                if (palabra.Text == "sixteen")
                {
                    textBox1.Text = textBox1.Text + "16";
                }
                if (palabra.Text == "diecisiete")
                {
                    textBox1.Text = textBox1.Text + "17";
                }
                if (palabra.Text == "seventeen")
                {
                    textBox1.Text = textBox1.Text + "17";
                }
                if (palabra.Text == "dieciocho")
                {
                    textBox1.Text = textBox1.Text + "18";
                }
                if (palabra.Text == "eighteen")
                {
                    textBox1.Text = textBox1.Text + "18";
                }
                if (palabra.Text == "diecinueve")
                {
                    textBox1.Text = textBox1.Text + "19";
                }
                if (palabra.Text == "nineteen")
                {
                    textBox1.Text = textBox1.Text + "19";
                }
                if (palabra.Text == "veinte")
                {
                    textBox1.Text = textBox1.Text + "20";
                }
                if (palabra.Text == "twenty")
                {
                    textBox1.Text = textBox1.Text + "20";
                }
                if (palabra.Text == "limpiar")
                {
                    textBox1.Clear();
                    label1.Text = "";
                }
                if (palabra.Text == "clear")
                {
                    label1.Text = "";
                    textBox1.Clear();
                }
                if (palabra.Text == "mas")
                {
                    if (textBox1.Text != "")
                    {
                        if (lblsigno.Text != "")
                        {
                            Igualar();
                            textBox1.Clear();
                        }
                        else
                        {
                            A = SacarA(textBox1.Text);

                        }
                        lblsigno.Text = "+";
                        lblOperacion.Text = A.ToString();
                        CambiarBorrarC();

                    }

                }
                if (palabra.Text == "plus")
                {
                    if (textBox1.Text != "")
                    {
                        if (lblsigno.Text != "")
                        {
                            Igualar();
                            textBox1.Clear();
                        }
                        else
                        {
                            A = SacarA(textBox1.Text);

                        }
                        lblsigno.Text = "+";
                        lblOperacion.Text = A.ToString();
                        CambiarBorrarC();

                    }

                }
                if (palabra.Text == "menos")
                {
                    //Restar
                    //deshabilita el boton de resta y habilita los otros
                    if (textBox1.Text != "")
                    {
                        if (lblsigno.Text != "")
                        {
                            Igualar();
                            textBox1.Clear();
                        }
                        else
                        {
                            A = SacarA(textBox1.Text);

                        }
                        lblsigno.Text = "-";
                        lblOperacion.Text = A.ToString();
                        CambiarBorrarC();

                    }
                }
                if (palabra.Text == "minus")
                {
                    //Restar
                    //deshabilita el boton de resta y habilita los otros
                    if (textBox1.Text != "")
                    {
                        if (lblsigno.Text != "")
                        {
                            Igualar();
                            textBox1.Clear();
                        }
                        else
                        {
                            A = SacarA(textBox1.Text);

                        }
                        lblsigno.Text = "-";
                        lblOperacion.Text = A.ToString();
                        CambiarBorrarC();

                    }
                }
                if (palabra.Text == "por")
                {
                    //Multiplicar
                    //deshabilita el boton de Multiplicacion y habilita los otros
                    if (textBox1.Text != "")
                    {
                        if (lblsigno.Text != "")
                        {
                            Igualar();
                            textBox1.Clear();
                        }
                        else
                        {
                            A = SacarA(textBox1.Text);

                        }
                        lblsigno.Text = "x";
                        lblOperacion.Text = A.ToString();
                        CambiarBorrarC();

                    }

                }
                if (palabra.Text == "times")
                {
                    //Multiplicar
                    //deshabilita el boton de Multiplicacion y habilita los otros
                    if (textBox1.Text != "")
                    {
                        if (lblsigno.Text != "")
                        {
                            Igualar();
                            textBox1.Clear();
                        }
                        else
                        {
                            A = SacarA(textBox1.Text);

                        }
                        lblsigno.Text = "x";
                        lblOperacion.Text = A.ToString();
                        CambiarBorrarC();

                    }

                }
                if (palabra.Text == "entre")
                {
                    //Dividir
                    //deshabilita el boton de division y habilita los otros

                    if (textBox1.Text != "")
                    {
                        if (lblsigno.Text != "")
                        {
                            Igualar();
                            textBox1.Clear();
                        }
                        else
                        {
                            A = SacarA(textBox1.Text);

                        }
                        lblsigno.Text = "/";
                        lblOperacion.Text = A.ToString();
                        CambiarBorrarC();

                    }

                }
                if (palabra.Text == "divide")
                {
                    //Dividir
                    //deshabilita el boton de division y habilita los otros

                    if (textBox1.Text != "")
                    {
                        if (lblsigno.Text != "")
                        {
                            Igualar();
                            textBox1.Clear();
                        }
                        else
                        {
                            A = SacarA(textBox1.Text);

                        }
                        lblsigno.Text = "/";
                        lblOperacion.Text = A.ToString();
                        CambiarBorrarC();

                    }

                }
                if (palabra.Text == "resultado")
                {
                    //dar resultado
                    if (textBox1.Text != "")
                    {
                        Igualar();
                        textBox1.Text = A.ToString();
                        lblOperacion.Text = "";
                        lblsigno.Text = "";
                        CambiarBorrarCE();
                    }
                }
                if (palabra.Text == "equals")
                {
                    //dar resultado
                    if (textBox1.Text != "")
                    {
                        Igualar();
                        textBox1.Text = A.ToString();
                        lblOperacion.Text = "";
                        lblsigno.Text = "";
                        CambiarBorrarCE();
                    }
                }
                if (palabra.Text == "porcentaje")
                {
                    //deshabilita el boton de porcentaje y habilita los otros
                    if (textBox1.Text != "")
                    {
                        if (lblsigno.Text != "")
                        {
                            Igualar();
                            textBox1.Clear();
                        }
                        else
                        {
                            A = SacarA(textBox1.Text);

                        }
                        lblOperacion.Text = A.ToString();
                        lblsigno.Text = "%";
                        CambiarBorrarC();

                    }
                }
                if (palabra.Text == "percentage")
                {
                    //deshabilita el boton de porcentaje y habilita los otros
                    if (textBox1.Text != "")
                    {
                        if (lblsigno.Text != "")
                        {
                            Igualar();
                            textBox1.Clear();
                        }
                        else
                        {
                            A = SacarA(textBox1.Text);

                        }
                        lblOperacion.Text = A.ToString();
                        lblsigno.Text = "%";
                        CambiarBorrarC();

                    }
                }
                if (palabra.Text == "cuadrado")
                {
                    //cuadrado
                    //esto saca el cuadrado del numero escrito en la textbox
                    double c;
                    c = SacarA(textBox1.Text);
                    Historial.Items.Add($"{c} x^x {c} = ");
                    c = c * c;
                    Historial.Items.Add(c);
                    textBox1.Text = c.ToString();
                    CambiarBorrarCE();
                }
                if (palabra.Text == "square")
                {
                    //cuadrado
                    //esto saca el cuadrado del numero escrito en la textbox
                    double c;
                    c = SacarA(textBox1.Text);
                    Historial.Items.Add($"{c} x^x {c} = ");
                    c = c * c;
                    Historial.Items.Add(c);
                    textBox1.Text = c.ToString();
                    CambiarBorrarCE();
                }
                if (palabra.Text == "potencial")
                {
                    //Potencia enecima
                    //deshabilita el boton de potencia y habilita los otros
                    if (textBox1.Text != "")
                    {
                        if (lblsigno.Text != "")
                        {
                            Igualar();
                            textBox1.Clear();
                        }
                        else
                        {
                            A = SacarA(textBox1.Text);

                        }
                        lblsigno.Text = "x^x";
                        lblOperacion.Text = A.ToString();
                        CambiarBorrarC();

                    }
                }
                if (palabra.Text == "potential")
                {
                    //Potencia enecima
                    //deshabilita el boton de potencia y habilita los otros
                    if (textBox1.Text != "")
                    {
                        if (lblsigno.Text != "")
                        {
                            Igualar();
                            textBox1.Clear();
                        }
                        else
                        {
                            A = SacarA(textBox1.Text);

                        }
                        lblsigno.Text = "x^x";
                        lblOperacion.Text = A.ToString();
                        CambiarBorrarC();

                    }
                }
                if (palabra.Text == "pi")
                {
                    // escribir pi
                    //esto suma PI al numero de la textbox
                    if (textBox1.Text != "")
                    {
                        A = SacarA(textBox1.Text);
                        Sumar("3.141592");
                        textBox1.Text = A.ToString();
                    }
                    else
                    {
                        textBox1.Text = "3.141592";
                    }
                    CambiarBorrarC();
                }
                if (palabra.Text == "cambio")
                {
                    // cambiar el valor de la textbox a positivo o negativo
                    if (textBox1.Text != "0" && textBox1.Text != "")
                    {
                        double C = 0;
                        C = System.Double.Parse(textBox1.Text);
                        if (C > 0)
                            textBox1.Text = "-" + textBox1.Text;
                        else if (C < 0)
                        {
                            C = C * -1;
                            textBox1.Text = C.ToString();
                        }
                        CambiarBorrarC();
                    }
                }
                if (palabra.Text == "change")
                {
                    // cambiar el valor de la textbox a positivo o negativo
                    if (textBox1.Text != "0" && textBox1.Text != "")
                    {
                        double C = 0;
                        C = System.Double.Parse(textBox1.Text);
                        if (C > 0)
                            textBox1.Text = "-" + textBox1.Text;
                        else if (C < 0)
                        {
                            C = C * -1;
                            textBox1.Text = C.ToString();
                        }
                        CambiarBorrarC();
                    }
                }
                if (palabra.Text == "square root")
                {
                    // Raiz cuadrada
                    //saca la raiz cuadrada del numero de la textbox
                    double c = SacarA(textBox1.Text);
                    Historial.Items.Add($"{c} x^x {c} = ");
                    c = Math.Sqrt(c);
                    Historial.Items.Add(c);
                    textBox1.Text = c.ToString();
                    CambiarBorrarCE();
                }
                if (palabra.Text == "root")
                {
                    // Raiz cuadrada
                    //saca la raiz cuadrada del numero de la textbox
                    double c = SacarA(textBox1.Text);
                    Historial.Items.Add($"{c} x^x {c} = ");
                    c = Math.Sqrt(c);
                    Historial.Items.Add(c);
                    textBox1.Text = c.ToString();
                    CambiarBorrarCE();
                }
                if (palabra.Text == "porcentaje")
                {
                    //deshabilita el boton de porcentaje y habilita los otros
                    if (textBox1.Text != "")
                    {
                        if (lblsigno.Text != "")
                        {
                            Igualar();
                            textBox1.Clear();
                        }
                        else
                        {
                            A = SacarA(textBox1.Text);

                        }
                        lblOperacion.Text = A.ToString();
                        lblsigno.Text = "%";
                        CambiarBorrarC();

                    }
                }
                if (palabra.Text == "raices")
                {
                    //Raiz enecima
                    //deshabilita el boton de Raiz enecima y habilita los otros
                    if (textBox1.Text != "")
                    {
                        if (lblsigno.Text != "")
                        {
                            Igualar();
                            textBox1.Clear();
                        }
                        else
                        {
                            A = SacarA(textBox1.Text);

                        }
                        lblsigno.Text = "x√";
                        lblOperacion.Text = A.ToString();
                        CambiarBorrarC();

                    }
                }
                if (palabra.Text == "root")
                {
                    //Raiz enecima
                    //deshabilita el boton de Raiz enecima y habilita los otros
                    if (textBox1.Text != "")
                    {
                        if (lblsigno.Text != "")
                        {
                            Igualar();
                            textBox1.Clear();
                        }
                        else
                        {
                            A = SacarA(textBox1.Text);

                        }
                        lblsigno.Text = "x√";
                        lblOperacion.Text = A.ToString();
                        CambiarBorrarC();

                    }
                }
                if (palabra.Text == "punto")
                {
                    //escribir punto
                    if (textBox1.Text.Contains(".") == false)
                    {
                        if (textBox1.Text == "")
                        {
                            textBox1.Text = textBox1.Text + "0.";
                            CambiarBorrarC();
                        }
                        else
                        {
                            textBox1.Text = textBox1.Text + ".";
                            CambiarBorrarC();
                        }
                    }
                }
                if (palabra.Text == "dot")
                {
                    //escribir punto
                    if (textBox1.Text.Contains(".") == false)
                    {
                        if (textBox1.Text == "")
                        {
                            textBox1.Text = textBox1.Text + "0.";
                            CambiarBorrarC();
                        }
                        else
                        {
                            textBox1.Text = textBox1.Text + ".";
                            CambiarBorrarC();
                        }
                    }
                }
            }
        }
    }
}