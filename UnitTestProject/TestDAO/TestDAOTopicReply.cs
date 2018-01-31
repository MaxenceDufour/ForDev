using BusinessClassPortable;
using DAOClass;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data.SqlClient;

namespace UnitTestProject.TestDAO
{
    [TestClass]
    public class TestDAOTopicReply
    {
        [TestMethod]
        public void Test_AddNewTopicReply()
        {
            //Arrange
            Controller.DAOInitialize("Data Source=176.31.248.137;Initial Catalog=user19;Persist Security Info=True;User ID=user19;Password=274user19");
            
            DAOTopicReply objDaoTopicReply = DAOTopicReply.getInstance();
            Message messageExpected = new Message();
            messageExpected.ReplyContent = "UnitTest TopicReply";
            messageExpected.DateAdd = DateTime.Now;
            messageExpected.DateUp = DateTime.Now;
            messageExpected.Topic.TopicId = 1;
            messageExpected.Person.PersonId = 1;

            // Act 
            objDaoTopicReply.AddNewTopicReply(messageExpected);
            Message messageActual = new Message();
            string command = "SELECT * FROM TOPICREPLY WHERE REPLYCONTENT='UnitTest TopicReply'";

            using (SqlConnection connection = new SqlConnection("Data Source=176.31.248.137;Initial Catalog=user19;Persist Security Info=True;User ID=user19;Password=274user19"))
            {
                SqlCommand cmd = new SqlCommand(command, connection);
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    messageActual.ReplyContent = reader.GetString(1);
                    messageActual.DateAdd = reader.GetDateTime(2);
                    messageActual.DateUp = reader.GetDateTime(3);
                    messageActual.Topic.TopicId = reader.GetInt32(4);
                }
                connection.Close();
                messageActual.Person.PersonId = 1;
            }

            // Assert
            Assert.IsTrue(messageExpected.Equals(messageActual));

        }
    }
}
