/*Написать программу, которая из имеющегося массива строк формирует 
массив из строк длина которых меньше либо равна 3 символов. 
Первоначальный массив можно ввести с клавиатуры либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться  коллекциямиб лучше обойтись исключительно массивами.
Примеры: ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
         ["1234", "1567", "-2", "computer sciens"] -> ["-2"]*/

Console.WriteLine("Наш массив:"); 
string[] myArray = {"string", "df", "34&", "computer sciens", "w+)"};
for (int i = 0; i < myArray.Length; i++)
Console.Write("{0}, ", myArray[i]);
Console.WriteLine();

Console.WriteLine("\nМассив из строк длина которых <= 3 символов:");
if (myArray[0].Length <= 3)
{
Console.Write("{0}, ", myArray[0]);
    }
    if (myArray[1].Length <= 3)
        {
        Console.Write("{0}, ", myArray[1]);
            }
                if (myArray[2].Length <= 3)
                    {
                        Console.Write("{0}, ", myArray[2]);
                            }
                                if (myArray[3].Length <= 3)
                                    {
                                    Console.Write("{0}, ", myArray[3]);
                                    }
                                        if (myArray[4].Length <= 3)
                                            {
                                            Console.Write("{0}, ", myArray[4]);
                                            }
Console.WriteLine();


