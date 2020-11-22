using System;
namespace TechJobsOO
{
    public class Job
    {
        public int Id { get; }
        private static int nextId = 1;

        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }

        // TODO: Add the two necessary constructors.
        public Job()
        {
            Id = nextId;
            nextId++;
        }

        public Job(string name, Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency jobCoreCompetency) : this()
        {
            this.Name = name;
            this.EmployerName = employerName;
            this.EmployerLocation = employerLocation;
            this.JobType = jobType;
            this.JobCoreCompetency = jobCoreCompetency;
        }

        public override bool Equals(object obj)
        {
            return obj is Job job &&
                   Id == job.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public string EnteredString(string value) 
        {
            string enteredValue;

            if (value == "" || value == null)
            {
                enteredValue = "Data not available";
            }
            else
            {
                enteredValue = value;
            }
            return enteredValue;
        }
        public override string ToString()
        {
            return $"\nId: {Id}\nName: {EnteredString(Name)}\nEmployer: {EnteredString(EmployerName.Value)}\nLocation: {EnteredString(EmployerLocation.Value)}\nPosition Type: {EnteredString(JobType.Value)}\nCore Competency: {EnteredString(JobCoreCompetency.Value)}\n";
        }

    }
}
