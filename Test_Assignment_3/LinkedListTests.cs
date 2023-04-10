namespace Test_Assignment_3
{
	using Assignment_3_skeleton;

	public class LinkedListTests
	{
		private LinkedListADT linkedList;

		[SetUp]
		public void Setup()
		{
			// Create your concrete linked list class and assign to to linkedList.
			this.linkedList = new SLL();
		}

		[TearDown]
		public void TearDown()
		{
			this.linkedList.Clear();
		}

		//Test the linked list is empty.
		[Test]
		public void TestIsEmpty()
		{
			Assert.True(this.linkedList.IsEmpty());
			Assert.AreEqual(0, this.linkedList.Size());
		}

		//Tests appending elements to the linked list.
		[Test]
		public void TestAppendNode()
		{
			this.linkedList.Append("a");
			this.linkedList.Append("b");
			this.linkedList.Append("c");
			this.linkedList.Append("d");

			/**
             * Linked list should now be:
             * 
             * a -> b -> c -> d
             */

			// Test the linked list is not empty.
			Assert.False(this.linkedList.IsEmpty());

			// Test the size is 4
			Assert.AreEqual(4, this.linkedList.Size());

			// Test the first node value is a
			Assert.AreEqual("a", this.linkedList.Retrieve(0));

			// Test the second node value is b
			Assert.AreEqual("b", this.linkedList.Retrieve(1));

			// Test the third node value is c
			Assert.AreEqual("c", this.linkedList.Retrieve(2));

			// Test the fourth node value is d
			Assert.AreEqual("d", this.linkedList.Retrieve(3));
		}

		//Tests prepending nodes to linked list.
		[Test]
		public void testPrependNodes()
		{
			this.linkedList.Prepend("a");
			this.linkedList.Prepend("b");
			this.linkedList.Prepend("c");
			this.linkedList.Prepend("d");

			/**
             * Linked list should now be:
             * 
             * d -> c -> b -> a
             */

			// Test the linked list is not empty.
			Assert.False(this.linkedList.IsEmpty());

			// Test the size is 4
			Assert.AreEqual(4, this.linkedList.Size());

			// Test the first node value is a
			Assert.AreEqual("d", this.linkedList.Retrieve(0));

			// Test the second node value is b
			Assert.AreEqual("c", this.linkedList.Retrieve(1));

			// Test the third node value is c
			Assert.AreEqual("b", this.linkedList.Retrieve(2));

			// Test the fourth node value is d
			Assert.AreEqual("a", this.linkedList.Retrieve(3));
		}

		//Tests inserting node at valid index.
		[Test]
		public void TestInsertNode()
		{
			this.linkedList.Append("a");
			this.linkedList.Append("b");
			this.linkedList.Append("c");
			this.linkedList.Append("d");

			this.linkedList.Insert("e", 2);

			/**
             * Linked list should now be:
             * 
             * a -> b -> e -> c -> d
             */

			// Test the linked list is not empty.
			Assert.False(this.linkedList.IsEmpty());

			// Test the size is 4
			Assert.AreEqual(5, this.linkedList.Size());

			// Test the first node value is a
			Assert.AreEqual("a", this.linkedList.Retrieve(0));

			// Test the second node value is b
			Assert.AreEqual("b", this.linkedList.Retrieve(1));

			// Test the third node value is e
			Assert.AreEqual("e", this.linkedList.Retrieve(2));

			// Test the third node value is c
			Assert.AreEqual("c", this.linkedList.Retrieve(3));

			// Test the fourth node value is d
			Assert.AreEqual("d", this.linkedList.Retrieve(4));
		}

		//Tests replacing existing nodes data.
		[Test]
		public void TestReplaceNode()
		{
			this.linkedList.Append("a");
			this.linkedList.Append("b");
			this.linkedList.Append("c");
			this.linkedList.Append("d");

			this.linkedList.Replace("e", 2);

			/**
             * Linked list should now be:
             * 
             * a -> b -> e -> d
             */

			// Test the linked list is not empty.
			Assert.False(this.linkedList.IsEmpty());

			// Test the size is 4
			Assert.AreEqual(4, this.linkedList.Size());

			// Test the first node value is a
			Assert.AreEqual("a", this.linkedList.Retrieve(0));

			// Test the second node value is b
			Assert.AreEqual("b", this.linkedList.Retrieve(1));

			// Test the third node value is e
			Assert.AreEqual("e", this.linkedList.Retrieve(2));

			// Test the fourth node value is d
			Assert.AreEqual("d", this.linkedList.Retrieve(3));
		}

		//Tests deleting node from linked list.
		[Test]
		public void TestDeleteNode()
		{
			this.linkedList.Append("a");
			this.linkedList.Append("b");
			this.linkedList.Append("c");
			this.linkedList.Append("d");

			this.linkedList.Delete(2);

			/**
             * Linked list should now be:
             * 
             * a -> b -> d
             */

			// Test the linked list is not empty.
			Assert.False(this.linkedList.IsEmpty());

			// Test the size is 4
			Assert.AreEqual(3, this.linkedList.Size());

			// Test the first node value is a
			Assert.AreEqual("a", this.linkedList.Retrieve(0));

			// Test the second node value is b
			Assert.AreEqual("b", this.linkedList.Retrieve(1));

			// Test the fourth node value is d
			Assert.AreEqual("d", this.linkedList.Retrieve(2));
		}

		//Tests finding and retrieving node in linked list.
		[Test]
		public void TestFindNode()
		{
			this.linkedList.Append("a");
			this.linkedList.Append("b");
			this.linkedList.Append("c");
			this.linkedList.Append("d");

			/**
             * Linked list should now be:
             * 
             * a -> b -> c -> d
             */

			bool contains = this.linkedList.Contains("b");
			Assert.True(contains);

			int index = this.linkedList.IndexOf("b");
			Assert.AreEqual(1, index);

			string value = (string)this.linkedList.Retrieve(1);
			Assert.AreEqual("b", value);
		}

		[Test]
		public void TestClearList()
		{
			this.linkedList.Append("a");
			this.linkedList.Append("b");
			this.linkedList.Append("c");
			this.linkedList.Append("d");
			this.linkedList.Clear();
			/**
			 * Linked list should now be: null
			 */

			// Test the linked list is empty.
			Assert.True(this.linkedList.IsEmpty());
			// Test the size is 0
			Assert.AreEqual(0, this.linkedList.Size());
		}

		[Test]
		public void TestSizeList()
		{
			this.linkedList.Append("a");
			this.linkedList.Append("b");
			this.linkedList.Append("c");
			this.linkedList.Append("d");
			this.linkedList.Append("e");
			this.linkedList.Append("f");
			this.linkedList.Append("g");

			// Test the linked list is not empty.
			Assert.False(this.linkedList.IsEmpty());
			// Test the size is 0
			Assert.AreEqual(7, this.linkedList.Size());
		}

		[Test]
		public void TestIndexOfNode()
		{
			this.linkedList.Append("a");
			this.linkedList.Append("b");
			this.linkedList.Append("c");
			this.linkedList.Append("d");
			this.linkedList.Append("e");

			// Test the linked list is not empty.
			Assert.False(this.linkedList.IsEmpty());

			// The element c is at index 2.
			Assert.AreEqual(2, this.linkedList.IndexOf("c"));

			// The element e is at index 4.
			Assert.AreEqual(4, this.linkedList.IndexOf("e"));
		}

		[Test]
		public void TestContainsNode()
		{
			this.linkedList.Append("a");
			this.linkedList.Append("b");
			this.linkedList.Append("c");
			this.linkedList.Append("d");
			this.linkedList.Append("e");

			// Test the linked list is not empty.
			Assert.False(this.linkedList.IsEmpty());

			// Check if the list contains a.
			Assert.True(this.linkedList.Contains("a"));

			// Check if the list contains a.
			Assert.False(this.linkedList.Contains("g"));

			// Check if the list contains a.
			Assert.True(this.linkedList.Contains("d"));
		}

		[Test]
		public void TestRetreiveNode()
		{
			this.linkedList.Append("a");
			this.linkedList.Append("b");
			this.linkedList.Append("c");
			this.linkedList.Append("d");
			this.linkedList.Append("e");

			// Test the linked list is not empty.
			Assert.False(this.linkedList.IsEmpty());

			// retrevie node will get the node.
			Assert.AreEqual("c", this.linkedList.Retrieve(2));

			// retrevie node will get the node.
			Assert.AreEqual("b", this.linkedList.Retrieve(1));

			// retrevie node will get the node.
			Assert.AreEqual("e", this.linkedList.Retrieve(4));
		}

	}
}
