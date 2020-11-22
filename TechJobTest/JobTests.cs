using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobTest
{
    [TestClass]
    public class JobTests
    {
        [TestMethod]
        public void TestSettingJobId()
        {
            Job job1 = new Job();
            Job job2 = new Job();

            Assert.AreEqual(job1.Id, job2.Id-1, .001);
            
        }

        [TestMethod]
        public void TestFullConstructor()
        {
            Job job1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

            Assert.AreEqual(job1.Name, "Product tester");
            Assert.AreEqual(job1.EmployerName.Value, "ACME");
            Assert.AreEqual(job1.EmployerLocation.Value, "Desert");
            Assert.AreEqual(job1.JobType.Value, "Quality control");
            Assert.AreEqual(job1.JobCoreCompetency.Value, "Persistence");
        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            Job job1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Job job2 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

            Assert.IsFalse(job1.Equals(job2));
        }

        [TestMethod]
        public void TestToStringMethodFirstLineBlank()
        {
            Job job1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            string toString = job1.ToString();

            Assert.AreEqual(toString[0], '\n');
            Assert.AreEqual(toString[toString.Length - 1], '\n');
        }

        [TestMethod]
        public void TestStringMethodLabels()
        {
            Job job1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            string toString = job1.ToString();

            Assert.IsTrue(toString.Contains("\nId: "));

            Assert.IsTrue(toString.Contains("\nName: "));
            Assert.IsTrue(toString.Contains("\nEmployer: "));
            Assert.IsTrue(toString.Contains("\nLocation: "));
            Assert.IsTrue(toString.Contains("\nPosition Type: "));
            Assert.IsTrue(toString.Contains("\nCore Competency: "));
        }

        [TestMethod]
        public void TestToStringFieldValues()
        {
            Job job1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            //string toString = job1.ToString();

            Assert.AreEqual(job1.Name, "Product tester");
            Assert.AreEqual(job1.EmployerName.Value, "ACME");
            Assert.AreEqual(job1.EmployerLocation.Value, "Desert");
            Assert.AreEqual(job1.JobType.Value, "Quality control");
            Assert.AreEqual(job1.JobCoreCompetency.Value, "Persistence");
        }

    }
}
