Public Class formUOM
    Private Sub Reloads()
        Try
            Reload("SELECT * FROM tbl_uom", uomDataGrid)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Eraser()
        uomid.Text = ""
        uomname.Clear()
        uomdesc.Clear()
    End Sub


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If String.IsNullOrEmpty(uomname.Text.Trim) Then
            ErrorProvider1.SetError(uomname, "Please enter a name")
            MessageBox.Show("Please input a name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            uomname.Focus()
        Else
            Try
                Create("INSERT INTO tbl_uom (name,description) VALUES('" & uomname.Text & "','" & uomdesc.Text & "')")
                ErrorProvider1.SetError(uomname, String.Empty)
                Reloads()
                Eraser()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If String.IsNullOrEmpty(uomname.Text.Trim) Then
            ErrorProvider1.SetError(uomname, "Please enter a name")
            MessageBox.Show("Please input a name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Try
                Updates("UPDATE tbl_uom SET name='" & uomname.Text & "', 
            description='" & uomdesc.Text & "' WHERE uid ='" & uomid.Text & "' ")
                ErrorProvider1.SetError(uomname, String.Empty)
                uomPanel.Hide()
                Reloads()
                Eraser()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles uomAdd.Click
        btnSave.Enabled = True
        uomPanel.Show()
        Eraser()
    End Sub

    Private Sub formUOM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Reloads()
        uomPanel.Hide()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        uomPanel.Hide()
    End Sub

    Private Sub uomDataGrid_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles uomDataGrid.CellContentClick
        Try
            If uomDataGrid.Columns(e.ColumnIndex).Name = "Edit" Then
                uomPanel.Show()
                btnSave.Enabled = False
                Dim dr As DataGridViewRow = uomDataGrid.SelectedRows(0)
                uomid.Text = dr.Cells(2).Value.ToString()
                uomname.Text = dr.Cells(3).Value.ToString()
                uomdesc.Text = dr.Cells(4).Value.ToString()
            ElseIf uomDataGrid.Columns(e.ColumnIndex).Name = "Deletes" Then
                Try
                    delete("DELETE FROM tbl_uom WHERE uid ='" & uomDataGrid.SelectedRows(0).Cells(2).Value.ToString() & "'")
                    Reloads()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class