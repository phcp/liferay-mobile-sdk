/**
 * Copyright (c) 2000-present Liferay, Inc. All rights reserved.
 *
 * This library is free software; you can redistribute it and/or modify it under
 * the terms of the GNU Lesser General Public License as published by the Free
 * Software Foundation; either version 2.1 of the License, or (at your option)
 * any later version.
 *
 * This library is distributed in the hope that it will be useful, but WITHOUT
 * ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS
 * FOR A PARTICULAR PURPOSE. See the GNU Lesser General Public License for more
 * details.
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Liferay.SDK.Service.V62.JournalStructure
{
	public class JournalStructureService : ServiceBase
	{
		public JournalStructureService(ISession session)
			: base(session)
		{
		}

		public async Task<IDictionary<string, object>> AddStructureAsync(long groupId, string structureId, bool autoStructureId, string parentStructureId, IDictionary<string, string> nameMap, IDictionary<string, string> descriptionMap, string xsd, IDictionary<string, object> serviceContext)
		{
			var _parameters = new JsonObject();

			_parameters.Add("groupId", groupId);
			_parameters.Add("structureId", structureId);
			_parameters.Add("autoStructureId", autoStructureId);
			_parameters.Add("parentStructureId", parentStructureId);
			_parameters.Add("nameMap", nameMap);
			_parameters.Add("descriptionMap", descriptionMap);
			_parameters.Add("xsd", xsd);
			_parameters.Add("serviceContext", serviceContext);

			var _command = new JsonObject()
			{
				{ "/journalstructure/add-structure", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			return (IDictionary<string, object>)_obj;
		}

		public async Task<IDictionary<string, object>> CopyStructureAsync(long groupId, string oldStructureId, string newStructureId, bool autoStructureId)
		{
			var _parameters = new JsonObject();

			_parameters.Add("groupId", groupId);
			_parameters.Add("oldStructureId", oldStructureId);
			_parameters.Add("newStructureId", newStructureId);
			_parameters.Add("autoStructureId", autoStructureId);

			var _command = new JsonObject()
			{
				{ "/journalstructure/copy-structure", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			return (IDictionary<string, object>)_obj;
		}

		public async Task DeleteStructureAsync(long groupId, string structureId)
		{
			var _parameters = new JsonObject();

			_parameters.Add("groupId", groupId);
			_parameters.Add("structureId", structureId);

			var _command = new JsonObject()
			{
				{ "/journalstructure/delete-structure", _parameters }
			};

			await this.Session.InvokeAsync(_command);
		}

		public async Task<IDictionary<string, object>> GetStructureAsync(long groupId, string structureId)
		{
			var _parameters = new JsonObject();

			_parameters.Add("groupId", groupId);
			_parameters.Add("structureId", structureId);

			var _command = new JsonObject()
			{
				{ "/journalstructure/get-structure", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			return (IDictionary<string, object>)_obj;
		}

		public async Task<IDictionary<string, object>> GetStructureAsync(long groupId, string structureId, bool includeGlobalStructures)
		{
			var _parameters = new JsonObject();

			_parameters.Add("groupId", groupId);
			_parameters.Add("structureId", structureId);
			_parameters.Add("includeGlobalStructures", includeGlobalStructures);

			var _command = new JsonObject()
			{
				{ "/journalstructure/get-structure", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			return (IDictionary<string, object>)_obj;
		}

		public async Task<IDictionary<string, object>> GetStructuresAsync(long groupId)
		{
			var _parameters = new JsonObject();

			_parameters.Add("groupId", groupId);

			var _command = new JsonObject()
			{
				{ "/journalstructure/get-structures", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			return (IDictionary<string, object>)_obj;
		}

		public async Task<IDictionary<string, object>> GetStructuresAsync(IEnumerable<long> groupIds)
		{
			var _parameters = new JsonObject();

			_parameters.Add("groupIds", groupIds);

			var _command = new JsonObject()
			{
				{ "/journalstructure/get-structures", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			return (IDictionary<string, object>)_obj;
		}

		public async Task<IDictionary<string, object>> SearchAsync(long companyId, IEnumerable<long> groupIds, string keywords, int start, int end, IDictionary<string, object> obc)
		{
			var _parameters = new JsonObject();

			_parameters.Add("companyId", companyId);
			_parameters.Add("groupIds", groupIds);
			_parameters.Add("keywords", keywords);
			_parameters.Add("start", start);
			_parameters.Add("end", end);
			_parameters.Add("obc", obc);

			var _command = new JsonObject()
			{
				{ "/journalstructure/search", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			return (IDictionary<string, object>)_obj;
		}

		public async Task<IDictionary<string, object>> SearchAsync(long companyId, IEnumerable<long> groupIds, string structureId, string name, string description, bool andOperator, int start, int end, IDictionary<string, object> obc)
		{
			var _parameters = new JsonObject();

			_parameters.Add("companyId", companyId);
			_parameters.Add("groupIds", groupIds);
			_parameters.Add("structureId", structureId);
			_parameters.Add("name", name);
			_parameters.Add("description", description);
			_parameters.Add("andOperator", andOperator);
			_parameters.Add("start", start);
			_parameters.Add("end", end);
			_parameters.Add("obc", obc);

			var _command = new JsonObject()
			{
				{ "/journalstructure/search", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			return (IDictionary<string, object>)_obj;
		}

		public async Task<long> SearchCountAsync(long companyId, IEnumerable<long> groupIds, string keywords)
		{
			var _parameters = new JsonObject();

			_parameters.Add("companyId", companyId);
			_parameters.Add("groupIds", groupIds);
			_parameters.Add("keywords", keywords);

			var _command = new JsonObject()
			{
				{ "/journalstructure/search-count", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			return (long)_obj;
		}

		public async Task<long> SearchCountAsync(long companyId, IEnumerable<long> groupIds, string structureId, string name, string description, bool andOperator)
		{
			var _parameters = new JsonObject();

			_parameters.Add("companyId", companyId);
			_parameters.Add("groupIds", groupIds);
			_parameters.Add("structureId", structureId);
			_parameters.Add("name", name);
			_parameters.Add("description", description);
			_parameters.Add("andOperator", andOperator);

			var _command = new JsonObject()
			{
				{ "/journalstructure/search-count", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			return (long)_obj;
		}

		public async Task<IDictionary<string, object>> UpdateStructureAsync(long groupId, string structureId, string parentStructureId, IDictionary<string, string> nameMap, IDictionary<string, string> descriptionMap, string xsd, IDictionary<string, object> serviceContext)
		{
			var _parameters = new JsonObject();

			_parameters.Add("groupId", groupId);
			_parameters.Add("structureId", structureId);
			_parameters.Add("parentStructureId", parentStructureId);
			_parameters.Add("nameMap", nameMap);
			_parameters.Add("descriptionMap", descriptionMap);
			_parameters.Add("xsd", xsd);
			_parameters.Add("serviceContext", serviceContext);

			var _command = new JsonObject()
			{
				{ "/journalstructure/update-structure", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			return (IDictionary<string, object>)_obj;
		}
	}
}