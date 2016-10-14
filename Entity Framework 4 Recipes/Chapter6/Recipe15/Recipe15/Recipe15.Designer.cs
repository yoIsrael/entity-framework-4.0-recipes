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
#region EDM Relationship Metadata

[assembly: EdmRelationshipAttribute("Recipe15", "UserPasswordHistory", "User", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(Recipe15.User), "PasswordHistory", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(Recipe15.PasswordHistory))]

#endregion

namespace Recipe15
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class Recipe15Container : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new Recipe15Container object using the connection string found in the 'Recipe15Container' section of the application configuration file.
        /// </summary>
        public Recipe15Container() : base("name=Recipe15Container", "Recipe15Container")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new Recipe15Container object.
        /// </summary>
        public Recipe15Container(string connectionString) : base(connectionString, "Recipe15Container")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new Recipe15Container object.
        /// </summary>
        public Recipe15Container(EntityConnection connection) : base(connection, "Recipe15Container")
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
        public ObjectSet<User> Users
        {
            get
            {
                if ((_Users == null))
                {
                    _Users = base.CreateObjectSet<User>("Users");
                }
                return _Users;
            }
        }
        private ObjectSet<User> _Users;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<PasswordHistory> PasswordHistories
        {
            get
            {
                if ((_PasswordHistories == null))
                {
                    _PasswordHistories = base.CreateObjectSet<PasswordHistory>("PasswordHistories");
                }
                return _PasswordHistories;
            }
        }
        private ObjectSet<PasswordHistory> _PasswordHistories;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Users EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToUsers(User user)
        {
            base.AddObject("Users", user);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the PasswordHistories EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToPasswordHistories(PasswordHistory passwordHistory)
        {
            base.AddObject("PasswordHistories", passwordHistory);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="Recipe15", Name="PasswordHistory")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class PasswordHistory : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new PasswordHistory object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="lastLogin">Initial value of the LastLogin property.</param>
        public static PasswordHistory CreatePasswordHistory(global::System.Int32 id, global::System.DateTime lastLogin)
        {
            PasswordHistory passwordHistory = new PasswordHistory();
            passwordHistory.Id = id;
            passwordHistory.LastLogin = lastLogin;
            return passwordHistory;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime LastLogin
        {
            get
            {
                return _LastLogin;
            }
            set
            {
                OnLastLoginChanging(value);
                ReportPropertyChanging("LastLogin");
                _LastLogin = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("LastLogin");
                OnLastLoginChanged();
            }
        }
        private global::System.DateTime _LastLogin;
        partial void OnLastLoginChanging(global::System.DateTime value);
        partial void OnLastLoginChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("Recipe15", "UserPasswordHistory", "User")]
        public User User
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<User>("Recipe15.UserPasswordHistory", "User").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<User>("Recipe15.UserPasswordHistory", "User").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<User> UserReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<User>("Recipe15.UserPasswordHistory", "User");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<User>("Recipe15.UserPasswordHistory", "User", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="Recipe15", Name="User")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class User : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new User object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="userName">Initial value of the UserName property.</param>
        public static User CreateUser(global::System.Int32 id, global::System.String userName)
        {
            User user = new User();
            user.Id = id;
            user.UserName = userName;
            return user;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String UserName
        {
            get
            {
                return _UserName;
            }
            set
            {
                OnUserNameChanging(value);
                ReportPropertyChanging("UserName");
                _UserName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("UserName");
                OnUserNameChanged();
            }
        }
        private global::System.String _UserName;
        partial void OnUserNameChanging(global::System.String value);
        partial void OnUserNameChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("Recipe15", "UserPasswordHistory", "PasswordHistory")]
        public EntityCollection<PasswordHistory> PasswordHistories
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<PasswordHistory>("Recipe15.UserPasswordHistory", "PasswordHistory");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<PasswordHistory>("Recipe15.UserPasswordHistory", "PasswordHistory", value);
                }
            }
        }

        #endregion
    }

    #endregion
    
}
