Public Class formSupplier
    Private Sub Reloads()
        Try
            Reload("SELECT * FROM tbl_supplier", supplierDataGrid)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Eraser()
        supplierid.Text = ""
        suppliername.Clear()
        supplieraddr.Clear()
        supplieremail.Clear()
        supplierphoneno.Clear()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If String.IsNullOrEmpty(suppliername.Text.Trim) Then
            ErrorProvider1.SetError(suppliername, "Please enter a name")
            MessageBox.Show("Please input a name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            suppliername.Focus()
        ElseIf String.IsNullOrEmpty(supplieraddr.Text.Trim) Then
            ErrorProvider1.SetError(supplieraddr, "Please enter an address")
            MessageBox.Show("Please input an address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            supplieraddr.Focus()
        ElseIf String.IsNullOrEmpty(supplierphoneno.Text.Trim) Then
            ErrorProvider1.SetError(supplierphoneno, "Please enter a phone number")
            MessageBox.Show("Please input a phone number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            supplierphoneno.Focus()
        ElseIf String.IsNullOrEmpty(supplieremail.Text.Trim) Then
            ErrorProvider1.SetError(supplieremail, "Please enter an email")
            MessageBox.Show("Please input an email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            supplieremail.Focus()
        Else
            Try
                Create("INSERT INTO tbl_supplier (name,address,phone_num,email) VALUES('" & suppliername.Text & "',
            '" & supplieraddr.Text & "', '" & supplierphoneno.Text & "', '" & supplieremail.Text & "')")
                ErrorProvider1.SetError(suppliername, String.Empty)
                ErrorProvider1.SetError(supplieraddr, String.Empty)
                ErrorProvider1.SetError(supplierphoneno, String.Empty)
                ErrorProvider1.SetError(supplieremail, String.Empty)
                Reloads()
                Eraser()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If String.IsNullOrEmpty(suppliername.Text.Trim) Then
            ErrorProvider1.SetError(suppliername, "Please enter a name")
            MessageBox.Show("Please input a name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            suppliername.Focus()
        ElseIf String.IsNullOrEmpty(supplieraddr.Text.Trim) Then
            ErrorProvider1.SetError(supplieraddr, "Please enter an address")
            MessageBox.Show("Please input an address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            supplieraddr.Focus()
        ElseIf String.IsNullOrEmpty(supplierphoneno.Text.Trim) Then
            ErrorProvider1.SetError(supplierphoneno, "Please enter a phone number")
            MessageBox.Show("Please input a phone number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            supplierphoneno.Focus()
        ElseIf String.IsNullOrEmpty(supplieremail.Text.Trim) Then
            ErrorProvider1.SetError(supplieremail, "Please enter an email")
            MessageBox.Show("Please input an email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            supplieremail.Focus()
        Else
            Try
                Updates("UPDATE tbl_supplier SET name='" & suppliername.Text & "', 
            address='" & supplieraddr.Text & "', phone_num='" & supplierphoneno.Text & "', 
            email='" & supplieremail.Text & "' WHERE sup_id='" & supplierid.Text & "'")
                ErrorProvider1.SetError(suppliername, String.Empty)
                ErrorProvider1.SetError(supplieraddr, String.Empty)
                ErrorProvider1.SetError(supplierphoneno, String.Empty)
                ErrorProvider1.SetError(supplieremail, String.Empty)
                supplierPanel.Hide()
                Reloads()
                Eraser()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs)
        Try
            delete("DELETE FROM tbl_supplier WHERE sup_id ='" & supplierid.Text & "'")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs)
        supplierid.Text = ""
        suppliername.Clear()
        supplieraddr.Clear()
        supplieremail.Clear()
        supplierphoneno.Clear()
    End Sub





    Private Sub Guna2HtmlLabel3_Click(sender As Object, e As EventArgs) Handles Guna2HtmlLabel3.Click

    End Sub

    Private Sub supplierphoneno_TextChanged(sender As Object, e As EventArgs) Handles supplierphoneno.TextChanged

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        btnSave.Enabled = True
        supplierPanel.Show()
        Eraser()
    End Sub

    Private Sub formSupplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Reloads()
        supplierPanel.Hide()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        supplierPanel.Hide()
    End Sub

    Private Sub supplierphoneno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles supplierphoneno.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("this field only accepts numbers only")
        End If
    End Sub

    Private Sub supplierDataGrid_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles supplierDataGrid.CellContentClick
        supplierid.Text = CStr(supplierDataGrid.CurrentRow.Cells(0).Value)
        suppliername.Text = CStr(supplierDataGrid.CurrentRow.Cells(1).Value)
        supplieraddr.Text = CStr(supplierDataGrid.CurrentRow.Cells(2).Value)
        supplierphoneno.Text = CStr(supplierDataGrid.CurrentRow.Cells(3).Value)
        supplieremail.Text = CStr(supplierDataGrid.CurrentRow.Cells(4).Value)

        Try
            If supplierDataGrid.Columns(e.ColumnIndex).Name = "Edit" Then
                supplierPanel.Show()
                btnSave.Enabled = False
                Dim dr As DataGridViewRow = supplierDataGrid.SelectedRows(0)
                supplierid.Text = dr.Cells(2).Value.ToString()
                suppliername.Text = dr.Cells(3).Value.ToString()
                supplieraddr.Text = dr.Cells(4).Value.ToString()
                supplierphoneno.Text = dr.Cells(5).Value.ToString()
                supplieremail.Text = dr.Cells(6).Value.ToString()

            ElseIf supplierDataGrid.Columns(e.ColumnIndex).Name = "Deletes" Then
                Try
                    delete("DELETE FROM tbl_supplier WHERE sup_id ='" & supplierDataGrid.SelectedRows(0).Cells(2).Value.ToString() & "'")
                    Reloads()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class