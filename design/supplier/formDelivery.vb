Public Class formDelivery
    Private Sub Reloads()
        Try


            Reload("SELECT tbl_delivery.deli_id, tbl_delivery.transaction_id, tbl_supplier.name," &
                    " tbl_delivery.date" &
                    " FROM tbl_delivery" &
                    " left join tbl_supplier ON supplier_id = sup_id", deliveryDataGrid)

            idDropDownReload("SELECT * from tbl_supplier", deliverySupComboBox, "name", "sup_id", "tbl_supplier")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Eraser()
        deliveryid.Text = ""
        firstNum = gen.Next(100000)
        secondNum = gen.Next(100000)
        thirdNum = gen.Next(100000)
        deliveryTransaction.Text = CStr(firstNum) + " - " + CStr(secondNum) + " - " + CStr(thirdNum)
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If String.IsNullOrEmpty(deliverySupComboBox.Text.Trim) Then
            ErrorProvider1.SetError(deliverySupComboBox, "Please select a supplier id")
            MessageBox.Show("Please select a supplier id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            deliverySupComboBox.Focus()
        Else
            Try
                Create("INSERT INTO tbl_delivery (transaction_id,supplier_id,date) VALUES('" & deliveryTransaction.Text & "',
            '" & deliverySupComboBox.SelectedValue.ToString & "', '" & deliveryDate.Text & "')")


                ErrorProvider1.SetError(deliveryTransaction, String.Empty)
                ErrorProvider1.SetError(deliverySupComboBox, String.Empty)
                ErrorProvider1.SetError(deliveryDate, String.Empty)
                Reloads()
                Eraser()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If


    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If String.IsNullOrEmpty(deliverySupComboBox.Text.Trim) Then
            ErrorProvider1.SetError(deliverySupComboBox, "Please select a supplier id")
            MessageBox.Show("Please select a supplier id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            deliverySupComboBox.Focus()
        Else
            Try
                Updates("UPDATE tbl_delivery SET transaction_id='" & deliveryTransaction.Text & "', 
            supplier_id='" & deliverySupComboBox.SelectedValue.ToString & "', date='" & deliveryDate.Text & "' WHERE deli_id='" & deliveryid.Text & "'")
                ErrorProvider1.SetError(deliveryTransaction, String.Empty)
                ErrorProvider1.SetError(deliverySupComboBox, String.Empty)
                deliveryPanel.Hide()
                Reloads()
                Eraser()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs)
        deliveryid.Text = ""
        deliveryTransaction.Text = CStr((gen.Next(100000)))
    End Sub



    Private Sub formDelivery_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Reloads()
        deliveryPanel.Hide()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        btnSave.Enabled = True
        deliveryPanel.Show()
        Eraser()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        deliveryPanel.Hide()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs)
        idDropDownReload("SELECT * from tbl_supplier", deliverySupComboBox, "sup_id", "tbl_supplier")
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        idDropDownReload("SELECT * from tbl_supplier", deliverySupComboBox, "name", "sup_id", "tbl_supplier")
    End Sub

    Private Sub deliveryDataGrid_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles deliveryDataGrid.CellContentClick
        Try
            If deliveryDataGrid.Columns(e.ColumnIndex).Name = "Edit" Then
                deliveryPanel.Show()
                btnSave.Enabled = False
                Dim dr As DataGridViewRow = deliveryDataGrid.SelectedRows(0)
                deliveryid.Text = dr.Cells(2).Value.ToString()
                deliveryTransaction.Text = dr.Cells(3).Value.ToString()
                deliverySupComboBox.Text = dr.Cells(4).Value.ToString()
            ElseIf deliveryDataGrid.Columns(e.ColumnIndex).Name = "Deletes" Then
                Try
                    delete("DELETE FROM tbl_delivery WHERE deli_id ='" & deliveryDataGrid.SelectedRows(0).Cells(2).Value.ToString() & "'")
                    Reloads()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class