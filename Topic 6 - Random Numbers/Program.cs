// See https://aka.ms/new-console-template for more information
Random generator = new Random();
int randNum; // Random number stored in this variable

randNum = generator.Next(10);

Console.WriteLine("My random number is " + randNum);

Console.WriteLine("Here are some numbers from 0 to 4!");
Console.Write(generator.Next(5) + " ");
Console.Write(generator.Next(5) + " ");
Console.Write(generator.Next(5) + " ");
Console.Write(generator.Next(5) + " ");
Console.Write(generator.Next(5) + " ");
Console.WriteLine(generator.Next(5) + " ");
Console.WriteLine();

Console.WriteLine("Here are some numbers from 0 to 99!");
Console.Write(generator.Next(100) + " ");
Console.Write(generator.Next(100) + " ");
Console.Write(generator.Next(100) + " ");
Console.Write(generator.Next(100) + " ");
Console.Write(generator.Next(100) + " ");
Console.WriteLine(generator.Next(100) + " ");
Console.WriteLine();

int num1 = generator.Next(10);
int num2 = generator.Next(10);
if (num1 == num2)
{
    Console.WriteLine("The random numbers were the same! Weird.");
}
if (num1 != num2)
{
    Console.WriteLine("The random numbers were different! Not weird. ");
}
Console.WriteLine();

// Task 1
int max, min;
Console.WriteLine("Provide me with a maximum value: ");
max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Provide me with a minimum value smaller than the maximum of " + max + ": ");
min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Here is a random number between " + min + " and " + max + ":");
Console.WriteLine(generator.Next(min, max + 1));
Console.WriteLine();

// Task 2
int guess, secretNumber;
secretNumber = generator.Next(1, 11);
Console.WriteLine("Please guess the secret number.  It could be anything from 1 to 10.");
guess = Convert.ToInt32(Console.ReadLine());
if (guess == secretNumber)
    Console.WriteLine("Congradulations, you guessed it!!");
else
    Console.WriteLine("Sorry but no, the secret number was " + secretNumber);
Console.WriteLine();

// Task 3
int die1, die2, total;
Console.WriteLine("Hit ENTER to roll the dice.");
Console.ReadLine();
die1 = generator.Next(1, 7);
die2 = generator.Next(1, 7);
total = die1 + die2;
Console.WriteLine("Die 1 - " + die1);
Console.WriteLine("Die 2 - " + die2);
Console.WriteLine("Total - " + total);