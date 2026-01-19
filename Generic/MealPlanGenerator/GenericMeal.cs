namespace Generic.MealPlan
{
    class Meal<T> where T : IMealPlan
    {
        private List<T> mealPlans = new List<T>();

        public void AddMeal(T meal)
        {
            mealPlans.Add(meal);
        }

        public void DisplayAll()
        {
            foreach (var meal in mealPlans)
            {
                meal.ShowPlan();
            }
        }
    }

}