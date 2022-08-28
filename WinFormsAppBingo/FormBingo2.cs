using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsAppBingo
{
    public partial class FormBingo2 : Form
    {
        //LISTA DE NUMEROS PARA BINGO
        List<int> Lista_Numeros_Bingo = new List<int>();
        public FormBingo2()
        {
            InitializeComponent();
            buttonRelogioI.ForeColor = Color.Black;
        }

        private void FormBingo2_Load(object sender, EventArgs e)
        {

        }
        public void ListaNumero()
        {
            try
            {

            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.ToString()); }
            for (int ListaNumero = 1; ListaNumero < 76; ListaNumero++)
            {
                Lista_Numeros_Bingo.Add(ListaNumero);
            }
            for (int i = 0; i < Lista_Numeros_Bingo.Count; i++)
            {
                if (i == 74) { textBoxNumeros.Text = textBoxNumeros.Text + Lista_Numeros_Bingo[i].ToString() + "."; }
                else { textBoxNumeros.Text = textBoxNumeros.Text + Lista_Numeros_Bingo[i].ToString() + ","; }
            }
        }

        private void buttonInicio_Click(object sender, EventArgs e)
        {
            buttonInicio.Text = "RENICIAR";
            if (Lista_Numeros_Bingo.Count == 0)
            {
                ListaNumero();
            }
            else
            {
                DialogResult SalvaCliente = MessageBox.Show("INICIAR NOVO BINGO ? ",
                                         "Aviso", MessageBoxButtons.YesNo);
                if (SalvaCliente == DialogResult.Yes)
                {
                    Lista_Numeros_Bingo.Clear();
                    LimpaJogos();
                    textBoxNumeros.Text = "";
                    ListaNumero();
                }
                if (SalvaCliente == DialogResult.No)
                {
                    MessageBox.Show("JOGO OCORRENDO AINDA!");
                }
            }
        }
        public void LimpaJogos()
        {
            for (int inicio = 1; inicio < 76; inicio++)
            {
                string textBoxEntrada2 = "button";
                StringBuilder sb = new StringBuilder(textBoxEntrada2);
                sb.Append(inicio);
                if (inicio < 16)
                {
                    Panel panel = Application.OpenForms["FormBingo"].Controls["panel1"] as Panel;
                    Button Button = panel.Controls[sb.ToString()] as Button;
                    Button.BackColor = Color.Gainsboro;
                }
                if ((inicio > 15) && (inicio < 31))
                {
                    Panel panel = Application.OpenForms["FormBingo"].Controls["panel2"] as Panel;
                    Button Button = panel.Controls[sb.ToString()] as Button;
                    Button.BackColor = Color.Gainsboro;
                }
                if ((inicio > 30) && (inicio < 46))
                {
                    Panel panel = Application.OpenForms["FormBingo"].Controls["panel3"] as Panel;
                    Button Button = panel.Controls[sb.ToString()] as Button;
                    Button.BackColor = Color.Gainsboro;
                }
                if ((inicio > 45) && (inicio < 61))
                {
                    Panel panel = Application.OpenForms["FormBingo"].Controls["panel4"] as Panel;
                    Button Button = panel.Controls[sb.ToString()] as Button;
                    Button.BackColor = Color.Gainsboro;
                }
                if (inicio > 60)
                {
                    Panel panel = Application.OpenForms["FormBingo"].Controls["panel5"] as Panel;
                    Button Button = panel.Controls[sb.ToString()] as Button;
                    Button.BackColor = Color.Gainsboro;
                }

            }

        }

        private void buttonProximo_Click(object sender, EventArgs e)
        {
            if (Lista_Numeros_Bingo.Count == 0)
            {
                MessageBox.Show("JOGO NÃO INICIADO OU SEM NUMERO PARA ESCOLHER!");
            }
            else { RandomNumero(); }
        }
        public void RandomNumero()
        {
            try
            {
                //Panel panel = Application.OpenForms["FormBingo"].Controls["panelTotal"].Controls["panelResultado"] 
                Random rnd = new Random();
                int posicao = rnd.Next(0, Lista_Numeros_Bingo.Count);
                textBoxBola.Text = Lista_Numeros_Bingo[posicao].ToString();

                if (Lista_Numeros_Bingo[posicao] < 16)//B
                {
                    string textBoxEntrada2 = "button";
                    StringBuilder sb = new StringBuilder(textBoxEntrada2);
                    sb.Append(Lista_Numeros_Bingo[posicao]);
                    Panel panel = Application.OpenForms["FormBingo"].Controls["panel1"] as Panel;
                    Button Button = panel.Controls[sb.ToString()] as Button;
                    Button.BackColor = Color.LightSkyBlue;
                    textBoxlLetra.Text = "B";

                }
                if ((Lista_Numeros_Bingo[posicao] > 15) && (Lista_Numeros_Bingo[posicao] < 31)) //I
                {
                    string textBoxEntrada2 = "button";
                    StringBuilder sb = new StringBuilder(textBoxEntrada2);
                    sb.Append(Lista_Numeros_Bingo[posicao]);
                    Panel panel = Application.OpenForms["FormBingo"].Controls["panel2"] as Panel;
                    Button Button = panel.Controls[sb.ToString()] as Button;
                    Button.BackColor = Color.LightSkyBlue;
                    textBoxlLetra.Text = "I";
                }
                if ((Lista_Numeros_Bingo[posicao] > 30) && (Lista_Numeros_Bingo[posicao] < 46))//N
                {
                    string textBoxEntrada2 = "button";
                    StringBuilder sb = new StringBuilder(textBoxEntrada2);
                    sb.Append(Lista_Numeros_Bingo[posicao]);
                    Panel panel = Application.OpenForms["FormBingo"].Controls["panel3"] as Panel;
                    Button Button = panel.Controls[sb.ToString()] as Button;
                    Button.BackColor = Color.LightSkyBlue;
                    textBoxlLetra.Text = "N";
                }
                if ((Lista_Numeros_Bingo[posicao] > 45) && (Lista_Numeros_Bingo[posicao] < 61))//G
                {
                    string textBoxEntrada2 = "button";
                    StringBuilder sb = new StringBuilder(textBoxEntrada2);
                    sb.Append(Lista_Numeros_Bingo[posicao]);
                    Panel panel = Application.OpenForms["FormBingo"].Controls["panel4"] as Panel;
                    Button Button = panel.Controls[sb.ToString()] as Button;
                    Button.BackColor = Color.LightSkyBlue;
                    textBoxlLetra.Text = "G";
                }
                if (Lista_Numeros_Bingo[posicao] > 60)//O
                {
                    string textBoxEntrada2 = "button";
                    StringBuilder sb = new StringBuilder(textBoxEntrada2);
                    sb.Append(Lista_Numeros_Bingo[posicao]);
                    Panel panel = Application.OpenForms["FormBingo"].Controls["panel5"] as Panel;
                    Button Button = panel.Controls[sb.ToString()] as Button;
                    Button.BackColor = Color.LightSkyBlue;
                    textBoxlLetra.Text = "O";
                }
                Lista_Numeros_Bingo.RemoveAt(posicao);
                textBoxNumeros.Text = "";
                for (int i = 0; i < Lista_Numeros_Bingo.Count; i++)
                {
                    if (i == Lista_Numeros_Bingo.Count - 1) { textBoxNumeros.Text = textBoxNumeros.Text + Lista_Numeros_Bingo[i].ToString() + "."; }
                    else { textBoxNumeros.Text = textBoxNumeros.Text + Lista_Numeros_Bingo[i].ToString() + ","; }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());

            }
        }

        private void buttonRelogioI_Click(object sender, EventArgs e)
        {
            if (Lista_Numeros_Bingo.Count > 0)
            {
                if (buttonRelogioI.ForeColor == Color.Black)
                {
                    buttonRelogioI.ForeColor = Color.Red;
                    buttonRelogioI.Text = "PARAR";

                    timerNumero.Enabled = true;
                    timerNumero.Interval = int.Parse(textBoxTempo.Text.ToString());
                    timerNumero.Start();
                    RandomNumero();

                }
                else
                {
                    buttonRelogioI.ForeColor = Color.Black;
                    buttonRelogioI.Text = "INICIAR";

                    timerNumero.Stop();
                    timerNumero.Enabled = false;
                }
            }
            else
            {
                timerNumero.Stop();
                timerNumero.Enabled = false;
            }
        }
    }
}
