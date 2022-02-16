// See https://aka.ms/new-console-template for more information


var FibonacciNumbers = new List<int> {1,1};



while(FibonacciNumbers.Count < 21)
{   
    var prev1 = FibonacciNumbers[FibonacciNumbers.Count -1];
    var prev2 = FibonacciNumbers[FibonacciNumbers.Count -2];
    FibonacciNumbers.Add(prev1 + prev2);

}


foreach (var n in FibonacciNumbers)
{
    Console.WriteLine(n);
}