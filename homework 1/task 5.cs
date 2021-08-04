using System;

public class Class1
{
	public Class1()
	{
		String res = "";
		int obratnoe = 0;
		for (; n > 9;)
		{
			res += (n % 10).ToString();
			n = n / 10;
		}
		res += n.ToString();
		obratnoe = Convert.ToInt(res);
		Console.WriteLine(res);
		Console.ReadLine();
	}
}
