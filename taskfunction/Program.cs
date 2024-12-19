#region AllFunction

//task1
string FullName(string name)
{
    return  name;
}

//task2
 double volue( double width, double height, double length)
{

    return width * height * length;
}


//task3
int number( int num)
{

    if (num % 2 == 0)
    {
        return num*2;
    }
    else
    {
        return num* num;
    }
}

//task4
double Celsius( double temp)
{

    return (temp * 9 / 5) + 32;
}


//task5
string letters(char check){
    if (check == 'a' || check == 'o' || check == 'u' || check == 'i' || check == 'e' )
    {
        return "vowel";
            }

    else
    {
        return "constant";
    }

}

//task6
double currency( double originalAmount, double conversionRate)
{
    double converstionAmount= originalAmount * conversionRate;
    return converstionAmount;

}


#endregion










#region Callfunction
//task1
//Console.WriteLine(" welcome " + Console.ReadLine());
Console.WriteLine("enter your name ");
string name = Console.ReadLine();
Console.WriteLine("welcome    " + FullName(name));

//task2
Console.WriteLine(" enter values");
double valueA =Convert.ToDouble(Console.ReadLine());
double valueB =Convert.ToDouble(Console.ReadLine());
double valueC =Convert.ToDouble(Console.ReadLine());
Console.WriteLine("the value is:   " + volue(valueA, valueB, valueC));
Console.WriteLine(" the value is overloaded" + volue(1, 2, 3)); //bonus

//task3
Console.WriteLine("enter the number");
int valueD = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("the number is :   " + number(valueD));

//task4
Console.WriteLine("enter the tempreture");
double valueH = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("the tempreture is :  " +Celsius(valueH));

//task5
Console.WriteLine("enter a letter");
char check = Convert.ToChar(Console.ReadLine());
Console.WriteLine(letters(check));

//task6
Console.WriteLine("enter amount");
double originalAmount = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(" the convertion amount is :");
double conversionRate = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(currency(originalAmount, conversionRate));


#endregion region


