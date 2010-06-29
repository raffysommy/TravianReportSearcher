Imports System.IO

Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click



        'WebBrowser1.Navigate("http://s9.travian.it/berichte.php?id=0000000")
        'System.Threading.Thread.Sleep(150)
        Dim counterrepovuoto As Integer = 300  'WebBrowser1.Document.All.Count.ToString()


        Dim fine As Integer = TextBox2.Text

        Dim objStreamWriter As StreamWriter


        objStreamWriter = New System.IO.StreamWriter("C:\Report.txt")

        Dim start As Integer = TextBox1.Text


        Dim startstring As String = start

        For start = TextBox1.Text To fine





            Dim navto As String = "http://s9.travian.it/berichte.php?id=" + startstring
            System.Threading.Thread.Sleep(1000)
            TextBox3.Text = start
            WebBrowser1.Navigate(navto)

            System.Threading.Thread.Sleep(300)
            Dim counterrepo As Integer = WebBrowser1.Document.All.Count.ToString()

            If counterrepo > counterrepovuoto Then

                startstring = start + 1

                navto = "http://s9.travian.it/berichte.php?id=" + startstring
                objStreamWriter.WriteLine(navto)

            End If
            start = start + 1
        Next


        objStreamWriter.Close()
        MsgBox("Troverai il file con i risultati in c:\Report.txt :)")



    End Sub
   
  
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        WebBrowser1.Navigate("http://s9.travian.it")


    End Sub


End Class
