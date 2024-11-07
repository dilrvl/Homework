using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Вывести на экран число e (основание натурального логарифма) с точностью до десятых.
            Console.WriteLine("1: ");
            double e = Math.E;
            Console.WriteLine("Значение e с точностью до десятых: {0:F1}", e);
            */



            /* Вывести на экран числа 50 и 10 одно под другим.
            Console.WriteLine("2: ");
            Console.WriteLine(50);
            Console.WriteLine(10);
            */

            /*Составить программу вывода на экран «столбиком» четырех любых чисел.
            Console.WriteLine("3: ");
            double number1 = Convert.ToDouble(Console.ReadLine());
            double number2 = Convert.ToDouble(Console.ReadLine());
            double number3 = Convert.ToDouble(Console.ReadLine());
            double number4 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(number1);
            Console.WriteLine(number2);
            Console.WriteLine(number3);
            Console.WriteLine(number4);
            */

            /* Пользователь вводит число. Выведите на экран число, которое больше введенного на 10.
            Console.WriteLine("4: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(a + 10); */

            /*Дана сторона квадрата. Найти его периметр.
            Console.WriteLine("5: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(b * 4); */

            /*Дан радиус окружности. Найти длину окружности и площадь круга.
            Console.WriteLine("6: ");
            double R = Convert.ToDouble(Console.ReadLine());
            double circum = 2 * Math.PI * R;
            double area = Math.PI * R * R;
            Console.WriteLine("Длина окружности: " + circum);
            Console.WriteLine("Площадь круга: " + area); */

            /*Найти значение y=cos(x)
            Console.WriteLine("7: ");
            double degrees = Convert.ToDouble(Console.ReadLine());
            double radians = degrees * Math.PI / 180;
            double y = Math.Cos(radians);
            Console.WriteLine($"Значение y = cos({degrees}) = {y}");*/

            /*Даны основания и высота равнобедренной трапеции. Найти ее периметр.
            Console.WriteLine("8: ");
            double osn1 = Convert.ToDouble(Console.ReadLine());
            double osn2 = Convert.ToDouble(Console.ReadLine());
            double vis = Convert.ToDouble(Console.ReadLine());
            double c = Math.Sqrt(vis * vis + Math.Pow((osn2 - osn1) / 2, 2));
            double per = osn1 + osn2 + 2 * c;
            Console.WriteLine($"Периметр равнобедренной трапеции: {per}"); */

            /*Известна стоимость 1 кг конфет, печенья и яблок. Найти стоимость всей покупки, если купили x кг конфет, у кг печенья и z кг яблок.
            Console.WriteLine("9: ");
            Console.Write("Введите стоимость 1 кг конфет: ");
            double price1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите стоимость 1 кг печенья: ");
            double price2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите стоимость 1 кг яблок: ");
            double price3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите количество кг конфет (x): ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите количество кг печенья (y): ");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите количество кг яблок (z): ");
            double z = Convert.ToDouble(Console.ReadLine());      
            double obch = (x * price1) + (y * price2) + (z * price3);          
            Console.WriteLine($"Общая стоимость покупки: {obch} руб."); */

            /*Напишите программу, выводит на экран три строки "Мир", "Труд" и "Май"(кавычки не нужны). Причём сделайте, чтобы выводилось сначала так: Мир Труд Май
            // Затем так: Мир
                              //Труд
                                     //Май
            Console.WriteLine("10: ");
            Console.WriteLine("Мир" + " Труд" + " Май ");
            Console.WriteLine( "Мир");
            Console.WriteLine("    Труд");
            Console.WriteLine("          Май "); */

            /*Составить программу вывода на экран числа, вводимого с клавиатуры. Вводимому числу должно предшествовать сообщение «Вы ввели число».
             Console.WriteLine("13: ");
             Console.WriteLine( " Вы ввели число " + Convert.ToDouble(Console.ReadLine())); */

            /*Составить программу вывода на экран следующей информации: 2 кг
                                                                      // 13
                                                                      // 17


             Console.WriteLine("14:");
             Console.WriteLine("2 кг");
             Console.WriteLine("13" + " " + "17 "); */

            /*Составить программу вывода на экран «столбиком» четырех случайных чисел.
            Console.WriteLine("15:");
            Random random = new Random(); 
            Console.WriteLine("Случайные числа:");
            for (int i = 0; i < 4; i++)
            {
                int Number = random.Next(1, 101);
                Console.WriteLine(Number);
            }
            */

            /* Найти корни квадратного уравнения(коэффициента задаются пользователем с клавиатуры)
            Console.WriteLine("16:");
            Console.Write("Введите коэффициент a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите коэффициент b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите коэффициент c: ");
            double c = Convert.ToDouble(Console.ReadLine());
            if (a == 0)
            {
                Console.WriteLine("Коэффициент a не может быть равным 0.");
                return;
            }
            double D = b * b - 4 * a * c;
            if (D > 0)
            {
                // Два различных корня
                double x1 = (-b + Math.Sqrt(D)) / (2 * a);
                double x2 = (-b - Math.Sqrt(D)) / (2 * a);
                Console.WriteLine($"Два корня: x1 = {x1}, x2 = {x2}");
            }
            else if (D == 0)
            {
                // Один корень (дважды)
                double x = -b / (2 * a);
                Console.WriteLine($"Один корень): x = {x}");
            }
            else
            {
                // Нет действительных корней
                Console.WriteLine("Нет корней.");
            }
            */

            /*Даны два целых числа. Найти: а) их среднее арифметическое; б) их среднее геометрическое.
            Console.WriteLine("17:");
            int a = Convert.ToInt32(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());                                               
            Console.WriteLine("a) Среднее арифмитическое: " + (a + b) / 2);
            Console.WriteLine("б) Среднее геометрическое: " + Math.Sqrt( a * b ) ); */

            /*Известны координаты на плоскости двух точек. Составить программу вычисления расстояния между ними.
            Console.WriteLine("18:");
            Console.WriteLine("Введите координаты точки А: ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координаты точки В: ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            double y2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" D = " + (Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)))); */

            /*Составить программу обмена значениями трех переменных величин а, b, c по следующим двум схемам:
            //а) b присвоить значение c, а присвоить значение b, с присвоить значение а;
            //б) b присвоить значение а, с присвоить значение b, а присвоить значение с.
            Console.WriteLine("19:");
            Console.Write("Введите значение a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите значение b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите значение c: ");
            int c = Convert.ToInt32(Console.ReadLine());
            int t = a;
            a =b; b = c; c= t;
            Console.WriteLine($" а) {a} {b} {c}");
            int d = a; a =b; b = c; c = d;
            Console.WriteLine($"б) {a} {b} {c}"); */

            /*С начала суток прошло n секунд. Определить:            а) сколько полных часов прошло с начала суток;           б) сколько полных минут прошло с начала очередного часа;            в) сколько полных секунд прошло с начала очередной минуты.
            Console.WriteLine("20:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"а) {a / 3600} ");
            Console.WriteLine($"б) {(a % 3600) / 60}");
            Console.WriteLine($"в) {a % 60}"); */

            /*Дан прямоугольник с размерами 543 х 130 мм. Сколько квадратов со стороной 130 мм можно отрезать от него ?
            Console.WriteLine("21:");
            int h = 543;  // ширина в мм
            int t = 130; // высота в мм          
            int e = 130; // сторона квадрата в мм          
           int he= h / e;  
            int te = t/ e;
            Console.WriteLine($"Получится {he * te} квадратов"); */

            /*Дано трехзначное число. В нем зачеркнули последнюю справа цифру и приписали ее в начале.Найти полученное число.
            Console.WriteLine("22:");
            int z = Convert.ToInt32(Console.ReadLine());
            int x = z / 10;
            int y = z % 10;
            Console.WriteLine($" {y}{x}");   */

            /*Дано натуральное число n (n > 999). Найти:
            //а) число сотен в нем;
            //б) число тысяч в нем.
            Console.WriteLine("23:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"а) {(n / 100) % 10}");
            Console.WriteLine($"б){n / 1000}"); */

            /*
            Console.WriteLine("24:");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = a % 10;
            int c = (a / 10) % 10;
            int d = (a / 100) % 10;
            int e = a / 1000;
            Console.WriteLine($"а){b}{c}{d}{e}");
            Console.WriteLine($"б){d}{e}{b}{c}");
            Console.WriteLine($"в){e}{c}{d}{b}");
            Console.WriteLine($"г){b}{c}{e}{d}"); */

            /*Даны целые числа h, m, s (0 ≤ h ≤ 23, 0 ≤ m ≤ 59, 0 ≤ s ≤ 59), указывающие момент времени: «h часов, m минут, s секунд». Определить угол(в градусах) между положением часовой стрелки в начале суток и в указанный момент времени.
            Console.WriteLine("26:");            
            int h = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());
            int s = Convert.ToInt32(Console.ReadLine());
            // Проверка диапазонов
            if (h < 0 || h > 23 || m < 0 || m > 59 || s < 0 || s > 59)
            {
                Console.WriteLine("Неправильный ввод времени.");
                return;
            }            
            h = h % 12;           
            double e = 30 * h + 0.5 * m + (0.5 / 60) * s;
            Console.WriteLine($"Угол между часовыми стрелками: {e} градусов."); */

            /*Составить программу, которая:            а) запрашивает имя человека и повторяет его на экране;            б) запрашивает имя человека и повторяет его на экране с приветствием.
            Console.WriteLine("34:");
            Console.Write("Введите ваше имя: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Вы ввели: {name}");
            Console.Write("Введите ваше имя: ");
            string  name1 = Console.ReadLine();
            Console.WriteLine($"Привет, {name1}!"); */


        }
    }
    
}