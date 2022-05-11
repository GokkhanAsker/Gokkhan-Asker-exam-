string[] stringArray = { "The", "quick", "brown", "fox", "jumped", "over", "the", "lazy", "dog" };// объявляем первоначальный массив
var count = string.Empty;// обЪявляем пустую переменную
for (int index = 0; index < stringArray.Length; index++)  // цикл. Проходим весь массив
{
    if (stringArray[index].Length <= 3) // проверяем данный индекс массива, количество символов должно быть меньше либо равно трем
    {
        count += "'" + stringArray[index] + "'"; //если количество символов меньше либо равно трем, пишем данный индекс в переменную count 
    }
}
char[] newstringArray = count.ToCharArray(); //переменную переводим в массив
System.Console.WriteLine("Первоначальный массив");
Console.WriteLine("[{0}]", string.Join(",", stringArray));//печатаем первоначальный массив
Console.WriteLine("Обработанный массив: ");
Console.WriteLine("[{0}]", string.Join("", newstringArray));//печатаем обработанный массив