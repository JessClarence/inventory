Public Class Dashboard
    Private Sub customizeDesigning()
        subPanelSupplier.Visible = False
        subPanelCustomer.Visible = False
    End Sub

    Private Sub hideSubMenu()
        If subPanelSupplier.Visible = True Then
            subPanelSupplier.Visible = False
        End If
        If subPanelCustomer.Visible = True Then
            subPanelCustomer.Visible = False
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

    Private Sub addForm(frm As Form)
        PanelContainer.Controls.Clear()
        frm.TopLevel = False
        frm.TopMost = True
        frm.Dock = DockStyle.Fill
        PanelContainer.Controls.Add(frm)
        frm.Show()
    End Sub

    Private Sub change_menu(menu As String)
        Select Case menu
            Case "UOM"
                addForm(formUOM)
            Case "Category"
                addForm(formCategory)
            Case "Product"
                addForm(formProduct)
            Case "Supplier"
                addForm(formSupplier)
            Case "Customer"
                addForm(formCustomer)
            Case "Delivery"
                addForm(formDelivery)
            Case "Delivery Transaction"
                addForm(formDeliveryDetails)
            Case "Orders"
                addForm(formOrders)
            Case "Orders Transaction"
                addForm(formOrderDetails)
        End Select
    End Sub

    Private Sub btnSupplier_Click(sender As Object, e As EventArgs) Handles btnSupplier.Click
        showSubMenu(subPanelSupplier)
    End Sub

    Private Sub btnListofSupplier_Click(sender As Object, e As EventArgs) Handles btnListofSupplier.Click
        change_menu("Supplier")

        hideSubMenu()

    End Sub

    Private Sub btnDelivery_Click(sender As Object, e As EventArgs) Handles btnDelivery.Click
        change_menu("Delivery")

        hideSubMenu()
    End Sub

    Private Sub btnDeliTrans_Click(sender As Object, e As EventArgs) Handles btnDeliDet.Click
        change_menu("Delivery Transaction")
        hideSubMenu()
    End Sub

    Private Sub btnCustomer_Click(sender As Object, e As EventArgs) Handles btnCustomer.Click
        showSubMenu(subPanelCustomer)
    End Sub

    Private Sub btnListofCust_Click(sender As Object, e As EventArgs) Handles btnListofCust.Click
        change_menu("Customer")
        hideSubMenu()
    End Sub

    Private Sub btnOrders_Click(sender As Object, e As EventArgs) Handles btnOrders.Click
        change_menu("Orders")
        hideSubMenu()
    End Sub

    Private Sub btnOrdersTrans_Click(sender As Object, e As EventArgs) Handles btnOrderDet.Click
        change_menu("Orders Transaction")
        hideSubMenu()
    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        customizeDesigning()
        change_menu("UOM")
    End Sub

    Private Sub btnUOM_Click(sender As Object, e As EventArgs) Handles btnUOM.Click
        change_menu("UOM")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        change_menu("Category")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        change_menu("Product")
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Select Case MsgBox("Are you sure you want to Logged Out?", MsgBoxStyle.YesNoCancel, "EXIT")
            Case MsgBoxResult.Yes
                LoginPage.Show()
                Me.Close()
        End Select

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Select Case MsgBox("Do you want to Exit?", MsgBoxStyle.YesNoCancel, "EXIT")
            Case MsgBoxResult.Yes
                LoginPage.Show()
                Me.Close()
        End Select
    End Sub
End Class