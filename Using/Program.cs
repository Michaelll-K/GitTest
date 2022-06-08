using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Using
{
    internal class Program
    {
        static void Main(string[] args) // blok "using" możemy wykorzystać dla każdej klasy która dziedziczy po IDisposable
        {
            var filePath = "B:/file.txt";
            var fileContent = File.ReadAllLines(filePath);

            using (var readFileStream = new FileStream(filePath, FileMode.Open))
            {
                //readFileStream.Read();
            }// domyślnie na końcu using wykonuje się .Close()


            var writeFileStream = new FileStream(filePath, FileMode.Open);

            //writeFileStream.Write();
            writeFileStream.Close();



            //          *using zastępuje to bo to bardzo popularne przy korzystaniu z danych zewnętrznych*
            //try
            //{
            //    throw new Exception();
            //    //readFileStream.Read();
            //}
            //finally
            //{
            //    readFileStream.Close();
            //}


            using (var some = new SomeClass()) // <- teraz można użyć bo SomeClass dziedziczy po disposable
            {
                some.SayHi();
            }

        }

    }
}
