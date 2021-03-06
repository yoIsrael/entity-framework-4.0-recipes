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

namespace Recipe10
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
        public ObjectSet<Candidate> Candidates
        {
            get
            {
                if ((_Candidates == null))
                {
                    _Candidates = base.CreateObjectSet<Candidate>("Candidates");
                }
                return _Candidates;
            }
        }
        private ObjectSet<Candidate> _Candidates;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Candidates EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToCandidates(Candidate candidate)
        {
            base.AddObject("Candidates", candidate);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="EFRecipesModel", Name="Candidate")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Candidate : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Candidate object.
        /// </summary>
        /// <param name="candidateId">Initial value of the CandidateId property.</param>
        /// <param name="name">Initial value of the Name property.</param>
        public static Candidate CreateCandidate(global::System.Int32 candidateId, global::System.String name)
        {
            Candidate candidate = new Candidate();
            candidate.CandidateId = candidateId;
            candidate.Name = name;
            return candidate;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 CandidateId
        {
            get
            {
                return _CandidateId;
            }
            set
            {
                if (_CandidateId != value)
                {
                    OnCandidateIdChanging(value);
                    ReportPropertyChanging("CandidateId");
                    _CandidateId = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("CandidateId");
                    OnCandidateIdChanged();
                }
            }
        }
        private global::System.Int32 _CandidateId;
        partial void OnCandidateIdChanging(global::System.Int32 value);
        partial void OnCandidateIdChanged();
    
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
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        private global::System.String Resume
        {
            get
            {
                return _Resume;
            }
            set
            {
                OnResumeChanging(value);
                ReportPropertyChanging("Resume");
                _Resume = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Resume");
                OnResumeChanged();
            }
        }
        private global::System.String _Resume;
        partial void OnResumeChanging(global::System.String value);
        partial void OnResumeChanged();

        #endregion
    
    }

    #endregion
    
}
