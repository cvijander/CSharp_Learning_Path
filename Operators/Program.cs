// See https://aka.ms/new-console-template for more information

// varialbe declaration 
int x, y, a, b;

// asignment operator 
x = 3;
y = 2;
a = 1;
b = 0;

// there are many mathematicla operators in C#

// Addition operator 
x = 3 + 4;

// substraction operator 
x = 4 - 3;

// Multiplication operator
x = 4 * 3;


// Division operator 
x = 4 / 2;

// Order of operation using parethesis 
x = (x + y) * (a - b);

// there are many operators used to evaluate values .. 

// Equality operator 
if (x ==y )
{
       Console.WriteLine("x and y are equal");
}

// greater than operator 
if (x > y )
{
    Console.WriteLine("This is when \"X\" is greather than \"Y\" . "  );
}

// less than operator 

if (x < y)
{
    Console.WriteLine("This is when \"Y\" is greather than \"X\".");
}

// greater or equal to operator 
if (x >= y)
{
    Console.WriteLine("This is when \"X\"  is greather or equal to  \"Y\". ");
}

// less than or equal to operator
if (x <= y)
{
    Console.WriteLine("This is when \"X\" is smaller or equal to \"Y\".");
}

// There are conditional operators as well that can be used to expand / enhance an evaluation ..
// adn they can be combined together multiple times. 

// conditional AND operator 
if ((x > y) && (a > b))
{
    Console.WriteLine("This is only TRUE when \"X\" is greater than \"Y\" and \"A\" is greater than \"B\".");
}

// conditional OR operator 
if((x > y) || (a > b))
{
    Console.WriteLine("This is TRUE if left parenthisis is true, or right parethisis is true, or both are true");
}

// aslo , here 's the in-line conditional operator we learedn about in the previous lession 
string message = (x == 1) ? "Car" : "Boat";

// member access and method invocation 
Console.WriteLine(message);
Console.WriteLine("Hi");



//https://www.youtube.com/watch?v=0QUgvfuKvWU 


