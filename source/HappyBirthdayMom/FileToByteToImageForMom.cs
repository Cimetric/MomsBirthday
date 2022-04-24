using System;
using System.Drawing;
using System.IO;
using System.Timers;



namespace HappyBirthdayMom
{

    class Program
    {
        public class ImageConverter : System.ComponentModel.TypeConverter
        {

        }

        static void Main(string[] args)
        {



            Console.WriteLine("Hey Mom! I know that Olivia and I have already handed you a wonderful book as a present.");
            Console.WriteLine("But I thought I would make this for you as something you could keep and use to your hearts content.");
            Console.WriteLine("");
            Console.WriteLine("I made a way to make some pretty cool abstract art, out of your favorite pictures and files in general!");
            Console.WriteLine("");
            Console.WriteLine("Just copy the whichever file's path now to the command line ");


            string InputFilePath = Console.ReadLine();


            byte[] FileToByteArray(string InputFile)
            {
                byte[] fileData = null;

                using (FileStream fs = File.OpenRead(InputFilePath))
                {
                    var binaryReader = new BinaryReader(fs);
                    fileData = binaryReader.ReadBytes((int)fs.Length);
                }
                return fileData;

            }
            var FileBytes = FileToByteArray(InputFilePath);

            Console.WriteLine(System.BitConverter.ToString(FileBytes));
        }





    }
}
