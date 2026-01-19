/*AI-Driven Resume Screening System
o Concepts: Generic Classes, Generic Methods, Constraints
o Problem Statement: Develop a resume screening system that can
process resumes for different job roles while ensuring type safety.
o Hints:

▪ Create an abstract class JobRole (SoftwareEngineer,
DataScientist).
▪ Implement a generic class Resume<T> where T : JobRole to
process resumes dynamically.
▪ Use List<T> to handle multiple job roles in the screening
pipeline.*/


namespace Generic.ResumeScreeningSystem
{
    class ResumeScreen
    {
        public void Screening()
        {
            Resume<SoftwareEngineering> sf = new Resume<SoftwareEngineering>();
            sf.AddResume(new SoftwareEngineering { Name = "Abhay" });
            sf.AddResume(new SoftwareEngineering { Name = "JayKant" });
            sf.AddResume(new SoftwareEngineering { Name = "Lucky" });

            Resume<CloudEngineering> cl = new Resume<CloudEngineering>();
            cl.AddResume(new CloudEngineering { Name = "Sai" });
            cl.AddResume(new CloudEngineering { Name = "Prasant" });

            sf.ShowAll();
            cl.ShowAll();

        }
    }
}