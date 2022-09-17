for (int i = 1; i <= 100; i++)
{
    var output = "";
    
    if (i % 3 == 0)
    {
      output += "Fizz";
    }

    if (i % 5 == 0)
    {
      output += "Bazz";
    }

    if (i % 7 == 0)
    {
      output += "Jazz";
    }

    if (!output.Equals(""))
    {
      Console.WriteLine(output);
    }
    else
    {
      Console.WriteLine(i);
    }
}