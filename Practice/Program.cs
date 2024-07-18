using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Net.Mail;
using Microsoft.VisualBasic;
using Practice;

//Misc excercises-----------------------------------------------------------------------------------------------------------------

/*
Console.WriteLine("Enter the amount of Celsius");
var celsius = int.Parse(Console.ReadLine());

var kelvin = Math.Floor(celsius + 273.15);
var farenheit = (celsius * 9 / 5) + 32;

Console.WriteLine($"Kelvin = {kelvin}");
Console.WriteLine($"Farenheit = {farenheit}");

Console.ReadLine();*/

/* var sentence = "The quick brown fox jumps over the lazy dog.";
  var sentenceModified = sentence[0] + sentence + sentence[0];
  Console.WriteLine(sentenceModified);
  Console.ReadLine();*/


/* Console.WriteLine("Input the first integer");
 var num1 = int.Parse(Console.ReadLine());

 Console.WriteLine("Input the second integer");
 var num2 = int.Parse(Console.ReadLine());

 if(num1 > 0 && num2 < 0 || num1 <0 && num2 > 0)
 {
     bool conditionMet = true;
     Console.WriteLine(conditionMet);
 }
 else
 {
    bool conditionMet = false;
     Console.WriteLine(conditionMet);
 }
 Console.ReadLine();*/


/*var num1 = 3;
var num2 = 3;

if(num1 != num2)
{
    Console.WriteLine(num1 + num2);
}
else
{
    Console.WriteLine((num1 + num2) * 3);
}*/



/*var num1 = 15;
var num2 = 6;

var sum = num1 + num2;
bool isTwenty;

if(sum  == 20 || num1 == 20 || num2 == 20)
{
    isTwenty = true;
}
else
{
    isTwenty= false;
}
Console.WriteLine(isTwenty);*/





/* Console.WriteLine("Input an integer");
 var num = int.Parse(Console.ReadLine());

 bool conditionMet;

 if(num >= 80 && num <= 120 || num >= 180 && num <= 220)
 {
     conditionMet = true;
 }
 else
 {
     conditionMet = false;
 }
 Console.WriteLine(conditionMet);*/





/* string sentence = "Write a C# program to display the following pattern using the alphabet";
 string[] words = sentence.Split(new[] { " " }, StringSplitOptions.None);
 string word = "";
 int ctr = 0;

 foreach (String s in words)
 {

     if (s.Length > ctr)
     {
         word = s; 
         ctr = s.Length; 
     }
 }

 Console.WriteLine(word); 
 Console.ReadLine();*/




/*var sentence = "This is a new sentence that i'm using to find the biggest word";
String[] words = sentence.Split(" ", StringSplitOptions.None);
String biggestWord = " ";
var ctr = 0;
foreach(String word in words)
{
    if(word.Length > ctr)
    {
        biggestWord = word;
        ctr = word.Length;
    }
}
Console.WriteLine(biggestWord);
Console.ReadLine();*/



/*IEnumerable<int> range = Enumerable.Range(1, 99);
foreach (int i in range)
{
    if(i % 2 == 0)
    {
        continue;
    }
    else
    {
        Console.WriteLine(i);
    }
}
Console.ReadLine();*/




/*
Console.WriteLine("\nSum of the first 500 prime numbers: "); 

int sum = 0; 
int ctr = 0; 
int n = 2; 


while (ctr < 500)
{
    if (isPrime(n)) 
    {
        sum += n; 
        ctr++; 
    }
    n++; 
}

Console.WriteLine(sum); 
}


public static bool isPrime(int n)
{
int x = (int)Math.Floor(Math.Sqrt(n)); 

if (n == 1) return false; 
if (n == 2) return true; 


for (int i = 2; i <= x; ++i)
{
    if (n % i == 0) return false; 
}

return true;*/






