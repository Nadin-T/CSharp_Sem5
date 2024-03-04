﻿// Задача 1: Задайте двумерный массив символов (тип char [,]). 
// Создать строку из символов этого массива.



//Вывод массива
void ShowMatrix(char[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

//Создание строки из символов двумерного массива
string GetStringFromArrayChars(char[,] chars)
{
    string str = String.Empty;
    for (int i = 0; i < chars.GetLength (0); i++)
    {
        for (int j = 0; j < chars.GetLength(1); j++)
        {
            str += chars[i,j];
        }
    }
    return str;
}


char [,] chars = {{'1','f','5','s'}, {'f','3','9','v'}};
ShowMatrix (chars);
string str = GetStringFromArrayChars(chars);
Console.Write (str);