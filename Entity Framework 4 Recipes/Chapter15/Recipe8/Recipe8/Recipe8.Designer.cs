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
[assembly: EdmRelationshipAttribute("EFRecipesModel", "RelativeRelativeResidence", "Relative", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(Recipe8.Relative), "RelativeResidence", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(Recipe8.RelativeResidence))]
[assembly: EdmRelationshipAttribute("EFRecipesModel", "FriendFriendResidence", "Friend", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(Recipe8.Friend), "FriendResidence", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(Recipe8.FriendResidence))]
#endregion

namespace Recipe8
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
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new EFRecipesEntities object.
        /// </summary>
        public EFRecipesEntities(string connectionString) : base(connectionString, "EFRecipesEntities")
        {
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new EFRecipesEntities object.
        /// </summary>
        public EFRecipesEntities(EntityConnection connection) : base(connection, "EFRecipesEntities")
        {
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
        public ObjectSet<Friend> Friends
        {
            get
            {
                if ((_Friends == null))
                {
                    _Friends = base.CreateObjectSet<Friend>("Friends");
                }
                return _Friends;
            }
        }
        private ObjectSet<Friend> _Friends;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Relative> Relatives
        {
            get
            {
                if ((_Relatives == null))
                {
                    _Relatives = base.CreateObjectSet<Relative>("Relatives");
                }
                return _Relatives;
            }
        }
        private ObjectSet<Relative> _Relatives;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Residence> Residences
        {
            get
            {
                if ((_Residences == null))
                {
                    _Residences = base.CreateObjectSet<Residence>("Residences");
                }
                return _Residences;
            }
        }
        private ObjectSet<Residence> _Residences;
    
        #endregion
        #region AddTo Methods
            
        /// <summary>
        /// Deprecated Method for adding a new object to the Friends EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToFriends(Friend friend)
        {
            base.AddObject("Friends", friend);
        }
            
        /// <summary>
        /// Deprecated Method for adding a new object to the Relatives EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToRelatives(Relative relative)
        {
            base.AddObject("Relatives", relative);
        }
            
        /// <summary>
        /// Deprecated Method for adding a new object to the Residences EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToResidences(Residence residence)
        {
            base.AddObject("Residences", residence);
        }
        #endregion
    }
    
    #endregion
    
    
    #region Entities
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="EFRecipesModel", Name="Friend")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Friend : EntityObject
    {
        #region Factory Method
        /// <summary>
        /// Create a new Friend object.
        /// </summary>
        /// <param name="personId">Initial value of the PersonId property.</param>
        /// <param name="name">Initial value of the Name property.</param>
        public static Friend CreateFriend(global::System.Int32 personId, global::System.String name)
        {
            Friend friend = new Friend();
            friend.PersonId = personId;
            
            friend.Name = name;
            
            return friend;
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
    
        #region Navigation Properties
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("EFRecipesModel", "FriendFriendResidence", "FriendResidence")] 
        public FriendResidence FriendResidence
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<FriendResidence>("EFRecipesModel.FriendFriendResidence", "FriendResidence").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<FriendResidence>("EFRecipesModel.FriendFriendResidence", "FriendResidence").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<FriendResidence> FriendResidenceReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<FriendResidence>("EFRecipesModel.FriendFriendResidence", "FriendResidence");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<FriendResidence>("EFRecipesModel.FriendFriendResidence", "FriendResidence", value);
                }
            }
        }
        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="EFRecipesModel", Name="FriendResidence")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class FriendResidence : Residence
    {
        #region Factory Method
        /// <summary>
        /// Create a new FriendResidence object.
        /// </summary>
        /// <param name="addressId">Initial value of the AddressId property.</param>
        /// <param name="address">Initial value of the Address property.</param>
        /// <param name="city">Initial value of the City property.</param>
        /// <param name="state">Initial value of the State property.</param>
        /// <param name="zIP">Initial value of the ZIP property.</param>
        public static FriendResidence CreateFriendResidence(global::System.Int32 addressId, global::System.String address, global::System.String city, global::System.String state, global::System.String zIP)
        {
            FriendResidence friendResidence = new FriendResidence();
            friendResidence.AddressId = addressId;
            
            friendResidence.Address = address;
            
            friendResidence.City = city;
            
            friendResidence.State = state;
            
            friendResidence.ZIP = zIP;
            
            return friendResidence;
        }
        #endregion

    
        #region Navigation Properties
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("EFRecipesModel", "FriendFriendResidence", "Friend")] 
        public Friend Friend
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Friend>("EFRecipesModel.FriendFriendResidence", "Friend").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Friend>("EFRecipesModel.FriendFriendResidence", "Friend").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Friend> FriendReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Friend>("EFRecipesModel.FriendFriendResidence", "Friend");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Friend>("EFRecipesModel.FriendFriendResidence", "Friend", value);
                }
            }
        }
        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="EFRecipesModel", Name="Relative")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Relative : EntityObject
    {
        #region Factory Method
        /// <summary>
        /// Create a new Relative object.
        /// </summary>
        /// <param name="personId">Initial value of the PersonId property.</param>
        /// <param name="name">Initial value of the Name property.</param>
        public static Relative CreateRelative(global::System.Int32 personId, global::System.String name)
        {
            Relative relative = new Relative();
            relative.PersonId = personId;
            
            relative.Name = name;
            
            return relative;
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
    
        #region Navigation Properties
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("EFRecipesModel", "RelativeRelativeResidence", "RelativeResidence")] 
        public RelativeResidence RelativeResidence
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<RelativeResidence>("EFRecipesModel.RelativeRelativeResidence", "RelativeResidence").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<RelativeResidence>("EFRecipesModel.RelativeRelativeResidence", "RelativeResidence").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<RelativeResidence> RelativeResidenceReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<RelativeResidence>("EFRecipesModel.RelativeRelativeResidence", "RelativeResidence");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<RelativeResidence>("EFRecipesModel.RelativeRelativeResidence", "RelativeResidence", value);
                }
            }
        }
        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="EFRecipesModel", Name="RelativeResidence")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class RelativeResidence : Residence
    {
        #region Factory Method
        /// <summary>
        /// Create a new RelativeResidence object.
        /// </summary>
        /// <param name="addressId">Initial value of the AddressId property.</param>
        /// <param name="address">Initial value of the Address property.</param>
        /// <param name="city">Initial value of the City property.</param>
        /// <param name="state">Initial value of the State property.</param>
        /// <param name="zIP">Initial value of the ZIP property.</param>
        public static RelativeResidence CreateRelativeResidence(global::System.Int32 addressId, global::System.String address, global::System.String city, global::System.String state, global::System.String zIP)
        {
            RelativeResidence relativeResidence = new RelativeResidence();
            relativeResidence.AddressId = addressId;
            
            relativeResidence.Address = address;
            
            relativeResidence.City = city;
            
            relativeResidence.State = state;
            
            relativeResidence.ZIP = zIP;
            
            return relativeResidence;
        }
        #endregion

    
        #region Navigation Properties
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("EFRecipesModel", "RelativeRelativeResidence", "Relative")] 
        public Relative Relative
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Relative>("EFRecipesModel.RelativeRelativeResidence", "Relative").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Relative>("EFRecipesModel.RelativeRelativeResidence", "Relative").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Relative> RelativeReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Relative>("EFRecipesModel.RelativeRelativeResidence", "Relative");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Relative>("EFRecipesModel.RelativeRelativeResidence", "Relative", value);
                }
            }
        }
        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="EFRecipesModel", Name="Residence")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    [KnownTypeAttribute(typeof(RelativeResidence))]
    [KnownTypeAttribute(typeof(FriendResidence))]
    public abstract partial class Residence : EntityObject
    {
        #region Primitive Properties
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 AddressId
        {
            get
            {
                return _AddressId;
            }
            set
            {
                if (_AddressId != value)
                {
                    OnAddressIdChanging(value);
                    ReportPropertyChanging("AddressId");
                    _AddressId = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("AddressId");
                    OnAddressIdChanged();
                }
            }
                
        }
        private global::System.Int32 _AddressId;
        partial void OnAddressIdChanging(global::System.Int32 value);
        partial void OnAddressIdChanged();
        
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Address
        {
            get
            {
                return _Address;
            }
            set
            {
                OnAddressChanging(value);
                ReportPropertyChanging("Address");
                _Address = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Address");
                OnAddressChanged();
            }
                
        }
        private global::System.String _Address;
        partial void OnAddressChanging(global::System.String value);
        partial void OnAddressChanged();
        
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String City
        {
            get
            {
                return _City;
            }
            set
            {
                OnCityChanging(value);
                ReportPropertyChanging("City");
                _City = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("City");
                OnCityChanged();
            }
                
        }
        private global::System.String _City;
        partial void OnCityChanging(global::System.String value);
        partial void OnCityChanged();
        
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String State
        {
            get
            {
                return _State;
            }
            set
            {
                OnStateChanging(value);
                ReportPropertyChanging("State");
                _State = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("State");
                OnStateChanged();
            }
                
        }
        private global::System.String _State;
        partial void OnStateChanging(global::System.String value);
        partial void OnStateChanged();
        
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String ZIP
        {
            get
            {
                return _ZIP;
            }
            set
            {
                OnZIPChanging(value);
                ReportPropertyChanging("ZIP");
                _ZIP = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("ZIP");
                OnZIPChanged();
            }
                
        }
        private global::System.String _ZIP;
        partial void OnZIPChanging(global::System.String value);
        partial void OnZIPChanged();
        
        #endregion
    
    }
    
    #endregion
    
}
