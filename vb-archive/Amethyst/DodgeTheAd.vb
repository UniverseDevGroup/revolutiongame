﻿Partial Class DodgeTheAd
    Dim score As Integer = 0
    Dim items As Dictionary(Of String, Boolean) = New Dictionary(Of String, Boolean)
    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        Dim question As Boolean = items.Item(lblAd.Text)
        Dim answer As Boolean
        If comboxYesOrNo.Text = "Yes" Then
            answer = True
        ElseIf comboxYesOrNo.Text = "No" Then
            answer = False
        Else
            MsgBox("You have to select an option")
            Return
        End If
        If question = answer Then
            score += 1
            My.Settings.CashCount += 1
        End If
        comboxYesOrNo.SelectedIndex = 0
        lblScore.Text = CType(score, String)
        lblAd.Text = items.Keys(CInt(Math.Floor(items.Count * Rnd())))
    End Sub


    Private Sub dodgeTheAd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        comboxYesOrNo.SelectedIndex = 0
        items.Add("Ad for the newest version of Microsoft Windows", True)
        items.Add("Ad for the new Facebook network", True)
        items.Add("Ad for your site, " + My.Settings.SiteName, True)
        items.Add("Ad for the Pirate Bay torrenting site.", False)
        items.Add("adf.ly link that is not trusted", False)
        items.Add("Link to a fishy forum that you do not like", False)
        items.Add("eBay link", True)
        items.Add("Windows Blue-Screen In Browser Pop-Up", False)
        items.Add("A link to a media converter", False)
        items.Add("Link to small software site", False)
        items.Add("Custom Themes for Windows on Microsoft Site", True)
        items.Add("Link to site where PC games are sold on disk", True)
        items.Add("Link to a some-what fishy looking 'AVG'", True)
        items.Add("Link the an irc chat that contains NSFW", False)
        items.Add("Picture of the google search engine", True)
        items.Add("NSFW pictures", False)
        items.Add("Link to a website that is no longer existent", False)
        items.Add("Link to an online dating website", True)
    End Sub
End Class
