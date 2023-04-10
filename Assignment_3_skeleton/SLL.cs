namespace Assignment_3_skeleton
{
	using System;

	public class SLL : LinkedListADT
	{
		private Node head;
		private int count;

		public SLL()
		{
			head = null;
			count = 0;
		}

		public bool IsEmpty()
		{
			return head == null;
		}

		public void Clear()
		{
			head = null;
			count = 0;
		}

		public void Append(object data)
		{
			Insert(data, count);
		}

		public void Prepend(object data)
		{
			head = new Node { Data = data, Next = head };
			count++;
		}

		public void Insert(object data, int index)
		{
			if (index < 0 || index > count)
			{
				throw new IndexOutOfRangeException();
			}

			if (index == 0)
			{
				Prepend(data);
				return;
			}

			Node current = head;
			for (int i = 0; i < index - 1; i++)
			{
				current = current.Next;
			}

			Node newNode = new Node { Data = data, Next = current.Next };
			current.Next = newNode;
			count++;
		}

		public void Replace(object data, int index)
		{
			if (index < 0 || index >= count)
			{
				throw new IndexOutOfRangeException();
			}

			Node current = head;
			for (int i = 0; i < index; i++)
			{
				current = current.Next;
			}

			current.Data = data;
		}

		public int Size()
		{
			return count;
		}

		public void Delete(int index)
		{
			if (index < 0 || index >= count)
			{
				throw new IndexOutOfRangeException();
			}

			if (index == 0)
			{
				head = head.Next;
			}
			else
			{
				Node current = head;
				for (int i = 0; i < index - 1; i++)
				{
					current = current.Next;
				}

				current.Next = current.Next.Next;
			}

			count--;
		}

		public object Retrieve(int index)
		{
			if (index < 0 || index >= count)
			{
				throw new IndexOutOfRangeException();
			}

			Node current = head;
			for (int i = 0; i < index; i++)
			{
				current = current.Next;
			}

			return current.Data;
		}

		public int IndexOf(object data)
		{
			Node current = head;
			for (int i = 0; i < count; i++)
			{
				if (current.Data.Equals(data))
				{
					return i;
				}
				current = current.Next;
			}

			return -1;
		}

		public bool Contains(object data)
		{
			return IndexOf(data) != -1;
		}
	}

}
