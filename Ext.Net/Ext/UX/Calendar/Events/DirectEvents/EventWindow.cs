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
 ********/using System.ComponentModel;
using System.Web.UI;
using Ext.Net;
using System;

namespace Ext.Net
{
    public partial class EventWindowDirectEvents : WindowDirectEvents
    {
        public EventWindowDirectEvents() { }

        public EventWindowDirectEvents(Observable parent) { this.Parent = parent; }

        private ComponentDirectEvent eventAdd;

        /// <summary>
        /// Fires after a new event is added
        /// </summary>
        [ListenerArgument(0, "item", typeof(CalendarPanel), "Ext.calendar.EventEditWindow")]
        [ListenerArgument(1, "record", typeof(DateTime), "The new record that was added")]
        [ListenerArgument(2, "el", typeof(object), "The target element")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("eventadd", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires after a new event is added")]
        public virtual ComponentDirectEvent EventAdd
        {
            get
            {
                if (this.eventAdd == null)
                {
                    this.eventAdd = new ComponentDirectEvent(this);
                }

                return this.eventAdd;
            }
        }

        private ComponentDirectEvent eventCancel;

        /// <summary>
        /// Fires after an event add/edit operation is canceled by the user and no store update took place
        /// </summary>
        [ListenerArgument(0, "item", typeof(CalendarPanel), "Ext.calendar.EventEditWindow")]
        [ListenerArgument(1, "record", typeof(DateTime), "The new record that was canceled")]
        [ListenerArgument(2, "el", typeof(object), "The target element")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("eventcancel", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires after an event add/edit operation is canceled by the user and no store update took place")]
        public virtual ComponentDirectEvent EventCancel
        {
            get
            {
                if (this.eventCancel == null)
                {
                    this.eventCancel = new ComponentDirectEvent(this);
                }

                return this.eventCancel;
            }
        }

        private ComponentDirectEvent eventDelete;

        /// <summary>
        /// Fires after an event is deleted
        /// </summary>
        [ListenerArgument(0, "item", typeof(CalendarPanel), "Ext.calendar.EventEditWindow")]
        [ListenerArgument(1, "record", typeof(DateTime), "The new record that was deleted")]
        [ListenerArgument(2, "el", typeof(object), "The target element")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("eventdelete", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires after an event is deleted")]
        public virtual ComponentDirectEvent EventDelete
        {
            get
            {
                if (this.eventDelete == null)
                {
                    this.eventDelete = new ComponentDirectEvent(this);
                }

                return this.eventDelete;
            }
        }

        private ComponentDirectEvent eventUpdate;

        /// <summary>
        /// Fires after an existing event is updated
        /// </summary>
        [ListenerArgument(0, "item", typeof(CalendarPanel), "Ext.calendar.EventEditWindow")]
        [ListenerArgument(1, "record", typeof(DateTime), "The new record that was updated")]
        [ListenerArgument(2, "el", typeof(object), "The target element")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("eventupdate", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires after an existing event is updated")]
        public virtual ComponentDirectEvent EventUpdate
        {
            get
            {
                if (this.eventUpdate == null)
                {
                    this.eventUpdate = new ComponentDirectEvent(this);
                }

                return this.eventUpdate;
            }
        }

        private ComponentDirectEvent editDetails;

        /// <summary>
        /// Fires when the user selects the option in this window to continue editing in the detailed edit form (by default, an instance of Ext.calendar.EventEditForm. Handling code should hide this window and transfer the current event record to the appropriate instance of the detailed form by showing it and calling loadRecord.
        /// </summary>
        [ListenerArgument(0, "item", typeof(CalendarPanel), "Ext.calendar.EventEditWindow")]
        [ListenerArgument(1, "record", typeof(DateTime), "The record that is currently being edited")]
        [ListenerArgument(2, "el", typeof(object), "The target element")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("editdetails", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires when the user selects the option in this window to continue editing in the detailed edit form (by default, an instance of Ext.calendar.EventEditForm. Handling code should hide this window and transfer the current event record to the appropriate instance of the detailed form by showing it and calling loadRecord.")]
        public virtual ComponentDirectEvent EditDetails
        {
            get
            {
                if (this.editDetails == null)
                {
                    this.editDetails = new ComponentDirectEvent(this);
                }

                return this.editDetails;
            }
        }
    }
}