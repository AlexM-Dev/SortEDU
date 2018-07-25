Namespace Global.Sorting
    Public Module SortingAlgorithms
        Public Sub BubbleSort(ByRef arr As Integer())
            If (arr.Length = 1) Then Return
            Dim n As Integer = arr.Length
            For i As Integer = 0 To n - 2
                Dim swapped As Boolean = False

                For j = 0 To n - 2
                    If (arr(j) > arr(j + 1)) Then
                        Dim v As Integer = arr(j)
                        arr(j) = arr(j + 1)
                        arr(j + 1) = v
                        swapped = True
                    End If
                Next

                If Not swapped Then
                    Exit For
                End If
            Next
        End Sub
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
            Dim len As Integer = arr.Length

            For i As Integer = 0 To len - 2 '' < len - 1, in C#.
                Dim min = i

                For j As Integer = i + 1 To len - 1
                    If (arr(j) < arr(min)) Then
                        min = j
                    End If
                Next

                If (min <> i) Then
                    Dim value As Integer = arr(i)
                    arr(i) = arr(min)
                    arr(min) = value
                End If
            Next
        End Sub

        Public Sub Quicksort(ByRef arr As Integer())
            Quicksort(arr, 0, arr.Length - 1)
        End Sub

        Private Sub Quicksort(ByRef arr As Integer(),
                              ByVal lower As Integer,
                              ByVal upper As Integer)
            If (lower < upper) Then
                Dim p As Integer = Partition(arr, lower, upper)
                Quicksort(arr, lower, p - 1)
                Quicksort(arr, p + 1, upper)
            End If
        End Sub
        Private Function Partition(ByRef arr As Integer(),
                                   ByVal lower As Integer,
                                   ByVal upper As Integer) As Integer
            Dim pivot As Integer = arr(upper)
            Dim i = lower - 1

            For j As Integer = lower To upper - 1
                If (arr(j) < pivot) Then
                    i += 1

                    Dim value As Integer = arr(i)
                    arr(i) = arr(j)
                    arr(j) = value
                End If
            Next

            Dim swap As Integer = arr(i + 1)
            arr(i + 1) = arr(upper)
            arr(upper) = swap

            Return i + 1
        End Function
    End Module
End Namespace
