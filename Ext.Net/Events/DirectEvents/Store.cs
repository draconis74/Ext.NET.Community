/********
 * This file is part of Ext.NET.
 *     
 * Ext.NET is free software: you can redistribute it and/or modify
 * it under the terms of the GNU AFFERO GENERAL PUBLIC LICENSE as 
 * published by the Free Software Foundation, either version 3 of the 
 * License, or (at your option) any later version.
 * 
 * Ext.NET is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU AFFERO GENERAL PUBLIC LICENSE for more details.
 * 
 * You should have received a copy of the GNU AFFERO GENERAL PUBLIC LICENSE
 * along with Ext.NET.  If not, see <http://www.gnu.org/licenses/>.
 *
 *
 * @version   : 2.1.0 - Ext.NET Community License (AGPLv3 License)
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-11-21
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : GNU AFFERO GENERAL PUBLIC LICENSE (AGPL) 3.0. 
 *              See license.txt and http://www.ext.net/license/.
 *              See AGPL License at http://www.gnu.org/licenses/agpl-3.0.txt
 ********/

using System.ComponentModel;
using System.Web.UI;

namespace Ext.Net
{
    /// <summary>
    /// 
    /// </summary>
    public partial class StoreDirectEvents : AbstractStoreDirectEvents
    {
        public StoreDirectEvents() { }

        public StoreDirectEvents(Observable parent) { this.Parent = parent; }

        private ComponentDirectEvent beforePrefetch;

        /// <summary>
        /// Fires before a prefetch occurs. Return false to cancel.
        /// Parameters
        /// store : Ext.data.store
        /// operation : Ext.data.Operation
        /// The associated operation
        /// </summary>
        [ListenerArgument(0, "store", typeof(Store), "this")]
        [ListenerArgument(1, "operation", typeof(object), "Ext.data.Operation")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("beforeprefetch", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires before a prefetch occurs. Return false to cancel.")]
        public virtual ComponentDirectEvent BeforePrefetch
        {
            get
            {
                return this.beforePrefetch ?? (this.beforePrefetch = new ComponentDirectEvent(this));
            }
        }

        private ComponentDirectEvent groupChange;

        /// <summary>
        /// Fired whenever the grouping in the grid changes
        /// Parameters
        /// store : Ext.data.Store
        /// The store
        ///
        /// groupers : Array
        /// The array of grouper objects
        /// </summary>
        [ListenerArgument(0, "store", typeof(Store), "this")]
        [ListenerArgument(1, "groupers", typeof(object), "The array of grouper objects")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("groupchange", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fired whenever the grouping in the grid changes")]
        public virtual ComponentDirectEvent GroupChange
        {
            get
            {
                return this.groupChange ?? (this.groupChange = new ComponentDirectEvent(this));
            }
        }

        private ComponentDirectEvent prefetch;

        /// <summary>
        /// Fires whenever records have been prefetched
        /// Parameters
        /// store : Ext.data.Store
        /// records : Array
        /// An array of records
        /// successful : Boolean
        /// True if the operation was successful.
        /// operation : Ext.data.Operation
        /// The associated operation
        /// </summary>
        [ListenerArgument(0, "store", typeof(Store), "this")]
        [ListenerArgument(1, "records", typeof(object), "The Records that were loaded")]
        [ListenerArgument(2, "successful", typeof(object), "True if the operation was successful.")]
        [ListenerArgument(3, "operation", typeof(object), "The associated operation")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("prefetch", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires whenever records have been prefetched")]
        public virtual ComponentDirectEvent Prefetch
        {
            get
            {
                return this.prefetch ?? (this.prefetch = new ComponentDirectEvent(this));
            }
        }

        private ComponentDirectEvent totalcountchange;

        /// <summary>
        /// 
        /// </summary>
        [ListenerArgument(0, "totalCount")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("totalcountchange", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("")]
        public virtual ComponentDirectEvent TotalCountChange
        {
            get
            {
                return this.totalcountchange ?? (this.totalcountchange = new ComponentDirectEvent(this));
            }
        }
    }
}