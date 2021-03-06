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
    public partial class DateFilter
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Builder<TDateFilter, TBuilder> : GridFilter.Builder<TDateFilter, TBuilder>
            where TDateFilter : DateFilter
            where TBuilder : Builder<TDateFilter, TBuilder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder(TDateFilter component) : base(component) { }


			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// The text displayed for the 'Before' menu item
			/// </summary>
            public virtual TBuilder BeforeText(string beforeText)
            {
                this.ToComponent().BeforeText = beforeText;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// The text displayed for the 'After' menu item
			/// </summary>
            public virtual TBuilder AfterText(string afterText)
            {
                this.ToComponent().AfterText = afterText;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// The text displayed for the 'On' menu item
			/// </summary>
            public virtual TBuilder OnText(string onText)
            {
                this.ToComponent().OnText = onText;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// The default date format string which can be overriden for localization support. The format must be valid according to Date.parseDate (defaults to 'd').
			/// </summary>
            public virtual TBuilder Format(string format)
            {
                this.ToComponent().Format = format;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// 
 			/// </summary>
 			/// <param name="action">The action delegate</param>
 			/// <returns>An instance of TBuilder</returns>
            public virtual TBuilder DatePickerOptions(Action<DatePickerOptions> action)
            {
                action(this.ToComponent().DatePickerOptions);
                return this as TBuilder;
            }
			 
 			/// <summary>
			/// Allowable date as passed to the Ext.DatePicker
			/// </summary>
            public virtual TBuilder MaxDate(DateTime maxDate)
            {
                this.ToComponent().MaxDate = maxDate;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// Allowable date as passed to the Ext.DatePicker
			/// </summary>
            public virtual TBuilder MinDate(DateTime minDate)
            {
                this.ToComponent().MinDate = minDate;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// Predefined filter value
			/// </summary>
            public virtual TBuilder BeforeValue(DateTime? beforeValue)
            {
                this.ToComponent().BeforeValue = beforeValue;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// Predefined filter value
			/// </summary>
            public virtual TBuilder AfterValue(DateTime? afterValue)
            {
                this.ToComponent().AfterValue = afterValue;
                return this as TBuilder;
            }
             
 			/// <summary>
			/// Predefined filter value
			/// </summary>
            public virtual TBuilder OnValue(DateTime? onValue)
            {
                this.ToComponent().OnValue = onValue;
                return this as TBuilder;
            }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }
		
		/// <summary>
        /// 
        /// </summary>
        public partial class Builder : DateFilter.Builder<DateFilter, DateFilter.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new DateFilter()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(DateFilter component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(DateFilter.Config config) : base(new DateFilter(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(DateFilter component)
            {
                return component.ToBuilder();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public DateFilter.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.DateFilter(this);
		}
		
		/// <summary>
        /// 
        /// </summary>
        public override IControlBuilder ToNativeBuilder()
		{
			return (IControlBuilder)this.ToBuilder();
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public DateFilter.Builder DateFilter()
        {
#if MVC
			return this.DateFilter(new DateFilter { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return this.DateFilter(new DateFilter());
#endif			
        }

        /// <summary>
        /// 
        /// </summary>
        public DateFilter.Builder DateFilter(DateFilter component)
        {
#if MVC
			component.ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null;
#endif			
			return new DateFilter.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public DateFilter.Builder DateFilter(DateFilter.Config config)
        {
#if MVC
			return new DateFilter.Builder(new DateFilter(config) { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return new DateFilter.Builder(new DateFilter(config));
#endif			
        }
    }
}