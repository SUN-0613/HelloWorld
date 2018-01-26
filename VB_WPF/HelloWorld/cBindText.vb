Imports System.ComponentModel

''' <summary>
''' Textbox管理クラス
''' </summary>
Public Class CBindText

    Implements INotifyPropertyChanged   'プロパティチェンジイベント実装
    Implements IDisposable              '終了処理実装

    ''' <summary>
    ''' 入力内容
    ''' </summary>
    Private _Text As String

    ''' <summary>
    ''' バインディング
    ''' </summary>
    Private _Bind As Binding

    ''' <summary>
    ''' Textbox
    ''' </summary>
    Private _txtbox As TextBox

    ''' <summary>
    ''' 終了処理実行FLG
    ''' </summary>
    Private disposedValue As Boolean

    ''' <summary>
    ''' イベント名
    ''' </summary>
    Private Const EventName As String = "Text"

    ''' <summary>
    ''' プロパティチェンジイベント
    ''' </summary>
    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

    ''' <summary>
    ''' 新規作成
    ''' </summary>
    Public Sub New(txt As TextBox)
        Me.SetBind(txt)
    End Sub

    ''' <summary>
    ''' 終了処理
    ''' </summary>
    Protected Overridable Sub Dispose(disposing As Boolean)
        If Not disposedValue Then
            If disposing Then

                Me.Close()

                Me._Bind = Nothing
                Me._Text = Nothing
                Me._txtbox = Nothing

            End If
        End If
        disposedValue = True
    End Sub

    ''' <summary>
    ''' 終了処理(手動)
    ''' </summary>
    Public Sub Dispose() Implements IDisposable.Dispose
        Dispose(True)
    End Sub

    ''' <summary>
    ''' 終了処理
    ''' </summary>
    Public Sub Close()

        If Not IsNothing(Me._Bind) Then

            ClearBind()

        End If

    End Sub

    ''' <summary>
    ''' 入力内容
    ''' </summary>
    ''' <returns>現入力内容</returns>
    Public Property Text As String
        Get
            Return Me._Text
        End Get
        Set(value As String)
            If Not Me._Text.Equals(value) Then
                Me._Text = value
                RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(EventName))
            End If
        End Set
    End Property

    ''' <summary>
    ''' バインディング設定
    ''' </summary>
    ''' <param name="txt">Textbox</param>
    Private Sub SetBind(txt As TextBox)

        If IsNothing(txt.Name) Then Return

        Me._txtbox = txt
        Me._Text = txt.Text

        Me._Bind = New Binding(EventName)
        Me._Bind.Source = Me

        BindingOperations.SetBinding(Me._txtbox, TextBox.TextProperty, Me._Bind)

    End Sub

    ''' <summary>
    ''' バインディング解除
    ''' </summary>
    Private Sub ClearBind()

        If Not IsNothing(Me._Bind) Then
            BindingOperations.ClearAllBindings(Me._txtbox)
        End If

    End Sub

End Class
