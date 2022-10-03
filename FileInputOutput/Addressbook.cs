using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileInputOutput
{
    public class Addressbook
    {
        private static string path = @"C:\Users\Shree\Desktop\Day27_File_IO\FileInputOutput\Demo.txt";
        public static void ReadFromStreamReader()
        {
            using (StreamReader sr = File.OpenText(path))
            {
                string s = " ";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
        }
        public static void WriteUsingStreamReader()
        {

            using (StreamWriter sr = File.AppendText(path))
            {
               
                sr.WriteLine(" Firstname = Abhishek, Lastname = jagtap, Contact number = 727669541, ZipCode = 411028 ");
                sr.Close();
                Console.WriteLine(File.ReadAllText(path));
            }
        }
    }
}
