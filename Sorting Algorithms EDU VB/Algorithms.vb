Module Algorithms
    Public Sub InsertionSort_1(ByRef arr As Integer())
        For i = 1 To arr.Length - 1
            Dim j As Integer = i
            While (j > 0 & arr(j - 1) > arr(j))
                '' Swap the items.
                Dim v = arr(j)
                arr(j) = arr(j - 1)
                arr(j - 1) = v

                j -= 1
            End While
        Next
    End Sub
End Module
