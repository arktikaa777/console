Console.Write("Enter username: ");
string username = Console.ReadLine();

if(username.ToLower() == "masha")
{
    Console.WriteLine("Hey, this is Masha!");
}
else
{
    Console.Write("Hi, ");
    Console.WriteLine(username);
}