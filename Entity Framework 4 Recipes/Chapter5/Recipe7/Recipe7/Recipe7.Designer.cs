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
[assembly: EdmRelationshipAttribute("EFRecipesModel", "FK_OrderItem_Order", "Order", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(Recipe7.Order), "OrderItem", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(Recipe7.OrderItem), true)]
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
        public ObjectSet<Order> Orders
        {
            get
            {
                if ((_Orders == null))
                {
                    _Orders = base.CreateObjectSet<Order>("Orders");
                }
                return _Orders;
            }
        }
        private ObjectSet<Order> _Orders;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<OrderItem> OrderItems
        {
            get
            {
                if ((_OrderItems == null))
                {
                    _OrderItems = base.CreateObjectSet<OrderItem>("OrderItems");
                }
                return _OrderItems;
            }
        }
        private ObjectSet<OrderItem> _OrderItems;
    
        #endregion
        #region AddTo Methods
            
        /// <summary>
        /// Deprecated Method for adding a new object to the Orders EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToOrders(Order order)
        {
            base.AddObject("Orders", order);
        }
            
        /// <summary>
        /// Deprecated Method for adding a new object to the OrderItems EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToOrderItems(OrderItem orderItem)
        {
            base.AddObject("OrderItems", orderItem);
        }
        #endregion
    }
    
    #endregion
    
    
    #region Entities
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
        /// <param name="orderDate">Initial value of the OrderDate property.</param>
        /// <param name="customerName">Initial value of the CustomerName property.</param>
        public static Order CreateOrder(global::System.Int32 orderId, global::System.DateTime orderDate, global::System.String customerName)
        {
            Order order = new Order();
            order.OrderId = orderId;
            
            order.OrderDate = orderDate;
            
            order.CustomerName = customerName;
            
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
        public global::System.DateTime OrderDate
        {
            get
            {
                return _OrderDate;
            }
            set
            {
                OnOrderDateChanging(value);
                ReportPropertyChanging("OrderDate");
                _OrderDate = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("OrderDate");
                OnOrderDateChanged();
            }
                
        }
        private global::System.DateTime _OrderDate;
        partial void OnOrderDateChanging(global::System.DateTime value);
        partial void OnOrderDateChanged();
        
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String CustomerName
        {
            get
            {
                return _CustomerName;
            }
            set
            {
                OnCustomerNameChanging(value);
                ReportPropertyChanging("CustomerName");
                _CustomerName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("CustomerName");
                OnCustomerNameChanged();
            }
                
        }
        private global::System.String _CustomerName;
        partial void OnCustomerNameChanging(global::System.String value);
        partial void OnCustomerNameChanged();
        
        #endregion
    
        #region Navigation Properties
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("EFRecipesModel", "FK_OrderItem_Order", "OrderItem")] 
        public EntityCollection<OrderItem> OrderItems
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<OrderItem>("EFRecipesModel.FK_OrderItem_Order", "OrderItem");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<OrderItem>("EFRecipesModel.FK_OrderItem_Order", "OrderItem", value);
                }
            }
        }
        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="EFRecipesModel", Name="OrderItem")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class OrderItem : EntityObject
    {
        #region Factory Method
        /// <summary>
        /// Create a new OrderItem object.
        /// </summary>
        /// <param name="orderItemId">Initial value of the OrderItemId property.</param>
        /// <param name="orderId">Initial value of the OrderId property.</param>
        /// <param name="sKU">Initial value of the SKU property.</param>
        /// <param name="shipped">Initial value of the Shipped property.</param>
        /// <param name="unitPrice">Initial value of the UnitPrice property.</param>
        public static OrderItem CreateOrderItem(global::System.Int32 orderItemId, global::System.Int32 orderId, global::System.Int32 sKU, global::System.Int32 shipped, global::System.Decimal unitPrice)
        {
            OrderItem orderItem = new OrderItem();
            orderItem.OrderItemId = orderItemId;
            
            orderItem.OrderId = orderId;
            
            orderItem.SKU = sKU;
            
            orderItem.Shipped = shipped;
            
            orderItem.UnitPrice = unitPrice;
            
            return orderItem;
        }
        #endregion

        #region Primitive Properties
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 OrderItemId
        {
            get
            {
                return _OrderItemId;
            }
            set
            {
                if (_OrderItemId != value)
                {
                    OnOrderItemIdChanging(value);
                    ReportPropertyChanging("OrderItemId");
                    _OrderItemId = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("OrderItemId");
                    OnOrderItemIdChanged();
                }
            }
                
        }
        private global::System.Int32 _OrderItemId;
        partial void OnOrderItemIdChanging(global::System.Int32 value);
        partial void OnOrderItemIdChanged();
        
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 OrderId
        {
            get
            {
                return _OrderId;
            }
            set
            {
                OnOrderIdChanging(value);
                ReportPropertyChanging("OrderId");
                _OrderId = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("OrderId");
                OnOrderIdChanged();
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
        public global::System.Int32 SKU
        {
            get
            {
                return _SKU;
            }
            set
            {
                OnSKUChanging(value);
                ReportPropertyChanging("SKU");
                _SKU = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("SKU");
                OnSKUChanged();
            }
                
        }
        private global::System.Int32 _SKU;
        partial void OnSKUChanging(global::System.Int32 value);
        partial void OnSKUChanged();
        
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Shipped
        {
            get
            {
                return _Shipped;
            }
            set
            {
                OnShippedChanging(value);
                ReportPropertyChanging("Shipped");
                _Shipped = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Shipped");
                OnShippedChanged();
            }
                
        }
        private global::System.Int32 _Shipped;
        partial void OnShippedChanging(global::System.Int32 value);
        partial void OnShippedChanged();
        
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Decimal UnitPrice
        {
            get
            {
                return _UnitPrice;
            }
            set
            {
                OnUnitPriceChanging(value);
                ReportPropertyChanging("UnitPrice");
                _UnitPrice = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("UnitPrice");
                OnUnitPriceChanged();
            }
                
        }
        private global::System.Decimal _UnitPrice;
        partial void OnUnitPriceChanging(global::System.Decimal value);
        partial void OnUnitPriceChanged();
        
        #endregion
    
        #region Navigation Properties
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("EFRecipesModel", "FK_OrderItem_Order", "Order")] 
        public Order Order
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Order>("EFRecipesModel.FK_OrderItem_Order", "Order").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Order>("EFRecipesModel.FK_OrderItem_Order", "Order").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Order> OrderReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Order>("EFRecipesModel.FK_OrderItem_Order", "Order");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Order>("EFRecipesModel.FK_OrderItem_Order", "Order", value);
                }
            }
        }
        #endregion
    }
    
    #endregion
    
}
