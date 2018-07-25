Imports System.Diagnostics
Imports System.IO
Imports System.Text
Imports Sorting
Module Program
    Dim rnd As New Random()

    Sub Main()
        '' Reserve VB code for Searching.
        Dim arr As String() = RandomStringArray(80000)
        Dim src As String = arr(rnd.Next(arr.Length))

        Console.WriteLine("Sorting")
        Dim l As Long = TimeMethod(Sub() Array.Sort(arr, StringComparer.InvariantCulture))
        Console.WriteLine("Sorting took " + l.ToString() + "ms.")

        Dim i As Integer
        l = TimeMethod(Sub() i = Search(arr, src))

        Console.WriteLine(arr(i) + $", binary search took {l}ms.")

        l = TimeMethod(Sub() i = LinearSearch(arr, src))

        Console.WriteLine(arr(i) + $", linear search took {l}ms.")

        Console.ReadKey()
    End Sub

    Public Function RandomString(ByVal Optional len As Integer = 10) As String
        Dim builder As New StringBuilder()

        For i = 0 To len - 1
            Dim min = Convert.ToInt32("a"c)
            min = min + rnd.Next(26)

            builder.Append(Convert.ToChar(min))
        Next

        Return builder.ToString()
    End Function

    Public Function RandomStringArray(Optional len As Integer = 20,
                                      Optional vLen As Integer = 10) As String()
        Dim arr(len - 1) As String
        For i = 0 To len - 1
            arr(i) = RandomString(vLen)
        Next
        Return arr
    End Function
End Module
