Imports System

Module Bingo

    Sub Main()
        Dim bingoSheet(4, 4) As Integer
        'create a new instance of the Random class
        Dim random As New Random()

        'populate the array with random numbers in the proper range for each column
        For j As Integer = 0 To 4
            For i As Integer = 0 To 4
                If j = 0 Then
                    'column 1: numbers 1-15
                    bingoSheet(i, j) = random.Next(1, 16)
                ElseIf j = 1 Then
                    'column 2: numbers 16-30
                    bingoSheet(i, j) = random.Next(16, 31)
                ElseIf j = 2 Then
                    'column 3: numbers 31-45
                    bingoSheet(i, j) = random.Next(31, 46)
                ElseIf j = 3 Then
                    'column 4: numbers 46-60
                    bingoSheet(i, j) = random.Next(46, 61)
                Else
                    'column 5: numbers 61-75
                    bingoSheet(i, j) = random.Next(61, 76)
                End If
            Next
        Next

        'print the bingo sheet
        Console.WriteLine("+----+----+----+----+----+")
        Console.WriteLine("| B  | I  | N  | G  | O  |")
        Console.WriteLine("+----+----+----+----+----+")
        For i As Integer = 0 To 4
            Console.Write("|")
            For j As Integer = 0 To 4
                If bingoSheet(i, j) > 9 Then
                    Console.Write(" " & bingoSheet(i, j) & " |")
                Else
                    Console.Write(" " & bingoSheet(i, j) & "  |")
                End If
            Next
            Console.WriteLine()
            Console.WriteLine("+----+----+----+----+----+")
        Next
        Console.ReadLine()
    End Sub
End Module
