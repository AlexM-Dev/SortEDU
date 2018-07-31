Namespace Global
    Public Module Table
        Public Sub DrawTable(Headers As List(Of String),
                             Rows As List(Of List(Of String)),
                             Optional ColWidth As Integer = 20,
                             Optional Buff As Integer = 2)
            Dim buffer As String = New String(" ", Buff)
            Console.WriteLine()

            For i = 0 To Headers.Count - 1
                Dim lim = Limit(Headers(i), ColWidth - Buff)
                Console.Write(buffer & lim &
                                New String(" ", ColWidth - lim.Length))
            Next
            Console.WriteLine()
            Console.WriteLine(Environment.NewLine &
                                New String("-", Headers.Count * ColWidth +
                                    Buff * Headers.Count) & Environment.NewLine)

            For Each row In Rows
                For Each entry In row
                    Dim lim = Limit(entry, ColWidth - Buff)

                    Console.Write(buffer & lim &
                                    New String(" ", ColWidth - lim.Length))
                Next
                Console.WriteLine()
            Next
        End Sub

        Public Function Limit(value As String, len As Integer) As String
            If value.Length <= len Then Return value

            Dim append = New String(".", If(len > 3, 3, 0))

            Return value.Remove(len - append.Length) & append
        End Function

    End Module

End Namespace
