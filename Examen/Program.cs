using System;
using System.Text;
namespace examen
{
    class Start : Lessons
    {
        List<string> listrand = new List<string>();
        List<int> answerrand = new List<int>();
        List<string> usersmath = new List<string>();
        List<int> pointmath = new List<int>();
        List<string> usersgeo = new List<string>();
        List<int> pointgeo = new List<int>();
        List<string> usershistory = new List<string>();
        List<int> pointhistory = new List<int>();
        List<string> usersmix = new List<string>();
        List<int> pointmix = new List<int>();
        History history;
        Geography geography;
        Math math;
        Enter enter;
        int choose = 0;
        public Start()
        {
            StreamWriter streamWriter = new StreamWriter("results.txt", false);
            streamWriter.Close();
            StreamWriter streamWriter1 = new StreamWriter("top20math.txt", true);
            streamWriter1.Close();
            StreamWriter streamWriter2 = new StreamWriter("top20geo.txt", true);
            streamWriter2.Close();
            StreamWriter streamWriter3 = new StreamWriter("top20history.txt", true);
            streamWriter3.Close();
            StreamWriter streamWriter4 = new StreamWriter("top20mix.txt", true);
            streamWriter4.Close();
            StreamWriter streamwr = new StreamWriter("newlol", true);
            streamwr.Close();
            enter = new Enter();            
            while (choose != 5)
            {
                Console.WriteLine("1 - Start new game\n2 - Show my results\n3 - Show top 20\n4 - change settings\n5 - exit: ");
                choose = int.Parse(Console.ReadLine());
                if (choose == 1)
                {
                    Console.WriteLine("Выберите викторину: 1 - История  2 - География  3 - Математика  4 - Смешанная: ");
                    choose = int.Parse(Console.ReadLine());
                    if (choose == 1)
                        history = new History(enter.login, pointhistory, usershistory);
                    if (choose == 2)
                        geography = new Geography(enter.login, pointgeo, usersgeo);
                    if (choose == 3)
                        math = new Math(enter.login, pointmath, usersmath);
                    if (choose == 4)
                    {
                        Console.WriteLine("Смешанная викторина (Если есть 2 ответа то вводите их через пробел)");
                        Console.WriteLine();
                        listrand = new List<string>();
                        answerrand = new List<int>();
                        int i = 0;
                        history = new History(listrand, answerrand);
                        geography = new Geography(listrand, answerrand);
                        math = new Math(listrand, answerrand);
                        while (i < 10)
                        {
                            try
                            {
                                Console.WriteLine(listrand[i]);
                                choosestr = Console.ReadLine();
                                if (choosestr.Length < 2)
                                {
                                    choose = int.Parse(choosestr);
                                    if (choose == answerrand[i])
                                        points++;
                                    i++;
                                }
                                else if (choosestr.Length == 3)
                                {
                                    answer = choosestr.Split(' ');
                                    choosestr = answer[0] + answer[1];
                                    choose = int.Parse(choosestr);
                                    if (choose == answerrand[i])
                                        points++;
                                    i++;
                                }
                                else
                                    throw new Exception();
                            }
                            catch
                            {
                                Console.WriteLine("Вводите 2 ответа через пробел");
                            }
                        }
                        List<string> users2 = usersmix;
                        List<int> point2 = pointmix;
                        List<string> userspoints = new List<string>();
                        Console.WriteLine($"Your points = {points}");
                        Console.WriteLine();
                        using (StreamWriter sw = new StreamWriter("results.txt", true))
                        {
                            sw.WriteLine($"Смешанная викторина: {enter.login} - {points} points");
                            pointmix.Add(points);
                            usersmix.Add(enter.login);
                        }
                        using (StreamReader streamReader = new StreamReader("top20mix.txt", true))
                        {
                            int j = 0;
                            string? line;
                            int h = 0;
                            while ((line = streamReader.ReadLine()) != null)
                            {
                                string[] arg = line.Split(" ");
                                users2.Add(arg[0]);
                                point2.Add(Convert.ToInt32(arg[1]));
                            }
                            while (users2.Count() > 20 && point2.Count() > 20)
                            {
                                int d = point2.FindIndex(p => p == h);
                                if (d == -1)
                                    h++;
                                else
                                {
                                    users2.RemoveAt(d);
                                    point2.RemoveAt(d);
                                }
                            }
                        }
                        using (StreamWriter streamWr = new StreamWriter("top20mix.txt", false))
                        {
                            int h = 5;
                            int k = point2.Count();
                            for (int j = 0; j < k;)
                            {
                                while (point2.Contains(h))
                                {
                                    int d = point2.FindIndex(p => p == h);
                                    userspoints.Add($"{users2[d]} {point2[d]}");
                                    streamWr.WriteLine(userspoints[j]);
                                    users2.RemoveAt(d);
                                    point2.RemoveAt(d);
                                    j++;
                                }
                                h--;
                            }
                        }
                    }
                    choose = 99;
                    points = 0;
                }
                if (choose == 2)
                {
                    Console.WriteLine();
                    Showresults();
                }
                if (choose == 3)
                {
                    Console.WriteLine();
                    ShowTop20();
                }
                if (choose == 4)
                {
                    ChangeSettings();
                }
            }
        }
        void ShowTop20()
        {
            Console.WriteLine("По какой викторине показать топ 20?: 1 - по истории 2 - по географии 3 - по математике 4 - по смешанной");
            int choose = int.Parse(Console.ReadLine());
            if (choose == 4)
            {
                Console.WriteLine("TOP 20 MIX:");
                using (StreamReader streamReader = new StreamReader("top20mix.txt", true))
                {
                    string? line;
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        Console.WriteLine(line + " points");
                    }
                }
            }
            else if (choose == 3)
            {
                Console.WriteLine("TOP 20 MATH:");
                using (StreamReader streamReader = new StreamReader("top20math.txt", true))
                {
                    string? line;
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        Console.WriteLine(line + " points");
                    }
                }
            }
            else if (choose == 2)
            {
                Console.WriteLine("TOP 20 GEOGRAPHY:");
                using (StreamReader streamReader = new StreamReader("top20geo.txt", true))
                {
                    string? line;
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        Console.WriteLine(line + " points");
                    }
                }
            }
            else if (choose == 1)
            {
                Console.WriteLine("TOP 20 HISTORY:");
                using (StreamReader streamReader = new StreamReader("top20history.txt", true))
                {
                    string? line;
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        Console.WriteLine(line + " points");
                    }
                }
            }
            Console.WriteLine();
        }
        void Showresults()
        {
            using (StreamReader streamReader = new StreamReader("results.txt", true))
            {
                string? line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
            Console.WriteLine();
        }
        void ChangeSettings()
        {
            string newlogin = "";
            string newpassword = "";
            DateTime newTime = new DateTime();
            Console.WriteLine("Что хотите изменить?: 1 - логин 2 - пароль 3 - логин и пароль, 4 - дату рождения 5 - выход");
            int choose = int.Parse(Console.ReadLine());
            while (choose != 5)
            {
                if (choose == 1)
                {
                    choose = 0;
                    newlogin = "";
                    while (newlogin.Length < 6)
                    {
                        Console.WriteLine("Введите новый логин: ");
                        newlogin = Console.ReadLine();
                        if (newlogin.Length < 6)
                            Console.WriteLine("Логин должнен быть не меньше 6 символов");
                    }
                    using (StreamReader reader = new StreamReader(enter.path, true))
                    {
                        string? line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            string[] ar = line.Split(' ');
                            if (ar[0] == newlogin)
                            {
                                choose = 1;
                                Console.WriteLine("Такой пользователь уже существует");
                            }
                        }
                    }
                    if (choose == 0)
                    {
                        using (StreamWriter sw = new StreamWriter("newlol.txt", false))
                        {
                            using (StreamReader reader = new StreamReader(enter.path, true))
                            {
                                string? line;
                                while ((line = reader.ReadLine()) != null)
                                {
                                    
                                    if (line == $"{enter.login} {enter.password} {enter.dateTime.ToShortDateString()}")
                                    {
                                        sw.WriteLine($"{newlogin} {enter.password} {enter.dateTime.ToShortDateString()}");
                                        enter.login = newlogin;
                                    }
                                    else
                                        sw.WriteLine(line);
                                }
                            }
                        }
                        using (StreamWriter sw = new StreamWriter(enter.path, false))
                        {
                            using (StreamReader streamReader = new StreamReader("newlol.txt", true))
                            {
                                string? line;
                                while ((line = streamReader.ReadLine()) != null)
                                {
                                    if (line == $"{enter.login} {enter.password} {enter.dateTime.ToShortDateString()}")
                                    {
                                        sw.WriteLine($"{newlogin} {enter.password} {enter.dateTime.ToShortDateString()}");
                                        enter.login = newlogin;
                                    }
                                    else
                                        sw.WriteLine(line);
                                }
                            }
                        }
                        choose = 5;
                    }
                }
                else if (choose == 2)
                {
                    choose = 0;
                    newpassword = "";
                    while (newpassword.Length < 6)
                    {
                        Console.WriteLine("Введите новый пароль: ");
                        newpassword = Console.ReadLine();
                        if (newpassword.Length < 6)
                            Console.WriteLine("Пароль должнен быть не меньше 6 символов");
                    }
                    using (StreamWriter sw = new StreamWriter("newlol.txt", false))
                    {
                        using (StreamReader reader = new StreamReader(enter.path, true))
                        {
                            string? line;
                            while ((line = reader.ReadLine()) != null)
                            {
                                if (line == $"{enter.login} {enter.password} {enter.dateTime.ToShortDateString()}")
                                    sw.WriteLine($"{enter.login} {newpassword} {enter.dateTime.ToShortDateString()}");
                                else
                                    sw.WriteLine(line);
                            }
                        }
                    }
                    using (StreamWriter sw = new StreamWriter(enter.path, false))
                    {
                        using (StreamReader streamReader = new StreamReader("newlol.txt", true))
                        {
                            string? line;
                            while ((line = streamReader.ReadLine()) != null)
                            {
                                if (line == $"{enter.login} {enter.password} {enter.dateTime.ToShortDateString()}")
                                    sw.WriteLine($"{enter.login} {newpassword} {enter.dateTime.ToShortDateString()}");
                                else
                                    sw.WriteLine(line);
                            }
                        }
                    }
                    choose = 5;
                }
                else if (choose == 3)
                {
                    choose = 0;
                    newlogin = "";
                    while (newlogin.Length < 6 || newpassword.Length < 6)
                    {
                        Console.WriteLine("Введите новый логин: ");
                        newlogin = Console.ReadLine();
                        Console.WriteLine("Введите новый пароль: ");
                        newpassword = Console.ReadLine();
                        if (newlogin.Length < 6 || newpassword.Length < 6)
                            Console.WriteLine("Логин и пароль должны быть не меньше 6 символов");
                    }
                    using (StreamReader reader = new StreamReader(enter.path, true))
                    {
                        string? line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            string[] ar = line.Split(' ');
                            if (ar[0] == newlogin)
                            {
                                choose = 3;
                                Console.WriteLine("Такой пользователь уже существует");
                            }
                        }
                    }
                    if (choose == 0)
                    {
                        using (StreamWriter sw = new StreamWriter("newlol.txt", false))
                        {
                            using (StreamReader reader = new StreamReader(enter.path, true))
                            {
                                string? line;
                                while ((line = reader.ReadLine()) != null)
                                {
                                    if (line == $"{enter.login} {enter.password} {enter.dateTime.ToShortDateString()}")
                                    {
                                        sw.WriteLine($"{newlogin} {newpassword} {enter.dateTime.ToShortDateString()}");
                                    }
                                    else
                                        sw.WriteLine(line);
                                }
                            }
                        }
                        using (StreamWriter sw = new StreamWriter(enter.path, false))
                        {
                            using (StreamReader streamReader = new StreamReader("newlol.txt", true))
                            {
                                string? line;
                                while ((line = streamReader.ReadLine()) != null)
                                {
                                    if (line == $"{enter.login} {enter.password} {enter.dateTime.ToShortDateString()}")
                                    {
                                        sw.WriteLine($"{newlogin} {newpassword} {enter.dateTime.ToShortDateString()}");
                                        enter.login = newlogin;
                                    }
                                    else
                                        sw.WriteLine(line);
                                }
                            }
                        }
                        choose = 5;
                    }
                }
                else if (choose == 4)
                {
                    choose = 0;
                    newTime = new DateTime();
                        Console.WriteLine("Введите день рождения: ");
                        int newday = int.Parse(Console.ReadLine());
                        Console.WriteLine("Введите месяц рождения: ");
                        int newmonth = int.Parse(Console.ReadLine());
                        Console.WriteLine("Введите год рождения: ");
                        int newyear = int.Parse(Console.ReadLine());
                        newTime = new DateTime(newyear, newmonth, newday);
                    using (StreamWriter sw = new StreamWriter("newlol.txt", false))
                    {
                        using (StreamReader reader = new StreamReader(enter.path, true))
                        {
                            string? line;
                            while ((line = reader.ReadLine()) != null)
                            {
                                if (line == $"{enter.login} {enter.password} {enter.dateTime.ToShortDateString()}")
                                    sw.WriteLine($"{enter.login} {enter.password} {newTime.ToShortDateString()}");
                                else
                                    sw.WriteLine(line);
                            }
                        }
                    }
                    using (StreamWriter sw = new StreamWriter(enter.path, false))
                    {
                        using (StreamReader streamReader = new StreamReader("newlol.txt", true))
                        {
                            string? line;
                            while ((line = streamReader.ReadLine()) != null)
                            {
                                if (line == $"{enter.login} {enter.password} {enter.dateTime}")
                                    sw.WriteLine($"{enter.login} {enter.password} {newTime.ToShortDateString()}");
                                else
                                    sw.WriteLine(line);
                            }
                        }
                    }
                    choose = 5;
                }
            }
        }
    }
    class Enter
    {
        internal string path = "lolggg.txt";
        internal string login = "";
        internal string password = "";
        internal DateTime dateTime;
        int choose;
        public Enter()
        {
            Console.WriteLine("WELCOME\n1 - New Account\t2 - Login");
            choose = int.Parse(Console.ReadLine());
            while (choose != 99)
            {
                Console.WriteLine("Enter your login: ");
                login = Console.ReadLine();
                Console.WriteLine("Enter your password: ");
                password = Console.ReadLine();
                if (choose == 1)
                {
                    while (login.Length < 6 || password.Length < 6)
                    {
                        Console.WriteLine("Логин и пароль должны быть не меньше 6 символов");
                        Console.WriteLine("Enter your login: ");
                        login = Console.ReadLine();
                        Console.WriteLine("Enter your password: ");
                        password = Console.ReadLine();
                    }
                    choose = 3;
                    using (StreamReader reader = new StreamReader("lolggg.txt"))
                    {
                        string? line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            string[] ar = line.Split(' ');
                            if (ar[0] == login)
                            {
                                choose = 0;
                                Console.WriteLine("Такой пользователь уже существует");
                                Console.WriteLine("Хотите войти? 1 - Hет(продолжить регистрацию) 2 - Да: ");
                                choose = int.Parse(Console.ReadLine());
                            }
                        }
                    }
                    if (choose == 3)
                    {
                        using (StreamWriter d = new StreamWriter("lolggg.txt", true))
                        {
                            Registration();
                            d.WriteLine($"{login} {password} {dateTime.ToShortDateString()}");
                            choose = 99;
                        }
                    }
                }
                if (choose == 2)
                {
                    Check();
                }
            }
        }
        void Check()
        {
            using (StreamReader reader = new StreamReader("lolggg.txt"))
            {
                choose = 1;
                string? line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] ar = line.Split(' ');
                    if ($"{login} {password}" == $"{ar[0]} {ar[1]}")
                    {
                        dateTime = DateTime.Parse(ar[2]);
                        Console.WriteLine();
                        Console.WriteLine("Вы вошли в систему");
                        Console.WriteLine();
                        choose = 99;
                        break;
                    }
                    if (ar[0] == login)
                    {
                        choose = 2;
                        Console.WriteLine("Неверный пароль");
                    }
                }
                if (choose != 2 && choose != 99)
                {
                    Console.WriteLine("Пользователь не найден");
                    Console.WriteLine("Хотите пройти регистрацию? 1 - Да 2 - Нет(ввести другой логин): ");
                    choose = int.Parse(Console.ReadLine());
                }
            }
        }
        void Registration()
        {
            Console.WriteLine("Enter your birth date: ");
            int day = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your birth month: ");
            int month = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your birth year: ");
            int year = int.Parse(Console.ReadLine());
            dateTime = new DateTime(year, month, day);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
           
            
            
            Start start = new Start();
        }
    }
}