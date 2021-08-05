Public Class Form1
    Private Sub KanaForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = " "
        Me.ControlBox = False
        CustomForm.JapaneseRadio.Checked = True
        Alphabet2.Hide()
    End Sub

    ' Button for Customize Alphabet
    Private Sub CustomBtn_Click(sender As Object, e As EventArgs) Handles CustomBtn.Click
        CustomForm.Show()
    End Sub


    ' Button for Show Hidden Alphabet
    Private Sub ShowHiddenBtn_Click(sender As Object, e As EventArgs) Handles ShowHiddenBtn.Click
        Alphabet2.Show()
    End Sub

    ' Button for Close Application
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    ' Button for Random Alphabet
    Private Sub RandomBtn_Click(sender As Object, e As EventArgs) Handles RandomBtn.Click

        Alphabet2.Hide()

        Dim JapaneseDictionarylist As New ArrayList
        Dim RomanjiDictionarylist As New ArrayList

        ' Add Alphabet to ArrayList

        If CustomForm.Kana1.Checked = True Then
            JapaneseDictionarylist.Add("あ")
            RomanjiDictionarylist.Add("a")
        End If

        If CustomForm.Kana2.Checked = True Then
            JapaneseDictionarylist.Add("い")
            RomanjiDictionarylist.Add("i")
        End If

        If CustomForm.Kana3.Checked = True Then
            JapaneseDictionarylist.Add("う")
            RomanjiDictionarylist.Add("u")
        End If

        If CustomForm.Kana4.Checked = True Then
            JapaneseDictionarylist.Add("え")
            RomanjiDictionarylist.Add("e")
        End If

        If CustomForm.Kana5.Checked = True Then
            JapaneseDictionarylist.Add("お")
            RomanjiDictionarylist.Add("o")
        End If

        If CustomForm.Kana6.Checked = True Then
            JapaneseDictionarylist.Add("か")
            RomanjiDictionarylist.Add("ka")
        End If

        If CustomForm.Kana7.Checked = True Then
            JapaneseDictionarylist.Add("き")
            RomanjiDictionarylist.Add("ki")
        End If

        If CustomForm.Kana8.Checked = True Then
            JapaneseDictionarylist.Add("く")
            RomanjiDictionarylist.Add("ku")
        End If

        If CustomForm.Kana9.Checked = True Then
            JapaneseDictionarylist.Add("け")
            RomanjiDictionarylist.Add("ke")
        End If

        If CustomForm.Kana10.Checked = True Then
            JapaneseDictionarylist.Add("こ")
            RomanjiDictionarylist.Add("ko")
        End If

        If CustomForm.Kana11.Checked = True Then
            JapaneseDictionarylist.Add("さ")
            RomanjiDictionarylist.Add("sa")
        End If

        If CustomForm.Kana12.Checked = True Then
            JapaneseDictionarylist.Add("し")
            RomanjiDictionarylist.Add("shi")
        End If

        If CustomForm.Kana13.Checked = True Then
            JapaneseDictionarylist.Add("す")
            RomanjiDictionarylist.Add("su")
        End If

        If CustomForm.Kana14.Checked = True Then
            JapaneseDictionarylist.Add("せ")
            RomanjiDictionarylist.Add("se")
        End If

        If CustomForm.Kana15.Checked = True Then
            JapaneseDictionarylist.Add("そ")
            RomanjiDictionarylist.Add("so")
        End If

        If CustomForm.Kana16.Checked = True Then
            JapaneseDictionarylist.Add("た")
            RomanjiDictionarylist.Add("ta")
        End If

        If CustomForm.Kana17.Checked = True Then
            JapaneseDictionarylist.Add("ち")
            RomanjiDictionarylist.Add("chi")
        End If

        If CustomForm.Kana18.Checked = True Then
            JapaneseDictionarylist.Add("つ")
            RomanjiDictionarylist.Add("tsu")
        End If

        If CustomForm.Kana19.Checked = True Then
            JapaneseDictionarylist.Add("て")
            RomanjiDictionarylist.Add("te")
        End If

        If CustomForm.Kana20.Checked = True Then
            JapaneseDictionarylist.Add("と")
            RomanjiDictionarylist.Add("to")
        End If

        If CustomForm.Kana21.Checked = True Then
            JapaneseDictionarylist.Add("な")
            RomanjiDictionarylist.Add("na")
        End If

        If CustomForm.Kana22.Checked = True Then
            JapaneseDictionarylist.Add("に")
            RomanjiDictionarylist.Add("ni")
        End If

        If CustomForm.Kana23.Checked = True Then
            JapaneseDictionarylist.Add("ぬ")
            RomanjiDictionarylist.Add("nu")
        End If

        If CustomForm.Kana24.Checked = True Then
            JapaneseDictionarylist.Add("ね")
            RomanjiDictionarylist.Add("ne")
        End If

        If CustomForm.Kana25.Checked = True Then
            JapaneseDictionarylist.Add("の")
            RomanjiDictionarylist.Add("no")
        End If

        If CustomForm.Kana26.Checked = True Then
            JapaneseDictionarylist.Add("は")
            RomanjiDictionarylist.Add("ha")
        End If

        If CustomForm.Kana27.Checked = True Then
            JapaneseDictionarylist.Add("ひ")
            RomanjiDictionarylist.Add("hi")
        End If

        If CustomForm.Kana28.Checked = True Then
            JapaneseDictionarylist.Add("ふ")
            RomanjiDictionarylist.Add("fu")
        End If

        If CustomForm.Kana29.Checked = True Then
            JapaneseDictionarylist.Add("へ")
            RomanjiDictionarylist.Add("he")
        End If

        If CustomForm.Kana30.Checked = True Then
            JapaneseDictionarylist.Add("ほ")
            RomanjiDictionarylist.Add("ho")
        End If

        If CustomForm.Kana31.Checked = True Then
            JapaneseDictionarylist.Add("ま")
            RomanjiDictionarylist.Add("ma")
        End If

        If CustomForm.Kana32.Checked = True Then
            JapaneseDictionarylist.Add("み")
            RomanjiDictionarylist.Add("mi")
        End If

        If CustomForm.Kana33.Checked = True Then
            JapaneseDictionarylist.Add("む")
            RomanjiDictionarylist.Add("mu")
        End If

        If CustomForm.Kana34.Checked = True Then
            JapaneseDictionarylist.Add("め")
            RomanjiDictionarylist.Add("me")
        End If

        If CustomForm.Kana35.Checked = True Then
            JapaneseDictionarylist.Add("も")
            RomanjiDictionarylist.Add("mo")
        End If

        If CustomForm.Kana36.Checked = True Then
            JapaneseDictionarylist.Add("や")
            RomanjiDictionarylist.Add("ya")
        End If

        If CustomForm.Kana37.Checked = True Then
            JapaneseDictionarylist.Add("ゆ")
            RomanjiDictionarylist.Add("yu")
        End If

        If CustomForm.Kana38.Checked = True Then
            JapaneseDictionarylist.Add("よ")
            RomanjiDictionarylist.Add("yo")
        End If

        If CustomForm.Kana39.Checked = True Then
            JapaneseDictionarylist.Add("ら")
            RomanjiDictionarylist.Add("ra")
        End If

        If CustomForm.Kana40.Checked = True Then
            JapaneseDictionarylist.Add("り")
            RomanjiDictionarylist.Add("ri")
        End If

        If CustomForm.Kana41.Checked = True Then
            JapaneseDictionarylist.Add("る")
            RomanjiDictionarylist.Add("ru")
        End If

        If CustomForm.Kana42.Checked = True Then
            JapaneseDictionarylist.Add("れ")
            RomanjiDictionarylist.Add("re")
        End If

        If CustomForm.Kana43.Checked = True Then
            JapaneseDictionarylist.Add("ろ")
            RomanjiDictionarylist.Add("ro")
        End If

        If CustomForm.Kana44.Checked = True Then
            JapaneseDictionarylist.Add("わ")
            RomanjiDictionarylist.Add("wa")
        End If

        If CustomForm.Kana45.Checked = True Then
            JapaneseDictionarylist.Add("を")
            RomanjiDictionarylist.Add("wo")
        End If

        If CustomForm.Kana46.Checked = True Then
            JapaneseDictionarylist.Add("ん")
            RomanjiDictionarylist.Add("n")
        End If

        If CustomForm.Kana47.Checked = True Then
            JapaneseDictionarylist.Add("が")
            RomanjiDictionarylist.Add("ga")
        End If

        If CustomForm.Kana48.Checked = True Then
            JapaneseDictionarylist.Add("ぎ")
            RomanjiDictionarylist.Add("gi")
        End If

        If CustomForm.Kana49.Checked = True Then
            JapaneseDictionarylist.Add("ぐ")
            RomanjiDictionarylist.Add("gu")
        End If

        If CustomForm.Kana50.Checked = True Then
            JapaneseDictionarylist.Add("げ")
            RomanjiDictionarylist.Add("ge")
        End If

        If CustomForm.Kana51.Checked = True Then
            JapaneseDictionarylist.Add("ご")
            RomanjiDictionarylist.Add("go")
        End If

        If CustomForm.Kana52.Checked = True Then
            JapaneseDictionarylist.Add("ざ")
            RomanjiDictionarylist.Add("za")
        End If

        If CustomForm.Kana53.Checked = True Then
            JapaneseDictionarylist.Add("じ")
            RomanjiDictionarylist.Add("ji")
        End If

        If CustomForm.Kana54.Checked = True Then
            JapaneseDictionarylist.Add("ず")
            RomanjiDictionarylist.Add("zu")
        End If

        If CustomForm.Kana55.Checked = True Then
            JapaneseDictionarylist.Add("ぜ")
            RomanjiDictionarylist.Add("ze")
        End If

        If CustomForm.Kana56.Checked = True Then
            JapaneseDictionarylist.Add("ぞ")
            RomanjiDictionarylist.Add("zo")
        End If

        If CustomForm.Kana57.Checked = True Then
            JapaneseDictionarylist.Add("だ")
            RomanjiDictionarylist.Add("da")
        End If

        If CustomForm.Kana58.Checked = True Then
            JapaneseDictionarylist.Add("ぢ")
            RomanjiDictionarylist.Add("ji")
        End If

        If CustomForm.Kana59.Checked = True Then
            JapaneseDictionarylist.Add("づ")
            RomanjiDictionarylist.Add("zu")
        End If

        If CustomForm.Kana60.Checked = True Then
            JapaneseDictionarylist.Add("で")
            RomanjiDictionarylist.Add("de")
        End If

        If CustomForm.Kana61.Checked = True Then
            JapaneseDictionarylist.Add("ど")
            RomanjiDictionarylist.Add("do")
        End If

        If CustomForm.Kana62.Checked = True Then
            JapaneseDictionarylist.Add("ば")
            RomanjiDictionarylist.Add("ba")
        End If

        If CustomForm.Kana63.Checked = True Then
            JapaneseDictionarylist.Add("び")
            RomanjiDictionarylist.Add("bi")
        End If

        If CustomForm.Kana64.Checked = True Then
            JapaneseDictionarylist.Add("ぶ")
            RomanjiDictionarylist.Add("bu")
        End If

        If CustomForm.Kana65.Checked = True Then
            JapaneseDictionarylist.Add("べ")
            RomanjiDictionarylist.Add("be")
        End If

        If CustomForm.Kana66.Checked = True Then
            JapaneseDictionarylist.Add("ぼ")
            RomanjiDictionarylist.Add("bo")
        End If

        If CustomForm.Kana67.Checked = True Then
            JapaneseDictionarylist.Add("ぱ")
            RomanjiDictionarylist.Add("pa")
        End If

        If CustomForm.Kana68.Checked = True Then
            JapaneseDictionarylist.Add("ぴ")
            RomanjiDictionarylist.Add("pi")
        End If

        If CustomForm.Kana69.Checked = True Then
            JapaneseDictionarylist.Add("ぷ")
            RomanjiDictionarylist.Add("pu")
        End If

        If CustomForm.Kana70.Checked = True Then
            JapaneseDictionarylist.Add("ぺ")
            RomanjiDictionarylist.Add("pe")
        End If

        If CustomForm.Kana71.Checked = True Then
            JapaneseDictionarylist.Add("ぽ")
            RomanjiDictionarylist.Add("po")
        End If

        If CustomForm.Kana72.Checked = True Then
            JapaneseDictionarylist.Add("きゃ")
            RomanjiDictionarylist.Add("kya")
        End If

        If CustomForm.Kana73.Checked = True Then
            JapaneseDictionarylist.Add("きゅ")
            RomanjiDictionarylist.Add("kyu")
        End If

        If CustomForm.Kana74.Checked = True Then
            JapaneseDictionarylist.Add("きょ")
            RomanjiDictionarylist.Add("kyo")
        End If

        If CustomForm.Kana75.Checked = True Then
            JapaneseDictionarylist.Add("しゃ")
            RomanjiDictionarylist.Add("sha")
        End If

        If CustomForm.Kana76.Checked = True Then
            JapaneseDictionarylist.Add("しゅ")
            RomanjiDictionarylist.Add("shu")
        End If

        If CustomForm.Kana77.Checked = True Then
            JapaneseDictionarylist.Add("しょ")
            RomanjiDictionarylist.Add("sho")
        End If

        If CustomForm.Kana78.Checked = True Then
            JapaneseDictionarylist.Add("ちゃ")
            RomanjiDictionarylist.Add("cha")
        End If

        If CustomForm.Kana79.Checked = True Then
            JapaneseDictionarylist.Add("ちゅ")
            RomanjiDictionarylist.Add("chu")
        End If

        If CustomForm.Kana80.Checked = True Then
            JapaneseDictionarylist.Add("ちょ")
            RomanjiDictionarylist.Add("cho")
        End If

        If CustomForm.Kana81.Checked = True Then
            JapaneseDictionarylist.Add("にゃ")
            RomanjiDictionarylist.Add("nya")
        End If

        If CustomForm.Kana82.Checked = True Then
            JapaneseDictionarylist.Add("にゅ")
            RomanjiDictionarylist.Add("nyu")
        End If

        If CustomForm.Kana83.Checked = True Then
            JapaneseDictionarylist.Add("にょ")
            RomanjiDictionarylist.Add("nyo")
        End If

        If CustomForm.Kana84.Checked = True Then
            JapaneseDictionarylist.Add("ひゃ")
            RomanjiDictionarylist.Add("hya")
        End If

        If CustomForm.Kana85.Checked = True Then
            JapaneseDictionarylist.Add("ひゅ")
            RomanjiDictionarylist.Add("hyu")
        End If

        If CustomForm.Kana86.Checked = True Then
            JapaneseDictionarylist.Add("ひょ")
            RomanjiDictionarylist.Add("hyo")
        End If

        If CustomForm.Kana87.Checked = True Then
            JapaneseDictionarylist.Add("みゃ")
            RomanjiDictionarylist.Add("mya")
        End If

        If CustomForm.Kana88.Checked = True Then
            JapaneseDictionarylist.Add("みゅ")
            RomanjiDictionarylist.Add("myu")
        End If

        If CustomForm.Kana89.Checked = True Then
            JapaneseDictionarylist.Add("みょ")
            RomanjiDictionarylist.Add("myo")
        End If

        If CustomForm.Kana90.Checked = True Then
            JapaneseDictionarylist.Add("りゃ")
            RomanjiDictionarylist.Add("rya")
        End If

        If CustomForm.Kana91.Checked = True Then
            JapaneseDictionarylist.Add("りゅ")
            RomanjiDictionarylist.Add("ryu")
        End If

        If CustomForm.Kana92.Checked = True Then
            JapaneseDictionarylist.Add("りょ")
            RomanjiDictionarylist.Add("ryo")
        End If

        If CustomForm.Kana93.Checked = True Then
            JapaneseDictionarylist.Add("ぎゃ")
            RomanjiDictionarylist.Add("gya")
        End If

        If CustomForm.Kana94.Checked = True Then
            JapaneseDictionarylist.Add("ぎゅ")
            RomanjiDictionarylist.Add("gyu")
        End If

        If CustomForm.Kana95.Checked = True Then
            JapaneseDictionarylist.Add("ぎょ")
            RomanjiDictionarylist.Add("gyo")
        End If

        If CustomForm.Kana96.Checked = True Then
            JapaneseDictionarylist.Add("じゃ")
            RomanjiDictionarylist.Add("ja")
        End If

        If CustomForm.Kana97.Checked = True Then
            JapaneseDictionarylist.Add("じゅ")
            RomanjiDictionarylist.Add("ju")
        End If

        If CustomForm.Kana98.Checked = True Then
            JapaneseDictionarylist.Add("じょ")
            RomanjiDictionarylist.Add("jo")
        End If

        If CustomForm.Kana99.Checked = True Then
            JapaneseDictionarylist.Add("びゃ")
            RomanjiDictionarylist.Add("bya")
        End If

        If CustomForm.Kana100.Checked = True Then
            JapaneseDictionarylist.Add("びゅ")
            RomanjiDictionarylist.Add("byu")
        End If

        If CustomForm.Kana101.Checked = True Then
            JapaneseDictionarylist.Add("びょ")
            RomanjiDictionarylist.Add("byo")
        End If

        If CustomForm.Kana102.Checked = True Then
            JapaneseDictionarylist.Add("ぴゃ")
            RomanjiDictionarylist.Add("pya")
        End If

        If CustomForm.Kana103.Checked = True Then
            JapaneseDictionarylist.Add("ぴゅ")
            RomanjiDictionarylist.Add("pyu")
        End If

        If CustomForm.Kana104.Checked = True Then
            JapaneseDictionarylist.Add("ぴょ")
            RomanjiDictionarylist.Add("pyo")
        End If

        If CustomForm.Kana105.Checked = True Then
            JapaneseDictionarylist.Add("ア")
            RomanjiDictionarylist.Add("a")
        End If

        If CustomForm.Kana106.Checked = True Then
            JapaneseDictionarylist.Add("イ")
            RomanjiDictionarylist.Add("i")
        End If

        If CustomForm.Kana107.Checked = True Then
            JapaneseDictionarylist.Add("ウ")
            RomanjiDictionarylist.Add("u")
        End If

        If CustomForm.Kana108.Checked = True Then
            JapaneseDictionarylist.Add("エ")
            RomanjiDictionarylist.Add("e")
        End If

        If CustomForm.Kana109.Checked = True Then
            JapaneseDictionarylist.Add("オ")
            RomanjiDictionarylist.Add("o")
        End If

        If CustomForm.Kana110.Checked = True Then
            JapaneseDictionarylist.Add("カ")
            RomanjiDictionarylist.Add("ka")
        End If

        If CustomForm.Kana111.Checked = True Then
            JapaneseDictionarylist.Add("キ")
            RomanjiDictionarylist.Add("ki")
        End If

        If CustomForm.Kana112.Checked = True Then
            JapaneseDictionarylist.Add("ク")
            RomanjiDictionarylist.Add("ku")
        End If

        If CustomForm.Kana113.Checked = True Then
            JapaneseDictionarylist.Add("ケ")
            RomanjiDictionarylist.Add("ke")
        End If

        If CustomForm.Kana114.Checked = True Then
            JapaneseDictionarylist.Add("コ")
            RomanjiDictionarylist.Add("ko")
        End If

        If CustomForm.Kana115.Checked = True Then
            JapaneseDictionarylist.Add("サ")
            RomanjiDictionarylist.Add("sa")
        End If

        If CustomForm.Kana116.Checked = True Then
            JapaneseDictionarylist.Add("シ")
            RomanjiDictionarylist.Add("shi")
        End If

        If CustomForm.Kana117.Checked = True Then
            JapaneseDictionarylist.Add("ス")
            RomanjiDictionarylist.Add("su")
        End If

        If CustomForm.Kana118.Checked = True Then
            JapaneseDictionarylist.Add("セ")
            RomanjiDictionarylist.Add("se")
        End If

        If CustomForm.Kana119.Checked = True Then
            JapaneseDictionarylist.Add("ソ")
            RomanjiDictionarylist.Add("so")
        End If

        If CustomForm.Kana120.Checked = True Then
            JapaneseDictionarylist.Add("タ")
            RomanjiDictionarylist.Add("ta")
        End If

        If CustomForm.Kana121.Checked = True Then
            JapaneseDictionarylist.Add("チ")
            RomanjiDictionarylist.Add("chi")
        End If

        If CustomForm.Kana122.Checked = True Then
            JapaneseDictionarylist.Add("ツ")
            RomanjiDictionarylist.Add("tsu")
        End If

        If CustomForm.Kana123.Checked = True Then
            JapaneseDictionarylist.Add("テ")
            RomanjiDictionarylist.Add("te")
        End If

        If CustomForm.Kana124.Checked = True Then
            JapaneseDictionarylist.Add("ト")
            RomanjiDictionarylist.Add("to")
        End If

        If CustomForm.Kana125.Checked = True Then
            JapaneseDictionarylist.Add("ナ")
            RomanjiDictionarylist.Add("na")
        End If

        If CustomForm.Kana126.Checked = True Then
            JapaneseDictionarylist.Add("ニ")
            RomanjiDictionarylist.Add("ni")
        End If

        If CustomForm.Kana127.Checked = True Then
            JapaneseDictionarylist.Add("ヌ")
            RomanjiDictionarylist.Add("nu")
        End If

        If CustomForm.Kana128.Checked = True Then
            JapaneseDictionarylist.Add("ネ")
            RomanjiDictionarylist.Add("ne")
        End If

        If CustomForm.Kana129.Checked = True Then
            JapaneseDictionarylist.Add("ノ")
            RomanjiDictionarylist.Add("no")
        End If

        If CustomForm.Kana130.Checked = True Then
            JapaneseDictionarylist.Add("ハ")
            RomanjiDictionarylist.Add("ha")
        End If

        If CustomForm.Kana131.Checked = True Then
            JapaneseDictionarylist.Add("ヒ")
            RomanjiDictionarylist.Add("hi")
        End If

        If CustomForm.Kana132.Checked = True Then
            JapaneseDictionarylist.Add("フ")
            RomanjiDictionarylist.Add("fu")
        End If

        If CustomForm.Kana133.Checked = True Then
            JapaneseDictionarylist.Add("ヘ")
            RomanjiDictionarylist.Add("he")
        End If

        If CustomForm.Kana134.Checked = True Then
            JapaneseDictionarylist.Add("ホ")
            RomanjiDictionarylist.Add("ho")
        End If

        If CustomForm.Kana135.Checked = True Then
            JapaneseDictionarylist.Add("マ")
            RomanjiDictionarylist.Add("ma")
        End If

        If CustomForm.Kana136.Checked = True Then
            JapaneseDictionarylist.Add("ミ")
            RomanjiDictionarylist.Add("mi")
        End If

        If CustomForm.Kana137.Checked = True Then
            JapaneseDictionarylist.Add("ム")
            RomanjiDictionarylist.Add("mu")
        End If

        If CustomForm.Kana138.Checked = True Then
            JapaneseDictionarylist.Add("メ")
            RomanjiDictionarylist.Add("me")
        End If

        If CustomForm.Kana139.Checked = True Then
            JapaneseDictionarylist.Add("モ")
            RomanjiDictionarylist.Add("mo")
        End If

        If CustomForm.Kana140.Checked = True Then
            JapaneseDictionarylist.Add("ヤ")
            RomanjiDictionarylist.Add("ya")
        End If

        If CustomForm.Kana141.Checked = True Then
            JapaneseDictionarylist.Add("ユ")
            RomanjiDictionarylist.Add("yu")
        End If

        If CustomForm.Kana142.Checked = True Then
            JapaneseDictionarylist.Add("ヨ")
            RomanjiDictionarylist.Add("yo")
        End If

        If CustomForm.Kana143.Checked = True Then
            JapaneseDictionarylist.Add("ラ")
            RomanjiDictionarylist.Add("ra")
        End If

        If CustomForm.Kana144.Checked = True Then
            JapaneseDictionarylist.Add("リ")
            RomanjiDictionarylist.Add("ri")
        End If

        If CustomForm.Kana145.Checked = True Then
            JapaneseDictionarylist.Add("ル")
            RomanjiDictionarylist.Add("ru")
        End If

        If CustomForm.Kana146.Checked = True Then
            JapaneseDictionarylist.Add("レ")
            RomanjiDictionarylist.Add("re")
        End If

        If CustomForm.Kana147.Checked = True Then
            JapaneseDictionarylist.Add("ロ")
            RomanjiDictionarylist.Add("ro")
        End If

        If CustomForm.Kana148.Checked = True Then
            JapaneseDictionarylist.Add("ワ")
            RomanjiDictionarylist.Add("wa")
        End If

        If CustomForm.Kana149.Checked = True Then
            JapaneseDictionarylist.Add("ヲ")
            RomanjiDictionarylist.Add("wo")
        End If

        If CustomForm.Kana150.Checked = True Then
            JapaneseDictionarylist.Add("ン")
            RomanjiDictionarylist.Add("n")
        End If

        If CustomForm.Kana151.Checked = True Then
            JapaneseDictionarylist.Add("ガ")
            RomanjiDictionarylist.Add("ga")
        End If

        If CustomForm.Kana152.Checked = True Then
            JapaneseDictionarylist.Add("ギ")
            RomanjiDictionarylist.Add("gi")
        End If

        If CustomForm.Kana153.Checked = True Then
            JapaneseDictionarylist.Add("グ")
            RomanjiDictionarylist.Add("gu")
        End If

        If CustomForm.Kana154.Checked = True Then
            JapaneseDictionarylist.Add("ゲ")
            RomanjiDictionarylist.Add("ge")
        End If

        If CustomForm.Kana155.Checked = True Then
            JapaneseDictionarylist.Add("ゴ")
            RomanjiDictionarylist.Add("go")
        End If

        If CustomForm.Kana156.Checked = True Then
            JapaneseDictionarylist.Add("ザ")
            RomanjiDictionarylist.Add("za")
        End If

        If CustomForm.Kana157.Checked = True Then
            JapaneseDictionarylist.Add("ジ")
            RomanjiDictionarylist.Add("ji")
        End If

        If CustomForm.Kana158.Checked = True Then
            JapaneseDictionarylist.Add("ズ")
            RomanjiDictionarylist.Add("zu")
        End If

        If CustomForm.Kana159.Checked = True Then
            JapaneseDictionarylist.Add("ゼ")
            RomanjiDictionarylist.Add("ze")
        End If

        If CustomForm.Kana160.Checked = True Then
            JapaneseDictionarylist.Add("ゾ")
            RomanjiDictionarylist.Add("zo")
        End If

        If CustomForm.Kana161.Checked = True Then
            JapaneseDictionarylist.Add("ダ")
            RomanjiDictionarylist.Add("da")
        End If

        If CustomForm.Kana162.Checked = True Then
            JapaneseDictionarylist.Add("ヂ")
            RomanjiDictionarylist.Add("ji")
        End If

        If CustomForm.Kana163.Checked = True Then
            JapaneseDictionarylist.Add("ヅ")
            RomanjiDictionarylist.Add("zu")
        End If

        If CustomForm.Kana164.Checked = True Then
            JapaneseDictionarylist.Add("デ")
            RomanjiDictionarylist.Add("de")
        End If

        If CustomForm.Kana165.Checked = True Then
            JapaneseDictionarylist.Add("ド")
            RomanjiDictionarylist.Add("do")
        End If

        If CustomForm.Kana166.Checked = True Then
            JapaneseDictionarylist.Add("バ")
            RomanjiDictionarylist.Add("ba")
        End If

        If CustomForm.Kana167.Checked = True Then
            JapaneseDictionarylist.Add("ビ")
            RomanjiDictionarylist.Add("bi")
        End If

        If CustomForm.Kana168.Checked = True Then
            JapaneseDictionarylist.Add("ブ")
            RomanjiDictionarylist.Add("bu")
        End If

        If CustomForm.Kana169.Checked = True Then
            JapaneseDictionarylist.Add("ベ")
            RomanjiDictionarylist.Add("be")
        End If

        If CustomForm.Kana170.Checked = True Then
            JapaneseDictionarylist.Add("ボ")
            RomanjiDictionarylist.Add("bo")
        End If

        If CustomForm.Kana171.Checked = True Then
            JapaneseDictionarylist.Add("パ")
            RomanjiDictionarylist.Add("pa")
        End If

        If CustomForm.Kana172.Checked = True Then
            JapaneseDictionarylist.Add("ピ")
            RomanjiDictionarylist.Add("pi")
        End If

        If CustomForm.Kana173.Checked = True Then
            JapaneseDictionarylist.Add("プ")
            RomanjiDictionarylist.Add("pu")
        End If

        If CustomForm.Kana174.Checked = True Then
            JapaneseDictionarylist.Add("ペ")
            RomanjiDictionarylist.Add("pe")
        End If

        If CustomForm.Kana175.Checked = True Then
            JapaneseDictionarylist.Add("ポ")
            RomanjiDictionarylist.Add("po")
        End If

        If CustomForm.Kana176.Checked = True Then
            JapaneseDictionarylist.Add("キャ")
            RomanjiDictionarylist.Add("kya")
        End If

        If CustomForm.Kana177.Checked = True Then
            JapaneseDictionarylist.Add("キュ")
            RomanjiDictionarylist.Add("kyu")
        End If

        If CustomForm.Kana178.Checked = True Then
            JapaneseDictionarylist.Add("キョ")
            RomanjiDictionarylist.Add("kyo")
        End If

        If CustomForm.Kana179.Checked = True Then
            JapaneseDictionarylist.Add("シャ")
            RomanjiDictionarylist.Add("sha")
        End If

        If CustomForm.Kana180.Checked = True Then
            JapaneseDictionarylist.Add("シュ")
            RomanjiDictionarylist.Add("shu")
        End If

        If CustomForm.Kana181.Checked = True Then
            JapaneseDictionarylist.Add("ショ")
            RomanjiDictionarylist.Add("sho")
        End If

        If CustomForm.Kana182.Checked = True Then
            JapaneseDictionarylist.Add("チャ")
            RomanjiDictionarylist.Add("cha")
        End If

        If CustomForm.Kana183.Checked = True Then
            JapaneseDictionarylist.Add("チュ")
            RomanjiDictionarylist.Add("chu")
        End If

        If CustomForm.Kana184.Checked = True Then
            JapaneseDictionarylist.Add("チョ")
            RomanjiDictionarylist.Add("cho")
        End If

        If CustomForm.Kana185.Checked = True Then
            JapaneseDictionarylist.Add("ニャ")
            RomanjiDictionarylist.Add("nya")
        End If

        If CustomForm.Kana186.Checked = True Then
            JapaneseDictionarylist.Add("ニュ")
            RomanjiDictionarylist.Add("nyu")
        End If

        If CustomForm.Kana187.Checked = True Then
            JapaneseDictionarylist.Add("ニョ")
            RomanjiDictionarylist.Add("nyo")
        End If

        If CustomForm.Kana188.Checked = True Then
            JapaneseDictionarylist.Add("ヒャ")
            RomanjiDictionarylist.Add("hya")
        End If

        If CustomForm.Kana189.Checked = True Then
            JapaneseDictionarylist.Add("ヒュ")
            RomanjiDictionarylist.Add("hyu")
        End If

        If CustomForm.Kana190.Checked = True Then
            JapaneseDictionarylist.Add("ヒョ")
            RomanjiDictionarylist.Add("hyo")
        End If

        If CustomForm.Kana191.Checked = True Then
            JapaneseDictionarylist.Add("ミャ")
            RomanjiDictionarylist.Add("mya")
        End If

        If CustomForm.Kana192.Checked = True Then
            JapaneseDictionarylist.Add("ミュ")
            RomanjiDictionarylist.Add("myu")
        End If

        If CustomForm.Kana193.Checked = True Then
            JapaneseDictionarylist.Add("ミョ")
            RomanjiDictionarylist.Add("myo")
        End If

        If CustomForm.Kana194.Checked = True Then
            JapaneseDictionarylist.Add("リャ")
            RomanjiDictionarylist.Add("rya")
        End If

        If CustomForm.Kana195.Checked = True Then
            JapaneseDictionarylist.Add("リュ")
            RomanjiDictionarylist.Add("ryu")
        End If

        If CustomForm.Kana196.Checked = True Then
            JapaneseDictionarylist.Add("リョ")
            RomanjiDictionarylist.Add("ryo")
        End If

        If CustomForm.Kana197.Checked = True Then
            JapaneseDictionarylist.Add("ギャ")
            RomanjiDictionarylist.Add("gya")
        End If

        If CustomForm.Kana198.Checked = True Then
            JapaneseDictionarylist.Add("ギュ")
            RomanjiDictionarylist.Add("gyu")
        End If

        If CustomForm.Kana199.Checked = True Then
            JapaneseDictionarylist.Add("ギョ")
            RomanjiDictionarylist.Add("gyo")
        End If

        If CustomForm.Kana200.Checked = True Then
            JapaneseDictionarylist.Add("ジャ")
            RomanjiDictionarylist.Add("ja")
        End If

        If CustomForm.Kana201.Checked = True Then
            JapaneseDictionarylist.Add("ジュ")
            RomanjiDictionarylist.Add("ju")
        End If

        If CustomForm.Kana202.Checked = True Then
            JapaneseDictionarylist.Add("ジョ")
            RomanjiDictionarylist.Add("jo")
        End If

        If CustomForm.Kana203.Checked = True Then
            JapaneseDictionarylist.Add("ビャ")
            RomanjiDictionarylist.Add("bya")
        End If

        If CustomForm.Kana204.Checked = True Then
            JapaneseDictionarylist.Add("ビュ")
            RomanjiDictionarylist.Add("byu")
        End If

        If CustomForm.Kana205.Checked = True Then
            JapaneseDictionarylist.Add("ビョ")
            RomanjiDictionarylist.Add("byo")
        End If

        If CustomForm.Kana206.Checked = True Then
            JapaneseDictionarylist.Add("ピャ")
            RomanjiDictionarylist.Add("pya")
        End If

        If CustomForm.Kana207.Checked = True Then
            JapaneseDictionarylist.Add("ピュ")
            RomanjiDictionarylist.Add("pyu")
        End If

        If CustomForm.Kana208.Checked = True Then
            JapaneseDictionarylist.Add("ピョ")
            RomanjiDictionarylist.Add("pyo")
        End If

        If CustomForm.Kana209.Checked = True Then
            JapaneseDictionarylist.Add("シ")
            RomanjiDictionarylist.Add("shi")
        End If

        If CustomForm.Kana210.Checked = True Then
            JapaneseDictionarylist.Add("ツ")
            RomanjiDictionarylist.Add("tsu")
        End If

        If CustomForm.Kana211.Checked = True Then
            JapaneseDictionarylist.Add("ソ")
            RomanjiDictionarylist.Add("so")
        End If

        If CustomForm.Kana212.Checked = True Then
            JapaneseDictionarylist.Add("ン")
            RomanjiDictionarylist.Add("n")
        End If

        If CustomForm.Kana213.Checked = True Then
            JapaneseDictionarylist.Add("ノ")
            RomanjiDictionarylist.Add("no")
        End If

        If CustomForm.Kana214.Checked = True Then
            JapaneseDictionarylist.Add("ウ")
            RomanjiDictionarylist.Add("u")
        End If

        If CustomForm.Kana215.Checked = True Then
            JapaneseDictionarylist.Add("フ")
            RomanjiDictionarylist.Add("fu")
        End If

        If CustomForm.Kana216.Checked = True Then
            JapaneseDictionarylist.Add("ワ")
            RomanjiDictionarylist.Add("wa")
        End If

        If CustomForm.Kana217.Checked = True Then
            JapaneseDictionarylist.Add("ラ")
            RomanjiDictionarylist.Add("ra")
        End If

        If CustomForm.Kana218.Checked = True Then
            JapaneseDictionarylist.Add("ス")
            RomanjiDictionarylist.Add("su")
        End If

        If CustomForm.Kana219.Checked = True Then
            JapaneseDictionarylist.Add("ヌ")
            RomanjiDictionarylist.Add("nu")
        End If

        If CustomForm.Kana220.Checked = True Then
            JapaneseDictionarylist.Add("ヲ")
            RomanjiDictionarylist.Add("wo")
        End If
        ' End Adding Alphabet to ArrayList


        ' Random Alphabet and Show on Screen

        Dim RandomNumber As Integer
        RandomNumber = Int((JapaneseDictionarylist.Count * Rnd()))

        If CustomForm.RomajiRadio.Checked = True Then

            If RomanjiDictionarylist.Count <> 0 Then

                Alphabet1.Text = RomanjiDictionarylist(RandomNumber)
                Alphabet2.Text = JapaneseDictionarylist(RandomNumber)

            End If

        End If

        If CustomForm.JapaneseRadio.Checked = True Then

            If RomanjiDictionarylist.Count <> 0 Then

                Alphabet1.Text = JapaneseDictionarylist(RandomNumber)
                Alphabet2.Text = RomanjiDictionarylist(RandomNumber)

            End If

        End If

        ' End Random Alphabet and Show on Screen


    End Sub

End Class