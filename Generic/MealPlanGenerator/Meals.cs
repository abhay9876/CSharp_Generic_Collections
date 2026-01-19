namespace Generic.MealPlan
{
    class VegetarianMeal : IMealPlan
    {
        public string MealName { get; set; }
        public int Calories { get; set; }

        public void ShowPlan()
        {
            Console.WriteLine($"Vegetarian Meal : {MealName}, Calories : {Calories}");
        }
    }

    class KetoMeal : IMealPlan
    {
        public string MealName { get; set; }
        public int Calories { get; set; }

        public void ShowPlan()
        {
            Console.WriteLine($"Keto Meal : {MealName}, Calories : {Calories}");
        }
    }

}