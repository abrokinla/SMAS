Public Class frmAssets
    Private access As New DBControl
    Private Sub lblAdd_Click(sender As Object, e As EventArgs) Handles lblAdd.Click
        GroupBox2.Visible = True
        dgvAssets.Visible = False

    End Sub

    Private Sub lblView_Click(sender As Object, e As EventArgs) Handles lblView.Click
        GroupBox2.Visible = True
        dgvAssets.Visible = True
        access.ExecQuery("SELECT * FROM Asset")
        dgvAssets.DataSource = access.DBDT
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        access.AddParam("@Asset", txtAsset.Text)
        access.AddParam("@Quantity", txtQnty.Text)
        access.AddParam("@Value", txtValue.Text)

        access.ExecQuery("INSERT INTO Asset ASSET, QUANTITY, VALUE)" & _
                         "VALUES (@Asset, @Quantity, @Value);")

        '   SUCCESS
        MsgBox("ADDEDD SUCCESSFULLY")
        Dim FRM As New frmAssets
        FRM.Show()
        Me.Close()
    End Sub

    Private Sub txtQnty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQnty.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub txtValue_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtValue.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.KeyChar = ""
        End If
    End Sub

End Class