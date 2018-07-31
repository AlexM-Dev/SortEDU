Imports System.Diagnostics
Imports System.IO
Imports System.Text
Imports Sorting
Module Program
    Dim rnd As New Random()

    Sub Main()
        '' Sort the dictionary and filter out ugly things.
        Dim arr As String() = RandomStringArray(5000000, 5)
        'For i = 0 To arr.Length - 1
        '    arr(i) = arr(i).ToLower().Replace("'", "")
        'Next
        Dim sort = TimeMethod(Sub() Array.Sort(arr,
                        StringComparer.InvariantCultureIgnoreCase))

        Console.WriteLine("Sorting took " + sort.ToString() + "ms.")

        Dim headers = New List(Of String) From {
            "#", "Index", "BinarySearch()", "Binary", "Linear"
        }
        Dim rows As New List(Of List(Of String))

        Dim amount = New List(Of Integer) From {
            1, 2, 5, 10, 20, 50, 100, 200, 500, 1000, 2000, 5000,
            10000, 20000, 50000, 100000, 200000, 500000, 1000000,
            2000000, 5000000
        }

        DrawTable(headers, rows, 20, 2)
        For i As Integer = 0 To amount.Count - 1
            Dim index = -1
            Dim iArr() As String = arr.Take(amount(i)).ToArray()

            Dim src As String = iArr(rnd.Next(iArr.Length))

            Dim row = New List(Of String)

            Dim defBinary = TimeMethod(Sub() index = Array.BinarySearch(arr, src))
            Dim binary = TimeMethod(Sub() index = Search(arr, src))
            Dim linear = TimeMethod(Sub() index = LinearSearch(arr, src))

            row.AddRange({amount(i), src, defBinary, binary, linear})
            rows.Add(row)

            Console.SetCursorPosition(0, 1)
            DrawTable(headers, rows, 20, 2)
        Next

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
