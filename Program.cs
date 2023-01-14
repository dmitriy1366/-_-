// Задача. Написать программу, которая из имеющегося массива строк формирует
// новый массив из строк, длина которых меньше либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте
//  выполнения алгоритма.

string[] strings = { "мир", "Привет", "Строка", "C#", "777"};
List<string> result = new List<string>();
foreach (string s in strings)
{
    if (s.Length <= 3)
    {
        result.Add(s);
    }
}
foreach (string s in result)
    Console.WriteLine(s);