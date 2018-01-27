Imports System.ComponentModel

''' <summary>
''' MVVM:View Model
''' </summary>
Public Class CViewModel

    Implements INotifyPropertyChanged
    Implements IDisposable

    ''' <summary>
    ''' プロパティ変更イベント
    ''' </summary>
    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

    ''' <summary>
    ''' プロパティネーム
    ''' </summary>
    Private Const ProName As String = "Value"

    ''' <summary>
    ''' 重複呼出FLG
    ''' </summary>
    Private disposedValue As Boolean

    ''' <summary>
    ''' 値
    ''' </summary>
    Private _Value As String

    ''' <summary>
    ''' 新規作成
    ''' </summary>
    Public Sub New()
        Me._Value = ""
    End Sub

    ''' <summary>
    ''' 新規作成
    ''' </summary>
    ''' <param name="Str">初期値</param>
    Public Sub New(Str As String)
        Me._Value = Str
    End Sub

    ''' <summary>
    ''' 終了処理
    ''' </summary>
    ''' <param name="disposing">マネージ破棄FLG</param>
    Protected Overridable Sub Dispose(disposing As Boolean)
        If Not disposedValue Then
            If disposing Then
                ' TODO: マネージ状態を破棄します (マネージ オブジェクト)。
            End If
        End If
        disposedValue = True
    End Sub

    ''' <summary>
    ''' 終了処理
    ''' </summary>
    Public Sub Dispose() Implements IDisposable.Dispose
        Dispose(True)
    End Sub

    ''' <summary>
    ''' 値の取得・更新
    ''' </summary>
    ''' <returns></returns>
    Public Property Value() As String
        Get
            Return Me._Value
        End Get
        Set(value As String)
            If Not value.Equals(Me._Value) Then
                Me._Value = value
                RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(ProName))
            End If
        End Set
    End Property

End Class
