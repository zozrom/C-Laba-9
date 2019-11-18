using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_9_Zozulia_Roman
{
    //Базовий клас
    abstract class Shape
    {
        protected string colorOfShape { get; set; }
        protected int numberOfVertices { get; }
        protected string nameOfShape { get; }

        //типа базовый наборцветов для случайного задавания цвета

        string[] colors = { "Black", "Blue", "Cyan", "DarkBlue", "DarkCyan", "DarkGray", "DarkGreen", "DarkMagenta", "DarkRed", "DarkYellow",
            "Gray","Green","Magenta","Red","White","Yellow"};

        //кострукторы
        protected Shape() { }
        protected Shape(string nameOfShape, int numberOfVertices)
        {
            this.nameOfShape = nameOfShape;
            this.numberOfVertices = numberOfVertices;
            Random rndm = new Random();
            colorOfShape = colors[rndm.Next(0, colors.Length)];
        }
        //Присвоюємо захисним змінним данні 
        protected Shape(string nameOfShape, int numberOfVertices, string colorOfShape)
        {
            this.nameOfShape = nameOfShape;
            this.numberOfVertices = numberOfVertices;
            this.colorOfShape = colorOfShape;
        }
        abstract public void CountArea();
        abstract public void CountPerimetr();
        // то что надо во всех классах, одно на все и везде будет сделано

        protected static double EnterArea()
        {
            double number = 0;
            Console.Write("Enter Side Lendth: ");
            string str1 = Convert.ToString(Console.ReadLine());
           
                bool isAllNumbers = true;
                char[] charArray = str1.ToCharArray();//Число класдемо до масиву
                for (int i = 0; i < charArray.Length; i++)
                {
                    if (!char.IsDigit(charArray[i]))
                    {
                        if (charArray[i] != '.')
                        {
                            if (charArray[i] != ',')
                            {
                                isAllNumbers = false;
                                break;
                            }
                        }
                    }
                    if (charArray[i] == '.')
                    {
                        charArray[i] = ',';
                    }
                }
                if (isAllNumbers == true)
                {
                    string str2 = new string(charArray);
                    number = Convert.ToDouble(str2);
                }
               
            
            return number;
        }
        protected void ChangeColorOfLetters(string s)
        {
            switch (s)//Вибір коліра за назвою 
            {
                case "Black":
                    {
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.White;
                        break;
                    }
                case "Blue":
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        break;
                    }
                case "Cyan":
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        break;
                    }
                case "DarkBlue":
                    {
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        break;
                    }
                case "DarkCyan":
                    {
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        break;
                    }
                case "DarkGray":
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        break;
                    }
                case "DarkGreen":
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        break;
                    }
                case "DarkMagenta":
                    {
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        break;
                    }
                case "DarkRed":
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        break;
                    }
                case "DarkYellow":
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        break;
                    }
                case "Gray":
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                        break;
                    }
                case "Green":
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                    }
                case "Magenta":
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        break;
                    }
                case "Red":
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                    }
                case "White":
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    }
                case "Yellow":
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                    }

                default:
                    {
                        Console.WriteLine("This color not faund, so will be Red!!!");
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                    }
            }
        }
    }


    //Task 3 :
    public interface IDraw
    {
        void Draw();
    }


    // Task 2 :
    class Picture
    {
        protected int numberOfElements = 0;
        public Picture()
        {
            List<Shape> shapes = new List<Shape>();
        }
        public Picture(int lendth)
        {
            List<Shape> shapes = new List<Shape>(lendth);
        }

    }


    class Square : Shape, IDraw
    {
        // поля
        protected double sideLendth = 0;
        protected double squareArea = 0;
        protected double squarePerimetr = 0;

        // конструкторы
        public Square() { }
        protected Square(string name) : base(name, 4)
        {
            Random random = new Random();
            sideLendth = random.Next(1, 100);
        }
        protected Square(string name, double sideLendth) : base(name, 4)
        {
            this.sideLendth = sideLendth;
        }
        protected Square(string name, double sideLendth, string color) : base(name, 4, color)
        {
            this.sideLendth = sideLendth;
        }
        static public Square EnterData()
        {
            Square square;
            bool isName = true;
            bool isSideLendth = false;//Так як не знаємо ще данних присвоюємо фолс
            bool isColor = false;
            string name;
            double sideLendth;
            string color;
            
                Console.Write(" Name  Square: ");
                name = Convert.ToString(Console.ReadLine());
                
           
            sideLendth = EnterArea();//Ввід данних числа та повертаэмо число 
            
                isSideLendth = true;
            
            Console.Write(" Color  Square: ");
            color = Convert.ToString(Console.ReadLine());
           
                isColor = true;
            
            if (isName == true && isSideLendth == true)
            {
                if (isName == true && isSideLendth == true && isColor == true)
                {
                    square = new Square(name, sideLendth, color);
                    return square;
                }
                else
                {
                    square = new Square(name, sideLendth);
                    return square;
                }
            }
            else
            {
                square = new Square(name);
                return square;
            }
        }
        protected void DisplayData()
        {
            Console.WriteLine($"\tName: {nameOfShape}\tNumber of Verticles: {numberOfVertices}\tColor: {colorOfShape}\t" +
                $"Side Lendth: {sideLendth}\tArea: {squareArea}\tPerimetr: {squarePerimetr}");
        }
        //подсчет площади
        public override void CountArea()
        {
            squareArea = sideLendth * sideLendth;
            Console.WriteLine($"Square area = {squareArea}");
        }
        // подсчет периметра
        public override void CountPerimetr()
        {
            squarePerimetr = 4 * sideLendth;
            Console.WriteLine($"Square perimetr = {squarePerimetr}");
        }

        // ввод значения дабл

        public void Draw()
        {
            string colorOfLetters = colorOfShape;
            ChangeColorOfLetters(colorOfLetters);
            DisplayData();
            Console.ResetColor();
        }

    }



    //Клас Circle унаслідован від Shape
    class Circle : Shape, IDraw
    {
        protected double radius = 0;
        protected double circleArea = 0;
        protected double circleLength = 0;
        readonly double pi = 3.14;
        // конструкторы
        public Circle() { }
        protected Circle(string name) : base(name, 0)
        {
            Random random = new Random();
            radius = random.Next(1, 100);
        }
        protected Circle(string name, double radius) : base(name, 0)
        {
            this.radius = radius;
        }
        protected Circle(string name, double radius, string color) : base(name, 0, color)
        {
            this.radius = radius;
        }
        static public Circle EnterData()
        {
            Circle circle;
            bool isName = true;
            bool isRadius = false;
            bool isColor = false;
            string name;
            double radius;
            string color;
           
                Console.Write(" Name  Circle: ");
                name = Convert.ToString(Console.ReadLine());
               
            radius = EnterArea();
            
                isRadius = true;
            
            Console.Write("Name Square: ");
            color = Convert.ToString(Console.ReadLine());
           
                isColor = true;
            
           
            if (isName == true && isRadius == true)
            {
                if (isName == true && isRadius == true && isColor == true)
                {
                    circle = new Circle(name, radius, color);
                    return circle;
                }
                else
                {
                    circle = new Circle(name, radius);
                    return circle;
                }
            }
            else
            {
                circle = new Circle(name);
                return circle;
            }
        }
        protected void DisplayData()
        {
            Console.WriteLine($"Name: {nameOfShape}\tNumber of Verticles: {numberOfVertices}\tColor: {colorOfShape}\t" +
                $"Radius: {radius}\tArea: {circleArea}\tPerimetr: {circleLength}");
        }
        //подсчет площади
        public override void CountArea()
        {
            circleArea = pi * radius * radius;
            Console.WriteLine($"Square area = {circleArea}");
        }
        // подсчет периметра
        public override void CountPerimetr()
        {
            circleLength = 2 * pi * radius;
            Console.WriteLine($"Square perimetr = {circleLength}");
        }
        public void Draw()
        {
            string colorOfLetters = colorOfShape;
            ChangeColorOfLetters(colorOfLetters);
            DisplayData();
            Console.ResetColor();
        }

    }

    //Triangle унаследован от Shape
    class Triangle : Shape, IDraw
    {
        // поля
        protected double sideLendth = 0;
        protected double triangleArea = 0;
        protected double trianglePerimetr = 0;

        // конструкторы
        public Triangle() { }
        protected Triangle(string name) : base(name, 3)
        {
            Random random = new Random();
            sideLendth = random.Next(1, 100);
        }
        protected Triangle(string name, double sideLendth) : base(name, 3)
        {
            this.sideLendth = sideLendth;
        }
        protected Triangle(string name, double sideLendth, string color) : base(name, 3, color)
        {
            this.sideLendth = sideLendth;
        }

        static public Triangle EnterData()
        {
            Triangle triangle;
            bool isName = true;
            bool isSideLendth = false;//Так як ще не ввели присваюємо фолс!!!
            bool isColor = false;
            string name;
            double sideLendth;
            string color;
            
                Console.Write(" Name  Triangle: ");
                name = Convert.ToString(Console.ReadLine());
                
            sideLendth = EnterArea();
            
                isSideLendth = true;
            
            
            
            Console.Write("Input Color Trianle: ");
            color = Convert.ToString(Console.ReadLine());
            
                isColor = true;
            
            
            if (isName == true && isSideLendth == true)
            {
                if (isName == true && isSideLendth == true && isColor == true)
                {
                    triangle = new Triangle(name, sideLendth, color);
                    return triangle;
                }
                else
                {
                    triangle = new Triangle(name, sideLendth);
                    return triangle;
                }
            }
            else
            {
                triangle = new Triangle(name);
                return triangle;
            }
        }
        protected void DisplayData()//Вивід кіневих данних 
        {
            Console.WriteLine($"\tName: {nameOfShape}\tNumber of Verticles: {numberOfVertices}\tColor: {colorOfShape}\t" +
                $"Side Lendth: {sideLendth}\tArea: {triangleArea}\tPerimetr: {trianglePerimetr}");
        }
        //подсчет площади
        public override void CountArea()
        {
            double halfPerimetr = sideLendth * 3 / 2;
            triangleArea = Math.Sqrt(halfPerimetr * (halfPerimetr - sideLendth) * (halfPerimetr - sideLendth) * (halfPerimetr - sideLendth));
            Console.WriteLine($"Square area = {triangleArea}");
        }
        // подсчет периметра
        public override void CountPerimetr()
        {
            trianglePerimetr = sideLendth * 3;
            Console.WriteLine($"Square perimetr = {trianglePerimetr}");
        }
        public void Draw()
        {
            string colorOfLetters = colorOfShape;
            ChangeColorOfLetters(colorOfLetters);
            DisplayData();
            Console.ResetColor();//Сброс коліра
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Square square;//Створюємо обьект класу Square
            square = Square.EnterData();
            square.Draw();
            Triangle triangle;//Створюємо обьект класу Triangle
            triangle = Triangle.EnterData();
            triangle.Draw();
            Circle circle;//Створюємо обьект класу Circle
            circle = Circle.EnterData();
            circle.Draw();


            Console.ReadKey();
        }
    }
}
