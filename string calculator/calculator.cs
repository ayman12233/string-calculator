public class Calculator
{
    public static int Add(string numbers)
    {
        if (string.IsNullOrEmpty(numbers))
        {
            return 0;
        }

        string[] numberArray = numbers.Split(',');

        if (numberArray.Length != 2)
        {
            throw new ArgumentException("Le format du nombre doit être de la forme 'x,y'.");
        }

        if (int.TryParse(numberArray[0], out int x) && int.TryParse(numberArray[1], out int y))
        {
            return x + y;
        }
        else
        {
            throw new ArgumentException("Les valeurs x et y doivent être des nombres entiers valides.");
        }
    }
}
