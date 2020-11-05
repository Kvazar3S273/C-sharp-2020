using System;
using System.Collections.Generic;
using System.Text;

namespace NortonCommander
{
    class Draw
    {
        public void Title()
        {
            Console.WriteLine("\n   The Total Commander, Version 1.00 Copyright (C) 2020 by Volodymyr Blonsky\n");
        }
        public void DrawOnceTable(int startX, int startY)
        {
            // 201 ╔        187  ╗
            // 205 ════ (4) 
            // 205 ═══  (3)
            // 205 ════════════  (12)
            // 186 ║    206 ╬     204 ╠      185 ╣  
            // 200 ╚    188 ╝
            // 209 ╤    207 ╧     199 ╟      182 ╢
            // 193 ┴    179 │     
            // 196 ──── (4)
            // 196 ─── (3)
            // 196 ──────────── (12)

            Console.SetCursorPosition(startX, startY);
            Console.WriteLine("╔════════════╤════════════╤════════════╗");
            for (int i = 1; i < 20; i++)
            {
                Console.SetCursorPosition(startX, startY + i);
                Console.WriteLine("║            │            │            ║");
            }
            Console.SetCursorPosition(startX, startY + 20);
            Console.WriteLine("╟────────────┴────────────┴────────────╢");
            Console.SetCursorPosition(startX, startY + 21);
            Console.WriteLine("║                                      ║");
            Console.SetCursorPosition(startX, startY + 22);
            Console.WriteLine("╚══════════════════════════════════════╝");
        }
        public void DrawFooter()
        {
            Console.SetCursorPosition(0, 27);
            Console.ResetColor();
            Console.Write("1");
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("Help  ");
            Console.ResetColor();
            Console.Write(" ");
            Console.Write("2");
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("Menu  ");
            Console.ResetColor();
            Console.Write(" ");
            Console.Write("3");
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("View  ");
            Console.ResetColor();
            Console.Write(" ");
            Console.Write("4");
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("Edit  ");
            Console.ResetColor();
            Console.Write(" "); 
            Console.Write("5");
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("Copy  ");
            Console.ResetColor();
            Console.Write(" ");
            Console.Write("6");
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("RenMov");
            Console.ResetColor();
            Console.Write(" ");
            Console.Write("7");
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("Mkdir ");
            Console.ResetColor();
            Console.Write(" ");
            Console.Write("8");
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("Delete");
            Console.ResetColor();
            Console.Write(" ");
            Console.Write("9");
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("PullDn");
            Console.ResetColor();
            Console.Write(" ");
            Console.Write("10");
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("Quit  ");
            Console.ResetColor();
            Console.Write(" ");
        }

        public void DrawDiscChoise(int startX, int startY)
        {
            Console.SetCursorPosition(startX, startY);
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("                                      ");
            Console.SetCursorPosition(startX, startY + 1);
            Console.Write("   ╔════════ ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("DRIVE LETTER");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write(" ════════╗   ");
            Console.SetCursorPosition(startX, startY + 2);
            Console.WriteLine("   ║         Choose drive:        ║   ");
            Console.SetCursorPosition(startX, startY + 3);
            Console.WriteLine("   ║   C   D   E   F   G   H   I  ║   "); 
            Console.SetCursorPosition(startX, startY + 4);
            Console.WriteLine("   ╚══════════════════════════════╝   ");
            Console.SetCursorPosition(startX, startY + 5);
            Console.WriteLine("                                      ");

            Console.ResetColor();

        }
    }
}
