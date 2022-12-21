using System;

namespace _21_12_2022_EV_TAPSIRIQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("1. Notebooklar uzerinde axtaris et");
            Console.WriteLine("2. Yeni notebook yarat");
            Console.WriteLine("0. Menudan cix");
            bool hasProblem = false;

            string countStr = Console.ReadLine();
            int count = Convert.ToInt32(countStr);

            Notebook[] notebooks = new Notebook[count];
           
            for (int i = 0; i < notebooks.Length; i++)
                {

                    try
                    {
                        Console.Write($"{i + 1}. Name:");
                        string name = Console.ReadLine();


                        Console.Write($"{i + 1}. Price :");
                        string priceStr = Console.ReadLine();
                        int price = Convert.ToInt32(priceStr);

                        Console.Write($"{i + 1}. Ram:");
                        string ramStr = Console.ReadLine();
                        double ram = Convert.ToByte(ramStr);


                        notebooks[i] = new Notebook(name, price);
                        notebooks[i].RAM = ram;


                    }
                    catch (Exception e)
                    {

                        Console.WriteLine("Bir xeta bas verdi :(");
                        Console.WriteLine("Error: " + e.Message);
                        Console.WriteLine("Yeniden daxil edin!");
                        hasProblem = true;
                    }


                }

                for (int i = 0; i < notebooks.Length; i++)
                {
                    Console.WriteLine(notebooks[i].GetInfo());
                }


                string answer;
                do
                {
                    Console.WriteLine("1. Notebooklar uzerinde axtaris et");
                    Console.WriteLine("2. Yeni notebook yarat");
                    Console.WriteLine("0. Menudan cix");

                    answer = Console.ReadLine();
                    try
                    {
                        if (answer == "1")
                        {
                            Console.WriteLine("Axtaris detalini yaz");

                            string search = Console.ReadLine();
                            Console.WriteLine("Filtered Notebooks:");
                            for (int i = 0; i < notebooks.Length; i++)
                            {
                                if (notebooks[i].Name.Contains(search))
                                {
                                    Console.WriteLine(notebooks[i].GetInfo());
                                }
                            }
                        }
                    }
                    catch (Exception e)
                    {

                        Console.WriteLine("Bir xeta bas verdi :(");
                        Console.WriteLine("Error: " + e.Message);
                        Console.WriteLine("Yeniden daxil edin!");
                        hasProblem = true;
                    }

                    if (answer == "2")
                    {
                        do
                        {
                            Console.WriteLine("1. Notebooklar uzerinde axtaris et");
                            Console.WriteLine("2. Yeni notebook yarat");
                            Console.WriteLine("0. Menudan cix");


                            string cotStr = Console.ReadLine();
                            int cot = Convert.ToInt32(cotStr);

                            Notebook[] notebooks1 = new Notebook[cot];
                            for (int i = 0; i < notebooks.Length; i++)
                            {
                                Console.Write($"{i + 1}. Name:");
                                string name = Console.ReadLine();

                                Console.Write($"{i + 1}. Price :");
                                string priceStr = Console.ReadLine();
                                int price = Convert.ToInt32(priceStr);

                                Console.Write($"{i + 1}. Ram:");
                                string ramStr = Console.ReadLine();
                                double ram = Convert.ToByte(ramStr);

                                notebooks[i] = new Notebook(name, price);
                                notebooks[i].RAM = ram;

                            }
                            Console.WriteLine("All Notebooks:");
                            for (int i = 0; i < notebooks.Length; i++)
                            {
                                Console.WriteLine(notebooks[i].GetInfo());
                            }

                        } while (answer != "2");


                    }

                    if (answer == "0")
                    {
                        Console.WriteLine("Proses Basa Catdi");
                        return;
                    }

                } while (answer != "1" && answer != "0" && answer != "2");
            }
        }
    }

