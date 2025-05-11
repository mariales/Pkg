namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: UpdateSysSettingsForExternalUsersInstallScriptExecutorSchema

	/// <exclude/>
	public class UpdateSysSettingsForExternalUsersInstallScriptExecutorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public UpdateSysSettingsForExternalUsersInstallScriptExecutorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public UpdateSysSettingsForExternalUsersInstallScriptExecutorSchema(UpdateSysSettingsForExternalUsersInstallScriptExecutorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("0e1be858-f9fe-4d6b-a4d3-b2c71df20e6b");
			Name = "UpdateSysSettingsForExternalUsersInstallScriptExecutor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("1296b383-c2ef-47b8-ae67-0601cddb70e1");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,181,85,219,110,226,48,16,125,78,165,254,131,197,83,42,33,62,96,123,145,202,173,139,68,81,181,129,190,15,206,36,241,202,177,179,182,19,26,33,254,125,199,132,176,148,165,79,164,82,110,246,156,57,115,209,228,88,65,142,182,0,142,108,137,198,128,213,137,27,140,180,74,68,90,26,112,66,171,219,155,237,237,77,80,90,161,82,22,213,214,97,78,118,41,145,123,163,29,188,160,66,35,248,253,17,115,74,99,240,171,253,193,68,57,225,4,90,2,16,164,40,215,82,112,198,37,88,203,86,69,12,14,41,86,132,206,145,171,157,106,51,249,112,104,20,200,149,69,99,103,202,58,144,50,226,70,20,110,242,129,188,116,218,252,96,179,139,251,196,190,221,199,104,131,84,90,196,172,177,98,232,249,168,92,213,148,195,202,79,203,59,230,75,15,130,10,12,179,255,210,153,11,235,30,153,194,13,243,95,15,99,177,7,131,169,31,172,51,4,232,51,189,254,77,12,79,79,7,255,192,99,191,134,181,168,96,203,122,35,29,99,175,207,122,175,66,189,81,47,54,218,196,115,84,169,203,122,187,6,180,235,119,64,25,21,200,5,200,81,6,84,109,169,92,167,228,139,50,247,19,241,61,228,115,189,65,195,193,226,247,208,175,138,162,115,122,26,177,5,110,162,12,165,188,158,172,77,244,39,77,158,54,245,47,228,180,232,46,209,23,173,83,137,75,72,95,65,65,138,166,19,210,41,84,130,107,53,53,58,63,249,169,175,167,30,11,11,107,137,207,113,5,138,99,252,46,108,9,114,146,36,132,239,128,253,56,206,218,77,254,16,241,82,123,173,152,235,84,168,235,201,167,66,162,151,52,101,189,136,142,81,213,94,74,58,233,246,24,19,40,165,27,26,189,161,124,73,11,73,172,215,96,34,87,75,60,111,203,238,126,255,74,72,144,129,103,44,252,44,116,36,132,177,216,203,162,80,231,250,215,74,99,176,215,241,250,196,124,216,120,60,211,210,70,240,235,136,103,152,195,97,186,232,240,112,205,246,176,94,208,57,20,246,78,231,163,127,174,198,77,178,129,72,88,120,30,110,48,69,199,51,63,97,227,97,120,161,130,187,99,190,193,127,174,180,162,3,173,204,213,59,200,146,114,152,217,40,122,123,174,64,72,63,93,148,134,51,37,182,193,47,184,67,133,97,107,110,218,187,127,250,7,221,116,253,5,199,237,107,136,99,7,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0e1be858-f9fe-4d6b-a4d3-b2c71df20e6b"));
		}

		#endregion

	}

	#endregion

}

