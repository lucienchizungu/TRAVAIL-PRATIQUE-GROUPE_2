﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP2.Abstract;
using System.Data.SqlClient;
using TP2.Connection;
using System.Data;
using MySql.Data.MySqlClient;

namespace TP2
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("ABSTRACT CLASS");
            Console.WriteLine("===============\n");
<<<<<<< HEAD
            Teacher t1 = new Teacher("amani", "ntingingwa", "22lsi620060");
            Student s1 = new Student("josue", "ntj", "22lsi75664");
=======
            Teacher t1 = new Teacher("AWEZAYE", "CHIZUNGU", "22LSILJ619977");
            Student s1 = new Student("Liripa", "Kpak", "22lsi657744");
>>>>>>> master

            t1.Add(2);
            s1.Add(2);

            t1.show(1,2);
            Console.WriteLine("\n===============\n");
            s1.show(1,2);

            Console.WriteLine("\n===============\n");


            Console.WriteLine("INTERFACE ");
            Console.WriteLine("===============\n");

            Interfaces.Teacher t2 = new Interfaces.Teacher("Justine", "saba", "hhfydyd");
            Interfaces.Student s2 = new Interfaces.Student("Jean", "mali", "22lsij65774");

            t2.Add(2);
            s2.Add(2);

            t2.show(2,2);
            Console.WriteLine("\n===============\n");
            s2.show(2,2);

            Console.WriteLine("\n===============\n");



            Console.ReadLine();

        }
    }
}
