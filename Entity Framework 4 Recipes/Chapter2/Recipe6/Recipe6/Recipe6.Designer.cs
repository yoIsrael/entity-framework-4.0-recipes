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


namespace Recipe6
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
        public ObjectSet<Product> Products
        {
            get
            {
                if ((_Products == null))
                {
                    _Products = base.CreateObjectSet<Product>("Products");
                }
                return _Products;
            }
        }
        private ObjectSet<Product> _Products;
    
        #endregion
        #region AddTo Methods
            
        /// <summary>
        /// Deprecated Method for adding a new object to the Products EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToProducts(Product product)
        {
            base.AddObject("Products", product);
        }
        #endregion
    }
    
    #endregion
    
    
    #region Entities
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="EFRecipesModel", Name="Product")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Product : EntityObject
    {
        #region Factory Method
        /// <summary>
        /// Create a new Product object.
        /// </summary>
        /// <param name="sKU">Initial value of the SKU property.</param>
        /// <param name="description">Initial value of the Description property.</param>
        /// <param name="price">Initial value of the Price property.</param>
        public static Product CreateProduct(global::System.Int32 sKU, global::System.String description, global::System.Decimal price)
        {
            Product product = new Product();
            product.SKU = sKU;
            
            product.Description = description;
            
            product.Price = price;
            
            return product;
        }
        #endregion

        #region Primitive Properties
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 SKU
        {
            get
            {
                return _SKU;
            }
            set
            {
                if (_SKU != value)
                {
                    OnSKUChanging(value);
                    ReportPropertyChanging("SKU");
                    _SKU = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("SKU");
                    OnSKUChanged();
                }
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
        public global::System.String Description
        {
            get
            {
                return _Description;
            }
            set
            {
                OnDescriptionChanging(value);
                ReportPropertyChanging("Description");
                _Description = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Description");
                OnDescriptionChanged();
            }
                
        }
        private global::System.String _Description;
        partial void OnDescriptionChanging(global::System.String value);
        partial void OnDescriptionChanged();
        
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Decimal Price
        {
            get
            {
                return _Price;
            }
            set
            {
                OnPriceChanging(value);
                ReportPropertyChanging("Price");
                _Price = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Price");
                OnPriceChanged();
            }
                
        }
        private global::System.Decimal _Price;
        partial void OnPriceChanging(global::System.Decimal value);
        partial void OnPriceChanged();
        
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String ImageURL
        {
            get
            {
                return _ImageURL;
            }
            set
            {
                OnImageURLChanging(value);
                ReportPropertyChanging("ImageURL");
                _ImageURL = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("ImageURL");
                OnImageURLChanged();
            }
                
        }
        private global::System.String _ImageURL;
        partial void OnImageURLChanging(global::System.String value);
        partial void OnImageURLChanged();
        
        #endregion
    
    }
    
    #endregion
    
}
