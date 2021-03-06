﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]

namespace Recipe15
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class EFRecipesEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new EFRecipesEntities object using the connection string found in the 'EFRecipesEntities' section of the application configuration file.
        /// </summary>
        public EFRecipesEntities() : base("name=EFRecipesEntities", "EFRecipesEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new EFRecipesEntities object.
        /// </summary>
        public EFRecipesEntities(string connectionString) : base(connectionString, "EFRecipesEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new EFRecipesEntities object.
        /// </summary>
        public EFRecipesEntities(EntityConnection connection) : base(connection, "EFRecipesEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Registration> Registrations
        {
            get
            {
                if ((_Registrations == null))
                {
                    _Registrations = base.CreateObjectSet<Registration>("Registrations");
                }
                return _Registrations;
            }
        }
        private ObjectSet<Registration> _Registrations;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Registrations EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToRegistrations(Registration registration)
        {
            base.AddObject("Registrations", registration);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="EFRecipesModel", Name="Registration")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Registration : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Registration object.
        /// </summary>
        /// <param name="registrationId">Initial value of the RegistrationId property.</param>
        /// <param name="studentName">Initial value of the StudentName property.</param>
        /// <param name="registrationDate">Initial value of the RegistrationDate property.</param>
        public static Registration CreateRegistration(global::System.Int32 registrationId, global::System.String studentName, global::System.DateTime registrationDate)
        {
            Registration registration = new Registration();
            registration.RegistrationId = registrationId;
            registration.StudentName = studentName;
            registration.RegistrationDate = registrationDate;
            return registration;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 RegistrationId
        {
            get
            {
                return _RegistrationId;
            }
            set
            {
                if (_RegistrationId != value)
                {
                    OnRegistrationIdChanging(value);
                    ReportPropertyChanging("RegistrationId");
                    _RegistrationId = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("RegistrationId");
                    OnRegistrationIdChanged();
                }
            }
        }
        private global::System.Int32 _RegistrationId;
        partial void OnRegistrationIdChanging(global::System.Int32 value);
        partial void OnRegistrationIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String StudentName
        {
            get
            {
                return _StudentName;
            }
            set
            {
                OnStudentNameChanging(value);
                ReportPropertyChanging("StudentName");
                _StudentName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("StudentName");
                OnStudentNameChanged();
            }
        }
        private global::System.String _StudentName;
        partial void OnStudentNameChanging(global::System.String value);
        partial void OnStudentNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime RegistrationDate
        {
            get
            {
                return _RegistrationDate;
            }
            set
            {
                OnRegistrationDateChanging(value);
                ReportPropertyChanging("RegistrationDate");
                _RegistrationDate = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("RegistrationDate");
                OnRegistrationDateChanged();
            }
        }
        private global::System.DateTime _RegistrationDate;
        partial void OnRegistrationDateChanging(global::System.DateTime value);
        partial void OnRegistrationDateChanged();

        #endregion
    
    }

    #endregion
    
}
