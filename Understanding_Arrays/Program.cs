// See https://aka.ms/new-console-template for more information
/*
int number1 = 4;
int number2 = 8;
int number3 = 15;
int number4 = 16;
int number5 = 23;


if (number1 == 16)
{

}
else if (number2 == 16)
{
     
}
else if (number3 == 16)
{
}
else if (number4 == 16)
{
}
else if (number5 == 16)
{
}
*/

int[] numbers = new int[5];

numbers[0] = 4;
numbers[1] = 8;
numbers[2] = 15;
numbers[3] = 16;
numbers[4] = 23;

Console.WriteLine(numbers[1]);
Console.WriteLine(numbers.Length);

int[] secondNumbers = new int[] { 4, 8, 15, 16, 23, 42 };

string[] names = new string[] { "Eddie", "Alex", "David", "Michael" };

for (int i =0; i < names.Length; i++ )
{
    Console.WriteLine(names[i]);
}


Console.WriteLine("Next --------------");

foreach(string name in names)
{
    Console.WriteLine(name);
}



string zig = "You can get what you wnat out of life if you help enought other people getwhat they want out of life. - Zig Ziglar";

char[] charArray = zig.ToCharArray();
Array.Reverse(charArray);

foreach (char zigChar in charArray)
{
       Console.Write(zigChar);

}