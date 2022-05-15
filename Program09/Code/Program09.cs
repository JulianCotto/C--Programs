using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    //main programe
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is Program09");
            Test t;
            try
            {
                t = new Test(); // make object of class t
                t.CreateMultipleDirectories(); // call methord
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Thank you for running Program09");
                Console.WriteLine("This was a little harder than I expected it to be. I overcame however. Learning more and more everyday");
            }
            Console.ReadKey();
        }
    }

    class Test : IDisposable
    {

        public void CreateMultipleDirectories()
        {
            string rootdir = @"c:\test\";
            bool check = true;
            while (check)
            {
                string option = null;
                Console.WriteLine("To exit press 0 | To create a directory press 1 | To create a file press 2");
                option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        Console.WriteLine("Enter dir name");
                        string dirname = Console.ReadLine();
                        rootdir + dirname;
                        if (!Directory.Exists(rootdir)) // check if dir is exist or not
                        {
                            Directory.CreateDirectory(rootdir); // create dir
                        }
                        else
                        {
                            Console.WriteLine("Directory already exist");
                        }
                        break;
                    case "2":
                        Console.WriteLine("Enter File name");
                        string filename = Console.ReadLine();
                        rootdir + filename;
                        if (!File.Exists(rootdir)) // check file is exist or not
                        {
                            using (StreamWriter sw = File.CreateText(rootdir)) // make stream and write in the file
                            {
                                Console.WriteLine("Enter text for file");
                                string mytext = Console.ReadLine();
                                sw.WriteLine(mytext);
                            }
                            using (StreamReader sr = File.OpenText(rootdir)) // read from file
                            {
                                string str = "";
                                while ((str = sr.ReadLine()) != null)
                                {
                                    Console.WriteLine(str);
                                }
                            }

                            FileAttributes attributes = File.GetAttributes(rootdir); // check status of file
                            Console.WriteLine("Enter 1 for not Directory report status or 2 for Hidden report status");
                            string status = Console.ReadLine();
                            if (status.Equals("1"))
                            {
                                if ((attributes & FileAttributes.Directory) == FileAttributes.Directory)
                                {
                                    Console.WriteLine("not dir");
                                }
                                else
                                {
                                    Console.WriteLine("is dir");
                                }
                            }
                            else if (status.Equals("2"))
                            {
                                if ((attributes & FileAttributes.Hidden) == FileAttributes.Hidden)
                                {
                                    Console.WriteLine("is hidden");
                                }
                                else
                                {
                                    Console.WriteLine("not hidden");
                                }
                            }
                            else
                            {
                                Console.WriteLine("wrong option");
                            }

                        }
                        else
                        {
                            Console.WriteLine("File already exist");
                        }
                        break;
                    case "0":
                        check = false;
                        break;
                    default:
                        Console.WriteLine("wrong option");
                        break;

                }

            }

        }
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}

