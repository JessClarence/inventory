Public Class formProduct


    Private Sub Reloads()
        Try
            Reload("SELECT tbl_product.pid, tbl_product.name, tbl_product.code," &
                   " tbl_product.description, tbl_product.actual_price," &
                   " tbl_product.old_price, tbl_category.name, tbl_uom.name FROM tbl_product" &
                   " left join tbl_category ON category_id = cid" &
                   " left join tbl_uom ON uom_id = uid", productDataGrid)
            idDropDownReload("SELECT * from tbl_category", categoryComboBox, "name", "cid", "tbl_category")
            idDropDownReload("SELECT * from tbl_uom", uomComboBox, "name", "uid", "tbl_uom")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Eraser()
        productid.Text = ""
        productcode.Text = CStr(gen.Next(100000))
        productdesc.Clear()
        productactprice.Clear()
        productoldprice.Clear()
        productname.Clear()
    End Sub



    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If String.IsNullOrEmpty(productcode.Text.Trim) Then
            ErrorProvider1.SetError(productcode, "Please enter code")
            MessageBox.Show("Please input a code", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            productcode.Focus()
        ElseIf String.IsNullOrEmpty(productactprice.Text.Trim) Then
            ErrorProvider1.SetError(productactprice, "Please enter the actual price")
            MessageBox.Show("Please input the actual price", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            productactprice.Focus()
        ElseIf String.IsNullOrEmpty(productname.Text.Trim) Then
            ErrorProvider1.SetError(productname, "Please enter product name")
            MessageBox.Show("Please input product name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            productactprice.Focus()
        ElseIf String.IsNullOrEmpty(productoldprice.Text.Trim) Then
            ErrorProvider1.SetError(productoldprice, "Please enter the old price")
            MessageBox.Show("Please input the old price", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            productoldprice.Focus()
        ElseIf String.IsNullOrEmpty(categoryComboBox.Text.Trim) Then
            ErrorProvider1.SetError(categoryComboBox, "Please select a category")
            MessageBox.Show("Please select a category", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            categoryComboBox.Focus()
        ElseIf String.IsNullOrEmpty(uomComboBox.Text.Trim) Then
            ErrorProvider1.SetError(uomComboBox, "Please select a UOM")
            MessageBox.Show("Please select a UOM", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            uomComboBox.Focus()
        Else
            Try

                Create("INSERT INTO tbl_product (name,code,description,actual_price,old_price,category_id,uom_id) VALUES('" &
                       productname.Text & "','" & productcode.Text & "', '" & productdesc.Text & "', '" & productactprice.Text & "', 
                       '" & productoldprice.Text & "', '" & categoryComboBox.SelectedValue.ToString & "', '" & uomComboBox.SelectedValue.ToString & "')")



                ErrorProvider1.SetError(productcode, String.Empty)
                ErrorProvider1.SetError(productactprice, String.Empty)
                ErrorProvider1.SetError(productoldprice, String.Empty)
                ErrorProvider1.SetError(categoryComboBox, String.Empty)
                ErrorProvider1.SetError(uomComboBox, String.Empty)
                ErrorProvider1.SetError(productname, String.Empty)
                Reloads()
                Eraser()

                productcode.Text = CStr(gen.Next(100000))
                productcode.Text = CStr(gen.Next(100000))
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If String.IsNullOrEmpty(productcode.Text.Trim) Then
            ErrorProvider1.SetError(productcode, "Please enter code")
            MessageBox.Show("Please input a code", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            productcode.Focus()
        ElseIf String.IsNullOrEmpty(productname.Text.Trim) Then
            ErrorProvider1.SetError(productname, "Please enter the product name")
            MessageBox.Show("Please input the product name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            productactprice.Focus()
        ElseIf String.IsNullOrEmpty(productactprice.Text.Trim) Then
            ErrorProvider1.SetError(productactprice, "Please enter the actual price")
            MessageBox.Show("Please input the actual price", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            productactprice.Focus()
        ElseIf String.IsNullOrEmpty(productoldprice.Text.Trim) Then
            ErrorProvider1.SetError(productoldprice, "Please enter the old price")
            MessageBox.Show("Please input the old price", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            productoldprice.Focus()
        ElseIf String.IsNullOrEmpty(categoryComboBox.Text.Trim) Then
            ErrorProvider1.SetError(categoryComboBox, "Please select a category")
            MessageBox.Show("Please select a category", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            categoryComboBox.Focus()
        ElseIf String.IsNullOrEmpty(uomComboBox.Text.Trim) Then
            ErrorProvider1.SetError(uomComboBox, "Please select a UOM")
            MessageBox.Show("Please select a UOM", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            uomComboBox.Focus()
        Else
            Try
                Updates("UPDATE tbl_product SET name='" & productname.Text & "' , code='" & productcode.Text & "', 
                description='" & productdesc.Text & "', actual_price='" & productactprice.Text & "', 
                old_price='" & productoldprice.Text & "', category_id='" & categoryComboBox.SelectedValue.ToString & "', uom_id='" & uomComboBox.SelectedValue.ToString &
                "' WHERE pid='" & productid.Text & "'")
                ErrorProvider1.SetError(productcode, String.Empty)
                ErrorProvider1.SetError(productactprice, String.Empty)
                ErrorProvider1.SetError(productoldprice, String.Empty)
                ErrorProvider1.SetError(categoryComboBox, String.Empty)
                ErrorProvider1.SetError(uomComboBox, String.Empty)
                ErrorProvider1.SetError(productname, String.Empty)
                productPanel.Hide()
                Reloads()
                Eraser()

                productcode.Text = CStr(gen.Next(100000))
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If

    End Sub





    Private Sub productactprice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles productactprice.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("this field only accepts numbers only")
        End If
    End Sub

    Private Sub productoldprice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles productoldprice.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("this field only accepts numbers only")
        End If
    End Sub

    Private Sub productcode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles productcode.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("this field only accepts numbers only")
        End If
    End Sub

    Private Sub productactprice_TextChanged(sender As Object, e As EventArgs) Handles productactprice.TextChanged

    End Sub

    Private Sub formProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        productcode.Text = CStr(gen.Next(100000))
        Reloads()
        productPanel.Hide()
    End Sub

    Private Sub productcode_TextChanged(sender As Object, e As EventArgs) Handles productcode.TextChanged

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs)
        MessageBox.Show("DropDown List is now refreshed", "success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        dropDownReload("SELECT * from tbl_uom", uomComboBox)
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        btnSave.Enabled = True
        productPanel.Show()
        Eraser()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        productPanel.Hide()
    End Sub

    Private Sub gunatext1_Click(sender As Object, e As EventArgs) Handles gunatext1.Click

    End Sub

    Private Sub productDataGrid_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub productDataGrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles productDataGrid.CellContentClick
        Try
            If productDataGrid.Columns(e.ColumnIndex).Name = "Edit" Then
                productPanel.Show()
                btnSave.Enabled = False
                Dim dr As DataGridViewRow = productDataGrid.SelectedRows(0)
                productid.Text = dr.Cells(2).Value.ToString()
                productname.Text = dr.Cells(3).Value.ToString()
                productcode.Text = dr.Cells(4).Value.ToString()
                productdesc.Text = dr.Cells(5).Value.ToString()
                productactprice.Text = dr.Cells(6).Value.ToString()
                productoldprice.Text = dr.Cells(7).Value.ToString()
                categoryComboBox.Text = dr.Cells(8).Value.ToString()
                uomComboBox.Text = dr.Cells(9).Value.ToString()
            ElseIf productDataGrid.Columns(e.ColumnIndex).Name = "Deletes" Then
                Try
                    delete("DELETE FROM tbl_product WHERE pid ='" & productDataGrid.SelectedRows(0).Cells(2).Value.ToString() & "'")
                    Reloads()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Guna2Button1_Click_1(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        idDropDownReload("SELECT * from tbl_category", categoryComboBox, "name", "cid", "tbl_category")
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        idDropDownReload("SELECT * from tbl_uom", uomComboBox, "name", "uid", "tbl_uom")
    End Sub
End Class