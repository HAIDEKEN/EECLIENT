
Imports System.Data.SqlClient

Module Connection
    Dim pcname As String = System.Windows.Forms.SystemInformation.ComputerName


    Public conS As New SqlConnection("server =" & pcname & "\SQLEXPRESS; database=SJCEXAMINATIONDB; user=sa; password=@dm1nMIS")

    Public Sub connectionToDB()
        Try
            conS.Open()
            MsgBox("Connected")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Module
