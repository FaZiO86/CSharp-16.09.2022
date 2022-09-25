using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CSharp_16._09._2022_new {
    public class Rectangle : GeoFigure {
        //площадь A*B периметр 2(A*B)
        
        public new string name_ = "Прямоугольник", path_ = "output.txt";
        public float sideA;
        public float sideB;
        /////////////////////////////////////////////////////////////////////////
        public override float Square() {
    
            return sideA * sideB;
        }
        public float Square(float a, float b, bool isBase) {
            if (isBase) {
                return base.Square(a, b);
            }
            {
                return Square(a, b);
            }

        }
        public override float Perimeter() {
            float _resault = 2 * (sideA * sideB);
            return _resault;
        }
        public override float Perimeter(float a, float b) {
            sideA = a;
            sideB = b;
            return 2 * (sideA * sideB);
        }
        public float Perimeter(float a, float b, bool isBase) {
            if (isBase) {
                return base.Perimeter(a, b);
            }
            {
                return Perimeter(a, b);
            }

        }
        public void printRectangleSquare() {
            Console.WriteLine($"площадь = {this.Square()}");
        }
        public void printRectangleSquare(bool isBase) {
            Console.WriteLine($"площадь = {this.Square(sideA,sideB, isBase)}");
        }
        public void printRectanglePerimeter() {
            Console.WriteLine($"Периметр = {this.Perimeter(sideA, sideB)}");
        }
        public void printRectanglePerimeter(bool isBase) {
            Console.WriteLine($"Периметр = {this.Perimeter(sideA, sideB, isBase)}");
        }
        public void WriteSquareRectangle() {
            string full_path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);//доступ к папке
            var sw = new StreamWriter(full_path + "//" + path_, true);
            sw.WriteLine(name);
            sw.WriteLine("Площадь = {0}", this.Square(this.sideA,this.sideB));
            sw.Close();
        }
        public void WriteRectanglePerimeter() {
            string full_path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var sw = new StreamWriter(full_path + "//" + path_, true);
            sw.WriteLine(name);
            sw.WriteLine("Периметр = {0}", this.Perimeter(this.sideA,this.sideB));
            sw.Close();
        }
    }
}