/* Console.WriteLine("Input a number: ");
 var num = int.Parse(Console.ReadLine());
 var ctr = 0;
 int[] result = num.ToString().Select(o => Convert.ToInt32(o) - 48).ToArray();
 foreach (int i in result)
 {
     ctr += i;
 }
 Console.WriteLine(ctr);*/



/*var filePath = "C:\\Users\\aorourke\\OneDrive - clarkinc.biz\\Desktop\\test.txt";
long length = new System.IO.FileInfo(filePath).Length;
Console.WriteLine(length);
Console.ReadLine();*/


//Exception handeling -------------------------------------------------------------------------------------------------------------




/*try
{
    Console.WriteLine("Please input a number: ");
    var num1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Please input a second number: ");
    var num2 = int.Parse(Console.ReadLine());

    var solution = num1 / num2;

    Console.WriteLine($"The solution is {solution}");
}
catch (FormatException)
{ Console.WriteLine($"invalid input"); }

catch(DivideByZeroException)
{
    Console.WriteLine("Cannot divide by zero.");
}
Console.ReadLine();*/



//Conditional Statements ---------------------------------------------------------------------------------------------------------




/*Console.WriteLine("Enter first number: ");
var num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter second number: ");
var num2 = int.Parse(Console.ReadLine());


if (num1 == num2)
{
    Console.WriteLine("These numbers are equal");
}
else
{
    Console.WriteLine("These numbers are not equal.");
}

Console.ReadLine();*/


/*Console.WriteLine("Enter a number");
int num = int.Parse(Console.ReadLine());

if(num % 2 == 0)
{
    Console.WriteLine("This number is even");
}
else
{
    Console.WriteLine("This number is odd");
}

Console.ReadLine();*/



/* Console.WriteLine("Enter a number");
 int num = int.Parse(Console.ReadLine());

 if(num < 0)
 {
     Console.WriteLine("This number is negative");
 }
 else
 {
     Console.WriteLine("This number is positive");
 }

 Console.ReadLine();*/


/*var age = 17;
if(age >= 18)
{
    Console.WriteLine("You are eligible to vote!");
}
else
{
    Console.WriteLine("You are not eligible to vote");
}

Console.ReadLine();*/





/* Console.WriteLine("Input the first number: ");
 var num1 = int.Parse(Console.ReadLine());

 Console.WriteLine("Input the second number: ");
 var num2 = int.Parse(Console.ReadLine());

 Console.WriteLine("Input the third number: ");
 var num3 = int.Parse(Console.ReadLine());

 List<int> numbers = new List<int>();
 numbers.Add(num1);
 numbers.Add(num2);
 numbers.Add(num3);

 var largest = numbers.Max();

 if(largest == num1)
 {
     Console.WriteLine("The first number is the largest");
 }
 else if(largest == num2)
 {
     Console.WriteLine("The second number is the largest");
 }
 else
 {
     Console.WriteLine("The third number is the largest");
 }

 Console.ReadLine();*/




/*Console.WriteLine("Input the value for x coordinate");
var xselection = int.Parse(Console.ReadLine());

Console.WriteLine("Input the value for y coordinate");
var yselection = int.Parse(Console.ReadLine());

if(xselection > 0 && yselection > 0)
{
    Console.WriteLine($"The coordinate point ({xselection},{yselection}) lies in the First quadrant");
}
else if (xselection > 0 && yselection < 0)
{
    Console.WriteLine($"The coordinate point ({xselection},{yselection}) lies in the Second quadrant");
}
else if (xselection < 0 && yselection < 0)
{
    Console.WriteLine($"The coordinate point ({xselection},{yselection}) lies in the Third quadrant");
}
else 
{
    Console.WriteLine($"The coordinate point ({xselection},{yselection}) lies in the Fourth quadrant");
}

Console.ReadLine();*/






