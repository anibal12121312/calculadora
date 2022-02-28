using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora

{
    public partial class Form1 : Form
    {
        string operador;

        double num1, num2, resultado;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "0";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            operador = "-";
            num1 = double.Parse(pantalla.Text); ///convierte un texto a numero (decimal o double)
            pantalla.Clear();

        }

        private void button15_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "9";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "3";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "2";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "8";
        }

        private void btn_punto_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + ".";
        }

        private void btn_c_Click(object sender, EventArgs e)
        {
            pantalla.Clear();
        }

        private void btn_remover_Click(object sender, EventArgs e)
        {
            if(pantalla.TextLength > 1)
            {
                pantalla.Text = pantalla.Text.Remove(pantalla.Text.Length - 1, 1);
            }
        }

        private void btn_por_Click(object sender, EventArgs e)
        {
            operador = "x";
            num1 = double.Parse(pantalla.Text); ///convierte un texto a numero (decimal o double)
            pantalla.Clear();
        }

        private void btn_division_Click(object sender, EventArgs e)
        {
            operador = "/";
            num1 = double.Parse(pantalla.Text); ///convierte un texto a numero (decimal o double)
            pantalla.Clear();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();


        }

        private void btn_igual_Click(object sender, EventArgs e)
        {

            num2 = double.Parse(pantalla.Text); ///convierte un texto a numero (decimal o double)


            switch (operador)
            {
                case "+":
                    resultado = num1 + num2;
                    break;

                case "-":
                    resultado = num1 - num2;
                    break;
                case "x":
                    resultado = num1 * num2;
                    break;
                case "/":
                    resultado = num1 / num2;
                    break;

            }

            pantalla.Text = resultado.ToString();  //convierte un numero a texto (string)


        }

        private void btn_suma_Click(object sender, EventArgs e)
        {
            operador = "+";
            num1 = double.Parse(pantalla.Text); ///convierte un texto a numero (decimal o double)
            pantalla.Clear();
            //pantalla.Text = num1.ToString() +"D"; //convierte un numero a texto (string)

        }
    }
}
