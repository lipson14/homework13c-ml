namespace homework13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 10, 20, 30, 40 };
            List<string> names = new List<string> { "Mari", "Nino", "Giorgi" };

            numbers.PrintReverse();                       
            Console.WriteLine(numbers.GetFirstElement()); 
            Console.WriteLine(names.GetLastElement());    
            Console.WriteLine(numbers.ContainsElement(30)); 
            Console.WriteLine(names.CountElements());     
            Console.WriteLine(names.FindIndex("Nino"));   
            Console.WriteLine(names.FindIndex("Luka"));
        }
    }
}
