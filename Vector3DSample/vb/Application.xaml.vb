﻿Imports System.Configuration

Namespace Mil3dVectorSample
	''' <summary>
	''' Interaction logic for App.xaml
	''' </summary>
	Partial Public Class App
		Inherits Application
		Private Sub AppStartingUp(ByVal sender As Object, ByVal e As StartupEventArgs)
			Dim mainWindow As New MainWindow()
			mainWindow.Show()

			'''Displays the values of the variables that will be used
			mainWindow.ShowVars()

		End Sub
	End Class
End Namespace
