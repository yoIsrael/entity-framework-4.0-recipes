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

namespace Recipe2
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
        public ObjectSet<Agent> Agents
        {
            get
            {
                if ((_Agents == null))
                {
                    _Agents = base.CreateObjectSet<Agent>("Agents");
                }
                return _Agents;
            }
        }
        private ObjectSet<Agent> _Agents;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Agents EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToAgents(Agent agent)
        {
            base.AddObject("Agents", agent);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="EFRecipesModel", Name="Agent")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Agent : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Agent object.
        /// </summary>
        /// <param name="name">Initial value of the Name property.</param>
        /// <param name="phone">Initial value of the Phone property.</param>
        /// <param name="timeStamp">Initial value of the TimeStamp property.</param>
        public static Agent CreateAgent(global::System.String name, global::System.String phone, global::System.Byte[] timeStamp)
        {
            Agent agent = new Agent();
            agent.Name = name;
            agent.Phone = phone;
            agent.TimeStamp = timeStamp;
            return agent;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                if (_Name != value)
                {
                    OnNameChanging(value);
                    ReportPropertyChanging("Name");
                    _Name = StructuralObject.SetValidValue(value, false);
                    ReportPropertyChanged("Name");
                    OnNameChanged();
                }
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
        public global::System.String Phone
        {
            get
            {
                return _Phone;
            }
            set
            {
                OnPhoneChanging(value);
                ReportPropertyChanging("Phone");
                _Phone = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Phone");
                OnPhoneChanged();
            }
        }
        private global::System.String _Phone;
        partial void OnPhoneChanging(global::System.String value);
        partial void OnPhoneChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Byte[] TimeStamp
        {
            get
            {
                return StructuralObject.GetValidValue(_TimeStamp);
            }
            set
            {
                OnTimeStampChanging(value);
                ReportPropertyChanging("TimeStamp");
                _TimeStamp = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("TimeStamp");
                OnTimeStampChanged();
            }
        }
        private global::System.Byte[] _TimeStamp;
        partial void OnTimeStampChanging(global::System.Byte[] value);
        partial void OnTimeStampChanged();

        #endregion
    
    }

    #endregion
    
}
