

Console.WriteLine("Please enter the number: ");
int n = int.Parse(Console.ReadLine());
var sum = 0;
while (n > 0)
{
    sum += n % 10; 
    n = n / 10;
}
Console.WriteLine("Sum of the digits is: " + sum);
