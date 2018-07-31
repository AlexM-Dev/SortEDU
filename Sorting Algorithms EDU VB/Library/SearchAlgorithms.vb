Namespace Global.Sorting
    Public Module SearchAlgorithms

        Public Function Search(ByVal arr As String(),
                               ByVal value As String) As Integer
            Dim left = 0
            Dim right = arr.Length - 1

            Dim c As Integer = 0

            While (left <= right)
                Dim m As Integer = (left + right) / 2
                Dim s As String = arr(m)
                c += 1

                If (s.CompareTo(value) < 0) Then
                    left = m + 1
                ElseIf (s.CompareTo(value) > 0) Then
                    right = m - 1
                Else
                    Return m
                End If
            End While

            Return -1
        End Function

        Public Sub WriteArray(ByVal a As String(), l As Integer, h As Integer)
            Console.Write("{")
            For i = l To h
                Console.Write(a(i) + ", ")
            Next
            Console.WriteLine("}")
        End Sub

        Public Function LinearSearch(ByVal arr As String(),
                                     ByVal value As String) As Integer
            '' Don't need to sort the array.

            Dim c As Integer = 0

            For i = 0 To arr.Length - 1
                c += 1
                If (arr(i).CompareTo(value) = 0) Then
                    Console.WriteLine(c)
                    Return i
                End If
            Next

            Return -1
        End Function
    End Module
End Namespace
