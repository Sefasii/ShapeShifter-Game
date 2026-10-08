using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            string gamemode = "game";
            string aa, ab, ac, ba, bb, bc, ca, cb, cc;
            aa = " "; ab = " "; ac = " ";
            ba = " "; bb = " "; bc = " ";
            ca = " "; cb = " "; cc = " ";
            string a1, a2, a3, a4, a5, a6, a7, a8, a9;
            a1 = " "; a2 = " "; a3 = " ";
            a4 = " "; a5 = " "; a6 = " ";
            a7 = " "; a8 = " "; a9 = " ";
            Console.WriteLine("ShapeShift Menu");
            Console.WriteLine("-------------");
            Console.Write("Choose the Player (1:Human / 2:Computer): ");
            string player = Console.ReadLine();
            string playerName = "";
            bool validPlayer = false;
            while (validPlayer == false)
            {
                if (player == "1")
                {
                    playerName = "Human";
                    validPlayer = true;
                }
                else if (player == "2")
                {
                    playerName = "Computer";
                    validPlayer = true;
                }
                else
                {
                    Console.Write("Invalid choice. Choose again. (Enter 1-2): ");
                    player = Console.ReadLine();
                }
            }
            Console.WriteLine("Chosen player: " + playerName);
            Console.WriteLine("-------------");
            Console.Write("Choose the Symbols (1:A / 2:A,B / 3:A,B,C / 4:A,B,C,D / 5:A,B,C,D,E): ");
            string Notos = Console.ReadLine();
            bool validNOTOS = false;
            string notos = "";
            while (validNOTOS == false)
            {
                if (Notos == "1")
                {
                    notos = "A";
                    validNOTOS = true;
                }
                else if (Notos == "2")
                {
                    notos = "A,B";
                    validNOTOS = true;
                }
                else if (Notos == "3")
                {
                    notos = "A,B,C";
                    validNOTOS = true;
                }
                else if (Notos == "4")
                {
                    notos = "A,B,C,D";
                    validNOTOS = true;
                }
                else if (Notos == "5")
                {
                    notos = "A,B,C,D,E";
                    validNOTOS = true;
                }
                else
                {
                    Console.Write("Invalid choice. Choose again. (Enter 1-5): ");
                    Notos = Console.ReadLine();
                }
            }
            Console.WriteLine("Chosen NOTOS: " + Notos + " (" + notos + ")");
            int NOTOS = Convert.ToInt32(Notos);
            Console.WriteLine("-------------");
            Console.Write("Choose Number of the Symbols (1-6): ");
            int NOS = Convert.ToInt32(Console.ReadLine());
            bool validNOS = false;
            while (validNOS == false)
            {
                if (NOS >= 1 && NOS <= 6)
                {
                    validNOS = true;
                }
                else
                {
                    Console.Write("Invalid choice. Choose again. (Enter 1-6): ");
                    NOS = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Chosen NOS: " + NOS);
            Console.WriteLine("-------------");
            Console.Write("Choose Board Generation Shifts (1-20): ");
            int BoardGenerationShifts = Convert.ToInt32(Console.ReadLine());
            bool validShifts = false;
            while (validShifts == false)
            {
                if (BoardGenerationShifts >= 1 && BoardGenerationShifts <= 20)
                {
                    validShifts = true;
                }
                else
                {
                    Console.Write("Invalid choice. Choose again. (Enter 1-20): ");
                    BoardGenerationShifts = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Chosen Shifts: " + BoardGenerationShifts);
            Console.WriteLine("-------------");
            Console.WriteLine("Your game will start in 5 seconds...");
            int ControlNOS = 0;
            string symbol = " ";
            while (ControlNOS < NOS)
            {
                int place = rand.Next(1, 10);
                if (NOTOS == 1)
                {
                    symbol = "A";
                }
                else if (NOTOS == 2)
                {
                    int number = rand.Next(1, 3);
                    if (number == 1)
                        symbol = "A";
                    else
                        symbol = "B";
                }
                else if (NOTOS == 3)
                {
                    int number = rand.Next(1, 4);
                    if (number == 1)
                        symbol = "A";
                    else if (number == 2)
                        symbol = "B";
                    else
                        symbol = "C";
                }
                else if (NOTOS == 4)
                {
                    int number = rand.Next(1, 5);
                    if (number == 1)
                        symbol = "A";
                    else if (number == 2)
                        symbol = "B";
                    else if (number == 3)
                        symbol = "C";
                    else
                        symbol = "D";
                }
                else
                {
                    int number = rand.Next(1, 6);
                    if (number == 1)
                        symbol = "A";
                    else if (number == 2)
                        symbol = "B";
                    else if (number == 3)
                        symbol = "C";
                    else if (number == 4)
                        symbol = "D";
                    else
                        symbol = "E";
                }
                if (place == 1 && a1 == " ")
                {
                    aa = symbol;
                    a1 = aa;
                    ControlNOS++;
                }
                else if (place == 2 && a2 == " ")
                {
                    ab = symbol;
                    a2 = ab;
                    ControlNOS++;
                }
                else if (place == 3 && a3 == " ")
                {
                    ac = symbol;
                    a3 = ac;
                    ControlNOS++;
                }
                else if (place == 4 && a4 == " ")
                {
                    ba = symbol;
                    a4 = ba;
                    ControlNOS++;
                }
                else if (place == 5 && a5 == " ")
                {
                    bb = symbol;
                    a5 = bb;
                    ControlNOS++;
                }
                else if (place == 6 && a6 == " ")
                {
                    bc = symbol;
                    a6 = bc;
                    ControlNOS++;
                }
                else if (place == 7 && a7 == " ")
                {
                    ca = symbol;
                    a7 = ca;
                    ControlNOS++;
                }
                else if (place == 8 && a8 == " ")
                {
                    cb = symbol;
                    a8 = cb;
                    ControlNOS++;
                }
                else if (place == 9 && a9 == " ")
                {
                    cc = symbol;
                    a9 = cc;
                    ControlNOS++;
                }
            }
            int MixShifts = 0;
            int Shift;
            while (MixShifts < BoardGenerationShifts)
            {
                int randomShift = rand.Next(1, 13);
                Shift = randomShift;
                if (Shift == 1)
                {
                    if (a1 != " " || a2 != " " || a3 != " ")
                    {
                        if (a2 != " " && a3 == " ")
                        {
                            a3 = a2;
                            a2 = " ";
                        }
                        if (a1 != " " && a2 == " ")
                        {
                            a2 = a1;
                            a1 = " ";
                        }
                        if (a2 != " " && a3 == " ")
                        {
                            a3 = a2;
                            a2 = " ";
                        }
                        MixShifts++;
                    }
                }
                else if (Shift == 2)
                {
                    if (a4 != " " || a5 != " " || a6 != " ")
                    {
                        if (a5 != " " && a6 == " ")
                        {
                            a6 = a5;
                            a5 = " ";
                        }
                        if (a4 != " " && a5 == " ")
                        {
                            a5 = a4;
                            a4 = " ";
                        }
                        if (a5 != " " && a6 == " ")
                        {
                            a6 = a5;
                            a5 = " ";
                        }
                        MixShifts++;
                    }
                }
                else if (Shift == 3)
                {
                    if (a7 != " " || a8 != " " || a9 != " ")
                    {
                        if (a8 != " " && a9 == " ")
                        {
                            a9 = a8;
                            a8 = " ";
                        }
                        if (a7 != " " && a8 == " ")
                        {
                            a8 = a7;
                            a7 = " ";
                        }
                        if (a8 != " " && a9 == " ")
                        {
                            a9 = a8;
                            a8 = " ";
                        }
                        MixShifts++;
                    }
                }
                else if (Shift == 4)
                {
                    if (a1 != " " || a2 != " " || a3 != " ")
                    {
                        if (a2 != " " && a1 == " ")
                        {
                            a1 = a2;
                            a2 = " ";
                        }
                        if (a3 != " " && a2 == " ")
                        {
                            a2 = a3;
                            a3 = " ";
                        }
                        if (a2 != " " && a1 == " ")
                        {
                            a1 = a2;
                            a2 = " ";
                        }
                        MixShifts++;
                    }
                }
                else if (Shift == 5)
                {
                    if (a4 != " " || a5 != " " || a6 != " ")
                    {
                        if (a5 != " " && a4 == " ")
                        {
                            a4 = a5;
                            a5 = " ";
                        }
                        if (a6 != " " && a5 == " ")
                        {
                            a5 = a6;
                            a6 = " ";
                        }
                        if (a5 != " " && a4 == " ")
                        {
                            a4 = a5;
                            a5 = " ";
                        }
                        MixShifts++;
                    }
                }
                else if (Shift == 6)
                {
                    if (a7 != " " || a8 != " " || a9 != " ")
                    {
                        if (a8 != " " && a7 == " ")
                        {
                            a7 = a8;
                            a8 = " ";
                        }
                        if (a9 != " " && a8 == " ")
                        {
                            a8 = a9;
                            a9 = " ";
                        }
                        if (a8 != " " && a7 == " ")
                        {
                            a7 = a8;
                            a8 = " ";
                        }
                        MixShifts++;
                    }
                }
                else if (Shift == 7)
                {
                    if (a1 != " " || a4 != " " || a7 != " ")
                    {
                        if (a4 != " " && a7 == " ")
                        {
                            a7 = a4;
                            a4 = " ";
                        }
                        if (a1 != " " && a4 == " ")
                        {
                            a4 = a1;
                            a1 = " ";
                        }
                        if (a4 != " " && a7 == " ")
                        {
                            a7 = a4;
                            a4 = " ";
                        }
                        MixShifts++;
                    }
                }
                else if (Shift == 8)
                {
                    if (a2 != " " || a5 != " " || a8 != " ")
                    {
                        if (a5 != " " && a8 == " ")
                        {
                            a8 = a5;
                            a5 = " ";
                        }
                        if (a2 != " " && a5 == " ")
                        {
                            a5 = a2;
                            a2 = " ";
                        }
                        if (a5 != " " && a8 == " ")
                        {
                            a8 = a5;
                            a5 = " ";
                        }
                        MixShifts++;
                    }
                }
                else if (Shift == 9)
                {
                    if (a3 != " " || a6 != " " || a9 != " ")
                    {
                        if (a6 != " " && a9 == " ")
                        {
                            a9 = a6;
                            a6 = " ";
                        }
                        if (a3 != " " && a6 == " ")
                        {
                            a6 = a3;
                            a3 = " ";
                        }
                        if (a6 != " " && a9 == " ")
                        {
                            a9 = a6;
                            a6 = " ";
                        }
                        MixShifts++;
                    }
                }
                else if (Shift == 10)
                {
                    if (a1 != " " || a4 != " " || a7 != " ")
                    {
                        if (a4 != " " && a1 == " ")
                        {
                            a1 = a4;
                            a4 = " ";
                        }
                        if (a7 != " " && a4 == " ")
                        {
                            a4 = a7;
                            a7 = " ";
                        }
                        if (a4 != " " && a1 == " ")
                        {
                            a1 = a4;
                            a4 = " ";
                        }
                        MixShifts++;
                    }
                }
                else if (Shift == 11)
                {
                    if (a2 != " " || a5 != " " || a8 != " ")
                    {
                        if (a5 != " " && a2 == " ")
                        {
                            a2 = a5;
                            a5 = " ";
                        }
                        if (a8 != " " && a5 == " ")
                        {
                            a5 = a8;
                            a8 = " ";
                        }
                        if (a5 != " " && a2 == " ")
                        {
                            a2 = a5;
                            a5 = " ";
                        }
                        MixShifts++;
                    }
                }
                else if (Shift == 12)
                {
                    if (a3 != " " || a6 != " " || a9 != " ")
                    {
                        if (a6 != " " && a3 == " ")
                        {
                            a3 = a6;
                            a6 = " ";
                        }
                        if (a9 != " " && a6 == " ")
                        {
                            a6 = a9;
                            a9 = " ";
                        }
                        if (a6 != " " && a3 == " ")
                        {
                            a3 = a6;
                            a6 = " ";
                        }
                        MixShifts++;
                    }
                }
                else
                {
                    Shift = rand.Next(1, 13);
                }
            }
            Thread.Sleep(5000);
            Console.Clear();
            int ActualNumOfShifts = 0;
            int BoardScore = 0;
            while (gamemode == "game")
            {
                if (aa == a1)
                {
                    if (a1 == "A")
                        BoardScore = BoardScore + 1;
                    else if (a1 == "B")
                        BoardScore = BoardScore + 2;
                    else if (a1 == "C")
                        BoardScore = BoardScore + 3;
                    else if (a1 == "D")
                        BoardScore = BoardScore + 4;
                    else if (a1 == "E")
                        BoardScore = BoardScore + 5;
                }
                if (ab == a2)
                {
                    if (a2 == "A")
                        BoardScore = BoardScore + 2;
                    else if (a2 == "B")
                        BoardScore = BoardScore + 4;
                    else if (a2 == "C")
                        BoardScore = BoardScore + 6;
                    else if (a2 == "D")
                        BoardScore = BoardScore + 8;
                    else if (a2 == "E")
                        BoardScore = BoardScore + 10;
                }
                if (ac == a3)
                {
                    if (a3 == "A")
                        BoardScore = BoardScore + 1;
                    else if (a3 == "B")
                        BoardScore = BoardScore + 2;
                    else if (a3 == "C")
                        BoardScore = BoardScore + 3;
                    else if (a3 == "D")
                        BoardScore = BoardScore + 4;
                    else if (a3 == "E")
                        BoardScore = BoardScore + 5;
                }
                if (ba == a4)
                {
                    if (a4 == "A")
                        BoardScore = BoardScore + 2;
                    else if (a4 == "B")
                        BoardScore = BoardScore + 4;
                    else if (a4 == "C")
                        BoardScore = BoardScore + 6;
                    else if (a4 == "D")
                        BoardScore = BoardScore + 8;
                    else if (a4 == "E")
                        BoardScore = BoardScore + 10;
                }
                if (bb == a5)
                {
                    if (a5 == "A")
                        BoardScore = BoardScore + 4;
                    else if (a5 == "B")
                        BoardScore = BoardScore + 8;
                    else if (a5 == "C")
                        BoardScore = BoardScore + 12;
                    else if (a5 == "D")
                        BoardScore = BoardScore + 16;
                    else if (a5 == "E")
                        BoardScore = BoardScore + 20;
                }
                if (bc == a6)
                {
                    if (a6 == "A")
                        BoardScore = BoardScore + 2;
                    else if (a6 == "B")
                        BoardScore = BoardScore + 4;
                    else if (a6 == "C")
                        BoardScore = BoardScore + 6;
                    else if (a6 == "D")
                        BoardScore = BoardScore + 8;
                    else if (a6 == "E")
                        BoardScore = BoardScore + 10;
                }
                if (ca == a7)
                {
                    if (a7 == "A")
                        BoardScore = BoardScore + 1;
                    else if (a7 == "B")
                        BoardScore = BoardScore + 2;
                    else if (a7 == "C")
                        BoardScore = BoardScore + 3;
                    else if (a7 == "D")
                        BoardScore = BoardScore + 4;
                    else if (a7 == "E")
                        BoardScore = BoardScore + 5;
                }
                if (cb == a8)
                {
                    if (a8 == "A")
                        BoardScore = BoardScore + 2;
                    else if (a8 == "B")
                        BoardScore = BoardScore + 4;
                    else if (a8 == "C")
                        BoardScore = BoardScore + 6;
                    else if (a8 == "D")
                        BoardScore = BoardScore + 8;
                    else if (a8 == "E")
                        BoardScore = BoardScore + 10;
                }
                if (cc == a9)
                {
                    if (a9 == "A")
                        BoardScore = BoardScore + 1;
                    else if (a9 == "B")
                        BoardScore = BoardScore + 2;
                    else if (a9 == "C")
                        BoardScore = BoardScore + 3;
                    else if (a9 == "D")
                        BoardScore = BoardScore + 4;
                    else if (a9 == "E")
                        BoardScore = BoardScore + 5;
                }
                Console.WriteLine("Game Mode");
                Console.WriteLine("-------------");
                Console.WriteLine("Player  : " + playerName);
                Console.WriteLine("Symbols : " + notos);
                Console.WriteLine("Number of Symbols : " + NOS);
                Console.WriteLine("Number of Shifts  : " + BoardGenerationShifts);
                Console.WriteLine();
                Console.WriteLine("--- Target Board ---");
                Console.WriteLine();
                Console.WriteLine("   7  8  9   ");
                Console.WriteLine(" +---------+ ");
                Console.WriteLine("1| " + aa + "  " + ab + "  " + ac + " |4");
                Console.WriteLine(" |         | ");
                Console.WriteLine("2| " + ba + "  " + bb + "  " + bc + " |5");
                Console.WriteLine(" |         | ");
                Console.WriteLine("3| " + ca + "  " + cb + "  " + cc + " |6");
                Console.WriteLine(" +---------+ ");
                Console.WriteLine("  10 11 12   ");
                Console.WriteLine();
                Console.Write("--- Round ");
                Console.Write(ActualNumOfShifts + 1);
                Console.WriteLine(" ---");
                Console.WriteLine();
                Console.WriteLine("   7  8  9   ");
                Console.WriteLine(" +---------+    Board");
                Console.WriteLine("1| " + a1 + "  " + a2 + "  " + a3 + " |4   Score : " + BoardScore);
                Console.WriteLine(" |         | ");
                Console.WriteLine("2| " + a4 + "  " + a5 + "  " + a6 + " |5");
                Console.WriteLine(" |         | ");
                Console.WriteLine("3| " + a7 + "  " + a8 + "  " + a9 + " |6   Shift : ");
                Console.WriteLine(" +---------+ ");
                Console.WriteLine("  10 11 12   ");
                Console.SetCursorPosition(24, 26);
                if (a1 == aa && a2 == ab && a3 == ac && a4 == ba && a5 == bb && a6 == bc && a7 == ca && a8 == cb && a9 == cc)
                {
                    gamemode = "end";
                    Console.SetCursorPosition(0, 18);
                    Console.Write("--- Completed ---");
                    Console.SetCursorPosition(0, 29);
                    Console.WriteLine("-------------");
                    Console.WriteLine("Congratulations! You have finished the game.");
                    Console.WriteLine("Calculating your score wait 5 seconds...");
                    Thread.Sleep(5000);
                    int GameScore = (10 * BoardScore) + (NOTOS * NOS * (BoardGenerationShifts - ActualNumOfShifts));
                    Console.WriteLine("-------------");
                    Console.WriteLine("Game Score = " + GameScore);
                    Console.ReadLine();
                }
                else
                {
                    Shift = Convert.ToInt32(Console.ReadLine());
                    if (Shift == 1)
                    {
                        if (a1 != " " || a2 != " " || a3 != " ")
                        {
                            if (a2 != " " && a3 == " ")
                            {
                                a3 = a2;
                                a2 = " ";
                            }
                            if (a1 != " " && a2 == " ")
                            {
                                a2 = a1;
                                a1 = " ";
                            }
                            if (a2 != " " && a3 == " ")
                            {
                                a3 = a2;
                                a2 = " ";
                            }
                        }
                    }
                    else if (Shift == 2)
                    {
                        if (a4 != " " || a5 != " " || a6 != " ")
                        {
                            if (a5 != " " && a6 == " ")
                            {
                                a6 = a5;
                                a5 = " ";
                            }
                            if (a4 != " " && a5 == " ")
                            {
                                a5 = a4;
                                a4 = " ";
                            }
                            if (a5 != " " && a6 == " ")
                            {
                                a6 = a5;
                                a5 = " ";
                            }
                        }
                    }
                    else if (Shift == 3)
                    {
                        if (a7 != " " || a8 != " " || a9 != " ")
                        {
                            if (a8 != " " && a9 == " ")
                            {
                                a9 = a8;
                                a8 = " ";
                            }
                            if (a7 != " " && a8 == " ")
                            {
                                a8 = a7;
                                a7 = " ";
                            }
                            if (a8 != " " && a9 == " ")
                            {
                                a9 = a8;
                                a8 = " ";
                            }
                        }
                    }
                    else if (Shift == 4)
                    {
                        if (a1 != " " || a2 != " " || a3 != " ")
                        {
                            if (a2 != " " && a1 == " ")
                            {
                                a1 = a2;
                                a2 = " ";
                            }
                            if (a3 != " " && a2 == " ")
                            {
                                a2 = a3;
                                a3 = " ";
                            }
                            if (a2 != " " && a1 == " ")
                            {
                                a1 = a2;
                                a2 = " ";
                            }
                        }
                    }
                    else if (Shift == 5)
                    {
                        if (a4 != " " || a5 != " " || a6 != " ")
                        {
                            if (a5 != " " && a4 == " ")
                            {
                                a4 = a5;
                                a5 = " ";
                            }
                            if (a6 != " " && a5 == " ")
                            {
                                a5 = a6;
                                a6 = " ";
                            }
                            if (a5 != " " && a4 == " ")
                            {
                                a4 = a5;
                                a5 = " ";
                            }
                        }
                    }
                    else if (Shift == 6)
                    {
                        if (a7 != " " || a8 != " " || a9 != " ")
                        {
                            if (a8 != " " && a7 == " ")
                            {
                                a7 = a8;
                                a8 = " ";
                            }
                            if (a9 != " " && a8 == " ")
                            {
                                a8 = a9;
                                a9 = " ";
                            }
                            if (a8 != " " && a7 == " ")
                            {
                                a7 = a8;
                                a8 = " ";
                            }
                        }
                    }
                    else if (Shift == 7)
                    {
                        if (a1 != " " || a4 != " " || a7 != " ")
                        {
                            if (a4 != " " && a7 == " ")
                            {
                                a7 = a4;
                                a4 = " ";
                            }
                            if (a1 != " " && a4 == " ")
                            {
                                a4 = a1;
                                a1 = " ";
                            }
                            if (a4 != " " && a7 == " ")
                            {
                                a7 = a4;
                                a4 = " ";
                            }
                        }
                    }
                    else if (Shift == 8)
                    {
                        if (a2 != " " || a5 != " " || a8 != " ")
                        {
                            if (a5 != " " && a8 == " ")
                            {
                                a8 = a5;
                                a5 = " ";
                            }
                            if (a2 != " " && a5 == " ")
                            {
                                a5 = a2;
                                a2 = " ";
                            }
                            if (a5 != " " && a8 == " ")
                            {
                                a8 = a5;
                                a5 = " ";
                            }
                        }
                    }
                    else if (Shift == 9)
                    {
                        if (a3 != " " || a6 != " " || a9 != " ")
                        {
                            if (a6 != " " && a9 == " ")
                            {
                                a9 = a6;
                                a6 = " ";
                            }
                            if (a3 != " " && a6 == " ")
                            {
                                a6 = a3;
                                a3 = " ";
                            }
                            if (a6 != " " && a9 == " ")
                            {
                                a9 = a6;
                                a6 = " ";
                            }
                        }
                    }
                    else if (Shift == 10)
                    {
                        if (a1 != " " || a4 != " " || a7 != " ")
                        {
                            if (a4 != " " && a1 == " ")
                            {
                                a1 = a4;
                                a4 = " ";
                            }
                            if (a7 != " " && a4 == " ")
                            {
                                a4 = a7;
                                a7 = " ";
                            }
                            if (a4 != " " && a1 == " ")
                            {
                                a1 = a4;
                                a4 = " ";
                            }
                        }
                    }
                    else if (Shift == 11)
                    {
                        if (a2 != " " || a5 != " " || a8 != " ")
                        {
                            if (a5 != " " && a2 == " ")
                            {
                                a2 = a5;
                                a5 = " ";
                            }
                            if (a8 != " " && a5 == " ")
                            {
                                a5 = a8;
                                a8 = " ";
                            }
                            if (a5 != " " && a2 == " ")
                            {
                                a2 = a5;
                                a5 = " ";
                            }
                        }
                    }
                    else if (Shift == 12)
                    {
                        if (a3 != " " || a6 != " " || a9 != " ")
                        {
                            if (a6 != " " && a3 == " ")
                            {
                                a3 = a6;
                                a6 = " ";
                            }
                            if (a9 != " " && a6 == " ")
                            {
                                a6 = a9;
                                a9 = " ";
                            }
                            if (a6 != " " && a3 == " ")
                            {
                                a3 = a6;
                                a6 = " ";
                            }
                        }
                    }
                    Console.Clear();
                    BoardScore = 0;
                    ActualNumOfShifts++;
                }
            }
        }
    }
}
