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

namespace Ext.Net
{
	/// <summary>
    /// The AutoLayout is the default layout manager delegated by Ext.container.Container to render any child Components when no layout is configured into a Container. AutoLayout provides only a passthrough of any layout calls to any child containers.
	/// </summary>
	[Description("")]
    public partial class LayoutConfig : BaseItem
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public LayoutConfig() { }

        /// <summary>
        /// 
        /// </summary>
	    [ConfigOption("type")]
        [DefaultValue("")]
        protected virtual string LayoutType
	    {
	        get
	        {
	            return "";
	        }
	    }

        /// <summary>
        /// An optional extra CSS class that will be added to the container. This can be useful for adding customized styles to the container or any of its children using standard CSS rules. See Ext.Component.ctCls also.
        /// </summary>
        [ConfigOption]
        [DefaultValue("")]
        [Description("An optional extra CSS class that will be added to the container. This can be useful for adding customized styles to the container or any of its children using standard CSS rules. See Ext.Component.ctCls also.")]
        public virtual string ItemCls
        {
            get
            {
                return this.State.Get<string>("ItemCls", "");
            }
            set
            {
                this.State.Set("ItemCls", value);
            }
        }

        /// <summary>
        /// One of the following values:
        /// 0 if the layout should ignore overflow.
        /// 1 if the layout should be rerun if scrollbars are needed.
        /// 2 if the layout should also correct padding when overflowed.
        /// Defaults to: 0
        /// </summary>
        [ConfigOption]
        [DefaultValue(0)]
        [Description("")]
        public virtual int ManageOverflow
        {
            get
            {
                return this.State.Get<int>("ManageOverflow", 0);
            }
            set
            {
                this.State.Set("ManageOverflow", value);
            }
        }

        /// <summary>
        /// Set to true to leave space for a vertical scrollbar (if the OS shows space-consuming scrollbars) regardless of whether a scrollbar is needed.
        /// This is useful if content height changes during application usage, but you do not want the calculated width of child items to change when a scrollbar appears or disappears. The scrollbar will appear in the reserved space, and the calculated width of child Components will not change.
        /// </summary>
        [ConfigOption]
        [DefaultValue(false)]
        [Description("")]
        public virtual bool ReserveScrollbar
        {
            get
            {
                return this.State.Get<bool>("ReserveScrollbar", false);
            }
            set
            {
                this.State.Set("ReserveScrollbar", value);
            }
        }
    }

    /// <summary>
    /// 
    /// </summary>
    [Description("")]
    public partial class LayoutConfigCollection : BaseItemCollection<LayoutConfig>
    {
        /// <summary>
        /// 
        /// </summary>
        [ConfigOption(JsonMode.Object)]
        [Description("")]
        public LayoutConfig Primary
        {
            get
            {
                if (this.Count > 0)
                {
                    return this[0];
                }

                return null;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public LayoutConfigCollection()
        {
            this.SingleItemMode = true;
        }
    }
}