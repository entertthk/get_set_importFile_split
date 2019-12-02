using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrjoshkaProject
{   
    class Matrjoshka
    {
        public static int Count = 0;
        string name;
        string color;
        int size;
        string image;

        public Matrjoshka(string _name, string _color, int _size, string _image)
        {
            
            name = _name;
            color = _color;
            Size = _size;
            image = _image;
            Count++;
        }
        public string Name
        {
            get { return name; }
        }
        public string Color
        {
            get { return color; }
        }
        public string Image
        {
            get { return image; }
        }
        public int Size
        {
            get { return size;  }
            set
            {
                if (value > 0 && value <= 10)
                {
                    size = value;
                }
                else 
                {
                    size = 1;
                }
            }
        }
        public Matrjoshka OpenMatrjoshka(string _name, string _color, string _image)
        {
            Matrjoshka newMatrjoshka = new Matrjoshka(_name, _color, size-2, _image);
            return newMatrjoshka;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Matrjoshka> boxOfMatrjoshkas = new List<Matrjoshka>();
            Matrjoshka matrjoshka1 = new Matrjoshka("Matrjoshka1", "blue", 10, "image1"); //loome matrjoshka
            boxOfMatrjoshkas.Add(matrjoshka1);
            //open matrjoshkas
            Matrjoshka matrjoshka2 = matrjoshka1.OpenMatrjoshka("Matrjoshka2", "orange", "image2"); //paneme meetodi tööle mis loob uue matrjoshka matrjoshka1-st
            boxOfMatrjoshkas.Add(matrjoshka2);
            Matrjoshka matrjoshka3 = matrjoshka2.OpenMatrjoshka("Matrjoshka3", "red", "image3");
            boxOfMatrjoshkas.Add(matrjoshka3);
            Matrjoshka matrjoshka4 = matrjoshka3.OpenMatrjoshka("Matrjoshka4", "black", "image4");
            boxOfMatrjoshkas.Add(matrjoshka4);
            Matrjoshka matrjoshka5 = matrjoshka4.OpenMatrjoshka("Matrjoshka5", "purple", "image5");
            boxOfMatrjoshkas.Add(matrjoshka5);
            
            foreach(Matrjoshka matrjoshka in boxOfMatrjoshkas) //matrjoska boxofmatrjoshka listis
            {
                Console.WriteLine($"A {matrjoshka.Color} {matrjoshka.Name} size {matrjoshka.Size} is in the box");
            }
            Console.WriteLine($"There are {Matrjoshka.Count} matrjoshkas in the box");

            Console.WriteLine("What color matrjoshka would you take from the box");
            string userInput = Console.ReadLine();

            for(int i = 0; i < boxOfMatrjoshkas.Count; i++) // count- gets number of elemnts conatined in the list
            {
                if(boxOfMatrjoshkas[i].Color == userInput)
                {
                    Console.WriteLine($"You have taken {boxOfMatrjoshkas[i].Name} from the box");
                    boxOfMatrjoshkas.Remove(boxOfMatrjoshkas[i]);
                    Matrjoshka.Count--;
                    break;
                }
            }

            foreach(Matrjoshka matrjoshka in boxOfMatrjoshkas)
            {
                Console.WriteLine($"A {matrjoshka.Color} {matrjoshka.Name} size {matrjoshka.Size} is in the box");
                
            }

            Console.WriteLine($"There are {Matrjoshka.Count} matrjoshkas in the box");

            


            Console.ReadLine();
        }
    }
}
