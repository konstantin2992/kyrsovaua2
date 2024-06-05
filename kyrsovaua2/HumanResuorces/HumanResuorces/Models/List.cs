using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace HumanResuorces.Models
{
    public class List
    {
        public List() {
            Employees = new List<Employee>();
         
        }
        public List<Employee> Employees { get; set; }

        void FillWithTestData(int n)
        {
            Employees.Clear();
            for (int i = 0; i < n; i++)
            {
                Employees.Add(new Employee
                {
                    Passport = $"Passport{i}",
                    Name = $"Name{i}",
                    Ededucation = $"Ededucation{i}",
                    Specialty = $"Specialty{i}",
                    Department = $"Department{i}",
                    Position = $"Position{i}",
                    Salary = i * 1000,
                    DOE = DateTime.Now.AddYears(-i),
                    DLA = DateTime.Now.AddYears(-i / 2),
                    BirthDate = DateTime.Now.AddYears(-30 - i) // 30 + i years old
                });
            }
        }

        public List<Employee> Search(string name, string passport)
        {
            var result = new List<Employee>();

            // Ітерація по всіх співробітниках у списку Employees
            foreach (var b in Employees)
            {
                // Перевірка чи співробітник відповідає критеріям пошуку
                if (b.Name.Contains(name) &&
                    b.Passport.ToString().Contains(passport))
                {
                    // Додавання співробітника до результатів пошуку
                    result.Add(b);
                }
            }
            // Повернення результатів пошуку
            return result;
        }
        // Метод для збереження даних у файл
        public void SaveData(string path)
        {
            // Серіалізація об'єкта List у JSON-рядок
            var jsonString = JsonSerializer.Serialize(this);
            // Запис JSON-рядка у файл
            File.WriteAllText(path, jsonString);
        }

        // Метод для завантаження даних з файлу
        public List LoadData(string path)
        {
            // Читання JSON-рядка з файлу
            var jsonString = File.ReadAllText(path);
            // Десеріалізація JSON-рядка у об'єкт List
            return JsonSerializer.Deserialize<List>(jsonString);
        }
        public List<Employee> SelectForRetirement(int retirementAge)
        {
            var now = DateTime.Now;
            return Employees.Where(e => (now.Year - e.BirthDate.Year) >= retirementAge).ToList();
        }
        public string GenerateOrder(Employee employee, string orderType)
        {
            var sb = new StringBuilder(); // Використання StringBuilder для створення тексту наказу
            sb.AppendLine($"Наказ №{new Random().Next(1000, 9999)}"); // Додавання випадкового номера наказу
            sb.AppendLine($"Дата: {DateTime.Now.ToShortDateString()}"); // Додавання поточної дати
            sb.AppendLine($"Тип наказу: {orderType}"); // Додавання типу наказу
            sb.AppendLine($"ПІБ: {employee.Name}"); // Додавання ПІБ співробітника
            sb.AppendLine($"Паспорт: {employee.Passport}"); // Додавання паспорта співробітника
            sb.AppendLine($"Підрозділ: {employee.Department}"); // Додавання підрозділу співробітника
            sb.AppendLine($"Посада: {employee.Position}"); // Додавання посади співробітника
            sb.AppendLine($"Оклад: {employee.Salary}"); // Додавання окладу співробітника
            sb.AppendLine($"Дата прийняття: {employee.DOE.ToShortDateString()}"); // Додавання дати прийняття на роботу
            sb.AppendLine($"Дата останнього призначення: {employee.DLA.ToShortDateString()}"); // Додавання дати останнього призначення
            return sb.ToString(); // Повернення згенерованого тексту наказу
        }
    }
}
