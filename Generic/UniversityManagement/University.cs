/*Multi-Level University Course Management System
o Concepts: Generic Classes, Constraints, Variance

o Problem Statement: Develop a university course management
system where different departments offer courses with different
evaluation types.
o Hints:
▪ Create an abstract class CourseType (e.g., ExamCourse,
AssignmentCourse).
▪ Implement a generic class Course<T> where T : CourseType
to manage different courses.
▪ Use List<T> to handle any type of course dynamically.*/


namespace Generic.UniversityManagement{
    class University{
        

   public void UniversityDetails()
    {
        Course<ExamCourse> examDept = new Course<ExamCourse>();
        examDept.AddCourse(new ExamCourse { CourseName = "C# Generic" });

        Course<AssignmentCourse> assignmentDept = new Course<AssignmentCourse>();
        assignmentDept.AddCourse(new AssignmentCourse { CourseName = "C# Advance" });

        examDept.EvaluateAll();
        assignmentDept.EvaluateAll();
    }


    }
}