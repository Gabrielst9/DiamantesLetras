using System.Security.Cryptography.X509Certificates;

namespace DiamantesLetras.ConsoleApp
{
    internal class Program
    {
        //M é a letra que fica na metado do alfabeto
        static char[] alfabeto = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        static char letra = 'E';
        static int indexLetra;


        static void Main(string[] args)
        {
            ExibirTitulo();

            //pegando o index da letra no array do alfabeto
            for (int i = 0; i < alfabeto.Length; i++)
            {
                if (alfabeto[i] == letra)
                {
                    indexLetra = i;
                    break;
                }
            }
            Console.WriteLine(indexLetra);


            //gira ate o index da letra
            for (int i = 0; i <= indexLetra; i++)
            {
                ///fazendo o espaçamento até alcançar o index da letra digitada
                ///ex: se a letra for E ele vai fazer até D
                for (int j = 0; j < indexLetra - i; j++)
                {
                    Console.Write(" ");
                }

                //imprimindo a letra depois do espaçamento ser feito
                Console.Write(alfabeto[i]);

                ///verifica se o i é 0
                ///no caso se for a primeira letra A ele não faz outras colunas
                if (i > 0)
                {
                    ///faz a conta do espaçamento entre as letras
                    ///enquanto j é menor que 2 x i -1
                    ///ele continua imprimindo os espaços
                    for (int j = 0; j < 2 * i - 1; j++)
                    {
                        Console.Write(" ");
                    }
                    
                    //escrever a outra coluna de letras
                    Console.Write(alfabeto[i]);
                }

                //passa para a proxima linha
                Console.WriteLine();
            }

        }
  

        #region ExibirTitulo
        private static void ExibirTitulo()
        {
            Console.WriteLine("-----------------------");
            Console.WriteLine("| Diamante de Letras! |");
            Console.WriteLine("-----------------------");
        }
        #endregion
    }
}
