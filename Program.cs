using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* hola mudno*/
namespace ejemplo1
{
    public class dibujos
    {

        public static void nada()
        {
            Console.WriteLine("|-------------|");
            Console.WriteLine("|             |");
            Console.WriteLine("|");
            Console.WriteLine("|");
            Console.WriteLine("|");
            Console.WriteLine("|");
            Console.WriteLine("|-----------|   ");
            Console.WriteLine("|           |   ");

        }
        public static void Cabeza()
        {
            Console.WriteLine("|-------------|");
            Console.WriteLine("|             |");
            Console.WriteLine("|             O");
            Console.WriteLine("|              ");
            Console.WriteLine("|");
            Console.WriteLine("|");
            Console.WriteLine("|------------|   ");
            Console.WriteLine("|            |   ");

        }
        public static void brazo1()
        {
            Console.WriteLine("|-------------|");
            Console.WriteLine("|             |");
            Console.WriteLine("|             O");
            Console.WriteLine("|            / ");
            Console.WriteLine("|");
            Console.WriteLine("|");
            Console.WriteLine("|-------------|   ");
            Console.WriteLine("|             |   ");

        }
        public static void brazo2()
        {
            Console.WriteLine("|-------------|");
            Console.WriteLine("|             |");
            Console.WriteLine("|             O");
            Console.WriteLine("|            / ) ");
            Console.WriteLine("|");
            Console.WriteLine("|");
            Console.WriteLine("|-------------| ");
            Console.WriteLine("|             | ");

        }
        public static void tronco()
        {
            Console.WriteLine("|-------------|");
            Console.WriteLine("|             |");
            Console.WriteLine("|             O");
            Console.WriteLine("|            /|) ");
            Console.WriteLine("|             | ");
            Console.WriteLine("|");
            Console.WriteLine("|-------------|   ");
            Console.WriteLine("|         --  |   ");

        }
        public static void pierna1()
        {
            Console.WriteLine("|-------------|");
            Console.WriteLine("|             |");
            Console.WriteLine("|             O");
            Console.WriteLine("|            /|) ");
            Console.WriteLine("|             | ");
            Console.WriteLine("|            /  ");
            Console.WriteLine("|-------------|   ");
            Console.WriteLine("|             |   ");


        }
        public static void pierna2()
        {
            Console.WriteLine("|-------------|");
            Console.WriteLine("|             |");
            Console.WriteLine("|             O");
            Console.WriteLine("|            /|) ");
            Console.WriteLine("|             | ");
            Console.WriteLine("|            / ) ");
            Console.WriteLine("|-------------|   ");
            Console.WriteLine("|             |   ");
            Console.WriteLine("USTED SE MURIO :V");
        }
    }
   
    public class Ahorcado
    {
        public string PalabraClave { get; set; }
        public int contador { get; set; }
        public int contadorLOSER { get; set; }
        public int pts { get; set; }
        public int EspaciosVacios { get; set; }
        public Ahorcado()
        {
         string PalabraClave ;
         int contador, contadorLOSER , pts;
         int EspaciosVacios ;

        }
        public Ahorcado(string Palabra, int contador1, int contador_perdedor, int puntos_ganados, int contador_espacios_vacios )

        {
            this.PalabraClave = Palabra;
            this.contador = contador1;
            this.contadorLOSER = contador_perdedor;
            this.pts = puntos_ganados;
            this.EspaciosVacios = contador_espacios_vacios;
        }
            
    }
    class Inicio_juego : Ahorcado
    {
        delegate void ObjetoDelegado();
        public void Inicio()
        {
            ObjetoDelegado Mostrar = new ObjetoDelegado(dibujos.nada);
            StringBuilder nuevo = new StringBuilder();
            StringBuilder PalabraRepetida = new StringBuilder();
            PalabraClave  = Console.ReadLine();
            Mostrar();
            nuevo.Append(PalabraClave);
            for (int i = 0; i < PalabraClave.Length; i++)
            {

                if (nuevo[i] != ' ')
                {
                    Console.Write("_" + " ");
                }
                else
                {
                    Console.Write(" ");
                    EspaciosVacios++;
                }
            }
            contador = PalabraClave.Length - EspaciosVacios;
            Console.WriteLine();
            string letra;
            do
            {
               letra = Console.ReadLine();
               for (int x = 0; x < PalabraRepetida.Length; x++)
               {
                   if (PalabraRepetida[x].ToString() == letra )
                   {
                       Console.WriteLine("letra ya ingresada");
                        letra = Console.ReadLine();
                       
                   }
               }
               PalabraRepetida.AppendLine(letra.ToString());
               if (PalabraClave.Contains(letra))
               {
                   Console.Clear();
                   Console.WriteLine("letra correcta");
                   pts += 20;
                   contador--;
                   string gas = letra.ToString();
                   for (int i = 0; i < PalabraClave.Length; i++)
                   {
                      if (nuevo[i] == ' ' || nuevo[i].ToString() != letra)
                      {
                          Console.Write("_" + " ");
                      }
                      else
                      {
                         Console.WriteLine(letra + " ");
                      }
                   }
               }
               else
               {
                    Console.WriteLine("letra incorrecta");
                    contadorLOSER++;
                    if (pts > 0)
                    {
                        pts -= 5;
                    }
                    Console.Clear();
               }
               if (contadorLOSER == 1)
               {
                   Console.ForegroundColor = ConsoleColor.DarkRed;
                   Mostrar = new ObjetoDelegado(dibujos.Cabeza);
                   Mostrar();
                   Console.WriteLine("puntos {0}:", pts);
               }
               if (contadorLOSER == 2)
               {
                   Console.ForegroundColor = ConsoleColor.DarkGreen;
                   Mostrar = new ObjetoDelegado(dibujos.brazo1);
                   Mostrar();
                   Console.WriteLine("puntos {0}:", pts);
               }
               if (contadorLOSER == 3)
               {
                   Console.ForegroundColor = ConsoleColor.Green;
                   Mostrar = new ObjetoDelegado(dibujos.brazo2);
                   Mostrar();
                   Console.WriteLine("puntos {0}:", pts);
               }
               if (contadorLOSER == 4)
               {
                   Console.ForegroundColor = ConsoleColor.Yellow;
                   Mostrar = new ObjetoDelegado(dibujos.tronco);
                   Mostrar();
                   Console.WriteLine("puntos {0}:", pts);
               }
               if (contadorLOSER == 5)
               {
                   Console.ForegroundColor = ConsoleColor.Blue;
                   Mostrar = new ObjetoDelegado(dibujos.pierna1);
                   Mostrar();
                   Console.WriteLine("puntos {0}:", pts);
               }
               if (contadorLOSER == 6)
               {
                  Console.ForegroundColor = ConsoleColor.Red;
                  Mostrar = new ObjetoDelegado(dibujos.pierna2);
                  Mostrar();
                  Console.WriteLine("puntos {0}:", pts);
               }
            } while (contadorLOSER != 7 && contador != 0) ;
        }
    }
    class Program
    {
       
        static void Main(string[] args)
        {
           Ahorcado x = new Ahorcado();
           Inicio_juego p = new Inicio_juego();
           p.Inicio();
           Console.ReadKey();
        }
    }
}

