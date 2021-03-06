/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System.Collections.Generic;
using Newtonsoft.Json;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.dms_enterprise;
using Aliyun.Acs.dms_enterprise.Transform;
using Aliyun.Acs.dms_enterprise.Transform.V20181101;

namespace Aliyun.Acs.dms_enterprise.Model.V20181101
{
    public class ListOrdersRequest : RpcAcsRequest<ListOrdersResponse>
    {
        public ListOrdersRequest()
            : base("dms-enterprise", "2018-11-01", "ListOrders")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private string orderStatus;

		private string searchContent;

		private string searchDateType;

		private string endTime;

		private string startTime;

		private long? tid;

		private int? pageNumber;

		private string pluginType;

		private int? pageSize;

		private string orderResultType;

		public string OrderStatus
		{
			get
			{
				return orderStatus;
			}
			set	
			{
				orderStatus = value;
				DictionaryUtil.Add(QueryParameters, "OrderStatus", value);
			}
		}

		public string SearchContent
		{
			get
			{
				return searchContent;
			}
			set	
			{
				searchContent = value;
				DictionaryUtil.Add(QueryParameters, "SearchContent", value);
			}
		}

		public string SearchDateType
		{
			get
			{
				return searchDateType;
			}
			set	
			{
				searchDateType = value;
				DictionaryUtil.Add(QueryParameters, "SearchDateType", value);
			}
		}

		public string EndTime
		{
			get
			{
				return endTime;
			}
			set	
			{
				endTime = value;
				DictionaryUtil.Add(QueryParameters, "EndTime", value);
			}
		}

		public string StartTime
		{
			get
			{
				return startTime;
			}
			set	
			{
				startTime = value;
				DictionaryUtil.Add(QueryParameters, "StartTime", value);
			}
		}

		public long? Tid
		{
			get
			{
				return tid;
			}
			set	
			{
				tid = value;
				DictionaryUtil.Add(QueryParameters, "Tid", value.ToString());
			}
		}

		public int? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
				DictionaryUtil.Add(QueryParameters, "PageNumber", value.ToString());
			}
		}

		public string PluginType
		{
			get
			{
				return pluginType;
			}
			set	
			{
				pluginType = value;
				DictionaryUtil.Add(QueryParameters, "PluginType", value);
			}
		}

		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
				DictionaryUtil.Add(QueryParameters, "PageSize", value.ToString());
			}
		}

		public string OrderResultType
		{
			get
			{
				return orderResultType;
			}
			set	
			{
				orderResultType = value;
				DictionaryUtil.Add(QueryParameters, "OrderResultType", value);
			}
		}

        public override ListOrdersResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListOrdersResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
