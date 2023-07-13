// **************************************************
//System.Console.WriteLine("Hello, World!");
// **************************************************

// **************************************************
//string x;
//x = "Dariush Tasdighi";
//System.Console.WriteLine(x);
// **************************************************

// **************************************************
//string x = "Dariush Tasdighi";
//System.Console.WriteLine(x);
// **************************************************

// **************************************************
// تاکتیک
// **************************************************

// **************************************************
//string fullName = "Dariush Tasdighi";
//System.Console.WriteLine(fullName);
// **************************************************

// **************************************************
//string fullName = System.Console.ReadLine();
//System.Console.WriteLine(fullName);
// **************************************************

// **************************************************
//System.Console.WriteLine("What is your full name:");
//string fullName = System.Console.ReadLine();
//System.Console.WriteLine(fullName);
// **************************************************

// **************************************************
//System.Console.Write("What is your full name:");
//string fullName = System.Console.ReadLine();
//System.Console.WriteLine(fullName);
// **************************************************

// **************************************************
//System.Console.Write("What is your full name: ");
//string fullName = System.Console.ReadLine();
//System.Console.WriteLine(fullName);
// **************************************************

// **************************************************
//System.Console.Write("What is your first name: ");
//string firstName = System.Console.ReadLine();

//System.Console.Write("What is your last name: ");
//string lastName = System.Console.ReadLine();

////string fullName = firstName + lastName;
////string fullName = firstName + "" + lastName;
//string fullName = firstName + " " + lastName;

//System.Console.WriteLine(fullName);
// **************************************************

// **************************************************
//System.Console.Write
//	("What is your first name: ");

//string firstName =
//	System.Console.ReadLine();

//System.Console.Write
//	("What is your last name: ");

//string lastName =
//	System.Console.ReadLine();

//string fullName =
//	firstName + " " + lastName;

//System.Console.WriteLine(fullName);
// **************************************************

// **************************************************
//System.Console.Write
//	("What is your first name: ");

//string firstName =
//	System.Console.ReadLine();

//System.Console.Write
//	("What is your last name: ");

//string lastName =
//	System.Console.ReadLine();

////string fullName =
////	firstName + " " + lastName;

////string fullName = string.Format
////	("{0} {1}", firstName, lastName);

//string fullName =
//	$"{firstName} {lastName}";

//System.Console.WriteLine(fullName);
// **************************************************

// **************************************************
//int temperature = 40;
////int temperature = 32;

//if (temperature > 35)
//{
//	System.Console.WriteLine("It's too hot!");
//}
// **************************************************

// **************************************************
//int temperature = 40;
////int temperature = 32;

//if (temperature > 35)
//{
//	System.Console.WriteLine("It's too hot!");
//}
//else
//{
//	System.Console.WriteLine("It's OK!");
//}
// **************************************************

// **************************************************
//int temperature = 40;
////int temperature = 32;
////int temperature = 22;

//if (temperature > 35)
//{
//	System.Console.WriteLine("It's too hot!");
//}
//else
//{
//	if (temperature > 24)
//	{
//		System.Console.WriteLine("It's OK!");
//	}
//	else
//	{
//		System.Console.WriteLine("It's too cold!");
//	}
//}
// **************************************************

// **************************************************
//if (1 == 1)
//{
//	System.Console.WriteLine("Hello, World!");
//}

//while (1 == 1)
//{
//	System.Console.WriteLine("Hello, World!");
//}
// **************************************************

// **************************************************
//int number = 1;

//number = number + 1; // Expression, Operator, Operand

//number += 1;

//number++;
//++number;
// **************************************************

// **************************************************
//int number = 1;

//while(number <= 10)
//{
//	System.Console.WriteLine(number);

//	number++;
//}
// **************************************************

// **************************************************
//int number = 1;

//while (number <= 10)
//{
//	System.Console.WriteLine(number);

//	number += 2;
//}
// **************************************************

// **************************************************
//int number = 1;

//while (number <= 100)
//{
//	System.Console.WriteLine(number);

//	number += 7;
//}
// **************************************************

// **************************************************
//int firstNumber = 10;
//int firstNumberInt = 10;

//string fullName = "Dariush Tasdighi";
//string fullNameString = "Dariush Tasdighi";
// **************************************************

// **************************************************
//System.Console.Write
//	("What is your maximum number: ");

//string maximumNumberString =
//	System.Console.ReadLine();

//int maximumNumber =
//	System.Convert.ToInt32(maximumNumberString);

//int number = 1;

//while (number <= maximumNumber)
//{
//	System.Console.WriteLine(number);

//	number++;
//}
// **************************************************

// **************************************************
//System.Console.Write
//	("What is your maximum number: ");

////string maximumNumberString =
////	System.Console.ReadLine();

////int maximumNumber =
////	System.Convert.ToInt32(maximumNumberString);

//int maximumNumber = System.Convert
//	.ToInt32(System.Console.ReadLine());

//int number = 1;

//while (number <= maximumNumber)
//{
//	System.Console.WriteLine(number);

//	number++;
//}
// **************************************************

// **************************************************
//int index = 1;

//int sum = 0;

//while (index <= 5)
//{
//	sum += index;
//	//sum = sum + index;

//	//System.Console.WriteLine(index);

//	index++;

//	//System.Console.WriteLine(sum);
//}

//System.Console.WriteLine(sum);
// **************************************************

// **************************************************
//int sum = 0;
//int index = 1;

//while (index <= 5)
//{
//	sum += index;

//	index++;
//}

//System.Console.WriteLine(sum);
// **************************************************

// **************************************************
//int sum = 1;
//int index = 1;

//while (index <= 5)
//{
//	sum *= index;

//	index++;
//}

//System.Console.WriteLine(sum);
// **************************************************

// **************************************************
System.Console.Write
	("How many numbers do you have: ");

string numberCountString =
	System.Console.ReadLine();

int numberCount = System
	.Convert.ToInt32(numberCountString);

int sum = 0;
int index = 1;

while (index <= numberCount)
{
	System.Console.Write($"{index}: ");

	string numberString =
		System.Console.ReadLine();

	int number = System
		.Convert.ToInt32(numberString);

	sum += number;

	index++;
}

System.Console.WriteLine
	($"The sum of these numbers is {sum}.");
// **************************************************











// **************************************************
//while(1 == 1)
//{
//	System.Console.WriteLine("Hello, World!");
//}
// **************************************************

// **************************************************
//int number = 5;
//int index = 1;

//while(index <= number)
//{
//	System.Console.WriteLine("Hello, World!");
//}
// **************************************************

// **************************************************
//int number = 5;
//int index = 1;

//while (index <= number)
//{
//	System.Console.WriteLine("Hello, World!");

//	//index = index + 1;
//	//index += 1;
//	//++index;
//	index++;
//}
// **************************************************

// **************************************************
//int number = 5;
//int index = 1;

//while (index <= number)
//{
//	System.Console.WriteLine(index);

//	index++;
//}
// **************************************************

// **************************************************
//int number = 20;
//int index = 1;

//while (index <= number)
//{
//	System.Console.WriteLine(index);

//	//index = index + 2;
//	index += 2;
//}
// **************************************************

// **************************************************
//int number = 100;
//int index = 7;

//while (index <= number)
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
//System.Console.Write("What is your number: ");
//string numberString = System.Console.ReadLine();
//int number = System.Convert.ToInt32(numberString);

//int index = 1;
//int result = 1;

//while (index <= number)
//{
//	result *= index;

//	index++;
//}

//string message = "The" + " " + number + "! is equal to " + result;
//System.Console.WriteLine(message);
// **************************************************
