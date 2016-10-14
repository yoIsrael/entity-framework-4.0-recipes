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

[assembly: EdmRelationshipAttribute("EFRecipesModel", "FK_LineItem_Invoice", "Invoice", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(Recipe7.Invoice), "LineItem", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(Recipe7.LineItem), true)]

#endregion

namespace Recipe7
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
        public ObjectSet<Invoice> Invoices
        {
            get
            {
                if ((_Invoices == null))
                {
                    _Invoices = base.CreateObjectSet<Invoice>("Invoices");
                }
                return _Invoices;
            }
        }
        private ObjectSet<Invoice> _Invoices;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<LineItem> LineItems
        {
            get
            {
                if ((_LineItems == null))
                {
                    _LineItems = base.CreateObjectSet<LineItem>("LineItems");
                }
                return _LineItems;
            }
        }
        private ObjectSet<LineItem> _LineItems;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Invoices EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToInvoices(Invoice invoice)
        {
            base.AddObject("Invoices", invoice);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the LineItems EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToLineItems(LineItem lineItem)
        {
            base.AddObject("LineItems", lineItem);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="EFRecipesModel", Name="Invoice")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Invoice : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Invoice object.
        /// </summary>
        /// <param name="invoiceNumber">Initial value of the InvoiceNumber property.</param>
        /// <param name="billedTo">Initial value of the BilledTo property.</param>
        /// <param name="invoiceDate">Initial value of the InvoiceDate property.</param>
        public static Invoice CreateInvoice(global::System.Int32 invoiceNumber, global::System.String billedTo, global::System.DateTime invoiceDate)
        {
            Invoice invoice = new Invoice();
            invoice.InvoiceNumber = invoiceNumber;
            invoice.BilledTo = billedTo;
            invoice.InvoiceDate = invoiceDate;
            return invoice;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 InvoiceNumber
        {
            get
            {
                return _InvoiceNumber;
            }
            set
            {
                if (_InvoiceNumber != value)
                {
                    OnInvoiceNumberChanging(value);
                    ReportPropertyChanging("InvoiceNumber");
                    _InvoiceNumber = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("InvoiceNumber");
                    OnInvoiceNumberChanged();
                }
            }
        }
        private global::System.Int32 _InvoiceNumber;
        partial void OnInvoiceNumberChanging(global::System.Int32 value);
        partial void OnInvoiceNumberChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String BilledTo
        {
            get
            {
                return _BilledTo;
            }
            set
            {
                OnBilledToChanging(value);
                ReportPropertyChanging("BilledTo");
                _BilledTo = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("BilledTo");
                OnBilledToChanged();
            }
        }
        private global::System.String _BilledTo;
        partial void OnBilledToChanging(global::System.String value);
        partial void OnBilledToChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime InvoiceDate
        {
            get
            {
                return _InvoiceDate;
            }
            set
            {
                OnInvoiceDateChanging(value);
                ReportPropertyChanging("InvoiceDate");
                _InvoiceDate = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("InvoiceDate");
                OnInvoiceDateChanged();
            }
        }
        private global::System.DateTime _InvoiceDate;
        partial void OnInvoiceDateChanging(global::System.DateTime value);
        partial void OnInvoiceDateChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("EFRecipesModel", "FK_LineItem_Invoice", "LineItem")]
        public EntityCollection<LineItem> LineItems
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<LineItem>("EFRecipesModel.FK_LineItem_Invoice", "LineItem");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<LineItem>("EFRecipesModel.FK_LineItem_Invoice", "LineItem", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="EFRecipesModel", Name="LineItem")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class LineItem : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new LineItem object.
        /// </summary>
        /// <param name="invoiceNumber">Initial value of the InvoiceNumber property.</param>
        /// <param name="itemNumber">Initial value of the ItemNumber property.</param>
        /// <param name="cost">Initial value of the Cost property.</param>
        public static LineItem CreateLineItem(global::System.Int32 invoiceNumber, global::System.Int32 itemNumber, global::System.Decimal cost)
        {
            LineItem lineItem = new LineItem();
            lineItem.InvoiceNumber = invoiceNumber;
            lineItem.ItemNumber = itemNumber;
            lineItem.Cost = cost;
            return lineItem;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 InvoiceNumber
        {
            get
            {
                return _InvoiceNumber;
            }
            set
            {
                if (_InvoiceNumber != value)
                {
                    OnInvoiceNumberChanging(value);
                    ReportPropertyChanging("InvoiceNumber");
                    _InvoiceNumber = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("InvoiceNumber");
                    OnInvoiceNumberChanged();
                }
            }
        }
        private global::System.Int32 _InvoiceNumber;
        partial void OnInvoiceNumberChanging(global::System.Int32 value);
        partial void OnInvoiceNumberChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 ItemNumber
        {
            get
            {
                return _ItemNumber;
            }
            set
            {
                if (_ItemNumber != value)
                {
                    OnItemNumberChanging(value);
                    ReportPropertyChanging("ItemNumber");
                    _ItemNumber = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("ItemNumber");
                    OnItemNumberChanged();
                }
            }
        }
        private global::System.Int32 _ItemNumber;
        partial void OnItemNumberChanging(global::System.Int32 value);
        partial void OnItemNumberChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Decimal Cost
        {
            get
            {
                return _Cost;
            }
            set
            {
                OnCostChanging(value);
                ReportPropertyChanging("Cost");
                _Cost = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Cost");
                OnCostChanged();
            }
        }
        private global::System.Decimal _Cost;
        partial void OnCostChanging(global::System.Decimal value);
        partial void OnCostChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("EFRecipesModel", "FK_LineItem_Invoice", "Invoice")]
        public Invoice Invoice
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Invoice>("EFRecipesModel.FK_LineItem_Invoice", "Invoice").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Invoice>("EFRecipesModel.FK_LineItem_Invoice", "Invoice").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Invoice> InvoiceReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Invoice>("EFRecipesModel.FK_LineItem_Invoice", "Invoice");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Invoice>("EFRecipesModel.FK_LineItem_Invoice", "Invoice", value);
                }
            }
        }

        #endregion
    }

    #endregion
    
}
