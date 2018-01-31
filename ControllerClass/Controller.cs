using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessClassPortable;
using DAOClass;

namespace BusinessClassPortable
{
    /// <summary>
    /// Controller class to respect the architecture of the specifications
    /// Enables interaction between the presentation layer and the data access layer
    /// </summary>
    public static class Controller
    {
        // DAO Object
        private static DAOLogin _objDaoLogin;
        private static DAORubric _objDaoRubric;
        private static DAOTopic _objDaoTopic;
        private static DAOTopicReply _objDaoTopicReply;

        /// <summary>
        /// Initialize DAO
        /// </summary>
        /// <param name="connexionString">Connection chain</param>
        public static void DAOInitialize(string connexionString)
        {
            _objDaoLogin = DAOLogin.getInstance();
            _objDaoLogin.ConnectionString = connexionString;
            _objDaoTopic = DAOTopic.getInstance();
            _objDaoTopic.ConnectionString = connexionString;
            _objDaoRubric = DAORubric.getInstance();
            _objDaoRubric.ConnectionString = connexionString;
            _objDaoTopicReply = DAOTopicReply.getInstance();
            _objDaoTopicReply.ConnectionString = connexionString;
        }

        /// <summary>
        /// Uses the method of retrieval of the last sections in db
        /// </summary>
        /// <returns>rubric list</returns>
        public static List<Rubric> GetListRubrics()
        {
            _objDaoRubric = DAORubric.getInstance();
            return _objDaoRubric.GetListRubric();
        }

        /// <summary>
        /// Uses the method of retrieval latest ten topic in the db
        /// </summary>
        /// <returns>topic list</returns>
        public static List<Topic> GetLastTopicTop10()
        {
            _objDaoTopic = DAOTopic.getInstance();
            return _objDaoTopic.GetLastTopicTop10();
        }

        /// <summary>
        /// Uses the method of retrieval the last ten topics from the rubric in the db
        /// </summary>
        /// <param name="rubricId">id of the rubric</param>
        /// <returns>topic list</returns>
        public static List<Topic> GetLastTopicTop10ById(int rubricId)
        {
            _objDaoTopic = DAOTopic.getInstance();
            return _objDaoTopic.GetLastTopicTop10ById(rubricId);
        }

        /// <summary>
        /// Uses the user verification method and password in the db
        /// </summary>
        /// <param name="login">User first name</param>
        /// <param name="pass">User password</param>
        /// <returns>object person</returns>
        public static Person CheckAccess(string login, string pass)
        {
            _objDaoLogin = DAOLogin.getInstance();
            return _objDaoLogin.CheckAccess(login, pass);
        }

        /// <summary>
        /// Uses the method of creating a topic in the db
        /// </summary>
        /// <param name="topic">the topic</param>
        /// <param name="personId">user id</param>
        public static void CreateTopic(Topic topic, int personId)
        {
            _objDaoTopic = DAOTopic.getInstance();
            _objDaoTopic.CreateTopic(topic, personId);
        }

        /// <summary>
        /// Uses the method of retrieving the last ten messages in db
        /// </summary>
        /// <param name="topicId">topic id</param>
        /// <returns>message list</returns>
        public static List<Message> GetTopicReplyTop10(int topicId)
        {
            _objDaoTopicReply = DAOTopicReply.getInstance();
            return _objDaoTopicReply.GetTopicReplyTop10(topicId);
        }

        /// <summary>
        /// Uses the method of deleting a message in db
        /// </summary>
        /// <param name="personId">person id</param>
        /// <param name="topicReplyId">message id</param>
        public static void DeleteTopicReplyById(int personId, int topicReplyId)
        {
            _objDaoTopicReply = DAOTopicReply.getInstance();
            _objDaoTopicReply.DeleteTopicReplyById(personId, topicReplyId);
        }

        /// <summary>
        /// Uses the method of retrieving a topic in db
        /// </summary>
        /// <param name="topicId">topic id</param>
        /// <returns>topic</returns>
        public static Topic GetTopicById(int topicId)
        {
            _objDaoTopic = DAOTopic.getInstance();
            return _objDaoTopic.GetTopicById(topicId);
        }

        /// <summary>
        /// Uses the method of editing a topic in db
        /// </summary>
        /// <param name="topic">topic</param>
        public static void EditTopicInDb(Topic topic)
        {
            _objDaoTopic = DAOTopic.getInstance();
            _objDaoTopic.EditTopicInDb(topic);
        }

        /// <summary>
        /// Uses the method of deleting a topic in db
        /// </summary>
        /// <param name="topicId">topic id</param>
        public static void DeleteTopicInDb(int topicId)
        {
            _objDaoTopic = DAOTopic.getInstance();
            _objDaoTopic.DeleteTopicInDb(topicId);
        }

        /// <summary>
        /// Uses the method of adding a message in db
        /// </summary>
        /// <param name="message">message</param>
        public static void AddNewTopicReply(Message message)
        {
            _objDaoTopicReply = DAOTopicReply.getInstance();
            _objDaoTopicReply.AddNewTopicReply(message);
        }

        /// <summary>
        /// Uses the password change method in db
        /// </summary>
        /// <param name="personId">person id</param>
        /// <param name="password">new password</param>
        /// <returns>true if success</returns>
        public static bool UpdatePassword(int personId, string password)
        {
            _objDaoLogin = DAOLogin.getInstance();
            return _objDaoLogin.UpdatePassword(personId, password);
        }

        /// <summary>
        /// Uses the voting method of a topic in db
        /// </summary>
        /// <param name="topicReplyId">message id</param>
        /// <param name="personId">person id</param>
        public static void UpdateVoteTopicReply(int topicReplyId, int personId)
        {
            _objDaoTopicReply = DAOTopicReply.getInstance();
            _objDaoTopicReply.UpdateVoteTopicReply(topicReplyId, personId);
        }

        /// <summary>
        /// Uses the voting verification method of a topic in db
        /// </summary>
        /// <param name="topicReplyId">message id</param>
        /// <param name="personId">person id</param>
        /// <returns>true if the person has already voted</returns>
        public static bool CheckVoted(int topicReplyId, int personId)
        {
            _objDaoTopicReply = DAOTopicReply.getInstance();
            return _objDaoTopicReply.CheckVoted(topicReplyId, personId);
        }
    }
}
