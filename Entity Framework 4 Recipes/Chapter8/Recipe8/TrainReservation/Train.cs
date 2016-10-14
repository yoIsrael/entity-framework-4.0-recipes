//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace TrainReservation
{
    public partial class Train
    {
        #region Primitive Properties
    
        public virtual int TrainId
        {
            get;
            set;
        }
    
        public virtual string TrainName
        {
            get;
            set;
        }

        #endregion
        #region Navigation Properties
    
        public virtual ICollection<Schedule> Schedules
        {
            get
            {
                if (_schedules == null)
                {
                    var newCollection = new FixupCollection<Schedule>();
                    newCollection.CollectionChanged += FixupSchedules;
                    _schedules = newCollection;
                }
                return _schedules;
            }
            set
            {
                if (!ReferenceEquals(_schedules, value))
                {
                    var previousValue = _schedules as FixupCollection<Schedule>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupSchedules;
                    }
                    _schedules = value;
                    var newValue = value as FixupCollection<Schedule>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupSchedules;
                    }
                }
            }
        }
        private ICollection<Schedule> _schedules;

        #endregion
        #region Association Fixup
    
        private void FixupSchedules(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (Schedule item in e.NewItems)
                {
                    item.Train = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (Schedule item in e.OldItems)
                {
                    if (ReferenceEquals(item.Train, this))
                    {
                        item.Train = null;
                    }
                }
            }
        }

        #endregion
    }
}
