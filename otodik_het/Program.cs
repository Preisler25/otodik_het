namespace otodik_het;

using System;
class Program

{
    static void Print(string text)
    {
        Console.WriteLine(text);
    }

    static void Wait()
    {
        Console.ReadKey();
    }

    static void Hello()
    {
        Print("Hello, világ!");
    }

    static int Add(int a, int b)
    {
        return a + b;
    }

    static int[] PrintArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Print(array[i].ToString());
        }
        return array;
    }

    static bool IsEven(int number)
    {
        return number % 2 == 0;
    }

    static string ReverseString(string text)
    {
        string reversed = "";
        for (int i = text.Length - 1; i >= 0; i--)
        {
            reversed += text[i];
        }
        return reversed;
    }

    static int CalculateFactorial(int number)
    {
        int factorial = 1;
        for (int i = 1; i <= number; i++)
        {
            factorial *= i;
        }
        return factorial;
    }

    static bool IsPrime(int number){
        for (int i = 2; i < number; i++)
        {
            if(number % i == 0){
                return false;
            }
        }
        return true;
    }

    static int SumOfList(int[] list){
        int sum = 0;
        for (int i = 0; i < list.Length; i++)
        {
            sum += list[i];
        }
        return sum;
    }

    static int FindMax(int[] list){
        int max = list[0];
        for (int i = 1; i < list.Length; i++)
        {
            if(list[i] > max){
                max = list[i];
            }
        }
        return max;
    }

    static int CountEvenNumbers(int[] list){
        int even = 0;

        for (int i = 0; i < list.Length; i++)
        {
            if(IsEven(list[i])){
                even++;
            }
        }
    }

    static void RemoveDuplicates(int[] list){
        int[] newList = new int[list.Length];
        int index = 0;
        for (int i = 0; i < list.Length; i++)
        {
            bool found = false;
            for (int j = 0; j < newList.Length; j++)
            {
                if(list[i] == newList[j]){
                    found = true;
                    break;
                }
            }
            if(!found){
                newList[index] = list[i];
                index++;
            }
        }
        PrintArray(newList);
    }

    static bool IsPalindrome(string text){
        string reversed = ReverseString(text);
        return text == reversed;
    }

    static string FindLargestSubstring(string text1, string text2){
        string largest = "";
        for (int i = 0; i < text1.Length; i++)
        {
            for (int j = 0; j < text2.Length; j++)
            {
                if(text1[i] == text2[j]){
                    string substring = text1[i].ToString();
                    int index1 = i + 1;
                    int index2 = j + 1;
                    while(index1 < text1.Length && index2 < text2.Length && text1[index1] == text2[index2]){
                        substring += text1[index1];
                        index1++;
                        index2++;
                    }
                    if(substring.Length > largest.Length){
                        largest = substring;
                    }
                }
            }
        }
        return largest;
    }

    static string ConvertToUpperCase(string text1){
        string text2 = "";
        for (int i = 0; i < text1.Length; i++)
        {
            if(text1[i] >= 'a' && text1[i] <= 'z'){
                text2 += (char)(text1[i] - 32);
            }else{
                text2 += text1[i];
            }
        }
        return text2;
    }

    static void Main(string[] args)
    {
        Hello();
        Wait();
    }
}