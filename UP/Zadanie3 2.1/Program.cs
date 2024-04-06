using System;
using System.Collections.Generic;

class HelloWorld {
    public static bool Duplicate (int[] nums)
    {
        HashSet<int> number = new HashSet<int>();
        foreach(int num in nums)
        {
            if(number.Contains(num))
            {
                return true;
            }
            number.Add(num);
        }
        return false;
    }
    public static void Main()
    {
        int[] nums1 = {1,2,3,4};
        int[] nums2 = {1,1,1,3,3,4,3,2,4,2};
        int[] nums3 = {1,2,3,1};
        Console.WriteLine(Duplicate(nums1));
        Console.WriteLine(Duplicate(nums2));
        Console.WriteLine(Duplicate(nums3));
    }