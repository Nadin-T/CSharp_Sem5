// Задача 1: Задайте двумерный массив символов (тип char [,]). 
// Создать строку из символов этого массива.



//Вывод массива
// void ShowMatrix(char[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($"{matrix[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// //Создание строки из символов двумерного массива
// string GetStringFromArrayChars(char[,] chars)
// {
//     string str = String.Empty;
//     for (int i = 0; i < chars.GetLength (0); i++)
//     {
//         for (int j = 0; j < chars.GetLength(1); j++)
//         {
//             str += chars[i,j];
//         }
//     }
//     return str;
// }


// char [,] chars = {{'1','f','5','s'}, {'f','3','9','v'}};
// ShowMatrix (chars);
// string str = GetStringFromArrayChars(chars);
// Console.Write (str);

//Задача 2: Задайте строку, содержащую латинские буквы в обоих регистрах. 
//Сформируйте строку, в которой все заглавные буквы заменены на строчные.

//Перевод букв строки в строчные
// string GetLowersLetters (string str)
// {
//     string strToLower = "";
//     foreach (char e in str)
//     {
//         strToLower = str.ToLower();
//     }
//     return strToLower;
// }

// string str = "Hello WOrlD";
// string str1 = GetLowersLetters (str);
// Console.Write (str1);


//Задача 3: Задайте произвольную строку. 
//Выясните, является ли она палиндромом.

// Преобразовываем строку в массив символов

//Определяем, является ли строка полиндромом

// char[] GetArrayFromStringChars(string str)
// {
//     char [] chars = new char [str.Length];
//     for (int i = 0; i < str.Length; i++)
//     {
//         chars[i] = str[i];
//     }
//     return chars;
// }

// bool CheckIsPolindrom (char [] chars)
// {
//     bool flag = true;
//     for (int i = 0; i < chars.Length/2; i++)
//     {
//         if (chars[i] == chars[chars.Length-1-i])
//         {
//             flag = true;
//         }
//         else
//         {
//             flag = false;
//             break;
//         }
//     }
//     return flag;
// }

// string str = "кошка";
// char [] chars = GetArrayFromStringChars (str);
// if (CheckIsPolindrom (chars) == true)
// {
//     Console.Write("Да");
// }
// else
// {
//     Console.Write("Нет");
// }