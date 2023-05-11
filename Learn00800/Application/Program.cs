// **************************************************
//while(1 == 1)
//{
//	System.Console.WriteLine("Hello, World!");
//}
// **************************************************

// **************************************************
//int count = 5;
//int index = 1;

//while(index <= count)
//{
//	System.Console.WriteLine("Hello, World!");
//}
// **************************************************

// **************************************************
//int count = 5;
//int index = 1;

//while (index <= count)
//{
//	System.Console.WriteLine("Hello, World!");

//	//index = index + 1;
//	//index += 1;
//	//++index;
//	index++;
//}
// **************************************************

// **************************************************
//int count = 5;
//int index = 1;

//while (index <= count)
//{
//	System.Console.WriteLine(index);

//	index++;
//}
// **************************************************

// **************************************************
//int count = 20;
//int index = 1;

//while (index <= count)
//{
//	System.Console.WriteLine(index);

//	//index = index + 2;
//	index += 2;
//}
// **************************************************

// **************************************************
//int count = 100;
//int index = 7;

//while (index <= count)
//{
//	System.Console.WriteLine(index);

//	index += 7;
//}
// **************************************************

// **************************************************
//int number = 10;
//int index = 1;

//while (index <= number)
//{
//	System.Console.WriteLine(index);

//	index++;
//}
// **************************************************

// **************************************************
//string firstName;
//long resultNumber;

//string strFirstName; // استاندارد منسوخ شده
//long lngResultNumber; // استاندارد منسوخ شده

//string firstNameString;
//long resultNumberLong;
// **************************************************

// **************************************************
//System.Console.Write("What is your number: ");
//string numberString = System.Console.ReadLine();
//int number = System.Convert.ToInt32(numberString);

//int sum = 0;
//int index = 1;

//while (index <= number)
//{
//	//System.Console.WriteLine(index);

//	//sum = sum + index;
//	sum += index;

//	index++;
//}

//string message = "The sum of these numbers is " + sum;
//System.Console.WriteLine(message);
// **************************************************

// **************************************************
System.Console.Write("What is your number: ");
string numberString = System.Console.ReadLine();
int number = System.Convert.ToInt32(numberString);

int index = 1;
int result = 1;

while (index <= number)
{
	result *= index;

	index++;
}

string message = "The" + " " + number + "! is equal to " + result;
System.Console.WriteLine(message);
// **************************************************
