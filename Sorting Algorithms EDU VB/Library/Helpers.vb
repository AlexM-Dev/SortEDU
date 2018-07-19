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
    End Module
End Namespace