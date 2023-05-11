// **************************************************
//System.Console.Write("How many numbers do you have: ");
//string numberCountString = System.Console.ReadLine();
//int numberCount = System.Convert.ToInt32(numberCountString);

//int[] numbers = new int[numberCount];

//for (int index = 1; index <= numberCount; index++)
//{
//	System.Console.Write($"[{index}]: ");
//	string numberString = System.Console.ReadLine();
//	int number = System.Convert.ToInt32(numberString);

//	//numbers[index] = number; // Runtime Error!
//	numbers[index - 1] = number;
//}

//int sum = 0;

////for (int index = 0; index <= numberCount - 1; index++)
////{
////}

//for (int index = 0; index <= numbers.Length - 1; index++)
//{
//	sum += numbers[index];
//}

//System.Console.Write($"The sum of these numbers is {sum}");
// **************************************************

// **************************************************
// تر و تمیز شده کد فوق
// **************************************************
//System.Console.Write("How many numbers do you have: ");
//string numberCountString = System.Console.ReadLine();
//int numberCount = System.Convert.ToInt32(numberCountString);

//int[] numbers = new int[numberCount];

//for (int index = 1; index <= numberCount; index++)
//{
//	System.Console.Write($"[{index}]: ");
//	string numberString = System.Console.ReadLine();
//	int number = System.Convert.ToInt32(numberString);

//	numbers[index - 1] = number;
//}

//int sum = 0;

//for (int index = 0; index <= numbers.Length - 1; index++)
//{
//	sum += numbers[index];
//}

//System.Console.Write($"The sum of these numbers is {sum}");
// **************************************************

// **************************************************
System.Console.Write("How many numbers do you have: ");
string numberCountString = System.Console.ReadLine();
int numberCount = System.Convert.ToInt32(numberCountString);

int[] numbers = new int[numberCount];

for (int index = 1; index <= numberCount; index++)
{
	System.Console.Write($"[{index}]: ");
	string numberString = System.Console.ReadLine();
	int number = System.Convert.ToInt32(numberString);

	numbers[index - 1] = number;
}

//for (int index = 0; index <= numbers.Length - 1; index++)
//{
//	System.Console.WriteLine(numbers[index]);
//}

//for (int index = 2; index <= numbers.Length - 1; index++)
//{
//	System.Console.WriteLine(numbers[index]);
//}

//for (int index = 0; index <= numbers.Length - 3; index++)
//{
//	System.Console.WriteLine(numbers[index]);
//}

//for (int index = numbers.Length - 1; index >= 0; index--)
//{
//	System.Console.WriteLine(numbers[index]);
//}

//for (int index = 0; index <= numbers.Length - 1; index++)
//{
//	numbers[index] += 10;

//	System.Console.WriteLine(numbers[index]);
//}

foreach(int number in numbers)
{
	//number += 10; // Number is read only!

	System.Console.WriteLine(number);
}
// **************************************************
