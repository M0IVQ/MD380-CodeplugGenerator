Imports System.IO

Public Class frmMain
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

        codeplug.BaseStream.Seek(offset, SeekOrigin.Begin)

        callID = (codeplug.ReadByte) + (codeplug.ReadByte * 256) + (codeplug.ReadByte * 256 * 256)
        callType = codeplug.ReadByte
        callRxTone = (callType And &H20) / 32
        callType = (callType And &H03)

        For i = 1 To 16
            contactName = contactName & codeplug.ReadChar
            codeplug.ReadChar()
        Next
        MsgBox(callID & " " & callType & " " & callRxTone & " " & contactName)

    End Sub

End Class