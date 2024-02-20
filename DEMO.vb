Imports System.IO
Public Class DEMO
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim openFileDialog1 As New OpenFileDialog()

        openFileDialog1.Filter = "Image Files (*.jpg;*.jpeg;* .png;*.bmp)|*.jpg;*.jpeg;*.png;*,bmp| All files(*.*)|*.*"

        If openFileDialog1.ShowDialog() = DialogResult.OK Then

            Dim filePath As String = openFileDialog1.FileName


            If File.Exists(filePath) Then

                Dim img As Image = Image.FromFile(filePath)

                PictureBox1.Image = img

            Else
                MessageBox.Show("File does not exist.")
            End If

        End If

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class