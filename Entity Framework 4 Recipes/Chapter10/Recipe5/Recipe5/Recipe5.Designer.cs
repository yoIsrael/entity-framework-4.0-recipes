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

[assembly: EdmRelationshipAttribute("EFRecipesModel", "FK_Message_Member", "Member", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(Recipe5.Member), "Message", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(Recipe5.Message), true)]

#endregion

namespace Recipe5
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
        public ObjectSet<Member> Members
        {
            get
            {
                if ((_Members == null))
                {
                    _Members = base.CreateObjectSet<Member>("Members");
                }
                return _Members;
            }
        }
        private ObjectSet<Member> _Members;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Message> Messages
        {
            get
            {
                if ((_Messages == null))
                {
                    _Messages = base.CreateObjectSet<Message>("Messages");
                }
                return _Messages;
            }
        }
        private ObjectSet<Message> _Messages;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Members EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToMembers(Member member)
        {
            base.AddObject("Members", member);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Messages EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToMessages(Message message)
        {
            base.AddObject("Messages", message);
        }

        #endregion
        #region Function Imports
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        /// <param name="datesent">No Metadata Documentation available.</param>
        public ObjectResult<Member> MembersWithTheMostMessages(Nullable<global::System.DateTime> datesent)
        {
            ObjectParameter datesentParameter;
            if (datesent.HasValue)
            {
                datesentParameter = new ObjectParameter("datesent", datesent);
            }
            else
            {
                datesentParameter = new ObjectParameter("datesent", typeof(global::System.DateTime));
            }
    
            return base.ExecuteFunction<Member>("MembersWithTheMostMessages", datesentParameter);
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        /// <param name="mergeOption"></param>
        /// <param name="datesent">No Metadata Documentation available.</param>
        public ObjectResult<Member> MembersWithTheMostMessages(Nullable<global::System.DateTime> datesent, MergeOption mergeOption)
        {
            ObjectParameter datesentParameter;
            if (datesent.HasValue)
            {
                datesentParameter = new ObjectParameter("datesent", datesent);
            }
            else
            {
                datesentParameter = new ObjectParameter("datesent", typeof(global::System.DateTime));
            }
    
            return base.ExecuteFunction<Member>("MembersWithTheMostMessages", mergeOption, datesentParameter);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="EFRecipesModel", Name="Member")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Member : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Member object.
        /// </summary>
        /// <param name="memberId">Initial value of the MemberId property.</param>
        /// <param name="name">Initial value of the Name property.</param>
        public static Member CreateMember(global::System.Int32 memberId, global::System.String name)
        {
            Member member = new Member();
            member.MemberId = memberId;
            member.Name = name;
            return member;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 MemberId
        {
            get
            {
                return _MemberId;
            }
            set
            {
                if (_MemberId != value)
                {
                    OnMemberIdChanging(value);
                    ReportPropertyChanging("MemberId");
                    _MemberId = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("MemberId");
                    OnMemberIdChanged();
                }
            }
        }
        private global::System.Int32 _MemberId;
        partial void OnMemberIdChanging(global::System.Int32 value);
        partial void OnMemberIdChanged();
    
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
        [EdmRelationshipNavigationPropertyAttribute("EFRecipesModel", "FK_Message_Member", "Message")]
        public EntityCollection<Message> Messages
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Message>("EFRecipesModel.FK_Message_Member", "Message");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Message>("EFRecipesModel.FK_Message_Member", "Message", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="EFRecipesModel", Name="Message")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Message : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Message object.
        /// </summary>
        /// <param name="messageId">Initial value of the MessageId property.</param>
        /// <param name="memberId">Initial value of the MemberId property.</param>
        /// <param name="dateSent">Initial value of the DateSent property.</param>
        /// <param name="subject">Initial value of the Subject property.</param>
        /// <param name="messageBody">Initial value of the MessageBody property.</param>
        public static Message CreateMessage(global::System.Int32 messageId, global::System.Int32 memberId, global::System.DateTime dateSent, global::System.String subject, global::System.String messageBody)
        {
            Message message = new Message();
            message.MessageId = messageId;
            message.MemberId = memberId;
            message.DateSent = dateSent;
            message.Subject = subject;
            message.MessageBody = messageBody;
            return message;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 MessageId
        {
            get
            {
                return _MessageId;
            }
            set
            {
                if (_MessageId != value)
                {
                    OnMessageIdChanging(value);
                    ReportPropertyChanging("MessageId");
                    _MessageId = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("MessageId");
                    OnMessageIdChanged();
                }
            }
        }
        private global::System.Int32 _MessageId;
        partial void OnMessageIdChanging(global::System.Int32 value);
        partial void OnMessageIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 MemberId
        {
            get
            {
                return _MemberId;
            }
            set
            {
                OnMemberIdChanging(value);
                ReportPropertyChanging("MemberId");
                _MemberId = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("MemberId");
                OnMemberIdChanged();
            }
        }
        private global::System.Int32 _MemberId;
        partial void OnMemberIdChanging(global::System.Int32 value);
        partial void OnMemberIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime DateSent
        {
            get
            {
                return _DateSent;
            }
            set
            {
                OnDateSentChanging(value);
                ReportPropertyChanging("DateSent");
                _DateSent = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("DateSent");
                OnDateSentChanged();
            }
        }
        private global::System.DateTime _DateSent;
        partial void OnDateSentChanging(global::System.DateTime value);
        partial void OnDateSentChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Subject
        {
            get
            {
                return _Subject;
            }
            set
            {
                OnSubjectChanging(value);
                ReportPropertyChanging("Subject");
                _Subject = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Subject");
                OnSubjectChanged();
            }
        }
        private global::System.String _Subject;
        partial void OnSubjectChanging(global::System.String value);
        partial void OnSubjectChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String MessageBody
        {
            get
            {
                return _MessageBody;
            }
            set
            {
                OnMessageBodyChanging(value);
                ReportPropertyChanging("MessageBody");
                _MessageBody = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("MessageBody");
                OnMessageBodyChanged();
            }
        }
        private global::System.String _MessageBody;
        partial void OnMessageBodyChanging(global::System.String value);
        partial void OnMessageBodyChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("EFRecipesModel", "FK_Message_Member", "Member")]
        public Member Member
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Member>("EFRecipesModel.FK_Message_Member", "Member").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Member>("EFRecipesModel.FK_Message_Member", "Member").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Member> MemberReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Member>("EFRecipesModel.FK_Message_Member", "Member");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Member>("EFRecipesModel.FK_Message_Member", "Member", value);
                }
            }
        }

        #endregion
    }

    #endregion
    
}
