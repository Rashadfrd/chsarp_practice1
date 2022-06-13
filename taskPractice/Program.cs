using System;

namespace taskPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Akif", "Zakir", "Allahverdi", "Abdulla", "Semender" };
            Console.WriteLine("Herfleri sayi 5den uzun olan adlarin sayi:");
            Console.WriteLine(LetterCountFound(names));

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 11, 12, 13, 14, 15, 16 };
            var result = EvenNumbers(numbers);
            Console.WriteLine("\nCut ededler:");
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }


            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 11, 12, 13, 14, 15, 16, 17, 18, 19 };
            int num = 3;
            Console.WriteLine("\nVerilmis ededin indexi:");
            Console.WriteLine(FindIndex(nums, num));

            int[] numbers1 = { 1, 2, 3, 4, 7 };
            int[] numbers2 = { 1, 2, 3, 4, 5, 6 };
            Console.WriteLine("\nIlk array ikinci arraya daxildirmi:");
            bool result2 = IsArrayExist(numbers1, numbers2);
            Console.WriteLine(result2);


            string[] names2 = { "Asif", "Akif", "Agamirze", "Abdulla", "Agababa", "Agabala" };
            Console.WriteLine("\nButun adlar a herfiyle baslayirmi:");
            Console.WriteLine(StartsWithA(names2));


            int[] numberss = { 1, 2, 3, 4, 5 };
            int numberr = 17;
            Console.WriteLine("\nYeni array:");
            numberss = NewArrMaker(numberss, numberr);
            foreach (var item in numberss)
            {
                Console.WriteLine(item);
            }

        }
        static int LetterCountFound(string[] names)
        {
            int lettercount = 0;
            int namecount = 0;
            for (int i = 0; i < names.Length; i++)
            {
                lettercount = 0;
                for (int j = 0; j < names[i].Length; j++)
                {
                    lettercount++;
                    if (lettercount > 5)
                    {
                        namecount++;
                        break;
                    }
                }
            }
            return namecount;
        }

        static int[] EvenNumbers(int[] numbers)
        {
            int[] newNums = new int[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    Array.Resize(ref newNums, newNums.Length + 1);
                    newNums[newNums.Length - 1] = numbers[i];
                }
            }
            return newNums;
        }

        static int FindIndex(int[] nums, int num)
        {
            int index = 0; ;
            int min = 0;
            int max = nums.Length - 1;
            while (min <= max)
            {
                int mid = (max + min) / 2;
                if (num == nums[mid])
                {
                    index = mid;
                    break;
                }
                else if (num > nums[mid])
                {
                    min = mid;
                    min++;
                }
                else
                {
                    max = mid;
                    max--;
                }

            }
            return index;
        }

        static bool IsArrayExist(int[] numbers1, int[] numbers2)
        {
            bool check = false;
            for (int i = 0; i < numbers1.Length; i++)
            {
                check = false;
                for (int j = 0; j < numbers2.Length; j++)
                {
                    if (numbers1[i] == numbers2[j])
                    {
                        check = true;
                        break;
                    }
                }
                if (check == false)
                    break;

            }
            if (check)
                return true;
            else
                return false;
        }

        static bool StartsWithA(string[] names)
        {
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i][0] == 'A')
                {
                    continue;
                }
                else
                {
                    return false;
                    break;
                }
            }

            return true;
        }

        static int[] NewArrMaker(int[] nums, int num)
        {
            Array.Resize(ref nums, nums.Length + 1);
            nums[nums.Length - 1] = num;
            return nums;
        }

    }


}
    

