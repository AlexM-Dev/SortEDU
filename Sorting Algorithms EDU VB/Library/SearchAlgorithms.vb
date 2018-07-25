Namespace Global.Sorting
    Public Module SearchAlgorithms

        Public Function Search(ByVal arr As String(), ByVal value As String) As Integer
            Array.Sort(arr, StringComparer.InvariantCulture)

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
    End Module
End Namespace
