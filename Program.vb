
Imports System

Module ErrorHandlingExample
    Sub Main()
        Try
            Console.Write("Enter a number: ")
            Dim userInput As String = Console.ReadLine()

            ' convert user input to a numeric value
            Dim number As Double = Convert.ToDouble(userInput)

            ' If successful, perform a calculation 
            Dim result As Double = number * number
            Console.WriteLine($"The square of {number} is: {result}")
            Dim sum As Integer = number + number
            Console.WriteLine($"The sum of {number} and {number} is: {sum}")
            Dim division As Double = number / number
            Console.WriteLine($"The division of {number} by {number} is: {division}")

        Catch ex As FormatException
            ' Catch the exception if user input is a non-numeric value
            Console.WriteLine("Error: That is a non-numeric value. Please enter a valid numeric value.")

        Catch ex As Exception
            ' Catch any other unexpected exceptions
            Console.WriteLine($"An unexpected error occurred: {ex.Message}")

        End Try
    End Sub
End Module
