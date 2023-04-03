Public Class formCustomer
    Private Sub Reloads()
        Try
            Reload("SELECT * FROM tbl_customer", customerDataGrid)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Eraser()
        customerid.Text = ""
        customername.Clear()
        customeraddr.Clear()
        customeremail.Clear()
        customerphoneno.Clear()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If String.IsNullOrEmpty(customername.Text.Trim) Then
            ErrorProvider1.SetError(customername, "Please enter a name")
            MessageBox.Show("Please input a name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            customername.Focus()
        ElseIf String.IsNullOrEmpty(customeraddr.Text.Trim) Then
            ErrorProvider1.SetError(customeraddr, "Please enter an address")
            MessageBox.Show("Please input an address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            customeraddr.Focus()
        ElseIf String.IsNullOrEmpty(customerphoneno.Text.Trim) Then
            ErrorProvider1.SetError(customerphoneno, "Please enter a phone number")
            MessageBox.Show("Please input a phone number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            customerphoneno.Focus()
        ElseIf String.IsNullOrEmpty(customeremail.Text.Trim) Then
            ErrorProvider1.SetError(customeremail, "Please enter an email")
            MessageBox.Show("Please input an email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            customeremail.Focus()
        Else
            Try
                Create("INSERT INTO tbl_customer (name,address,phone_num,email) VALUES('" & customername.Text & "',
            '" & customeraddr.Text & "', '" & customerphoneno.Text & "', '" & customeremail.Text & "')")
                ErrorProvider1.SetError(customername, String.Empty)
                ErrorProvider1.SetError(customeraddr, String.Empty)
                ErrorProvider1.SetError(customerphoneno, String.Empty)
                ErrorProvider1.SetError(customeremail, String.Empty)
                Reloads()
                Eraser()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If String.IsNullOrEmpty(customername.Text.Trim) Then
            ErrorProvider1.SetError(customername, "Please enter a name")
            MessageBox.Show("Please input a name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            customername.Focus()
        ElseIf String.IsNullOrEmpty(customeraddr.Text.Trim) Then
            ErrorProvider1.SetError(customeraddr, "Please enter an address")
            MessageBox.Show("Please input an address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            customeraddr.Focus()
        ElseIf String.IsNullOrEmpty(customerphoneno.Text.Trim) Then
            ErrorProvider1.SetError(customerphoneno, "Please enter a phone number")
            MessageBox.Show("Please input a phone number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            customerphoneno.Focus()
        ElseIf String.IsNullOrEmpty(customeremail.Text.Trim) Then
            ErrorProvider1.SetError(customeremail, "Please enter an email")
            MessageBox.Show("Please input an email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            customeremail.Focus()
        Else
            Try
                Updates("UPDATE tbl_customer SET name='" & customername.Text & "', 
            address='" & customeraddr.Text & "', phone_num='" & customerphoneno.Text & "', 
            email='" & customeremail.Text & "' WHERE cust_id = '" & customerid.Text & "'")
                ErrorProvider1.SetError(customername, String.Empty)
                ErrorProvider1.SetError(customeraddr, String.Empty)
                ErrorProvider1.SetError(customerphoneno, String.Empty)
                ErrorProvider1.SetError(customeremail, String.Empty)
                customerPanel.Hide()
                Reloads()
                Eraser()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs)
        Try
            delete("DELETE FROM tbl_customer WHERE cust_id ='" & customerid.Text & "'")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs)
        customerid.Text = ""
        customername.Clear()
        customeraddr.Clear()
        customeremail.Clear()
        customerphoneno.Clear()
    End Sub



    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        btnSave.Enabled = True
        customerPanel.Show()
        Eraser()
    End Sub

    Private Sub formCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Reloads()
        customerPanel.Hide()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        customerPanel.Hide()
    End Sub

    Private Sub customerphoneno_KeyDown(sender As Object, e As KeyEventArgs) Handles customerphoneno.KeyDown

    End Sub

    Private Sub customerphoneno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles customerphoneno.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("this field only accepts numbers only")
        End If
    End Sub

    Private Sub customerDataGrid_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles customerDataGrid.CellContentClick
        Try
            If customerDataGrid.Columns(e.ColumnIndex).Name = "Edit" Then
                customerPanel.Show()
                btnSave.Enabled = False
                Dim dr As DataGridViewRow = customerDataGrid.SelectedRows(0)
                customerid.Text = dr.Cells(2).Value.ToString()
                customername.Text = dr.Cells(3).Value.ToString()
                customeraddr.Text = dr.Cells(4).Value.ToString()
                customerphoneno.Text = dr.Cells(5).Value.ToString()
                customeremail.Text = dr.Cells(6).Value.ToString()
            ElseIf customerDataGrid.Columns(e.ColumnIndex).Name = "Deletes" Then
                Try
                    delete("DELETE FROM tbl_customer WHERE cust_id ='" & customerDataGrid.SelectedRows(0).Cells(2).Value.ToString() & "'")
                    Reloads()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class