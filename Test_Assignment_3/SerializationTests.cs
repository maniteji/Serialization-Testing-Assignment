﻿namespace Test_Assignment_3
{
	using Assignment_3_skeleton;

	public class SerializationTests
	{
		private List<User> users;
		private readonly string testFileName = "test_users.bin";

		[SetUp]
		public void Setup()
		{
			users = new List<User>();
			users.Append(new User(1, "Joe Blow", "jblow@gmail.com", "password"));
			users.Append(new User(2, "Joe Schmoe", "joe.schmoe@outlook.com", "abcdef"));
			users.Append(new User(3, "Colonel Sanders", "chickenlover1890@gmail.com", "kfc5555"));
			users.Append(new User(4, "Ronald McDonald", "burgers4life63@outlook.com", "mcdonalds999"));
		}

		[TearDown]
		public void TearDown()
		{
			this.users.Clear();
		}

		//Tests the object was serialized.
		[Test]
		public void TestSerialization()
		{
			SerializationHelper.SerializeUsers(users, testFileName);
			Assert.IsTrue(File.Exists(testFileName));
		}

		// Tests the object was deserialized.
		[Test]
		public void TestDeSerialization()
		{
			SerializationHelper.SerializeUsers(users, testFileName);
			List<User> deserializedUsers = SerializationHelper.DeserializeUsers(testFileName);
			Assert.AreEqual(users.Count, deserializedUsers.Count);
			for (int i = 0; i < users.Count; i++)
			{
				Assert.AreEqual(users[i].Id, deserializedUsers[i].Id);
				Assert.AreEqual(users[i].Name, deserializedUsers[i].Name);
				Assert.AreEqual(users[i].UserName, deserializedUsers[i].UserName);
				Assert.AreEqual(users[i].Password, deserializedUsers[i].Password);
			}
		}

	}
}
