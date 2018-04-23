Imports System
Imports System.ComponentModel
Imports DevExpress.Xpo
Imports DevExpress.Persistent.Base
Imports DevExpress.Persistent.BaseImpl
Imports DevExpress.Persistent.Validation

Namespace TabsLayoutCustomization.Module.BusinessObjects
    <DefaultClassOptions, System.ComponentModel.DefaultProperty("Title")> _
    Public Class Position
        Inherits BaseObject

        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub


        Private title_Renamed As String
        <RuleRequiredField("RuleRequiredField for Position.Title", DefaultContexts.Save)> _
        Public Property Title() As String
            Get
                Return title_Renamed
            End Get
            Set(ByVal value As String)
                SetPropertyValue("Title", title_Renamed, value)
            End Set
        End Property
        <Association("Departments-Positions")> _
        Public ReadOnly Property Departments() As XPCollection(Of Department)
            Get
                Return GetCollection(Of Department)("Departments")
            End Get
        End Property
    End Class

End Namespace
