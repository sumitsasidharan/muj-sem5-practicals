
' Write a program to convert temperature from Fahrenheit to centigrade using the formula C=(F-32)*5/9, F=(1.8*C)+32. 

Imports System

Module Program

  Sub Main()
    ' Declare variables for temperature in Fahrenheit and Celsius
    Dim fahrenheit As Double
    Dim celsius As Double

    ' Prompt the user to enter the temperature in Fahrenheit
    Console.Write("Enter temperature in Fahrenheit: ")
    fahrenheit = Convert.ToDouble(Console.ReadLine())

    ' Convert Fahrenheit to Celsius using the formula
    celsius = (fahrenheit - 32) * 5 / 9

    ' Round the Celsius value to two decimal places using Math.Round
    celsius = Math.Round(celsius, 2)

    ' Display the result with Celsius rounded to two decimal places
    Console.WriteLine("Temperature in Celsius: {0}", celsius)
  End Sub

End Module