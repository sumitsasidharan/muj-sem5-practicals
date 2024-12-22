
' Problem Statement: Write a program to calculate the area of the rectangle.

Imports System 'System is a Namespace  

Module RectangleArea
    Sub Main()
        ' Console.WriteLine("Enter the length of the rectangle: ")
        Dim length As Double = Convert.ToDouble(Console.ReadLine())

        ' Console.WriteLine("Enter the width of the rectangle: ")
        Dim width As Double = Convert.ToDouble(Console.ReadLine())

        Dim area As Double = CalculateArea(length, width)

        Console.WriteLine("Area of the rectangle {0}", area)
    End Sub

    Function CalculateArea(ByVal length As Double, ByVal width As Double) As Double
        Return length * width
    End Function
End Module
