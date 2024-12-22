' Write a program to check whether a number is even or odd.

Imports System 'System is a Namespace  

Module Program
    Sub Main()
        ' Declare a variable to store the user input
        Dim number As Integer

        ' Prompt the user to enter a number
        ' Console.Write("Enter a number: ")
        
        ' Read the user input and convert it to an integer
        number = Convert.ToInt32(Console.ReadLine())

        ' Check if the number is even or odd
        If number Mod 2 = 0 Then
            Console.WriteLine("Number is EVEN")
        Else
            Console.WriteLine("Number is ODD")
        End If
    End Sub
End Module
