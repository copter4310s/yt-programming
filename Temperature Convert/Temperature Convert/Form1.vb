Public Class Form1

    Dim cTemp As Decimal
    Dim fTemp As Decimal
    Dim rTemp As Decimal
    Dim kTemp As Decimal

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.SelectedIndex = 0
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.SelectedIndex = 0 Then
            'C TO K
            kTemp = NumericUpDown1.Value + 273
        ElseIf ComboBox1.SelectedIndex = 1 Then
            'F TO K
            kTemp = (((NumericUpDown1.Value - 32) / 9) * 5) + 273
        ElseIf ComboBox1.SelectedIndex = 2 Then
            kTemp = NumericUpDown1.Value
        ElseIf ComboBox1.SelectedIndex = 3 Then
            'R TO K
            kTemp = (NumericUpDown1.Value * 1.25) + 273
        End If

        'K TO C
        cTemp = kTemp - 273
        lbl_c.Text = cTemp.ToString("0.00") & " °C"

        'K TO F
        fTemp = (((kTemp - 273) / 5) * 9) + 32
        lbl_f.Text = fTemp.ToString("0.00") & " °F"

        'K TO R
        rTemp = (((kTemp - 273) / 5) * 4)
        lbl_r.Text = rTemp.ToString("0.00") & " °R"

        lbl_k.Text = kTemp.ToString("0.00") & " K"
    End Sub
End Class