/* var MathReq = 65;
 var PhyReq = 55;
 var ChemReq = 50;
 var TotalReq = 180;

 Console.WriteLine("Input math grade");
 var MathGrade = int.Parse(Console.ReadLine());

 Console.WriteLine("Input physics grade");
 var PhyGrade = int.Parse(Console.ReadLine());

 Console.WriteLine("Input chemistry grade");
 var ChemGrade = int.Parse(Console.ReadLine());

 var TotalGrade = MathGrade + PhyGrade + ChemGrade;

 if(MathGrade > MathReq && ChemGrade > ChemReq && PhyGrade > PhyReq && TotalGrade > 180)
 {
     Console.WriteLine("Candidate is eligable");
 }
 else
 {
     Console.WriteLine("Candidate is not eligable");
 }

 Console.ReadLine();*/


//For loops------------------------------------------------------------------------------------------




/*IEnumerable<int> numbers = Enumerable.Range(1, 10);
var sentence = " ";
var ctr = 0;
foreach (var number in numbers)
{
    sentence += number+" ";
    ctr += number;
}
Console.WriteLine(sentence);
Console.WriteLine($"The sum is {ctr}");
Console.ReadLine();*/



/*var testNum = 7;
IEnumerable<int> numbers = Enumerable.Range(1, testNum);
var sentence = " ";
foreach (var number in numbers)
{
    sentence += number;
}
Console.WriteLine(sentence);*/




/*Console.WriteLine("Input a number to test: ");
var num = int.Parse(Console.ReadLine());

IEnumerable<int> numbers = Enumerable.Range(1, num);

foreach(int i in numbers)
{
    var cube = i * i * i;
    Console.WriteLine($"Number is {i} and the cube of {i} is {cube}");
}
Console.ReadLine();*/





// Guessing game -------------------------------------------------------------------------------------------------------------------



/* Random random = new Random();
 var correctNum = random.Next(1, 10);
 var guessIsCorrect = false;


 while(!guessIsCorrect)
 {
     Console.WriteLine("Pick a number between 1 and 10");
     var userGuess = int.Parse(Console.ReadLine());

     if (userGuess < correctNum)
     {
         Console.WriteLine($"{userGuess} is too low!");
     }
     else if(userGuess > correctNum)
     {
         Console.WriteLine($"{userGuess} is too high");
     }
     else
     {
         Console.WriteLine($"You got it! You guessed {userGuess} and the correct number is {correctNum}");
         guessIsCorrect = true;
     }*/

// Calculator 2.0 -------------------------------------------------------------------------------------------------------






/*var menuIsActive = true;

while (menuIsActive)
{

    displayMenu();
    var selection = Console.ReadLine();
    if (selection == "1")
    {
        add();
    }
    else if (selection == "2")
    {
        subtract();
    }
    else if (selection == "3")
    {
        multiply();
    }
    else if (selection == "4")
    {
        divide();
    }
    else if (selection == "q")
    {
        menuIsActive = false;
    }
    else
    {
        Console.WriteLine("Selection invalid. Please select one of the options from the menu. Press any key to continue");
        Console.ReadLine();
    }

}*/



//arrays------------------------------------------------------------------------------------------------------------------------

/*int[] numbers = new int[10];
var ctr = 1;

for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"Input element {ctr} in the array");
    var number = int.Parse(Console.ReadLine());
    numbers[i] = number;
    ctr++;
}

Console.WriteLine("The 10 elements in the array are as follows");
Console.WriteLine("\n\n");
Console.WriteLine("------------------------------------------------------------------------------");

foreach (var number in numbers)
{
    Console.WriteLine(number);
}
Console.ReadLine();*/


/*Console.WriteLine("Input the number of elements that will be in the array");
var arraySize = int.Parse(Console.ReadLine());

int[] numbers = new int[arraySize];
int[] numbersReversed = new int[arraySize];
var sentenceReversed = " ";
var ctr = 1;
var sentence = " ";

Console.WriteLine($"Input {arraySize} elements in the array:");

for(int i = 0; i < numbers.Length; i++)
{
    var number = int.Parse(Console.ReadLine());
    numbers[i] = number;

    numbersReversed[numbers.Length - ctr] = number;
    ctr++;
}

Console.WriteLine("The numbers in the array are: ");
Console.WriteLine("-----------------------------------");
Console.WriteLine("\n");
foreach (int number in numbers)
{ 
   sentence += number;
}

Console.WriteLine(sentence);
Console.ReadLine();

Console.WriteLine("The numbers in the array reversed are: ");
Console.WriteLine("-----------------------------------");
Console.WriteLine("\n");

foreach (int number in numbersReversed)
{
    sentenceReversed += number;
}
Console.WriteLine(sentenceReversed);
Console.ReadLine();*/



