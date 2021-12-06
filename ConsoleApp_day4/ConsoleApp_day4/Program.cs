using System;

namespace main
{
    public class Program
    {
        private static bool CheckPassed(int score)
        {
            return score >= 60;
        }

        private static void Print(int value)
        {
            Console.Write($"{value} ");
        }

        static void PrintArray(System.Array array)
        {
            foreach (var e in array)
                Console.Write(e);
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            //배열 인덱스 설정 방식
            /*int[] scores = new int[5];
            scores[0] = 80;
            scores[1] = 74;
            scores[2] = 81;
            scores[^2] = 90;  // 배열의 마지막-1
            scores[^1] = 34;  // 배열의 마지막

            foreach (int score in scores)
                Console.WriteLine(score);

            int sum = 0;
            foreach (int score in scores)
                sum += score;

            int average = sum / scores.Length;

            Console.WriteLine($"Average Score : {average}");*/





            //배열 초기화 방법
            /* string[] array1 = new string[3] { "안녕", "Hello", "Halo" };

             Console.WriteLine("array1...");
             foreach (string greeting in array1)
                 Console.WriteLine($" {greeting}");

             string[] array2 = new string[] { "안녕", "Hello", "Halo" };

             Console.WriteLine("\narray2...");
             foreach (string greeting in array2)
                 Console.WriteLine($" {greeting}");

             string[] array3 = { "안녕", "Hello", "Halo" };

             Console.WriteLine("\narray3...");
             foreach (string greeting in array3)
                 Console.WriteLine($" {greeting}");*/





            //array 방식 연습
            /*int[] scores = new int[] { 80, 74, 81, 90, 34 };
            foreach (int score in scores)
                Console.Write($"{score} ");
            Console.WriteLine();

            Array.Sort(scores);
            Array.ForEach<int>(scores, new Action<int>(Print));
            Console.WriteLine();

            Console.WriteLine($"Numver of dimension : {scores.Rank}");
            Console.WriteLine($"Binary search : 81 is at " + $"{Array.BinarySearch<int>(scores, 81)}");
            Console.WriteLine($"Binary search : 90 is at " + $"{Array.BinarySearch<int>(scores, 90)}");

            Console.WriteLine($"Everyone passed ? : " +
                $"{Array.TrueForAll<int>(scores, CheckPassed)}");

            int index = Array.FindIndex<int>(scores, (score) => score < 60);

            scores[index] = 61;
            Console.WriteLine($"Everyone passed ? : " +
                $"{Array.TrueForAll<int>(scores, CheckPassed)}");


            Console.WriteLine("Old length of scores : " +
                $"{scores.GetLength(0)}");

            Array.Resize<int>(ref scores, 10);
            Console.WriteLine($"New length of scores : {scores.Length}");

            Array.ForEach<int>(scores, new Action<int>(Print));
            Console.WriteLine();

            Array.Clear(scores, 3, 7);
            Array.ForEach<int>(scores, new Action<int>(Print));
            Console.WriteLine();

            int[] sliced = new int[3];
            Array.Copy(scores, 0, sliced, 0, 3);
            Array.ForEach<int>(sliced, new Action<int>(Print));
            Console.WriteLine();*/





            //배열 분활하기
           /* char[] array = new char['Z' - 'A' + 1];
            for (int i = 0; i < array.Length; i++)
                array[i] = (char)('A' + i);

            PrintArray(array[..]);    // 0번째부터 마지막까지
            PrintArray(array[5..]);   // 5번째부터 끝까지

            Range range_5_10 = 5..10;
            PrintArray(array[range_5_10]); // 5번째부터 9(10-1)번째까지      

            Index last = ^0;
            Range range_5_last = 5..last;
            PrintArray(array[range_5_last]); // 5번째부터 끝(^)까지      

            PrintArray(array[^4..^1]);  // 끝에서 4번째부터 끝(^)에서 1번째까지*/
        }
    }
}