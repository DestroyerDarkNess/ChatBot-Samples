Public Class Form2

    Private Sub LoyalButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoyalButton1.Click
        If LoyalCheckBox1.Checked = True Then
            Form1.Show()
        End If
        If LoyalCheckBox2.Checked = True Then
            Form3.Show()
        End If
        If LoyalCheckBox3.Checked = True Then
            Form4.Show()
        End If
    End Sub

    Private Sub LoyalButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoyalButton2.Click
        End
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        System.Diagnostics.Process.Start("https://foro.elhacker.net")
    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        System.Diagnostics.Process.Start("https://www.facebook.com/salvador.osvaldo.1")
    End Sub
    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       
    End Sub
End Class