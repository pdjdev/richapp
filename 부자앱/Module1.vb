Module Module1
    Public Sub FadeIn()
        Dim fade As Double
        For fade = 0.0 To 1.1 Step 0.05
            Form1.Opacity = fade
            Form1.Refresh()
            Threading.Thread.Sleep(10)
        Next
    End Sub
    Public Sub fadeout()
        Dim fade As Double
        For fade = 1.1 To 0.0 Step -0.09
            Form1.Opacity = fade
            Form1.Refresh()
            Threading.Thread.Sleep(10)
        Next
    End Sub
End Module
