Namespace Global.Sorting
    Public Module SortingAlgorithms
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
        Public Sub SelectionSort(ByRef arr As Integer())
            Dim len = arr.Length

            For i = 0 To len - 2 '' < len - 1, in C#.
                Dim min = i

                For j = i + 1 To len - 1
                    If (arr(j) < arr(min)) Then
                        min = j
                    End If
                Next

                If (min <> i) Then
                    Dim value = arr(i)
                    arr(i) = arr(min)
                    arr(min) = value
                End If
            Next
        End Sub
    End Module

End Namespace
