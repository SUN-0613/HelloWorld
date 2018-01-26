Public Class WMain

    Private CText As CBindText

    ''' <summary>
    ''' 新規作成
    ''' </summary>
    Public Sub New()

        InitializeComponent()

        CText = New CBindText(Me.txt)
        CText.Text = "Hello World!"

    End Sub

    ''' <summary>
    ''' 終了処理
    ''' </summary>
    Protected Overrides Sub Finalize()

        MyBase.Finalize()

    End Sub

End Class
