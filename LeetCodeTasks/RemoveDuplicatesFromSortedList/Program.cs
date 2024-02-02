namespace RemoveDuplicatesFromSortedList
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
            if (head == null)
            {
                return head;
            }

            ListNode result = new ListNode(head.val);
            ListNode resultCurrentNode = result;

            ListNode currentNode = head;
            while (currentNode.next != null)
            {
                currentNode = currentNode.next;
                if (currentNode.val != resultCurrentNode.val)
                {
                    resultCurrentNode.next = new ListNode(currentNode.val);
                    resultCurrentNode = resultCurrentNode.next;
                }
            }

            return result;
        }
    }
}