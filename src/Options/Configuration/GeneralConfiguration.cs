﻿/*
 *   _____                                ______
 *  /_   /  ____  ____  ____  _________  / __/ /_
 *    / /  / __ \/ __ \/ __ \/ ___/ __ \/ /_/ __/
 *   / /__/ /_/ / / / / /_/ /\_ \/ /_/ / __/ /_
 *  /____/\____/_/ /_/\__  /____/\____/_/  \__/
 *                   /____/
 *
 * Authors:
 *   钟峰(Popeye Zhong) <zongsoft@qq.com>
 *
 * Copyright (C) 2018-2019 Zongsoft Corporation <http://www.zongsoft.com>
 *
 * This file is part of Zongsoft.Externals.Wechat.
 *
 * Zongsoft.Externals.Wechat is free software; you can redistribute it and/or
 * modify it under the terms of the GNU Lesser General Public
 * License as published by the Free Software Foundation; either
 * version 2.1 of the License, or (at your option) any later version.
 *
 * Zongsoft.Externals.Wechat is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU
 * Lesser General Public License for more details.
 *
 * The above copyright notice and this permission notice shall be
 * included in all copies or substantial portions of the Software.
 *
 * You should have received a copy of the GNU Lesser General Public
 * License along with Zongsoft.Externals.Wechat; if not, write to the Free Software
 * Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA 02110-1301 USA
 */

using System;

using Zongsoft.Options;
using Zongsoft.Options.Configuration;

namespace Zongsoft.Externals.Wechat.Options.Configuration
{
	public class GeneralConfiguration : OptionConfigurationElement, IConfiguration
	{
		#region 常量定义
		private const string XML_APPS_COLLECTION = "apps";
		#endregion

		#region 公共属性
		[OptionConfigurationProperty(XML_APPS_COLLECTION)]
		public AppElementCollection Apps
		{
			get
			{
				return (AppElementCollection)this[XML_APPS_COLLECTION];
			}
		}
		#endregion

		#region 显式实现
		IAppSettingCollection IConfiguration.Apps
		{
			get
			{
				return this.Apps;
			}
		}
		#endregion

	}
}
