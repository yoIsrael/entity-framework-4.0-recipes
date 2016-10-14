//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.EntityClient;

namespace TrainReservation
{
    public partial class EFRecipesEntities : ObjectContext, IReservationContext
    {
        public const string ConnectionString = "name=EFRecipesEntities";
        public const string ContainerName = "EFRecipesEntities";
    
        #region Constructors
    
        public EFRecipesEntities()
            : base(ConnectionString, ContainerName)
        {
            this.ContextOptions.LazyLoadingEnabled = true;
        }
    
        public EFRecipesEntities(string connectionString)
            : base(connectionString, ContainerName)
        {
            this.ContextOptions.LazyLoadingEnabled = true;
        }
    
        public EFRecipesEntities(EntityConnection connection)
            : base(connection, ContainerName)
        {
            this.ContextOptions.LazyLoadingEnabled = true;
        }
    
        #endregion
    
        #region ObjectSet Properties
    
        public IObjectSet<Reservation> Reservations
        {
            get { return _reservations  ?? (_reservations = CreateObjectSet<Reservation>("Reservations")); }
        }
        private IObjectSet<Reservation> _reservations;
    
        public IObjectSet<Schedule> Schedules
        {
            get { return _schedules  ?? (_schedules = CreateObjectSet<Schedule>("Schedules")); }
        }
        private IObjectSet<Schedule> _schedules;
    
        public IObjectSet<Train> Trains
        {
            get { return _trains  ?? (_trains = CreateObjectSet<Train>("Trains")); }
        }
        private IObjectSet<Train> _trains;

        #endregion
    }
}