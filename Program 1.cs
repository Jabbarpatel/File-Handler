using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ch;
            do
            {
                Console.WriteLine("-------------------------");
                Console.WriteLine("--1).To Create an File---");
                Console.WriteLine("--2).To Read File--------");
                Console.WriteLine("--3).To Copy the Path----");
                Console.WriteLine("--4).To Move the File----");
                Console.WriteLine("--5).To Delete the File--");
                Console.WriteLine("--6).To Exit-------------");
                Console.WriteLine("-------------------------");
                Console.WriteLine("Enter the choice");
                ch = Int32.Parse(Console.ReadLine());
                string path;
                switch (ch)
                {
                    case 1:
                        Console.WriteLine("----Enter the path to check the the is alredy exits----");
                        path = Console.ReadLine();
                        create(path);
                        break;
                    case 2:
                        Console.WriteLine("---Enter the path---");
                        path = Console.ReadLine();
                        read(path);
                        break;
                    case 3:
                        copy();
                        break;
                    case 4:
                        movefile();
                        break;
                    case 5:
                        deletefile();
                        break;
                }
            } while (ch != 6);
            Console.WriteLine("EXIT");
            Console.ReadLine();
        }
        static void create(string path)
        {

            if (File.Exists(path))
            {
                Console.WriteLine("-----The file is alredy Exits-----");
            }
            else
            {
                StreamWriter sw = new StreamWriter(path);
                Console.WriteLine("-----File is Created------");
                string s;
                Console.WriteLine("--Enter a data to insert in a file--");
                s = Console.ReadLine();
                sw.WriteLine(s);
                Console.WriteLine("-----Data is inserted in a file----");
                sw.Close();
            }
        }
        static void read(string path)
        {
            if (File.Exists(path))
            {
                StreamReader sr = new StreamReader(path);
                Console.WriteLine("------The Data Present in the File-------");
                while (sr.ReadLine() is string s)
                {
                    Console.WriteLine(s);
                }
                sr.Close();
            }
            else
            {
                Console.WriteLine("-----File Not Found-----");
            }
         
        }
        static void copy()
        {
            string sourcefile;
            Console.WriteLine("-------Enter the Path to copy--------");
            sourcefile = Console.ReadLine();
            string destination;
            Console.WriteLine("---------Enter the destination where to copy------");
            destination = Console.ReadLine();
            if (File.Exists(sourcefile))
            {
                File.Copy(sourcefile, destination);
                Console.WriteLine("---The File is Succesfully Copied----");
            }
            else
            {
                Console.WriteLine("------Path is not found----------");
            }
        }
        static void movefile()
        {
            string sourcefile;
            Console.WriteLine("-------Enter the Source Path--------");
            sourcefile = Console.ReadLine();
            string destination;
            Console.WriteLine("---------Enter the destination Path------");
            destination = Console.ReadLine();
            if (File.Exists(sourcefile))
            {
                File.Move(sourcefile, destination);
                Console.WriteLine("-----The File Succesfully Moved-----");
            }
            else
            {
                Console.WriteLine("------Path is not found----------");
            }
        }
        static void deletefile()
        {
            Console.WriteLine("-------Enter the Path to delete the file--------");
            string path;
            path=Console.ReadLine();
            if(File.Exists(path))
            {
                Console.WriteLine("----------The file is deleted---------");
                File.Delete(path);
            }
            else
            {
                Console.WriteLine("-----------Path Not Found-------");
            }
        }
    }
}
