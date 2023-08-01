/*Ответ на вопрос по SQL:
SELECT p.product_name, c.category_name
FROM products p
LEFT JOIN categories c ON p.product_id = c.product_id
*/

/*В тестововм описании не было подробно описано, что из
 себя должна представлять библиотека и как должна вычисляться площадь,
поэтому были реализованы два варианта:
    - создание объекта фигуры и использование метода для вычисления площади
    - функция, которая по заданным аргументам определяет фигуру и вычисляет площадь
    (во втором варианте все равно используются объекты первого варианта)
*/

namespace TestMindBox
{
    //абстрактный класс для других фигур
    public abstract class Figure
    {

        public abstract double Area();
        //перегруженные функции для вычисления площади, в зависимости
        //от количества аргументов создается нужный объект 
        //и вычисляется нужная площадь
        public static double CalcArea(double r)
        {
            Circle circle = new Circle(r);
            return circle.Area();
        }

        public static double CalcArea(double a, double b, double c)
        {
            Triangle triangle = new Triangle(a, b, c);  
            return triangle.Area();
        }
    }
    public class Circle:Figure
    {
        double radius;
        public Circle(double radius)
        {
            if (radius <= 0)
                throw new Exception("Радиус не может быть равен нулю или отрицательным"); 
            this.radius = radius;
        }

        public override double Area()
        {
            return Math.PI * radius * radius;
        }
    }

    public class Triangle : Figure
    {
        double a, b, c;
        public Triangle(double a, double b, double c)
        {
            if (a + b <= c || a + c <= b || b + c <= a)
                throw new Exception("Треугольника с такими сторонами не существует");
            if(a <= 0 || b <= 0 || c <= 0)
                throw new Exception("Сторона треугольника не может быть равна нулю или отрицательной");
            
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public override double Area()
        {
            double temp;
            if (c > b)
                swap(ref b, ref c);
            if (b > a)
                swap(ref a,ref b);
            if (Math.Sqrt(a * a) == Math.Sqrt(b * b + c * c))
                return (b * c)/2;

            double p = (a + b + c) / 2;

            return Math.Sqrt(p*(p-a)*(p-b)*(p-c));
        }
        void swap(ref double a, ref double b)
        {
            double temp;
            temp = a;
            a = b;
            b = temp;
        }
    }

}