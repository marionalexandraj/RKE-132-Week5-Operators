int math, biology, chemistry;

Console.WriteLine("Enter math result:");
math = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your Biology result:");
biology = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your chemistry result:");
chemistry = Int32.Parse(Console.ReadLine());

if (math >= 90 && biology >= 90 && chemistry >= 90)
{
    Console.WriteLine("You got accepted!");
} else
{
    Console.WriteLine("Your application cannot be approved");
}