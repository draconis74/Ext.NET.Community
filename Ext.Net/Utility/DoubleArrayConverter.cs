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
using System.ComponentModel;
using System.Globalization;

using Ext.Net.Utilities;

namespace Ext.Net
{
    // REFERENCE: http://msdn2.microsoft.com/en-us/library/ayybcxe5.aspx
    class DoubleArrayConverter : TypeConverter
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
            return (sourceType == typeof(string));
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
        {
            if (value == null)
            {
                return null;
            }

            if (value is string)
            {
                string[] list = ((string)value).Split(',');
                double[] items = new double[list.Length];

                for(int i = 0; i < list.Length; i++)
                {
                    items[i] = Convert.ToDouble(list[i], System.Globalization.CultureInfo.InvariantCulture);
                }

                return items;
            }

            return base.ConvertFrom(context, culture, value);
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
        {
            if (destinationType != typeof(string))
            {
                throw base.GetConvertToException(value, destinationType);
            }
            if (value == null)
            {
                return null;
            }

            return ((double[])value).Join();
        }
    }
}