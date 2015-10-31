namespace School.Test
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class StudentTest
    {
        [TestMethod]
        public void TestStudentName()
        {
            Student pesho = new Student("Pesho", 10001);
            Assert.AreEqual("Pesho", pesho.Name);
        }

        [TestMethod]
        public void TestStudentNumber()
        {
            Student pesho = new Student("Pesho", 10001);
            Assert.AreEqual(10001, pesho.Number);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestStudentWithNullName()
        {
            new Student(null, 10001);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestStudentWithEmptyName()
        {
            Student invalid = new Student(string.Empty, 10001);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestStudentWithLowerIdNumber()
        {
            Student invalid = new Student("Pesho", 1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestStudentWithHigherIdNumber()
        {
            Student invalid = new Student("Pesho", 100000);
        }
    }
}
