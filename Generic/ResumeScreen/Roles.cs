namespace Generic.ResumeScreeningSystem
{
    public class SoftwareEngineering : JobRole
    {
        public string Name { get; set; }
        public override void Show()
        {
            Console.WriteLine($"Name : {Name}   Role : SoftWare Engineer");
        }
    }

    public class CloudEngineering : JobRole
    {
        public string Name { get; set; }
        public override void Show()
        {
            Console.WriteLine($"Name : {Name}   Role : Cloud Engineer");
        }
    }
}