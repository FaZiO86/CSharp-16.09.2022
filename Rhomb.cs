using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CSharp_16._09._2022_new {
    public class Rhomb : GeoFigure {
        //площадь ромба высота * сторону, периметр 4 * сторону
        public new string name_ = "Ромб", path_ = "output.txt";
        public float side;
        public float height;
        public override float Square() {
            return side * height;
        }
        public override float Perimeter() {
            return 4 * side;
        }
        public void printRhombSquare() {
            Console.WriteLine($"площадь = {this.Square()}");
        }
        public void printRhombPerimeter() {
            Console.WriteLine($"Периметр = {this.Perimeter()}");
        }
        public void WriteRhombSquare() {
            string full_path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);//доступ к папке
            var sw = new StreamWriter(full_path + "//" + path_, true);
            sw.WriteLine(name);
            sw.WriteLine("Площадь = {0}", this.Square());
            sw.Close();
        }
        public void WriteRhombPerimeter() {
            string full_path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var sw = new StreamWriter(full_path + "//" + path_, true);
            sw.WriteLine(name);
            sw.WriteLine("Периметр = {0}", this.Perimeter());
            sw.Close();
        }
    }
}
