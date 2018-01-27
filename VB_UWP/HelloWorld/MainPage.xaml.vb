' 空白ページの項目テンプレートについては、https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x411 を参照してください

''' <summary>
''' それ自体で使用できる空白ページまたはフレーム内に移動できる空白ページ。
''' </summary>
Public NotInheritable Class MainPage
    Inherits Page

    ''' <summary>
    ''' ViewModelプロパティ定義
    ''' </summary>
    Public Property VModel As New CViewModel()

    ''' <summary>
    ''' 新規作成
    ''' </summary>
    Public Sub New()

        InitializeComponent()

        VModel.Value = "Hello World!"

    End Sub

End Class
