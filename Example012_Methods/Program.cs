// // Виды методов
// // Вид 1
// // который ничего не принимает и ничего не возвращает

// void Method1()
// {
//     Console.WriteLine("Автор ...");
// }

// // Method1();



// // Вид 2
// // который принимает агрументы, но ничего не возвращает

// void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }
// // Method2("Текст сообщения");

// void Method21(string msg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }
// }
// // Method21(count: 4, msg: "новый текст сообщения");



// // Вид 3
// // который ничего не принимает, но что то возвращает

// int Method3()
// {
//     return DateTime.Now.Year;
// }
// int year = Method3();
// Console.WriteLine(year);



// // Вид 4
// // который что то принимает и что то возвращает

// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;

//     while(i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }

// string res = Method4(10, "текст много раз");
// Console.WriteLine(res);



// про цикл for

// string Method4(int count, string text)
// {
//     string result = String.Empty;
//     for(int i = 0; i < count; i++)
//     {
//         result = result + text;
//     }
//     return result;
// }

// string res = Method4(10, "текст много раз");
// Console.WriteLine(res);



// цикл в цикле

// for (int i = 2; i <= 10; i++)
// {
//     for (int j = 2; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} x {j} = {j}");
//     }
//     Console.WriteLine();
// }



// Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить черточками,
// маленькие буквы "к" заменить большими "К",
// а большие "С" заменить маленькими "с".

// string text = "— Я думаю, — сказал князь, улыбаясь, — что, "
//             + "ежели бы вас послали вместо нашего милого Винценгероде, "
//             + "вы бы взяли приступом согласие прусского короля. "
//             + "Вы так красноречивы. Вы дадите мне чаю?"
//             + "ккк ССС ККК ссс";

// string Replace(string text, char oldValue, char newValue)
// {
//     string result = String.Empty;

//     int length = text.Length;
//     for (int i = 0; i < text.Length; i++)
//     {
//         if (text[i] == oldValue) result = result + $"{newValue}";
//         else result = result + $"{text[i]}";
//     }
//     return result;
// }

// string newText = Replace(text, ' ', '|');
// Console.WriteLine(newText);
// newText = Replace(newText, 'к', 'К');
// Console.WriteLine(newText);
// newText = Replace(newText, 'С', 'с');
// Console.WriteLine(newText);



// Упорядочить данные в массиве

int [] arr = {1, 5, 4, 3, 2, 6, 7, 1 ,1 };

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);