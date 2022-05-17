using System;
namespace examen
{
    class History : Lessons
    {
        List<string> userspoints = new List<string>();
        public History(string login, List<int> point, List<string> users)
        {
            answer = new string[10];
            Questions();
            Game(login, point, users);
        }
        public History(List<string> randquest, List<int> randansw)
        {
            answer = new string[10];
            Questions();
            Rand(randquest, randansw);
        }
        public void Rand(List<string> randquest, List<int> randansw)
        {
            int i = 0;
            int ok = 0;
            List<int> chg = new List<int>();
            Random random = new Random();
            while (i < 3)
            {
                int irr = random.Next(0, 5);
                if (chg.Contains(irr))
                    ok = 1;
                if (ok == 0)
                {
                    randquest.Add(questions[irr]);
                    randansw.Add(answers[irr]);
                    chg.Add(irr);
                    i++;
                }
                ok = 0;
            }
        }
        public void Game(string login, List<int> point, List<string> users)
        {
            Console.WriteLine("Викторина по Истории (Если есть 2 ответа то вводите их через пробел)");
            Console.WriteLine();
            int i = 0;
            while (i < 5)
            {
                try
                {
                    Console.WriteLine(questions[i]);
                    choosestr = Console.ReadLine();
                    if (choosestr.Length < 2)
                    {
                        choose = int.Parse(choosestr);
                        if (choose == answers[i])
                            points++;
                        i++;
                    }
                    else if (choosestr.Length == 3)
                    {
                        answer = choosestr.Split(' ');
                        choosestr = answer[0] + answer[1];
                        choose = int.Parse(choosestr);
                        if (choose == answers[i])
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
            List<string> users2 = users;
            List<int> point2 = point;
            Console.WriteLine($"Your points = {points}");
            Console.WriteLine();
            using (StreamWriter sw = new StreamWriter("results.txt", true))
            {
                sw.WriteLine($"Викторина по истории: {login} - {points} points");
                users.Add(login);
                point.Add(points);
            }
            using (StreamReader streamReader = new StreamReader("top20history.txt", true))
            {
                int h = 0;
                int j = 0;
                string? line;
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
            using (StreamWriter streamWriter = new StreamWriter("top20history.txt", false))
            {
                int h = 5;
                int k = point2.Count();
                for (int j = 0; j < k;)
                {
                    while (point2.Contains(h))
                    {
                        int d = point2.FindIndex(p => p == h);
                        userspoints.Add($"{users2[d]} {point2[d]}");
                        streamWriter.WriteLine(userspoints[j]);
                        users2.RemoveAt(d);
                        point2.RemoveAt(d);
                        j++;
                    }
                    h--;
                }
            }
        }
        public override void Questions()
        {
            questions.Add("В каком году появилась Атропатена: 1) 543  2) 382  3) 323: ");
            answers.Add(3);
            questions.Add("В каком году родился Юлий Цезарь: 1) 37  2) 100  3) 192: ");
            answers.Add(2);
            questions.Add("В каком году образовалась АДР: 1) 1918  2) 1982  3) 2000");
            answers.Add(1);
            questions.Add("В честь кого было названа римская империя: 1) Ромул  2) Рем  3) Октавиан Август");
            answers.Add(1);
            questions.Add("Что из перечисленного относится к Мехмету 2: 1) Захватил Константенопль  2) Правил с 1451-1481  3) Убил своего отца");
            answers.Add(12);
        }
    }
}