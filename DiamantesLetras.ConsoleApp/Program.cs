using System.Security.Cryptography.X509Certificates;

namespace DiamantesLetras.ConsoleApp
{
    internal class Program
    {
        static char[] alfabeto = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        static char letra;
        static int indexLetra;
        static string letraInformada;

        static void Main(string[] args)
        {
            ExibirTitulo();

            ColetandoInput();

            //pegando o index da letra no array do alfabeto
            PegandoIndexLetra();

            DesenhandoParteDeCima();

            DesenhandoParteDeBaixo();

        }

        #region ExibirTitulo
        private static void ExibirTitulo()
        {
            Console.WriteLine("-----------------------");
            Console.WriteLine("| Diamante de Letras! |");
            Console.WriteLine("-----------------------");
        }
        #endregion

        #region Colentando a Letra
        private static void ColetandoInput()
        {
            Console.WriteLine("Informe uma letra: ");
            letraInformada = Console.ReadLine().ToUpper();
            letra = Convert.ToChar(letraInformada);
        }
        #endregion

        #region Pegando o Index da Letra
        private static void PegandoIndexLetra()
        {
            for (int i = 0; i < alfabeto.Length; i++)
            {
                if (alfabeto[i] == letra)
                {
                    indexLetra = i;
                    break;
                }
            }
            Console.WriteLine(indexLetra);
        }
        #endregion

        #region Desenhando Parte de Cima
        private static void DesenhandoParteDeCima()
        {
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
        #endregion

        #region Desenhando Parte de Baixo
        private static void DesenhandoParteDeBaixo()
        {
            ///Parte de baixo do diamante
            ///iniciamos o i com o index da letra no array, ex: 4 (E)
            ///ele vai diminuindo a cada giro ate chegar no 0
            for (int i = indexLetra; i >= 0; i--)
            {
                ///fazendo o espaçamento inicial
                ///enquanto j for menor que o index da letra menos o i, continua aumentando
                for (int j = 0; j < indexLetra - i; j++)
                {
                    Console.Write(" ");
                }

                //fazendo rodar a partir do index da letra informada
                if (i != indexLetra)
                {
                    //imprimindo as letras após espaçamento
                    Console.Write(alfabeto[i]);

                    ///fazendo o espaçamento interior
                    ///enquanto j+1 for menor que 3 vezes o i ele aumenta
                    ///ex: j recebe 4 + 1 = 5, enquanto for menor que i(4)*3 = 7
                    ///ele continua aumentando
                    for (int j = i + 1; j < i * 3; j++)
                    {
                        Console.Write(" ");
                    }

                    //impedindo de duplicar a ultima letra
                    if (i != 0)
                    {
                        Console.WriteLine(alfabeto[i]);
                    }

                }
            }
        }
        #endregion
    }
}
