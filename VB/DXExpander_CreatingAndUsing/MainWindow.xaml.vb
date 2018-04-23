Imports Microsoft.VisualBasic
Imports System.Windows
Imports DevExpress.Xpf.Themes

Namespace DXExpander_CreatingAndUsing
	Partial Public Class MainWindow
		Inherits Window
		Public Sub New()
			InitializeComponent()
			ThemeManager.ApplicationThemeName = "Office2007Blue"
			gridControl1.DataSource = _
				New nwindDataSetTableAdapters.CustomerReportsTableAdapter().GetData()
		End Sub
		Private Sub Button_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			expander.IsExpanded = Not expander.IsExpanded
		End Sub
		Private Sub rbAzure_Checked(ByVal sender As Object, ByVal e As RoutedEventArgs)
			If gridControl1 Is Nothing Then
				Return
			End If
			If rbAzure.IsChecked = True Then
				ThemeManager.ApplicationThemeName = "Azure"
			End If
		End Sub
		Private Sub rbOfficeBlack_Checked(ByVal sender As Object, ByVal e As RoutedEventArgs)
			If gridControl1 Is Nothing Then
				Return
			End If
			If rbOfficeBlack.IsChecked = True Then
				ThemeManager.ApplicationThemeName = "Office2007Black"
			End If
		End Sub
		Private Sub rbOfficeBlue_Checked(ByVal sender As Object, ByVal e As RoutedEventArgs)
			If gridControl1 Is Nothing Then
				Return
			End If
			If rbOfficeBlue.IsChecked = True Then
				ThemeManager.ApplicationThemeName = "Office2007Blue"
			End If
		End Sub
		Private Sub rbOfficeSilver_Checked(ByVal sender As Object, ByVal e As RoutedEventArgs)
			If gridControl1 Is Nothing Then
				Return
			End If
			If rbOfficeSilver.IsChecked = True Then
				ThemeManager.ApplicationThemeName = "Office2007Silver"
			End If
		End Sub
	End Class
End Namespace
