using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_16._09._2022_new
{
    public abstract class GeoFigure {
        public string name;
        public GeoFigure() {
            name = "Фигура";
        }
        private bool Scalable;
        public bool scalable {
            get { return Scalable; }
            set { Scalable = value; }
        }

        public void printName() {
            Console.WriteLine(this.name);// лучше писать так
        }
        public abstract float Square();
        public virtual float Square(float _metric) {

            return _metric;
        }
        public virtual float Square(float a, float b) {
            return a * b;
        }
        public virtual float Perimeter(float a, float b) {
            return 2 * (a * b);
        }
        public abstract float Perimeter();
        public virtual float Perimeter(float _metric) {
            return _metric;
        }

    }
}
