Namespace Global.Sorting
    Public Module Helpers
        Public Function GenerateValues(ByVal length As Integer) As Integer()
            Dim vals(length) As Integer
            Dim random As New Random

            For i = 0 To length - 1
                vals(i) = random.Next(length)
            Next

            Return vals
        End Function
        Public Function TimeMethod(ByVal a As Action) As Long
            Dim timer As New Stopwatch
            timer.Start()

            a.Invoke()

            timer.Stop()
            Return timer.ElapsedMilliseconds
        End Function
    End Module
End Namespace