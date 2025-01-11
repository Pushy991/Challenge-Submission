using System.Data;
using System.Formats.Asn1;
using System.Runtime.Intrinsics.Arm;
using System.Threading.Tasks.Dataflow;

//control used for while loop
int control = 0;
//While loop to keep repeating if wrong data inputed by user
while (control == 0)
{
    Console.WriteLine("Do you have a rectangle(1) or circle(2)?");
    int choice = int.Parse(Console.ReadLine());
    
    //If statement for the responses to whether its a rectangle or circle
    if (choice == 1)
    {
        //Asks user to enter length and width of rectangle
        Console.WriteLine("Enter length of rectangle: ");
        int Length = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter width of rectangle: ");
        int Width = int.Parse(Console.ReadLine());
        
        //Finds area a perimeter and stores it in variables
        int Peri = (Length + Width) * 2;
        int Area = Length * Width;
        
        //Outputs the area a perimeter using concatination
        Console.WriteLine($"Area is {Area}.\nPerimeter is {Peri}");
        control = 1;
    }
    else if (choice == 2)
    {
        //Asks user to enter radius of cirlce
        Console.WriteLine("Enter radius of circle:  ");
        int Radius = int.Parse(Console.ReadLine());

        //Finds area and circumference
        int Area = (int)(3.14 * Radius * Radius);
        int Circ = (int)(3.14 * Radius * 2);
        //Outputs area and circumference using concatination
        Console.WriteLine($"Area is {Area}.\nCircumference is {Circ}");
        control = 1;
    }
    else
    {
        //control will remain 0 if user input is incorrect so will loop till correct
        Console.WriteLine("It's not hard to follow simple instructions. Now try again.");
    }

}
