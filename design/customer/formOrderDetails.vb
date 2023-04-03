Public Class formOrderDetails

    Dim resultOforderQuantities As New Dictionary(Of String, Integer)
    Private Sub hideSubMenu()
        If notifPanel.Visible = True Then
            notifPanel.Visible = False
        End If

    End Sub

    Private Sub showSubMenu(ByVal subMenu As Panel)
        If (subMenu.Visible = False) Then
            hideSubMenu()
            subMenu.Visible = True
        Else
            subMenu.Visible = False
        End If
    End Sub

    Private Sub calculation()
        Dim nameQuantities As New Dictionary(Of String, Integer)

        For Each row As DataGridViewRow In orderDataGrid.Rows
            Dim name As String = CStr(row.Cells("Column3").Value)
            Dim quantity As Integer = CInt(row.Cells("Column4").Value)

            If nameQuantities.ContainsKey(name) Then
                nameQuantities(name) += quantity
            Else
                nameQuantities.Add(name, quantity)
            End If
        Next

        For Each nameQuantityPair As KeyValuePair(Of String, Integer) In nameQuantities
            Dim index As Integer = nameQuantities.ToList().IndexOf(nameQuantityPair)
            Dim name As String = nameQuantityPair.Key
            Dim quantity As Integer = nameQuantityPair.Value
            resultOforderQuantities(name) = quantity
            If formDeliveryDetails.resultOfdeliveryQuantities.ContainsKey(name) Then
                Dim estimates = formDeliveryDetails.resultOfdeliveryQuantities(name) - quantity
                If estimates < 3 Then
                    Label2.Show()
                    MessageBox.Show($"WARNING: The {name} of the supply is very Low", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Label2.Text = $"WARNING: The {index} of the supply is very Low"
                End If
            End If
        Next
    End Sub

    Private Sub Reloads()

        Try

            Reload("SELECT tbl_orders_details.ords_det_id, tbl_orders.transaction_id, tbl_product.name," &
                   " tbl_orders_details.quantity " &
                   " FROM tbl_orders_details" &
                   " left join tbl_orders ON orders_id = ords_id" &
                   " left join tbl_product ON product_id = pid", orderDataGrid)


            idDropDownReload("SELECT * from tbl_orders", orderDetComboBox, "transaction_id", "ords_id", "tbl_orders")
            idDropDownReload("SELECT * from tbl_product", productDetComboBox, "name", "pid", "tbl_product")


            calculation()



        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Eraser()
        orderDetid.Text = ""
        orderQuantity.Clear()
    End Sub


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        formDeliveryDetails.Show()
        formDeliveryDetails.Hide()




        Dim productName As String = productDetComboBox.Text
        Dim orderQuantityInteger As Integer

        If resultOforderQuantities.ContainsKey(productName) Then
            orderQuantityInteger = resultOforderQuantities(productName)
        End If

        Dim orders = orderQuantityInteger + CInt(orderQuantity.Text)


        If String.IsNullOrEmpty(orderDetComboBox.Text.Trim) Then
            ErrorProvider1.SetError(orderDetComboBox, "Please enter order id")
            MessageBox.Show("Please enter order id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            orderDetComboBox.Focus()
        ElseIf String.IsNullOrEmpty(productDetComboBox.Text.Trim) Then
            ErrorProvider1.SetError(productDetComboBox, "Please enter product name")
            MessageBox.Show("Please input the product name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            productDetComboBox.Focus()
        ElseIf Not formDeliveryDetails.resultOfdeliveryQuantities.ContainsKey(productName) Then
            MessageBox.Show("This product has no supply yet", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ElseIf orders > formDeliveryDetails.resultOfdeliveryQuantities(productName) Then
            MessageBox.Show("Order quantity exceeds supply for " & productName, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            orderQuantity.Focus()
        ElseIf String.IsNullOrEmpty(orderQuantity.Text.Trim) Then
            ErrorProvider1.SetError(orderQuantity, "Please enter the quantity")
            MessageBox.Show("Please input the quantity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            orderQuantity.Focus()

        Else
            Try
                Create("INSERT INTO tbl_orders_details (orders_id,product_id,quantity) VALUES('" & orderDetComboBox.SelectedValue.ToString & "',
            '" & productDetComboBox.SelectedValue.ToString & "', '" & orderQuantity.Text & "')")
                ErrorProvider1.SetError(orderDetComboBox, String.Empty)
                ErrorProvider1.SetError(productDetComboBox, String.Empty)
                ErrorProvider1.SetError(orderQuantity, String.Empty)

                Reloads()
                Eraser()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        formDeliveryDetails.Show()
        formDeliveryDetails.Hide()


        Dim productName As String = productDetComboBox.Text
        Dim orderQuantityInteger As Integer

        If resultOforderQuantities.ContainsKey(productName) Then
            orderQuantityInteger = resultOforderQuantities(productName)
        End If


        Dim orders = orderQuantityInteger + CInt(orderQuantity.Text)

        If String.IsNullOrEmpty(orderDetComboBox.Text.Trim) Then
            ErrorProvider1.SetError(orderDetComboBox, "Please enter order id")
            MessageBox.Show("Please enter order id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            orderDetComboBox.Focus()
        ElseIf String.IsNullOrEmpty(productDetComboBox.Text.Trim) Then
            ErrorProvider1.SetError(productDetComboBox, "Please enter product id")
            MessageBox.Show("Please input the product id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            productDetComboBox.Focus()
        ElseIf Not formDeliveryDetails.resultOfdeliveryQuantities.ContainsKey(ProductName) Then
            MessageBox.Show("This product has no supply yet", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ElseIf orders > formDeliveryDetails.resultOfdeliveryQuantities(ProductName) Then
            MessageBox.Show("Order quantity exceeds supply for " & ProductName, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            orderQuantity.Focus()
        ElseIf String.IsNullOrEmpty(orderQuantity.Text.Trim) Then
            ErrorProvider1.SetError(orderQuantity, "Please enter the quantity")
            MessageBox.Show("Please input the quantity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            orderQuantity.Focus()
        Else
            Try
                Updates("UPDATE tbl_orders_details SET orders_id='" & orderDetComboBox.SelectedValue.ToString & "', 
            product_id='" & productDetComboBox.SelectedValue.ToString & "', quantity='" & orderQuantity.Text & "' WHERE ords_det_id='" & orderDetid.Text & "'")
                ErrorProvider1.SetError(orderDetComboBox, String.Empty)
                ErrorProvider1.SetError(productDetComboBox, String.Empty)
                ErrorProvider1.SetError(orderQuantity, String.Empty)
                orderPanel.Hide()
                Reloads()
                Eraser()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs)
        orderDetid.Text = ""
        orderQuantity.Clear()
    End Sub

    Private Sub btnReload_Click(sender As Object, e As EventArgs)
        Try
            Reload("SELECT * FROM tbl_orders_details", orderDataGrid)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub



    Private Sub productDetComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles productDetComboBox.SelectedIndexChanged

    End Sub



    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        btnSave.Enabled = True
        orderPanel.Show()
        Eraser()
    End Sub

    Private Sub formOrderDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Reloads()
        Label2.Hide()
        orderPanel.Hide()
        hideSubMenu()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        orderPanel.Hide()
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        idDropDownReload("SELECT * from tbl_orders", orderDetComboBox, "transaction_id", "ords_id", "tbl_orders")
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        idDropDownReload("SELECT * from tbl_product", productDetComboBox, "name", "pid", "tbl_product")
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        showSubMenu(notifPanel)
    End Sub

    Private Sub deliveryDataGrid_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles orderDataGrid.CellContentClick
        orderDetid.Text = CStr(orderDataGrid.CurrentRow.Cells(0).Value)
        orderDetComboBox.Text = CStr(orderDataGrid.CurrentRow.Cells(1).Value)
        productDetComboBox.Text = CStr(orderDataGrid.CurrentRow.Cells(2).Value)
        orderQuantity.Text = CStr(orderDataGrid.CurrentRow.Cells(3).Value)

        Try
            If orderDataGrid.Columns(e.ColumnIndex).Name = "Edit" Then
                orderPanel.Show()
                btnSave.Enabled = False
                Dim dr As DataGridViewRow = orderDataGrid.SelectedRows(0)
                orderDetid.Text = dr.Cells(2).Value.ToString()
                orderDetComboBox.Text = dr.Cells(3).Value.ToString()
                productDetComboBox.Text = dr.Cells(4).Value.ToString()
                orderQuantity.Text = dr.Cells(5).Value.ToString()
            ElseIf orderDataGrid.Columns(e.ColumnIndex).Name = "Deletes" Then
                Try
                    delete("DELETE FROM tbl_orders_details WHERE ords_det_id ='" & orderDataGrid.SelectedRows(0).Cells(2).Value.ToString() & "'")
                    Reloads()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class