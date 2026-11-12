
class Program
{
    static void Main()
    {
        // Создаём корректного студента.
        Student student = new Student("Алексей", "Лохмаев", 20, 4.5);

        Console.WriteLine(student.GetInfo());

        // Проверяем изменение возраста.
        student.SetAge(21);
        Console.WriteLine("Новый возраст: " + student.GetAge());

        // Проверяем недопустимый возраст.
        try
        {
            student.SetAge(200);
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine("Ошибка: " + ex.Message);
        }

        // Проверяем создание студента с неправильными данными.
        try
        {
            Student invalidStudent = new Student("Алексей", "", -3, 6);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Ошибка создания студента: " + ex.Message);
        }

        // Проверяем, что данные можно получить только через методы.
        Console.WriteLine(student.GetFullName());
    }
}
