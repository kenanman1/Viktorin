﻿using System;
using System.Collections.Generic;
using System.Linq;
class Programh
{
    public class Debtor
    {
        public Debtor(string fullname, DateTime birthDay, string phone, string email, string address, int debt)
        {
            this.FullName = fullname;
            this.BirthDay = birthDay;
            this.Phone = phone;
            this.Email = email;
            this.Address = address;
            this.Debt = debt;
        }

        public string FullName { get; set; }
        public DateTime BirthDay { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public int Debt { get; set; }
        public override string ToString()
        {
            return $"{this.FullName} {this.BirthDay.ToShortDateString()} {this.Phone} {this.Email} {this.Address} {this.Debt}";
        }
    }
    static void Main()
    {
        List<Debtor> debtors = new List<Debtor> {
            new Debtor("Shirley T. Qualls", DateTime.Parse("March 30, 1932"), "530-662-7732", "ShirleyTQualls@teleworm.us", "3565 Eagles Nest Drive Woodland, CA 95695", 2414),
            new Debtor("Danielle W. Grier", DateTime.Parse("October 18, 1953"), "321-473-4178", "DanielleWGrier@rhyta.com", "1973 Stoneybrook Road Maitland, FL 32751", 3599),
            new Debtor("Connie W. Lemire", DateTime.Parse("June 18, 1963"), "828-321-3751", "ConnieWLemire@rhyta.com", "2432 Hannah Street Andrews, NC 28901", 1219),
            new Debtor("Coy K. Adams", DateTime.Parse("March 1, 1976"), "410-347-1307", "CoyKAdams@dayrep.com", "2411 Blue Spruce Lane Baltimore, MD 21202", 3784),
            new Debtor("Bernice J. Miles", DateTime.Parse("June 1, 1988"), "912-307-6797", "BerniceJMiles@armyspy.com", "4971 Austin Avenue Savannah, GA 31401", 4060),
            new Debtor("Bob L. Zambrano", DateTime.Parse("February 28, 1990"), "706-446-1649", "BobLZambrano@armyspy.com", "2031 Limer Street Augusta, GA 30901", 6628),
            new Debtor("Adam D. Bartlett", DateTime.Parse("May 6, 1950"), "650-693-1758", "AdamDBartlett@rhyta.com", "2737 Rardin Drive San Jose, CA 95110", 5412),
            new Debtor("Pablo M. Skinner", DateTime.Parse("August 26, 1936"), "630-391-2034", "PabloMSkinner@armyspy.com", "16 Fraggle Drive Hickory Hills, IL 60457", 11097),
            new Debtor("Dorothy J. Brown", DateTime.Parse("July 9, 1971"), "270-456-3288", "DorothyJBrown@rhyta.com", "699 Harper Street Louisville, KY 40202", 7956),
            new Debtor("Larry A. Miracle", DateTime.Parse("May 22, 1998"), "301-621-3318", "LarryAMiracle@jourrapide.com", "2940 Adams Avenue Columbia, MD 21044", 7150),
            new Debtor("Donna B. Maynard", DateTime.Parse("January 26, 1944"), "520-297-0575", "DonnaBMaynard@teleworm.us", "4821 Elk Rd Little Tucson, AZ 85704", 2910),
            new Debtor("Jessica J. Stoops", DateTime.Parse("April 22, 1989"), "360-366-8101", "JessicaJStoops@dayrep.com", "2527 Terra Street Custer, WA 98240", 11805),
            new Debtor("Audry M. Styles", DateTime.Parse("February 7, 1937"), "978-773-4802", "AudryMStyles@jourrapide.com", "151 Christie Way Marlboro, MA 01752", 1001),
            new Debtor("Violet R. Anguiano", DateTime.Parse("November 4, 1958"), "585-340-7888", "VioletRAnguiano@dayrep.com", "1460 Walt Nuzum Farm Road Rochester, NY 14620", 9128),
            new Debtor("Charles P. Segundo", DateTime.Parse("October 21, 1970"), "415-367-3341", "CharlesPSegundo@dayrep.com", "1824 Roosevelt Street Fremont, CA 94539", 5648),
            new Debtor("Paul H. Sturtz", DateTime.Parse("September 15, 1944"), "336-376-1732", "PaulHSturtz@dayrep.com", "759 Havanna Street Saxapahaw, NC 27340", 10437),
            new Debtor("Doris B. King", DateTime.Parse("October 10, 1978"), "205-231-8973", "DorisBKing@rhyta.com", "3172 Bedford Street Birmingham, AL 35203", 7230),
            new Debtor("Deanna J. Donofrio", DateTime.Parse("April 16, 1983"), "952-842-7576", "DeannaJDonofrio@rhyta.com", "1972 Orchard Street Bloomington, MN 55437", 515),
            new Debtor("Martin S. Malinowski", DateTime.Parse("January 17, 1992"), "765-599-3523", "MartinSMalinowski@dayrep.com", "3749 Capitol Avenue New Castle, IN 47362", 1816),
            new Debtor("Melissa R. Arner", DateTime.Parse("May 24, 1974"), "530-508-7328", "MelissaRArner@armyspy.com", "922 Hill Croft Farm Road Sacramento, CA 95814", 5037),
            new Debtor("Kelly G. Hoffman", DateTime.Parse("September 22, 1969"), "505-876-8935", "KellyGHoffman@armyspy.com", "4738 Chapmans Lane Grants, NM 87020", 7755),
            new Debtor("Doyle B. Short", DateTime.Parse("June 15, 1986"), "989-221-4363", "DoyleBShort@teleworm.us", "124 Wood Street Saginaw, MI 48607", 11657),
            new Debtor("Lorrie R. Gilmore", DateTime.Parse("December 23, 1960"), "724-306-7138", "LorrieRGilmore@teleworm.us", "74 Pine Street Pittsburgh, PA 15222", 9693),
            new Debtor("Lionel A. Cook", DateTime.Parse("April 16, 1972"), "201-627-5962", "LionelACook@jourrapide.com", "29 Goldleaf Lane Red Bank, NJ 07701", 2712),
            new Debtor("Charlene C. Burke", DateTime.Parse("January 18, 1990"), "484-334-9729", "CharleneCBurke@armyspy.com", "4686 Renwick Drive Philadelphia, PA 19108", 4016),
            new Debtor("Tommy M. Patton", DateTime.Parse("June 30, 1981"), "774-571-6481", "TommyMPatton@rhyta.com", "748 Rockford Road Westborough, MA 01581", 349),
            new Debtor("Kristin S. Bloomer", DateTime.Parse("June 16, 1944"), "443-652-0734", "KristinSBloomer@dayrep.com", "15 Hewes Avenue Towson, MD 21204", 9824),
            new Debtor("Daniel K. James", DateTime.Parse("November 10, 1997"), "801-407-4693", "DanielKJames@rhyta.com", "3052 Walton Street Salt Lake City, UT 84104", 8215),
            new Debtor("Paula D. Henry", DateTime.Parse("September 6, 1976"), "618-378-5307", "PaulaDHenry@rhyta.com", "3575 Eagle Street Norris City, IL 62869", 5766),
            new Debtor("Donna C. Sandoval", DateTime.Parse("December 13, 1947"), "540-482-5463", "DonnaCSandoval@rhyta.com", "675 Jehovah Drive Martinsville, VA 24112", 8363),
            new Debtor("Robert T. Taylor", DateTime.Parse("August 17, 1932"), "270-596-6442", "RobertTTaylor@armyspy.com", "2812 Rowes Lane Paducah, KY 42001", 7785),
            new Debtor("Donna W. Alamo", DateTime.Parse("December 9, 1948"), "978-778-2533", "DonnaWAlamo@teleworm.us", "4367 Christie Way Marlboro, MA 01752", 10030),
            new Debtor("Amy R. Parmer", DateTime.Parse("May 19, 1995"), "480-883-4934", "AmyRParmer@armyspy.com", "85 Elmwood Avenue Chandler, AZ 85249", 5347),
            new Debtor("Newton K. Evans", DateTime.Parse("October 8, 1986"), "303-207-9084", "NewtonKEvans@rhyta.com", "3552 Columbia Road Greenwood Village, CO 80111", 9838),
            new Debtor("Kathleen C. Chaney", DateTime.Parse("January 5, 1949"), "605-245-3513", "KathleenCChaney@rhyta.com", "316 Elsie Drive Fort Thompson, SD 57339", 1672),
            new Debtor("Manuel C. Johnson", DateTime.Parse("February 23, 1957"), "606-247-2659", "ManuelCJohnson@jourrapide.com", "4146 May Street Sharpsburg, KY 40374", 9195),
            new Debtor("Carla A. Creagh", DateTime.Parse("November 21, 1988"), "614-307-8974", "CarlaACreagh@dayrep.com", "3106 Bates Brothers Road Columbus, OH 43215", 11271),
            new Debtor("Norma M. New", DateTime.Parse("May 18, 1988"), "857-492-8703", "NormaMNew@jourrapide.com", "965 Metz Lane Woburn, MA 01801", 9761),
            new Debtor("Roy D. Green", DateTime.Parse("January 27, 1983"), "308-340-5981", "RoyDGreen@jourrapide.com", "401 Romrog Way Grand Island, NE 68801", 10771),
            new Debtor("Cristy J. Jensen", DateTime.Parse("November 2, 1935"), "440-626-9550", "CristyJJensen@jourrapide.com", "2177 Harley Vincent Drive Cleveland, OH 44113", 5205),
            new Debtor("Nancy J. Fergerson", DateTime.Parse("June 10, 1993"), "219-987-8498", "NancyJFergerson@dayrep.com", "3584 Jadewood Drive Demotte, IN 46310", 1276),
            new Debtor("Dave N. Rodriguez", DateTime.Parse("January 21, 1938"), "214-540-2499", "DaveNRodriguez@rhyta.com", "1890 Poco Mas Drive Dallas, TX 75247", 9132),
            new Debtor("James E. Denning", DateTime.Parse("May 4, 1988"), "504-289-8640", "JamesEDenning@jourrapide.com", "1444 Rose Avenue Metairie, LA 70001", 8176),
            new Debtor("Richard M. Thomas", DateTime.Parse("February 13, 1972"), "510-735-3359", "RichardMThomas@jourrapide.com", "4454 Green Avenue Oakland, CA 94609", 7875),
            new Debtor("Lakisha R. Forrest", DateTime.Parse("December 1, 1973"), "334-830-1181", "LakishaRForrest@armyspy.com", "3121 Quarry Drive Montgomery, AL 36117", 3088),
            new Debtor("Pamela H. Beauchamp", DateTime.Parse("November 20, 1959"), "801-559-6347", "PamelaHBeauchamp@jourrapide.com", "3239 Tori Lane Salt Lake City, UT 84104", 6588)
        };
        //  1. Вывести тех должников, имя которых начинается на гласную букву.
        var a = debtors.Where(p => p.FullName.StartsWith('Q') || p.FullName.StartsWith('R') || p.FullName.StartsWith('T')
        || p.FullName.StartsWith('Y') || p.FullName.StartsWith('P') || p.FullName.StartsWith('S') || p.FullName.StartsWith('D')
        || p.FullName.StartsWith('F') || p.FullName.StartsWith('G') || p.FullName.StartsWith('H') || p.FullName.StartsWith('J')
        || p.FullName.StartsWith('K') || p.FullName.StartsWith('L') || p.FullName.StartsWith('Z') || p.FullName.StartsWith('X')
        || p.FullName.StartsWith('C') || p.FullName.StartsWith('V') || p.FullName.StartsWith('B') || p.FullName.StartsWith('N')
        || p.FullName.StartsWith('M'));
        //  2. Вывести тех должников, имеющих почту в домене rhyta.com или dayrep.com
        var b = debtors.Where(p => p.Email.Contains("rhyta.com") || p.Email.Contains("dayrep.com"));
        //  3. Вывести тех должников в возрасте от 26 до 36 лет.
        var c = debtors.Where(p => p.BirthDay < new DateTime(1995, 01, 01) && p.BirthDay > new DateTime(1985, 01, 01));
        //  4. Вывести тех должников, сумма долга которых не превышает 5000.
        var d = from u in debtors where u.Debt < 5000 select u;
        //  5. Вывести тех должников, полное имя которых длиннее 18 символов, и номер телефона которых содержит 2 или больше семерок.
        var e = debtors.Where(d => d.FullName.Length >= 18);
        List<string> vs = new List<string>();
        List<string> vs2 = new List<string>();
        foreach (var item in e)
        {
            vs.Add(item.Phone);
        }
        for (int id = 0; id < vs.Count(); id++)
        {
            int count = 0;
            foreach (var item in vs[id])
            {
                if (item == '7')
                    count++;
            }
            if (count >= 2)
                vs2.Add(vs[id]);
        }
        e = from dd in debtors from cc in vs2
            where dd.FullName.Length >= 18 && dd.Phone.Contains(cc)
            select dd;
        //  6. Вывести тех должников, возраст которых - четное число, отсортировав по сумме цифр года рождения.
        var f = debtors.Where(p => p.BirthDay.Year % 2 == 0).OrderBy(p => p.BirthDay.Year);
        //  7. Вывести тех должников, родившихся зимой, отсортировав по почтовому индексу (5 цифр в конце адреса).
        var g = debtors.Where(p => p.BirthDay.Month < 03 || p.BirthDay.Month == 12).OrderBy(p => p.Address);
        //  8. Вывести тех должников, сумма долга которых превышает среднюю сумму долга по всем должникам, отсортировав их сначала по фамилии, затем по убыванию суммы долга.
        var h = debtors.Where(p => p.Debt > debtors.Average(p => p.Debt)).OrderBy(p => p.FullName).OrderByDescending(p => p.Debt);
        //  9. Вывести только фамилии, возраст и суммы долга всех должников, в номере телефона которых отсутствуют восьмерки.
        var i = debtors.Where(p => p.Phone.Contains('8'));
        var i2 = debtors.Except(i);
        // 10. Вывести должника, у которого самая длинная фамилия среди должников с самым коротким именем.
        var j = from jj in debtors select jj;
        List<string> list = new List<string>();
        string[] names = new string[3];
        int lengname = 10;
        int lengsurn = 0;
        foreach (var item in j)
        {
            names = item.FullName.Split(' ');
            if (names[0].Length < lengname)
                lengname = names[0].Length;
        }
        foreach (var item in j)
        {
            names = item.FullName.Split(' ');
            if (names[0].Length == lengname && names[2].Length > lengsurn)
                lengsurn = names[2].Length;
        }
        foreach (var item in j)
        {
            names = item.FullName.Split(' ');
            if (names[0].Length == lengname && names[2].Length == lengsurn)
                list.Add($"{names[0]} {names[1]} {names[2]}");
        }
        j = from jj in debtors from jjj in list
            where jj.FullName.Contains(jjj) select jj;
        // 11. Вывести должников, у которых в имени и фамилии есть хотя бы 3 одинаковые буквы, отсортировав их в алфавитном порядке по среднему имени.
        // не получилось
        // 12. Вывести самый популярный почтовый домен среди должников.
        List<string> domens = new List<string>();
        List<int> win = new List<int>();
        var l = from ll in debtors select ll.Email;
        string mostpopular = "";
        foreach (var item in l)
        {
            int check = 0;
            string []ar = item.Split('@');
            foreach (var item2 in domens)
            {
                if (item2 == ar[1])
                    check++;
            }
            if (check == 0)
                domens.Add(ar[1]);
        }
        foreach (var item in domens)
        {
            win.Add(0);
        }
        foreach (var item in l)
        {
            string[] ar = item.Split('@');
            for (int ir = 0; ir < domens.Count(); ir++)
            {
                if (ar[1] == domens[ir])
                {
                    win[ir] = (win[ir]) + 1;
                }
            }
        }
        mostpopular = domens[win.IndexOf(win.Max())];
        // 13. Вывести год, в который родилось наибольшее количество должников.
        List<int> years = new List<int>();
        List<int> wins = new List<int>();
        int mostpopularyear = 0;
        var m = from mm in debtors select mm.BirthDay.Year;
        foreach (var item in m)
        {
            int check = 0;
            foreach (var item2 in years)
            {
                if (item2 == item)
                    check++;
            }
            if (check == 0)
                years.Add(item);
        }
        foreach (var item in years)
        {
            wins.Add(0);
        }
        foreach (var item in m)
        {
            for (int ir = 0; ir < years.Count(); ir++)
            {
                if (item == years[ir])
                {
                    wins[ir] = (wins[ir]) + 1;
                }
            }
        }
        mostpopularyear = years[wins.IndexOf(wins.Max())];
        // 14. Вывести Топ-5 должников по сумме долга.
        var n = debtors.OrderByDescending(p => p.Debt).Take(5);
        // 15. Вывести общую сумму долга всех должников.
        var o = debtors.Sum(p => p.Debt);
        // 16. Вывести имена и фамилии людей, переживших Вторую Мировую Войну.
        var p = debtors.Where(f => f.BirthDay > new DateTime(1939, 01, 09));
        // 17. Вывести фамилии и возраст людей, родившихся после развала СССР.
        var q = debtors.Where(p => p.BirthDay > new DateTime(1991, 26, 12));
        // 18. Вывести номера телефона и суммы долга людей, в номере телефона которых нет повторяющихся цифр.
        var r = from rr in debtors select rr.Phone;
        List<string> nam = new List<string>();
        List<string> nam2 = new List<string>();
        foreach (var item in r)
        {
            nam.Add(item);
        }
        for (int count = 0; count < nam.Count(); count++)
        {
            string str = nam[count];
            int check = 0;
            for (int c1 = 0, c2 = 1; c1 < str.Length - 1 || c2 < str.Length; c1++, c2++)
            {
                if (str[c1] == str[c2])
                    check++;
            }
            if (check == 0)
            {
                nam2.Add(str);
            }
        }
        var r2 = from rr in debtors from rrr in nam2
            where rr.Phone.Contains(rrr) select rr;
        // 19. Представим, что все должники начали отдавать свои долги с текущего дня по 500 каждый месяц.
        //     Вывести на экран список должников, которые успеют отдать долг до своего следующего дня рождения.
        DateTime dateTime = new DateTime(2022, 05, 17);
        List<string> vs1 = new List<string>();
        var s = from ss in debtors select ss;
        foreach (var item in s)
        {
            DateTime dateTime1 = new DateTime(item.BirthDay.Year, item.BirthDay.Month, item.BirthDay.Day);
            int time = 0;
            if (dateTime.Month > dateTime1.Month)
                time = dateTime.Month - dateTime1.Month;
            else if (dateTime.Month < dateTime1.Month)
                time = (dateTime1.Month - dateTime.Month);
            if (time * 500 > item.Debt)
                vs1.Add(item.FullName);
        }
        s = from ss in debtors from sss in vs1
            where ss.FullName.Contains(sss)
            select ss;
        // 20. Вывести тех должников, из букв имени и фамилии которых можно собрать слово "smile".
        var t = debtors.Where(p => p.FullName.Contains('s') && p.FullName.Contains('m') && p.FullName.Contains('i') &&
        p.FullName.Contains('l') && p.FullName.Contains('e'));
        // Максимально используйте LINQ.
        // https://metanit.com/sharp/tutorial/15.1.php
        // https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/linq/
    }
}