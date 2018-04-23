Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace TestGridLookUpEditCSV
    Public Class Customer
        Public Sub New()
            Me.ID = 0
            Me.Name = ""
            Me.Info = ""
        End Sub

        Public Sub New(ByVal id As Integer, ByVal name As String, ByVal info As String)
            Me.ID = id
            Me.Name = name
            Me.Info = info
        End Sub

        Public Property ID() As Integer
        Public Property Name() As String
        Public Property Info() As String
    End Class
End Namespace
