Random random = new Random();
int randomNumber = random.Next(10, 100);
Console.WriteLine(randomNumber);

int lastNumber = randomNumber % 10;
int firstNumber = randomNumber / 10;

if(lastNumber>firstNumber)
{
    Console.WriteLine($"Максимальное число равно {lastNumber}");
}
else
{
    Console.WriteLine($"Максимальное число равно {firstNumber}");
}