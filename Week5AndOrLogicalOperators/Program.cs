// AND (&&) and OR (||) logical operators

//AND
//true && true = true
//true && false = false
//false && true = false
//false && false = false

string username, password;   //userName: admin; password: admin1234

Console.WriteLine("Enter Username:");
username = Console.ReadLine();

Console.WriteLine("Enter password:");
password = Console.ReadLine();

//OR
//true || true = true
//true || false = true
//false || true = true
//false || false = false

if (username != "admin" || password != "admin1234") //!= NOT
{
    Console.WriteLine("Invalid user credentials");
}
else
{
    Console.WriteLine("Welcome!");
}


//if  (username == "admin" && password == "admin1234")
//{
//    Console.WriteLine("Welcome!");
//}
//else
//{
//    Console.WriteLine("Invalid user credentials");
//}