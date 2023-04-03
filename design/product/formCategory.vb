Public Class formCategory
    Private Sub Reloads()
        Try
            Reload("SELECT * FROM tbl_category", categoryDataGrid)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Eraser()
        categoryid.Text = ""
        categoryname.Clear()
        categorydesc.Clear()
    End Sub


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If String.IsNullOrEmpty(categoryname.Text.Trim) Then
            ErrorProvider1.SetError(categoryname, "Please enter a name")
            MessageBox.Show("Please input a name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            categoryname.Focus()
        Else
            Try
                Create("INSERT INTO tbl_category (name,description) VALUES('" & categoryname.Text & "','" & categorydesc.Text & "')")
                ErrorProvider1.SetError(categoryname, String.Empty)
                Reloads()
                Eraser()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If String.IsNullOrEmpty(categoryname.Text.Trim) Then
            ErrorProvider1.SetError(categoryname, "Please enter a name")
            MessageBox.Show("Please input a name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            categoryname.Focus()
        Else
            Try
                Updates("UPDATE tbl_category SET name='" & categoryname.Text & "', 
            description='" & categorydesc.Text & "' WHERE cid ='" & categoryid.Text & "'")
                ErrorProvider1.SetError(categoryname, String.Empty)
                categoryPanel.Hide()
                Reloads()
                Eraser()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs)
        categoryid.Text = ""
        categoryname.Clear()
        categorydesc.Clear()
    End Sub

    Private Sub btnReload_Click(sender As Object, e As EventArgs)
        Try
            Reload("SELECT * FROM tbl_category", categoryDataGrid)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub



    Private Sub Guna2HtmlLabel2_Click(sender As Object, e As EventArgs) Handles Guna2HtmlLabel2.Click

    End Sub

    Private Sub categorydesc_TextChanged(sender As Object, e As EventArgs) Handles categorydesc.TextChanged

    End Sub

    Private Sub categoryid_TextChanged(sender As Object, e As EventArgs) Handles categoryid.TextChanged

    End Sub

    Private Sub formCategory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        categoryPanel.Hide()
        Reloads()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        btnSave.Enabled = True
        categoryPanel.Show()
        Eraser()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        categoryPanel.Hide()
    End Sub

    Private Sub categoryDataGrid_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles categoryDataGrid.CellContentClick
        categoryid.Text = CStr(categoryDataGrid.CurrentRow.Cells(0).Value)
        categoryname.Text = CStr(categoryDataGrid.CurrentRow.Cells(1).Value)
        categorydesc.Text = CStr(categoryDataGrid.CurrentRow.Cells(2).Value)

        Try
            If categoryDataGrid.Columns(e.ColumnIndex).Name = "Edit" Then
                categoryPanel.Show()
                btnSave.Enabled = False
                Dim dr As DataGridViewRow = categoryDataGrid.SelectedRows(0)
                categoryid.Text = dr.Cells(2).Value.ToString()
                categoryname.Text = dr.Cells(3).Value.ToString()
                categorydesc.Text = dr.Cells(4).Value.ToString()
            ElseIf categoryDataGrid.Columns(e.ColumnIndex).Name = "Deletes" Then
                Try
                    delete("DELETE FROM tbl_category WHERE cid ='" & categoryDataGrid.SelectedRows(0).Cells(2).Value.ToString() & "'")
                    Reloads()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class