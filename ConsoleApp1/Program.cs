/*
static bool IsPalindrome(int x)
{
int r = 0, c = x;
while (c > 0)
{
    r = r * 10 + c % 10;
    c /= 10;
}
return r == x;
}

Console.WriteLine(IsPalindrome(121));
*/

/*
static int MySqrt(int x)
{
if (x == 0)
    return 0;

int left = 1;
int right = x;

while (left <= right) {
    int mid = left + (right - left) / 2;
    int sqrt = x / mid;

    if (sqrt == mid)
        return mid;
    else if (sqrt < mid)
        right = mid - 1;
    else
        left = mid + 1;
}

return right;
}

Console.WriteLine(MySqrt(9));
*/

/*
static int ClimbStairs(int n)
{
    if (n == 1)
        return 1;
    if (n == 2)
        return 2;
    int first = 1, second = 2;
    int output = second;
    for (int i=3; i<=n; i++)
    {
        output = first + second;
        first = second;
        second = output;
    }
    return output;
}

Console.WriteLine(ClimbStairs(3));
*/

// HyperActive HiTech 3.25

/*
static void BiggestFromTen(){
    int i = 9, biggest, input;
    Console.WriteLine("Please enter the first number and then press Enter");
    biggest = int.Parse(Console.ReadLine());
    while (i>0){
        Console.WriteLine("Please enter the " + (11-i) + "'st number and then press Enter");
        input = int.Parse(Console.ReadLine());
        if (input > biggest)
            biggest = input;
        i--;
    }
    Console.WriteLine(biggest);
}

BiggestFromTen();
*/

/*
static void SevenBoom(){
    int i = 1;
    while (i<101)
    {
        if (i%6==0)
            Console.WriteLine("Boom");
        else if (i%2==0)
            Console.WriteLine(2);
        else if (i%3==0)
            Console.WriteLine(3);
        else
            Console.WriteLine(i);
        i++;
    }
}

SevenBoom();
*/

/*
static void GuessingGame(){
    Console.WriteLine("Please enter the secret number (1-100):");
    int secret_number = int.Parse(Console.ReadLine());
    Console.WriteLine("Please guess the secret number:");
    int guessed_number = int.Parse(Console.ReadLine());
    bool guess = false;
    int number_of_guesses=1;
    while (!guess)
    {
        if (guessed_number == secret_number)
        {
            guess = true;
            continue;
        }
        else if (guessed_number<secret_number)
            Console.WriteLine("Wrong, it is bigger. \n Please try again:");
        else
            Console.WriteLine("Wrong, it is smaller. \n Please try again:");
        guessed_number = int.Parse(Console.ReadLine());
        number_of_guesses++;
    }
    Console.WriteLine("Bravo! you did it in "+number_of_guesses+" guesses");
}

GuessingGame();
*/

/*
static void GuessingGameUpgraded(){
    Console.WriteLine("Please enter the secret number (1-100):");
    int secret_number = int.Parse(Console.ReadLine());
    Console.WriteLine("Please guess the secret number:");
    int guessed_number = int.Parse(Console.ReadLine());
    bool guess = false;
    int number_of_guesses=1, diff, prev_diff=0;
    while (!guess)
    {
        if (secret_number == guessed_number)
        {
            guess = true;
            continue;
        }
        else
        {
            diff = Math.Abs(secret_number - guessed_number);
            if ((number_of_guesses==1) || (diff==prev_diff))
                Console.WriteLine("Wrong.\nPlease try again:");
            else if (diff<prev_diff)
                Console.WriteLine("Wrong, but youre getting closer.\nPlease try again:");
            else
                Console.WriteLine("Wrong you were closer last time.\nPlease try again:");

            prev_diff = diff;
            guessed_number = int.Parse(Console.ReadLine());
            number_of_guesses++;
        }
    }
    Console.WriteLine("Bravo! you did it in "+number_of_guesses+" guesses");
}

GuessingGameUpgraded();
*/

/*
void IsPrime ()
{
    Console.WriteLine("Please enter a number:");
    int divider=2, input = int.Parse(Console.ReadLine());
    while(divider<=input)
    {
        if (divider*divider == input)
        {
            Console.WriteLine("It is not a prime (divider is:"+divider+")");
        }
        divider++;
    }
    Console.WriteLine("It is a prime");
}

IsPrime();
*/

/*
static void Pow()
{
    Console.WriteLine("Please enter the base:");
    int b = int.Parse(Console.ReadLine());
    Console.WriteLine("Please enter the power:");
    int p = int.Parse(Console.ReadLine());
    if (p == 0)
        Console.WriteLine(1);
    else
    {
        int i = 1, sol = b;
        while(i<p)
        {
            sol *= b;
            i++;
        }
        Console.WriteLine(sol);
    }
}

Pow();
*/

// Final exersice

/*
void Sqrt()
{
    Console.WriteLine("Please enter a number:");
    int input = int.Parse(Console.ReadLine());
    int half_input = input / 2;
    int sqrt = 2;
    bool found = false;
    if (input == 1)
        Console.WriteLine("sqrt is 1");
    else
    {
        while (sqrt <= half_input)
        {
            if (sqrt * sqrt == input)
            {
                Console.WriteLine("root is:" + sqrt);
                found = true;
            }
            sqrt++;
        }
        if (!found)
            Console.WriteLine("no integer root");
    }
}

Sqrt();
*/

// Average Question

/*
void Average(){
    int sum = 0, highest, lowest;
    double counter = 0;
    Console.WriteLine("Please enter a number:");
    int input = int.Parse(Console.ReadLine());
    highest = input; lowest = input;
    while (input != -1){
        highest = highest < input ? input : highest;
        lowest = lowest < input ? lowest : input;
        sum += input;
        counter++;
        input = int.Parse(Console.ReadLine());
    }
    Console.WriteLine("Average: "+sum/counter);
    Console.WriteLine("Lowest: "+lowest);
    Console.WriteLine("Highest: "+highest);

}

Average();
*/

// Pyramid Question

/*
void Pyramid()
{
    Console.WriteLine("Please enter pyramid height:");
    int height = int.Parse(Console.ReadLine());
    int i = 1;
    while (i <= height) // row
    {
        int j = 1;
        while (j <= height - i) // col
        {
            Console.Write(" ");
            j++;
        }
        j = 1;
        while (j <= 2 * i - 1) 
        {
            if (j == 1 || j == 2 * i - 1)
                Console.Write("*");
            else
                Console.Write(" ");
            j++;
        }
        Console.WriteLine();
        i++;
    }
}

Pyramid();
*/


// Octal Question


/*
void Octal(){
    int i, num=1;
    Console.WriteLine("0");
    while (num <= 4095)
    {
        i = num;
        string octal = "";
        while (i > 0)
        {
            int digit = i % 8;
            octal = digit + octal;
            i /= 8;
        }
        Console.WriteLine(octal);
        num++;
    }
}

Octal();
*/

Console.WriteLine("all methods in comment");
