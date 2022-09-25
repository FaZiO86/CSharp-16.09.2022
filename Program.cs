using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace CSharp_16._09._2022_new {
    //Гардедж колектор?
    public delegate void MyDelegate();


    class Program {
        static void Main(string[] args) {
            var myCircle = new Circle(); 
            var myRectangle = new Rectangle();
            var myRhomb = new Rhomb();
            
            int num = 0;
           Console.WriteLine($"Какой подсчёт фигуры вы бы хотели сделать?\n"+
               "[1] окружность\n"+
               "[2] прямоугольник\n"+
               "[3] ромб\n");
            num = Convert.ToInt32( Console.ReadLine());
            switch (num) {
                case 1: Console.WriteLine("Введите радиус окружности ");
                    myCircle._radius = Convert.ToSingle( Console.ReadLine());
                    MyDelegate  _delegateCircle = myCircle.printName;
                    myCircle.name = "Окружность";
                    _delegateCircle += myCircle.printSquareCircle;
                    _delegateCircle += myCircle.printPerimeterCircle;
                    _delegateCircle?.Invoke();
                    Console.WriteLine("Хотите сохранить данные окружности в файл [Y] да/[N]нет");
                    char str = Convert.ToChar(Console.ReadLine());
                    if(str == 'Y') {
                        _delegateCircle += myCircle.WriteSquareCircle;
                        _delegateCircle += myCircle.WritePerimeterCircle;
                        _delegateCircle -= myCircle.printSquareCircle;
                        _delegateCircle -= myCircle.printPerimeterCircle;
                        _delegateCircle?.Invoke();
                       Console.WriteLine("Данные сохранены");
                    }
                    break;
                    case 2: Console.WriteLine("Введите Сторону А в прямоугольнике ");
                    myRectangle.sideA = Convert.ToSingle( Console.ReadLine());
                    Console.WriteLine("Введите Сторону B в прямоугольнике ");
                    myRectangle.sideB = Convert.ToSingle( Console.ReadLine());
                    MyDelegate _delegateRectangle = myRectangle.printName;
                    myRectangle.name = "Прямоугольник";
                    _delegateRectangle += myRectangle.printRectangleSquare;
                    _delegateRectangle += myRectangle.printRectanglePerimeter;
                    _delegateRectangle?.Invoke();
                    Console.WriteLine("Хотите сохранить данные прямоугольника в файл [Y] да/[N]нет");
                    str = Convert.ToChar(Console.ReadLine());
                    if(str == 'Y') {
                        _delegateRectangle += myRectangle.WriteSquareRectangle;
                        _delegateRectangle += myRectangle.WriteRectanglePerimeter;
                        _delegateRectangle -= myRectangle.printRectangleSquare;
                        _delegateRectangle -= myRectangle.printRectanglePerimeter;
                        _delegateRectangle?.Invoke();
                       Console.WriteLine("Данные сохранены");
                    }
                    break;
                    case 3: Console.WriteLine("Введите длинну стороны ромба ");
                    myRhomb.side = Convert.ToSingle( Console.ReadLine());
                    Console.WriteLine("Введите высоту ромба ");
                    myRhomb.height = Convert.ToSingle( Console.ReadLine());
                    MyDelegate _delegateRhomb = myRhomb.printName;
                    myRhomb.name = "Ромб";
                    _delegateRhomb += myRhomb.printRhombSquare;
                    _delegateRhomb += myRhomb.printRhombPerimeter;
                    _delegateRhomb?.Invoke();
                    Console.WriteLine("Хотите сохранить данные ромба в файл [Y] да/[N]нет");
                    str = Convert.ToChar(Console.ReadLine());
                    if(str == 'Y') {
                        _delegateRhomb += myRhomb.WriteRhombSquare;
                        _delegateRhomb += myRhomb.WriteRhombPerimeter;
                        _delegateRhomb -= myRhomb.printRhombSquare;
                        _delegateRhomb -= myRhomb.printRhombPerimeter;
                        _delegateRhomb?.Invoke();
                       Console.WriteLine("Данные сохранены");
                    }
                    break;

            }

           
            
            Console.ReadLine();
        }
    }
}

