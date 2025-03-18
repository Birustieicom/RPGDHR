using System;
using System.Collections.Generic;
using System.Text;

namespace RPGturnos
{
    public class Itens
    {
        string[,] equipamentos = new string[21, 6];

        public void cadastrarItem()
        {
            equipamentos[0, 0] = "ITEM";
            equipamentos[0, 1] = "TIPO";
            equipamentos[0, 2] = "VALOR";
            equipamentos[0, 3] = "DANO";
            equipamentos[0, 4] = "DEFESA";
            equipamentos[0, 5] = "SLOTS";

            equipamentos[1, 0] = "Adaga";
            equipamentos[1, 1] = "Arma";
            equipamentos[1, 2] = "10";
            equipamentos[1, 3] = "2";
            equipamentos[1, 4] = "0";
            equipamentos[1, 5] = "1";

            equipamentos[2, 0] = "Espada";
            equipamentos[3, 0] = "Arco";
            equipamentos[4, 0] = "Lança";
            equipamentos[5, 0] = "Porrete";
            equipamentos[6, 0] = "Martelo";
            equipamentos[7, 0] = "Clava";
            equipamentos[8, 0] = "Foice";
            equipamentos[9, 0] = "Chicote";
            equipamentos[10, 0] = "Dardo";
            equipamentos[11, 0] = "Mangual";
            equipamentos[12, 0] = "Besta";
            equipamentos[13, 0] = "Tridente";
            equipamentos[14, 0] = "Zarabatana";
            equipamentos[15, 0] = "Picareta";
            equipamentos[16, 0] = "Machadinha";
            equipamentos[17, 0] = "Machado";
            equipamentos[18, 0] = "Cajado";
            equipamentos[19, 0] = "Glaive";
            equipamentos[20, 0] = "Alabarda";
            equipamentos[21, 0] = "Desarmado";

            listarItens();
        }

        public void listarItens()
        {
            Console.Clear();
            Console.WriteLine(equipamentos);
        }
    }
}
