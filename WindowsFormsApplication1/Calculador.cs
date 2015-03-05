using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace WindowsFormsApplication1
{
    public partial class xXx_calculator420_xXx : Form{
        public xXx_calculator420_xXx(){
            InitializeComponent();
        }
        public double primeironm;
        public double segundonm;
        public string operacao;
        public string lastOperacao;
        public double result;
        public bool temvirgula;
        public bool segundo = false;
        public bool eresultado = false;

        private void NumberClick(object sender, EventArgs e){
            Button xXx_digito_xXx = sender as Button;
            lastOperacao = "";
            if (textBoxResultado.Text.Length <= 28){
                if (segundo == true) { textBoxResultado.Text = ""; }
                segundo = false;
                if (textBoxResultado.Text != "0"){
                    if (xXx_digito_xXx.Text == ","){
                        if (temvirgula == false){
                            textBoxResultado.Text = textBoxResultado.Text + xXx_digito_xXx.Text;
                            temvirgula = true;
                        }
                    }else{
                        if (eresultado == false){
                            textBoxResultado.Text = textBoxResultado.Text + xXx_digito_xXx.Text;
                        }else{
                            textBoxResultado.Text = xXx_digito_xXx.Text;
                            eresultado = false;
                        }
                    }
                }else{
                    textBoxResultado.Text = xXx_digito_xXx.Text;
                }
            }
        }

        private void C__Click(object sender, EventArgs e){
            textBoxResultado.Text = "0";
            lastOperacao = "";
            temvirgula = false;
            eresultado = false;
        }

        private void Back_Click(object sender, EventArgs e){
            if (eresultado == false && lastOperacao == ""){
                if (textBoxResultado.Text.Length > 0 && textBoxResultado.Text != "0"){
                    textBoxResultado.Text = textBoxResultado.Text.Remove(textBoxResultado.Text.Length - 1);
                }
                if (textBoxResultado.Text == ""){
                    textBoxResultado.Text = "0";
                }
            }
        }

        private void Operacao_Click(object sender, EventArgs e){
            Button xXx_operacao_xXx = sender as Button;
            operacao = xXx_operacao_xXx.Text;
            Debug.Print(textBoxResultado.Text + " | " + operacao);
            primeironm = double.Parse(textBoxResultado.Text);
            Debug.Print(primeironm + " | " + operacao);
            temvirgula = false;
            segundo = true;
            eresultado = false;
            lastOperacao = "";
        }

        private void OperacaoUnica(object sender, EventArgs e){
            Button xXx_operacao_xXx = sender as Button;
            operacao = xXx_operacao_xXx.Text;
            Debug.Print(textBoxResultado.Text + " | " + operacao);
            primeironm = double.Parse(textBoxResultado.Text);
            Debug.Print(primeironm + " | " + operacao);
            temvirgula = false;
            segundo = true;
            switch (operacao){
                case "√":
                    eresultado = true;
                    lastOperacao = operacao;
                    result = Math.Sqrt(primeironm);
                    textBoxResultado.Text = Convert.ToString(result);
                    Debug.Print(primeironm + " | " + operacao + " | " + segundonm + " | " + result);
                    break;

                case "sen":
                    eresultado = true;
                    lastOperacao = operacao;
                    result = Math.Sin(primeironm * (Math.PI / 180.0));
                    textBoxResultado.Text = Convert.ToString(result);
                    Debug.Print(primeironm + " | " + operacao + " | " + segundonm + " | " + result);
                    break;

                case "cos":
                    eresultado = true;
                    lastOperacao = operacao;
                    result = Math.Cos(primeironm * (Math.PI / 180.0));
                    textBoxResultado.Text = Convert.ToString(result);
                    Debug.Print(primeironm + " | " + operacao + " | " + segundonm + " | " + result);
                    break;

                case "tg":
                    eresultado = true;
                    lastOperacao = operacao;
                    result = Math.Tan(primeironm * (Math.PI / 180.0));
                    textBoxResultado.Text = Convert.ToString(result);
                    Debug.Print(primeironm + " | " + operacao + " | " + segundonm + " | " + result);
                    break;

                case "+ -":
                    eresultado = true;
                    lastOperacao = operacao;
                    result = primeironm * (-1);
                    textBoxResultado.Text = Convert.ToString(result);
                    Debug.Print(primeironm + " | " + operacao + " | " + segundonm + " | " + result);
                    break;

                default:
                    break;
            }
        }

        private void Igual_Click(object sender, EventArgs e){
            switch (operacao){
                case "+":
                    eresultado = true;
                    if (lastOperacao == "") { segundonm = Convert.ToDouble(textBoxResultado.Text); }
                    else { primeironm = Convert.ToDouble(textBoxResultado.Text); }
                    lastOperacao = operacao;
                    result = primeironm + segundonm;
                    textBoxResultado.Text = Convert.ToString(result);
                    Debug.Print(primeironm + " | " + operacao + " | " + segundonm + " | " + result);
                    break;

                case "-":
                    eresultado = true;
                    if (lastOperacao == "") { segundonm = Convert.ToDouble(textBoxResultado.Text); }
                    else { primeironm = Convert.ToDouble(textBoxResultado.Text); }
                    lastOperacao = operacao;
                    result = primeironm - segundonm;
                    textBoxResultado.Text = Convert.ToString(result);
                    Debug.Print(primeironm + " | " + operacao + " | " + segundonm + " | " + result);
                    break;

                case "*":
                    eresultado = true;
                    if (lastOperacao == "") { segundonm = Convert.ToDouble(textBoxResultado.Text); }
                    else { primeironm = Convert.ToDouble(textBoxResultado.Text); }
                    lastOperacao = operacao;
                    result = primeironm * segundonm;
                    textBoxResultado.Text = Convert.ToString(result);
                    Debug.Print(primeironm + " | " + operacao + " | " + segundonm + " | " + result);
                    break;

                case "/":
                    eresultado = true;
                    if (lastOperacao == "") { segundonm = Convert.ToDouble(textBoxResultado.Text);}
                    else { primeironm = Convert.ToDouble(textBoxResultado.Text); }
                    lastOperacao = operacao;
                    result = primeironm / segundonm;
                    textBoxResultado.Text = Convert.ToString(result);
                    Debug.Print(primeironm + " | " + operacao + " | " + segundonm + " | " + result);
                    break;

                case "Resto":
                    eresultado = true;
                    if (lastOperacao == "") { segundonm = Convert.ToDouble(textBoxResultado.Text);}
                    else { primeironm = Convert.ToDouble(textBoxResultado.Text); }
                    lastOperacao = operacao;
                    result = primeironm % segundonm;
                    textBoxResultado.Text = Convert.ToString(result);
                    Debug.Print(primeironm + " | " + operacao + " | " + segundonm + " | " + result);
                    break;

                case "%":
                    eresultado = true;
                    if (lastOperacao == "") { segundonm = Convert.ToDouble(textBoxResultado.Text);}
                    else { primeironm = Convert.ToDouble(textBoxResultado.Text); }
                    lastOperacao = operacao;
                    result = (primeironm / 100) * segundonm;
                    textBoxResultado.Text = Convert.ToString(result);
                    Debug.Print(primeironm + " | " + operacao + " | " + segundonm + " | " + result);
                    break;

                case "x²":
                    eresultado = true;
                    if (lastOperacao == "") { segundonm = Convert.ToDouble(textBoxResultado.Text);}
                    else { primeironm = Convert.ToDouble(textBoxResultado.Text); }
                    lastOperacao = operacao;
                    result = Math.Pow(primeironm, segundonm);
                    textBoxResultado.Text = Convert.ToString(result);
                    Debug.Print(primeironm + " | " + operacao + " | " + segundonm + " | " + result);
                    break;

                default:
                    break;
            }
        }
    }
}
