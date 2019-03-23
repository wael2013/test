using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Menu
{
    
    class Program
    {
        static void Main(string[] args)
        {
            menuMethod();
        }

        private static void menuMethod()
        {
            string[] menu = { "   New    ", "  Display ", "   Exit   " };
            bool flag = true;
            int highlight = 0;
            ConsoleKeyInfo k;
            #region once menu
            //if (highlight == 0)
            //{
            //    Console.BackgroundColor = ConsoleColor.Blue;

            //}
            //else
            //{
            //    Console.BackgroundColor = ConsoleColor.Black;

            //}
            //Console.SetCursorPosition(30, 5);
            //Console.Write("New");
            //if (highlight == 1)
            //{
            //    Console.BackgroundColor = ConsoleColor.Blue;

            //}
            //else
            //{
            //    Console.BackgroundColor = ConsoleColor.Black;

            //}
            //Console.SetCursorPosition(30, 10);
            //Console.Write("Display");
            //if (highlight == 2)
            //{
            //    Console.BackgroundColor = ConsoleColor.Blue;

            //}
            //else
            //{
            //    Console.BackgroundColor = ConsoleColor.Black;

            //}
            //Console.SetCursorPosition(30, 15);
            //Console.Write("Exit");
            #endregion
            #region continous menu
            do
            {

                for (int i = 0; i < menu.Length; i++)
                {
                    if (highlight == i)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                    }
                    Console.SetCursorPosition(30, 5 + (i * 5));
                    Console.Write(menu[i]);

                }
                Console.ResetColor();
                Console.CursorVisible = false;

                k = Console.ReadKey();
                switch (k.Key)
                {
                    case ConsoleKey.Enter:
                        {
                            Console.Clear();
                            switch (highlight)
                            {
                                case 0:

                                    Console.WriteLine("new");
                                    Console.ReadLine();

                                    break;
                                case 1:
                                    Console.WriteLine("Dispaly");
                                    Console.ReadLine();
                                    break;
                                case 2:
                                    flag = false;
                                    break;
                            }
                            Console.Clear();
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        {
                            highlight++;
                            if (highlight > 2)
                                highlight = 0;
                        }
                        break;
                    case ConsoleKey.UpArrow:
                        {
                            highlight--;
                            if (highlight < 0)
                                highlight = 2;
                        }
                        break;
                    case ConsoleKey.Escape:
                        {
                            flag = false;
                        }
                        break;
                }
            } while (flag);
            #endregion
        }




        private static void menuMethod2()
        {
            Employee[] emparr = new Employee[5];
            int currentindex = 0;

            bool flag = true;
            int highlight = 0;
            ConsoleKeyInfo k;
            string[] menu = { "   New    ", "  Display ", "   Exit   " };
            do
            {

                for (int i = 0; i < menu.Length; i++)
                {
                    if (highlight == i)
                    {
                        Console.BackgroundColor = ConsoleColor.Blue;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                    }
                    Console.SetCursorPosition(30, 5 + (i * 5));
                    Console.Write(menu[i]);//.PadRight(10));

                }
                Console.ResetColor();
                Console.CursorVisible = false;
                k = Console.ReadKey();
                switch (k.Key)
                {
                    case ConsoleKey.Enter:
                        {
                            Console.Clear();
                            switch (highlight)
                            {
                                case 0:
                                    if (currentindex < emparr.Length-1)
                                        NewEmployee(emparr, currentindex);
                                    else
                                    {
                                        Console.WriteLine("the array is full");
                                        Console.ReadLine();
                                    }

                                    break;
                                case 1:
                                    DispalyEmplyees(emparr, currentindex);
                                    break;
                                case 2:
                                    flag = false;
                                    break;
                            }
                            Console.Clear();
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        {
                            highlight++;
                            if (highlight > 2)
                                highlight = 0;
                        }
                        break;
                    case ConsoleKey.UpArrow:
                        {
                            highlight--;
                            if (highlight < 0)
                                highlight = 2;
                        }
                        break;
                }
            } while (flag);
        }

        private static void DispalyEmplyees(Employee[] empar, int index)
        {
            for (int i = 0; i < index; i++)
            {
                Console.WriteLine(empar[i].ToString());
            }
            Console.WriteLine("Dispaly");
            Console.ReadLine();
        }

        private static void NewEmployee(Employee[] empar, int index)
        {

            Console.WriteLine("new");
            Console.ReadLine();
        }
    }
}
