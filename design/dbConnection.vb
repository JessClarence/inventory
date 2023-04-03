Imports MySql.Data.MySqlClient

Module dbConnection
    Public Function strconnection() As MySqlConnection
        Return New MySqlConnection("server=localhost;user id=root;password=;database=inventorydb")
    End Function
    Public strcon As MySqlConnection = strconnection()

    Public result As String
    Public cmd As New MySqlCommand
    Public da As New MySqlDataAdapter
    Public dt As New DataTable
    Public reader As MySqlDataReader
    Public gen As New Random
    Public firstNum As Integer
    Public secondNum As Integer
    Public thirdNum As Integer
    'Public resultOfdeliveryQuantities As New Dictionary(Of String, Integer)
    'Public resultOforderQuantities As New Dictionary(Of String, Integer)


    Public Sub Login(ByVal sql As String)
        Try
            If strcon.State <> ConnectionState.Open Then
                strcon.Open()
            End If
            da = New MySqlDataAdapter(sql, strcon)
            dt.Clear()
            da.Fill(dt)
            If dt.Rows.Count() <= 0 Then
                MessageBox.Show("username and password is invalid")
            Else
                MessageBox.Show("Successful Connect to the Database")
                LoginPage.Hide()
                Dashboard.Show()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If strcon.State = ConnectionState.Open Then
                strcon.Close()
            End If
        End Try
    End Sub

    Public Sub Create(ByVal sql As String)

        Try
            If strcon.State <> ConnectionState.Open Then
                strcon.Open()
            End If

            Dim cmd As New MySqlCommand(sql, strcon)
            Dim result As Integer = cmd.ExecuteNonQuery()

            If result = 0 Then
                MessageBox.Show("Failed to save the data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Data has been saved in the database", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If strcon.State = ConnectionState.Open Then
                strcon.Close()
            End If
        End Try
    End Sub

    Public Sub Reload(ByVal sql As String, ByVal DTG As DataGridView)
        Try
            dt = New DataTable
            If strcon.State <> ConnectionState.Open Then
                strcon.Open()
            End If
            With cmd
                .Connection = strcon
                .CommandText = sql
            End With
            da.SelectCommand = cmd
            da.Fill(dt)
            DTG.DataSource = dt
        Catch ex As Exception
            If strcon.State = ConnectionState.Open Then
                strcon.Close()
            End If
            da.Dispose()
        End Try
    End Sub

    Public Sub Updates(ByVal sql As String)
        Try
            If strcon.State <> ConnectionState.Open Then
                strcon.Open()
            End If
            With cmd
                .Connection = strcon
                .CommandText = sql

                result = CStr(cmd.ExecuteNonQuery)
                If result = "0" Then
                    MessageBox.Show("Data failed", "error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Data has updated successfully", "success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If strcon.State = ConnectionState.Open Then
                strcon.Close()
            End If
        End Try

    End Sub

    Public Sub delete(ByVal sql As String)
        Try
            If strcon.State <> ConnectionState.Open Then
                strcon.Open()
            End If
            With cmd
                .Connection = strcon
                .CommandText = sql

                result = CStr(cmd.ExecuteNonQuery)
                If result = "0" Then
                    MessageBox.Show("failed to delete", "error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Data has deleted successfully", "success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If strcon.State = ConnectionState.Open Then
                strcon.Close()
            End If
        End Try
    End Sub

    Public Sub dropDownReload(ByVal sql As String, ByVal combobox As ComboBox)
        Try
            If strcon.State <> ConnectionState.Open Then
                strcon.Open()
            End If
            With cmd
                .Connection = strcon
                .CommandText = sql

                result = CStr(cmd.ExecuteNonQuery)
                reader = cmd.ExecuteReader
                While reader.Read
                    Dim sname = reader.GetString("name")
                    If combobox.Items.Contains(sname) = False Then
                        combobox.Items.Add(sname)
                    End If
                End While
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If strcon.State = ConnectionState.Open Then
                strcon.Close()
            End If
        End Try
    End Sub

    Public Sub productDropDownReload(ByVal sql As String, ByVal combobox As ComboBox)
        Try
            If strcon.State <> ConnectionState.Open Then
                strcon.Open()
            End If
            With cmd
                .Connection = strcon
                .CommandText = sql

                result = CStr(cmd.ExecuteNonQuery)
                reader = cmd.ExecuteReader
                While reader.Read
                    Dim scode = reader.GetString("code")
                    If combobox.Items.Contains(scode) = False Then
                        combobox.Items.Add(scode)
                    End If
                End While
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If strcon.State = ConnectionState.Open Then
                strcon.Close()
            End If
        End Try
    End Sub

    Public Sub idDropDownReload(ByVal sql As String, ByVal combobox As ComboBox, ByVal column As String, ByVal Optional idname As String = Nothing, ByVal Optional table As String = Nothing)
        Try
            If strcon.State <> ConnectionState.Open Then
                strcon.Open()
            End If

            Dim adapter As New MySqlDataAdapter(sql, strcon)
            Dim dataset As New DataSet()

            adapter.Fill(dataset, table)

            With combobox
                .DataSource = dataset.Tables(table)
                .DisplayMember = column
                .ValueMember = idname
            End With

            'With cmd
            '    .Connection = strcon
            '    .CommandText = sql

            '    result = CStr(cmd.ExecuteNonQuery)
            '    reader = cmd.ExecuteReader
            '    While reader.Read
            '        Dim sid = reader.GetString("id")
            '        Dim sname = reader.GetString("name")
            '        If combobox.Items.Contains(sid) = False Then
            '            combobox.Tag = sid
            '            combobox.Items.Add(sname)
            '        End If
            '    End While
            'End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If strcon.State = ConnectionState.Open Then
                strcon.Close()
            End If
        End Try
    End Sub



    Public Function RetrieveID(ByVal sql As String) As String
        Dim categoryId As String

        Try
            ' Retrieve the category ID based on the selected name
            Dim cmd As New MySqlCommand(sql, strcon)
            reader = cmd.ExecuteReader

            If reader.Read() Then
                categoryId = reader.GetString("id")
            End If
            reader.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Return categoryId
    End Function

End Module
