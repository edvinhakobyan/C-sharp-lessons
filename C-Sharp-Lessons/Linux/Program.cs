﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Linux
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("For Show Files and Folders in Folder, Write Folder Path and Enter");
            Console.WriteLine("For Show Files Content, Write File Path and Enter");
            Console.Write("For Create File, Use Comand ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Create");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("For Delete File, Use Comand ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Delete");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("For Append File, Use Comand ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Append");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("For Exit, Use ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Esc");
            Console.ForegroundColor = ConsoleColor.Gray;

            while (true)
            {
                bool flag = true;
                ConsoleKey key = Console.ReadKey().Key;

                if (key == ConsoleKey.Escape)
                    break;

                String Path = key.ToString();
                Path += Console.ReadLine();

                string[] filNames = null;
                string[] folderNames = null;
                try
                {
                    filNames = Directory.GetFiles(Path);
                }
                catch {  }

                try
                {
                    folderNames = Directory.GetDirectories(Path);
                }
                catch{ }

                if (filNames != null)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("-Files-");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    foreach (var item in filNames)
                        Console.WriteLine(item);
                    flag = false;
                }

                if (folderNames != null)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("-Folders-");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    foreach (var item in folderNames)
                        Console.WriteLine(item);
                    flag = false;
                }

                if(File.Exists(Path))
                {
                    foreach (var item in File.ReadAllLines(Path))
                        Console.WriteLine(item);
                    flag = false;
                }

                if(Path == "Create")
                {
                    Console.Write("-> ");
                    string fileName = Console.ReadLine();
                    try
                    {
                        if (!File.Exists(fileName))
                        {
                            using (File.Create(fileName)) { };
                                Console.WriteLine($"File {fileName} created");
                        }
                        else
                        {
                            Console.WriteLine($"File with Name {fileName} exist");
                            Console.Write($"Do you want to replace it (y/n) ");
                            if (Console.ReadLine() == "y")
                            {
                                using (File.Create(fileName)) { };
                                    Console.WriteLine($"File {fileName} created");
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    flag = false;
                }

                if (Path == "Delete")
                {
                    Console.Write("-> ");
                    string fileName = Console.ReadLine();
                    try
                    {
                        if (File.Exists(fileName))
                        {
                            File.Delete(fileName);
                            Console.WriteLine($"File {fileName} deleted");
                        }
                        else
                        {
                            Console.WriteLine($"File {fileName} not exist");
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    flag = false;
                }

                if (Path == "Append")
                {
                    Console.Write("-> ");
                    string fileName = Console.ReadLine();
                    try
                    {
                        if (File.Exists(fileName))
                        {
                            StreamWriter wr = File.AppendText(fileName);
                            Console.Write("-> ");
                            string text = Console.ReadLine();
                            wr.WriteLine(text);
                            wr.Close();
                            Console.WriteLine($"Text is Append in your File");
                        }
                        else
                        {
                            Console.WriteLine($"File {fileName} not exist");
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    flag = false;
                }

                if(flag)
                {
                    Console.WriteLine($"{Path} is Not Comand");
                }

            }
        }
    }
}
