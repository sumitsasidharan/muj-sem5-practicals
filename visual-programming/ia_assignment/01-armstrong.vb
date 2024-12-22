
' Problem Statement: Write a vb.net program to check whether the given number is Armstrong or not.

Imports System 'System is a Namespace  

Module ArmstrongCheck
    Sub Main()
        'Console.WriteLine("Enter a number: ")
        Dim number As Integer = Convert.ToInt32(Console.ReadLine())

        If IsArmstrong(number) Then
            Console.WriteLine("Number is an Armstrong")
        Else
            Console.WriteLine("Number is not an Armstrong")
        End If
    End Sub

    Function IsArmstrong(ByVal num As Integer) As Boolean
        Dim originalNum As Integer = num
        Dim sum As Integer = 0
        Dim digits As Integer = num.ToString().Length

        While num > 0
            Dim digit As Integer = num Mod 10
            sum += Math.Pow(digit, digits)
            num \= 10
        End While

        Return sum = originalNum
    End Function
End Module
