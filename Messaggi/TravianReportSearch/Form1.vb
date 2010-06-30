Imports System.IO


Public Class Form1
   



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim navto As String
        Dim objStreamWriter As StreamWriter

        'WebBrowser1.Navigate("http://s9.travian.it/nachrichten.php?id=0000000")
        'System.Threading.Thread.Sleep(150)
        Dim counterrepovuoto As Integer = 250  'WebBrowser1.Document.All.Count.ToString()

        objStreamWriter = New System.IO.StreamWriter("C:\Report.txt")


        Dim fine As Integer = TextBox2.Text

        'Dim objStreamWriter As StreamWriter


        'objStreamWriter = New System.IO.StreamWriter("C:\Report.txt")

        Dim start As Integer = TextBox1.Text


        Dim startstring As String = start

        While start < fine
            start = start + 1

            navto = "http://s9.travian.it/nachrichten.php?id=" + startstring
            startstring = start + 1
            TextBox3.Text = start
            WebBrowser1.Navigate(navto)

            System.Threading.Thread.Sleep(700)
            Dim counterrepo As Integer = WebBrowser1.Document.All.Count.ToString()


            MsgBox(counterrepo)

            navto = "http://s9.travian.it/nachrichten.php?id=" + startstring
            Dim navstring As String = startstring - 2

            If counterrepo > 250 Then




                objStreamWriter.WriteLine(navto+navstring)

            End If
            
            'objStreamWriter.WriteLine(navto)

            'End If

        End While


        objStreamWriter.Close()
        MsgBox("Troverai il file con i risultati in c:\Report.txt :)")




    End Sub
   
  
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        WebBrowser1.Navigate("http://s9.travian.it")


    End Sub


    Public Sub WebBrowser1_DocumentCompleted(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        
    End Sub
End Class
