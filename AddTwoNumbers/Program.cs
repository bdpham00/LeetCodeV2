﻿using System;

namespace AddTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedListSolution solution = new LinkedListSolution();
            var ans = solution.AddTwoNumbers(new ListNode(2, new ListNode(4, new ListNode(3))), new ListNode(5, new ListNode(6, new ListNode(4))));
            Console.WriteLine(ans);
            Console.Read();
        }
    }
}
