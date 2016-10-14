﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System.Data.EntityClient;
using System.Data.Metadata.Edm;
using System.Data.Objects.DataClasses;
using System.Data.Objects;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.Linq;

namespace MediaEntities
{
    public partial class EFRecipesEntities : ObjectContext
    {
        public const string ConnectionString = "name=EFRecipesEntities";
        public const string ContainerName = "EFRecipesEntities";
    
        #region Constructors
    
        public EFRecipesEntities()
            : base(ConnectionString, ContainerName)
        {
            Initialize();
        }
    
        public EFRecipesEntities(string connectionString)
            : base(connectionString, ContainerName)
        {
            Initialize();
        }
    
        public EFRecipesEntities(EntityConnection connection)
            : base(connection, ContainerName)
        {
            Initialize();
        }
    
        private void Initialize()
        {
            // Creating proxies requires the use of the ProxyDataContractResolver and
            // may allow lazy loading which can expand the loaded graph during serialization.
            ContextOptions.ProxyCreationEnabled = false;
            ObjectMaterialized += new ObjectMaterializedEventHandler(HandleObjectMaterialized);
        }
    
        private void HandleObjectMaterialized(object sender, ObjectMaterializedEventArgs e)
        {
            var entity = e.Entity as IObjectWithChangeTracker;
            if (entity != null)
            {
                bool changeTrackingEnabled = entity.ChangeTracker.ChangeTrackingEnabled;
                try
                {
                    entity.MarkAsUnchanged();
                }
                finally
                {
                    entity.ChangeTracker.ChangeTrackingEnabled = changeTrackingEnabled;
                }
                this.StoreReferenceKeyValues(entity);
            }
        }
    
        #endregion
    
        #region ObjectSet Properties
    
        public ObjectSet<Category> Categories
        {
            get { return _categories  ?? (_categories = CreateObjectSet<Category>("Categories")); }
        }
        private ObjectSet<Category> _categories;
    
        public ObjectSet<Medium> Media
        {
            get { return _media  ?? (_media = CreateObjectSet<Medium>("Media")); }
        }
        private ObjectSet<Medium> _media;
    
        public ObjectSet<MediaType> MediaTypes
        {
            get { return _mediaTypes  ?? (_mediaTypes = CreateObjectSet<MediaType>("MediaTypes")); }
        }
        private ObjectSet<MediaType> _mediaTypes;

        #endregion
    }
}
