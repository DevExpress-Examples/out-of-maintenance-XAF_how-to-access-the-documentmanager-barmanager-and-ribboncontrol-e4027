Imports System
Imports System.Security.Principal

Imports DevExpress.Persistent.BaseImpl
Imports DevExpress.Persistent.Base.Security
Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Security
Imports DevExpress.ExpressApp.Updating
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering

Public Class Updater
	Inherits DevExpress.ExpressApp.Updating.ModuleUpdater
    Public Sub New(ByVal objectSpace As IObjectSpace, ByVal currentDBVersion As Version)
        MyBase.New(objectSpace, currentDBVersion)
    End Sub

	Public Overrides Sub UpdateDatabaseAfterUpdateSchema()
        MyBase.UpdateDatabaseAfterUpdateSchema()
        Dim developerPosition As Position = ObjectSpace.FindObject(Of Position)(CriteriaOperator.Parse("Title == 'Developer'"))
        If developerPosition Is Nothing Then
            developerPosition = ObjectSpace.CreateObject(Of Position)()
            developerPosition.Title = "Developer"
        End If
        Dim managerPosition As Position = ObjectSpace.FindObject(Of Position)(CriteriaOperator.Parse("Title == 'Manager'"))
        If managerPosition Is Nothing Then
            managerPosition = ObjectSpace.CreateObject(Of Position)()
            managerPosition.Title = "Manager"
        End If

        Dim devDepartment As Department = ObjectSpace.FindObject(Of Department)(CriteriaOperator.Parse("Title == 'Development Department'"))
        If devDepartment Is Nothing Then
            devDepartment = ObjectSpace.CreateObject(Of Department)()
            devDepartment.Title = "Development Department"
            devDepartment.Office = "205"
            devDepartment.Positions.Add(developerPosition)
            devDepartment.Positions.Add(managerPosition)
        End If

        Dim contactMary As Contact = ObjectSpace.FindObject(Of Contact)(CriteriaOperator.Parse("FirstName == 'Mary' && LastName == 'Tellitson'"))
        If contactMary Is Nothing Then
            contactMary = ObjectSpace.CreateObject(Of Contact)()
            contactMary.FirstName = "Mary"
            contactMary.LastName = "Tellitson"
            contactMary.Email = "mary_tellitson@md.com"
            contactMary.Birthday = New DateTime(1980, 11, 27)
            contactMary.Department = devDepartment
            contactMary.Position = managerPosition
        End If

        Dim contactJohn As Contact = ObjectSpace.FindObject(Of Contact)(CriteriaOperator.Parse("FirstName == 'John' && LastName == 'Nilsen'"))
        If contactJohn Is Nothing Then
            contactJohn = ObjectSpace.CreateObject(Of Contact)()
            contactJohn.FirstName = "John"
            contactJohn.LastName = "Nilsen"
            contactJohn.Email = "john_nilsen@md.com"
            contactJohn.Birthday = New DateTime(1981, 10, 3)
            contactJohn.Department = devDepartment
            contactJohn.Position = developerPosition
        End If
    End Sub
End Class
