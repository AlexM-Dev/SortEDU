Public Module Algorithms
    Public Sub InsertionSort(ByRef arr As Integer())
        For i As Integer = 1 To arr.Length - 1
            Dim j As Integer = i

            While j > 0 AndAlso arr(j - 1) > arr(j)
                Dim v As Integer = arr(j)
                arr(j) = arr(j - 1)
                arr(j - 1) = v
                j -= 1
            End While
        Next
    End Sub
End Module
