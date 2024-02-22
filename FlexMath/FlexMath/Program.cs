using FlexMath.Core;
var calculator = new FlexCalculator(new StringToNumberConvertor());
var result = calculator.Add(5.2, "three hundred");
Console.WriteLine($"result: {result}");