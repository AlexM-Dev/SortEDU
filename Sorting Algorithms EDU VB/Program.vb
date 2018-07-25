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

        Dim i As Integer

        Dim sort = TimeMethod(Sub() Array.Sort(arr, StringComparer.InvariantCulture))
        Dim binary = TimeMethod(Sub() i = Search(arr, src))
        Dim linear = TimeMethod(Sub() i = LinearSearch(arr, src))

        Console.WriteLine("Sorting took " + sort.ToString() + "ms.")
        Console.WriteLine(arr(i) + $", binary search took {binary}ms.")
        Console.WriteLine(arr(i) + $", linear search took {linear}ms.")

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
