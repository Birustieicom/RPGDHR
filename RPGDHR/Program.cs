using System;

namespace RPGturnos
{
    class Program
    {
        static void Main(string[] args)
        {
            string menu;
            Console.WriteLine("D&D: O Jogo");
            Console.WriteLine("Pressione qualquer tecla para começar");
            Console.ReadKey();
            Console.WriteLine("");

            do
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1 - Novo Jogo");
                Console.WriteLine("2 - Sair");
                menu = Console.ReadLine();
                Console.Clear();
                if (menu == "1")
                {
                    Personagem Char = new Personagem();
                    Char.criacaoPersonagem();
                }
                else if (menu == "2")
                {

                }
                else if (menu != "1" && menu != "2")
                {
                    Console.WriteLine("Esta opção não está disponível");
                    Console.WriteLine("Tente outra opção");
                    Console.WriteLine("");
                }
            } while (menu != "1" && menu != "2");

            Itens Equipes = new Itens();
            Equipes.cadastrarItem();
        }
    }
}
