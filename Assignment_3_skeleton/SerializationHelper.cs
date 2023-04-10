namespace Assignment_3_skeleton
{
	using System.Collections.Generic;
	using System.IO;
	using System.Runtime.Serialization;

	public static class SerializationHelper
    {
        public static void SerializeUsers(List<User> users, string fileName)
        {
            DataContractSerializer serializer = new DataContractSerializer(typeof(List<User>));
            using (FileStream stream = File.Create(fileName))
            {
                serializer.WriteObject(stream, users);
            }
        }

        public static List<User> DeserializeUsers(string fileName)
        {
            DataContractSerializer serializer = new DataContractSerializer(typeof(List<User>));
            using (FileStream stream = File.OpenRead(fileName))
            {
                return (List<User>)serializer.ReadObject(stream);
            }
        }
    }
}
