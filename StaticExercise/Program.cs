using StaticExercise;
Console.WriteLine("Please enter the temperature in Fahrenheit?");

double temp = double.Parse(Console.ReadLine());

Console.WriteLine($"The temperatue in Celcius is {TempConverter.FahrenheitToCelsius(temp)}.");

Console.WriteLine("What is the temperature outside in Celcius?");

double temp1 = double.Parse(Console.ReadLine());

Console.WriteLine($"The temperature in Fahrenheit is {TempConverter.CelsiusToFahrenheit(temp1)}.");