using System;

namespace TupleAfterBeing
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var labs = Labs();
            var cats = Cats();
            var mainexam = MainExam();
            var labtotal = labs.Value.Lab1 + labs.Value.Lab2 + labs.Value.Lab3;
            var cattotal = cats.Value.Cat1 + cats.Value.Cat2 + cats.Value.Cat3;

            var mainExaTota = mainexam.Value.Calculus + mainexam.Value.Cnt + mainexam.Value.Geometry +
                              mainexam.Value.Ode + mainexam.Value.Thermo + mainexam.Value.Phy;
            var totalmarks = labtotal + cattotal + mainExaTota;
            Console.WriteLine(totalmarks);
            Console.ReadKey();
        }


        private static (double? Cat1, double? Cat2, double? Cat3)? Cats()
        {
            double cat1 = 10;
            double cat2 = 8;
            double cat3 = 7;
            return (cat1, cat2, cat3);
        }

        private static (double? Lab1, double? Lab2, double? Lab3)? Labs()
        {
            var lab1 = 6;
            var lab2 = 5;
            var lab3 = 7;
            return (lab1, lab2, lab3);
        }

        private static (double? Phy, double? Thermo, double? Cnt, double? Ode, double? Calculus, double? Geometry,
            string)? MainExam()
        {
            double? phy = 60;
            double? thermo = 75;
            double? cnt = 65;
            double? ode = 80;
            double? calculus = 68;
            double? geometry = 74;


            return (phy, thermo, cnt, ode, calculus, geometry, "This have been the marks for this student");
        }
    }
}