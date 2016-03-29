Imports System.IO

Public Class frmMain
    Dim contactsList(1000, 4) As String

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tabMain.SelectedTab = tabContacts
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
        Dim codeplug As New BinaryReader(File.Open("c:\users\post2\desktop\codeplug.rdt", FileMode.Open))

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
        dgvContacts.ColumnCount = 4

        For i = 0 To contactsList.GetUpperBound(0)
            Select Case contactsList(i, 1)
                Case 0
                    contactsList(i, 1) = ""
                Case 1
                    contactsList(i, 1) = "Group"
                Case 2
                    contactsList(i, 1) = "Private"
                Case 3
                    contactsList(i, 1) = "All"
            End Select

            Select Case contactsList(i, 2)
                Case 0
                    contactsList(i, 2) = "No"
                Case 1
                    contactsList(i, 2) = "Yes"
            End Select

            dgvContacts.Rows.Add(contactsList(i, 0), contactsList(i, 1), contactsList(i, 2), contactsList(i, 3))
        Next
        'MsgBox(contactsList(5, 0) & " " & contactsList(0, 1) & " " & contactsList(0, 2) & " " & contactsList(0, 3))
    End Sub

    Private Sub tabContacts_Click(sender As Object, e As EventArgs) Handles tabContacts.Click

    End Sub
End Class