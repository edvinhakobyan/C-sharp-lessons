﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

class Program
{

    static int curent_x = 0;
    static int curent_y = 0;
    static LinkedList<int> curent_width = new LinkedList<int>();
    //static Random rand = new Random();

    public static int Curent_x
    {
        get { return curent_x; }
        set
        {
            if (value > Console.BufferWidth - 10)
            {
                curent_x = 0;
                curent_y += 8;
            }
            else
            {
                curent_x = value;
            }
            Console.SetCursorPosition(value, curent_y);
        }
    }
    public static int Curent_y
    {
        get { return curent_y; }
        set
        {
            curent_y = value;
            Console.SetCursorPosition(curent_x, value);
        }
    }

    public static int Curent_width
    {
        get
        {
            return curent_width.Last();;
        }
        set
        {
            curent_width.AddLast(value);
        }
    }

    static void Main(string[] args)
    {
        Console.WindowWidth = 150;
        Console.BufferWidth = 150;

        Console.BufferHeight = Int16.MaxValue - 1;

        while (true)
            WriteChar(WriteCharAndDelete());
    }


    static char WriteCharAndDelete()
    {
        //char ch = (char)rand.Next(65, 91);
        int x = Console.CursorLeft;
        int y = Console.CursorTop;
        char ch = Console.ReadKey().KeyChar;
        Console.SetCursorPosition(x, y);
        Console.Write(' ');
        Console.SetCursorPosition(x, y);
        return ch;
    }


    static void WriteChar(char ch)
    {
        if (char.IsLower(ch))
            ch = char.ToUpper(ch);

        switch (ch)
        {
            case 'A': A(); break;
            case 'B': B(); break;
            case 'C': C(); break;
            case 'D': D(); break;
            case 'E': E(); break;
            case 'F': F(); break;
            case 'G': G(); break;
            case 'H': H(); break;
            case 'I': I(); break;
            case 'J': J(); break;
            case 'K': K(); break;
            case 'L': L(); break;
            case 'M': M(); break;
            case 'N': N(); break;
            case 'O': O(); break;
            case 'P': P(); break;
            case 'Q': Q(); break;
            case 'R': R(); break;
            case 'S': S(); break;
            case 'T': T(); break;
            case 'U': U(); break;
            case 'V': V(); break;
            case 'W': W(); break;
            case 'X': X(); break;
            case 'Y': Y(); break;
            case 'Z': Z(); break;
            case '.': Dot(); break;
            case '!': Vosk(); break;
            case '?': Ansver(); break;
            case ' ': Spase(); break;
            case '\r': Enter(); break;
            case '\b': Backspace(); break;
            default: return;
        }
    }

