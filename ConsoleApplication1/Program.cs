using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ConsoleApplication1
{
    class Program
    {
        //Tworzy plik DebugRandom.png w folderze aplikacji w bin
        static void Main(string[] args)
        {
            Bitmap bmp = new Bitmap(600, 600);
            Random rnd = new Random();
            string path = Environment.CurrentDirectory + "Random.png";
            for (int i = 0; i < 600; i++)
            {
                for (int j = 0; j < 600; j++)
                {
                    if(rnd.Next(0,2) == 0)
                        bmp.SetPixel(i, j, Color.Black);

                }
            }
            bmp.Save(path);
        }
    }
}
