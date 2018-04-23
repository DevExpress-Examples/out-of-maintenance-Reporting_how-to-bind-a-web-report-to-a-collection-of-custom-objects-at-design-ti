Imports System
Imports System.Collections.Generic
Imports System.Text

Namespace Reports
    Public Class Data
        Private _id As Integer
        Private _name As String
        Public Property ID() As Integer
            Get
                Return Me._id
            End Get
            Set(ByVal value As Integer)
                Me._id = value
            End Set
        End Property
        Public Property Name() As String
            Get
                Return Me._name
            End Get
            Set(ByVal value As String)
                Me._name = value
            End Set
        End Property
        Public Sub New(ByVal id As Integer, ByVal name As String)
            Me._id = id
            Me._name = name
        End Sub
    End Class
End Namespace
