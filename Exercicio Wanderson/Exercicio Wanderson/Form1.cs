using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Exercicio_Wanderson
{

    public partial class exercicioForm : Form

    {
        public exercicioForm()
        {
            InitializeComponent();
        }
        #region Variaveis

        int codigoDoExercicio;
        ArrayList nota = new ArrayList();
        ArrayList nomeAluno = new ArrayList();
        MetodosDoExercicio  metodoEx = new MetodosDoExercicio();
        ArrayList labelResposta;
        List<Aluno> listaDeAlunos = new List<Aluno>();
        ArrayList salarios = new ArrayList();
#region enunciado
        string enunciadoExercicio7 = "Uma loja utiliza os seguintes códigos para as transações de cada dia:\n" +
                " 'v' - para compras à vista 'p' - para compras a prazo É dada uma lista de\n" +
                " transações contendo o valor de cada compra e o respectivo código da transação.\n" +
                "Faça um Programa que calcule e imprima:\n" +
                "valor total das compras à vista;\n" +
                "valor total das compras a prazo;\n" +
                "valor total das compras efetuadas;\n" +
                "O valor a receber pelas compras a prazo, isto é, primeira parcela,\n" +
                "sabendo que estas serão pagas em três vezes.Sabe - se que são efetuadas 25 transações por dia.";
#endregion







        #endregion



        #region Botao
        private void Exercicio1Button_Click(object sender, EventArgs e)
        {
            respostaLabel.Text = "";
            respostaLabel2.Text = "";
            respostaLabel3.Text = "";
            enunciadoLabel.Visible = false;
            notaTextBox.Visible = false;
            calcularButton.Visible = false;
            notaLabel.Visible = false;
            nomeLabel.Visible = false;
            nomeTextBox.Visible = false;
            addNotaButton.Visible = false;

            respostaLabel.Text = MetodosDoExercicio.Exercicio1();
        }

        private void exercicio2Button_Click(object sender, EventArgs e)
        {
            respostaLabel.Text = "";
            respostaLabel2.Visible = false;
            respostaLabel3.Visible = false;
            enunciadoLabel.Visible = false;
            notaTextBox.Visible = false;
            calcularButton.Visible = false;
            respostaLabel.Text = MetodosDoExercicio.Exercicio2();
            notaLabel.Visible = false;
            nomeLabel.Visible = false;
            nomeTextBox.Visible = false;
            addNotaButton.Visible = false;
        }

        private void exercicio3Button_Click(object sender, EventArgs e)
        {
            respostaLabel.Text = "";
            respostaLabel2.Visible = false;
            respostaLabel3.Visible = false;
            enunciadoLabel.Visible = false;
            notaTextBox.Visible = false;
            calcularButton.Visible = false;
            respostaLabel.Text = MetodosDoExercicio.Exercicio3();
            notaLabel.Visible = false;
            nomeLabel.Visible = false;
            nomeTextBox.Visible = false;
            addNotaButton.Visible = false;
        }

        private void exercicio4Button_Click(object sender, EventArgs e)
        {
            codigoDoExercicio = 4;
            respostaLabel.Text = "";
            respostaLabel2.Text = "Calcular o valor de S, usando os 20 primeiros \n" +
                " termos da série abaixo:\n" +
                "S=x/1 - x/2 + x/3 - x/4 ";
            respostaLabel3.Text = "";
            enunciadoLabel.Visible = true;
            enunciadoLabel.Text = "Informe o valor de X";
            notaTextBox.Visible = true;
            notaTextBox.Text = "0";
            notaTextBox.Focus();
            calcularButton.Visible = true;
            calcularButton.Text = "Calcular";
            notaLabel.Visible = false;
            nomeLabel.Visible = false;
            nomeTextBox.Visible = false;
            addNotaButton.Visible = false;


        }

        private void exercicio5Button_Click(object sender, EventArgs e)
        {
            respostaLabel.Text = "";
            respostaLabel2.Visible = true;
            respostaLabel3.Visible = false;
            respostaLabel2.Text = "";            
            enunciadoLabel.Visible = false;
            notaTextBox.Visible = false;
            calcularButton.Visible = false;
            respostaLabel.Text = MetodosDoExercicio.Exercicio5a();
            respostaLabel2.Text = MetodosDoExercicio.Exercicio5b();
            notaLabel.Visible = false;
            nomeLabel.Visible = false;
            nomeTextBox.Visible = false;
            addNotaButton.Visible = false;

        }

        private void exercicio6Button_Click(object sender, EventArgs e)
        {
            respostaLabel.Text = "";
            respostaLabel2.Text = "";
            respostaLabel2.Visible = true;
            respostaLabel3.Visible = false;
            codigoDoExercicio = 6;
            enunciadoLabel.Visible = true;
            enunciadoLabel.Text = "Informe o número que você deseja saber a tabuada";
            notaTextBox.Visible = true;
            notaTextBox.Text = "0";
            notaTextBox.Focus();
            calcularButton.Visible = true;
            calcularButton.Text = "Calcular";
            notaLabel.Visible = false;
            nomeLabel.Visible = false;
            nomeTextBox.Visible = false;
            addNotaButton.Visible = false;

        }

        private void exercicio7Button_Click(object sender, EventArgs e)
        {
            respostaLabel2.Visible = true;
            respostaLabel3.Visible = true;
            enunciadoLabel.Visible = true;
            notaTextBox.Visible = false;
            calcularButton.Visible = false;
            notaLabel.Visible = false;
            nomeLabel.Visible = false;
            nomeTextBox.Visible = false;
            addNotaButton.Visible = false;
            enunciadoLabel.Text = enunciadoExercicio7;

            metodoEx.Resposta = new ArrayList();

            metodoEx.Exercicio7();

            labelResposta = new ArrayList
            {
                respostaLabel,
                respostaLabel2,
                respostaLabel3
            };

            for (int i = 0; i < metodoEx.Resposta.Count; i++)
            {
                (labelResposta[i] as Label).Text = metodoEx.Resposta[i].ToString();
            }


        }

        private void exercicio8Button_Click(object sender, EventArgs e)
        {
            codigoDoExercicio = 8;
            addNotaButton.Visible = true;
            addNotaButton.Location = new Point(284, 28);
            respostaLabel.Text = "";
            respostaLabel2.Text = "";
            respostaLabel3.Text = "";
            enunciadoLabel.Visible = true;
            enunciadoLabel.Text = "informe a nota aluno e clique em ADD";
            notaTextBox.Visible = true;
            notaTextBox.Focus();
            calcularButton.Visible = true;
            calcularButton.Text = "Calcular";
            notaLabel.Visible = false;
            nomeLabel.Visible = false;
            nomeTextBox.Visible = false;




        }
        
        private void exercicio9Button_Click(object sender, EventArgs e)
        {
            codigoDoExercicio = 9;
            addNotaButton.Visible = true;
            addNotaButton.Location = new Point(284, 28);
            respostaLabel.Text = "";
            respostaLabel2.Text = "";
            respostaLabel2.Visible = true;
            respostaLabel3.Visible = true;
            respostaLabel3.Text = "";
            enunciadoLabel.Visible = true;
            enunciadoLabel.Text = "informe a nota e o nome do aluno e clique em ADD";
            notaTextBox.Visible = true;          
            calcularButton.Visible = true;
            calcularButton.Text = "Calcular";
            nomeTextBox.Visible = true;
            nomeTextBox.Focus();
            notaLabel.Visible = true;
            nomeLabel.Visible = true;
            nomeLabel.Text = "Nome";
            notaLabel.Text = "nota";
            


        }

        private void exercicio10Button_Click(object sender, EventArgs e)
        {
            codigoDoExercicio = 10;
            
            respostaLabel.Text = "";
            respostaLabel2.Text = "";
            respostaLabel3.Text = "";         
            enunciadoLabel.Visible = true;            
            enunciadoLabel.Text = "informe o salário e clique em Exibir";
            notaTextBox.Visible = false;
            addNotaButton.Visible = true;
            addNotaButton.Location = new Point(254, 28);
            calcularButton.Visible = true;
            calcularButton.Text = "exibir";
            nomeTextBox.Visible = true;
            nomeTextBox.Focus();
            notaLabel.Visible = false;
            nomeLabel.Visible = true;
            nomeLabel.Text = "Salario";
            notaLabel.Text = "nota";
        }
        #endregion

        #region Metodos Botao

        void calcularButton_Click(object sender, EventArgs e)
        {

            switch (codigoDoExercicio)
            {
                case 4:
                    try
                    {
                        respostaLabel.Text = MetodosDoExercicio.Exercicio4(Convert.ToDouble(notaTextBox.Text));
                        notaTextBox.Text = "0";
                        

                        break;
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Formato inválido");
                        break;
                    }

                case 6:
                    try
                    {
                        respostaLabel.Text = MetodosDoExercicio.Exercicio6a(notaTextBox.Text);
                        respostaLabel3.Text = MetodosDoExercicio.Exercicio6b(notaTextBox.Text);
                        notaTextBox.Text = ""; 
                        break;
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Formato inválido");
                        break;
                    }

                case 8:
                    respostaLabel.Text = "Notas Maiores que a média\n" + 
                        MetodosDoExercicio.Exercicio8a(nota).ToString();
                    respostaLabel2.Text = "Notas Menores do que a média\n" + 
                        MetodosDoExercicio.Exercicio8b(nota).ToString();
                    respostaLabel3.Text = nota.Count.ToString();
                    nota.Clear();
                    break;

                case 9:
                    respostaLabel.Text = MetodosDoExercicio.Exercicio9(listaDeAlunos);
                    listaDeAlunos.Clear();

                    break;
                case 10:
                    respostaLabel.Text = MetodosDoExercicio.Exercicio10(salarios);
                    salarios.Clear();
                    break;
            }

            

        }

        public void addNotaButton_Click_1(object sender, EventArgs e)
        {
            switch (codigoDoExercicio)
            {
                case 8:
                    try
                    {
                        notaTextBox.Focus();
                        if (Convert.ToDouble(notaTextBox.Text) < 0)
                        {
                            throw new ApplicationException
                                ("Sabemos que o aluno é ruim, mas nota negativa não pode.");
                        }
                        nota.Add(notaTextBox.Text);
                        notaTextBox.Clear();
                        respostaLabel3.Text = nota.Count.ToString();
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Formato inválido");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    break;

                case 9:
                    try
                        
                    {
                        nomeTextBox.Focus();
                        if (Convert.ToDouble(notaTextBox.Text) < 0)
                        {
                            throw new ApplicationException
                                ("Sabemos que o aluno é ruim, mas nota negativa não pode.");
                        }


                        listaDeAlunos.Add(new Aluno()
                        {
                            nome = nomeTextBox.Text,
                            nota = notaTextBox.Text
                        });

                        nomeTextBox.Clear();
                        notaTextBox.Clear();
                        respostaLabel3.Text = "Numero de alunos: " + listaDeAlunos.Count.ToString();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    break;

                case 10:
                    try
                    {
                        nomeTextBox.Focus();
                        if (nomeTextBox.Text.Equals("-1"))
                        {
                            respostaLabel.Text = MetodosDoExercicio.Exercicio10(salarios);
                            break;
                        }

                        if (Convert.ToDecimal(nomeTextBox.Text) < -1)
                        {
                            throw new ApplicationException
                                ("Salario muito baixo");
                        }
                        salarios.Add(nomeTextBox.Text);
                        nomeTextBox.Clear();
                        respostaLabel3.Text =
                            "Quantidade de salários adicionados: " + salarios.Count.ToString();

                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    break;
            }



        }

        #endregion
    }
}