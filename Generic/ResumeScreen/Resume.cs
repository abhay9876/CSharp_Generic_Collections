namespace Generic.ResumeScreeningSystem
{
    public class Resume<T> where T : JobRole
    {
        private List<JobRole> roles = new List<JobRole>();

        public void AddResume(T role)
        {
            roles.Add(role);
        }
        public void ShowAll()
        {
            foreach (T role in roles)
            {
                role.Show();
            }
        }

    }
}