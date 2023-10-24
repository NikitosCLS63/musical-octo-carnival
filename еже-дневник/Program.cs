using System;

namespace CHTOTOTAKOE
{
    internal class Program
    {
        static DateTime second = DateTime.Now;
        static void Main(string[] args)
        {
            int position = 1;
            ConsoleKeyInfo key;
            do
            {
                Console.Clear();
                Console.Write("Выбрана дата " + second.ToShortDateString() + "\n");
                Menu();
                Arrow(position);

                position = Arrow(position);
                Dela(position);
                key = Console.ReadKey();
            } while (key.Key != ConsoleKey.Q);
        }
        static void Menu()
        {
            if (second.Date == new DateTime(2023, 10, 21))
            {
                Console.WriteLine("  1 учить лекции Мысева");
                Console.WriteLine("  2 учить лекци Серяка");
                Console.WriteLine("  3 сделать что нибудь");
            }
            else if (second.Date == new DateTime(2023, 10, 22))
            {
                Console.WriteLine("  1 сдать олимпееаду по бжд ");
                Console.WriteLine("  2 сходить в заал  ");
                Console.WriteLine("  3 сходить в магазин ПЯТЕРОЧКА5");

            }
            else if (second.Date == new DateTime(2023, 10, 23))
            {
                Console.WriteLine("  1 научиться играть на гитаре ");
                Console.WriteLine("  2 сделать практические великого человека Волков ");
                Console.WriteLine("  3 поговорить с кем нибудь ");
            }
            else if (second.Date == new DateTime(2023, 10, 24))
            {
                Console.WriteLine("  1 написать код на С# ");
                Console.WriteLine("  2 написать код на питоне");
                Console.WriteLine("  3 заработать миллион ");
            }
        }
        static void Data(ConsoleKeyInfo key)
        {
            if (key.Key == ConsoleKey.LeftArrow)
            {
                Console.SetCursorPosition(0, 0);
                second = second.AddDays(-1);

                Console.Clear();
                Console.Write("Выбрана дата: " + second.ToShortDateString() + "\n");
                Menu();

            }
            else if (key.Key == ConsoleKey.RightArrow)
            {
                Console.SetCursorPosition(0, 0);
                second = second.AddDays(+1);
                Console.Clear();
                Console.Write("Выбрана дата: " + second.ToShortDateString() + "\n");
                Menu();
            }
        }

        static int Arrow(int position)
        {
            ConsoleKeyInfo key;
            do
            {
                Console.SetCursorPosition(0, position);
                Console.WriteLine("->");

                key = Console.ReadKey();

                Console.SetCursorPosition(0, position);
                Console.WriteLine("  ");


                if (key.Key == ConsoleKey.UpArrow)
                {
                    position--;
                    if (position == 0)
                        position = 3;
                }
                else if (key.Key == ConsoleKey.DownArrow)
                {
                    position++;
                    if (position == 4)
                        position = 1;
                }
                Data(key);
            } while (key.Key != ConsoleKey.Enter);
            return position;
        }
        static void Dela(int position1)
        {
            if (position1 == 1 && second.Date == new DateTime(2023, 10, 21))
            {
                Console.Clear();
                Console.WriteLine("учить лекции Мысева ");
                Console.WriteLine("\n-----------");
                Console.WriteLine("\nописание: там чет про мать.... метринскую плату");
                Console.WriteLine("\nДата: " + second);
            }   
            else if (position1 == 2 && second.Date == new DateTime(2023, 10, 21))
            {
                Console.Clear();
                Console.WriteLine("учить лекци Серяка ");
                Console.WriteLine("\n-----------");
                Console.WriteLine("\nописание: ой, ну это вообще тема, 18 листов учить, кайфы");
                Console.WriteLine("\nДата: " + second);
            }
            else if (position1 == 3 && second.Date == new DateTime(2023, 10, 21))
            {
                Console.Clear();
                Console.WriteLine("сделать что нибудь");
                Console.WriteLine("\n-----------");
                Console.WriteLine("\nописание: вы думали я еще что то буду делать? Серяка 18 страниц мало?");
                Console.WriteLine("\nДата: " + second);
            }
            else if (position1 == 1 && second.Date == new DateTime(2023, 10, 22))
            {
                Console.Clear();
                Console.WriteLine("сдать олимпееаду по бжд  ");
                Console.WriteLine("\n-----------");
                Console.WriteLine("\nописание: за то что меня якобы на паре небыло.");
                Console.WriteLine("\nДата: " + second  );
            }
            else if (position1 == 2 && second.Date == new DateTime(2023, 10, 22))
            {
                Console.Clear();
                Console.WriteLine("сходить в заал");
                Console.WriteLine("\n-----------");
                Console.WriteLine("\nописание: чисто размяться, ничего больше).");
                Console.WriteLine("\nДата: " + second);
            }
            else if (position1 == 3 && second.Date == new DateTime(2023, 10, 22))
            {
                Console.Clear();
                Console.WriteLine("сходить в магазин ПЯТЕРОЧКА5 ");
                Console.WriteLine("\n-----------");
                Console.WriteLine("\nописание: огурцы, помидоры, перец и тд");
                Console.WriteLine("\nДата: " + second);
            }
            else if (position1 == 1 && second.Date == new DateTime(2023, 10, 23))
            {
                Console.Clear();
                Console.WriteLine("  научиться играть на гитаре ");
                Console.WriteLine("\n-----------");
                Console.WriteLine("\nописание: не знаю зачем ну пусть будет");
                Console.WriteLine("\nДата: " + second);
            }
            else if (position1 == 2 && second.Date == new DateTime(2023, 10, 23))
            {
                Console.Clear();
                Console.WriteLine("сделать практические великого человека Волков  ");
                Console.WriteLine("\n-----------");
                Console.WriteLine("\nописание: на паре успею сдлеать за минут 30 ");
                Console.WriteLine("\nДата: " + second);
            }
            else if (position1 == 1 && second.Date == new DateTime(2023, 10, 23))
            {
                Console.Clear();
                Console.WriteLine("поговорить с кем нибудь ");
                Console.WriteLine("\n-----------");
                Console.WriteLine("\nописание: ой надо будет сами поговорят,верно?");
                Console.WriteLine("\nДата: " + second);
            }
            else if (position1 == 1 && second.Date == new DateTime(2023, 10, 24))
            {
                Console.Clear();
                Console.WriteLine(" написать код на С#");
                Console.WriteLine("\n-----------");
                Console.WriteLine("\nописание: тут надо все и сразу сделать, даже наа практос в перед");
                Console.WriteLine("\nДата: " + second);
            }
            else if (position1 == 2 && second.Date == new DateTime(2023, 10, 24))
            {
                Console.Clear();
                Console.WriteLine("написать код на питоне ");
                Console.WriteLine("\n-----------");
                Console.WriteLine("\nописание:ну питон туда сюда и готово.");
                Console.WriteLine("\nДата: " + second);
            }
            else if (position1 == 1 && second.Date == new DateTime(2023, 10, 24))
            {
                Console.Clear();
                Console.WriteLine("заработать миллион");
                Console.WriteLine("\n-----------");
                Console.WriteLine("\nописание: когда нибудь но не сейчас ");
                Console.WriteLine("\nДата: " + second);
            }




        }

       
    }
}

