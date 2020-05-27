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

'INSTANT VB NOTE: The variable id was renamed since Visual Basic does not handle local variables named the same as class members well:
'INSTANT VB NOTE: The variable name was renamed since Visual Basic does not handle local variables named the same as class members well:
'INSTANT VB NOTE: The variable info was renamed since Visual Basic does not handle local variables named the same as class members well:
		Public Sub New(ByVal id_Conflict As Integer, ByVal name_Conflict As String, ByVal info_Conflict As String)
			Me.ID = id_Conflict
			Me.Name = name_Conflict
			Me.Info = info_Conflict
		End Sub

		Public Property ID() As Integer
		Public Property Name() As String
		Public Property Info() As String
	End Class
End Namespace