/*var ctr = 0;
Console.WriteLine("input number of elements in the array");
var arraySize = int.Parse(Console.ReadLine());

int[] numbers = new int[arraySize];
for (int i = 0; i < arraySize; i++)
{
    var number = int.Parse(Console.ReadLine());
    numbers[i] = number;
    ctr += number;
}

Console.WriteLine($"Sum of all of the numbers in the array {ctr}");
Console.ReadLine();*/


//Functions -----------------------------------------------------------------------------------------------------------------------
/*myFunction();

sayHello("John");

Console.WriteLine("Input the first number ");
var num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Input the second number ");
var num2 = int.Parse(Console.ReadLine());

addNumbers(num1, num2);*/

/*Console.WriteLine("Enter a sentence then press enter");
var data = Console.ReadLine();

countSpaces(data);*/

/*int[] numbers = new int[3];
numbers[0] = 5;
numbers[1] = 6;
numbers[2] = 7;

countArray(numbers);
static void myFunction()
{
    Console.WriteLine("Welcome Friends!");
    Console.WriteLine("Have a nice day!");
}

static void sayHello(string name)
{
    Console.WriteLine($"Welcome friend {name}!");
    Console.WriteLine("Have a nice day");
}


static void addNumbers(int num1, int num2)
{
    var sum = num1 + num2;
    Console.WriteLine($"The sum of two numbers is {sum}");
}

static void countSpaces(string data)
{
    int whiteSpaces = data.Count(Char.IsWhiteSpace);
    Console.WriteLine($"There are {whiteSpaces} blank spaces in your string");
}

static void countArray(int[] numbers)
{
    var i = 0;
    var ctr = 0;
    foreach (var number in numbers)
    {
        Console.WriteLine($"element {i} : {number}");
        ctr += number;
        i++;
    }
    Console.WriteLine($"The sum of the numbers in the array is {ctr} ");*/

//Delegates practice---------------------------------------------------------------------------------------------------------------
Test testforDelegate = new Test();
testforDelegate.writeSomething();

//These are methods for the calculator app----------------------------------------------------------------------------------------------------

static void displayMenu()
    {
        Console.WriteLine("Welcome to the calculator app!\nSelect 1 for addtion \n Select 2 for subtraction \n Select 3 for multiplication \n Select 4 for division\n Select q to quit");
    }

    static void add()
    {
        Console.WriteLine("Enter first number to add");
        int num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter second number to add");
        int num2 = int.Parse(Console.ReadLine());

        var sum = num1 + num2;
        Console.WriteLine($"{num1} + {num2} = {sum}");
    }

    static void subtract()
    {
        Console.WriteLine("Enter first number to subtract");
        int num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter second number to subtract");
        int num2 = int.Parse(Console.ReadLine());

        var difference = num1 - num2;
        Console.WriteLine($"{num1} - {num2} = {difference}");
    }

    static void multiply()
    {
        Console.WriteLine("Enter first number to multiply");
        int num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter second number to multiply");
        int num2 = int.Parse(Console.ReadLine());

        var product = num1 * num2;
        Console.WriteLine($"{num1} * {num2} = {product}");
    }


    static void divide()
    {
        Console.WriteLine("Enter first number to divide");
        int num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter second number to divide");
        int num2 = int.Parse(Console.ReadLine());

        var quotient = num1 / num2;
        Console.WriteLine($"{num1} / {num2} = {quotient}");
    }
    




 

 
