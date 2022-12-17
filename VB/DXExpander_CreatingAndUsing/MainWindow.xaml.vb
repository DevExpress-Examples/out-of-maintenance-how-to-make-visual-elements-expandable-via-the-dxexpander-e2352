Imports System.Windows
Imports DevExpress.Xpf.Core
Imports System.Collections.ObjectModel

Namespace DXExpander_CreatingAndUsing

    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
            DataContext = New MyViewModel()
            ApplicationThemeHelper.ApplicationThemeName = "Office2016White"
        End Sub

        Private Sub Button_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Me.expander.IsExpanded = Not Me.expander.IsExpanded
        End Sub

        Private Sub rbAzure_Checked(ByVal sender As Object, ByVal e As RoutedEventArgs)
            If Me.gridControl1 Is Nothing Then Return
            If Me.rbAzure.IsChecked = True Then ApplicationThemeHelper.ApplicationThemeName = "Office2016White"
        End Sub

        Private Sub rbGray_Checked(ByVal sender As Object, ByVal e As RoutedEventArgs)
            If Me.gridControl1 Is Nothing Then Return
            If Me.rbGray.IsChecked = True Then ApplicationThemeHelper.ApplicationThemeName = "LightGray"
        End Sub

        Private Sub rbOfficeBlack_Checked(ByVal sender As Object, ByVal e As RoutedEventArgs)
            If Me.gridControl1 Is Nothing Then Return
            If Me.rbOfficeBlack.IsChecked = True Then ApplicationThemeHelper.ApplicationThemeName = "Office2007Black"
        End Sub

        Private Sub rbOfficeBlue_Checked(ByVal sender As Object, ByVal e As RoutedEventArgs)
            If Me.gridControl1 Is Nothing Then Return
            If Me.rbOfficeBlue.IsChecked = True Then ApplicationThemeHelper.ApplicationThemeName = "Office2007Blue"
        End Sub

        Private Sub rbOfficeSilver_Checked(ByVal sender As Object, ByVal e As RoutedEventArgs)
            If Me.gridControl1 Is Nothing Then Return
            If Me.rbOfficeSilver.IsChecked = True Then ApplicationThemeHelper.ApplicationThemeName = "Office2007Silver"
        End Sub
    End Class

    Public Partial Class Person

        Public Sub New()
        End Sub

        Public Sub New(ByVal i As Integer)
            FirstName = "FirstName" & i
            LastName = "LastName" & i
            Age = i * 10
        End Sub

        Private _firstName As String

        Public Property LastName As String

        Private _age As Integer

        Public Property FirstName As String
            Get
                Return _firstName
            End Get

            Set(ByVal value As String)
                _firstName = value
            End Set
        End Property

        Public Property Age As Integer
            Get
                Return _age
            End Get

            Set(ByVal value As Integer)
                _age = value
            End Set
        End Property
    End Class

    Public Partial Class MyViewModel

        Public Sub New()
            CreateList()
        End Sub

        Public Property ListPerson As ObservableCollection(Of Person)

        Private Sub CreateList()
            ListPerson = New ObservableCollection(Of Person)()
            For i As Integer = 0 To 10 - 1
                Dim p As Person = New Person(i)
                ListPerson.Add(p)
            Next
        End Sub
    End Class
End Namespace
