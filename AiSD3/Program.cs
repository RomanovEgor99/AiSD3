using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AiSD3
{
    class Program
    {
        static void Main(string[] args)
        {

            Student student = new Student();
            Student[] arrayOfStudens = new Student[4];
            student.InputInfo();
            student.InputUintArray();
            student.OutputInfo();
            student.OutputUintArray();
            for (int i = 0; i < arrayOfStudens.Length; i++)
            {
                arrayOfStudens[i].InputInfo();
                arrayOfStudens[i].InputUintArray();

            }

            for (int i = 0; i < arrayOfStudens.Length; i++)
            {

                arrayOfStudens[i].OutputInfo();
                arrayOfStudens[i].OutputUintArray();
            }




            Console.ReadLine();


        }




    }

    struct Student
    {
        public Char[] lastName;
        public Char[] firstName;
        public int id;
        public uint[] uintNum;

        public Student(Char[] arrLastName, Char[] arrFirstName, int studentId, uint[] arrUint)
        {
            lastName = arrLastName;
            firstName = arrFirstName;
            id = studentId;
            uintNum = arrUint;

        }


        public void InputUintArray()
        {
            uint[] newUint = new uint[4];
            Console.WriteLine("Ввод массива беззнаковых чисел.");


            for (int k = 0; k < 4; k++)
            {

                Console.WriteLine("Введите число №{0}:", k + 1);
                newUint[k] = Convert.ToUInt32(Console.ReadLine());

            }

            uintNum = newUint;

        }
        public void OutputUintArray()
        {
            Console.WriteLine("Массив беззнаковых чисел");
            for (int k = 0; k < uintNum.Length; k++)
            {
                Console.Write("{0}", uintNum[k]);

            }
            Console.WriteLine("\n");
        }
        public void InputInfo()
        {
            Console.WriteLine("Введите Фамилию студента:");
            string lastNameStr = Console.ReadLine();

            lastName = lastNameStr.ToCharArray(0, lastNameStr.Length);

            Console.WriteLine("Введите имя студента");
            string firstNameStr = Console.ReadLine();

            firstName = firstNameStr.ToCharArray(0, firstNameStr.Length);

            Console.WriteLine("Введите id студента:");
            id = Convert.ToInt32(Console.ReadLine());

        }
        public void OutputInfo()
        {
            Console.Write("Фамилия: ");
            for (int i = 0; i < lastName.Length; i++)
                Console.Write(lastName[i]);
            Console.WriteLine();

            Console.Write("Имя: ");
            for (int i = 0; i < firstName.Length; i++)
                Console.Write(firstName[i]);
            Console.WriteLine();
            Console.WriteLine("Id: {0}", id);


        }


    }

}

