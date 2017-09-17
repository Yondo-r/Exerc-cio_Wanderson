using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


//Classe para tratar o evento de cada botão
namespace Exercicio_Wanderson
{
   public  class MetodosDoExercicio
    {
        public ArrayList Resposta { get;  set; }
        
        public static string Exercicio1()
        {
            string resposta;
            int soma = 0;
            for (int i = 1; i < 101; i++)
            {
                soma += i;
            }

             return resposta =
            "Resposta: A soma dos numeros naturais de 1 a 100 é:\n"
            + soma;
        }        

        public static string Exercicio2()
        {
            string resultado = "7";
            for (int i = 8; i < 200; i++)
            {
                if (i % 7 == 0)
                {
                    resultado = resultado + " - " + i;
                }
            }
            return resultado =
            "resposta: Os multiplos de 7 menores que 200 são:\n" + resultado;
        }        

        public static string Exercicio3()
        {
            String resultado = "4";
            for (int i = 5; i < 100; i++)
            {
                if (i % 4 == 0)
                {
                    resultado = resultado + " - " + i;
                }
            }
            return resultado =
            "Resposta: Os números divisíveis por 4 menor que 100 são: \n" + resultado;
        }

        public static string Exercicio4(double x)

        {
            double resultado = 0;
            string resposta;
            //double x = Convert.ToDouble(infoX4TextBox.Text);
            int sinal = 1;

            for (int i = 1; i <= 3; i++)
            {
                resultado += sinal * (x / i);
                sinal *= -1;

            }
            return resposta  = Convert.ToString(resultado);

        }

        public static string Exercicio5a()
        {
            string resposta1;
            string resultado = "";
            int x = 1;
            for (int i = 1; i < 11; i++)
            {
                x = 5 * i;
                resultado = resultado + " 5 x " + i + " = " + x + "\n";
            }
                        
            return resposta1 =
            "Resposta : A tabuada do 5 em for é: \n" +
            resultado;
            
        }
        public static string Exercicio5b()
        {
            string resposta2;
            String resultadoB = "";
            int xB = 1;
            int y = 0;
            while (y++ < 10)
            {
                xB = 5 * y;
                resultadoB = resultadoB + " 5 x " + y + " = " + xB + "\n";
            }
           
            return resposta2 = "Resposta: A tabuada do 5 em while é: \n" +
            resultadoB;

        }

        public static string Exercicio6a(string numero)
        {
            string resposta;
            int x = Convert.ToInt32(numero);
            int mult;
            string resultado = "";
            for (int i = 1; i < 11; i++)
            {
                mult = x * i;
                resultado += x + " x " + i + " = " + Convert.ToString(mult) + "\n";
            }
            resposta = "A tabuada no loop for do número fornecido é: \n"
            + resultado;
            return resposta;
        }
        public static string Exercicio6b(string numero)
        {
            int x = Convert.ToInt32(numero);
            string resposta;
            string resultado = "";
            int i = 0;
            int mult;

            while (i++ < 10)
            {
                mult = x * i;
                resultado += x + " x " + i + " = " + Convert.ToString(mult) + "\n";
            }
            return resposta = "A tabuda no loop while do número fornecido é: \n"
            + resultado;

        }

        public string  Exercicio7()
        {
            decimal totalDeComprasAPrazo = 0;
            decimal totalDeComprasAVista = 0;
            decimal lucroDodia = 0;

            Random codigoDaCompra = new Random();
            Random compra = new Random();

            decimal transacao;
            decimal formaDePagamento;

            string valorDaCompra = "";

            int numeroDeComprasDodia = 10;

            //Quantas compras serão feitas
            for (int i = 0; i < numeroDeComprasDodia; i++)
            {
                //gerando um valor pra compra
                transacao = compra.Next(999);
                //gerando um código para compra. 0=compra a vista 1=compra a prazo
                formaDePagamento = codigoDaCompra.Next(2);
                if (codigoDaCompra.Next(2) == 0)

                    totalDeComprasAVista += transacao / 100;

                else

                    totalDeComprasAPrazo += (transacao / 100) / 3;

                //transformando em $$ e somando o valor de cada compra
                lucroDodia = totalDeComprasAVista + totalDeComprasAPrazo;
                //formatando resultado para exibir o valor de cada compra separadamente
                valorDaCompra +=
                    Convert.ToString("compra " + (i + 1) + " código " + formaDePagamento + " R$" + transacao / 100 + "\n"); ;
            }
            //exibindo o que foi pedido



            Resposta.Add
                ("O valor total das compras a vista é: R$" + totalDeComprasAVista);
            Resposta.Add
                ("O valor total das compras a prazo é: R$" + Math.Round(totalDeComprasAPrazo, 2));
            Resposta.Add
                ("O lucro do dia foi R$" + Math.Round(lucroDodia, 2));
            
            return "";

            

        }

        public static string Exercicio8a(ArrayList nota)
        {
            double media;
            double somaDasNotas = 0;
            string numerosMaiorQMedia = "";
            foreach (var item in nota)
            {
                somaDasNotas += Convert.ToDouble(item.ToString());
            }
           
            media = somaDasNotas / nota.Count;

            foreach (var item in nota)
            {
                if (Convert.ToDouble(item) > media)
                {
                   numerosMaiorQMedia += item.ToString() + "\n";
                }
            }
            return numerosMaiorQMedia;
        }

        public static string Exercicio8b(ArrayList nota)
        {
            double media;
            double somaDasNotas = 0;
            string numerosMenorQMedia = "";
            foreach (var item in nota)
            {
                somaDasNotas += Convert.ToDouble(item.ToString());
            }

            media = somaDasNotas / nota.Count;

            foreach (var item in nota)
            {
                if (Convert.ToDouble(item) < media)
                {
                    numerosMenorQMedia += item.ToString() + "\n";
                }
            }
            return numerosMenorQMedia;
        }

        public static string Exercicio9(List<Aluno> listaDeAlunos)
        {
            double media;
            double somaDasNotas = 0;
            string numerosMaiorQMedia = "";

            foreach (var item in listaDeAlunos) 
            {
                somaDasNotas += Convert.ToDouble(item.nota);
            }

            media = somaDasNotas / listaDeAlunos.Count;

            foreach (Aluno aluno in listaDeAlunos)
            {

                if (Convert.ToDouble ( aluno.nota) > media)
                {
                    numerosMaiorQMedia += aluno.nome + " ";
                }
            
            }


            return "Os alunos que possuem nota maior que a média são: \n" + numerosMaiorQMedia;
        }

        public static string Exercicio10(ArrayList salarios)
        {
            string salarioReajuste = "";
            double reajuste = 0.15;
            foreach (var item in salarios)
            {
                salarioReajuste += Convert.ToDecimal(item) + 
                    ((Convert.ToDecimal(item) * Convert.ToDecimal(reajuste))) 
                    + "\n";
            }
            return "O Salário com reajuste de 15% é \n" + salarioReajuste ;
        }
    }
}
