using System;
using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7_1
{
    class Program
    {
        static void Main(string[] args)
        {//7.1.1
         //Console.WriteLine("Enter text:");
         //string str = Convert.ToString(Console.ReadLine());

            //var result = string.Concat(str.Split(new Char[] { ' ', ',', '.', '!', '?', ':', ';' }, StringSplitOptions.RemoveEmptyEntries).Select(word => word.Last()));
            //Console.WriteLine(result);
            //Console.ReadKey(true);

            //7.1.2
            //Console.WriteLine("Enter text:");
            //string str1 = Convert.ToString(Console.ReadLine());
            //int i = str1.IndexOf('O');
            //if (i == -1)
            //{
            //    Console.WriteLine("There is no such letter in the string");
            //}
            //else 
            //{
            //    Console.WriteLine(i);
            //}


            //7.1.3
            //Console.WriteLine("Enter text:");
            //string str2 = Convert.ToString(Console.ReadLine());
            //int count = str2.Count(Char.IsWhiteSpace);
            //Console.WriteLine(count);

            //7.1.4
            //string[] str3 = new string[5];
            //str3[0] = "Sergey";
            //str3[1] = "Olga";
            //str3[2] = "Vlad";
            //str3[3] = "Anna";
            //str3[4] = "Inna";
            //Array.Sort(str3);

            //foreach (string n in str3)
            //{ Console.WriteLine(n); }

            ////7.1.5
            //string str4 = "123. 345. 678.";
            //string[] str5 = str4.Split(new char[] { ' ' });

            //foreach (string s in str5)
            //{
            //    Console.WriteLine(s);
            //}

            ////7.1.6
            //int[] mass = new int[] {1, 2, 3, 4, 5, 6};

            //foreach(int i in mass)
            //{
            //    Console.Write(i);
            //}

            ////7.1.7
            //Console.WriteLine("Enter a string:");
            //string str6 = Convert.ToString(Console.ReadLine());
            //string str7 = str6.Substring(str6.Length - 1);

            //Console.WriteLine($"{str6}{str7}");

            //7.1.8
            //Console.WriteLine("Enter a string:");
            //string str8 = Convert.ToString(Console.ReadLine());

            //Console.WriteLine("Enter a char");
            //string ch = Convert.ToString(Console.ReadLine());

            //str8 = str8.Replace(ch,"");
            //Console.WriteLine(str8);

            //7.2

            //var listOfFavouriteSubject = new List <string> { "Math" };
            List<Student> students = new List<Student>
            {

             new Student{Name = "Pavel", Age = 21, GroupNumber = 4, Gender = "Male", listOfFavouriteSubject = new List <string> { "Math", "Chemistry" } },
             new Student{Name = "Anna", Age = 20, GroupNumber = 3, Gender = "Female",listOfFavouriteSubject = new List <string> { "Chemistry", "Physics" } },
             new Student{Name = "Viktop", Age = 19, GroupNumber = 2, Gender = "Male", listOfFavouriteSubject = new List <string> { "Physics", "History"} },
             new Student{Name = "Tina", Age = 18, GroupNumber = 6, Gender = "Female",listOfFavouriteSubject = new List <string> { "Geography", "Math", "Programming" } },
             new Student{Name = "Sergey", Age = 19, GroupNumber = 3, Gender = "Male", listOfFavouriteSubject = new List <string> { "Physics", "History", "Math", "Programming" } }
            };

            // 1
            //var studentsSergey = students.Where(m => m.Name == "Sergey").OrderBy(m => m.Name);
            //foreach (var n in studentsSergey)
            //{
            //    Console.WriteLine(n.ToString());
            //    string json = JsonConvert.SerializeObject(n, Formatting.Indented);
            //    Console.WriteLine(json);

            //}
            //2
            //var max = students.Max(m => m.Age);
            //var studentOld = students.Where(m => m.Age == max).OrderBy(m => m.Name);

            //foreach (var n in studentOld)
            //{
            //    Console.WriteLine(n.ToString());
            //    string json = JsonConvert.SerializeObject(n, Formatting.Indented);
            //    Console.WriteLine(json);

            //}
            //3
            //var moreThanTwoSubjects = students.Where(m => m.listOfFavouriteSubject.Count() > 2).OrderBy(m => m.Name);
            //foreach (var n in moreThanTwoSubjects)
            //{
            //    Console.WriteLine(n.ToString());
            //    string json = JsonConvert.SerializeObject(n, Formatting.Indented);
            //    Console.WriteLine(json);

            //}
            //4
            //var girlsLoveProgramming = students.Where(m => m.Gender == "Female" && m.listOfFavouriteSubject.Contains("Programming")).OrderBy(m => m.Name);
            //foreach (var n in girlsLoveProgramming)
            //{
            //    Console.WriteLine(n.ToString());
            //    string json = JsonConvert.SerializeObject(n, Formatting.Indented);
            //    Console.WriteLine(json);

            //}
            //5
            //List<List<Student>> subsCount = new List<List<Student>>();
            //List<string> subs = new List<string>();
            //students.ForEach(stud => stud.listOfFavouriteSubject.ForEach(sbj =>
            //{
            //    int i = subs.IndexOf(sbj);
            //    if (i == -1)
            //    {
            //        subs.Add(sbj);
            //        subsCount.Add(new List<Student>() { stud });
            //    }
            //    else
            //    {
            //        subsCount[i].Add(stud);
            //    }
            //}));
            //foreach (var s in subsCount)
            //{
            //    if (s.Count == 1)
            //        Console.WriteLine($"Student: {s[0]}; subject: ({subs[subsCount.IndexOf(s)]})");
            //}

            //6
            //var studentsSixGroup = students.Where(m => m.GroupNumber == 6).OrderBy(m => m.Name);

            //foreach (var n in studentsSixGroup)
            //{
            //    Console.WriteLine($"Name= {n.Name}, Age= {n.Age}");
            //    string json = JsonConvert.SerializeObject(n, Formatting.Indented);
            //    Console.WriteLine(json);
            //}

            //7
            //Console.WriteLine("Enter a subject (Math, History, Chemistry, Physics or Programming)");
            //string sub = Convert.ToString(Console.ReadLine());

            //Console.WriteLine($"Students who love {sub}:");
            //var studentsWhoLoveSub= students.Where(m => m.listOfFavouriteSubject.Contains(sub));
            //foreach (var n in studentsWhoLoveSub)
            //{
            //    Console.WriteLine(n);
            //    string json = JsonConvert.SerializeObject(n, Formatting.Indented);
            //    Console.WriteLine(json);
            //}

        }
    }
}
