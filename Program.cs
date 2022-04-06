using static System.Console;

Calculator calculator = new();

int count = 0;
do
{
    WriteLine("Enter Value 1");
    double input1 = Convert.ToDouble(ReadLine());
    WriteLine("Enter Value 2");
    double input2 = Convert.ToDouble(ReadLine());

    WriteLine("Value of Addition is " + calculator.Add(input1, input2));
    WriteLine("Value of Subtraction is " + calculator.Subtract(input1, input2));
    WriteLine("Value of Multiplication is " + calculator.Multiply(input1, input2));
    WriteLine("Value of Division is " + calculator.Divide(input1, input2));

    WriteLine("Do you want to continue? (y/n)");
    string? input = ReadLine();
    if (input == "y")
    {
        count++;
    }
    else
    {
        count = 0;
    }
    
} while (count != 0);