    private static void Backspace()
    {
        if (Curent_x == 0) return;
        Curent_x -= Curent_width;
        int x = Console.CursorLeft;
        int y = Console.CursorTop;
        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < Curent_width; j++)
            {
                Console.Write(' ');
                Curent_x++;
            }
            Curent_x = x;
            Curent_y++;
        }
        Curent_x = x; Curent_y = y;
        curent_width.RemoveLast();
    }

    static void A()
    {
        Write(Curent_x + 2, Curent_y + 0);
        Write(Curent_x + 3, Curent_y + 0);
        Write(Curent_x + 1, Curent_y + 1);
        Write(Curent_x + 3, Curent_y + 1);
        Write(Curent_x + 0, Curent_y + 2);
        Write(Curent_x + 3, Curent_y + 2);
        Write(Curent_x + 0, Curent_y + 3);
        Write(Curent_x + 3, Curent_y + 3);
        Write(Curent_x + 0, Curent_y + 4);
        Write(Curent_x + 1, Curent_y + 4);
        Write(Curent_x + 2, Curent_y + 4);
        Write(Curent_x + 3, Curent_y + 4);
        Write(Curent_x + 0, Curent_y + 5);
        Write(Curent_x + 3, Curent_y + 5);
        Write(Curent_x + 0, Curent_y + 6);
        Write(Curent_x + 3, Curent_y + 6);

        Curent_x += 5;
        Curent_width = 5;
    }

    static void B()
    {
        Write(Curent_x + 0, Curent_y + 0);
        Write(Curent_x + 1, Curent_y + 0);
        Write(Curent_x + 2, Curent_y + 0);
        Write(Curent_x + 0, Curent_y + 1);
        Write(Curent_x + 3, Curent_y + 1);
        Write(Curent_x + 0, Curent_y + 2);
        Write(Curent_x + 3, Curent_y + 2);
        Write(Curent_x + 0, Curent_y + 3);
        Write(Curent_x + 1, Curent_y + 3);
        Write(Curent_x + 2, Curent_y + 3);
        Write(Curent_x + 0, Curent_y + 4);
        Write(Curent_x + 3, Curent_y + 4);
        Write(Curent_x + 0, Curent_y + 5);
        Write(Curent_x + 3, Curent_y + 5);
        Write(Curent_x + 0, Curent_y + 6);
        Write(Curent_x + 1, Curent_y + 6);
        Write(Curent_x + 2, Curent_y + 6);

        Curent_x += 5;
        Curent_width = 5;
    }

    static void C()
    {
        Write(Curent_x + 1, Curent_y + 0);
        Write(Curent_x + 2, Curent_y + 0);
        Write(Curent_x + 0, Curent_y + 1);
        Write(Curent_x + 3, Curent_y + 1);
        Write(Curent_x + 0, Curent_y + 2);
        Write(Curent_x + 0, Curent_y + 3);
        Write(Curent_x + 0, Curent_y + 4);
        Write(Curent_x + 0, Curent_y + 5);
        Write(Curent_x + 3, Curent_y + 5);
        Write(Curent_x + 1, Curent_y + 6);
        Write(Curent_x + 2, Curent_y + 6);

        Curent_x += 5;
        Curent_width = 5;
    }


    static void D()
    {
        Write(Curent_x + 0, Curent_y + 0);
        Write(Curent_x + 1, Curent_y + 0);
        Write(Curent_x + 2, Curent_y + 0);
        Write(Curent_x + 0, Curent_y + 1);
        Write(Curent_x + 3, Curent_y + 1);
        Write(Curent_x + 0, Curent_y + 2);
        Write(Curent_x + 3, Curent_y + 2);
        Write(Curent_x + 0, Curent_y + 3);
        Write(Curent_x + 3, Curent_y + 3);
        Write(Curent_x + 0, Curent_y + 4);
        Write(Curent_x + 3, Curent_y + 4);
        Write(Curent_x + 0, Curent_y + 5);
        Write(Curent_x + 3, Curent_y + 5);
        Write(Curent_x + 0, Curent_y + 6);
        Write(Curent_x + 1, Curent_y + 6);
        Write(Curent_x + 2, Curent_y + 6);

        Curent_x += 5;
        Curent_width = 5;
    }



    static void E()
    {
        Write(Curent_x + 0, Curent_y + 0);
        Write(Curent_x + 1, Curent_y + 0);
        Write(Curent_x + 2, Curent_y + 0);
        Write(Curent_x + 3, Curent_y + 0);
        Write(Curent_x + 0, Curent_y + 1);
        Write(Curent_x + 0, Curent_y + 2);
        Write(Curent_x + 0, Curent_y + 3);
        Write(Curent_x + 1, Curent_y + 3);
        Write(Curent_x + 2, Curent_y + 3);
        Write(Curent_x + 0, Curent_y + 4);
        Write(Curent_x + 0, Curent_y + 5);
        Write(Curent_x + 0, Curent_y + 6);
        Write(Curent_x + 1, Curent_y + 6);
        Write(Curent_x + 2, Curent_y + 6);
        Write(Curent_x + 3, Curent_y + 6);

        Curent_x += 5;
        Curent_width = 5;
    }

    static void F()
    {
        Write(Curent_x + 0, Curent_y + 0);
        Write(Curent_x + 1, Curent_y + 0);
        Write(Curent_x + 2, Curent_y + 0);
        Write(Curent_x + 3, Curent_y + 0);
        Write(Curent_x + 0, Curent_y + 1);
        Write(Curent_x + 0, Curent_y + 2);
        Write(Curent_x + 0, Curent_y + 3);
        Write(Curent_x + 1, Curent_y + 3);
        Write(Curent_x + 2, Curent_y + 3);
        Write(Curent_x + 0, Curent_y + 4);
        Write(Curent_x + 0, Curent_y + 5);
        Write(Curent_x + 0, Curent_y + 6);

        Curent_x += 5;
        Curent_width = 5;
    }


    static void G()
    {
        Write(Curent_x + 1, Curent_y + 0);
        Write(Curent_x + 2, Curent_y + 0);
        Write(Curent_x + 0, Curent_y + 1);
        Write(Curent_x + 3, Curent_y + 1);
        Write(Curent_x + 0, Curent_y + 2);
        Write(Curent_x + 0, Curent_y + 3);
        Write(Curent_x + 0, Curent_y + 4);
        Write(Curent_x + 2, Curent_y + 4);
        Write(Curent_x + 3, Curent_y + 4);
        //Write(Curent_x + 4, Curent_y + 4);
        Write(Curent_x + 0, Curent_y + 5);
        Write(Curent_x + 3, Curent_y + 5);
        //Write(Curent_x + 4, Curent_y + 5);
        Write(Curent_x + 1, Curent_y + 6);
        Write(Curent_x + 2, Curent_y + 6);
        //Write(Curent_x + 4, Curent_y + 6);

        Curent_x += 5;
        Curent_width = 5;
    }


    static void H()
    {
        Write(Curent_x + 0, Curent_y + 0);
        Write(Curent_x + 3, Curent_y + 0);
        Write(Curent_x + 0, Curent_y + 1);
        Write(Curent_x + 3, Curent_y + 1);
        Write(Curent_x + 0, Curent_y + 2);
        Write(Curent_x + 3, Curent_y + 2);
        Write(Curent_x + 0, Curent_y + 3);
        Write(Curent_x + 1, Curent_y + 3);
        Write(Curent_x + 2, Curent_y + 3);
        Write(Curent_x + 3, Curent_y + 3);
        Write(Curent_x + 0, Curent_y + 4);
        Write(Curent_x + 3, Curent_y + 4);
        Write(Curent_x + 0, Curent_y + 5);
        Write(Curent_x + 3, Curent_y + 5);
        Write(Curent_x + 0, Curent_y + 6);
        Write(Curent_x + 3, Curent_y + 6);

        Curent_x += 5;
        Curent_width = 5;
    }
    static void I()
    {
        Write(Curent_x + 0, Curent_y + 0);
        Write(Curent_x + 0, Curent_y + 1);
        Write(Curent_x + 0, Curent_y + 2);
        Write(Curent_x + 0, Curent_y + 3);
        Write(Curent_x + 0, Curent_y + 4);
        Write(Curent_x + 0, Curent_y + 5);
        Write(Curent_x + 0, Curent_y + 6);


        Curent_x += 2;
        Curent_width = 2;
    }
    static void J()
    {
        Write(Curent_x + 3, Curent_y + 0);
        Write(Curent_x + 3, Curent_y + 1);
        Write(Curent_x + 3, Curent_y + 2);
        Write(Curent_x + 3, Curent_y + 3);
        Write(Curent_x + 0, Curent_y + 4);
        Write(Curent_x + 3, Curent_y + 4);
        Write(Curent_x + 0, Curent_y + 5);
        Write(Curent_x + 3, Curent_y + 5);
        Write(Curent_x + 1, Curent_y + 6);
        Write(Curent_x + 2, Curent_y + 6);

        Curent_x += 5;
        Curent_width = 5;
    }

    static void K()
    {
        Write(Curent_x + 0, Curent_y + 0);
        Write(Curent_x + 3, Curent_y + 0);
        Write(Curent_x + 0, Curent_y + 1);
        Write(Curent_x + 3, Curent_y + 1);
        Write(Curent_x + 0, Curent_y + 2);
        Write(Curent_x + 2, Curent_y + 2);
        Write(Curent_x + 0, Curent_y + 3);
        Write(Curent_x + 1, Curent_y + 3);
        Write(Curent_x + 0, Curent_y + 4);
        Write(Curent_x + 2, Curent_y + 4);
        Write(Curent_x + 0, Curent_y + 5);
        Write(Curent_x + 3, Curent_y + 5);
        Write(Curent_x + 0, Curent_y + 6);
        Write(Curent_x + 3, Curent_y + 6);

        Curent_x += 5;
        Curent_width = 5;
    }
    static void L()
    {
        Write(Curent_x + 0, Curent_y + 0);
        Write(Curent_x + 0, Curent_y + 1);
        Write(Curent_x + 0, Curent_y + 2);
        Write(Curent_x + 0, Curent_y + 3);
        Write(Curent_x + 0, Curent_y + 4);
        Write(Curent_x + 0, Curent_y + 5);
        Write(Curent_x + 0, Curent_y + 6);
        Write(Curent_x + 1, Curent_y + 6);
        Write(Curent_x + 2, Curent_y + 6);
        Write(Curent_x + 3, Curent_y + 6);

        Curent_x += 5;
        Curent_width = 5;
    }
    static void M()
    {
        Write(Curent_x + 0, Curent_y + 0);
        Write(Curent_x + 6, Curent_y + 0);
        Write(Curent_x + 0, Curent_y + 1);
        Write(Curent_x + 6, Curent_y + 1);
        Write(Curent_x + 0, Curent_y + 2);
        Write(Curent_x + 1, Curent_y + 2);
        Write(Curent_x + 5, Curent_y + 2);
        Write(Curent_x + 6, Curent_y + 2);
        Write(Curent_x + 0, Curent_y + 3);
        Write(Curent_x + 2, Curent_y + 3);
        Write(Curent_x + 4, Curent_y + 3);
        Write(Curent_x + 6, Curent_y + 3);
        Write(Curent_x + 0, Curent_y + 4);
        Write(Curent_x + 3, Curent_y + 4);
        Write(Curent_x + 6, Curent_y + 4);
        Write(Curent_x + 0, Curent_y + 5);
        Write(Curent_x + 6, Curent_y + 5);
        Write(Curent_x + 0, Curent_y + 6);
        Write(Curent_x + 6, Curent_y + 6);

        Curent_x += 8;
        Curent_width = 8;
    }

    static void N()
    {
        Write(Curent_x + 0, Curent_y + 0);
        Write(Curent_x + 4, Curent_y + 0);
        Write(Curent_x + 0, Curent_y + 1);
        Write(Curent_x + 4, Curent_y + 1);
        Write(Curent_x + 0, Curent_y + 2);
        Write(Curent_x + 1, Curent_y + 2);
        Write(Curent_x + 4, Curent_y + 2);
        Write(Curent_x + 0, Curent_y + 3);
        Write(Curent_x + 2, Curent_y + 3);
        Write(Curent_x + 4, Curent_y + 3);
        Write(Curent_x + 0, Curent_y + 4);
        Write(Curent_x + 3, Curent_y + 4);
        Write(Curent_x + 4, Curent_y + 4);
        Write(Curent_x + 0, Curent_y + 5);
        Write(Curent_x + 4, Curent_y + 5);
        Write(Curent_x + 0, Curent_y + 6);
        Write(Curent_x + 4, Curent_y + 6);

        Curent_x += 6;
        Curent_width = 6;
    }

    static void O()
    {
        Write(Curent_x + 1, Curent_y + 0);
        Write(Curent_x + 2, Curent_y + 0);
        Write(Curent_x + 0, Curent_y + 1);
        Write(Curent_x + 0, Curent_y + 2);
        Write(Curent_x + 0, Curent_y + 3);
        Write(Curent_x + 0, Curent_y + 4);
        Write(Curent_x + 0, Curent_y + 5);
        Write(Curent_x + 1, Curent_y + 6);
        Write(Curent_x + 2, Curent_y + 6);
        Write(Curent_x + 3, Curent_y + 1);
        Write(Curent_x + 3, Curent_y + 2);
        Write(Curent_x + 3, Curent_y + 3);
        Write(Curent_x + 3, Curent_y + 4);
        Write(Curent_x + 3, Curent_y + 5);


        Curent_x += 5;
        Curent_width = 5;
    }

    static void P()
    {
        Write(Curent_x + 0, Curent_y + 0);
        Write(Curent_x + 1, Curent_y + 0);
        Write(Curent_x + 2, Curent_y + 0);
        Write(Curent_x + 0, Curent_y + 1);
        Write(Curent_x + 0, Curent_y + 2);
        Write(Curent_x + 0, Curent_y + 3);
        Write(Curent_x + 0, Curent_y + 4);
        Write(Curent_x + 0, Curent_y + 5);
        Write(Curent_x + 0, Curent_y + 6);
        Write(Curent_x + 1, Curent_y + 4);
        Write(Curent_x + 2, Curent_y + 4);
        Write(Curent_x + 3, Curent_y + 1);
        Write(Curent_x + 3, Curent_y + 2);
        Write(Curent_x + 3, Curent_y + 3);


        Curent_x += 5;
        Curent_width = 5;
    }
    static void Q()
    {
        Write(Curent_x + 1, Curent_y + 0);
        Write(Curent_x + 2, Curent_y + 0);
        Write(Curent_x + 0, Curent_y + 1);
        Write(Curent_x + 0, Curent_y + 2);
        Write(Curent_x + 0, Curent_y + 3);
        Write(Curent_x + 0, Curent_y + 4);
        Write(Curent_x + 0, Curent_y + 5);
        Write(Curent_x + 1, Curent_y + 6);
        Write(Curent_x + 2, Curent_y + 6);
        Write(Curent_x + 3, Curent_y + 1);
        Write(Curent_x + 3, Curent_y + 2);
        Write(Curent_x + 3, Curent_y + 3);
        Write(Curent_x + 3, Curent_y + 4);
        Write(Curent_x + 3, Curent_y + 5);
        Write(Curent_x + 2, Curent_y + 5);
        Write(Curent_x + 4, Curent_y + 6);

        Curent_x += 6;
        Curent_width = 6;
    }

    static void R()
    {
        Write(Curent_x + 0, Curent_y + 0);
        Write(Curent_x + 1, Curent_y + 0);
        Write(Curent_x + 2, Curent_y + 0);
        Write(Curent_x + 0, Curent_y + 1);
        Write(Curent_x + 0, Curent_y + 2);
        Write(Curent_x + 0, Curent_y + 3);
        Write(Curent_x + 0, Curent_y + 4);
        Write(Curent_x + 0, Curent_y + 5);
        Write(Curent_x + 0, Curent_y + 6);
        Write(Curent_x + 1, Curent_y + 4);
        Write(Curent_x + 2, Curent_y + 4);
        Write(Curent_x + 3, Curent_y + 1);
        Write(Curent_x + 3, Curent_y + 2);
        Write(Curent_x + 3, Curent_y + 3);
        Write(Curent_x + 2, Curent_y + 5);
        Write(Curent_x + 3, Curent_y + 6);

        Curent_x += 5;
        Curent_width = 5;
    }
    static void S()
    {
        Write(Curent_x + 1, Curent_y + 0);
        Write(Curent_x + 2, Curent_y + 0);
        Write(Curent_x + 0, Curent_y + 1);
        Write(Curent_x + 0, Curent_y + 2);
        Write(Curent_x + 1, Curent_y + 3);
        Write(Curent_x + 0, Curent_y + 5);
        Write(Curent_x + 1, Curent_y + 6);
        Write(Curent_x + 2, Curent_y + 6);
        Write(Curent_x + 3, Curent_y + 1);
        Write(Curent_x + 2, Curent_y + 3);
        Write(Curent_x + 3, Curent_y + 4);
        Write(Curent_x + 3, Curent_y + 5);


        Curent_x += 5;
        Curent_width = 5;
    }
    static void T()
    {
        Write(Curent_x + 0, Curent_y + 0);
        Write(Curent_x + 1, Curent_y + 0);
        Write(Curent_x + 2, Curent_y + 0);
        Write(Curent_x + 2, Curent_y + 1);
        Write(Curent_x + 2, Curent_y + 2);
        Write(Curent_x + 2, Curent_y + 3);
        Write(Curent_x + 2, Curent_y + 4);
        Write(Curent_x + 2, Curent_y + 5);
        Write(Curent_x + 2, Curent_y + 6);
        Write(Curent_x + 3, Curent_y + 0);
        Write(Curent_x + 4, Curent_y + 0);

        Curent_x += 6;
        Curent_width = 6;
    }

    static void U()
    {
        Write(Curent_x + 0, Curent_y + 0);
        Write(Curent_x + 3, Curent_y + 0);
        Write(Curent_x + 0, Curent_y + 1);
        Write(Curent_x + 0, Curent_y + 2);
        Write(Curent_x + 0, Curent_y + 3);
        Write(Curent_x + 0, Curent_y + 4);
        Write(Curent_x + 0, Curent_y + 5);
        Write(Curent_x + 1, Curent_y + 6);
        Write(Curent_x + 2, Curent_y + 6);
        Write(Curent_x + 3, Curent_y + 1);
        Write(Curent_x + 3, Curent_y + 2);
        Write(Curent_x + 3, Curent_y + 3);
        Write(Curent_x + 3, Curent_y + 4);
        Write(Curent_x + 3, Curent_y + 5);

        Curent_x += 5;
        Curent_width = 5;
    }

    static void V()
    {
        Write(Curent_x + 0, Curent_y + 0);
        Write(Curent_x + 4, Curent_y + 0);
        Write(Curent_x + 0, Curent_y + 1);
        Write(Curent_x + 0, Curent_y + 2);
        Write(Curent_x + 0, Curent_y + 3);
        Write(Curent_x + 0, Curent_y + 4);
        Write(Curent_x + 1, Curent_y + 5);
        Write(Curent_x + 2, Curent_y + 6);
        Write(Curent_x + 4, Curent_y + 1);
        Write(Curent_x + 4, Curent_y + 2);
        Write(Curent_x + 4, Curent_y + 3);
        Write(Curent_x + 4, Curent_y + 4);
        Write(Curent_x + 3, Curent_y + 5);

        Curent_x += 6;
        Curent_width = 6;
    }

    static void W()
    {
        Write(Curent_x + 0, Curent_y + 0);
        Write(Curent_x + 4, Curent_y + 0);
        Write(Curent_x + 8, Curent_y + 0);
        Write(Curent_x + 0, Curent_y + 1);
        Write(Curent_x + 4, Curent_y + 1);
        Write(Curent_x + 8, Curent_y + 1);
        Write(Curent_x + 0, Curent_y + 2);
        Write(Curent_x + 4, Curent_y + 2);
        Write(Curent_x + 8, Curent_y + 2);
        Write(Curent_x + 0, Curent_y + 3);
        Write(Curent_x + 4, Curent_y + 3);
        Write(Curent_x + 8, Curent_y + 3);
        Write(Curent_x + 0, Curent_y + 4);
        Write(Curent_x + 4, Curent_y + 4);
        Write(Curent_x + 8, Curent_y + 4);
        Write(Curent_x + 1, Curent_y + 5);
        Write(Curent_x + 3, Curent_y + 5);
        Write(Curent_x + 5, Curent_y + 5);
        Write(Curent_x + 7, Curent_y + 5);
        Write(Curent_x + 2, Curent_y + 6);
        Write(Curent_x + 6, Curent_y + 6);

        Curent_x += 10;
        Curent_width = 10;
    }

    static void X()
    {
        Write(Curent_x + 0, Curent_y + 0);
        Write(Curent_x + 4, Curent_y + 0);
        Write(Curent_x + 0, Curent_y + 1);
        Write(Curent_x + 4, Curent_y + 1);
        Write(Curent_x + 1, Curent_y + 2);
        Write(Curent_x + 3, Curent_y + 2);
        Write(Curent_x + 2, Curent_y + 3);
        Write(Curent_x + 1, Curent_y + 4);
        Write(Curent_x + 3, Curent_y + 4);
        Write(Curent_x + 0, Curent_y + 5);
        Write(Curent_x + 4, Curent_y + 5);
        Write(Curent_x + 0, Curent_y + 5);
        Write(Curent_x + 0, Curent_y + 6);
        Write(Curent_x + 4, Curent_y + 6);

        Curent_x += 6;
        Curent_width = 6;
    }

    static void Y()
    {
        Write(Curent_x + 0, Curent_y + 0);
        Write(Curent_x + 4, Curent_y + 0);
        Write(Curent_x + 0, Curent_y + 1);
        Write(Curent_x + 4, Curent_y + 1);
        Write(Curent_x + 0, Curent_y + 2);
        Write(Curent_x + 4, Curent_y + 2);
        Write(Curent_x + 1, Curent_y + 3);
        Write(Curent_x + 3, Curent_y + 3);
        Write(Curent_x + 2, Curent_y + 4);
        Write(Curent_x + 2, Curent_y + 5);
        Write(Curent_x + 2, Curent_y + 6);

        Curent_x += 6;
        Curent_width = 6;
    }

    static void Z()
    {
        Write(Curent_x + 0, Curent_y + 0);
        Write(Curent_x + 1, Curent_y + 0);
        Write(Curent_x + 2, Curent_y + 0);
        Write(Curent_x + 3, Curent_y + 0);
        Write(Curent_x + 4, Curent_y + 0);
        Write(Curent_x + 4, Curent_y + 1);
        Write(Curent_x + 3, Curent_y + 2);
        Write(Curent_x + 2, Curent_y + 3);
        Write(Curent_x + 1, Curent_y + 4);
        Write(Curent_x + 0, Curent_y + 5);
        Write(Curent_x + 0, Curent_y + 6);
        Write(Curent_x + 1, Curent_y + 6);
        Write(Curent_x + 2, Curent_y + 6);
        Write(Curent_x + 3, Curent_y + 6);
        Write(Curent_x + 4, Curent_y + 6);

        Curent_x += 6;
        Curent_width = 6;
    }

    static void Dot()
    {
        Write(Curent_x + 0, Curent_y + 6);

        Curent_x += 2;
        Curent_width = 2;
    }

    static void Vosk()
    {
        Write(Curent_x + 0, Curent_y + 0);
        Write(Curent_x + 0, Curent_y + 1);
        Write(Curent_x + 0, Curent_y + 2);
        Write(Curent_x + 0, Curent_y + 3);
        Write(Curent_x + 0, Curent_y + 4);
        Write(Curent_x + 0, Curent_y + 6);

        Curent_x += 2;
        Curent_width = 2;
    }

    static void Ansver()
    {
        Write(Curent_x + 1, Curent_y + 0);
        Write(Curent_x + 2, Curent_y + 0);
        Write(Curent_x + 3, Curent_y + 0);
        Write(Curent_x + 3, Curent_y + 0);
        Write(Curent_x + 0, Curent_y + 1);
        Write(Curent_x + 4, Curent_y + 1);
        Write(Curent_x + 4, Curent_y + 2);
        Write(Curent_x + 3, Curent_y + 3);
        Write(Curent_x + 2, Curent_y + 4);
        Write(Curent_x + 2, Curent_y + 6);

        Curent_x += 2;
        Curent_width = 2;
    }


    static void Write(int x, int y)
    {
        Console.SetCursorPosition(x, y);
        Console.Write('#');
    }

    static void Spase()
    {
        Curent_x += 3;
        Curent_width = 3;
    }

    static void Enter()
    {
        Curent_x = 0;
        Curent_y += 8;
    }
}