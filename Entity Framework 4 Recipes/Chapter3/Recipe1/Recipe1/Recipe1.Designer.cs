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

namespace Recipe1
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
        public ObjectSet<Payment> Payments
        {
            get
            {
                if ((_Payments == null))
                {
                    _Payments = base.CreateObjectSet<Payment>("Payments");
                }
                return _Payments;
            }
        }
        private ObjectSet<Payment> _Payments;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Payments EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToPayments(Payment payment)
        {
            base.AddObject("Payments", payment);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="EFRecipesModel", Name="Payment")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Payment : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Payment object.
        /// </summary>
        /// <param name="paymentId">Initial value of the PaymentId property.</param>
        /// <param name="amount">Initial value of the Amount property.</param>
        /// <param name="vendor">Initial value of the Vendor property.</param>
        public static Payment CreatePayment(global::System.Int32 paymentId, global::System.Decimal amount, global::System.String vendor)
        {
            Payment payment = new Payment();
            payment.PaymentId = paymentId;
            payment.Amount = amount;
            payment.Vendor = vendor;
            return payment;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 PaymentId
        {
            get
            {
                return _PaymentId;
            }
            set
            {
                if (_PaymentId != value)
                {
                    OnPaymentIdChanging(value);
                    ReportPropertyChanging("PaymentId");
                    _PaymentId = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("PaymentId");
                    OnPaymentIdChanged();
                }
            }
        }
        private global::System.Int32 _PaymentId;
        partial void OnPaymentIdChanging(global::System.Int32 value);
        partial void OnPaymentIdChanged();
    
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
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Vendor
        {
            get
            {
                return _Vendor;
            }
            set
            {
                OnVendorChanging(value);
                ReportPropertyChanging("Vendor");
                _Vendor = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Vendor");
                OnVendorChanged();
            }
        }
        private global::System.String _Vendor;
        partial void OnVendorChanging(global::System.String value);
        partial void OnVendorChanged();

        #endregion
    
    }

    #endregion
    
}
