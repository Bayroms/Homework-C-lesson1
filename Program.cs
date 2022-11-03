Console.WriteLine ("Enter two numbers ");
int numA = Convert.ToInt32(Console.ReadLine());
int numB = Convert.ToInt32(Console.ReadLine());

if (numA > numB){
    Console.WriteLine ($"{numA} greater then {numB}");
}
else if (numA == numB){
    Console.WriteLine ("Enter two different numbers");
}
else {
    Console.WriteLine ($"{numB} greater then {numA}");
}