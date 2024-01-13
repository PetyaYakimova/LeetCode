namespace MergeTwoSortedLists
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] list1 = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
			ListNode head1 = new ListNode(list1[0]);
			ListNode currentNode = head1;
			for (int i = 1; i < list1.Length; i++)
			{
				currentNode.next = new ListNode(list1[i]);
				currentNode = currentNode.next;
			}

			int[] list2 = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
			ListNode head2 = new ListNode(list2[0]);
			currentNode = head2;
			for (int i = 1; i < list2.Length; i++)
			{
				currentNode.next = new ListNode(list2[i]);
				currentNode = currentNode.next;
			}

			ListNode result = Solution.MergeTwoLists(head1, head2);
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
		public static ListNode MergeTwoLists(ListNode list1, ListNode list2)
		{
			ListNode list1CurrentNode = list1;
			ListNode list2CurrentNode = list2;
			if (list1CurrentNode == null)
			{
				if (list2CurrentNode == null)
				{
					return null;
				}
				else
				{
					return list2CurrentNode;
				}
			}

			if (list2CurrentNode == null)
			{
				return list1CurrentNode;
			}

			ListNode result = null;
			if (list1CurrentNode.val <= list2CurrentNode.val)
			{
				result = new ListNode(list1CurrentNode.val);
				list1CurrentNode = list1CurrentNode.next;
			}
			else
			{
				result = new ListNode(list2CurrentNode.val);
				list2CurrentNode = list2CurrentNode.next;
			}

			ListNode resultCurrentNode = result;

			while (list1CurrentNode != null && list2CurrentNode != null)
			{
				if (list1CurrentNode.val <= list2CurrentNode.val)
				{
					resultCurrentNode.next = new ListNode(list1CurrentNode.val);
					list1CurrentNode = list1CurrentNode.next;
				}
				else
				{
					resultCurrentNode.next = new ListNode(list2CurrentNode.val);
					list2CurrentNode = list2CurrentNode.next;
				}

				resultCurrentNode = resultCurrentNode.next;
			}

			if (list1CurrentNode != null)
			{
				resultCurrentNode.next = list1CurrentNode;
			}

			if (list2CurrentNode != null)
			{
				resultCurrentNode.next = list2CurrentNode;
			}

			return result;
		}
	}
}

