// PrintHeader();
// PrintHeader();
// Console.WriteLine("Основная часть программы");
// PrintFooter();

// void PrintHeader()
// {
//     Console.WriteLine("^_^");
//     Console.WriteLine("Дата формирования отчёта 13:00 12.11.26");
//     Console.WriteLine("Лабораторная работа №13");
//     Console.WriteLine("0_0");
// }

// void PrintFooter()
// {
//     Console.WriteLine(">_<");
//     Console.WriteLine("   Конец программы");
//     Console.WriteLine("X_X");
// }

// void PrintStudentCard(string name, int age, string group)
// {
//     Console.WriteLine($"Студент: {name}, возраст: {age}, номер группы: {group}");
// }

// PrintStudentCard("Егор", 18, "Третья");
// PrintStudentCard("Валерия", 17, "Вторая");

// double CalculateShoolarship(double baseAmount, double bonusPercent)
// {
//     return baseAmount + baseAmount * bonusPercent / 100;
// }

// bool isEligibleForBonus(double averageGrade)
// {
//     return (averageGrade >= 4.5) == true;
// }
// if (isEligibleForBonus(4.6) == true)
// {
//     double result = CalculateShoolarship(2000, 15);
//     bool extra = isEligibleForBonus(4.6);
//     Console.WriteLine(result);
// }
// else
// {
//     double result = CalculateShoolarship(2000, 15);
// Console.WriteLine(result);
// }

double CalculateAverageGrade(int[] grades)
{
    int sum = 0;
    foreach (int grade in grades)
    {
        sum += grade;
    }
    return (double)sum / grades.Length;
}

int CountFives(int[] grades) {
        int count = 0;
        foreach (int grade in grades) {
            if (grade == 5) {
                count++;
            }
        }
        return count;
    }

int[] grades = { 4, 5, 3, 5, 4 };
double average = CalculateAverageGrade(grades);
int fcount = CountFives(grades);
Console.WriteLine(fcount);
Console.WriteLine(average);
