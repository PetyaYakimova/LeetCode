using System.ComponentModel;

namespace RemoveDuplicatesFromSortedList2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputNums = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
            ListNode head = new ListNode(inputNums[0]);
            ListNode currentNode = head;
            for (int i = 1; i < inputNums.Length; i++)
            {
                currentNode.next = new ListNode(inputNums[i]);
                currentNode = currentNode.next;
            }

            ListNode result = Solution.DeleteDuplicates(head);
            currentNode = result;
            while (currentNode != null)
            {
                Console.Write(currentNode.val + ",");
                currentNode = currentNode.next;
            }
            Console.WriteLine();
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    public static class Solution
    {
        public static ListNode DeleteDuplicates(ListNode head)
        {
            ListNode result = new ListNode(0, head);
            ListNode prev = result;

            while (prev != null)
            {
                // Found value that has duplicates
                if (prev.next != null && prev.next.next != null && prev.next.val == prev.next.next.val)
                {
                    var duplicateValue = prev.next.val;
                    while (prev.next != null && prev.next.val == duplicateValue) prev.next = prev.next.next;
                }
                else prev = prev.next;
            }

            return result.next;
        }
    }
}