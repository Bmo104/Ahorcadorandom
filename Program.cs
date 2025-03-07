using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Ahorcado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            string[] palabras = { "fuera", "cosas", "verde", "luffy", "video", "mouse", "falso", "libro", "tecla", "linea", "crema", "traer", "posee", "lider", "ayuda", "zonas", "capas", "tener", "sobre", "cuero", "aguas", "niños", "niñas"};
            int index = rnd.Next(palabras.Length);
            char[] palabra = { '_', '_' , '_', '_', '_' };
            char[] palabradef = palabras[index].ToCharArray();
            char letra;
            int fallos = 0;
            bool acertado;
            bool fin = false;

            while (fin == false)
            {
                acertado = false;
                if (string.Join("", palabra) == string.Join("", palabradef))
                {
                    Console.WriteLine("                 #@");
                    Console.WriteLine("                @=@@%=@");
                    Console.WriteLine("          +@@**+@:@:@@#@@@");
                    Console.WriteLine("       #@#=-:--------@@::==@@");
                    Console.WriteLine("     %@=--==========--:--=--==@");
                    Console.WriteLine("    @=--=====================-=@*");
                    Console.WriteLine("   @--========================--=*");
                    Console.WriteLine("  @--==-----============-----==--@");
                    Console.WriteLine("  @:---=@@@-::-======---=@@@-::--=@");
                    Console.WriteLine("  @::=@:   @@@:-====--:@:   @@@:--@");
                    Console.WriteLine("  @:-@@    @@@@:====--@@    :@@@:=@");
                    Console.WriteLine("  @:@@@@@@@@@@@:====--@@@@@@@@@@:=*");
                    Console.WriteLine("  @::@@@@@@@@@-:-----:@@@@@@@@@@:@");
                    Console.WriteLine("  @--:@@@@@@@::::*#=:::-@@@@@@::-=@");
                    Console.WriteLine(" @--=-:::::::@##@###%#@:::::::--=-=%");
                    Console.WriteLine(" @:======-@###........+###=======-=@");
                    Console.WriteLine(" @--=====-:::@@@@@@@@@@:::-=====--#*");
                    Console.WriteLine("  @+=---===--::-@##@@::--====---=@#");
                    Console.WriteLine("    #@@-::::::::::::::::::::-=@@");
                    Console.WriteLine("       @%##@#%@@@@@@@@@#@##%@");
                    Console.WriteLine("     @@+::.@@           @..:=#@");
                    Console.WriteLine("    @#-===.@  @@@@@@@@@ ##-==:=@");
                    Console.WriteLine("    @.==+=.@        @    @-=+=:#@");
                    Console.WriteLine("    @=:=+=.@ ..... @@ . :@:=+-=@");
                    Console.WriteLine("     @#+:=.@ ..... %  . @#:--*@@");
                    Console.WriteLine("       @@%#@  ........  @##%@@ ");
                    Console.WriteLine("            @          @@:=");
                    Console.WriteLine("             @#@@@@@@#@");
                    Console.WriteLine("            @@.@    @.@@");
                    Console.WriteLine("       @@#%##=+@    @++##@#@@");
                    Console.WriteLine("         .@  @@      @@  @");
                    Console.WriteLine("              Ganaste!");
                    Console.WriteLine();
                    Console.WriteLine("Su palabra era:");
                    Console.Write("    ");
                    foreach (char x in palabra)
                    {
                        Console.Write("  " + x);
                    }
                    fin = true;
                    break;
                }
                Console.WriteLine("Ingrese su letra");
                letra = char.Parse(Console.ReadLine());
                for (int j = 0; j < 5; j++)
                {
                    if (letra == palabradef[j])
                    {
                        palabra[j] = letra;
                        acertado = true;
                    }
                }
                if (acertado == false)
                {
                    fallos++;
                }
                switch (fallos)
                {
                    case 0:
                        Console.WriteLine(" ************");
                        Console.WriteLine(" *          *");
                        Console.WriteLine(" *          *");
                        Console.WriteLine(" *          *");
                        Console.WriteLine(" *          0");
                        Console.WriteLine(" *         /|\\ ");
                        Console.WriteLine(" *         / \\");
                        Console.WriteLine();
                        Console.Write("    ");
                        foreach (char x in palabra)
                        {
                            Console.Write("  " + x);
                        }
                        Console.WriteLine();
                        break;
                    case 1:
                        Console.WriteLine("*************");
                        Console.WriteLine(" *          *");
                        Console.WriteLine(" *          *");
                        Console.WriteLine(" *          *");
                        Console.WriteLine(" *          0");
                        Console.WriteLine(" *         /|\\ ");
                        Console.WriteLine(" *         /");
                        Console.WriteLine();
                        Console.Write("    ");
                        foreach (char x in palabra) 
                        {
                            Console.Write("  " + x);
                        }
                        Console.WriteLine();
                        break;
                    case 2:
                        Console.WriteLine(" ************");
                        Console.WriteLine(" *          *");
                        Console.WriteLine(" *          *");
                        Console.WriteLine(" *          *");
                        Console.WriteLine(" *          0");
                        Console.WriteLine(" *         /|\\ ");
                        Console.WriteLine(" *");
                        Console.WriteLine();
                        Console.Write("    ");
                        foreach (char x in palabra)
                        {
                            Console.Write("  " + x);
                        }
                        Console.WriteLine();
                        break;
                    case 3:
                        Console.WriteLine(" ************");
                        Console.WriteLine(" *          *");
                        Console.WriteLine(" *          *");
                        Console.WriteLine(" *          *");
                        Console.WriteLine(" *          0");
                        Console.WriteLine(" *         /|");
                        Console.WriteLine(" *");
                        Console.WriteLine();
                        Console.Write("    ");
                        foreach (char x in palabra)
                        {
                            Console.Write("  " + x);
                        }
                        Console.WriteLine();
                        break;
                    case 4:
                        Console.WriteLine(" ************");
                        Console.WriteLine(" *          *");
                        Console.WriteLine(" *          *");
                        Console.WriteLine(" *          *");
                        Console.WriteLine(" *          0");
                        Console.WriteLine(" *          |");
                        Console.WriteLine(" *");
                        Console.WriteLine();
                        Console.Write("    ");
                        foreach (char x in palabra)
                        {
                            Console.Write("  " + x);
                        }
                        Console.WriteLine();
                        break;
                    case 5:
                        Console.WriteLine(" ************");
                        Console.WriteLine(" *          *");
                        Console.WriteLine(" *          *");
                        Console.WriteLine(" *          *");
                        Console.WriteLine(" *          0");
                        Console.WriteLine(" *");
                        Console.WriteLine(" *");
                        Console.WriteLine();
                        Console.Write("    ");
                        foreach (char x in palabra)
                        {
                            Console.Write("  " + x);
                        }
                        Console.WriteLine();
                        break;
                    case 6:
                        Console.WriteLine("             .@@@@     |");
                        Console.WriteLine("           @@      @   |");
                        Console.WriteLine("          @         @  |");
                        Console.WriteLine("          @  X       = |");
                        Console.WriteLine("      @@   @        @ /  ");
                        Console.WriteLine("        @@@@:    __@_/       @@@");
                        Console.WriteLine("            @___/   @@@@@@@    @");
                        Console.WriteLine("           @      @@@@%    .    @");
                        Console.WriteLine("           @    @          .@  @@");
                        Console.WriteLine("           @    @          @   @");
                        Console.WriteLine("           @    @@     @@@    @-");
                        Console.WriteLine("            @      @@@@      @");
                        Console.WriteLine("             @@@:        .@@=");
                        Console.WriteLine("                +@@@@@@@@-");
                        Console.WriteLine("                 Ahorcado!");
                        Console.WriteLine();
                        Console.WriteLine("Su palabra era:");
                        Console.Write("    ");
                        foreach (char x in palabradef)
                        {
                            Console.Write("  " + x);
                        }
                        fin = true;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}