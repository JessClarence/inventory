Public Class formDeliveryDetails

    Public resultOfdeliveryQuantities As New Dictionary(Of String, Integer)
    Private Sub calculation()
        Dim OBJ As New formOrderDetails

        Dim nameQuantities As New Dictionary(Of String, Integer)

        For Each row As DataGridViewRow In deliveryDataGrid.Rows
            Dim name As String = CStr(row.Cells("Column3").Value)
            Dim quantity As Integer = CInt(row.Cells("Column4").Value)

            If nameQuantities.ContainsKey(name) Then
                nameQuantities(name) += quantity
            Else
                nameQuantities.Add(name, quantity)
            End If
        Next

        For Each nameQuantityPair As KeyValuePair(Of String, Integer) In nameQuantities
            Dim name As String = nameQuantityPair.Key
            Dim quantity As Integer = nameQuantityPair.Value
            resultOfdeliveryQuantities(name) = quantity
        Next
    End Sub

    Private Sub Reloads()
        Try
            Reload("SELECT tbl_delivery_details.deli_det_id, tbl_delivery.transaction_id, tbl_product.name," &
                   " tbl_delivery_details.quantity " &
                   " FROM tbl_delivery_details" &
                   " left join tbl_delivery ON delivery_id = deli_id" &
                   " left join tbl_product ON product_id = pid", deliveryDataGrid)

            idDropDownReload("SELECT * from tbl_delivery", deliveryComboBox, "transaction_id", "deli_id", "tbl_delivery")
            idDropDownReload("SELECT * from tbl_product", productComboBox, "name", "pid", "tbl_product")

            calculation()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Eraser()
        deliveryDetid.Text = ""
        deliveryQuantity.Clear()
    End Sub


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If String.IsNullOrEmpty(deliveryComboBox.Text.Trim) Then
            ErrorProvider1.SetError(deliveryComboBox, "Please enter delivery id")
            MessageBox.Show("Please enter delivery id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            deliveryComboBox.Focus()
        ElseIf String.IsNullOrEmpty(productComboBox.Text.Trim) Then
            ErrorProvider1.SetError(productComboBox, "Please enter product id")
            MessageBox.Show("Please input the product id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            productComboBox.Focus()
        ElseIf String.IsNullOrEmpty(deliveryQuantity.Text.Trim) Then
            ErrorProvider1.SetError(deliveryQuantity, "Please enter the quantity")
            MessageBox.Show("Please input the quantity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            deliveryQuantity.Focus()
        Else
            Try
                Create("INSERT INTO tbl_delivery_details (delivery_id,product_id,quantity) VALUES('" & deliveryComboBox.SelectedValue.ToString & "',
            '" & productComboBox.SelectedValue.ToString & "', '" & deliveryQuantity.Text & "')")

                ErrorProvider1.SetError(deliveryComboBox, String.Empty)
                ErrorProvider1.SetError(productComboBox, String.Empty)
                ErrorProvider1.SetError(deliveryQuantity, String.Empty)
                Reloads()
                Eraser()



            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub


    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If String.IsNullOrEmpty(deliveryComboBox.Text.Trim) Then
            ErrorProvider1.SetError(deliveryComboBox, "Please enter delivery id")
            MessageBox.Show("Please enter delivery id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            deliveryComboBox.Focus()
        ElseIf String.IsNullOrEmpty(productComboBox.Text.Trim) Then
            ErrorProvider1.SetError(productComboBox, "Please enter product id")
            MessageBox.Show("Please input the product id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            productComboBox.Focus()
        ElseIf String.IsNullOrEmpty(deliveryQuantity.Text.Trim) Then
            ErrorProvider1.SetError(deliveryQuantity, "Please enter the quantity")
            MessageBox.Show("Please input the quantity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            deliveryQuantity.Focus()
        Else
            Try
                Updates("UPDATE tbl_delivery_details SET delivery_id='" & deliveryComboBox.SelectedValue.ToString & "', 
            product_id='" & productComboBox.SelectedValue.ToString & "', quantity='" & deliveryQuantity.Text & "' WHERE deli_det_id='" & deliveryDetid.Text & "'")
                deliveryPanel.Hide()
                Reloads()
                Eraser()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs)
        deliveryDetid.Text = ""
        deliveryQuantity.Clear()
    End Sub


    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        btnSave.Enabled = True
        deliveryPanel.Show()
        Eraser()
    End Sub

    Private Sub formDeliveryDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Reloads()
        deliveryPanel.Hide()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        deliveryPanel.Hide()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        idDropDownReload("SELECT * from tbl_delivery", deliveryComboBox, "transaction_id", "deli_id", "tbl_delivery")
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        idDropDownReload("SELECT * from tbl_product", productComboBox, "name", "pid", "tbl_product")
    End Sub

    Private Sub deliveryDataGrid_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles deliveryDataGrid.CellContentClick
        Try
            If deliveryDataGrid.Columns(e.ColumnIndex).Name = "Edit" Then
                deliveryPanel.Show()
                btnSave.Enabled = False
                Dim dr As DataGridViewRow = deliveryDataGrid.SelectedRows(0)
                deliveryDetid.Text = dr.Cells(2).Value.ToString()
                deliveryComboBox.Text = dr.Cells(3).Value.ToString()
                productComboBox.Text = dr.Cells(4).Value.ToString()
                deliveryQuantity.Text = dr.Cells(5).Value.ToString()
            ElseIf deliveryDataGrid.Columns(e.ColumnIndex).Name = "Deletes" Then
                Try
                    delete("DELETE FROM tbl_delivery_details WHERE deli_det_id ='" & deliveryDataGrid.SelectedRows(0).Cells(2).Value.ToString() & "'")
                    Reloads()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class