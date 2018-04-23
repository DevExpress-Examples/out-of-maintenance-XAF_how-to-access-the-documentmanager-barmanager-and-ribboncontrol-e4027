using System;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Updating;
using DevExpress.Data.Filtering;

using TabsLayoutCustomization.Module.BusinessObjects;

namespace TabsLayoutCustomization.Module.DatabaseUpdate {
    public class Updater : ModuleUpdater {
        public Updater(IObjectSpace objectSpace, Version currentDBVersion)
            : base(objectSpace, currentDBVersion) {
        }
        public override void UpdateDatabaseAfterUpdateSchema() {
            base.UpdateDatabaseAfterUpdateSchema();
            Position developerPosition = ObjectSpace.FindObject<Position>(CriteriaOperator.Parse("Title == 'Developer'"));
            if(developerPosition == null) {
                developerPosition = ObjectSpace.CreateObject<Position>();
                developerPosition.Title = "Developer";
            }
            Position managerPosition = ObjectSpace.FindObject<Position>(CriteriaOperator.Parse("Title == 'Manager'"));
            if(managerPosition == null) {
                managerPosition = ObjectSpace.CreateObject<Position>();
                managerPosition.Title = "Manager";
            }

            Department devDepartment = ObjectSpace.FindObject<Department>(CriteriaOperator.Parse("Title == 'Development Department'"));
            if(devDepartment == null) {
                devDepartment = ObjectSpace.CreateObject<Department>();
                devDepartment.Title = "Development Department";
                devDepartment.Office = "205";
                devDepartment.Positions.Add(developerPosition);
                devDepartment.Positions.Add(managerPosition);
            }

            Contact contactMary = ObjectSpace.FindObject<Contact>(CriteriaOperator.Parse("FirstName == 'Mary' && LastName == 'Tellitson'"));
            if(contactMary == null) {
                contactMary = ObjectSpace.CreateObject<Contact>();
                contactMary.FirstName = "Mary";
                contactMary.LastName = "Tellitson";
                contactMary.Email = "mary_tellitson@md.com";
                contactMary.Birthday = new DateTime(1980, 11, 27);
                contactMary.Department = devDepartment;
                contactMary.Position = managerPosition;
            }

            Contact contactJohn = ObjectSpace.FindObject<Contact>(CriteriaOperator.Parse("FirstName == 'John' && LastName == 'Nilsen'"));
            if(contactJohn == null) {
                contactJohn = ObjectSpace.CreateObject<Contact>();
                contactJohn.FirstName = "John";
                contactJohn.LastName = "Nilsen";
                contactJohn.Email = "john_nilsen@md.com";
                contactJohn.Birthday = new DateTime(1981, 10, 3);
                contactJohn.Department = devDepartment;
                contactJohn.Position = developerPosition;
            }
        }
    }
}
