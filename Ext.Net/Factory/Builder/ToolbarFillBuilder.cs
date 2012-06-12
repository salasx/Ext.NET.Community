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
 * @version   : 1.4.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-24
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
    public partial class ToolbarFill
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : ToolbarItem.Builder<ToolbarFill, ToolbarFill.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new ToolbarFill()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(ToolbarFill component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(ToolbarFill.Config config) : base(new ToolbarFill(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(ToolbarFill component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public ToolbarFill.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.ToolbarFill(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public ToolbarFill.Builder ToolbarFill()
        {
            return this.ToolbarFill(new ToolbarFill());
        }

        /// <summary>
        /// 
        /// </summary>
        public ToolbarFill.Builder ToolbarFill(ToolbarFill component)
        {
            return new ToolbarFill.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public ToolbarFill.Builder ToolbarFill(ToolbarFill.Config config)
        {
            return new ToolbarFill.Builder(new ToolbarFill(config));
        }
    }
}