using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace practicheska_3

{
    internal class Programm
    {
        static int[] F1Octava = { 35, 39, 44, 49, 54, 59, 61, 66, 71, 76, 81, 86 };
        static int[] F2Octava = { 70, 75, 78, 83, 88, 93, 98, 103, 108, 113, 118, 123 };
        static int[] F3Octava = { 135, 140, 145, 150, 155, 170, 185, 196, 207, 220, 233, 246 };
        static int[] F4Octava = { 261, 277, 293, 311, 329, 349, 370, 392, 415, 440, 466, 493 };
        static int[] F5Octava = { 523, 554, 587, 622, 659, 698, 740, 784, 830, 880, 932, 987 };

        static void Main(string[] args)
        {
            Console.WriteLine("Выбирите октаву: F1 F2 F3 F4 F5 \n" +
                "Клавиши для воспроизведения звука: D R F T G Y H U J I K O ");
            while (true)
            {
                int[] allkeys = octava();
                if (allkeys == F1Octava)
                {
                    Console.WriteLine("первая октава");
                    beeep(allkeys);
                }
                else if (allkeys == F2Octava)
                {
                    Console.WriteLine("вторая октава ");
                    beeep(allkeys);
                }
                else if (allkeys == F3Octava)
                {
                    Console.WriteLine("третья октава ");
                    beeep(allkeys);
                }
                else if ( allkeys == F4Octava)
                {
                    Console.WriteLine("четвертая октава ");
                    beeep( allkeys);
                }
                else if ( allkeys == F5Octava)
                {
                    Console.WriteLine("пятая октава ");
                    beeep( allkeys);
                }
            }


        static int[] beeep(int[] allkeys)
        {
            int[] keysofkeyboard = new int[13];
            while (true)
            {
                ConsoleKey zvuk = Console.ReadKey().Key;
                switch (zvuk)
                {
                    case ConsoleKey.D:
                        Console.Beep(allkeys[0], 400);
                        Console.Clear();
                        continue;
                        break;
                    case ConsoleKey.R:
                        Console.Beep(allkeys[1] + 1050, 400);
                        Console.Clear();
                        continue;
                        break;
                    case ConsoleKey.F:
                        Console.Beep( allkeys[2] + 1050, 400);
                        Console.Clear();
                        continue;
                        break;
                    case ConsoleKey.T:
                        Console.Beep(allkeys[3] + 1050, 400);
                        Console.Clear();
                        continue;
                        break;
                    case ConsoleKey.G:
                        Console.Beep(allkeys[4] + 1050, 400);
                        Console.Clear();
                        continue;
                        break;
                    case ConsoleKey.Y:
                        Console.Beep( allkeys[5] + 1050, 400);
                        Console.Clear();
                        continue;
                        break;
                    case ConsoleKey.H:
                        Console.Beep( allkeys[6] + 1050, 400);
                        Console.Clear();
                        continue;
                        break;
                    case ConsoleKey.U:
                        Console.Beep( allkeys[7] + 1050, 400);
                        Console.Clear();
                        continue;
                        break;
                    case ConsoleKey.J:
                        Console.Beep( allkeys[8] + 1050, 400);
                        Console.Clear();
                        continue;
                        break;
                    case ConsoleKey.I:
                        Console.Beep( allkeys[9], 400);
                        Console.Clear();
                        continue;
                        break;
                    case ConsoleKey.K:
                        Console.Beep( allkeys[10], 400);
                        Console.Clear();
                        continue;
                        break;
                    case ConsoleKey.O:
                        Console.Beep( allkeys[11], 400);
                        Console.Clear();
                        continue;
                        break;
                    case ConsoleKey.F1:
                         allkeys = F1Octava;
                        return  allkeys;
                        break;
                    case ConsoleKey.F2:
                         allkeys = F2Octava;
                        return  allkeys;
                        break;
                    case ConsoleKey.F3:
                         allkeys = F3Octava;
                        return  allkeys;
                        break;
                    case ConsoleKey.F4:
                         allkeys = F4Octava;
                        return  allkeys;
                        break;
                    case ConsoleKey.F5:
                         allkeys = F5Octava;
                        return  allkeys;
                        break;
                    default:
                        Console.Clear();
                        continue;
                        break;


                }
            }
        }
            static int[] octava()
            {
                int[] keysofkeyboard = new int[13];
                {
                    ConsoleKeyInfo Key = Console.ReadKey();
                    Console.WriteLine(Key.Key);
                    if (Key.Key == ConsoleKey.F1)
                    {
                        Console.WriteLine("первая октава");
                        keysofkeyboard = F1Octava;
                        return keysofkeyboard;
                    }
                    else if (Key.Key == ConsoleKey.F2)
                    {
                        Console.WriteLine("вторая октава");
                        keysofkeyboard = F2Octava;
                        return keysofkeyboard;
                    }
                    else if (Key.Key == ConsoleKey.F3)
                    {
                        Console.WriteLine("третья  октава");
                        keysofkeyboard = F3Octava;
                        return keysofkeyboard;
                    }
                    else if (Key.Key == ConsoleKey.F4)
                    {
                        Console.WriteLine("четвертая  октава");
                        keysofkeyboard = F4Octava;
                        return keysofkeyboard;
                    }
                    else if (Key.Key == ConsoleKey.F5)
                    {
                        Console.WriteLine("пятая  октава");
                        keysofkeyboard = F5Octava;
                        return keysofkeyboard;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Выбирите октаву: F1 F2 F3 F4 F5 \n" +
            "Клавиши для воспроизведения звука: D R F T G Y H U J I K O ");
                        return keysofkeyboard;
                    }
                }
            }

        }
    }

}