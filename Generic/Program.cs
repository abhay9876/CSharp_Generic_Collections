using System;
using Generic.WarehouseSystem;
using Generic.Market_Place;
using Generic.UniversityManagement;
using Generic.MealPlan;
using Generic.ResumeScreeningSystem;
namespace Generic
{
    class Program
    {
        public static void Main(string[] args)
        {


            Warehouse wr = new Warehouse();
            wr.WarehouseDetail();



            MarketPlace mp = new MarketPlace();
            mp.MarketPlaceDetails();


            University uni = new University();
            uni.UniversityDetails();


            Meal ml = new Meal();
            ml.MealDetails();

            ResumeScreen rs = new ResumeScreen();
            rs.Screening();
        }
    }
}