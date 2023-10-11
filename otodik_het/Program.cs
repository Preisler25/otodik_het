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

    static void PrintArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Print(array[i].ToString());
        }
    }

    static void PrintList(List<int> list){
        for (int i = 0; i < list.Count; i++)
        {
            Print(list[i].ToString());
        }
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

    static int SumOfList(List<int> list){
        int sum = 0;
        for (int i = 0; i < list.Count; i++)
        {
            sum += list[i];
        }
        return sum;
    }

    static int FindMax(List<int> list){
        int max = list[0];
        for (int i = 1; i < list.Count; i++)
        {
            if(list[i] > max){
                max = list[i];
            }
        }
        return max;
    }

    static int CountEvenNumbers(List<int> list){
        int even = 0;

        for (int i = 0; i < list.Count; i++)
        {
            if(IsEven(list[i])){
                even++;
            }
        }
        return even;
    }

    static void RemoveDuplicates(List<int> list){
        int[] newList = new int[list.Count];
        int index = 0;
        for (int i = 0; i < list.Count; i++)
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

    static int CalculatePower(int baseNumber, int exponent){
        int result = 1;
        for (int i = 0; i < exponent; i++)
        {
            result *= baseNumber;
        }
        return result;
    }

    static void SortArray(int[] nums){
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if(nums[i] > nums[j]){
                    int temp = nums[i];
                    nums[i] = nums[j];
                    nums[j] = temp;
                }
            }
        }
    }

    static void SortList(List<int> list){
        for (int i = 0; i < list.Count; i++)
        {
            for (int j = i + 1; j < list.Count; j++)
            {
                if(list[i] > list[j]){
                    int temp = list[i];
                    list[i] = list[j];
                    list[j] = temp;
                }
            }
        }
    }

    static List<int> FindCommonElements(int[] arr1, int[] arr2){
        List<int> common = new List<int>();
        for (int i = 0; i < arr1.Length; i++)
        {
            for (int j = 0; j < arr2.Length; j++)
            {
                if(arr1[i] == arr2[j]){
                    common.Add(arr1[i]);
                }
            }
        }
        return common;
    }

    /*Feladat 19: Metódus neve: IsPalindromeNumber Bemenet: Egész szám (int number) Kimenet: Logikai érték (bool) Leírás: Hozz létre egy metódust, amely egy egész számot kap paraméterként, majd visszaadja true-t, ha a szám palindróm, és false-t, ha nem.
*/
    static bool IsPalindromeNumber(int number){
        int reversed = 0;
        int temp = number;
        while(temp > 0){
            reversed = reversed * 10 + temp % 10;
            temp /= 10;
        }
        return number == reversed;
    }

    /*Metódus neve: FindMissingNumber Bemenet: Egész számokból álló tömb (int[] numbers) Kimenet: Egész szám (int) Leírás: Hozz létre egy metódust, amely egy egész számokból álló tömböt kap paraméterként, amely tartalmaz egy számsorozatot 1-től n-ig, de egy szám hiányzik belőle. A metódusnak vissza kell adnia a hiányzó számot.*/
    
    static int FindMissingNumber(int[] numbers){
        
    }

    /*Metódus neve: SwapElements Bemenet: Egész számokból álló tömb (int[] numbers) Kimenet: Nincs (void) Leírás: Hozz létre egy metódust, amely egy egész számokból álló tömböt kap paraméterként, majd kicseréli az első és az utolsó elemét.*/
    
    static void SwapElements(int[] numbers){

    }

    static void Main(string[] args)
    {
        Hello();
        Wait();
    }
}