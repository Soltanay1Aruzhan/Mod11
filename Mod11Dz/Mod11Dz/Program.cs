using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeLib;

namespace Mod11Dz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeeManager manager = new EmployeeManager();

            Console.Write("Массив өлшемін енгізіңіз: ");
            int N = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            for (int i = 0; i < N; i++) 
            {
                Console.WriteLine($" {i+1} туралы ақпаратты көрсетіңіз");
                Console.Write("Аты: ");
                string fn = Console.ReadLine();
                Console.Write("Фамилию: ");
                string ln = Console.ReadLine();
                Console.Write("Жұмысқа қабылданған уақытың көрсетіңіз дд.ММ.гггг (день.месяц.год):");
                string d = Console.ReadLine();
                DateTime dob;
                while (!DateTime.TryParseExact(d, "dd.MM.yyyy", null, DateTimeStyles.None, out dob));
                Console.Write("Лауазымды енгізіңіз: ");
                string p = Console.ReadLine();
                Console.Write("Жынысын енгізініз(М/Ж): ");
                char g = Convert.ToChar(Console.ReadLine());
                Console.Write("Жалақысын енгізініз: ");
                int s = Convert.ToInt32(Console.ReadLine());
                manager.AddEmployee(new Employee { FName = fn, LName = ln, HireDate = dob, Position = p, Gender = g, Salary = s });
                Console.WriteLine();
            }

            // Выполнение задач
            Console.WriteLine("Барлық қызметкерлер туралы ақпаратты шығару; (функцияның шамадан тыс жүктелуін қолданған жөн ToString())");
            manager.AllEmployees();
            Console.WriteLine();
            Console.WriteLine("қызметкерлер, таңдалған лауазым туралы толық ақпаратты көрсетіңіз");
            manager.EmployeesByPosition("Менеджер");
            Console.WriteLine();
            Console.WriteLine("жалақысы барлық кеңсе қызметкерлерінің орташа жалақысынан асатын барлық менеджерлердің массивінен табыңыз, экранға осындай менеджерлер туралы толық ақпаратты олардың тегі бойынша сұрыптаңыз.");
            manager.ManagersAboveAvgClerkSalary();
            Console.WriteLine();
            Console.WriteLine("белгілі бір күннен кейін жұмысқа қабылданған барлық қызметкерлер туралы ақпаратты басып шығарыңыз (күнді пайдаланушы береді), қызметкердің тегі бойынша алфавиттік тәртіпте сұрыпталған.");
            manager.EmployeesHiredAfterDate(new DateTime(2022, 3, 1));
            Console.WriteLine();
            Console.WriteLine("Пайдаланушы не беретініне байланысты барлық ерлер, әйелдер туралы ақпаратты шығарыңыз. Пайдаланушы белгілі бір жынысты таңдамайтын жағдайды қарастырыңыз, яғни. барлығы туралы ақпарат алғысы келеді.");
            manager.EmployeesByGender('М');
        }
    }
}
