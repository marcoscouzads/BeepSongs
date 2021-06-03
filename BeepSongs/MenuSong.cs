using System;

namespace BeepSongs
{
    class MenuSong
    {
        static void Main(string[] args)
        {
            string opcaoMenu;
            do
            {
                ExibirMenuPrincipal();
                opcaoMenu = Console.ReadLine();

                if (opcaoMenu == "1")
                {
                    Song1();
                }
                else if (opcaoMenu == "2")
                {
                    Song2();
                }
                else if (opcaoMenu == "3")
                {
                    Song3();
                }
                else if (opcaoMenu == "4")
                {
                    Console.Clear();
                    Console.WriteLine("voce escolheu para sair! ");
                    Songs.Song1();
                }
                else if (opcaoMenu != "4")
                {
                    Console.WriteLine("Digite uma opção valida!");
                }
                Console.WriteLine("aperte qualquer tecla para continuar");
                Console.ReadKey();



            } while (opcaoMenu != "4");

            static void ExibirMenuPrincipal()
            {
                Console.Clear();
                Console.WriteLine("---Menu de utilidade---");
                Console.WriteLine("1 - Super Mario : ");
                Console.WriteLine("2 - Tetris : ");
                Console.WriteLine("3 - Happy Birthday : ");
                Console.WriteLine("4 - Sair : ");

            }

            static void Song1()
            {
                Console.Clear();
                Console.WriteLine("Música do Super Mario");
                Songs.SuperMario();

            }
            static void Song2()
            {
                Console.Clear();
                Console.WriteLine("Música do Tetris");
                Songs.Tetris();
            }
            static void Song3()
            {
                Console.Clear();
                Console.WriteLine("Música feliz aniversário");
                Songs.HappyBirthday();
            }
        }
    }
}
