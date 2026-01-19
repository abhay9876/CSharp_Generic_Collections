
namespace Generic.UniversityManagement
{
    class Course<T> where T : CourseType
    {
        private List<T> courses = new List<T>();

        public void AddCourse(T course)
        {
            courses.Add(course);
        }

        public void EvaluateAll()
        {
            foreach (T course in courses)
            {
                course.Evaluate();
            }
        }
    }
}
