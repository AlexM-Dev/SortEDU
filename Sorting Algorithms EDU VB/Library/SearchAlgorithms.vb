Namespace Global.Sorting
    Public Module SearchAlgorithms

        Public Function Search(ByVal arr As String(),
                               ByVal value As String) As Integer
            Dim left = 0
            Dim right = arr.Length - 1
            While (left <= right)
                Dim m As Integer = (left + right) / 2
                If (arr(m).CompareTo(value) < 0) Then
                    left = m + 1
                ElseIf (arr(m).CompareTo(value) > 0) Then
                    right = m - 1
                Else
                    Return m
                End If
            End While

            Return -1
        End Function

        Public Function LinearSearch(ByVal arr As String(),
                                     ByVal value As String) As Integer
            '' Don't need to sort the array.
            For i = 0 To arr.Length - 1
                If (arr(i).CompareTo(value) = 0) Then
                    Return i
                End If
            Next

            Return -1
        End Function
    End Module
End Namespace
