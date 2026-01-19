/*Personalized Meal Plan Generator
o Concepts: Generic Methods, Constraints, Interfaces
o Problem Statement: Design a system where users can choose
different meal categories like Vegetarian, Vegan, Keto, or
High-Protein.
o Hints:
▪ Define an interface IMealPlan with subtypes
(VegetarianMeal, VeganMeal).
▪ Implement a generic class Meal<T> where T : IMealPlan.
▪ Use a generic method to validate and generate meal plans
dynamically.*/

namespace Generic.MealPlan
{
    class Meal
    {
        public void MealDetails()
        {
            Meal<VegetarianMeal> vegMeal = new Meal<VegetarianMeal>();
            vegMeal.AddMeal(new VegetarianMeal { MealName = "Paneer Masala", Calories = 600 });

            Meal<KetoMeal> ketoMeal = new Meal<KetoMeal>();
            ketoMeal.AddMeal(new KetoMeal { MealName = "Egg", Calories = 300 });

            vegMeal.DisplayAll();
            ketoMeal.DisplayAll();

            MealGenerator.GenerateMeal(new VegetarianMeal { MealName = "Brown Bread", Calories = 100 });
        }
    }
}