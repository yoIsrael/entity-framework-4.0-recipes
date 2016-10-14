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
[assembly: EdmRelationshipAttribute("EFRecipesModel", "FK_Event_Club", "Club", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(Recipe4.Club), "Event", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(Recipe4.Event), true)]
#endregion

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
        public ObjectSet<Club> Clubs
        {
            get
            {
                if ((_Clubs == null))
                {
                    _Clubs = base.CreateObjectSet<Club>("Clubs");
                }
                return _Clubs;
            }
        }
        private ObjectSet<Club> _Clubs;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Event> Events
        {
            get
            {
                if ((_Events == null))
                {
                    _Events = base.CreateObjectSet<Event>("Events");
                }
                return _Events;
            }
        }
        private ObjectSet<Event> _Events;
    
        #endregion
        #region AddTo Methods
            
        /// <summary>
        /// Deprecated Method for adding a new object to the Clubs EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToClubs(Club club)
        {
            base.AddObject("Clubs", club);
        }
            
        /// <summary>
        /// Deprecated Method for adding a new object to the Events EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToEvents(Event @event)
        {
            base.AddObject("Events", @event);
        }
        #endregion
    }
    
    #endregion
    
    
    #region Entities
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="EFRecipesModel", Name="Club")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Club : EntityObject
    {
        #region Factory Method
        /// <summary>
        /// Create a new Club object.
        /// </summary>
        /// <param name="clubId">Initial value of the ClubId property.</param>
        /// <param name="name">Initial value of the Name property.</param>
        /// <param name="city">Initial value of the City property.</param>
        public static Club CreateClub(global::System.Int32 clubId, global::System.String name, global::System.String city)
        {
            Club club = new Club();
            club.ClubId = clubId;
            
            club.Name = name;
            
            club.City = city;
            
            return club;
        }
        #endregion

        #region Primitive Properties
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 ClubId
        {
            get
            {
                return _ClubId;
            }
            set
            {
                if (_ClubId != value)
                {
                    OnClubIdChanging(value);
                    ReportPropertyChanging("ClubId");
                    _ClubId = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("ClubId");
                    OnClubIdChanged();
                }
            }
                
        }
        private global::System.Int32 _ClubId;
        partial void OnClubIdChanging(global::System.Int32 value);
        partial void OnClubIdChanged();
        
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
        
        #endregion
    
        #region Navigation Properties
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("EFRecipesModel", "FK_Event_Club", "Event")] 
        public EntityCollection<Event> Events
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Event>("EFRecipesModel.FK_Event_Club", "Event");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Event>("EFRecipesModel.FK_Event_Club", "Event", value);
                }
            }
        }
        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="EFRecipesModel", Name="Event")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Event : EntityObject
    {
        #region Factory Method
        /// <summary>
        /// Create a new Event object.
        /// </summary>
        /// <param name="eventId">Initial value of the EventId property.</param>
        /// <param name="eventName">Initial value of the EventName property.</param>
        /// <param name="eventDate">Initial value of the EventDate property.</param>
        /// <param name="clubId">Initial value of the ClubId property.</param>
        public static Event CreateEvent(global::System.Int32 eventId, global::System.String eventName, global::System.DateTime eventDate, global::System.Int32 clubId)
        {
            Event @event = new Event();
            @event.EventId = eventId;
            
            @event.EventName = eventName;
            
            @event.EventDate = eventDate;
            
            @event.ClubId = clubId;
            
            return @event;
        }
        #endregion

        #region Primitive Properties
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 EventId
        {
            get
            {
                return _EventId;
            }
            set
            {
                if (_EventId != value)
                {
                    OnEventIdChanging(value);
                    ReportPropertyChanging("EventId");
                    _EventId = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("EventId");
                    OnEventIdChanged();
                }
            }
                
        }
        private global::System.Int32 _EventId;
        partial void OnEventIdChanging(global::System.Int32 value);
        partial void OnEventIdChanged();
        
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String EventName
        {
            get
            {
                return _EventName;
            }
            set
            {
                OnEventNameChanging(value);
                ReportPropertyChanging("EventName");
                _EventName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("EventName");
                OnEventNameChanged();
            }
                
        }
        private global::System.String _EventName;
        partial void OnEventNameChanging(global::System.String value);
        partial void OnEventNameChanged();
        
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime EventDate
        {
            get
            {
                return _EventDate;
            }
            set
            {
                OnEventDateChanging(value);
                ReportPropertyChanging("EventDate");
                _EventDate = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("EventDate");
                OnEventDateChanged();
            }
                
        }
        private global::System.DateTime _EventDate;
        partial void OnEventDateChanging(global::System.DateTime value);
        partial void OnEventDateChanged();
        
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 ClubId
        {
            get
            {
                return _ClubId;
            }
            set
            {
                OnClubIdChanging(value);
                ReportPropertyChanging("ClubId");
                _ClubId = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("ClubId");
                OnClubIdChanged();
            }
                
        }
        private global::System.Int32 _ClubId;
        partial void OnClubIdChanging(global::System.Int32 value);
        partial void OnClubIdChanged();
        
        #endregion
    
        #region Navigation Properties
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("EFRecipesModel", "FK_Event_Club", "Club")] 
        public Club Club
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Club>("EFRecipesModel.FK_Event_Club", "Club").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Club>("EFRecipesModel.FK_Event_Club", "Club").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Club> ClubReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Club>("EFRecipesModel.FK_Event_Club", "Club");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Club>("EFRecipesModel.FK_Event_Club", "Club", value);
                }
            }
        }
        #endregion
    }
    
    #endregion
    
}