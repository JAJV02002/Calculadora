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
    public partial class Calculadora : Form
    {
        double first;
        double second;
        string operador;
        public Calculadora()
        {
            InitializeComponent();
        }

        Classes.ClsAdd obj = new Classes.ClsAdd();
        Classes.ClsSubstraction obj2 = new Classes.ClsSubstraction();
        Classes.ClsMultiply obj3 = new Classes.ClsMultiply();
        Classes.ClsDivide obj4 = new Classes.ClsDivide();
        Classes.ClsPercentage obj5 = new Classes.ClsPercentage();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }    

        private void Number1_Click(object sender, EventArgs e)
        {
            TxtScreen.Text = TxtScreen.Text + "1";
        }

        private void Number2_Click(object sender, EventArgs e)
        {
            TxtScreen.Text = TxtScreen.Text + "2";
        }
        private void Number3_Click(object sender, EventArgs e)
        {
            TxtScreen.Text = TxtScreen.Text + "3";
        }

        private void Number4_Click(object sender, EventArgs e)
        {
            TxtScreen.Text = TxtScreen.Text + "4";
        }

        private void Number5_Click(object sender, EventArgs e)
        {
            TxtScreen.Text = TxtScreen.Text + "5";
        }

        private void Number6_Click(object sender, EventArgs e)
        {
            TxtScreen.Text = TxtScreen.Text + "6";
        }

        private void Number7_Click(object sender, EventArgs e)
        {
            TxtScreen.Text = TxtScreen.Text + "7";
        }

        private void Number8_Click(object sender, EventArgs e)
        {
            TxtScreen.Text = TxtScreen.Text + "8";
        }
        
        private void Button3_Click(object sender, EventArgs e)
        {
            TxtScreen.Text = TxtScreen.Text + "9";
        }

        private void Number0_Click(object sender, EventArgs e)
        {
            TxtScreen.Text = TxtScreen.Text + "0";
        }
        private void DotBttn_Click(object sender, EventArgs e)
        {
            TxtScreen.Text = TxtScreen.Text + ".";
        }            

        private void AddBttn_Click(object sender, EventArgs e)
        {
            operador = "+";
            first = double.Parse(TxtScreen.Text);
            TxtScreen.Clear();
        }
        private void SubstractionBttn_Click(object sender, EventArgs e)
        {
            operador = "-";
            first = double.Parse(TxtScreen.Text);
            TxtScreen.Clear();
        }

        private void MultiplyBttn_Click(object sender, EventArgs e)
        {
            operador = "x";
            first = double.Parse(TxtScreen.Text);
            TxtScreen.Clear();
        }

        private void DivideBttn_Click(object sender, EventArgs e)
        {
            operador = "/";
            first = double.Parse(TxtScreen.Text);
            TxtScreen.Clear();
        }

        private void PercentageBttn_Click(object sender, EventArgs e)
        {
            operador = "%";
            first = double.Parse(TxtScreen.Text);
            TxtScreen.Clear();
        }
        private void EqualsBottn_Click(object sender, EventArgs e)
        {
            second = double.Parse(TxtScreen.Text);
            double Add;
            double Sub;
            double Mul;
            double Div;
            double Per;

            switch (operador)
            {
                case "+" :
                    Add = obj.Add((first), (second));
                    TxtScreen.Text = Add.ToString();
                    break;

                case "-":
                    Sub = obj2.Substraction((first), (second));
                    TxtScreen.Text = Sub.ToString();
                    break;

                case "x":
                    Mul = obj3.Multiply((first), (second));
                    TxtScreen.Text = Mul.ToString();
                    break;

                case "/":
                    Div = obj4.Divide((first), (second));
                    TxtScreen.Text = Div.ToString();
                    break;

                case "%":
                    Per = obj5.Percentage((first), (second));
                    TxtScreen.Text = Per.ToString();
                    break;
            }


        }
        private void OffBttn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearScreenBttn_Click(object sender, EventArgs e)
        {
            TxtScreen.Clear();
        }

        private void ClearNumberBttn_Click(object sender, EventArgs e)
        {
            if (TxtScreen.Text.Length == 1)
                TxtScreen.Text = "";
            else
                TxtScreen.Text = TxtScreen.Text.Substring(0, TxtScreen.Text.Length - 1);
        }
       
    }
}
