Imports System.Data.SqlClient



Module SearchQuestionnaire
    Dim one, ccode As String

    Public Sub Search_question()

        ccode = "ite 10"

        Dim querys As String = "select * from questionnaire "
        Dim qReaders As New SqlDataAdapter(querys, conS)
        Dim dts As New DataTable
        qReaders.Fill(dts)

        one = +1

        For ctrs = 0 To dts.Rows.Count - 1
            one = dts.Rows(ctrs)("id")

            Try
                Dim query As String = "select * from questionnaire where ID='" & one & "' and CourseCode='" & ccode & "'"
                Dim qReader As New SqlDataAdapter(query, conS)
                Dim dt As New DataTable
                qReader.Fill(dt)

                For ctr = 0 To dt.Rows.Count - 1
                    Form1.Label1.Text = ctr + 1 & "." & dt.Rows(ctr)("Questions")
                    Form1.RadioButton1.Text = dt.Rows(ctr)("Answer1")
                    Form1.RadioButton2.Text = dt.Rows(ctr)("Answer2")
                    Form1.RadioButton3.Text = dt.Rows(ctr)("Answer3")
                    Form1.RadioButton4.Text = dt.Rows(ctr)("Answer4")
                Next
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Next
    End Sub
End Module
