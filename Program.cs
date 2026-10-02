// int dayNumber = 5;

// switch (dayNumber) {
//     case 6 or 7 or 5: Console.WriteLine("Выходной"); break;
//     default: Console.WriteLine("Будний"); break;
// }

// int score = 78;

// switch (score) {
//     case >= 0 and <= 39:
//         Console.WriteLine("Неудовлетворительно");
//         break;
//     case >= 40 and <= 59:
//         Console.WriteLine("Удовлетворительно");
//         break;
//     case >= 60 and <= 79:
//         Console.WriteLine("Хорошо");
//         break;
//     case >= 80 and <= 100:
//         Console.WriteLine("Отлично");
//         break;
//     default:
//         Console.WriteLine("Некорректный балл");
//         break;
// }

// int temperature = 20;

// string result = temperature switch {
//     >= 35 => "Очень жарко",
//     >= 25 => "Жарко",
//     >= 15 => "Комфортно",
//     >= 0  => "Прохладно",
//     _     => "Мороз"
// };

// Console.WriteLine(result);

// string role = "user";

// string result1 = role switch {
//     "admin"   => "Полный доступ",
//     "teacher" => "Доступ преподавателя",
//     _         => "Ограниченный доступ"
// };

// Console.WriteLine(result1);


// int age = 20;
// bool hasTicket = true;

// switch (age) {

//     case >= 18 when hasTicket:
//         Console.WriteLine("Вход разрешён");
//         break;
        
//     case >= 18:
//         Console.WriteLine("Нет билета");
//         break;

//     default:
//         Console.WriteLine("Возраст не подходит");
//         break;
// }
// int level = 2;

// switch (level)
// {
//     case 1:
//         Console.WriteLine("Начальный уровень");
//         break;
//     case 2:
//         Console.WriteLine("Средний уровень");
//         goto case 1;
//     case 3:
//         Console.WriteLine("Продвинутый уровень");
//         break;
// }
// Задача А
int month = 12;

string season = month switch {
    12 or 1 or 2 => "Зима",
    3 or 4 or 5  => "Весна",
    6 or 7 or 8  => "Лето",
    9 or 10 or 11 => "Осень",
    _            => "Неверный месяц"
};

Console.WriteLine(season);
// Задача В
int age1 = 20;

string ctg = age1 switch {
    < 0           => "Ошибка",
    >= 0 and <= 6  => "Ребёнок",
    >= 7 and <= 17 => "Подросток",
    >= 18 and <= 64 => "Взрослый",
    >= 65         => "Пенсионер"
};

Console.WriteLine(ctg);

