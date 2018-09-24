using System;
using BinaryTree;
using System.Collections;
using OneDimensionalArray;
namespace Nitshaiev_2
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(1992, 12, 12);
            DateTime dt2 = new DateTime(1994, 10, 13);
            DateTime dt3 = new DateTime(1996, 10, 15);
            DateTime dt4 = new DateTime(1993, 10, 17);
            DateTime dt5 = new DateTime(1994, 10, 20);
            DateTime dt6 = new DateTime(1997, 10, 4);
            DateTime dt7 = new DateTime(1994, 10, 3);
            DateTime dt8 = new DateTime(1993, 10, 2);
            DateTime dt9 = new DateTime(1992, 10, 8);
            Student ob = new Student("Pavel", dt, 50, "Math");
            Student ob2 = new Student("Masha", dt2, 65, "Math");
            Student ob3 = new Student("Maks", dt3, 25, "Math");
            Student ob4 = new Student("Michael", dt4, 20, "Math");
            Student ob5 = new Student("Dmitriy", dt5, 30, "Math");
            Student ob6 = new Student("Kesha", dt6, 90, "Math");
            Student ob7 = new Student("Lada", dt7, 100, "Math");
            Student ob8 = new Student("Sasha", dt8, 78, "Math");
            Student ob9 = new Student("Sergey", dt9, 65, "Math");
            Func<Student, Student, int> comparison = (student1, student2) => student1.Assessmant.CompareTo(student2.Assessmant);
            BinaryTree<Student> _tree = new BinaryTree<Student>
                (comparison);
            //BinaryTree<int> _tree = new BinaryTree<int>();
            //_tree.Add(10); _tree.Add(15); _tree.Add(7); _tree.Add(30); _tree.Add(25); _tree.Add(2); _tree.Add(9);
            _tree.Add(ob);
            _tree.Add(ob2);
            _tree.Add(ob3);
            _tree.Add(ob4);
            _tree.Add(ob5);
            _tree.Add(ob6);
            _tree.Add(ob7);
            _tree.Add(ob8);
            _tree.Added += _tree_Added;
            _tree.Add(ob9);

            IEnumerable tree = _tree;

            Console.WriteLine("In Deapth");
            foreach (var i in tree)
            {
                Console.WriteLine(i);
            }


            Console.ReadKey();

        }

        private static void _tree_Added(object sender, Student e)
        {
            Console.WriteLine("Was Added {0} ", e);
        }
        //OwnArray<int> array = new OwnArray<int>(-100, -80);
        //    Console.WriteLine(array.Length);
        //    for (int i = -100; i < -80; i++)
        //    {
        //        array[i] = i;
        //        Console.Write(array[i]);
        //    }
        //    Console.WriteLine();
        //    Console.WriteLine(array[-80]);
        //    Console.ReadLine();
        //}

    }
}

