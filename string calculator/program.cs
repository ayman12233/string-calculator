class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine(Calculator.Add("2,3"));  
            Console.WriteLine(Calculator.Add("1,abc")); 
            Console.WriteLine(Calculator.Add("1"));     
            Console.WriteLine(Calculator.Add("1,2,3")); 
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
