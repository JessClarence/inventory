Public Class formOrders

    Private Sub Reloads()
        Try
            'Reload("SELECT * FROM tbl_orders", orderDataGrid)

            Reload("SELECT tbl_orders.ords_id, tbl_orders.transaction_id, tbl_customer.name," &
                    " tbl_orders.date" &
                    " FROM tbl_orders" &
                    " left join tbl_customer ON customer_id = cust_id", orderDataGrid)

            idDropDownReload("SELECT * from tbl_customer", customerSupComboBox, "name", "cust_id", "tbl_customer")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Eraser()
        orderid.Text = ""
        firstNum = gen.Next(100000)
        secondNum = gen.Next(100000)
        thirdNum = gen.Next(100000)
        orderTransaction.Text = CStr(firstNum) + " - " + CStr(secondNum) + " - " + CStr(thirdNum)
    End Sub



    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If String.IsNullOrEmpty(customerSupComboBox.Text.Trim) Then
            ErrorProvider1.SetError(customerSupComboBox, "Please select a customer id")
            MessageBox.Show("Please select an customer id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            customerSupComboBox.Focus()
        Else
            Try
                Create("INSERT INTO tbl_orders (transaction_id,customer_id,date) VALUES('" & orderTransaction.Text & "',
            '" & customerSupComboBox.SelectedValue.ToString & "', '" & orderDate.Text & "')")
                ErrorProvider1.SetError(orderTransaction, String.Empty)
                ErrorProvider1.SetError(customerSupComboBox, String.Empty)
                ErrorProvider1.SetError(orderDate, String.Empty)
                Reloads()
                Eraser()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnReload_Click(sender As Object, e As EventArgs)
        Try
            Reload("SELECT * FROM tbl_orders", orderDataGrid)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If String.IsNullOrEmpty(customerSupComboBox.Text.Trim) Then
            ErrorProvider1.SetError(customerSupComboBox, "Please select a customer id")
            MessageBox.Show("Please select a customer id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            customerSupComboBox.Focus()
        Else
            Try
                Updates("UPDATE tbl_orders SET transaction_id='" & orderTransaction.Text & "', 
            customer_id='" & customerSupComboBox.SelectedValue.ToString & "', date='" & orderDate.Text & "' WHERE ords_id='" & orderid.Text & "'")
                ErrorProvider1.SetError(orderTransaction, String.Empty)
                ErrorProvider1.SetError(customerSupComboBox, String.Empty)
                orderPanel.Hide()
                Reloads()
                Eraser()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs)
        orderid.Text = ""
        orderTransaction.Text = CStr((gen.Next(100000)))
    End Sub



    Private Sub formOrders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Reloads()
        orderPanel.Hide()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        btnSave.Enabled = True
        orderPanel.Show()
        Eraser()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        orderPanel.Hide()
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        idDropDownReload("SELECT * from tbl_customer", customerSupComboBox, "name", "cust_id", "tbl_customer")
    End Sub

    Private Sub orderDataGrid_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles orderDataGrid.CellContentClick
        Try
            If orderDataGrid.Columns(e.ColumnIndex).Name = "Edit" Then
                orderPanel.Show()
                btnSave.Enabled = False
                Dim dr As DataGridViewRow = orderDataGrid.SelectedRows(0)
                orderid.Text = dr.Cells(2).Value.ToString()
                orderTransaction.Text = dr.Cells(3).Value.ToString()
                customerSupComboBox.Text = dr.Cells(4).Value.ToString()
                orderDate.Text = dr.Cells(5).Value.ToString()
            ElseIf orderDataGrid.Columns(e.ColumnIndex).Name = "Deletes" Then
                Try
                    delete("DELETE FROM tbl_orders WHERE ords_id ='" & orderDataGrid.SelectedRows(0).Cells(2).Value.ToString() & "'")
                    Reloads()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class