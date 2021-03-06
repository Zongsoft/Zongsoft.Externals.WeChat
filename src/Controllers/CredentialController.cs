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
using System.Web.Http;
using System.Threading.Tasks;

namespace Zongsoft.Externals.Wechat.Controllers
{
	public class CredentialController : ApiController
	{
		#region 成员字段
		private ICredentialProvider _provider;
		#endregion

		#region 公共属性
		public ICredentialProvider Provider
		{
			get => _provider;
			set => _provider = value ?? throw new ArgumentNullException();
		}
		#endregion

		#region 公共方法
		[HttpGet]
		public async Task<object> Get(string id)
		{
			return this.Text(await _provider.GetCredentialAsync(id));
		}

		[HttpGet]
		[ActionName("Ticket")]
		public async Task<object> GetTicket(string id)
		{
			return this.Text(await _provider.GetTicketAsync(id));
		}
		#endregion
	}
}
