using System.Runtime.CompilerServices;

long bigOne = long.MaxValue;
Console.WriteLine(bigOne);


int number = ExplicitCast(bigOne);
if (number == bigOne)
    Console.WriteLine(number);

long smallOne = 32659845;
Console.WriteLine(smallOne);

number = ExplicitCast(smallOne);
    if (number == smallOne)

    Console.WriteLine(number);


static int ExplicitCast(long number)
{
    int temp = 0;
    {
        if (number > int.MaxValue)
        {
            Console.WriteLine("IT DOESN'T WORK BUDDY !");
        }
        else
        {

            number = (int)number;  // Ici on convertie le long 'bigOne' a un int 'temp' 
        }

        return number;
    }
}