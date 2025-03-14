using System;
using System.Collections.Generic;
using System.Text;

namespace RPGturnos
{
    public class Personagem
    {
        string nome;
        string classe;
        int pontosdevida;
        int pontosdeenergia;
        int ataque;
        int resistencia;
        int experiencia;
        int nivel;
        int vidapornivel;
        int energiapornivel;

        public void criacaoPersonagem()
        {
            Console.WriteLine("Insira o nome do seu personagem");
            nome = Console.ReadLine();
            Console.Clear();

            do
            {
                Console.Clear();
                Console.WriteLine("Classes disponíveis");
                Console.WriteLine("");
                Console.WriteLine("Guerreiro");
                Console.WriteLine("Arqueiro");
                Console.WriteLine("Mago");
                Console.WriteLine("Monge");
                Console.WriteLine("Bardo");
                Console.WriteLine("Ladino");
                Console.WriteLine("");
                Console.WriteLine("Escreva qual a classe do seu personagem");
                classe = Console.ReadLine();
            } while (classe != "Guerreiro" && classe != "Arqueiro" && classe != "Mago" && classe != "Monge" && classe != "Bardo" && classe != "Ladino");

            Console.Clear();
            Console.WriteLine("Bem vindo " + nome);
            Console.WriteLine("Você pertence a classe " + classe);
            Console.WriteLine("Seus atributos são:");
            Console.WriteLine("");

            if (classe == "Guerreiro")
            {
                construirGuerreiro();
                Console.ReadKey();
            }
            else if (classe == "Arqueiro")
            {
                construirArqueiro();
                Console.ReadKey();
            }
            else if (classe == "Mago")
            {
                construirMago();
                Console.ReadKey();
            }
            else if (classe == "Monge")
            {
                construirMonge();
                Console.ReadKey();
            }
            else if (classe == "Bardo")
            {
                construirBardo();
                Console.ReadKey();
            }
            else
            {
                construirLadino();
                Console.ReadKey();
            }
        }

        public void construirGuerreiro()
        {
            experiencia = 0;
            nivel = 1;
            pontosdevida = 200;
            pontosdeenergia = 50;
            ataque = 10;
            resistencia = 10;
            vidapornivel = 25;
            energiapornivel = 5;

            Console.WriteLine("Nível:" + nivel);
            Console.WriteLine("Experiência: " + experiencia);
            Console.WriteLine("Pontos de Vida: " + pontosdevida);
            Console.WriteLine("Pontos de Energia: " + pontosdeenergia);
            Console.WriteLine("Ataque: " + ataque);
            Console.WriteLine("Resistência: " + resistencia);
            Console.WriteLine("Vida recebida por Nível: " + vidapornivel);
            Console.WriteLine("Energia recebida por Nível: " + energiapornivel);
        }

        public void construirArqueiro()
        {
            experiencia = 0;
            nivel = 1;
            pontosdevida = 125;
            pontosdeenergia = 125;
            ataque = 14;
            resistencia = 6;
            vidapornivel = 15;
            energiapornivel = 15;

            Console.WriteLine("Nível:" + nivel);
            Console.WriteLine("Experiência: " + experiencia);
            Console.WriteLine("Pontos de Vida: " + pontosdevida);
            Console.WriteLine("Pontos de Energia: " + pontosdeenergia);
            Console.WriteLine("Ataque: " + ataque);
            Console.WriteLine("Resistência: " + resistencia);
            Console.WriteLine("Vida recebida por Nível: " + vidapornivel);
            Console.WriteLine("Energia recebida por Nível: " + energiapornivel);
        }

        public void construirMago()
        {
            experiencia = 0;
            nivel = 1;
            pontosdevida = 75;
            pontosdeenergia = 175;
            ataque = 16;
            resistencia = 4;
            vidapornivel = 5;
            energiapornivel = 25;

            Console.WriteLine("Nível:" + nivel);
            Console.WriteLine("Experiência: " + experiencia);
            Console.WriteLine("Pontos de Vida: " + pontosdevida);
            Console.WriteLine("Pontos de Energia: " + pontosdeenergia);
            Console.WriteLine("Ataque: " + ataque);
            Console.WriteLine("Resistência: " + resistencia);
            Console.WriteLine("Vida recebida por Nível: " + vidapornivel);
            Console.WriteLine("Energia recebida por Nível: " + energiapornivel);
        }

        public void construirMonge()
        {
            experiencia = 0;
            nivel = 1;
            pontosdevida = 150;
            pontosdeenergia = 100;
            ataque = 8;
            resistencia = 12;
            vidapornivel = 20;
            energiapornivel = 10;

            Console.WriteLine("Nível:" + nivel);
            Console.WriteLine("Experiência: " + experiencia);
            Console.WriteLine("Pontos de Vida: " + pontosdevida);
            Console.WriteLine("Pontos de Energia: " + pontosdeenergia);
            Console.WriteLine("Ataque: " + ataque);
            Console.WriteLine("Resistência: " + resistencia);
            Console.WriteLine("Vida recebida por Nível: " + vidapornivel);
            Console.WriteLine("Energia recebida por Nível: " + energiapornivel);
        }

        public void construirBardo()
        {
            experiencia = 0;
            nivel = 1;
            pontosdevida = 100;
            pontosdeenergia = 150;
            ataque = 7;
            resistencia = 13;
            vidapornivel = 20;
            energiapornivel = 10;

            Console.WriteLine("Nível:" + nivel);
            Console.WriteLine("Experiência: " + experiencia);
            Console.WriteLine("Pontos de Vida: " + pontosdevida);
            Console.WriteLine("Pontos de Energia: " + pontosdeenergia);
            Console.WriteLine("Ataque: " + ataque);
            Console.WriteLine("Resistência: " + resistencia);
            Console.WriteLine("Vida recebida por Nível: " + vidapornivel);
            Console.WriteLine("Energia recebida por Nível: " + energiapornivel);
        }

        public void construirLadino()
        {
            experiencia = 0;
            nivel = 1;
            pontosdevida = 125;
            pontosdeenergia = 125;
            ataque = 6;
            resistencia = 14;
            vidapornivel = 20;
            energiapornivel = 10;

            Console.WriteLine("Nível:" + nivel);
            Console.WriteLine("Experiência: " + experiencia);
            Console.WriteLine("Pontos de Vida: " + pontosdevida);
            Console.WriteLine("Pontos de Energia: " + pontosdeenergia);
            Console.WriteLine("Ataque: " + ataque);
            Console.WriteLine("Resistência: " + resistencia);
            Console.WriteLine("Vida recebida por Nível: " + vidapornivel);
            Console.WriteLine("Energia recebida por Nível: " + energiapornivel);
        }
    }
}

