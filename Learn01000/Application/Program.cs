// **************************************************
System.Console.Write("What is you number: ");
string numberString = System.Console.ReadLine();
int number = System.Convert.ToInt32(numberString);

int i = 0;
int j = 1;

if(j <= number)
{
	System.Console.WriteLine(j);

	int k = i + j;

	while (k <= number)
	{
		System.Console.WriteLine(k);

		i = j;
		j = k;
		k = i + j;
	}
}
// **************************************************
