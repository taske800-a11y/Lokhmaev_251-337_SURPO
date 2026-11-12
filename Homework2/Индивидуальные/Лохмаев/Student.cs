
public class Student
{
    // Закрытые поля — напрямую обратиться к ним извне нельзя.
    private string firstName;
    private string lastName;
    private int age;
    private double averageMark;

    public Student(string firstName, string lastName, int age, double averageMark)
    {
        // Проверяем входные данные.
        if (string.IsNullOrWhiteSpace(firstName))
            throw new ArgumentException("Имя не может быть пустым.");

        if (string.IsNullOrWhiteSpace(lastName))
            throw new ArgumentException("Фамилия не может быть пустой.");

        ValidateAge(age);
        ValidateAverageMark(averageMark);

        // Если проверки пройдены, записываем данные.
        this.firstName = firstName;
        this.lastName = lastName;
        this.age = age;
        this.averageMark = averageMark;
    }

    // Возвращает полное имя студента.
    public string GetFullName()
    {
        return $"{firstName} {lastName}";
    }

    // Возвращает возраст.
    public int GetAge()
    {
        return age;
    }

    // Возвращает средний балл.
    public double GetAverageMark()
    {
        return averageMark;
    }

    // Изменяет возраст только после проверки.
    public void SetAge(int newAge)
    {
        ValidateAge(newAge);
        age = newAge;
    }

    // Возвращает всю информацию об одном студенте.
    public string GetInfo()
    {
        return $"Студент: {GetFullName()}, возраст: {age}, средний балл: {averageMark:F2}";
    }

    // Проверка допустимого возраста.
    private static void ValidateAge(int age)
    {
        if (age < 14 || age > 100)
            throw new ArgumentOutOfRangeException(
                nameof(age), "Возраст должен быть от 14 до 100 лет.");
    }

    // Проверка среднего балла.
    private static void ValidateAverageMark(double averageMark)
    {
        if (double.IsNaN(averageMark) || double.IsInfinity(averageMark) ||
            averageMark < 0 || averageMark > 5)
            throw new ArgumentOutOfRangeException(
                nameof(averageMark), "Средний балл должен быть от 0 до 5.");
    }
}
