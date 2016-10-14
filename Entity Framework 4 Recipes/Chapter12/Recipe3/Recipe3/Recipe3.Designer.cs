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

namespace Recipe3
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
        public ObjectSet<Donation> Donations
        {
            get
            {
                if ((_Donations == null))
                {
                    _Donations = base.CreateObjectSet<Donation>("Donations");
                }
                return _Donations;
            }
        }
        private ObjectSet<Donation> _Donations;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Donations EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToDonations(Donation donation)
        {
            base.AddObject("Donations", donation);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="EFRecipesModel", Name="Donation")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Donation : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Donation object.
        /// </summary>
        /// <param name="donationId">Initial value of the DonationId property.</param>
        /// <param name="donorName">Initial value of the DonorName property.</param>
        /// <param name="amount">Initial value of the Amount property.</param>
        public static Donation CreateDonation(global::System.Int32 donationId, global::System.String donorName, global::System.Decimal amount)
        {
            Donation donation = new Donation();
            donation.DonationId = donationId;
            donation.DonorName = donorName;
            donation.Amount = amount;
            return donation;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 DonationId
        {
            get
            {
                return _DonationId;
            }
            set
            {
                if (_DonationId != value)
                {
                    OnDonationIdChanging(value);
                    ReportPropertyChanging("DonationId");
                    _DonationId = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("DonationId");
                    OnDonationIdChanged();
                }
            }
        }
        private global::System.Int32 _DonationId;
        partial void OnDonationIdChanging(global::System.Int32 value);
        partial void OnDonationIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String DonorName
        {
            get
            {
                return _DonorName;
            }
            set
            {
                OnDonorNameChanging(value);
                ReportPropertyChanging("DonorName");
                _DonorName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("DonorName");
                OnDonorNameChanged();
            }
        }
        private global::System.String _DonorName;
        partial void OnDonorNameChanging(global::System.String value);
        partial void OnDonorNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Decimal Amount
        {
            get
            {
                return _Amount;
            }
            set
            {
                OnAmountChanging(value);
                ReportPropertyChanging("Amount");
                _Amount = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Amount");
                OnAmountChanged();
            }
        }
        private global::System.Decimal _Amount;
        partial void OnAmountChanging(global::System.Decimal value);
        partial void OnAmountChanged();

        #endregion
    
    }

    #endregion
    
}
