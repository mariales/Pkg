namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: WebhookServiceIntegrationInstallScriptSchema

	/// <exclude/>
	public class WebhookServiceIntegrationInstallScriptSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public WebhookServiceIntegrationInstallScriptSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public WebhookServiceIntegrationInstallScriptSchema(WebhookServiceIntegrationInstallScriptSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("3e37f168-6c97-4719-98a1-60f065e8e0d4");
			Name = "WebhookServiceIntegrationInstallScript";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b87a5b49-8965-4e3b-9f48-2dc1c2176364");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,84,193,110,219,48,12,61,167,64,255,129,243,46,14,16,248,3,218,109,192,154,54,67,14,29,6,120,217,206,138,204,56,218,108,201,144,104,111,65,144,127,31,45,201,105,98,184,219,142,34,249,30,31,201,103,3,104,81,163,107,132,68,248,138,214,10,103,118,148,45,141,222,169,178,181,130,148,209,183,55,199,219,155,89,235,148,46,33,63,56,194,154,243,85,133,178,79,186,236,19,106,180,74,222,159,107,46,105,44,190,22,207,158,52,41,82,232,184,128,75,222,90,44,153,14,150,149,112,238,14,190,227,118,111,204,207,28,109,167,36,174,53,97,25,196,172,181,35,81,85,185,180,170,33,143,108,218,109,165,36,200,30,248,159,56,184,131,245,85,224,233,55,202,150,140,133,163,167,60,171,121,70,218,155,130,245,124,177,170,19,132,33,219,132,7,48,1,113,231,206,168,2,54,77,193,161,207,188,203,149,194,170,72,55,14,45,111,81,135,45,65,123,245,92,48,212,246,43,193,126,7,135,30,53,239,91,207,102,51,191,149,67,46,247,88,139,103,161,69,137,54,86,93,199,222,143,40,179,9,224,253,5,99,36,97,220,4,27,223,144,66,217,131,23,147,190,232,90,140,250,204,3,169,228,203,211,48,133,169,138,111,162,106,145,201,147,120,0,136,23,72,38,202,53,254,58,151,47,45,246,231,129,105,88,39,134,225,89,64,161,188,223,24,197,4,240,168,188,28,97,15,239,2,237,2,204,246,7,107,252,16,23,57,59,66,210,15,144,44,94,244,157,124,230,20,200,213,14,210,55,129,61,91,33,201,253,202,154,250,241,33,29,55,156,207,35,161,69,106,173,14,224,192,20,209,57,18,127,16,109,173,125,151,116,104,59,204,25,87,54,20,139,14,211,16,58,69,179,161,46,130,223,94,51,159,119,120,244,94,112,187,247,92,112,45,254,221,107,131,177,198,6,29,59,50,225,7,9,73,73,148,251,207,122,254,21,124,44,106,165,55,90,13,160,137,129,98,236,50,116,250,3,80,145,90,122,116,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3e37f168-6c97-4719-98a1-60f065e8e0d4"));
		}

		#endregion

	}

	#endregion

}

