using BusinessClassPortable;
using DAOClass;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject.TestDAO
{
    [TestClass]
    public class TestDAOTopic
    {
        [TestMethod]
        public void Test_CreateTopic()
        {
            // Arrange string replyContent
            Controller.DAOInitialize("Data Source=176.31.248.137;Initial Catalog=user19;Persist Security Info=True;User ID=user19;Password=274user19");
            DAOTopic objDaoTopic = DAOTopic.getInstance();
           
            Topic newTopic = new Topic();
            newTopic.Person.PersonId = 1;
            newTopic.TypeTopic = 1;
            newTopic.Rubric.RubricId = 1;
            newTopic.Title = "UnitTest Title";
            newTopic.Description = "UnitTest Description";
            newTopic.DateAdd = DateTime.Now;
            newTopic.DateUp = newTopic.DateAdd;
            newTopic.Message = "UnitTest Message";

            // Act // Assert
            Assert.IsTrue(objDaoTopic.CreateTopic(newTopic, newTopic.Person.PersonId));
        }

        [TestMethod]
        public void Test_DeleteTopic()
        {
            // Arrange
            DAOTopic objDaoTopic = DAOTopic.getInstance();
            Controller.DAOInitialize("Data Source=176.31.248.137;Initial Catalog=user19;Persist Security Info=True;User ID=user19;Password=274user19");
            // Look at TOPIC table for initialize topicId
            int topicId = 1;
           
            // Act // Assert
            Assert.IsTrue(objDaoTopic.DeleteTopicInDb(topicId));
        }

        [TestMethod]
        public void Test_EditTopic()
        {
            // Arrange
            DAOTopic objDaoTopic = DAOTopic.getInstance();
            Controller.DAOInitialize("Data Source=176.31.248.137;Initial Catalog=user19;Persist Security Info=True;User ID=user19;Password=274user19");

            Topic topic = new Topic();
            topic.TopicId = 3;
            topic.Title = "UnitTest Title Edit";
            topic.Description = "UnitTest Description Edit";
            topic.DateUp = DateTime.Now;

            // Act // Assert
            Assert.IsTrue(objDaoTopic.EditTopicInDb(topic));
        }

        [TestMethod]
        public void Test_GetTopicById()
        {
            // Arrange
            DAOTopic objDaoTopic = DAOTopic.getInstance();
            Controller.DAOInitialize("Data Source=176.31.248.137;Initial Catalog=user19;Persist Security Info=True;User ID=user19;Password=274user19");
            Topic topic = new Topic();

            // Act 
            topic = objDaoTopic.GetTopicById(3);

            // Assert
            Assert.IsTrue(topic.TopicId == 3);
        }
    }
}
