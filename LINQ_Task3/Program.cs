int[] values = { 3,4,2,1,15,6,8,10,6,7};
var selectedNumbers = values.Where((number, index) => index % 2 > 0 && number % 2 == 0);
                            
foreach (var number in selectedNumbers)
    Console.WriteLine(number);
