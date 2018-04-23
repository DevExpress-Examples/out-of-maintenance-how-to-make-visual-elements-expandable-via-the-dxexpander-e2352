Imports System.Windows
Imports DevExpress.Xpf.Core
Imports System.Collections.ObjectModel

Namespace DXExpander_CreatingAndUsing
    Partial Public Class MainWindow
        Inherits Window

        Public Sub New()
            InitializeComponent()
            Me.DataContext = New MyViewModel()
            ApplicationThemeHelper.ApplicationThemeName = "Office2016White"

        End Sub
        Private Sub Button_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            expander.IsExpanded = Not expander.IsExpanded
        End Sub
        Private Sub rbAzure_Checked(ByVal sender As Object, ByVal e As RoutedEventArgs)
            If gridControl1 Is Nothing Then
                Return
            End If
            If rbAzure.IsChecked = True Then
                ApplicationThemeHelper.ApplicationThemeName = "Office2016White"
            End If
        End Sub
        Private Sub rbGray_Checked(ByVal sender As Object, ByVal e As RoutedEventArgs)
            If gridControl1 Is Nothing Then
                Return
            End If
            If rbGray.IsChecked = True Then
                ApplicationThemeHelper.ApplicationThemeName = "LightGray"
            End If
        End Sub
        Private Sub rbOfficeBlack_Checked(ByVal sender As Object, ByVal e As RoutedEventArgs)
            If gridControl1 Is Nothing Then
                Return
            End If
            If rbOfficeBlack.IsChecked = True Then
                ApplicationThemeHelper.ApplicationThemeName = "Office2007Black"
            End If
        End Sub
        Private Sub rbOfficeBlue_Checked(ByVal sender As Object, ByVal e As RoutedEventArgs)
            If gridControl1 Is Nothing Then
                Return
            End If
            If rbOfficeBlue.IsChecked = True Then
                ApplicationThemeHelper.ApplicationThemeName = "Office2007Blue"
            End If
        End Sub
        Private Sub rbOfficeSilver_Checked(ByVal sender As Object, ByVal e As RoutedEventArgs)
            If gridControl1 Is Nothing Then
                Return
            End If
            If rbOfficeSilver.IsChecked = True Then
                ApplicationThemeHelper.ApplicationThemeName = "Office2007Silver"
            End If
        End Sub
    End Class

    Partial Public Class Person
        Public Sub New()

        End Sub
        Public Sub New(ByVal i As Integer)
            FirstName = "FirstName" & i
            LastName = "LastName" & i
            Age = i * 10

        End Sub

        Private _firstName As String
        Public Property LastName() As String
        Private _age As Integer

        Public Property FirstName() As String
            Get
                Return _firstName
            End Get
            Set(ByVal value As String)
                _firstName = value
            End Set
        End Property

        Public Property Age() As Integer
            Get
                Return _age
            End Get
            Set(ByVal value As Integer)
                _age = value
            End Set
        End Property
    End Class
    Partial Public Class MyViewModel
        Public Sub New()
            CreateList()
        End Sub

        Public Property ListPerson() As ObservableCollection(Of Person)

        Private Sub CreateList()
            ListPerson = New ObservableCollection(Of Person)()

            For i As Integer = 0 To 9
                Dim p As New Person(i)
                ListPerson.Add(p)
            Next i
        End Sub
    End Class
End Namespace
