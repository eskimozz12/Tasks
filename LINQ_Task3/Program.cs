int[] values = { 3,4,2,1,15,6,8,10 };
var selectedNumbers = values.Select((n, i) => new { Pos = i, Value = n })
                      .Where(x => x.Pos % 2 > 0 && x.Value % 2 == 0)
                      .Select(x => x.Value);
foreach (var number in selectedNumbers)
    Console.WriteLine(number);
