using BusinessClassPortable;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace UnitTestProject.TestDAO
{
    [TestClass]
    public class TestDAORubric
    {
        [TestMethod]
        public void Test_GetListRubric_Ok()
        {
            // Arrange
            List<Rubric> rubricListExpected = new List<Rubric>();
            rubricListExpected.Add(new Rubric(1, "Développement"));
            rubricListExpected.Add(new Rubric(2, "Adresses utiles"));
            rubricListExpected.Add(new Rubric(3, "Questions diverses"));
            rubricListExpected.Add(new Rubric(4, "Espace Détente"));
            Controller.DAOInitialize("Data Source=176.31.248.137;Initial Catalog=user19;Persist Security Info=True;User ID=user19;Password=274user19");

            // Act
            List<Rubric> rubricListActual = new List<Rubric>();
            foreach (Rubric rubric in Controller.GetListRubrics())
                rubricListActual.Add(rubric);

            // Assert
            CollectionAssert.AreEqual(rubricListExpected, rubricListActual);
        }
    }
}
