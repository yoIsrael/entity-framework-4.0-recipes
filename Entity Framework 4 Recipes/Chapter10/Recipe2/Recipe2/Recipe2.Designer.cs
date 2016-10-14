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

[assembly: EdmRelationshipAttribute("EFRecipesModel", "FK_Rental_Vehicle", "Vehicle", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(Recipe2.Vehicle), "Rental", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(Recipe2.Rental), true)]

#endregion

namespace Recipe2
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
        public ObjectSet<Rental> Rentals
        {
            get
            {
                if ((_Rentals == null))
                {
                    _Rentals = base.CreateObjectSet<Rental>("Rentals");
                }
                return _Rentals;
            }
        }
        private ObjectSet<Rental> _Rentals;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Vehicle> Vehicles
        {
            get
            {
                if ((_Vehicles == null))
                {
                    _Vehicles = base.CreateObjectSet<Vehicle>("Vehicles");
                }
                return _Vehicles;
            }
        }
        private ObjectSet<Vehicle> _Vehicles;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Rentals EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToRentals(Rental rental)
        {
            base.AddObject("Rentals", rental);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Vehicles EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToVehicles(Vehicle vehicle)
        {
            base.AddObject("Vehicles", vehicle);
        }

        #endregion
        #region Function Imports
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        /// <param name="date">No Metadata Documentation available.</param>
        /// <param name="totalRentals">No Metadata Documentation available.</param>
        /// <param name="totalPayments">No Metadata Documentation available.</param>
        public ObjectResult<Vehicle> GetVehiclesWithRentals(Nullable<global::System.DateTime> date, ObjectParameter totalRentals, ObjectParameter totalPayments)
        {
            ObjectParameter dateParameter;
            if (date.HasValue)
            {
                dateParameter = new ObjectParameter("date", date);
            }
            else
            {
                dateParameter = new ObjectParameter("date", typeof(global::System.DateTime));
            }
    
            return base.ExecuteFunction<Vehicle>("GetVehiclesWithRentals", dateParameter, totalRentals, totalPayments);
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        /// <param name="mergeOption"></param>
        /// <param name="date">No Metadata Documentation available.</param>
        /// <param name="totalRentals">No Metadata Documentation available.</param>
        /// <param name="totalPayments">No Metadata Documentation available.</param>
        public ObjectResult<Vehicle> GetVehiclesWithRentals(Nullable<global::System.DateTime> date, ObjectParameter totalRentals, ObjectParameter totalPayments, MergeOption mergeOption)
        {
            ObjectParameter dateParameter;
            if (date.HasValue)
            {
                dateParameter = new ObjectParameter("date", date);
            }
            else
            {
                dateParameter = new ObjectParameter("date", typeof(global::System.DateTime));
            }
    
            return base.ExecuteFunction<Vehicle>("GetVehiclesWithRentals", mergeOption, dateParameter, totalRentals, totalPayments);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="EFRecipesModel", Name="Rental")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Rental : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Rental object.
        /// </summary>
        /// <param name="rentalId">Initial value of the RentalId property.</param>
        /// <param name="rentalDate">Initial value of the RentalDate property.</param>
        /// <param name="payment">Initial value of the Payment property.</param>
        /// <param name="vehicleId">Initial value of the VehicleId property.</param>
        public static Rental CreateRental(global::System.Int32 rentalId, global::System.DateTime rentalDate, global::System.Decimal payment, global::System.Int32 vehicleId)
        {
            Rental rental = new Rental();
            rental.RentalId = rentalId;
            rental.RentalDate = rentalDate;
            rental.Payment = payment;
            rental.VehicleId = vehicleId;
            return rental;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 RentalId
        {
            get
            {
                return _RentalId;
            }
            set
            {
                if (_RentalId != value)
                {
                    OnRentalIdChanging(value);
                    ReportPropertyChanging("RentalId");
                    _RentalId = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("RentalId");
                    OnRentalIdChanged();
                }
            }
        }
        private global::System.Int32 _RentalId;
        partial void OnRentalIdChanging(global::System.Int32 value);
        partial void OnRentalIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime RentalDate
        {
            get
            {
                return _RentalDate;
            }
            set
            {
                OnRentalDateChanging(value);
                ReportPropertyChanging("RentalDate");
                _RentalDate = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("RentalDate");
                OnRentalDateChanged();
            }
        }
        private global::System.DateTime _RentalDate;
        partial void OnRentalDateChanging(global::System.DateTime value);
        partial void OnRentalDateChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Decimal Payment
        {
            get
            {
                return _Payment;
            }
            set
            {
                OnPaymentChanging(value);
                ReportPropertyChanging("Payment");
                _Payment = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Payment");
                OnPaymentChanged();
            }
        }
        private global::System.Decimal _Payment;
        partial void OnPaymentChanging(global::System.Decimal value);
        partial void OnPaymentChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 VehicleId
        {
            get
            {
                return _VehicleId;
            }
            set
            {
                OnVehicleIdChanging(value);
                ReportPropertyChanging("VehicleId");
                _VehicleId = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("VehicleId");
                OnVehicleIdChanged();
            }
        }
        private global::System.Int32 _VehicleId;
        partial void OnVehicleIdChanging(global::System.Int32 value);
        partial void OnVehicleIdChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("EFRecipesModel", "FK_Rental_Vehicle", "Vehicle")]
        public Vehicle Vehicle
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Vehicle>("EFRecipesModel.FK_Rental_Vehicle", "Vehicle").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Vehicle>("EFRecipesModel.FK_Rental_Vehicle", "Vehicle").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Vehicle> VehicleReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Vehicle>("EFRecipesModel.FK_Rental_Vehicle", "Vehicle");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Vehicle>("EFRecipesModel.FK_Rental_Vehicle", "Vehicle", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="EFRecipesModel", Name="Vehicle")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Vehicle : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Vehicle object.
        /// </summary>
        /// <param name="vehicleId">Initial value of the VehicleId property.</param>
        /// <param name="model">Initial value of the Model property.</param>
        /// <param name="manufacturer">Initial value of the Manufacturer property.</param>
        /// <param name="year">Initial value of the Year property.</param>
        public static Vehicle CreateVehicle(global::System.Int32 vehicleId, global::System.String model, global::System.String manufacturer, global::System.Int32 year)
        {
            Vehicle vehicle = new Vehicle();
            vehicle.VehicleId = vehicleId;
            vehicle.Model = model;
            vehicle.Manufacturer = manufacturer;
            vehicle.Year = year;
            return vehicle;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 VehicleId
        {
            get
            {
                return _VehicleId;
            }
            set
            {
                if (_VehicleId != value)
                {
                    OnVehicleIdChanging(value);
                    ReportPropertyChanging("VehicleId");
                    _VehicleId = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("VehicleId");
                    OnVehicleIdChanged();
                }
            }
        }
        private global::System.Int32 _VehicleId;
        partial void OnVehicleIdChanging(global::System.Int32 value);
        partial void OnVehicleIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Model
        {
            get
            {
                return _Model;
            }
            set
            {
                OnModelChanging(value);
                ReportPropertyChanging("Model");
                _Model = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Model");
                OnModelChanged();
            }
        }
        private global::System.String _Model;
        partial void OnModelChanging(global::System.String value);
        partial void OnModelChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Manufacturer
        {
            get
            {
                return _Manufacturer;
            }
            set
            {
                OnManufacturerChanging(value);
                ReportPropertyChanging("Manufacturer");
                _Manufacturer = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Manufacturer");
                OnManufacturerChanged();
            }
        }
        private global::System.String _Manufacturer;
        partial void OnManufacturerChanging(global::System.String value);
        partial void OnManufacturerChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Year
        {
            get
            {
                return _Year;
            }
            set
            {
                OnYearChanging(value);
                ReportPropertyChanging("Year");
                _Year = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Year");
                OnYearChanged();
            }
        }
        private global::System.Int32 _Year;
        partial void OnYearChanging(global::System.Int32 value);
        partial void OnYearChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("EFRecipesModel", "FK_Rental_Vehicle", "Rental")]
        public EntityCollection<Rental> Rentals
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Rental>("EFRecipesModel.FK_Rental_Vehicle", "Rental");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Rental>("EFRecipesModel.FK_Rental_Vehicle", "Rental", value);
                }
            }
        }

        #endregion
    }

    #endregion
    
}
