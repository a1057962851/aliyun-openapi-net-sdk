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
using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Ecs.Transform;
using Aliyun.Acs.Ecs.Transform.V20140526;
using System.Collections.Generic;

namespace Aliyun.Acs.Ecs.Model.V20140526
{
    public class DescribeSecurityGroupsRequest : RpcAcsRequest<DescribeSecurityGroupsResponse>
    {
        public DescribeSecurityGroupsRequest()
            : base("Ecs", "2014-05-26", "DescribeSecurityGroups")
        {
        }

		private long? ownerId;

		private string resourceOwnerAccount;

		private long? resourceOwnerId;

		private string vpcId;

		private int? pageNumber;

		private int? pageSize;

		private string ownerAccount;

		private string securityGroupIds;

		private string tag1Key;

		private string tag2Key;

		private string tag3Key;

		private string tag4Key;

		private string tag5Key;

		private string tag1Value;

		private string tag2Value;

		private string tag3Value;

		private string tag4Value;

		private string tag5Value;

		private string networkType;

		private string securityGroupId;

		private string securityGroupName;

		private bool? isQueryEcsCount;

		private bool? fuzzyQuery;

		public long? OwnerId
		{
			get
			{
				return ownerId;
			}
			set	
			{
				ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value.ToString());
			}
		}

		public string ResourceOwnerAccount
		{
			get
			{
				return resourceOwnerAccount;
			}
			set	
			{
				resourceOwnerAccount = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerAccount", value);
			}
		}

		public long? ResourceOwnerId
		{
			get
			{
				return resourceOwnerId;
			}
			set	
			{
				resourceOwnerId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerId", value.ToString());
			}
		}

		public string VpcId
		{
			get
			{
				return vpcId;
			}
			set	
			{
				vpcId = value;
				DictionaryUtil.Add(QueryParameters, "VpcId", value);
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

		public string OwnerAccount
		{
			get
			{
				return ownerAccount;
			}
			set	
			{
				ownerAccount = value;
				DictionaryUtil.Add(QueryParameters, "OwnerAccount", value);
			}
		}

		public string SecurityGroupIds
		{
			get
			{
				return securityGroupIds;
			}
			set	
			{
				securityGroupIds = value;
				DictionaryUtil.Add(QueryParameters, "SecurityGroupIds", value);
			}
		}

		public string Tag1Key
		{
			get
			{
				return tag1Key;
			}
			set	
			{
				tag1Key = value;
				DictionaryUtil.Add(QueryParameters, "Tag.1.Key", value);
			}
		}

		public string Tag2Key
		{
			get
			{
				return tag2Key;
			}
			set	
			{
				tag2Key = value;
				DictionaryUtil.Add(QueryParameters, "Tag.2.Key", value);
			}
		}

		public string Tag3Key
		{
			get
			{
				return tag3Key;
			}
			set	
			{
				tag3Key = value;
				DictionaryUtil.Add(QueryParameters, "Tag.3.Key", value);
			}
		}

		public string Tag4Key
		{
			get
			{
				return tag4Key;
			}
			set	
			{
				tag4Key = value;
				DictionaryUtil.Add(QueryParameters, "Tag.4.Key", value);
			}
		}

		public string Tag5Key
		{
			get
			{
				return tag5Key;
			}
			set	
			{
				tag5Key = value;
				DictionaryUtil.Add(QueryParameters, "Tag.5.Key", value);
			}
		}

		public string Tag1Value
		{
			get
			{
				return tag1Value;
			}
			set	
			{
				tag1Value = value;
				DictionaryUtil.Add(QueryParameters, "Tag.1.Value", value);
			}
		}

		public string Tag2Value
		{
			get
			{
				return tag2Value;
			}
			set	
			{
				tag2Value = value;
				DictionaryUtil.Add(QueryParameters, "Tag.2.Value", value);
			}
		}

		public string Tag3Value
		{
			get
			{
				return tag3Value;
			}
			set	
			{
				tag3Value = value;
				DictionaryUtil.Add(QueryParameters, "Tag.3.Value", value);
			}
		}

		public string Tag4Value
		{
			get
			{
				return tag4Value;
			}
			set	
			{
				tag4Value = value;
				DictionaryUtil.Add(QueryParameters, "Tag.4.Value", value);
			}
		}

		public string Tag5Value
		{
			get
			{
				return tag5Value;
			}
			set	
			{
				tag5Value = value;
				DictionaryUtil.Add(QueryParameters, "Tag.5.Value", value);
			}
		}

		public string NetworkType
		{
			get
			{
				return networkType;
			}
			set	
			{
				networkType = value;
				DictionaryUtil.Add(QueryParameters, "NetworkType", value);
			}
		}

		public string SecurityGroupId
		{
			get
			{
				return securityGroupId;
			}
			set	
			{
				securityGroupId = value;
				DictionaryUtil.Add(QueryParameters, "SecurityGroupId", value);
			}
		}

		public string SecurityGroupName
		{
			get
			{
				return securityGroupName;
			}
			set	
			{
				securityGroupName = value;
				DictionaryUtil.Add(QueryParameters, "SecurityGroupName", value);
			}
		}

		public bool? IsQueryEcsCount
		{
			get
			{
				return isQueryEcsCount;
			}
			set	
			{
				isQueryEcsCount = value;
				DictionaryUtil.Add(QueryParameters, "IsQueryEcsCount", value.ToString());
			}
		}

		public bool? FuzzyQuery
		{
			get
			{
				return fuzzyQuery;
			}
			set	
			{
				fuzzyQuery = value;
				DictionaryUtil.Add(QueryParameters, "FuzzyQuery", value.ToString());
			}
		}

        public override DescribeSecurityGroupsResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return DescribeSecurityGroupsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}