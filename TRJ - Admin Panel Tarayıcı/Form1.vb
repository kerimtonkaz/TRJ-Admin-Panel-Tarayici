Imports System.IO
Imports System.Net

Public Class Form1

    Dim durum As Boolean = False
    Dim yakala As String
    Dim tarananlar As Integer = 0
    Dim bulunanlar As Integer = 0

    Private Sub btnKapat_Click(sender As Object, e As EventArgs) Handles btnKapat.Click
        Application.Exit()
    End Sub

    Private Sub btnPanelUrlEkle_Click(sender As Object, e As EventArgs) Handles btnPanelUrlEkle.Click
        If btnTara.Text = "               Bitir" Then
            MsgBox("Mevcut tarama bitmeden panel url ekleyemezsiniz!", MsgBoxStyle.Critical)
        Else
            Dim dosya_yolu As String
            lbPanelUrl.Items.Clear()
            ofdDosya.FileName = ""
            ofdDosya.Filter = "Txt Dosyası|*.txt"
            ofdDosya.ShowDialog()
            dosya_yolu = ofdDosya.FileName
            TextBox1.Text = FileIO.FileSystem.ReadAllText(dosya_yolu)
            lbPanelUrl.Items.AddRange(TextBox1.Lines)
            lblToplamPanelUrl.Text = Convert.ToString(lbPanelUrl.Items.Count)
        End If
    End Sub

    Private Sub btnTara_Click(sender As Object, e As EventArgs) Handles btnTara.Click
        Dim say As Integer = 0

        If btnTara.Text = "               Bitir" Then
            tmrTara.Stop()
            btnTara.Text = "               Tara"
            btnTara.Normalcolor = Color.FromArgb(46, 139, 87)
            btnTara.OnHovercolor = Color.FromArgb(46, 139, 87)
            TextBox2.Text = ""
        Else
            If Convert.ToInt32(lblToplamPanelUrl.Text) > 0 And tbUrl.text.Length > 9 Then

                tarananlar = 0
                bulunanlar = 0
                lblRobots.ForeColor = Color.FromArgb(178, 216, 255)
                lblRobots.Text = "Kontrol Ediliyor.."
                lbBulunan.Items.Clear()
                ListBox1.Items.Clear()
                TextBox2.Text = ""

                For i = 0 To tbUrl.text.Length - 1
                    If tbUrl.text.Chars(i) = "/" Then
                        say += 1
                    End If
                Next

                If (say = 3) Then
                    tbUrl.text = tbUrl.text.Substring(0, tbUrl.text.Length - 1)
                End If

                lbPanelUrl.SelectedIndex = 0
                btnTara.Text = "               Bitir"
                btnTara.Normalcolor = Color.Maroon
                btnTara.OnHovercolor = Color.Maroon
                wbUrl.Navigate(tbUrl.text & "/robots.txt")
            Else
                MsgBox("Site url veya Panel Url eklenmemiş!", MsgBoxStyle.Critical)
            End If
        End If
    End Sub

    Private Sub tmrTara_Tick(sender As Object, e As EventArgs) Handles tmrTara.Tick
        On Error Resume Next
        yakala = YakalaBrooo(tbUrl.text & "/" & lbPanelUrl.SelectedItem.ToString)
        tarananlar += 1
        If yakala <> "" Then
            bulunanlar += 1
            lbBulunan.Items.Add("Bulundu: " & tbUrl.text & "/" & lbPanelUrl.SelectedItem.ToString)
        End If
        If lbPanelUrl.Items.Count <> tarananlar Then
            lbPanelUrl.SelectedIndex = lbPanelUrl.SelectedIndex + 1
        Else
            btnTara.Text = "               Tara"
            btnTara.Normalcolor = Color.FromArgb(46, 139, 87)
            btnTara.OnHovercolor = Color.FromArgb(46, 139, 87)
            TextBox2.Text = ""
            tmrTara.Stop()
        End If
        lbBulunan.SelectedIndex = lbBulunan.Items.Count - 1
        lblTarananlar.Text = Convert.ToString(tarananlar)
        lblBulunanlar.Text = Convert.ToString(bulunanlar)
    End Sub

    Public Function YakalaBrooo(ByVal url As String) As String
        Dim objRequest As WebRequest = System.Net.HttpWebRequest.Create(url)
        objRequest.Timeout = 1000 * 30
        objRequest.Method = "GET"
        objRequest.PreAuthenticate = True
        objRequest.Credentials = CredentialCache.DefaultCredentials
        objRequest.Headers.Add("Name", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/63.0.3239.84 Safari/537.36")
        objRequest.ContentType = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8"

        On Error Resume Next
        Dim sr As New StreamReader(objRequest.GetResponse().GetResponseStream())
        Dim result As String = sr.ReadToEnd()
        sr.Close()
        Return result
    End Function

    Private Sub lbBulunan_DoubleClick(sender As Object, e As EventArgs) Handles lbBulunan.DoubleClick
        Dim webAddress As String = Convert.ToString(lbBulunan.SelectedItem)
        webAddress = webAddress.Replace("Bulundu: ", "")
        webAddress = webAddress.Replace("Robots.txt: ", "")
        webAddress = webAddress.Replace("Disallow: ", "")
        Process.Start(webAddress)
    End Sub

    Private Sub wbUrl_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles wbUrl.DocumentCompleted
        If wbUrl.ReadyState = WebBrowserReadyState.Complete Then
            For Each ara As HtmlElement In wbUrl.Document.All
                TextBox2.Text = ara.InnerHtml
                If TextBox2.Text <> "" Then
                    Exit For
                End If
            Next
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        If TextBox2.Text.Length > 2 Then
            ListBox1.Items.AddRange(TextBox2.Lines)
            For i = 0 To ListBox1.Items.Count - 1
                ListBox1.SelectedIndex = i
                If ListBox1.SelectedIndex = 0 Then
                    If ListBox1.SelectedItem.ToString.Contains("404") Or ListBox1.SelectedItem.ToString.Contains("Gezinme İptal Edildi") Then
                        lblRobots.Text = "Yok"
                        lblRobots.ForeColor = Color.Red
                        Exit For
                    End If
                End If

                If ListBox1.SelectedItem.ToString.Contains("admin") Or ListBox1.SelectedItem.ToString.Contains("administrator") Or ListBox1.SelectedItem.ToString.Contains("panel") Or ListBox1.SelectedItem.ToString.Contains("login") Or ListBox1.SelectedItem.ToString.Contains("user") Or ListBox1.SelectedItem.ToString.Contains("cms") Or ListBox1.SelectedItem.ToString.Contains("client") Or ListBox1.SelectedItem.ToString.Contains("account") Or ListBox1.SelectedItem.ToString.Contains("controlpanel") Then
                    If ListBox1.SelectedItem.ToString.Contains("Disallow: /") Then
                        lbBulunan.Items.Add("Robots.txt: " & tbUrl.text & "/" & ListBox1.SelectedItem.ToString.Replace("Disallow: /", ""))
                    Else
                        lbBulunan.Items.Add("Robots.txt: " & tbUrl.text & "/" & ListBox1.SelectedItem.ToString)
                    End If
                    lblRobots.Text = "Var"
                    lblRobots.ForeColor = Color.FromArgb(46, 139, 87)
                End If
            Next

            If lblRobots.Text = "Kontrol Ediliyor.." Then
                lblRobots.Text = "Var, Panel Bulunamadı."
                lblRobots.ForeColor = Color.FromArgb(46, 139, 87)
            End If

            If lblRobots.Text = "Var" Then
                If MsgBox("Robots.txt ' de admin panel bulundu. Yinede panel url'lerini taramaya devam edilsin mi?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    tmrTara.Start()
                Else
                    ListBox1.Items.Clear()
                    btnTara.Text = "               Tara"
                    btnTara.Normalcolor = Color.FromArgb(46, 139, 87)
                    btnTara.OnHovercolor = Color.FromArgb(46, 139, 87)
                End If
            Else
                tmrTara.Start()
            End If
        End If
    End Sub

    Private Sub btnKaydet_Click(sender As Object, e As EventArgs) Handles btnKaydet.Click
        If btnTara.Text = "               Tara" Then
            If lbBulunan.Items.Count > 0 Then
                TextBox1.Text = ""
                TextBox1.Lines = lbBulunan.Items.Cast(Of String).ToArray
                FileIO.FileSystem.WriteAllText("Admin Panel URL.txt", TextBox1.Text, False)
                MsgBox("Oluşturuldu", MsgBoxStyle.Information)
            Else
                MsgBox("Herhangi bir panel bulunmamış!", MsgBoxStyle.Critical)
            End If
        Else
            MsgBox("Mevcut tarama bitmeden panel url ekleyemezsiniz!", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub pbTurkHacks_Click(sender As Object, e As EventArgs) Handles pbTurkHacks.Click
        MsgBox("Tester: TurkCoder" & vbCrLf & "Developer: RedSquirrel" & vbCrLf & "Designer: jrCoder" & vbCrLf & "www.turkhacks.com")
        Process.Start("http://www.turkhacks.com/")
    End Sub
End Class
