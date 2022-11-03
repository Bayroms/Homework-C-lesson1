Console.WriteLine ("Enter number greater than 1 ");
int num = Convert.ToInt32(Console.ReadLine());

int i = 2;

if (num > 0 && num%2 == 0){
    while (i<num){
    Console.Write ($"{i}, ");
    i += 2;
    }
    Console.WriteLine (num);
}
if (num > 0 && num%2 != 0){
    while (i<num){
    Console.Write ($"{i}, ");
    i += 2;
    }
}
else{
    Console.WriteLine ("Enter number greater than 1");
}


