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
[assembly: EdmRelationshipAttribute("EFRecipesModel", "CustomerCustomerDiscount", "Customer", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(Recipe11.Customer), "CustomerDiscount", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(Recipe11.CustomerDiscount), true)]
[assembly: EdmRelationshipAttribute("EFRecipesModel", "CustomerCreditReport", "Customer", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(Recipe11.Customer), "CreditReport", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(Recipe11.CreditReport), true)]
[assembly: EdmRelationshipAttribute("EFRecipesModel", "RiskyCustomerRiskyOrder", "Order", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(Recipe11.Order), "Customer", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(Recipe11.Customer))]
[assembly: EdmRelationshipAttribute("EFRecipesModel", "PerferredCustomerPerferredOrder", "Order", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(Recipe11.Order), "Customer", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(Recipe11.Customer))]
#endregion

namespace Recipe11
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
        public ObjectSet<Customer> PreferredCustomers
        {
            get
            {
                if ((_PreferredCustomers == null))
                {
                    _PreferredCustomers = base.CreateObjectSet<Customer>("PreferredCustomers");
                }
                return _PreferredCustomers;
            }
        }
        private ObjectSet<Customer> _PreferredCustomers;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Customer> RiskyCustomers
        {
            get
            {
                if ((_RiskyCustomers == null))
                {
                    _RiskyCustomers = base.CreateObjectSet<Customer>("RiskyCustomers");
                }
                return _RiskyCustomers;
            }
        }
        private ObjectSet<Customer> _RiskyCustomers;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Order> PreferredOrders
        {
            get
            {
                if ((_PreferredOrders == null))
                {
                    _PreferredOrders = base.CreateObjectSet<Order>("PreferredOrders");
                }
                return _PreferredOrders;
            }
        }
        private ObjectSet<Order> _PreferredOrders;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Order> RiskyOrders
        {
            get
            {
                if ((_RiskyOrders == null))
                {
                    _RiskyOrders = base.CreateObjectSet<Order>("RiskyOrders");
                }
                return _RiskyOrders;
            }
        }
        private ObjectSet<Order> _RiskyOrders;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<CreditReport> CreditReports
        {
            get
            {
                if ((_CreditReports == null))
                {
                    _CreditReports = base.CreateObjectSet<CreditReport>("CreditReports");
                }
                return _CreditReports;
            }
        }
        private ObjectSet<CreditReport> _CreditReports;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<CustomerDiscount> CustomerDiscounts
        {
            get
            {
                if ((_CustomerDiscounts == null))
                {
                    _CustomerDiscounts = base.CreateObjectSet<CustomerDiscount>("CustomerDiscounts");
                }
                return _CustomerDiscounts;
            }
        }
        private ObjectSet<CustomerDiscount> _CustomerDiscounts;
    
        #endregion
        #region AddTo Methods
            
        /// <summary>
        /// Deprecated Method for adding a new object to the PreferredCustomers EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToPreferredCustomers(Customer customer)
        {
            base.AddObject("PreferredCustomers", customer);
        }
            
        /// <summary>
        /// Deprecated Method for adding a new object to the RiskyCustomers EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToRiskyCustomers(Customer customer)
        {
            base.AddObject("RiskyCustomers", customer);
        }
            
        /// <summary>
        /// Deprecated Method for adding a new object to the PreferredOrders EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToPreferredOrders(Order order)
        {
            base.AddObject("PreferredOrders", order);
        }
            
        /// <summary>
        /// Deprecated Method for adding a new object to the RiskyOrders EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToRiskyOrders(Order order)
        {
            base.AddObject("RiskyOrders", order);
        }
            
        /// <summary>
        /// Deprecated Method for adding a new object to the CreditReports EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToCreditReports(CreditReport creditReport)
        {
            base.AddObject("CreditReports", creditReport);
        }
            
        /// <summary>
        /// Deprecated Method for adding a new object to the CustomerDiscounts EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToCustomerDiscounts(CustomerDiscount customerDiscount)
        {
            base.AddObject("CustomerDiscounts", customerDiscount);
        }
        #endregion
    }
    
    #endregion
    
    
    #region Entities
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="EFRecipesModel", Name="CreditReport")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class CreditReport : EntityObject
    {
        #region Factory Method
        /// <summary>
        /// Create a new CreditReport object.
        /// </summary>
        /// <param name="reportId">Initial value of the ReportId property.</param>
        /// <param name="creditRating">Initial value of the CreditRating property.</param>
        /// <param name="customerId">Initial value of the CustomerId property.</param>
        public static CreditReport CreateCreditReport(global::System.Int32 reportId, global::System.Int32 creditRating, global::System.Int32 customerId)
        {
            CreditReport creditReport = new CreditReport();
            creditReport.ReportId = reportId;
            
            creditReport.CreditRating = creditRating;
            
            creditReport.CustomerId = customerId;
            
            return creditReport;
        }
        #endregion

        #region Primitive Properties
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 ReportId
        {
            get
            {
                return _ReportId;
            }
            set
            {
                if (_ReportId != value)
                {
                    OnReportIdChanging(value);
                    ReportPropertyChanging("ReportId");
                    _ReportId = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("ReportId");
                    OnReportIdChanged();
                }
            }
                
        }
        private global::System.Int32 _ReportId;
        partial void OnReportIdChanging(global::System.Int32 value);
        partial void OnReportIdChanged();
        
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 CreditRating
        {
            get
            {
                return _CreditRating;
            }
            set
            {
                OnCreditRatingChanging(value);
                ReportPropertyChanging("CreditRating");
                _CreditRating = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("CreditRating");
                OnCreditRatingChanged();
            }
                
        }
        private global::System.Int32 _CreditRating;
        partial void OnCreditRatingChanging(global::System.Int32 value);
        partial void OnCreditRatingChanged();
        
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 CustomerId
        {
            get
            {
                return _CustomerId;
            }
            set
            {
                OnCustomerIdChanging(value);
                ReportPropertyChanging("CustomerId");
                _CustomerId = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("CustomerId");
                OnCustomerIdChanged();
            }
                
        }
        private global::System.Int32 _CustomerId;
        partial void OnCustomerIdChanging(global::System.Int32 value);
        partial void OnCustomerIdChanged();
        
        #endregion
    
        #region Navigation Properties
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("EFRecipesModel", "CustomerCreditReport", "Customer")] 
        public Customer Customer
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Customer>("EFRecipesModel.CustomerCreditReport", "Customer").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Customer>("EFRecipesModel.CustomerCreditReport", "Customer").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Customer> CustomerReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Customer>("EFRecipesModel.CustomerCreditReport", "Customer");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Customer>("EFRecipesModel.CustomerCreditReport", "Customer", value);
                }
            }
        }
        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="EFRecipesModel", Name="Customer")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Customer : EntityObject
    {
        #region Factory Method
        /// <summary>
        /// Create a new Customer object.
        /// </summary>
        /// <param name="customerId">Initial value of the CustomerId property.</param>
        /// <param name="name">Initial value of the Name property.</param>
        public static Customer CreateCustomer(global::System.Int32 customerId, global::System.String name)
        {
            Customer customer = new Customer();
            customer.CustomerId = customerId;
            
            customer.Name = name;
            
            return customer;
        }
        #endregion

        #region Primitive Properties
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 CustomerId
        {
            get
            {
                return _CustomerId;
            }
            set
            {
                if (_CustomerId != value)
                {
                    OnCustomerIdChanging(value);
                    ReportPropertyChanging("CustomerId");
                    _CustomerId = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("CustomerId");
                    OnCustomerIdChanged();
                }
            }
                
        }
        private global::System.Int32 _CustomerId;
        partial void OnCustomerIdChanging(global::System.Int32 value);
        partial void OnCustomerIdChanged();
        
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
        [EdmRelationshipNavigationPropertyAttribute("EFRecipesModel", "CustomerCustomerDiscount", "CustomerDiscount")] 
        public CustomerDiscount CustomerDiscount
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<CustomerDiscount>("EFRecipesModel.CustomerCustomerDiscount", "CustomerDiscount").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<CustomerDiscount>("EFRecipesModel.CustomerCustomerDiscount", "CustomerDiscount").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<CustomerDiscount> CustomerDiscountReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<CustomerDiscount>("EFRecipesModel.CustomerCustomerDiscount", "CustomerDiscount");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<CustomerDiscount>("EFRecipesModel.CustomerCustomerDiscount", "CustomerDiscount", value);
                }
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("EFRecipesModel", "CustomerCreditReport", "CreditReport")] 
        public EntityCollection<CreditReport> CreditReports
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<CreditReport>("EFRecipesModel.CustomerCreditReport", "CreditReport");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<CreditReport>("EFRecipesModel.CustomerCreditReport", "CreditReport", value);
                }
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("EFRecipesModel", "RiskyCustomerRiskyOrder", "Order")] 
        public EntityCollection<Order> RiskyOrders
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Order>("EFRecipesModel.RiskyCustomerRiskyOrder", "Order");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Order>("EFRecipesModel.RiskyCustomerRiskyOrder", "Order", value);
                }
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("EFRecipesModel", "PerferredCustomerPerferredOrder", "Order")] 
        public EntityCollection<Order> PreferredOrders
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Order>("EFRecipesModel.PerferredCustomerPerferredOrder", "Order");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Order>("EFRecipesModel.PerferredCustomerPerferredOrder", "Order", value);
                }
            }
        }
        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="EFRecipesModel", Name="CustomerDiscount")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class CustomerDiscount : EntityObject
    {
        #region Factory Method
        /// <summary>
        /// Create a new CustomerDiscount object.
        /// </summary>
        /// <param name="customerId">Initial value of the CustomerId property.</param>
        /// <param name="purchaseDiscount">Initial value of the PurchaseDiscount property.</param>
        public static CustomerDiscount CreateCustomerDiscount(global::System.Int32 customerId, global::System.Int32 purchaseDiscount)
        {
            CustomerDiscount customerDiscount = new CustomerDiscount();
            customerDiscount.CustomerId = customerId;
            
            customerDiscount.PurchaseDiscount = purchaseDiscount;
            
            return customerDiscount;
        }
        #endregion

        #region Primitive Properties
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 CustomerId
        {
            get
            {
                return _CustomerId;
            }
            set
            {
                if (_CustomerId != value)
                {
                    OnCustomerIdChanging(value);
                    ReportPropertyChanging("CustomerId");
                    _CustomerId = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("CustomerId");
                    OnCustomerIdChanged();
                }
            }
                
        }
        private global::System.Int32 _CustomerId;
        partial void OnCustomerIdChanging(global::System.Int32 value);
        partial void OnCustomerIdChanged();
        
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 PurchaseDiscount
        {
            get
            {
                return _PurchaseDiscount;
            }
            set
            {
                OnPurchaseDiscountChanging(value);
                ReportPropertyChanging("PurchaseDiscount");
                _PurchaseDiscount = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("PurchaseDiscount");
                OnPurchaseDiscountChanged();
            }
                
        }
        private global::System.Int32 _PurchaseDiscount;
        partial void OnPurchaseDiscountChanging(global::System.Int32 value);
        partial void OnPurchaseDiscountChanged();
        
        #endregion
    
        #region Navigation Properties
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("EFRecipesModel", "CustomerCustomerDiscount", "Customer")] 
        public Customer Customer
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Customer>("EFRecipesModel.CustomerCustomerDiscount", "Customer").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Customer>("EFRecipesModel.CustomerCustomerDiscount", "Customer").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Customer> CustomerReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Customer>("EFRecipesModel.CustomerCustomerDiscount", "Customer");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Customer>("EFRecipesModel.CustomerCustomerDiscount", "Customer", value);
                }
            }
        }
        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="EFRecipesModel", Name="Order")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Order : EntityObject
    {
        #region Factory Method
        /// <summary>
        /// Create a new Order object.
        /// </summary>
        /// <param name="orderId">Initial value of the OrderId property.</param>
        /// <param name="amount">Initial value of the Amount property.</param>
        public static Order CreateOrder(global::System.Int32 orderId, global::System.Decimal amount)
        {
            Order order = new Order();
            order.OrderId = orderId;
            
            order.Amount = amount;
            
            return order;
        }
        #endregion

        #region Primitive Properties
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 OrderId
        {
            get
            {
                return _OrderId;
            }
            set
            {
                if (_OrderId != value)
                {
                    OnOrderIdChanging(value);
                    ReportPropertyChanging("OrderId");
                    _OrderId = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("OrderId");
                    OnOrderIdChanged();
                }
            }
                
        }
        private global::System.Int32 _OrderId;
        partial void OnOrderIdChanging(global::System.Int32 value);
        partial void OnOrderIdChanged();
        
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
    
        #region Navigation Properties
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("EFRecipesModel", "RiskyCustomerRiskyOrder", "Customer")] 
        public Customer RiskyCustomer
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Customer>("EFRecipesModel.RiskyCustomerRiskyOrder", "Customer").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Customer>("EFRecipesModel.RiskyCustomerRiskyOrder", "Customer").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Customer> RiskyCustomerReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Customer>("EFRecipesModel.RiskyCustomerRiskyOrder", "Customer");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Customer>("EFRecipesModel.RiskyCustomerRiskyOrder", "Customer", value);
                }
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("EFRecipesModel", "PerferredCustomerPerferredOrder", "Customer")] 
        public Customer PreferredCustomer
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Customer>("EFRecipesModel.PerferredCustomerPerferredOrder", "Customer").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Customer>("EFRecipesModel.PerferredCustomerPerferredOrder", "Customer").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Customer> PreferredCustomerReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Customer>("EFRecipesModel.PerferredCustomerPerferredOrder", "Customer");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Customer>("EFRecipesModel.PerferredCustomerPerferredOrder", "Customer", value);
                }
            }
        }
        #endregion
    }
    
    #endregion
    
}
