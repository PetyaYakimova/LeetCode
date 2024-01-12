namespace RemoveNthNodeFromEndOfList
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] inputNums = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
			int n = int.Parse(Console.ReadLine());
			ListNode head = new ListNode(inputNums[0]);
			ListNode currentNode = head;
			for (int i = 1; i < inputNums.Length; i++)
			{
				currentNode.next = new ListNode(inputNums[i]);
				currentNode = currentNode.next;
			}

			ListNode result = Solution.RemoveNthFromEnd(head, n);
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
		public static ListNode RemoveNthFromEnd(ListNode head, int n)
		{
			ListNode currentNode = head;
			int headLength = 0;
			while (currentNode != null)
			{
				headLength++;
				currentNode = currentNode.next;
			}

			if (headLength == 1)
			{
				return null;
			}
			else if (headLength == n)
			{
				return head.next;
			}

			int indexOfNodeToBeRemoved = headLength - n;
			currentNode = head;
			int counter = 0;
			while (counter < indexOfNodeToBeRemoved - 1)
			{
				currentNode = currentNode.next;
				counter++;
			}

			ListNode temp = currentNode.next.next;
			currentNode.next = temp;

			return head;
		}
	}
}