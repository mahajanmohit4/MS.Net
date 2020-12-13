using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;

namespace FileHandlingEX
{
    class Program
    {
        static void Main1(string[] args)
        {
            string s = "Hello World";
            byte[] arr = Encoding.Default.GetBytes(s);
           // Directory.CreateDirectory(@"D:\study\DotNet\MS.Net\Day11\demo");
            FileStream stream = File.Open(@"D:\study\DotNet\MS.Net\Day11\demo\a.txt", FileMode.Create);//creating file stream  

            stream.Write(arr, 0, arr.Length);
            // stream.Length
            // stream.Read()
            stream.Close();



        }
        static void Main2(string[] args)
        {
            FileStream f = new FileStream(@"D:\study\DotNet\MS.Net\Day11\demo\a.txt", FileMode.OpenOrCreate);
            StreamReader s = new StreamReader(f);

            string line = s.ReadLine();
            Console.WriteLine(line);
            Console.ReadLine();


        }
        static void Main(string[] args)
        {
            Class1 o = new Class1();
            o.i = 100;
            o.P1 = "aaa";
            o.P2 = 200;

            BinaryFormatter bf = new BinaryFormatter();
            
            Stream s = new FileStream(@"D:\study\DotNet\MS.Net\Day11\demo\a.txt", FileMode.OpenOrCreate);
            bf.Serialize(s, o);
           // Class1 o = (Class1)bf.Deserialize(s);
            s.Close();
           

            Console.ReadLine();


        }

    }
    public class Class1
    {
        [Serializable]
        private int private_data;
        public int i;
        public string P1 { get; set; }
        private int mP2;
        public int P2 { get; set; }

    }
}
