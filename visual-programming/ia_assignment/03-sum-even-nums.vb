' Write a program to calculate the Sum of Even Numbers from 1 to n.

Imports System 'System is a Namespace  
Module SumEvenNumbers
    Sub Main()
        ' Get the value of n from the user
        ' Console.Write("Enter the value of n: ")
        Dim n As Integer = CInt(Console.ReadLine())

        ' Initialize sum to 0
        Dim sumOfEvenNumbers As Integer = 0

        ' Iterate from 1 to n and add even numbers to the sum
        For i As Integer = 2 To n Step 2
            sumOfEvenNumbers += i
        Next

        ' Display the sum of even numbers
        Console.WriteLine(sumOfEvenNumbers)
    End Sub
End Module
