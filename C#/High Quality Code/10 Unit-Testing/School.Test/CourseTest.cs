namespace School.Test
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class CourseTest
    {
        [TestMethod]
        public void TestAddStudent()
        {
            Course course = new Course();
            Student pesho = new Student("Pesho", 10000);
            course.AddStudent(pesho);
            Assert.AreEqual(1, course.StudentsCount);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestAddNullStudent()
        {
            Course course = new Course();
            Student pesho = null;
            course.AddStudent(pesho);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestAddMoreThan29Students()
        {
            Course course = new Course();
            int studentsCount = 35;
            for (int i = 0; i < studentsCount; i++)
            {
                Student pesho = new Student("Pesho", 10000);
                course.AddStudent(pesho);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestAddStudentWithExistingNumber()
        {
            Course course = new Course();
            Student pesho = new Student("Pesho", 10000);
            course.AddStudent(pesho);
            Student gosho = new Student("Gosho", 10000);
            course.AddStudent(gosho);
        }

        [TestMethod]
        public void TestRemoveStudent()
        {
            Course course = new Course();
            Student pesho = new Student("Pesho", 10000);
            course.AddStudent(pesho);
            Assert.AreEqual(1, course.StudentsCount);
            course.RemoveStudent(pesho);
            Assert.AreEqual(0, course.StudentsCount);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestRemoveNullStudent()
        {
            Course course = new Course();
            Student pesho = null;
            course.RemoveStudent(pesho);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestRemoveInvalidStudent()
        {
            Course course = new Course();
            Student pesho = new Student("Pesho", 10000);
            course.AddStudent(pesho);
            Student gosho = new Student("Gosho", 10001);
            course.RemoveStudent(gosho);
        }
    }
}
