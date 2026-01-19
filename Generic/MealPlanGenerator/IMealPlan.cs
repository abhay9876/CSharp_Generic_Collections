namespace Generic.MealPlan
{
    interface IMealPlan
    {
        string MealName { get; set; }
        int Calories { get; set; }
        void ShowPlan();
    }

}