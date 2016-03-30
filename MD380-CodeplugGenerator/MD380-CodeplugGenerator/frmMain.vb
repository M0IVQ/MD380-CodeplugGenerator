Imports System.IO

Public Class frmMain
    Dim contactsList(1000, 4) As String
    Dim filename As String

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tabMain.SelectedTab = tabContacts
        dlgOpenFile.ShowDialog()
        filename = dlgOpenFile.FileName
        getContacts()
    End Sub

    Private Sub getContacts()
        Dim callID As Integer
        Dim callType As Integer
        Dim callRxTone As Integer
        Dim contactName As String
        Dim offset As Integer = &H61A5
        Dim recordlength As Integer = 36
        Dim records As Integer = 1000
        'Dim codeplug As New BinaryReader(File.Open("c:\users\post2\desktop\codeplug.rdt", FileMode.Open))
        Dim codeplug As New BinaryReader(File.Open(filename, FileMode.Open))

        For recordindex = 1 To records
            codeplug.BaseStream.Seek((offset + (recordlength * (recordindex - 1))), SeekOrigin.Begin)
            callID = (codeplug.ReadByte) + (codeplug.ReadByte * 256) + (codeplug.ReadByte * 256 * 256)
            callType = codeplug.ReadByte
            callRxTone = (callType And &H20) / 32
            callType = (callType And &H03)
            contactName = ""
            For i = 1 To 16
                contactName = contactName & codeplug.ReadChar
                codeplug.ReadChar()
            Next
            contactsList(recordindex - 1, 0) = callID
            contactsList(recordindex - 1, 1) = callType
            contactsList(recordindex - 1, 2) = callRxTone
            contactsList(recordindex - 1, 3) = contactName
        Next

        Dim callTypes(4) As String
        callTypes(0) = ""
        callTypes(1) = "Group"
        callTypes(2) = "Private"
        callTypes(3) = "All"

        Dim yesNo(2) As String
        yesNo(0) = "No"
        YesNo(1) = "Yes"

        Dim cmbCallType As New DataGridViewComboBoxColumn()
        cmbCallType.MaxDropDownItems = 4
        cmbCallType.Items.Add("")
        cmbCallType.Items.Add("Group")
        cmbCallType.Items.Add("Private")
        cmbCallType.Items.Add("All")

        Dim cmbCallRxTone As New DataGridViewComboBoxColumn()
        cmbCallRxTone.Items.Add("No")
        cmbCallRxTone.Items.Add("Yes")

        dgvContacts.ColumnCount = 2
        dgvContacts.Columns.Insert(1, cmbCallType)
        dgvContacts.Columns.Insert(3, cmbCallRxTone)

        dgvContacts.Columns(0).Name = "Contact Name" '"Call ID"
        dgvContacts.Columns(1).Name = "Call Type"
        dgvContacts.Columns(2).Name = "Call ID" '"Call Receive Tone"
        dgvContacts.Columns(3).Name = "Call Rx Tone" '"Contact Name"

        For i = 0 To contactsList.GetUpperBound(0)
            'Select Case contactsList(i, 1)
            'Case 0
            'contactsList(i, 1) = ""
            'Case 1
            'contactsList(i, 1) = "Group"
            'Case 2
            'contactsList(i, 1) = "Private"
            'Case 3
            'contactsList(i, 1) = "All"
            'End Select

            'Select Case contactsList(i, 2)
            'Case 0
            'contactsList(i, 2) = "No"
            'Case 1
            'contactsList(i, 2) = "Yes"
            'End Select

            dgvContacts.Rows.Add(contactsList(i, 3), callTypes(contactsList(i, 1)), contactsList(i, 1), yesNo(contactsList(i, 2)))
        Next
        'MsgBox(contactsList(5, 0) & " " & contactsList(0, 1) & " " & contactsList(0, 2) & " " & contactsList(0, 3))
    End Sub

    Private Sub dgvContacts_RowPostPaint(ByVal sender As Object, ByVal e As DataGridViewRowPostPaintEventArgs) Handles dgvContacts.RowPostPaint
        Using b As SolidBrush = New SolidBrush(dgvContacts.RowHeadersDefaultCellStyle.ForeColor)
            e.Graphics.DrawString(e.RowIndex + 1.ToString(System.Globalization.CultureInfo.CurrentUICulture),
            dgvContacts.DefaultCellStyle.Font,
            b,
            e.RowBounds.Location.X + 10,
            e.RowBounds.Location.Y + 4)
        End Using
    End Sub

    Private Sub tabContacts_Click(sender As Object, e As EventArgs) Handles tabContacts.Click

    End Sub
End Class