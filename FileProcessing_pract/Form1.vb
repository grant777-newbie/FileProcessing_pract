Public Class Form1
    Private Sub ButtonWrite_Click(sender As Object, e As EventArgs) Handles ButtonWrite.Click
        Try
            Dim filepath As String = "sample text" 'file location'

            Using writer As New StreamWriter(filepath)
                writer.WriteLine("HEllo, this is a test file!")
                writer.WriteLine("Second line of the text")
            End Using

            MessageBox.Show("Data Writter succesfully!")

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", )

    End Sub
End Class
