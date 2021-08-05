Imports System.IO
Public Class CustomForm
    Private Sub CustomForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = String.Empty
        Me.ControlBox = False
    End Sub

    ' Button for Close Customize form
    Private Sub CloseCustomBtn_Click(sender As Object, e As EventArgs) Handles CloseCustomBtn.Click
        Me.Hide()
    End Sub


    ' Change Form Detail
    Private Sub RomajiRadio_CheckedChanged(sender As Object, e As EventArgs) Handles RomajiRadio.CheckedChanged
        Form1.ShowHiddenBtn.Text = "Show Japanese"
        Form1.AlphabetBox1.Text = "Romaji Alphabet"
        Form1.AlphabetBox2.Text = "Japanese Alphabet"
    End Sub
    Private Sub JapaneseRadio_CheckedChanged(sender As Object, e As EventArgs) Handles JapaneseRadio.CheckedChanged
        Form1.ShowHiddenBtn.Text = "Show Romaji"
        Form1.AlphabetBox1.Text = "Japanese Alphabet"
        Form1.AlphabetBox2.Text = "Romaji Alphabet"
    End Sub


    ' Go to developer
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked

        If File.Exists("C:\Program Files\Google\Chrome\Application\chrome.exe") Then

            Process.Start("C:\Program Files\Google\Chrome\Application\chrome.exe", "https://github.com/RAGNAGUS")

        ElseIf File.Exists("C:\Program Files (x86)\Microsoft\Edge\Application\msedge.exe") Then

            Process.Start("C:\Program Files (x86)\Microsoft\Edge\Application\msedge.exe", "https://github.com/RAGNAGUS")

        Else

        End If

    End Sub


    ' Selection Function
    Private Sub HGALL_CheckedChanged(sender As Object, e As EventArgs) Handles HGALL.CheckedChanged

        If HGALL.Checked = True Then
            HG1.Checked = True
            HG2.Checked = True
            HG3.Checked = True
            HG4.Checked = True
            HG5.Checked = True
            HG6.Checked = True
            HG7.Checked = True
            HG8.Checked = True
            HG9.Checked = True
            HG10.Checked = True
        Else
            HG1.Checked = False
            HG2.Checked = False
            HG3.Checked = False
            HG4.Checked = False
            HG5.Checked = False
            HG6.Checked = False
            HG7.Checked = False
            HG8.Checked = False
            HG9.Checked = False
            HG10.Checked = False
        End If

    End Sub
    Private Sub HGDALL_CheckedChanged(sender As Object, e As EventArgs) Handles HGDALL.CheckedChanged
        If HGDALL.Checked = True Then
            HGD1.Checked = True
            HGD2.Checked = True
            HGD3.Checked = True
            HGD4.Checked = True
            HGD5.Checked = True
        Else
            HGD1.Checked = False
            HGD2.Checked = False
            HGD3.Checked = False
            HGD4.Checked = False
            HGD5.Checked = False
        End If
    End Sub
    Private Sub HYALL_CheckedChanged(sender As Object, e As EventArgs) Handles HYALL.CheckedChanged
        If HYALL.Checked = True Then
            HY1.Checked = True
            HY2.Checked = True
            HY3.Checked = True
            HY4.Checked = True
            HY5.Checked = True
            HY6.Checked = True
        Else
            HY1.Checked = False
            HY2.Checked = False
            HY3.Checked = False
            HY4.Checked = False
            HY5.Checked = False
            HY6.Checked = False
        End If
    End Sub
    Private Sub HYDALL_CheckedChanged(sender As Object, e As EventArgs) Handles HYDALL.CheckedChanged
        If HYDALL.Checked = True Then
            HYD1.Checked = True
            HYD2.Checked = True
            HYD3.Checked = True
            HYD4.Checked = True
            HYD5.Checked = True
        Else
            HYD1.Checked = False
            HYD2.Checked = False
            HYD3.Checked = False
            HYD4.Checked = False
            HYD5.Checked = False
        End If
    End Sub
    Private Sub KGALL_CheckedChanged(sender As Object, e As EventArgs) Handles KGALL.CheckedChanged
        If KGALL.Checked = True Then
            KG1.Checked = True
            KG2.Checked = True
            KG3.Checked = True
            KG4.Checked = True
            KG5.Checked = True
            KG6.Checked = True
            KG7.Checked = True
            KG8.Checked = True
            KG9.Checked = True
            KG10.Checked = True
        Else
            KG1.Checked = False
            KG2.Checked = False
            KG3.Checked = False
            KG4.Checked = False
            KG5.Checked = False
            KG6.Checked = False
            KG7.Checked = False
            KG8.Checked = False
            KG9.Checked = False
            KG10.Checked = False
        End If
    End Sub
    Private Sub KGDALL_CheckedChanged(sender As Object, e As EventArgs) Handles KGDALL.CheckedChanged
        If KGDALL.Checked = True Then
            KGD1.Checked = True
            KGD2.Checked = True
            KGD3.Checked = True
            KGD4.Checked = True
            KGD5.Checked = True
        Else
            KGD1.Checked = False
            KGD2.Checked = False
            KGD3.Checked = False
            KGD4.Checked = False
            KGD5.Checked = False
        End If
    End Sub
    Private Sub KYALL_CheckedChanged(sender As Object, e As EventArgs) Handles KYALL.CheckedChanged
        If KYALL.Checked = True Then
            KY1.Checked = True
            KY2.Checked = True
            KY3.Checked = True
            KY4.Checked = True
            KY5.Checked = True
            KY6.Checked = True
        Else
            KY1.Checked = False
            KY2.Checked = False
            KY3.Checked = False
            KY4.Checked = False
            KY5.Checked = False
            KY6.Checked = False
        End If
    End Sub
    Private Sub KYDALL_CheckedChanged(sender As Object, e As EventArgs) Handles KYDALL.CheckedChanged
        If KYDALL.Checked = True Then
            KYD1.Checked = True
            KYD2.Checked = True
            KYD3.Checked = True
            KYD4.Checked = True
            KYD5.Checked = True
        Else
            KYD1.Checked = False
            KYD2.Checked = False
            KYD3.Checked = False
            KYD4.Checked = False
            KYD5.Checked = False
        End If
    End Sub
    Private Sub KLALL_CheckedChanged(sender As Object, e As EventArgs) Handles KLALL.CheckedChanged
        If KLALL.Checked = True Then
            KL1.Checked = True
            KL2.Checked = True
        Else
            KL1.Checked = False
            KL2.Checked = False
        End If
    End Sub
    Private Sub HG1_CheckedChanged(sender As Object, e As EventArgs) Handles HG1.CheckedChanged
        If HG1.Checked = True Then
            Kana1.Checked = True
            Kana2.Checked = True
            Kana3.Checked = True
            Kana4.Checked = True
            Kana5.Checked = True
        Else
            Kana1.Checked = False
            Kana2.Checked = False
            Kana3.Checked = False
            Kana4.Checked = False
            Kana5.Checked = False
        End If
    End Sub
    Private Sub HG2_CheckedChanged(sender As Object, e As EventArgs) Handles HG2.CheckedChanged
        If HG2.Checked = True Then
            Kana6.Checked = True
            Kana7.Checked = True
            Kana8.Checked = True
            Kana9.Checked = True
            Kana10.Checked = True
        Else
            Kana6.Checked = False
            Kana7.Checked = False
            Kana8.Checked = False
            Kana9.Checked = False
            Kana10.Checked = False
        End If
    End Sub
    Private Sub HG3_CheckedChanged(sender As Object, e As EventArgs) Handles HG3.CheckedChanged
        If HG3.Checked = True Then
            Kana11.Checked = True
            Kana12.Checked = True
            Kana13.Checked = True
            Kana14.Checked = True
            Kana15.Checked = True
        Else
            Kana11.Checked = False
            Kana12.Checked = False
            Kana13.Checked = False
            Kana14.Checked = False
            Kana15.Checked = False
        End If
    End Sub
    Private Sub HG4_CheckedChanged(sender As Object, e As EventArgs) Handles HG4.CheckedChanged
        If HG4.Checked = True Then
            Kana16.Checked = True
            Kana17.Checked = True
            Kana18.Checked = True
            Kana19.Checked = True
            Kana20.Checked = True
        Else
            Kana16.Checked = False
            Kana17.Checked = False
            Kana18.Checked = False
            Kana19.Checked = False
            Kana20.Checked = False
        End If
    End Sub
    Private Sub HG5_CheckedChanged(sender As Object, e As EventArgs) Handles HG5.CheckedChanged
        If HG5.Checked = True Then
            Kana21.Checked = True
            Kana22.Checked = True
            Kana23.Checked = True
            Kana24.Checked = True
            Kana25.Checked = True
        Else
            Kana21.Checked = False
            Kana22.Checked = False
            Kana23.Checked = False
            Kana24.Checked = False
            Kana25.Checked = False
        End If
    End Sub
    Private Sub HG6_CheckedChanged(sender As Object, e As EventArgs) Handles HG6.CheckedChanged
        If HG6.Checked = True Then
            Kana26.Checked = True
            Kana27.Checked = True
            Kana28.Checked = True
            Kana29.Checked = True
            Kana30.Checked = True
        Else
            Kana26.Checked = False
            Kana27.Checked = False
            Kana28.Checked = False
            Kana29.Checked = False
            Kana30.Checked = False
        End If
    End Sub
    Private Sub HG7_CheckedChanged(sender As Object, e As EventArgs) Handles HG7.CheckedChanged
        If HG7.Checked = True Then
            Kana31.Checked = True
            Kana32.Checked = True
            Kana33.Checked = True
            Kana34.Checked = True
            Kana35.Checked = True
        Else
            Kana31.Checked = False
            Kana32.Checked = False
            Kana33.Checked = False
            Kana34.Checked = False
            Kana35.Checked = False
        End If
    End Sub
    Private Sub HG8_CheckedChanged(sender As Object, e As EventArgs) Handles HG8.CheckedChanged
        If HG8.Checked = True Then
            Kana36.Checked = True
            Kana37.Checked = True
            Kana38.Checked = True
        Else
            Kana36.Checked = False
            Kana37.Checked = False
            Kana38.Checked = False
        End If
    End Sub
    Private Sub HG9_CheckedChanged(sender As Object, e As EventArgs) Handles HG9.CheckedChanged
        If HG9.Checked = True Then
            Kana39.Checked = True
            Kana40.Checked = True
            Kana41.Checked = True
            Kana42.Checked = True
            Kana43.Checked = True
        Else
            Kana39.Checked = False
            Kana40.Checked = False
            Kana41.Checked = False
            Kana42.Checked = False
            Kana43.Checked = False
        End If
    End Sub
    Private Sub HG10_CheckedChanged(sender As Object, e As EventArgs) Handles HG10.CheckedChanged
        If HG10.Checked = True Then
            Kana44.Checked = True
            Kana45.Checked = True
            Kana46.Checked = True
        Else
            Kana44.Checked = False
            Kana45.Checked = False
            Kana46.Checked = False
        End If
    End Sub
    Private Sub HGD1_CheckedChanged(sender As Object, e As EventArgs) Handles HGD1.CheckedChanged
        If HGD1.Checked = True Then
            Kana47.Checked = True
            Kana48.Checked = True
            Kana49.Checked = True
            Kana50.Checked = True
            Kana51.Checked = True
        Else
            Kana47.Checked = False
            Kana48.Checked = False
            Kana49.Checked = False
            Kana50.Checked = False
            Kana51.Checked = False
        End If
    End Sub
    Private Sub HGD2_CheckedChanged(sender As Object, e As EventArgs) Handles HGD2.CheckedChanged
        If HGD2.Checked = True Then
            Kana52.Checked = True
            Kana53.Checked = True
            Kana54.Checked = True
            Kana55.Checked = True
            Kana56.Checked = True
        Else
            Kana52.Checked = False
            Kana53.Checked = False
            Kana54.Checked = False
            Kana55.Checked = False
            Kana56.Checked = False
        End If
    End Sub
    Private Sub HGD3_CheckedChanged(sender As Object, e As EventArgs) Handles HGD3.CheckedChanged
        If HGD3.Checked = True Then
            Kana57.Checked = True
            Kana58.Checked = True
            Kana59.Checked = True
            Kana60.Checked = True
            Kana61.Checked = True
        Else
            Kana57.Checked = False
            Kana58.Checked = False
            Kana59.Checked = False
            Kana60.Checked = False
            Kana61.Checked = False
        End If
    End Sub
    Private Sub HGD4_CheckedChanged(sender As Object, e As EventArgs) Handles HGD4.CheckedChanged
        If HGD4.Checked = True Then
            Kana62.Checked = True
            Kana63.Checked = True
            Kana64.Checked = True
            Kana65.Checked = True
            Kana66.Checked = True
        Else
            Kana62.Checked = False
            Kana63.Checked = False
            Kana64.Checked = False
            Kana65.Checked = False
            Kana66.Checked = False
        End If
    End Sub
    Private Sub HGD5_CheckedChanged(sender As Object, e As EventArgs) Handles HGD5.CheckedChanged
        If HGD5.Checked = True Then
            Kana67.Checked = True
            Kana68.Checked = True
            Kana69.Checked = True
            Kana70.Checked = True
            Kana71.Checked = True
        Else
            Kana67.Checked = False
            Kana68.Checked = False
            Kana69.Checked = False
            Kana70.Checked = False
            Kana71.Checked = False
        End If
    End Sub
    Private Sub HY1_CheckedChanged(sender As Object, e As EventArgs) Handles HY1.CheckedChanged
        If HY1.Checked = True Then
            Kana72.Checked = True
            Kana73.Checked = True
            Kana74.Checked = True
        Else
            Kana72.Checked = False
            Kana73.Checked = False
            Kana74.Checked = False
        End If
    End Sub
    Private Sub HY2_CheckedChanged(sender As Object, e As EventArgs) Handles HY2.CheckedChanged
        If HY2.Checked = True Then
            Kana75.Checked = True
            Kana76.Checked = True
            Kana77.Checked = True
        Else
            Kana75.Checked = False
            Kana76.Checked = False
            Kana77.Checked = False
        End If
    End Sub
    Private Sub HY3_CheckedChanged(sender As Object, e As EventArgs) Handles HY3.CheckedChanged
        If HY3.Checked = True Then
            Kana78.Checked = True
            Kana79.Checked = True
            Kana80.Checked = True
        Else
            Kana78.Checked = False
            Kana79.Checked = False
            Kana80.Checked = False
        End If
    End Sub
    Private Sub HY4_CheckedChanged(sender As Object, e As EventArgs) Handles HY4.CheckedChanged
        If HY4.Checked = True Then
            Kana81.Checked = True
            Kana82.Checked = True
            Kana83.Checked = True
        Else
            Kana81.Checked = False
            Kana82.Checked = False
            Kana83.Checked = False
        End If
    End Sub
    Private Sub HY5_CheckedChanged(sender As Object, e As EventArgs) Handles HY5.CheckedChanged
        If HY5.Checked = True Then
            Kana84.Checked = True
            Kana85.Checked = True
            Kana86.Checked = True
        Else
            Kana84.Checked = False
            Kana85.Checked = False
            Kana86.Checked = False
        End If
    End Sub
    Private Sub HY6_CheckedChanged(sender As Object, e As EventArgs) Handles HY6.CheckedChanged
        If HY6.Checked = True Then
            Kana87.Checked = True
            Kana88.Checked = True
            Kana89.Checked = True
        Else
            Kana87.Checked = False
            Kana88.Checked = False
            Kana89.Checked = False
        End If
    End Sub
    Private Sub HYD1_CheckedChanged(sender As Object, e As EventArgs) Handles HYD1.CheckedChanged
        If HYD1.Checked = True Then
            Kana90.Checked = True
            Kana91.Checked = True
            Kana92.Checked = True
        Else
            Kana90.Checked = False
            Kana91.Checked = False
            Kana92.Checked = False
        End If
    End Sub
    Private Sub HYD2_CheckedChanged(sender As Object, e As EventArgs) Handles HYD2.CheckedChanged
        If HYD2.Checked = True Then
            Kana93.Checked = True
            Kana94.Checked = True
            Kana95.Checked = True
        Else
            Kana93.Checked = False
            Kana94.Checked = False
            Kana95.Checked = False
        End If
    End Sub
    Private Sub HYD3_CheckedChanged(sender As Object, e As EventArgs) Handles HYD3.CheckedChanged
        If HYD3.Checked = True Then
            Kana96.Checked = True
            Kana97.Checked = True
            Kana98.Checked = True
        Else
            Kana96.Checked = False
            Kana97.Checked = False
            Kana98.Checked = False
        End If
    End Sub
    Private Sub HYD4_CheckedChanged(sender As Object, e As EventArgs) Handles HYD4.CheckedChanged
        If HYD4.Checked = True Then
            Kana99.Checked = True
            Kana100.Checked = True
            Kana101.Checked = True
        Else
            Kana99.Checked = False
            Kana100.Checked = False
            Kana101.Checked = False
        End If
    End Sub
    Private Sub HYD5_CheckedChanged(sender As Object, e As EventArgs) Handles HYD5.CheckedChanged
        If HYD5.Checked = True Then
            Kana102.Checked = True
            Kana103.Checked = True
            Kana104.Checked = True
        Else
            Kana102.Checked = False
            Kana103.Checked = False
            Kana104.Checked = False
        End If
    End Sub
    Private Sub KG1_CheckedChanged(sender As Object, e As EventArgs) Handles KG1.CheckedChanged
        If KG1.Checked = True Then
            Kana105.Checked = True
            Kana106.Checked = True
            Kana107.Checked = True
            Kana108.Checked = True
            Kana109.Checked = True
        Else
            Kana105.Checked = False
            Kana106.Checked = False
            Kana107.Checked = False
            Kana108.Checked = False
            Kana109.Checked = False
        End If
    End Sub
    Private Sub KG2_CheckedChanged(sender As Object, e As EventArgs) Handles KG2.CheckedChanged
        If KG2.Checked = True Then
            Kana110.Checked = True
            Kana111.Checked = True
            Kana112.Checked = True
            Kana113.Checked = True
            Kana114.Checked = True
        Else
            Kana110.Checked = False
            Kana111.Checked = False
            Kana112.Checked = False
            Kana113.Checked = False
            Kana114.Checked = False
        End If
    End Sub
    Private Sub KG3_CheckedChanged(sender As Object, e As EventArgs) Handles KG3.CheckedChanged
        If KG3.Checked = True Then
            Kana115.Checked = True
            Kana116.Checked = True
            Kana117.Checked = True
            Kana118.Checked = True
            Kana119.Checked = True
        Else
            Kana115.Checked = False
            Kana116.Checked = False
            Kana117.Checked = False
            Kana118.Checked = False
            Kana119.Checked = False
        End If
    End Sub
    Private Sub KG4_CheckedChanged(sender As Object, e As EventArgs) Handles KG4.CheckedChanged
        If KG4.Checked = True Then
            Kana120.Checked = True
            Kana121.Checked = True
            Kana122.Checked = True
            Kana123.Checked = True
            Kana124.Checked = True
        Else
            Kana120.Checked = False
            Kana121.Checked = False
            Kana122.Checked = False
            Kana123.Checked = False
            Kana124.Checked = False
        End If
    End Sub
    Private Sub KG5_CheckedChanged(sender As Object, e As EventArgs) Handles KG5.CheckedChanged
        If KG5.Checked = True Then
            Kana125.Checked = True
            Kana126.Checked = True
            Kana127.Checked = True
            Kana128.Checked = True
            Kana129.Checked = True
        Else
            Kana125.Checked = False
            Kana126.Checked = False
            Kana127.Checked = False
            Kana128.Checked = False
            Kana129.Checked = False
        End If
    End Sub
    Private Sub KG6_CheckedChanged(sender As Object, e As EventArgs) Handles KG6.CheckedChanged
        If KG6.Checked = True Then
            Kana130.Checked = True
            Kana131.Checked = True
            Kana132.Checked = True
            Kana133.Checked = True
            Kana134.Checked = True
        Else
            Kana130.Checked = False
            Kana131.Checked = False
            Kana132.Checked = False
            Kana133.Checked = False
            Kana134.Checked = False
        End If
    End Sub
    Private Sub KG7_CheckedChanged(sender As Object, e As EventArgs) Handles KG7.CheckedChanged
        If KG7.Checked = True Then
            Kana135.Checked = True
            Kana136.Checked = True
            Kana137.Checked = True
            Kana138.Checked = True
            Kana139.Checked = True
        Else
            Kana135.Checked = False
            Kana136.Checked = False
            Kana137.Checked = False
            Kana138.Checked = False
            Kana139.Checked = False
        End If
    End Sub
    Private Sub KG8_CheckedChanged(sender As Object, e As EventArgs) Handles KG8.CheckedChanged
        If KG8.Checked = True Then
            Kana140.Checked = True
            Kana141.Checked = True
            Kana142.Checked = True
        Else
            Kana140.Checked = False
            Kana141.Checked = False
            Kana142.Checked = False
        End If
    End Sub
    Private Sub KG9_CheckedChanged(sender As Object, e As EventArgs) Handles KG9.CheckedChanged
        If KG9.Checked = True Then
            Kana143.Checked = True
            Kana144.Checked = True
            Kana145.Checked = True
            Kana146.Checked = True
            Kana147.Checked = True
        Else
            Kana143.Checked = False
            Kana144.Checked = False
            Kana145.Checked = False
            Kana146.Checked = False
            Kana147.Checked = False
        End If
    End Sub
    Private Sub KG10_CheckedChanged(sender As Object, e As EventArgs) Handles KG10.CheckedChanged
        If KG10.Checked = True Then
            Kana148.Checked = True
            Kana149.Checked = True
            Kana150.Checked = True
        Else
            Kana148.Checked = False
            Kana149.Checked = False
            Kana150.Checked = False
        End If
    End Sub
    Private Sub KGD1_CheckedChanged(sender As Object, e As EventArgs) Handles KGD1.CheckedChanged
        If KGD1.Checked = True Then
            Kana151.Checked = True
            Kana152.Checked = True
            Kana153.Checked = True
            Kana154.Checked = True
            Kana155.Checked = True
        Else
            Kana151.Checked = False
            Kana152.Checked = False
            Kana153.Checked = False
            Kana154.Checked = False
            Kana155.Checked = False
        End If
    End Sub
    Private Sub KGD2_CheckedChanged(sender As Object, e As EventArgs) Handles KGD2.CheckedChanged
        If KGD2.Checked = True Then
            Kana156.Checked = True
            Kana157.Checked = True
            Kana158.Checked = True
            Kana159.Checked = True
            Kana160.Checked = True
        Else
            Kana156.Checked = False
            Kana157.Checked = False
            Kana158.Checked = False
            Kana159.Checked = False
            Kana160.Checked = False
        End If
    End Sub
    Private Sub KGD3_CheckedChanged(sender As Object, e As EventArgs) Handles KGD3.CheckedChanged
        If KGD3.Checked = True Then
            Kana161.Checked = True
            Kana162.Checked = True
            Kana163.Checked = True
            Kana164.Checked = True
            Kana165.Checked = True
        Else
            Kana161.Checked = False
            Kana162.Checked = False
            Kana163.Checked = False
            Kana164.Checked = False
            Kana165.Checked = False
        End If
    End Sub
    Private Sub KGD4_CheckedChanged(sender As Object, e As EventArgs) Handles KGD4.CheckedChanged
        If KGD4.Checked = True Then
            Kana166.Checked = True
            Kana167.Checked = True
            Kana168.Checked = True
            Kana169.Checked = True
            Kana170.Checked = True
        Else
            Kana166.Checked = False
            Kana167.Checked = False
            Kana168.Checked = False
            Kana169.Checked = False
            Kana170.Checked = False
        End If
    End Sub
    Private Sub KGD5_CheckedChanged(sender As Object, e As EventArgs) Handles KGD5.CheckedChanged
        If KGD5.Checked = True Then
            Kana171.Checked = True
            Kana172.Checked = True
            Kana173.Checked = True
            Kana174.Checked = True
            Kana175.Checked = True
        Else
            Kana171.Checked = False
            Kana172.Checked = False
            Kana173.Checked = False
            Kana174.Checked = False
            Kana175.Checked = False
        End If
    End Sub
    Private Sub KY1_CheckedChanged(sender As Object, e As EventArgs) Handles KY1.CheckedChanged
        If KY1.Checked = True Then
            Kana176.Checked = True
            Kana177.Checked = True
            Kana178.Checked = True
        Else
            Kana176.Checked = False
            Kana177.Checked = False
            Kana178.Checked = False
        End If
    End Sub
    Private Sub KY2_CheckedChanged(sender As Object, e As EventArgs) Handles KY2.CheckedChanged
        If KY2.Checked = True Then
            Kana179.Checked = True
            Kana180.Checked = True
            Kana181.Checked = True
        Else
            Kana179.Checked = False
            Kana180.Checked = False
            Kana181.Checked = False
        End If
    End Sub
    Private Sub KY3_CheckedChanged(sender As Object, e As EventArgs) Handles KY3.CheckedChanged
        If KY3.Checked = True Then
            Kana182.Checked = True
            Kana183.Checked = True
            Kana184.Checked = True
        Else
            Kana182.Checked = False
            Kana183.Checked = False
            Kana184.Checked = False
        End If
    End Sub
    Private Sub KY4_CheckedChanged(sender As Object, e As EventArgs) Handles KY4.CheckedChanged
        If KY4.Checked = True Then
            Kana185.Checked = True
            Kana186.Checked = True
            Kana187.Checked = True
        Else
            Kana185.Checked = False
            Kana186.Checked = False
            Kana187.Checked = False
        End If
    End Sub
    Private Sub KY5_CheckedChanged(sender As Object, e As EventArgs) Handles KY5.CheckedChanged
        If KY5.Checked = True Then
            Kana188.Checked = True
            Kana189.Checked = True
            Kana190.Checked = True
        Else
            Kana188.Checked = False
            Kana189.Checked = False
            Kana190.Checked = False
        End If
    End Sub
    Private Sub KY6_CheckedChanged(sender As Object, e As EventArgs) Handles KY6.CheckedChanged
        If KY6.Checked = True Then
            Kana191.Checked = True
            Kana192.Checked = True
            Kana193.Checked = True
        Else
            Kana191.Checked = False
            Kana192.Checked = False
            Kana193.Checked = False
        End If
    End Sub
    Private Sub KYD1_CheckedChanged(sender As Object, e As EventArgs) Handles KYD1.CheckedChanged
        If KYD1.Checked = True Then
            Kana194.Checked = True
            Kana195.Checked = True
            Kana196.Checked = True
        Else
            Kana194.Checked = False
            Kana195.Checked = False
            Kana196.Checked = False
        End If
    End Sub
    Private Sub KYD2_CheckedChanged(sender As Object, e As EventArgs) Handles KYD2.CheckedChanged
        If KYD2.Checked = True Then
            Kana197.Checked = True
            Kana198.Checked = True
            Kana199.Checked = True
        Else
            Kana197.Checked = False
            Kana198.Checked = False
            Kana199.Checked = False
        End If
    End Sub
    Private Sub KYD3_CheckedChanged(sender As Object, e As EventArgs) Handles KYD3.CheckedChanged
        If KYD3.Checked = True Then
            Kana200.Checked = True
            Kana201.Checked = True
            Kana202.Checked = True
        Else
            Kana200.Checked = False
            Kana201.Checked = False
            Kana202.Checked = False
        End If
    End Sub
    Private Sub KYD4_CheckedChanged(sender As Object, e As EventArgs) Handles KYD4.CheckedChanged
        If KYD4.Checked = True Then
            Kana203.Checked = True
            Kana204.Checked = True
            Kana205.Checked = True
        Else
            Kana203.Checked = False
            Kana204.Checked = False
            Kana205.Checked = False
        End If
    End Sub
    Private Sub KYD5_CheckedChanged(sender As Object, e As EventArgs) Handles KYD5.CheckedChanged
        If KYD5.Checked = True Then
            Kana206.Checked = True
            Kana207.Checked = True
            Kana208.Checked = True
        Else
            Kana206.Checked = False
            Kana207.Checked = False
            Kana208.Checked = False
        End If
    End Sub
    Private Sub KL1_CheckedChanged(sender As Object, e As EventArgs) Handles KL1.CheckedChanged
        If KL1.Checked = True Then
            Kana209.Checked = True
            Kana210.Checked = True
            Kana211.Checked = True
            Kana212.Checked = True
            Kana213.Checked = True
        Else
            Kana209.Checked = False
            Kana210.Checked = False
            Kana211.Checked = False
            Kana212.Checked = False
            Kana213.Checked = False
        End If
    End Sub
    Private Sub KL2_CheckedChanged(sender As Object, e As EventArgs) Handles KL2.CheckedChanged
        If KL2.Checked = True Then
            Kana214.Checked = True
            Kana215.Checked = True
            Kana216.Checked = True
            Kana217.Checked = True
            Kana218.Checked = True
            Kana219.Checked = True
            Kana220.Checked = True
        Else
            Kana214.Checked = False
            Kana215.Checked = False
            Kana216.Checked = False
            Kana217.Checked = False
            Kana218.Checked = False
            Kana219.Checked = False
            Kana220.Checked = False
        End If
    End Sub

End Class