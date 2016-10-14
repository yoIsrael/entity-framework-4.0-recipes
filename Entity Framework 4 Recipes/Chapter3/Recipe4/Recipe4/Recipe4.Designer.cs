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

namespace Recipe4
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
        public ObjectSet<Person> People
        {
            get
            {
                if ((_People == null))
                {
                    _People = base.CreateObjectSet<Person>("People");
                }
                return _People;
            }
        }
        private ObjectSet<Person> _People;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the People EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToPeople(Person person)
        {
            base.AddObject("People", person);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="EFRecipesModel", Name="Lawyer")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Lawyer : Person
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Lawyer object.
        /// </summary>
        /// <param name="personId">Initial value of the PersonId property.</param>
        /// <param name="name">Initial value of the Name property.</param>
        /// <param name="cases">Initial value of the Cases property.</param>
        public static Lawyer CreateLawyer(global::System.Int32 personId, global::System.String name, global::System.Int32 cases)
        {
            Lawyer lawyer = new Lawyer();
            lawyer.PersonId = personId;
            lawyer.Name = name;
            lawyer.Cases = cases;
            return lawyer;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Cases
        {
            get
            {
                return _Cases;
            }
            set
            {
                OnCasesChanging(value);
                ReportPropertyChanging("Cases");
                _Cases = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Cases");
                OnCasesChanged();
            }
        }
        private global::System.Int32 _Cases;
        partial void OnCasesChanging(global::System.Int32 value);
        partial void OnCasesChanged();

        #endregion
    
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="EFRecipesModel", Name="Person")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    [KnownTypeAttribute(typeof(Lawyer))]
    [KnownTypeAttribute(typeof(Teacher))]
    public partial class Person : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Person object.
        /// </summary>
        /// <param name="personId">Initial value of the PersonId property.</param>
        /// <param name="name">Initial value of the Name property.</param>
        public static Person CreatePerson(global::System.Int32 personId, global::System.String name)
        {
            Person person = new Person();
            person.PersonId = personId;
            person.Name = name;
            return person;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 PersonId
        {
            get
            {
                return _PersonId;
            }
            set
            {
                if (_PersonId != value)
                {
                    OnPersonIdChanging(value);
                    ReportPropertyChanging("PersonId");
                    _PersonId = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("PersonId");
                    OnPersonIdChanged();
                }
            }
        }
        private global::System.Int32 _PersonId;
        partial void OnPersonIdChanging(global::System.Int32 value);
        partial void OnPersonIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                OnNameChanging(value);
                ReportPropertyChanging("Name");
                _Name = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Name");
                OnNameChanged();
            }
        }
        private global::System.String _Name;
        partial void OnNameChanging(global::System.String value);
        partial void OnNameChanged();

        #endregion
    
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="EFRecipesModel", Name="Teacher")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Teacher : Person
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Teacher object.
        /// </summary>
        /// <param name="personId">Initial value of the PersonId property.</param>
        /// <param name="name">Initial value of the Name property.</param>
        /// <param name="isProfessor">Initial value of the IsProfessor property.</param>
        public static Teacher CreateTeacher(global::System.Int32 personId, global::System.String name, global::System.Boolean isProfessor)
        {
            Teacher teacher = new Teacher();
            teacher.PersonId = personId;
            teacher.Name = name;
            teacher.IsProfessor = isProfessor;
            return teacher;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Boolean IsProfessor
        {
            get
            {
                return _IsProfessor;
            }
            set
            {
                OnIsProfessorChanging(value);
                ReportPropertyChanging("IsProfessor");
                _IsProfessor = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("IsProfessor");
                OnIsProfessorChanged();
            }
        }
        private global::System.Boolean _IsProfessor;
        partial void OnIsProfessorChanging(global::System.Boolean value);
        partial void OnIsProfessorChanged();

        #endregion
    
    }

    #endregion
    
}
