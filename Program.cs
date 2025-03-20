int[] salary = new int[12];
int sum = 0;
double avg, pensiya = 0, deviations = 0;
int max_salary = 0, min_salary = 5000;
int max_month = 0, min_month = 0;

Random random = new();

for (int i = 0; i < salary.Length; i++)
{
    salary[i] = random.Next(1000, 5001);
    sum += salary[i];
    if (salary[i] > max_salary)
    {
        max_salary = salary[i];
        max_month = i;
    }
    if (salary[i] < min_salary)
    {
        min_salary = salary[i];
        min_month = i;
    }
}

pensiya = sum * 0.02;
avg = sum / salary.Length;
Math.Round(avg, 2);
Console.WriteLine($"Средняя зарплата: ${avg}\n");

string[] monthes = ["Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь"];

Console.WriteLine("| {0, -8} | {1, -9} | {2, -26} | {3, -30}", "Месяц", "Зарплата", "Отложение в пенсионный фонд", "Отклонение от средней зарплаты");
Console.WriteLine("|----------|-----------|-----------------------------|---------------------------------");

for (int i = 0; i < salary.Length; i++)
{
    Console.Write("| {0, -8} | ${1, -8} | ${2, -26} | ", monthes[i], salary[i], Math.Round(salary[i] * 0.02));

    if ((salary[i] - avg) > 0)
        Console.WriteLine("+${0, -30}", salary[i] - avg);
    else if ((salary[i] - avg) < 0)
        Console.WriteLine("-${0, -30}", avg - salary[i]);
    else if ((salary[i] - avg) == 0)
        Console.WriteLine("{0, -30}", "нет");
    pensiya += salary[i] * 0.02;
}

Console.WriteLine($"\n{monthes[max_month]} ${max_salary} - максимальная зарплата");
Console.WriteLine($"{monthes[min_month]} ${min_salary} - минимальная зарплата");
Console.WriteLine($"Общее отложение в пенсионный фонд: ${Math.Round(pensiya, 2)}");
