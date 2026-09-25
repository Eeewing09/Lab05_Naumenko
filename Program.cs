// int dayNumber = 5;

// switch (dayNumber) {
//     case 6 or 7 or 5: Console.WriteLine("Выходной"); break;
//     default: Console.WriteLine("Будний"); break;
// }

int score = 16;

switch (score)
{
    case < 0:
        Console.WriteLine("Мороз");
        break;
    case >= 0 and <= 14:
        Console.WriteLine("Прохладно");
        break;
    case >= 15 and <= 24:
        Console.WriteLine("Комфортно");
        break;
    case >= 25 and <= 34:
        Console.WriteLine("Жарко");
        break;
    case >= 35:
        Console.WriteLine("Очень жарко");
        break;
}



