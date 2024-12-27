int x, factorial=1, num; 
Console.WriteLine("Enter any number : "); 
num = int.Parse(Console.ReadLine()); 

for(x=1;x<=num; x++){
    factorial = factorial * x; 
}

Console.Write("The Factorial is : " + num + " : " + factorial); 