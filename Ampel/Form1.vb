Public Class frmAmpel
    Private Sub btnWeiter_Click(sender As Object, e As EventArgs) Handles btnWeiter.Click
        btnWeiter.Text = "Erik Sucks"
        If btnWeiter.Text = "Erik Sucks" Then
            lblRot.BackColor = Color.Red
            Application.DoEvents()
            System.Threading.Thread.Sleep(1000)

        End If
        If lblRot.BackColor = Color.Red Then
            lblgelb.BackColor = Color.Yellow
            Application.DoEvents()
            System.Threading.Thread.Sleep(1000)

        End If
        If lblgelb.BackColor = Color.Yellow Then
            lblGrün.BackColor = Color.Green
            Application.DoEvents()
            System.Threading.Thread.Sleep(1000)
        End If
        If lblGrün.BackColor = Color.Green Then
            btnWeiter.Text = "Start"
            lblgelb.BackColor = Color.Gray
            lblGrün.BackColor = Color.Gray
            lblRot.BackColor = Color.Gray

        End If
    End Sub
End Class
