using System;
using System.ComponentModel;

using DevExpress.Xpo;
using DevExpress.Data.Filtering;

using DevExpress.ExpressApp;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;

namespace TabsLayoutCustomization.Module.BusinessObjects {
   [DefaultClassOptions]
   [System.ComponentModel.DefaultProperty("Title")]
   public class Department : BaseObject {
      private string title;
      private string office;
      public Department(Session session)
         : base(session) {
      }
      public string Title {
         get {
            return title;
         }
         set {
            SetPropertyValue("Title", ref title, value);
         }
      }
      public string Office {
         get {
            return office;
         }
         set {
            SetPropertyValue("Office", ref office, value);
         }
      }
      [Association("Department-Contacts")]
      public XPCollection<Contact> Contacts {
         get {
            return GetCollection<Contact>("Contacts");
         }
      }
      [Association("Departments-Positions")]
      public XPCollection<Position> Positions {
         get {
            return GetCollection<Position>("Positions");
         }
      }
   }

}
