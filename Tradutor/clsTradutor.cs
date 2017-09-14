using System;
using System.Collections.Generic;

//clsTradutor.cs

namespace clsTradutor
{
    public static class Tradutor
    {
        public class Palavras
        {
            public string Ingles { get; set; }
            public string Portugues { get; set; }
        }
        public static IList<Palavras> Lista_de_Palavras()
        {
            IList<Palavras> w_Lista = new List<Palavras>();
            Palavras w_Palavras = new Palavras();
            Random randNum = new Random();
            int w_intValor = randNum.Next(0,25);
            switch (w_intValor)
                {
                case 0:
                    w_Palavras.Ingles = "red";
                    w_Palavras.Portugues = "vermelho";
                    w_Lista.Add(w_Palavras);
                    break;
                case 1:
                    w_Palavras.Ingles = "blue";
                    w_Palavras.Portugues = "azul";
                    w_Lista.Add(w_Palavras);
                    break;
                case 2:
                    w_Palavras.Ingles = "white";
                    w_Palavras.Portugues = "branco";
                    w_Lista.Add(w_Palavras);
                    break;
                case 3:
                    w_Palavras.Ingles = "pink";
                    w_Palavras.Portugues = "rosa";
                    w_Lista.Add(w_Palavras);
                    break;
                case 4:
                    w_Palavras.Ingles = "basket";
                    w_Palavras.Portugues = "basquete";
                    w_Lista.Add(w_Palavras);
                    break;
                case 5:
                    w_Palavras.Ingles = "club";
                    w_Palavras.Portugues = "clube";
                    w_Lista.Add(w_Palavras);
                    break;
                case 6:
                    w_Palavras.Ingles = "hot";
                    w_Palavras.Portugues = "quente";
                    w_Lista.Add(w_Palavras);
                    break;
                case 7:
                    w_Palavras.Ingles = "when";
                    w_Palavras.Portugues = "quando";
                    w_Lista.Add(w_Palavras);
                    break;
                case 8:
                    w_Palavras.Ingles = "write";
                    w_Palavras.Portugues = "escrever";
                    w_Lista.Add(w_Palavras);
                    break;
                case 9:
                    w_Palavras.Ingles = "people";
                    w_Palavras.Portugues = "pessoas";
                    w_Lista.Add(w_Palavras);
                    break;
                case 10:
                    w_Palavras.Ingles = "bread";
                    w_Palavras.Portugues = "pão";
                    w_Lista.Add(w_Palavras);
                    break;
                case 11:
                    w_Palavras.Ingles = "better ";
                    w_Palavras.Portugues = "melhor";
                    w_Lista.Add(w_Palavras);
                    break;
                case 12:
                    w_Palavras.Ingles = "ever";
                    w_Palavras.Portugues = "sempre";
                    w_Lista.Add(w_Palavras);
                    break;
                case 13:
                    w_Palavras.Ingles = "eyes";
                    w_Palavras.Portugues = "olhos";
                    w_Lista.Add(w_Palavras);
                    break;
                case 14:
                    w_Palavras.Ingles = "hand";
                    w_Palavras.Portugues = "mão";
                    w_Lista.Add(w_Palavras);
                    break;
                case 15:
                    w_Palavras.Ingles = "hands";
                    w_Palavras.Portugues = "mãos";
                    w_Lista.Add(w_Palavras);
                    break;
                case 16:
                    w_Palavras.Ingles = "however";
                    w_Palavras.Portugues = "entretanto";
                    w_Lista.Add(w_Palavras);
                    break;
                case 17:
                    w_Palavras.Ingles = "less";
                    w_Palavras.Portugues = "menos";
                    w_Lista.Add(w_Palavras);
                    break;
                case 18:
                    w_Palavras.Ingles = "make";
                    w_Palavras.Portugues = "fazer";
                    w_Lista.Add(w_Palavras);
                    break;
                case 19:
                    w_Palavras.Ingles = "war";
                    w_Palavras.Portugues = "guerra";
                    w_Lista.Add(w_Palavras);
                    break;
                case 20:
                    w_Palavras.Ingles = "always";
                    w_Palavras.Portugues = "sempre";
                    w_Lista.Add(w_Palavras);
                    break;
                case 21:
                    w_Palavras.Ingles = "before";
                    w_Palavras.Portugues = "antes";
                    w_Lista.Add(w_Palavras);
                    break;
                case 22:
                    w_Palavras.Ingles = "between";
                    w_Palavras.Portugues = "entre";
                    w_Lista.Add(w_Palavras);
                    break;
                case 23:
                    w_Palavras.Ingles = "body";
                    w_Palavras.Portugues = "corpo";
                    w_Lista.Add(w_Palavras);
                    break;
                case 24:
                    w_Palavras.Ingles = "case";
                    w_Palavras.Portugues = "caso";
                    w_Lista.Add(w_Palavras);
                    break;
                case 25:
                    w_Palavras.Ingles = "city";
                    w_Palavras.Portugues = "cidade";
                    w_Lista.Add(w_Palavras);
                    break;
            }
            return w_Lista;
        }
    }
}
