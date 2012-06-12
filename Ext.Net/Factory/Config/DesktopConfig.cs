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
 * @version   : 2.0.0.beta3 - Community Edition (AGPLv3 License)
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-28
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : GNU AFFERO GENERAL PUBLIC LICENSE (AGPL) 3.0. 
 *              See license.txt and http://www.ext.net/license/.
 *              See AGPL License at http://www.gnu.org/licenses/agpl-3.0.txt
 ********/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ext.Net
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Desktop
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public Desktop(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit Desktop.Config Conversion to Desktop
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Desktop(Desktop.Config config)
        {
            return new Desktop(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : Observable.Config 
        { 
			/*  Implicit Desktop.Config Conversion to Desktop.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator Desktop.Builder(Desktop.Config config)
			{
				return new Desktop.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			        
			private DesktopModulesCollection modules = null;

			/// <summary>
			/// 
			/// </summary>
			public DesktopModulesCollection Modules
			{
				get
				{
					if (this.modules == null)
					{
						this.modules = new DesktopModulesCollection();
					}
			
					return this.modules;
				}
			}
			
			private DesktopConfig desktopConfig = null;

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue(null)]
			public virtual DesktopConfig DesktopConfig 
			{ 
				get
				{
					return this.desktopConfig;
				}
				set
				{
					this.desktopConfig = value;
				}
			}

			private DesktopStartMenu startMenu = null;

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue(null)]
			public virtual DesktopStartMenu StartMenu 
			{ 
				get
				{
					return this.startMenu;
				}
				set
				{
					this.startMenu = value;
				}
			}

			private DesktopTaskBar taskBar = null;

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue(null)]
			public virtual DesktopTaskBar TaskBar 
			{ 
				get
				{
					return this.taskBar;
				}
				set
				{
					this.taskBar = value;
				}
			}
        
			private DesktopListeners listeners = null;

			/// <summary>
			/// Client-side JavaScript Event Handlers
			/// </summary>
			public DesktopListeners Listeners
			{
				get
				{
					if (this.listeners == null)
					{
						this.listeners = new DesktopListeners();
					}
			
					return this.listeners;
				}
			}
			        
			private DesktopDirectEvents directEvents = null;

			/// <summary>
			/// Server-side DirectEventHandlers
			/// </summary>
			public DesktopDirectEvents DirectEvents
			{
				get
				{
					if (this.directEvents == null)
					{
						this.directEvents = new DesktopDirectEvents();
					}
			
					return this.directEvents;
				}
			}
			
        }
    }
}