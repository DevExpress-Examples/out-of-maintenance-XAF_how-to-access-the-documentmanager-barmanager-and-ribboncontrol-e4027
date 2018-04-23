Imports System
Imports System.ComponentModel
Imports DevExpress.Xpo
Imports DevExpress.Persistent.Base
Imports DevExpress.Persistent.BaseImpl

Namespace TabsLayoutCustomization.Module.BusinessObjects
    <DefaultClassOptions, System.ComponentModel.DefaultProperty("Title")> _
    Public Class Department
        Inherits BaseObject


        Private title_Renamed As String

        Private office_Renamed As String
        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub
        Public Property Title() As String
            Get
                Return title_Renamed
            End Get
            Set(ByVal value As String)
                SetPropertyValue("Title", title_Renamed, value)
            End Set
        End Property
        Public Property Office() As String
            Get
                Return office_Renamed
            End Get
            Set(ByVal value As String)
                SetPropertyValue("Office", office_Renamed, value)
            End Set
        End Property
        <Association("Department-Contacts")> _
        Public ReadOnly Property Contacts() As XPCollection(Of Contact)
            Get
                Return GetCollection(Of Contact)("Contacts")
            End Get
        End Property
        <Association("Departments-Positions")> _
        Public ReadOnly Property Positions() As XPCollection(Of Position)
            Get
                Return GetCollection(Of Position)("Positions")
            End Get
        End Property
    End Class

End Namespace
