Console.WriteLine ("Enter three numbers ");
int numA = Convert.ToInt32(Console.ReadLine());
int numB = Convert.ToInt32(Console.ReadLine());
int numC = Convert.ToInt32(Console.ReadLine());

int max = numA;

if (numB > max){
    max = numB;
}
if (numC > max){
    max = numC;
}
else if (numA==numB){
    Console.WriteLine ("Enter three different numbers");
}

else if (numB==numC){
    Console.WriteLine ("Enter three different numbers");
}
else if (numA==numC){
    Console.WriteLine ("Enter three different numbers");
}

Console.WriteLine ($"{max} is the greatest number");
