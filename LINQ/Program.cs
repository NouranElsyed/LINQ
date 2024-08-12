using System.Globalization;

namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Implicitly type local varible [var,dynamic]
            //var Data01 = "Ahmed";
            //var x = 2;
            //var y; // invalid
            //var Z = null; //invalid 
            // x = "Noura"; // invalid
            //===================
            dynamic Data02 = "Ahmed";
            dynamic x = 2;
            dynamic y; // valid
            dynamic Z = null; //valid 
            x = "Noura"; // valid

            #endregion
            #region Extension Methods
            //int num = 12345;
            //Console.WriteLine(num.Reverse());

            #endregion
            #region Anonynous Types
            //var emp01 = new { Id = 1 , Name="Nouran" , Salary = 10000};
            //var emp02 = new  { Id = 2, Name = "Yomna", Salary = 80000 };

            //var emp03 = emp01;
            //var emp04 = emp02 with { Id=4};
            //if (emp01.Equals(emp03)) 
            //{
            //    Console.WriteLine("equals");
            //}

            #endregion
            #region LINQ 
            #endregion
            //List<int> Numbers = new List<int>() { 1,2,3,4,5,6};
            //var Result = Enumerable.Where(Numbers,N => N%2==0)
            //var Result = Numbers.Where(N => N % 2 == 0);
            //Numbers.Any();
            //var Result = Enumerable.Range(1,100);
            //Numbers.AddRange(new int[] { 7, 8, 9, 10 });

            //foreach (var item in Result)
            //{
            //    Console.Write($"{item} ");
            //}

            //Console.WriteLine(ListGenerator.ProductsList[0]);
            //Console.WriteLine(ListGenerator.CustomersList[0]);

            #region
            #endregion
        }
    }
}
