using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_16._09._2022_new {
    public class Circle : GeoFigure {

        public event MyDelegate _notify {
            add => _notify += value;
            remove => _notify -= value;
        }

        //наследник пользуется конструктором базового класса
        public new string name_ = "Окружность", path_ = "output.txt";
        public float _radius;
        //////////////////////////////////////////////////////////
        public override float Perimeter() {
            return 2 * 3.14f * _radius;
        }
        public float Perimeter(float _metric, bool isBase) {
            if (isBase) {
                return base.Perimeter(_metric);
            }
            {
                return Perimeter(_metric);
            }

        }
        public override float Square() {
            return _radius * _radius * 3.14f;
        }
        public override float Square(float _metric) {
            _radius = _metric;
            return _radius * _radius * 3.14f;
        }
        public float Square(float _metric, bool isBase) {
            if (isBase) {
                return base.Square(_metric);
            }
            {
                return Square(_metric);
            }

        }
        //вывод на консоль
        public void printSquareCircle() {
            Console.WriteLine($"площадь = {this.Square(_radius)}");
        }
        public void printSquareCircle(bool isBase) {
            Console.WriteLine($"площадь = {this.Square(_radius, isBase)}");
        }
        public void printPerimeterCircle() {
            Console.WriteLine("периметр = {0}", this.Perimeter(_radius));
        }
        public void printPerimeterCircle(bool isBase) {
            Console.WriteLine($"периметр = {this.Perimeter(_radius, isBase)}");
        }
        //сохранение
        public void WriteSquareCircle() {
            string full_path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);//доступ к папке
            var sw = new StreamWriter(full_path + "//" + path_, true);
            sw.WriteLine(name);
            sw.WriteLine("Площадь = {0}", this.Square(this._radius));
            sw.Close();
        }
        public void WritePerimeterCircle() {
            string full_path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var sw = new StreamWriter(full_path + "//" + path_, true);
            sw.WriteLine(name);
            sw.WriteLine("Периметр = {0}", this.Perimeter(this._radius));
            sw.Close();
        }
    }
}
