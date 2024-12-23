// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter a number!");

int usernum = Convert.ToInt32(Console.ReadLine());

// kas kasutaja arv on paaris voi paaritu

int result = usernum % 2;
if (result != 0) // ei ole vordne
{
    Console.WriteLine("user number is odd");
} else
{
    Console.WriteLine("User number is even");
}
