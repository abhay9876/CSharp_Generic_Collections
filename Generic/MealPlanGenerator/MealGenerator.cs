namespace Generic.MealPlan
{
    class MealGenerator
    {
        public static void GenerateMeal<T>(T meal) where T : IMealPlan
        {
            if (meal.Calories < 200)
                Console.WriteLine("Warning: Calories too low!");

            meal.ShowPlan();
        }
    }

}