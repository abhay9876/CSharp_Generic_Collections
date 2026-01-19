

namespace Generic.UniversityManagement
{
     class ExamCourse : CourseType
     {
          public override void Evaluate()
          {
               Console.WriteLine($"{CourseName} : Written Exam.");
          }
     }

     class AssignmentCourse : CourseType
     {
          public override void Evaluate()
          {
               Console.WriteLine($"{CourseName} : Assignments.");
          }
     }
}





