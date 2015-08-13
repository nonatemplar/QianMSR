using ScopeRuntime;
using Microsoft.SCOPE.Types;
using Microsoft.SCOPE.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;
using System.Runtime.Serialization;
using System.Linq;
using System.Runtime.Versioning;
[assembly:TargetFramework(".NETFramework,Version=v4.5", FrameworkDisplayName = ".NET Framework, Version 4.5")]

public class ___Scope_Generated_Classes___
{
	public static int __RuntimeVersion__ = 0;
	public static int __WriteSStreamVersion__ = 3;
	public static bool __BondIntermediates__ = false;
	private delegate ColumnData ColumnDataCtor();
#region ==BEGIN USER CODE==
#endregion ==END USER CODE==

	public class Row_FCBEBA9BE66EF92B : Row
	{
		private static readonly System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>[] _columnTable = 
		{
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("SubscriptionGUID", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("DeploymentGUID", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("DeploymentName", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("DeploymentCreateTimestamp", ColumnDataType.DateTimeQ, typeof(DateTime?), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("HostedServiceName", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("FabricGeoId", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("DeploymentType", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("IsSystemDeployment", ColumnDataType.IntegerQ, typeof(int?), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("DeploymentCSSInfoLastUpdated", ColumnDataType.DateTimeQ, typeof(DateTime?), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("DeploymentCurrentUpdateDomain", ColumnDataType.IntegerQ, typeof(int?), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("DeploymentCurrentUpgradeDomain", ColumnDataType.IntegerQ, typeof(int?), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("DeploymentCurrentUpgradeDomainState", ColumnDataType.IntegerQ, typeof(int?), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("DeploymentDescription", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("DeploymentDNSGuid", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("DeploymentDNSName", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("DeploymentFabricTenantStatus", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("DeploymentGroup", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("DeploymentHost", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("DeploymentInputEndpoints", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("DeploymentKind", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("DeploymentLabel", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("DeploymentLastChangingOperationId", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("DeploymentLastChangingOperationStarted", ColumnDataType.DateTimeQ, typeof(DateTime?), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("DeploymentLastServiceHealingTime", ColumnDataType.DateTimeQ, typeof(DateTime?), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("DeploymentLastUpdated", ColumnDataType.DateTimeQ, typeof(DateTime?), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("DeploymentLastVipSwapFailed", ColumnDataType.BooleanQ, typeof(bool?), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("DeploymentLastVipSwapFailedTime", ColumnDataType.DateTimeQ, typeof(DateTime?), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("DeploymentNumUpgradeDomains", ColumnDataType.IntegerQ, typeof(int?), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("DeploymentOsUpgradePolicy", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("DeploymentOsVersion", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("DeploymentProgressStatus", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("DeploymentRoleInstanceDetails", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("DeploymentRoleObjects", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("DeploymentRoles", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("DeploymentRolesCSSInfoLastUpdated", ColumnDataType.DateTimeQ, typeof(DateTime?), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("DeploymentRolesLastUpdated", ColumnDataType.DateTimeQ, typeof(DateTime?), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("DeploymentRolesSupportInfoLastUpdated", ColumnDataType.DateTimeQ, typeof(DateTime?), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("DeploymentRoleToUpgrade", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("DeploymentServiceHealingEnabled", ColumnDataType.BooleanQ, typeof(bool?), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("DeploymentServiceInstanceCount", ColumnDataType.IntegerQ, typeof(int?), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("DeploymentSettings", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("DeploymentStatus", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("DeploymentSupportInfoLastUpdated", ColumnDataType.DateTimeQ, typeof(DateTime?), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("DeploymentTransitionStatus", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("DeploymentUpdateInProgress", ColumnDataType.BooleanQ, typeof(bool?), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("DeploymentUpdateType", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("DeploymentVIP", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("DeploymentVIPIPv6", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("DeploymentWeightedNumberOfExtraSmallRoleInstances", ColumnDataType.IntegerQ, typeof(int?), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("DeploymentWeightedNumberOfRoleInstances", ColumnDataType.IntegerQ, typeof(int?), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("FqdnSuffix", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("IS_Current", ColumnDataType.BooleanQ, typeof(bool?), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("MigratedFrom", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("PackageRequiredFeatures", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("PersistentVMs", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("RoleOsMap", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("SCD_EndDate", ColumnDataType.DateTimeQ, typeof(DateTime?), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("SCD_StartDate", ColumnDataType.DateTimeQ, typeof(DateTime?), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("SdkVersion", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("TimeMigrated", ColumnDataType.DateTimeQ, typeof(DateTime?), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("endpoint", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("SourceTableName", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("AuditCreateDate", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("AuditUpdateDate", ColumnDataType.String, typeof(string), null),
		};
		ScopeRuntime.StringColumnData s0_SubscriptionGUID;
		public ScopeRuntime.StringColumnData SubscriptionGUID
		{
			get { return s0_SubscriptionGUID; }
			set
			{
				s0_SubscriptionGUID = value;
				_columns[0] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_DeploymentGUID;
		public ScopeRuntime.StringColumnData DeploymentGUID
		{
			get { return s0_DeploymentGUID; }
			set
			{
				s0_DeploymentGUID = value;
				_columns[1] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_DeploymentName;
		public ScopeRuntime.StringColumnData DeploymentName
		{
			get { return s0_DeploymentName; }
			set
			{
				s0_DeploymentName = value;
				_columns[2] = value;
			}
		}
		ScopeRuntime.DateTimeQColumnData s0_DeploymentCreateTimestamp;
		public ScopeRuntime.DateTimeQColumnData DeploymentCreateTimestamp
		{
			get { return s0_DeploymentCreateTimestamp; }
			set
			{
				s0_DeploymentCreateTimestamp = value;
				_columns[3] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_HostedServiceName;
		public ScopeRuntime.StringColumnData HostedServiceName
		{
			get { return s0_HostedServiceName; }
			set
			{
				s0_HostedServiceName = value;
				_columns[4] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_FabricGeoId;
		public ScopeRuntime.StringColumnData FabricGeoId
		{
			get { return s0_FabricGeoId; }
			set
			{
				s0_FabricGeoId = value;
				_columns[5] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_DeploymentType;
		public ScopeRuntime.StringColumnData DeploymentType
		{
			get { return s0_DeploymentType; }
			set
			{
				s0_DeploymentType = value;
				_columns[6] = value;
			}
		}
		ScopeRuntime.IntegerQColumnData s0_IsSystemDeployment;
		public ScopeRuntime.IntegerQColumnData IsSystemDeployment
		{
			get { return s0_IsSystemDeployment; }
			set
			{
				s0_IsSystemDeployment = value;
				_columns[7] = value;
			}
		}
		ScopeRuntime.DateTimeQColumnData s0_DeploymentCSSInfoLastUpdated;
		public ScopeRuntime.DateTimeQColumnData DeploymentCSSInfoLastUpdated
		{
			get { return s0_DeploymentCSSInfoLastUpdated; }
			set
			{
				s0_DeploymentCSSInfoLastUpdated = value;
				_columns[8] = value;
			}
		}
		ScopeRuntime.IntegerQColumnData s0_DeploymentCurrentUpdateDomain;
		public ScopeRuntime.IntegerQColumnData DeploymentCurrentUpdateDomain
		{
			get { return s0_DeploymentCurrentUpdateDomain; }
			set
			{
				s0_DeploymentCurrentUpdateDomain = value;
				_columns[9] = value;
			}
		}
		ScopeRuntime.IntegerQColumnData s0_DeploymentCurrentUpgradeDomain;
		public ScopeRuntime.IntegerQColumnData DeploymentCurrentUpgradeDomain
		{
			get { return s0_DeploymentCurrentUpgradeDomain; }
			set
			{
				s0_DeploymentCurrentUpgradeDomain = value;
				_columns[10] = value;
			}
		}
		ScopeRuntime.IntegerQColumnData s0_DeploymentCurrentUpgradeDomainState;
		public ScopeRuntime.IntegerQColumnData DeploymentCurrentUpgradeDomainState
		{
			get { return s0_DeploymentCurrentUpgradeDomainState; }
			set
			{
				s0_DeploymentCurrentUpgradeDomainState = value;
				_columns[11] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_DeploymentDescription;
		public ScopeRuntime.StringColumnData DeploymentDescription
		{
			get { return s0_DeploymentDescription; }
			set
			{
				s0_DeploymentDescription = value;
				_columns[12] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_DeploymentDNSGuid;
		public ScopeRuntime.StringColumnData DeploymentDNSGuid
		{
			get { return s0_DeploymentDNSGuid; }
			set
			{
				s0_DeploymentDNSGuid = value;
				_columns[13] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_DeploymentDNSName;
		public ScopeRuntime.StringColumnData DeploymentDNSName
		{
			get { return s0_DeploymentDNSName; }
			set
			{
				s0_DeploymentDNSName = value;
				_columns[14] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_DeploymentFabricTenantStatus;
		public ScopeRuntime.StringColumnData DeploymentFabricTenantStatus
		{
			get { return s0_DeploymentFabricTenantStatus; }
			set
			{
				s0_DeploymentFabricTenantStatus = value;
				_columns[15] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_DeploymentGroup;
		public ScopeRuntime.StringColumnData DeploymentGroup
		{
			get { return s0_DeploymentGroup; }
			set
			{
				s0_DeploymentGroup = value;
				_columns[16] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_DeploymentHost;
		public ScopeRuntime.StringColumnData DeploymentHost
		{
			get { return s0_DeploymentHost; }
			set
			{
				s0_DeploymentHost = value;
				_columns[17] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_DeploymentInputEndpoints;
		public ScopeRuntime.StringColumnData DeploymentInputEndpoints
		{
			get { return s0_DeploymentInputEndpoints; }
			set
			{
				s0_DeploymentInputEndpoints = value;
				_columns[18] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_DeploymentKind;
		public ScopeRuntime.StringColumnData DeploymentKind
		{
			get { return s0_DeploymentKind; }
			set
			{
				s0_DeploymentKind = value;
				_columns[19] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_DeploymentLabel;
		public ScopeRuntime.StringColumnData DeploymentLabel
		{
			get { return s0_DeploymentLabel; }
			set
			{
				s0_DeploymentLabel = value;
				_columns[20] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_DeploymentLastChangingOperationId;
		public ScopeRuntime.StringColumnData DeploymentLastChangingOperationId
		{
			get { return s0_DeploymentLastChangingOperationId; }
			set
			{
				s0_DeploymentLastChangingOperationId = value;
				_columns[21] = value;
			}
		}
		ScopeRuntime.DateTimeQColumnData s0_DeploymentLastChangingOperationStarted;
		public ScopeRuntime.DateTimeQColumnData DeploymentLastChangingOperationStarted
		{
			get { return s0_DeploymentLastChangingOperationStarted; }
			set
			{
				s0_DeploymentLastChangingOperationStarted = value;
				_columns[22] = value;
			}
		}
		ScopeRuntime.DateTimeQColumnData s0_DeploymentLastServiceHealingTime;
		public ScopeRuntime.DateTimeQColumnData DeploymentLastServiceHealingTime
		{
			get { return s0_DeploymentLastServiceHealingTime; }
			set
			{
				s0_DeploymentLastServiceHealingTime = value;
				_columns[23] = value;
			}
		}
		ScopeRuntime.DateTimeQColumnData s0_DeploymentLastUpdated;
		public ScopeRuntime.DateTimeQColumnData DeploymentLastUpdated
		{
			get { return s0_DeploymentLastUpdated; }
			set
			{
				s0_DeploymentLastUpdated = value;
				_columns[24] = value;
			}
		}
		ScopeRuntime.BooleanQColumnData s0_DeploymentLastVipSwapFailed;
		public ScopeRuntime.BooleanQColumnData DeploymentLastVipSwapFailed
		{
			get { return s0_DeploymentLastVipSwapFailed; }
			set
			{
				s0_DeploymentLastVipSwapFailed = value;
				_columns[25] = value;
			}
		}
		ScopeRuntime.DateTimeQColumnData s0_DeploymentLastVipSwapFailedTime;
		public ScopeRuntime.DateTimeQColumnData DeploymentLastVipSwapFailedTime
		{
			get { return s0_DeploymentLastVipSwapFailedTime; }
			set
			{
				s0_DeploymentLastVipSwapFailedTime = value;
				_columns[26] = value;
			}
		}
		ScopeRuntime.IntegerQColumnData s0_DeploymentNumUpgradeDomains;
		public ScopeRuntime.IntegerQColumnData DeploymentNumUpgradeDomains
		{
			get { return s0_DeploymentNumUpgradeDomains; }
			set
			{
				s0_DeploymentNumUpgradeDomains = value;
				_columns[27] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_DeploymentOsUpgradePolicy;
		public ScopeRuntime.StringColumnData DeploymentOsUpgradePolicy
		{
			get { return s0_DeploymentOsUpgradePolicy; }
			set
			{
				s0_DeploymentOsUpgradePolicy = value;
				_columns[28] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_DeploymentOsVersion;
		public ScopeRuntime.StringColumnData DeploymentOsVersion
		{
			get { return s0_DeploymentOsVersion; }
			set
			{
				s0_DeploymentOsVersion = value;
				_columns[29] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_DeploymentProgressStatus;
		public ScopeRuntime.StringColumnData DeploymentProgressStatus
		{
			get { return s0_DeploymentProgressStatus; }
			set
			{
				s0_DeploymentProgressStatus = value;
				_columns[30] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_DeploymentRoleInstanceDetails;
		public ScopeRuntime.StringColumnData DeploymentRoleInstanceDetails
		{
			get { return s0_DeploymentRoleInstanceDetails; }
			set
			{
				s0_DeploymentRoleInstanceDetails = value;
				_columns[31] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_DeploymentRoleObjects;
		public ScopeRuntime.StringColumnData DeploymentRoleObjects
		{
			get { return s0_DeploymentRoleObjects; }
			set
			{
				s0_DeploymentRoleObjects = value;
				_columns[32] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_DeploymentRoles;
		public ScopeRuntime.StringColumnData DeploymentRoles
		{
			get { return s0_DeploymentRoles; }
			set
			{
				s0_DeploymentRoles = value;
				_columns[33] = value;
			}
		}
		ScopeRuntime.DateTimeQColumnData s0_DeploymentRolesCSSInfoLastUpdated;
		public ScopeRuntime.DateTimeQColumnData DeploymentRolesCSSInfoLastUpdated
		{
			get { return s0_DeploymentRolesCSSInfoLastUpdated; }
			set
			{
				s0_DeploymentRolesCSSInfoLastUpdated = value;
				_columns[34] = value;
			}
		}
		ScopeRuntime.DateTimeQColumnData s0_DeploymentRolesLastUpdated;
		public ScopeRuntime.DateTimeQColumnData DeploymentRolesLastUpdated
		{
			get { return s0_DeploymentRolesLastUpdated; }
			set
			{
				s0_DeploymentRolesLastUpdated = value;
				_columns[35] = value;
			}
		}
		ScopeRuntime.DateTimeQColumnData s0_DeploymentRolesSupportInfoLastUpdated;
		public ScopeRuntime.DateTimeQColumnData DeploymentRolesSupportInfoLastUpdated
		{
			get { return s0_DeploymentRolesSupportInfoLastUpdated; }
			set
			{
				s0_DeploymentRolesSupportInfoLastUpdated = value;
				_columns[36] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_DeploymentRoleToUpgrade;
		public ScopeRuntime.StringColumnData DeploymentRoleToUpgrade
		{
			get { return s0_DeploymentRoleToUpgrade; }
			set
			{
				s0_DeploymentRoleToUpgrade = value;
				_columns[37] = value;
			}
		}
		ScopeRuntime.BooleanQColumnData s0_DeploymentServiceHealingEnabled;
		public ScopeRuntime.BooleanQColumnData DeploymentServiceHealingEnabled
		{
			get { return s0_DeploymentServiceHealingEnabled; }
			set
			{
				s0_DeploymentServiceHealingEnabled = value;
				_columns[38] = value;
			}
		}
		ScopeRuntime.IntegerQColumnData s0_DeploymentServiceInstanceCount;
		public ScopeRuntime.IntegerQColumnData DeploymentServiceInstanceCount
		{
			get { return s0_DeploymentServiceInstanceCount; }
			set
			{
				s0_DeploymentServiceInstanceCount = value;
				_columns[39] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_DeploymentSettings;
		public ScopeRuntime.StringColumnData DeploymentSettings
		{
			get { return s0_DeploymentSettings; }
			set
			{
				s0_DeploymentSettings = value;
				_columns[40] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_DeploymentStatus;
		public ScopeRuntime.StringColumnData DeploymentStatus
		{
			get { return s0_DeploymentStatus; }
			set
			{
				s0_DeploymentStatus = value;
				_columns[41] = value;
			}
		}
		ScopeRuntime.DateTimeQColumnData s0_DeploymentSupportInfoLastUpdated;
		public ScopeRuntime.DateTimeQColumnData DeploymentSupportInfoLastUpdated
		{
			get { return s0_DeploymentSupportInfoLastUpdated; }
			set
			{
				s0_DeploymentSupportInfoLastUpdated = value;
				_columns[42] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_DeploymentTransitionStatus;
		public ScopeRuntime.StringColumnData DeploymentTransitionStatus
		{
			get { return s0_DeploymentTransitionStatus; }
			set
			{
				s0_DeploymentTransitionStatus = value;
				_columns[43] = value;
			}
		}
		ScopeRuntime.BooleanQColumnData s0_DeploymentUpdateInProgress;
		public ScopeRuntime.BooleanQColumnData DeploymentUpdateInProgress
		{
			get { return s0_DeploymentUpdateInProgress; }
			set
			{
				s0_DeploymentUpdateInProgress = value;
				_columns[44] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_DeploymentUpdateType;
		public ScopeRuntime.StringColumnData DeploymentUpdateType
		{
			get { return s0_DeploymentUpdateType; }
			set
			{
				s0_DeploymentUpdateType = value;
				_columns[45] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_DeploymentVIP;
		public ScopeRuntime.StringColumnData DeploymentVIP
		{
			get { return s0_DeploymentVIP; }
			set
			{
				s0_DeploymentVIP = value;
				_columns[46] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_DeploymentVIPIPv6;
		public ScopeRuntime.StringColumnData DeploymentVIPIPv6
		{
			get { return s0_DeploymentVIPIPv6; }
			set
			{
				s0_DeploymentVIPIPv6 = value;
				_columns[47] = value;
			}
		}
		ScopeRuntime.IntegerQColumnData s0_DeploymentWeightedNumberOfExtraSmallRoleInstances;
		public ScopeRuntime.IntegerQColumnData DeploymentWeightedNumberOfExtraSmallRoleInstances
		{
			get { return s0_DeploymentWeightedNumberOfExtraSmallRoleInstances; }
			set
			{
				s0_DeploymentWeightedNumberOfExtraSmallRoleInstances = value;
				_columns[48] = value;
			}
		}
		ScopeRuntime.IntegerQColumnData s0_DeploymentWeightedNumberOfRoleInstances;
		public ScopeRuntime.IntegerQColumnData DeploymentWeightedNumberOfRoleInstances
		{
			get { return s0_DeploymentWeightedNumberOfRoleInstances; }
			set
			{
				s0_DeploymentWeightedNumberOfRoleInstances = value;
				_columns[49] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_FqdnSuffix;
		public ScopeRuntime.StringColumnData FqdnSuffix
		{
			get { return s0_FqdnSuffix; }
			set
			{
				s0_FqdnSuffix = value;
				_columns[50] = value;
			}
		}
		ScopeRuntime.BooleanQColumnData s0_IS_Current;
		public ScopeRuntime.BooleanQColumnData IS_Current
		{
			get { return s0_IS_Current; }
			set
			{
				s0_IS_Current = value;
				_columns[51] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_MigratedFrom;
		public ScopeRuntime.StringColumnData MigratedFrom
		{
			get { return s0_MigratedFrom; }
			set
			{
				s0_MigratedFrom = value;
				_columns[52] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_PackageRequiredFeatures;
		public ScopeRuntime.StringColumnData PackageRequiredFeatures
		{
			get { return s0_PackageRequiredFeatures; }
			set
			{
				s0_PackageRequiredFeatures = value;
				_columns[53] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_PersistentVMs;
		public ScopeRuntime.StringColumnData PersistentVMs
		{
			get { return s0_PersistentVMs; }
			set
			{
				s0_PersistentVMs = value;
				_columns[54] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_RoleOsMap;
		public ScopeRuntime.StringColumnData RoleOsMap
		{
			get { return s0_RoleOsMap; }
			set
			{
				s0_RoleOsMap = value;
				_columns[55] = value;
			}
		}
		ScopeRuntime.DateTimeQColumnData s0_SCD_EndDate;
		public ScopeRuntime.DateTimeQColumnData SCD_EndDate
		{
			get { return s0_SCD_EndDate; }
			set
			{
				s0_SCD_EndDate = value;
				_columns[56] = value;
			}
		}
		ScopeRuntime.DateTimeQColumnData s0_SCD_StartDate;
		public ScopeRuntime.DateTimeQColumnData SCD_StartDate
		{
			get { return s0_SCD_StartDate; }
			set
			{
				s0_SCD_StartDate = value;
				_columns[57] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_SdkVersion;
		public ScopeRuntime.StringColumnData SdkVersion
		{
			get { return s0_SdkVersion; }
			set
			{
				s0_SdkVersion = value;
				_columns[58] = value;
			}
		}
		ScopeRuntime.DateTimeQColumnData s0_TimeMigrated;
		public ScopeRuntime.DateTimeQColumnData TimeMigrated
		{
			get { return s0_TimeMigrated; }
			set
			{
				s0_TimeMigrated = value;
				_columns[59] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_endpoint;
		public ScopeRuntime.StringColumnData endpoint
		{
			get { return s0_endpoint; }
			set
			{
				s0_endpoint = value;
				_columns[60] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_SourceTableName;
		public ScopeRuntime.StringColumnData SourceTableName
		{
			get { return s0_SourceTableName; }
			set
			{
				s0_SourceTableName = value;
				_columns[61] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_AuditCreateDate;
		public ScopeRuntime.StringColumnData AuditCreateDate
		{
			get { return s0_AuditCreateDate; }
			set
			{
				s0_AuditCreateDate = value;
				_columns[62] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_AuditUpdateDate;
		public ScopeRuntime.StringColumnData AuditUpdateDate
		{
			get { return s0_AuditUpdateDate; }
			set
			{
				s0_AuditUpdateDate = value;
				_columns[63] = value;
			}
		}
		public Row_FCBEBA9BE66EF92B(Schema schema, ColumnData[] columns) : base(schema, columns) { }
		public Row_FCBEBA9BE66EF92B(Schema schema) : base(schema)
		{
			for (int i = 0; i < _columns.Length; ++i)
			{
				this[i] = _columns[i];
			}
		}
		public Row_FCBEBA9BE66EF92B() : base(BuildSchema(), BuildColumnData())
		{
			for (int i = 0; i < _columns.Length; ++i)
			{
				this[i] = _columns[i];
			}
		}
		private static Schema BuildSchema()
		{
			Schema schema = new Schema();
			for (int i = 0; i < _columnTable.Length; ++i)
			{
				schema.Add(new ScopeRuntime.ColumnInfo(_columnTable[i].Item1, _columnTable[i].Item3));
			}
			return schema;
		}
		private static ColumnData[] BuildColumnData()
		{
			ColumnData[] columnData = new ColumnData[_columnTable.Length];
			for (int i = 0; i < _columnTable.Length; ++i)
			{
				columnData[i] = _columnTable[i].Item4 != null ? _columnTable[i].Item4() : ColumnDataFactory.Create(_columnTable[i].Item2);
			}
			return columnData;
		}
		public override ColumnData this[int index]
		{
			get { return _columns[index]; }
			set
			{
				_columns[index] = value;

				//  We also need to reset the property
				switch (index)
				{
					case 0:
						s0_SubscriptionGUID = (ScopeRuntime.StringColumnData)value;
						break;
					case 1:
						s0_DeploymentGUID = (ScopeRuntime.StringColumnData)value;
						break;
					case 2:
						s0_DeploymentName = (ScopeRuntime.StringColumnData)value;
						break;
					case 3:
						s0_DeploymentCreateTimestamp = (ScopeRuntime.DateTimeQColumnData)value;
						break;
					case 4:
						s0_HostedServiceName = (ScopeRuntime.StringColumnData)value;
						break;
					case 5:
						s0_FabricGeoId = (ScopeRuntime.StringColumnData)value;
						break;
					case 6:
						s0_DeploymentType = (ScopeRuntime.StringColumnData)value;
						break;
					case 7:
						s0_IsSystemDeployment = (ScopeRuntime.IntegerQColumnData)value;
						break;
					case 8:
						s0_DeploymentCSSInfoLastUpdated = (ScopeRuntime.DateTimeQColumnData)value;
						break;
					case 9:
						s0_DeploymentCurrentUpdateDomain = (ScopeRuntime.IntegerQColumnData)value;
						break;
					case 10:
						s0_DeploymentCurrentUpgradeDomain = (ScopeRuntime.IntegerQColumnData)value;
						break;
					case 11:
						s0_DeploymentCurrentUpgradeDomainState = (ScopeRuntime.IntegerQColumnData)value;
						break;
					case 12:
						s0_DeploymentDescription = (ScopeRuntime.StringColumnData)value;
						break;
					case 13:
						s0_DeploymentDNSGuid = (ScopeRuntime.StringColumnData)value;
						break;
					case 14:
						s0_DeploymentDNSName = (ScopeRuntime.StringColumnData)value;
						break;
					case 15:
						s0_DeploymentFabricTenantStatus = (ScopeRuntime.StringColumnData)value;
						break;
					case 16:
						s0_DeploymentGroup = (ScopeRuntime.StringColumnData)value;
						break;
					case 17:
						s0_DeploymentHost = (ScopeRuntime.StringColumnData)value;
						break;
					case 18:
						s0_DeploymentInputEndpoints = (ScopeRuntime.StringColumnData)value;
						break;
					case 19:
						s0_DeploymentKind = (ScopeRuntime.StringColumnData)value;
						break;
					case 20:
						s0_DeploymentLabel = (ScopeRuntime.StringColumnData)value;
						break;
					case 21:
						s0_DeploymentLastChangingOperationId = (ScopeRuntime.StringColumnData)value;
						break;
					case 22:
						s0_DeploymentLastChangingOperationStarted = (ScopeRuntime.DateTimeQColumnData)value;
						break;
					case 23:
						s0_DeploymentLastServiceHealingTime = (ScopeRuntime.DateTimeQColumnData)value;
						break;
					case 24:
						s0_DeploymentLastUpdated = (ScopeRuntime.DateTimeQColumnData)value;
						break;
					case 25:
						s0_DeploymentLastVipSwapFailed = (ScopeRuntime.BooleanQColumnData)value;
						break;
					case 26:
						s0_DeploymentLastVipSwapFailedTime = (ScopeRuntime.DateTimeQColumnData)value;
						break;
					case 27:
						s0_DeploymentNumUpgradeDomains = (ScopeRuntime.IntegerQColumnData)value;
						break;
					case 28:
						s0_DeploymentOsUpgradePolicy = (ScopeRuntime.StringColumnData)value;
						break;
					case 29:
						s0_DeploymentOsVersion = (ScopeRuntime.StringColumnData)value;
						break;
					case 30:
						s0_DeploymentProgressStatus = (ScopeRuntime.StringColumnData)value;
						break;
					case 31:
						s0_DeploymentRoleInstanceDetails = (ScopeRuntime.StringColumnData)value;
						break;
					case 32:
						s0_DeploymentRoleObjects = (ScopeRuntime.StringColumnData)value;
						break;
					case 33:
						s0_DeploymentRoles = (ScopeRuntime.StringColumnData)value;
						break;
					case 34:
						s0_DeploymentRolesCSSInfoLastUpdated = (ScopeRuntime.DateTimeQColumnData)value;
						break;
					case 35:
						s0_DeploymentRolesLastUpdated = (ScopeRuntime.DateTimeQColumnData)value;
						break;
					case 36:
						s0_DeploymentRolesSupportInfoLastUpdated = (ScopeRuntime.DateTimeQColumnData)value;
						break;
					case 37:
						s0_DeploymentRoleToUpgrade = (ScopeRuntime.StringColumnData)value;
						break;
					case 38:
						s0_DeploymentServiceHealingEnabled = (ScopeRuntime.BooleanQColumnData)value;
						break;
					case 39:
						s0_DeploymentServiceInstanceCount = (ScopeRuntime.IntegerQColumnData)value;
						break;
					case 40:
						s0_DeploymentSettings = (ScopeRuntime.StringColumnData)value;
						break;
					case 41:
						s0_DeploymentStatus = (ScopeRuntime.StringColumnData)value;
						break;
					case 42:
						s0_DeploymentSupportInfoLastUpdated = (ScopeRuntime.DateTimeQColumnData)value;
						break;
					case 43:
						s0_DeploymentTransitionStatus = (ScopeRuntime.StringColumnData)value;
						break;
					case 44:
						s0_DeploymentUpdateInProgress = (ScopeRuntime.BooleanQColumnData)value;
						break;
					case 45:
						s0_DeploymentUpdateType = (ScopeRuntime.StringColumnData)value;
						break;
					case 46:
						s0_DeploymentVIP = (ScopeRuntime.StringColumnData)value;
						break;
					case 47:
						s0_DeploymentVIPIPv6 = (ScopeRuntime.StringColumnData)value;
						break;
					case 48:
						s0_DeploymentWeightedNumberOfExtraSmallRoleInstances = (ScopeRuntime.IntegerQColumnData)value;
						break;
					case 49:
						s0_DeploymentWeightedNumberOfRoleInstances = (ScopeRuntime.IntegerQColumnData)value;
						break;
					case 50:
						s0_FqdnSuffix = (ScopeRuntime.StringColumnData)value;
						break;
					case 51:
						s0_IS_Current = (ScopeRuntime.BooleanQColumnData)value;
						break;
					case 52:
						s0_MigratedFrom = (ScopeRuntime.StringColumnData)value;
						break;
					case 53:
						s0_PackageRequiredFeatures = (ScopeRuntime.StringColumnData)value;
						break;
					case 54:
						s0_PersistentVMs = (ScopeRuntime.StringColumnData)value;
						break;
					case 55:
						s0_RoleOsMap = (ScopeRuntime.StringColumnData)value;
						break;
					case 56:
						s0_SCD_EndDate = (ScopeRuntime.DateTimeQColumnData)value;
						break;
					case 57:
						s0_SCD_StartDate = (ScopeRuntime.DateTimeQColumnData)value;
						break;
					case 58:
						s0_SdkVersion = (ScopeRuntime.StringColumnData)value;
						break;
					case 59:
						s0_TimeMigrated = (ScopeRuntime.DateTimeQColumnData)value;
						break;
					case 60:
						s0_endpoint = (ScopeRuntime.StringColumnData)value;
						break;
					case 61:
						s0_SourceTableName = (ScopeRuntime.StringColumnData)value;
						break;
					case 62:
						s0_AuditCreateDate = (ScopeRuntime.StringColumnData)value;
						break;
					case 63:
						s0_AuditUpdateDate = (ScopeRuntime.StringColumnData)value;
						break;
				}
			}
		}
		public override void Serialize(BinaryWriter writer)
		{
			byte[] ___masking___ = new byte[9];
			___masking___[0] = 1;
			___masking___[1] = 0;
			___masking___[2] = 0;
			___masking___[3] = 0;
			___masking___[4] = 0;
			___masking___[5] = 0;
			___masking___[6] = 0;
			___masking___[7] = 0;
			___masking___[8] = 0;

			bool hasNull = false;
			if (s0_SubscriptionGUID.IsNull())
			{
				hasNull = true;
				___masking___[0] |= (byte)(1 << 1);
			}
			if (s0_DeploymentGUID.IsNull())
			{
				hasNull = true;
				___masking___[0] |= (byte)(1 << 2);
			}
			if (s0_DeploymentName.IsNull())
			{
				hasNull = true;
				___masking___[0] |= (byte)(1 << 3);
			}
			if (s0_DeploymentCreateTimestamp.IsNull())
			{
				hasNull = true;
				___masking___[0] |= (byte)(1 << 4);
			}
			if (s0_HostedServiceName.IsNull())
			{
				hasNull = true;
				___masking___[0] |= (byte)(1 << 5);
			}
			if (s0_FabricGeoId.IsNull())
			{
				hasNull = true;
				___masking___[0] |= (byte)(1 << 6);
			}
			if (s0_DeploymentType.IsNull())
			{
				hasNull = true;
				___masking___[0] |= (byte)(1 << 7);
			}
			if (s0_IsSystemDeployment.IsNull())
			{
				hasNull = true;
				___masking___[1] |= (byte)(1 << 0);
			}
			if (s0_DeploymentCSSInfoLastUpdated.IsNull())
			{
				hasNull = true;
				___masking___[1] |= (byte)(1 << 1);
			}
			if (s0_DeploymentCurrentUpdateDomain.IsNull())
			{
				hasNull = true;
				___masking___[1] |= (byte)(1 << 2);
			}
			if (s0_DeploymentCurrentUpgradeDomain.IsNull())
			{
				hasNull = true;
				___masking___[1] |= (byte)(1 << 3);
			}
			if (s0_DeploymentCurrentUpgradeDomainState.IsNull())
			{
				hasNull = true;
				___masking___[1] |= (byte)(1 << 4);
			}
			if (s0_DeploymentDescription.IsNull())
			{
				hasNull = true;
				___masking___[1] |= (byte)(1 << 5);
			}
			if (s0_DeploymentDNSGuid.IsNull())
			{
				hasNull = true;
				___masking___[1] |= (byte)(1 << 6);
			}
			if (s0_DeploymentDNSName.IsNull())
			{
				hasNull = true;
				___masking___[1] |= (byte)(1 << 7);
			}
			if (s0_DeploymentFabricTenantStatus.IsNull())
			{
				hasNull = true;
				___masking___[2] |= (byte)(1 << 0);
			}
			if (s0_DeploymentGroup.IsNull())
			{
				hasNull = true;
				___masking___[2] |= (byte)(1 << 1);
			}
			if (s0_DeploymentHost.IsNull())
			{
				hasNull = true;
				___masking___[2] |= (byte)(1 << 2);
			}
			if (s0_DeploymentInputEndpoints.IsNull())
			{
				hasNull = true;
				___masking___[2] |= (byte)(1 << 3);
			}
			if (s0_DeploymentKind.IsNull())
			{
				hasNull = true;
				___masking___[2] |= (byte)(1 << 4);
			}
			if (s0_DeploymentLabel.IsNull())
			{
				hasNull = true;
				___masking___[2] |= (byte)(1 << 5);
			}
			if (s0_DeploymentLastChangingOperationId.IsNull())
			{
				hasNull = true;
				___masking___[2] |= (byte)(1 << 6);
			}
			if (s0_DeploymentLastChangingOperationStarted.IsNull())
			{
				hasNull = true;
				___masking___[2] |= (byte)(1 << 7);
			}
			if (s0_DeploymentLastServiceHealingTime.IsNull())
			{
				hasNull = true;
				___masking___[3] |= (byte)(1 << 0);
			}
			if (s0_DeploymentLastUpdated.IsNull())
			{
				hasNull = true;
				___masking___[3] |= (byte)(1 << 1);
			}
			if (s0_DeploymentLastVipSwapFailed.IsNull())
			{
				hasNull = true;
				___masking___[3] |= (byte)(1 << 2);
			}
			if (s0_DeploymentLastVipSwapFailedTime.IsNull())
			{
				hasNull = true;
				___masking___[3] |= (byte)(1 << 3);
			}
			if (s0_DeploymentNumUpgradeDomains.IsNull())
			{
				hasNull = true;
				___masking___[3] |= (byte)(1 << 4);
			}
			if (s0_DeploymentOsUpgradePolicy.IsNull())
			{
				hasNull = true;
				___masking___[3] |= (byte)(1 << 5);
			}
			if (s0_DeploymentOsVersion.IsNull())
			{
				hasNull = true;
				___masking___[3] |= (byte)(1 << 6);
			}
			if (s0_DeploymentProgressStatus.IsNull())
			{
				hasNull = true;
				___masking___[3] |= (byte)(1 << 7);
			}
			if (s0_DeploymentRoleInstanceDetails.IsNull())
			{
				hasNull = true;
				___masking___[4] |= (byte)(1 << 0);
			}
			if (s0_DeploymentRoleObjects.IsNull())
			{
				hasNull = true;
				___masking___[4] |= (byte)(1 << 1);
			}
			if (s0_DeploymentRoles.IsNull())
			{
				hasNull = true;
				___masking___[4] |= (byte)(1 << 2);
			}
			if (s0_DeploymentRolesCSSInfoLastUpdated.IsNull())
			{
				hasNull = true;
				___masking___[4] |= (byte)(1 << 3);
			}
			if (s0_DeploymentRolesLastUpdated.IsNull())
			{
				hasNull = true;
				___masking___[4] |= (byte)(1 << 4);
			}
			if (s0_DeploymentRolesSupportInfoLastUpdated.IsNull())
			{
				hasNull = true;
				___masking___[4] |= (byte)(1 << 5);
			}
			if (s0_DeploymentRoleToUpgrade.IsNull())
			{
				hasNull = true;
				___masking___[4] |= (byte)(1 << 6);
			}
			if (s0_DeploymentServiceHealingEnabled.IsNull())
			{
				hasNull = true;
				___masking___[4] |= (byte)(1 << 7);
			}
			if (s0_DeploymentServiceInstanceCount.IsNull())
			{
				hasNull = true;
				___masking___[5] |= (byte)(1 << 0);
			}
			if (s0_DeploymentSettings.IsNull())
			{
				hasNull = true;
				___masking___[5] |= (byte)(1 << 1);
			}
			if (s0_DeploymentStatus.IsNull())
			{
				hasNull = true;
				___masking___[5] |= (byte)(1 << 2);
			}
			if (s0_DeploymentSupportInfoLastUpdated.IsNull())
			{
				hasNull = true;
				___masking___[5] |= (byte)(1 << 3);
			}
			if (s0_DeploymentTransitionStatus.IsNull())
			{
				hasNull = true;
				___masking___[5] |= (byte)(1 << 4);
			}
			if (s0_DeploymentUpdateInProgress.IsNull())
			{
				hasNull = true;
				___masking___[5] |= (byte)(1 << 5);
			}
			if (s0_DeploymentUpdateType.IsNull())
			{
				hasNull = true;
				___masking___[5] |= (byte)(1 << 6);
			}
			if (s0_DeploymentVIP.IsNull())
			{
				hasNull = true;
				___masking___[5] |= (byte)(1 << 7);
			}
			if (s0_DeploymentVIPIPv6.IsNull())
			{
				hasNull = true;
				___masking___[6] |= (byte)(1 << 0);
			}
			if (s0_DeploymentWeightedNumberOfExtraSmallRoleInstances.IsNull())
			{
				hasNull = true;
				___masking___[6] |= (byte)(1 << 1);
			}
			if (s0_DeploymentWeightedNumberOfRoleInstances.IsNull())
			{
				hasNull = true;
				___masking___[6] |= (byte)(1 << 2);
			}
			if (s0_FqdnSuffix.IsNull())
			{
				hasNull = true;
				___masking___[6] |= (byte)(1 << 3);
			}
			if (s0_IS_Current.IsNull())
			{
				hasNull = true;
				___masking___[6] |= (byte)(1 << 4);
			}
			if (s0_MigratedFrom.IsNull())
			{
				hasNull = true;
				___masking___[6] |= (byte)(1 << 5);
			}
			if (s0_PackageRequiredFeatures.IsNull())
			{
				hasNull = true;
				___masking___[6] |= (byte)(1 << 6);
			}
			if (s0_PersistentVMs.IsNull())
			{
				hasNull = true;
				___masking___[6] |= (byte)(1 << 7);
			}
			if (s0_RoleOsMap.IsNull())
			{
				hasNull = true;
				___masking___[7] |= (byte)(1 << 0);
			}
			if (s0_SCD_EndDate.IsNull())
			{
				hasNull = true;
				___masking___[7] |= (byte)(1 << 1);
			}
			if (s0_SCD_StartDate.IsNull())
			{
				hasNull = true;
				___masking___[7] |= (byte)(1 << 2);
			}
			if (s0_SdkVersion.IsNull())
			{
				hasNull = true;
				___masking___[7] |= (byte)(1 << 3);
			}
			if (s0_TimeMigrated.IsNull())
			{
				hasNull = true;
				___masking___[7] |= (byte)(1 << 4);
			}
			if (s0_endpoint.IsNull())
			{
				hasNull = true;
				___masking___[7] |= (byte)(1 << 5);
			}
			if (s0_SourceTableName.IsNull())
			{
				hasNull = true;
				___masking___[7] |= (byte)(1 << 6);
			}
			if (s0_AuditCreateDate.IsNull())
			{
				hasNull = true;
				___masking___[7] |= (byte)(1 << 7);
			}
			if (s0_AuditUpdateDate.IsNull())
			{
				hasNull = true;
				___masking___[8] |= (byte)(1 << 0);
			}
			if (hasNull)
			{
				writer.Write(___masking___[0]);
				writer.Write(___masking___[1]);
				writer.Write(___masking___[2]);
				writer.Write(___masking___[3]);
				writer.Write(___masking___[4]);
				writer.Write(___masking___[5]);
				writer.Write(___masking___[6]);
				writer.Write(___masking___[7]);
				writer.Write(___masking___[8]);
			}
			else
			{
				writer.Write( (byte) 0);
			}
			if (!s0_SubscriptionGUID.IsNull())
			{
				s0_SubscriptionGUID.Serialize(writer);
			}
			if (!s0_DeploymentGUID.IsNull())
			{
				s0_DeploymentGUID.Serialize(writer);
			}
			if (!s0_DeploymentName.IsNull())
			{
				s0_DeploymentName.Serialize(writer);
			}
			if (!s0_DeploymentCreateTimestamp.IsNull())
			{
				s0_DeploymentCreateTimestamp.Serialize(writer);
			}
			if (!s0_HostedServiceName.IsNull())
			{
				s0_HostedServiceName.Serialize(writer);
			}
			if (!s0_FabricGeoId.IsNull())
			{
				s0_FabricGeoId.Serialize(writer);
			}
			if (!s0_DeploymentType.IsNull())
			{
				s0_DeploymentType.Serialize(writer);
			}
			if (!s0_IsSystemDeployment.IsNull())
			{
				s0_IsSystemDeployment.Serialize(writer);
			}
			if (!s0_DeploymentCSSInfoLastUpdated.IsNull())
			{
				s0_DeploymentCSSInfoLastUpdated.Serialize(writer);
			}
			if (!s0_DeploymentCurrentUpdateDomain.IsNull())
			{
				s0_DeploymentCurrentUpdateDomain.Serialize(writer);
			}
			if (!s0_DeploymentCurrentUpgradeDomain.IsNull())
			{
				s0_DeploymentCurrentUpgradeDomain.Serialize(writer);
			}
			if (!s0_DeploymentCurrentUpgradeDomainState.IsNull())
			{
				s0_DeploymentCurrentUpgradeDomainState.Serialize(writer);
			}
			if (!s0_DeploymentDescription.IsNull())
			{
				s0_DeploymentDescription.Serialize(writer);
			}
			if (!s0_DeploymentDNSGuid.IsNull())
			{
				s0_DeploymentDNSGuid.Serialize(writer);
			}
			if (!s0_DeploymentDNSName.IsNull())
			{
				s0_DeploymentDNSName.Serialize(writer);
			}
			if (!s0_DeploymentFabricTenantStatus.IsNull())
			{
				s0_DeploymentFabricTenantStatus.Serialize(writer);
			}
			if (!s0_DeploymentGroup.IsNull())
			{
				s0_DeploymentGroup.Serialize(writer);
			}
			if (!s0_DeploymentHost.IsNull())
			{
				s0_DeploymentHost.Serialize(writer);
			}
			if (!s0_DeploymentInputEndpoints.IsNull())
			{
				s0_DeploymentInputEndpoints.Serialize(writer);
			}
			if (!s0_DeploymentKind.IsNull())
			{
				s0_DeploymentKind.Serialize(writer);
			}
			if (!s0_DeploymentLabel.IsNull())
			{
				s0_DeploymentLabel.Serialize(writer);
			}
			if (!s0_DeploymentLastChangingOperationId.IsNull())
			{
				s0_DeploymentLastChangingOperationId.Serialize(writer);
			}
			if (!s0_DeploymentLastChangingOperationStarted.IsNull())
			{
				s0_DeploymentLastChangingOperationStarted.Serialize(writer);
			}
			if (!s0_DeploymentLastServiceHealingTime.IsNull())
			{
				s0_DeploymentLastServiceHealingTime.Serialize(writer);
			}
			if (!s0_DeploymentLastUpdated.IsNull())
			{
				s0_DeploymentLastUpdated.Serialize(writer);
			}
			if (!s0_DeploymentLastVipSwapFailed.IsNull())
			{
				s0_DeploymentLastVipSwapFailed.Serialize(writer);
			}
			if (!s0_DeploymentLastVipSwapFailedTime.IsNull())
			{
				s0_DeploymentLastVipSwapFailedTime.Serialize(writer);
			}
			if (!s0_DeploymentNumUpgradeDomains.IsNull())
			{
				s0_DeploymentNumUpgradeDomains.Serialize(writer);
			}
			if (!s0_DeploymentOsUpgradePolicy.IsNull())
			{
				s0_DeploymentOsUpgradePolicy.Serialize(writer);
			}
			if (!s0_DeploymentOsVersion.IsNull())
			{
				s0_DeploymentOsVersion.Serialize(writer);
			}
			if (!s0_DeploymentProgressStatus.IsNull())
			{
				s0_DeploymentProgressStatus.Serialize(writer);
			}
			if (!s0_DeploymentRoleInstanceDetails.IsNull())
			{
				s0_DeploymentRoleInstanceDetails.Serialize(writer);
			}
			if (!s0_DeploymentRoleObjects.IsNull())
			{
				s0_DeploymentRoleObjects.Serialize(writer);
			}
			if (!s0_DeploymentRoles.IsNull())
			{
				s0_DeploymentRoles.Serialize(writer);
			}
			if (!s0_DeploymentRolesCSSInfoLastUpdated.IsNull())
			{
				s0_DeploymentRolesCSSInfoLastUpdated.Serialize(writer);
			}
			if (!s0_DeploymentRolesLastUpdated.IsNull())
			{
				s0_DeploymentRolesLastUpdated.Serialize(writer);
			}
			if (!s0_DeploymentRolesSupportInfoLastUpdated.IsNull())
			{
				s0_DeploymentRolesSupportInfoLastUpdated.Serialize(writer);
			}
			if (!s0_DeploymentRoleToUpgrade.IsNull())
			{
				s0_DeploymentRoleToUpgrade.Serialize(writer);
			}
			if (!s0_DeploymentServiceHealingEnabled.IsNull())
			{
				s0_DeploymentServiceHealingEnabled.Serialize(writer);
			}
			if (!s0_DeploymentServiceInstanceCount.IsNull())
			{
				s0_DeploymentServiceInstanceCount.Serialize(writer);
			}
			if (!s0_DeploymentSettings.IsNull())
			{
				s0_DeploymentSettings.Serialize(writer);
			}
			if (!s0_DeploymentStatus.IsNull())
			{
				s0_DeploymentStatus.Serialize(writer);
			}
			if (!s0_DeploymentSupportInfoLastUpdated.IsNull())
			{
				s0_DeploymentSupportInfoLastUpdated.Serialize(writer);
			}
			if (!s0_DeploymentTransitionStatus.IsNull())
			{
				s0_DeploymentTransitionStatus.Serialize(writer);
			}
			if (!s0_DeploymentUpdateInProgress.IsNull())
			{
				s0_DeploymentUpdateInProgress.Serialize(writer);
			}
			if (!s0_DeploymentUpdateType.IsNull())
			{
				s0_DeploymentUpdateType.Serialize(writer);
			}
			if (!s0_DeploymentVIP.IsNull())
			{
				s0_DeploymentVIP.Serialize(writer);
			}
			if (!s0_DeploymentVIPIPv6.IsNull())
			{
				s0_DeploymentVIPIPv6.Serialize(writer);
			}
			if (!s0_DeploymentWeightedNumberOfExtraSmallRoleInstances.IsNull())
			{
				s0_DeploymentWeightedNumberOfExtraSmallRoleInstances.Serialize(writer);
			}
			if (!s0_DeploymentWeightedNumberOfRoleInstances.IsNull())
			{
				s0_DeploymentWeightedNumberOfRoleInstances.Serialize(writer);
			}
			if (!s0_FqdnSuffix.IsNull())
			{
				s0_FqdnSuffix.Serialize(writer);
			}
			if (!s0_IS_Current.IsNull())
			{
				s0_IS_Current.Serialize(writer);
			}
			if (!s0_MigratedFrom.IsNull())
			{
				s0_MigratedFrom.Serialize(writer);
			}
			if (!s0_PackageRequiredFeatures.IsNull())
			{
				s0_PackageRequiredFeatures.Serialize(writer);
			}
			if (!s0_PersistentVMs.IsNull())
			{
				s0_PersistentVMs.Serialize(writer);
			}
			if (!s0_RoleOsMap.IsNull())
			{
				s0_RoleOsMap.Serialize(writer);
			}
			if (!s0_SCD_EndDate.IsNull())
			{
				s0_SCD_EndDate.Serialize(writer);
			}
			if (!s0_SCD_StartDate.IsNull())
			{
				s0_SCD_StartDate.Serialize(writer);
			}
			if (!s0_SdkVersion.IsNull())
			{
				s0_SdkVersion.Serialize(writer);
			}
			if (!s0_TimeMigrated.IsNull())
			{
				s0_TimeMigrated.Serialize(writer);
			}
			if (!s0_endpoint.IsNull())
			{
				s0_endpoint.Serialize(writer);
			}
			if (!s0_SourceTableName.IsNull())
			{
				s0_SourceTableName.Serialize(writer);
			}
			if (!s0_AuditCreateDate.IsNull())
			{
				s0_AuditCreateDate.Serialize(writer);
			}
			if (!s0_AuditUpdateDate.IsNull())
			{
				s0_AuditUpdateDate.Serialize(writer);
			}
		}

		public override void Deserialize(BinaryReader reader)
		{
			byte[] ___masking___ = new byte[9];
			byte firstByte = reader.ReadByte();
			if (firstByte == 0)
			{
				s0_SubscriptionGUID.Deserialize(reader);
				s0_DeploymentGUID.Deserialize(reader);
				s0_DeploymentName.Deserialize(reader);
				s0_DeploymentCreateTimestamp.Deserialize(reader);
				s0_HostedServiceName.Deserialize(reader);
				s0_FabricGeoId.Deserialize(reader);
				s0_DeploymentType.Deserialize(reader);
				s0_IsSystemDeployment.Deserialize(reader);
				s0_DeploymentCSSInfoLastUpdated.Deserialize(reader);
				s0_DeploymentCurrentUpdateDomain.Deserialize(reader);
				s0_DeploymentCurrentUpgradeDomain.Deserialize(reader);
				s0_DeploymentCurrentUpgradeDomainState.Deserialize(reader);
				s0_DeploymentDescription.Deserialize(reader);
				s0_DeploymentDNSGuid.Deserialize(reader);
				s0_DeploymentDNSName.Deserialize(reader);
				s0_DeploymentFabricTenantStatus.Deserialize(reader);
				s0_DeploymentGroup.Deserialize(reader);
				s0_DeploymentHost.Deserialize(reader);
				s0_DeploymentInputEndpoints.Deserialize(reader);
				s0_DeploymentKind.Deserialize(reader);
				s0_DeploymentLabel.Deserialize(reader);
				s0_DeploymentLastChangingOperationId.Deserialize(reader);
				s0_DeploymentLastChangingOperationStarted.Deserialize(reader);
				s0_DeploymentLastServiceHealingTime.Deserialize(reader);
				s0_DeploymentLastUpdated.Deserialize(reader);
				s0_DeploymentLastVipSwapFailed.Deserialize(reader);
				s0_DeploymentLastVipSwapFailedTime.Deserialize(reader);
				s0_DeploymentNumUpgradeDomains.Deserialize(reader);
				s0_DeploymentOsUpgradePolicy.Deserialize(reader);
				s0_DeploymentOsVersion.Deserialize(reader);
				s0_DeploymentProgressStatus.Deserialize(reader);
				s0_DeploymentRoleInstanceDetails.Deserialize(reader);
				s0_DeploymentRoleObjects.Deserialize(reader);
				s0_DeploymentRoles.Deserialize(reader);
				s0_DeploymentRolesCSSInfoLastUpdated.Deserialize(reader);
				s0_DeploymentRolesLastUpdated.Deserialize(reader);
				s0_DeploymentRolesSupportInfoLastUpdated.Deserialize(reader);
				s0_DeploymentRoleToUpgrade.Deserialize(reader);
				s0_DeploymentServiceHealingEnabled.Deserialize(reader);
				s0_DeploymentServiceInstanceCount.Deserialize(reader);
				s0_DeploymentSettings.Deserialize(reader);
				s0_DeploymentStatus.Deserialize(reader);
				s0_DeploymentSupportInfoLastUpdated.Deserialize(reader);
				s0_DeploymentTransitionStatus.Deserialize(reader);
				s0_DeploymentUpdateInProgress.Deserialize(reader);
				s0_DeploymentUpdateType.Deserialize(reader);
				s0_DeploymentVIP.Deserialize(reader);
				s0_DeploymentVIPIPv6.Deserialize(reader);
				s0_DeploymentWeightedNumberOfExtraSmallRoleInstances.Deserialize(reader);
				s0_DeploymentWeightedNumberOfRoleInstances.Deserialize(reader);
				s0_FqdnSuffix.Deserialize(reader);
				s0_IS_Current.Deserialize(reader);
				s0_MigratedFrom.Deserialize(reader);
				s0_PackageRequiredFeatures.Deserialize(reader);
				s0_PersistentVMs.Deserialize(reader);
				s0_RoleOsMap.Deserialize(reader);
				s0_SCD_EndDate.Deserialize(reader);
				s0_SCD_StartDate.Deserialize(reader);
				s0_SdkVersion.Deserialize(reader);
				s0_TimeMigrated.Deserialize(reader);
				s0_endpoint.Deserialize(reader);
				s0_SourceTableName.Deserialize(reader);
				s0_AuditCreateDate.Deserialize(reader);
				s0_AuditUpdateDate.Deserialize(reader);
			}
			else
			{
				___masking___[0] = firstByte;
				___masking___[1] = reader.ReadByte();
				___masking___[2] = reader.ReadByte();
				___masking___[3] = reader.ReadByte();
				___masking___[4] = reader.ReadByte();
				___masking___[5] = reader.ReadByte();
				___masking___[6] = reader.ReadByte();
				___masking___[7] = reader.ReadByte();
				___masking___[8] = reader.ReadByte();
				if ((___masking___[0] & 2) != 2)
				{
					s0_SubscriptionGUID.Deserialize(reader);
				}
				else
				{
					s0_SubscriptionGUID.SetNull();
				}
				if ((___masking___[0] & 4) != 4)
				{
					s0_DeploymentGUID.Deserialize(reader);
				}
				else
				{
					s0_DeploymentGUID.SetNull();
				}
				if ((___masking___[0] & 8) != 8)
				{
					s0_DeploymentName.Deserialize(reader);
				}
				else
				{
					s0_DeploymentName.SetNull();
				}
				if ((___masking___[0] & 16) != 16)
				{
					s0_DeploymentCreateTimestamp.Deserialize(reader);
				}
				else
				{
					s0_DeploymentCreateTimestamp.SetNull();
				}
				if ((___masking___[0] & 32) != 32)
				{
					s0_HostedServiceName.Deserialize(reader);
				}
				else
				{
					s0_HostedServiceName.SetNull();
				}
				if ((___masking___[0] & 64) != 64)
				{
					s0_FabricGeoId.Deserialize(reader);
				}
				else
				{
					s0_FabricGeoId.SetNull();
				}
				if ((___masking___[0] & 128) != 128)
				{
					s0_DeploymentType.Deserialize(reader);
				}
				else
				{
					s0_DeploymentType.SetNull();
				}
				if ((___masking___[1] & 1) != 1)
				{
					s0_IsSystemDeployment.Deserialize(reader);
				}
				else
				{
					s0_IsSystemDeployment.SetNull();
				}
				if ((___masking___[1] & 2) != 2)
				{
					s0_DeploymentCSSInfoLastUpdated.Deserialize(reader);
				}
				else
				{
					s0_DeploymentCSSInfoLastUpdated.SetNull();
				}
				if ((___masking___[1] & 4) != 4)
				{
					s0_DeploymentCurrentUpdateDomain.Deserialize(reader);
				}
				else
				{
					s0_DeploymentCurrentUpdateDomain.SetNull();
				}
				if ((___masking___[1] & 8) != 8)
				{
					s0_DeploymentCurrentUpgradeDomain.Deserialize(reader);
				}
				else
				{
					s0_DeploymentCurrentUpgradeDomain.SetNull();
				}
				if ((___masking___[1] & 16) != 16)
				{
					s0_DeploymentCurrentUpgradeDomainState.Deserialize(reader);
				}
				else
				{
					s0_DeploymentCurrentUpgradeDomainState.SetNull();
				}
				if ((___masking___[1] & 32) != 32)
				{
					s0_DeploymentDescription.Deserialize(reader);
				}
				else
				{
					s0_DeploymentDescription.SetNull();
				}
				if ((___masking___[1] & 64) != 64)
				{
					s0_DeploymentDNSGuid.Deserialize(reader);
				}
				else
				{
					s0_DeploymentDNSGuid.SetNull();
				}
				if ((___masking___[1] & 128) != 128)
				{
					s0_DeploymentDNSName.Deserialize(reader);
				}
				else
				{
					s0_DeploymentDNSName.SetNull();
				}
				if ((___masking___[2] & 1) != 1)
				{
					s0_DeploymentFabricTenantStatus.Deserialize(reader);
				}
				else
				{
					s0_DeploymentFabricTenantStatus.SetNull();
				}
				if ((___masking___[2] & 2) != 2)
				{
					s0_DeploymentGroup.Deserialize(reader);
				}
				else
				{
					s0_DeploymentGroup.SetNull();
				}
				if ((___masking___[2] & 4) != 4)
				{
					s0_DeploymentHost.Deserialize(reader);
				}
				else
				{
					s0_DeploymentHost.SetNull();
				}
				if ((___masking___[2] & 8) != 8)
				{
					s0_DeploymentInputEndpoints.Deserialize(reader);
				}
				else
				{
					s0_DeploymentInputEndpoints.SetNull();
				}
				if ((___masking___[2] & 16) != 16)
				{
					s0_DeploymentKind.Deserialize(reader);
				}
				else
				{
					s0_DeploymentKind.SetNull();
				}
				if ((___masking___[2] & 32) != 32)
				{
					s0_DeploymentLabel.Deserialize(reader);
				}
				else
				{
					s0_DeploymentLabel.SetNull();
				}
				if ((___masking___[2] & 64) != 64)
				{
					s0_DeploymentLastChangingOperationId.Deserialize(reader);
				}
				else
				{
					s0_DeploymentLastChangingOperationId.SetNull();
				}
				if ((___masking___[2] & 128) != 128)
				{
					s0_DeploymentLastChangingOperationStarted.Deserialize(reader);
				}
				else
				{
					s0_DeploymentLastChangingOperationStarted.SetNull();
				}
				if ((___masking___[3] & 1) != 1)
				{
					s0_DeploymentLastServiceHealingTime.Deserialize(reader);
				}
				else
				{
					s0_DeploymentLastServiceHealingTime.SetNull();
				}
				if ((___masking___[3] & 2) != 2)
				{
					s0_DeploymentLastUpdated.Deserialize(reader);
				}
				else
				{
					s0_DeploymentLastUpdated.SetNull();
				}
				if ((___masking___[3] & 4) != 4)
				{
					s0_DeploymentLastVipSwapFailed.Deserialize(reader);
				}
				else
				{
					s0_DeploymentLastVipSwapFailed.SetNull();
				}
				if ((___masking___[3] & 8) != 8)
				{
					s0_DeploymentLastVipSwapFailedTime.Deserialize(reader);
				}
				else
				{
					s0_DeploymentLastVipSwapFailedTime.SetNull();
				}
				if ((___masking___[3] & 16) != 16)
				{
					s0_DeploymentNumUpgradeDomains.Deserialize(reader);
				}
				else
				{
					s0_DeploymentNumUpgradeDomains.SetNull();
				}
				if ((___masking___[3] & 32) != 32)
				{
					s0_DeploymentOsUpgradePolicy.Deserialize(reader);
				}
				else
				{
					s0_DeploymentOsUpgradePolicy.SetNull();
				}
				if ((___masking___[3] & 64) != 64)
				{
					s0_DeploymentOsVersion.Deserialize(reader);
				}
				else
				{
					s0_DeploymentOsVersion.SetNull();
				}
				if ((___masking___[3] & 128) != 128)
				{
					s0_DeploymentProgressStatus.Deserialize(reader);
				}
				else
				{
					s0_DeploymentProgressStatus.SetNull();
				}
				if ((___masking___[4] & 1) != 1)
				{
					s0_DeploymentRoleInstanceDetails.Deserialize(reader);
				}
				else
				{
					s0_DeploymentRoleInstanceDetails.SetNull();
				}
				if ((___masking___[4] & 2) != 2)
				{
					s0_DeploymentRoleObjects.Deserialize(reader);
				}
				else
				{
					s0_DeploymentRoleObjects.SetNull();
				}
				if ((___masking___[4] & 4) != 4)
				{
					s0_DeploymentRoles.Deserialize(reader);
				}
				else
				{
					s0_DeploymentRoles.SetNull();
				}
				if ((___masking___[4] & 8) != 8)
				{
					s0_DeploymentRolesCSSInfoLastUpdated.Deserialize(reader);
				}
				else
				{
					s0_DeploymentRolesCSSInfoLastUpdated.SetNull();
				}
				if ((___masking___[4] & 16) != 16)
				{
					s0_DeploymentRolesLastUpdated.Deserialize(reader);
				}
				else
				{
					s0_DeploymentRolesLastUpdated.SetNull();
				}
				if ((___masking___[4] & 32) != 32)
				{
					s0_DeploymentRolesSupportInfoLastUpdated.Deserialize(reader);
				}
				else
				{
					s0_DeploymentRolesSupportInfoLastUpdated.SetNull();
				}
				if ((___masking___[4] & 64) != 64)
				{
					s0_DeploymentRoleToUpgrade.Deserialize(reader);
				}
				else
				{
					s0_DeploymentRoleToUpgrade.SetNull();
				}
				if ((___masking___[4] & 128) != 128)
				{
					s0_DeploymentServiceHealingEnabled.Deserialize(reader);
				}
				else
				{
					s0_DeploymentServiceHealingEnabled.SetNull();
				}
				if ((___masking___[5] & 1) != 1)
				{
					s0_DeploymentServiceInstanceCount.Deserialize(reader);
				}
				else
				{
					s0_DeploymentServiceInstanceCount.SetNull();
				}
				if ((___masking___[5] & 2) != 2)
				{
					s0_DeploymentSettings.Deserialize(reader);
				}
				else
				{
					s0_DeploymentSettings.SetNull();
				}
				if ((___masking___[5] & 4) != 4)
				{
					s0_DeploymentStatus.Deserialize(reader);
				}
				else
				{
					s0_DeploymentStatus.SetNull();
				}
				if ((___masking___[5] & 8) != 8)
				{
					s0_DeploymentSupportInfoLastUpdated.Deserialize(reader);
				}
				else
				{
					s0_DeploymentSupportInfoLastUpdated.SetNull();
				}
				if ((___masking___[5] & 16) != 16)
				{
					s0_DeploymentTransitionStatus.Deserialize(reader);
				}
				else
				{
					s0_DeploymentTransitionStatus.SetNull();
				}
				if ((___masking___[5] & 32) != 32)
				{
					s0_DeploymentUpdateInProgress.Deserialize(reader);
				}
				else
				{
					s0_DeploymentUpdateInProgress.SetNull();
				}
				if ((___masking___[5] & 64) != 64)
				{
					s0_DeploymentUpdateType.Deserialize(reader);
				}
				else
				{
					s0_DeploymentUpdateType.SetNull();
				}
				if ((___masking___[5] & 128) != 128)
				{
					s0_DeploymentVIP.Deserialize(reader);
				}
				else
				{
					s0_DeploymentVIP.SetNull();
				}
				if ((___masking___[6] & 1) != 1)
				{
					s0_DeploymentVIPIPv6.Deserialize(reader);
				}
				else
				{
					s0_DeploymentVIPIPv6.SetNull();
				}
				if ((___masking___[6] & 2) != 2)
				{
					s0_DeploymentWeightedNumberOfExtraSmallRoleInstances.Deserialize(reader);
				}
				else
				{
					s0_DeploymentWeightedNumberOfExtraSmallRoleInstances.SetNull();
				}
				if ((___masking___[6] & 4) != 4)
				{
					s0_DeploymentWeightedNumberOfRoleInstances.Deserialize(reader);
				}
				else
				{
					s0_DeploymentWeightedNumberOfRoleInstances.SetNull();
				}
				if ((___masking___[6] & 8) != 8)
				{
					s0_FqdnSuffix.Deserialize(reader);
				}
				else
				{
					s0_FqdnSuffix.SetNull();
				}
				if ((___masking___[6] & 16) != 16)
				{
					s0_IS_Current.Deserialize(reader);
				}
				else
				{
					s0_IS_Current.SetNull();
				}
				if ((___masking___[6] & 32) != 32)
				{
					s0_MigratedFrom.Deserialize(reader);
				}
				else
				{
					s0_MigratedFrom.SetNull();
				}
				if ((___masking___[6] & 64) != 64)
				{
					s0_PackageRequiredFeatures.Deserialize(reader);
				}
				else
				{
					s0_PackageRequiredFeatures.SetNull();
				}
				if ((___masking___[6] & 128) != 128)
				{
					s0_PersistentVMs.Deserialize(reader);
				}
				else
				{
					s0_PersistentVMs.SetNull();
				}
				if ((___masking___[7] & 1) != 1)
				{
					s0_RoleOsMap.Deserialize(reader);
				}
				else
				{
					s0_RoleOsMap.SetNull();
				}
				if ((___masking___[7] & 2) != 2)
				{
					s0_SCD_EndDate.Deserialize(reader);
				}
				else
				{
					s0_SCD_EndDate.SetNull();
				}
				if ((___masking___[7] & 4) != 4)
				{
					s0_SCD_StartDate.Deserialize(reader);
				}
				else
				{
					s0_SCD_StartDate.SetNull();
				}
				if ((___masking___[7] & 8) != 8)
				{
					s0_SdkVersion.Deserialize(reader);
				}
				else
				{
					s0_SdkVersion.SetNull();
				}
				if ((___masking___[7] & 16) != 16)
				{
					s0_TimeMigrated.Deserialize(reader);
				}
				else
				{
					s0_TimeMigrated.SetNull();
				}
				if ((___masking___[7] & 32) != 32)
				{
					s0_endpoint.Deserialize(reader);
				}
				else
				{
					s0_endpoint.SetNull();
				}
				if ((___masking___[7] & 64) != 64)
				{
					s0_SourceTableName.Deserialize(reader);
				}
				else
				{
					s0_SourceTableName.SetNull();
				}
				if ((___masking___[7] & 128) != 128)
				{
					s0_AuditCreateDate.Deserialize(reader);
				}
				else
				{
					s0_AuditCreateDate.SetNull();
				}
				if ((___masking___[8] & 1) != 1)
				{
					s0_AuditUpdateDate.Deserialize(reader);
				}
				else
				{
					s0_AuditUpdateDate.SetNull();
				}
			}
		}
	}


	public class Row_3AD8AF26BDD62668 : Row
	{
		private static readonly System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>[] _columnTable = 
		{
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("__date", ColumnDataType.DateTime, typeof(DateTime), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("SubscriptionGUID", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("DeploymentGUID", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("DeploymentName", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("DeploymentCreateTimestamp", ColumnDataType.DateTimeQ, typeof(DateTime?), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("HostedServiceName", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("FabricGeoId", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("DeploymentType", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("IsSystemDeployment", ColumnDataType.IntegerQ, typeof(int?), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("DeploymentCSSInfoLastUpdated", ColumnDataType.DateTimeQ, typeof(DateTime?), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("DeploymentCurrentUpdateDomain", ColumnDataType.IntegerQ, typeof(int?), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("DeploymentCurrentUpgradeDomain", ColumnDataType.IntegerQ, typeof(int?), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("DeploymentCurrentUpgradeDomainState", ColumnDataType.IntegerQ, typeof(int?), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("DeploymentDescription", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("DeploymentDNSGuid", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("DeploymentDNSName", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("DeploymentFabricTenantStatus", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("DeploymentGroup", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("DeploymentHost", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("DeploymentInputEndpoints", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("DeploymentKind", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("DeploymentLabel", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("DeploymentLastChangingOperationId", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("DeploymentLastChangingOperationStarted", ColumnDataType.DateTimeQ, typeof(DateTime?), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("DeploymentLastServiceHealingTime", ColumnDataType.DateTimeQ, typeof(DateTime?), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("DeploymentLastUpdated", ColumnDataType.DateTimeQ, typeof(DateTime?), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("DeploymentLastVipSwapFailed", ColumnDataType.BooleanQ, typeof(bool?), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("DeploymentLastVipSwapFailedTime", ColumnDataType.DateTimeQ, typeof(DateTime?), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("DeploymentNumUpgradeDomains", ColumnDataType.IntegerQ, typeof(int?), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("DeploymentOsUpgradePolicy", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("DeploymentOsVersion", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("DeploymentProgressStatus", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("DeploymentRoleInstanceDetails", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("DeploymentRoleObjects", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("DeploymentRoles", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("DeploymentRolesCSSInfoLastUpdated", ColumnDataType.DateTimeQ, typeof(DateTime?), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("DeploymentRolesLastUpdated", ColumnDataType.DateTimeQ, typeof(DateTime?), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("DeploymentRolesSupportInfoLastUpdated", ColumnDataType.DateTimeQ, typeof(DateTime?), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("DeploymentRoleToUpgrade", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("DeploymentServiceHealingEnabled", ColumnDataType.BooleanQ, typeof(bool?), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("DeploymentServiceInstanceCount", ColumnDataType.IntegerQ, typeof(int?), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("DeploymentSettings", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("DeploymentStatus", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("DeploymentSupportInfoLastUpdated", ColumnDataType.DateTimeQ, typeof(DateTime?), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("DeploymentTransitionStatus", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("DeploymentUpdateInProgress", ColumnDataType.BooleanQ, typeof(bool?), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("DeploymentUpdateType", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("DeploymentVIP", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("DeploymentVIPIPv6", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("DeploymentWeightedNumberOfExtraSmallRoleInstances", ColumnDataType.IntegerQ, typeof(int?), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("DeploymentWeightedNumberOfRoleInstances", ColumnDataType.IntegerQ, typeof(int?), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("FqdnSuffix", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("IS_Current", ColumnDataType.BooleanQ, typeof(bool?), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("MigratedFrom", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("PackageRequiredFeatures", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("PersistentVMs", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("RoleOsMap", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("SCD_EndDate", ColumnDataType.DateTimeQ, typeof(DateTime?), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("SCD_StartDate", ColumnDataType.DateTimeQ, typeof(DateTime?), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("SdkVersion", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("TimeMigrated", ColumnDataType.DateTimeQ, typeof(DateTime?), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("endpoint", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("SourceTableName", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("AuditCreateDate", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("AuditUpdateDate", ColumnDataType.String, typeof(string), null),
		};
		ScopeRuntime.DateTimeColumnData s0___date;
		public ScopeRuntime.DateTimeColumnData __date
		{
			get { return s0___date; }
			set
			{
				s0___date = value;
				_columns[0] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_SubscriptionGUID;
		public ScopeRuntime.StringColumnData SubscriptionGUID
		{
			get { return s0_SubscriptionGUID; }
			set
			{
				s0_SubscriptionGUID = value;
				_columns[1] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_DeploymentGUID;
		public ScopeRuntime.StringColumnData DeploymentGUID
		{
			get { return s0_DeploymentGUID; }
			set
			{
				s0_DeploymentGUID = value;
				_columns[2] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_DeploymentName;
		public ScopeRuntime.StringColumnData DeploymentName
		{
			get { return s0_DeploymentName; }
			set
			{
				s0_DeploymentName = value;
				_columns[3] = value;
			}
		}
		ScopeRuntime.DateTimeQColumnData s0_DeploymentCreateTimestamp;
		public ScopeRuntime.DateTimeQColumnData DeploymentCreateTimestamp
		{
			get { return s0_DeploymentCreateTimestamp; }
			set
			{
				s0_DeploymentCreateTimestamp = value;
				_columns[4] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_HostedServiceName;
		public ScopeRuntime.StringColumnData HostedServiceName
		{
			get { return s0_HostedServiceName; }
			set
			{
				s0_HostedServiceName = value;
				_columns[5] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_FabricGeoId;
		public ScopeRuntime.StringColumnData FabricGeoId
		{
			get { return s0_FabricGeoId; }
			set
			{
				s0_FabricGeoId = value;
				_columns[6] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_DeploymentType;
		public ScopeRuntime.StringColumnData DeploymentType
		{
			get { return s0_DeploymentType; }
			set
			{
				s0_DeploymentType = value;
				_columns[7] = value;
			}
		}
		ScopeRuntime.IntegerQColumnData s0_IsSystemDeployment;
		public ScopeRuntime.IntegerQColumnData IsSystemDeployment
		{
			get { return s0_IsSystemDeployment; }
			set
			{
				s0_IsSystemDeployment = value;
				_columns[8] = value;
			}
		}
		ScopeRuntime.DateTimeQColumnData s0_DeploymentCSSInfoLastUpdated;
		public ScopeRuntime.DateTimeQColumnData DeploymentCSSInfoLastUpdated
		{
			get { return s0_DeploymentCSSInfoLastUpdated; }
			set
			{
				s0_DeploymentCSSInfoLastUpdated = value;
				_columns[9] = value;
			}
		}
		ScopeRuntime.IntegerQColumnData s0_DeploymentCurrentUpdateDomain;
		public ScopeRuntime.IntegerQColumnData DeploymentCurrentUpdateDomain
		{
			get { return s0_DeploymentCurrentUpdateDomain; }
			set
			{
				s0_DeploymentCurrentUpdateDomain = value;
				_columns[10] = value;
			}
		}
		ScopeRuntime.IntegerQColumnData s0_DeploymentCurrentUpgradeDomain;
		public ScopeRuntime.IntegerQColumnData DeploymentCurrentUpgradeDomain
		{
			get { return s0_DeploymentCurrentUpgradeDomain; }
			set
			{
				s0_DeploymentCurrentUpgradeDomain = value;
				_columns[11] = value;
			}
		}
		ScopeRuntime.IntegerQColumnData s0_DeploymentCurrentUpgradeDomainState;
		public ScopeRuntime.IntegerQColumnData DeploymentCurrentUpgradeDomainState
		{
			get { return s0_DeploymentCurrentUpgradeDomainState; }
			set
			{
				s0_DeploymentCurrentUpgradeDomainState = value;
				_columns[12] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_DeploymentDescription;
		public ScopeRuntime.StringColumnData DeploymentDescription
		{
			get { return s0_DeploymentDescription; }
			set
			{
				s0_DeploymentDescription = value;
				_columns[13] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_DeploymentDNSGuid;
		public ScopeRuntime.StringColumnData DeploymentDNSGuid
		{
			get { return s0_DeploymentDNSGuid; }
			set
			{
				s0_DeploymentDNSGuid = value;
				_columns[14] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_DeploymentDNSName;
		public ScopeRuntime.StringColumnData DeploymentDNSName
		{
			get { return s0_DeploymentDNSName; }
			set
			{
				s0_DeploymentDNSName = value;
				_columns[15] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_DeploymentFabricTenantStatus;
		public ScopeRuntime.StringColumnData DeploymentFabricTenantStatus
		{
			get { return s0_DeploymentFabricTenantStatus; }
			set
			{
				s0_DeploymentFabricTenantStatus = value;
				_columns[16] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_DeploymentGroup;
		public ScopeRuntime.StringColumnData DeploymentGroup
		{
			get { return s0_DeploymentGroup; }
			set
			{
				s0_DeploymentGroup = value;
				_columns[17] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_DeploymentHost;
		public ScopeRuntime.StringColumnData DeploymentHost
		{
			get { return s0_DeploymentHost; }
			set
			{
				s0_DeploymentHost = value;
				_columns[18] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_DeploymentInputEndpoints;
		public ScopeRuntime.StringColumnData DeploymentInputEndpoints
		{
			get { return s0_DeploymentInputEndpoints; }
			set
			{
				s0_DeploymentInputEndpoints = value;
				_columns[19] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_DeploymentKind;
		public ScopeRuntime.StringColumnData DeploymentKind
		{
			get { return s0_DeploymentKind; }
			set
			{
				s0_DeploymentKind = value;
				_columns[20] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_DeploymentLabel;
		public ScopeRuntime.StringColumnData DeploymentLabel
		{
			get { return s0_DeploymentLabel; }
			set
			{
				s0_DeploymentLabel = value;
				_columns[21] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_DeploymentLastChangingOperationId;
		public ScopeRuntime.StringColumnData DeploymentLastChangingOperationId
		{
			get { return s0_DeploymentLastChangingOperationId; }
			set
			{
				s0_DeploymentLastChangingOperationId = value;
				_columns[22] = value;
			}
		}
		ScopeRuntime.DateTimeQColumnData s0_DeploymentLastChangingOperationStarted;
		public ScopeRuntime.DateTimeQColumnData DeploymentLastChangingOperationStarted
		{
			get { return s0_DeploymentLastChangingOperationStarted; }
			set
			{
				s0_DeploymentLastChangingOperationStarted = value;
				_columns[23] = value;
			}
		}
		ScopeRuntime.DateTimeQColumnData s0_DeploymentLastServiceHealingTime;
		public ScopeRuntime.DateTimeQColumnData DeploymentLastServiceHealingTime
		{
			get { return s0_DeploymentLastServiceHealingTime; }
			set
			{
				s0_DeploymentLastServiceHealingTime = value;
				_columns[24] = value;
			}
		}
		ScopeRuntime.DateTimeQColumnData s0_DeploymentLastUpdated;
		public ScopeRuntime.DateTimeQColumnData DeploymentLastUpdated
		{
			get { return s0_DeploymentLastUpdated; }
			set
			{
				s0_DeploymentLastUpdated = value;
				_columns[25] = value;
			}
		}
		ScopeRuntime.BooleanQColumnData s0_DeploymentLastVipSwapFailed;
		public ScopeRuntime.BooleanQColumnData DeploymentLastVipSwapFailed
		{
			get { return s0_DeploymentLastVipSwapFailed; }
			set
			{
				s0_DeploymentLastVipSwapFailed = value;
				_columns[26] = value;
			}
		}
		ScopeRuntime.DateTimeQColumnData s0_DeploymentLastVipSwapFailedTime;
		public ScopeRuntime.DateTimeQColumnData DeploymentLastVipSwapFailedTime
		{
			get { return s0_DeploymentLastVipSwapFailedTime; }
			set
			{
				s0_DeploymentLastVipSwapFailedTime = value;
				_columns[27] = value;
			}
		}
		ScopeRuntime.IntegerQColumnData s0_DeploymentNumUpgradeDomains;
		public ScopeRuntime.IntegerQColumnData DeploymentNumUpgradeDomains
		{
			get { return s0_DeploymentNumUpgradeDomains; }
			set
			{
				s0_DeploymentNumUpgradeDomains = value;
				_columns[28] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_DeploymentOsUpgradePolicy;
		public ScopeRuntime.StringColumnData DeploymentOsUpgradePolicy
		{
			get { return s0_DeploymentOsUpgradePolicy; }
			set
			{
				s0_DeploymentOsUpgradePolicy = value;
				_columns[29] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_DeploymentOsVersion;
		public ScopeRuntime.StringColumnData DeploymentOsVersion
		{
			get { return s0_DeploymentOsVersion; }
			set
			{
				s0_DeploymentOsVersion = value;
				_columns[30] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_DeploymentProgressStatus;
		public ScopeRuntime.StringColumnData DeploymentProgressStatus
		{
			get { return s0_DeploymentProgressStatus; }
			set
			{
				s0_DeploymentProgressStatus = value;
				_columns[31] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_DeploymentRoleInstanceDetails;
		public ScopeRuntime.StringColumnData DeploymentRoleInstanceDetails
		{
			get { return s0_DeploymentRoleInstanceDetails; }
			set
			{
				s0_DeploymentRoleInstanceDetails = value;
				_columns[32] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_DeploymentRoleObjects;
		public ScopeRuntime.StringColumnData DeploymentRoleObjects
		{
			get { return s0_DeploymentRoleObjects; }
			set
			{
				s0_DeploymentRoleObjects = value;
				_columns[33] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_DeploymentRoles;
		public ScopeRuntime.StringColumnData DeploymentRoles
		{
			get { return s0_DeploymentRoles; }
			set
			{
				s0_DeploymentRoles = value;
				_columns[34] = value;
			}
		}
		ScopeRuntime.DateTimeQColumnData s0_DeploymentRolesCSSInfoLastUpdated;
		public ScopeRuntime.DateTimeQColumnData DeploymentRolesCSSInfoLastUpdated
		{
			get { return s0_DeploymentRolesCSSInfoLastUpdated; }
			set
			{
				s0_DeploymentRolesCSSInfoLastUpdated = value;
				_columns[35] = value;
			}
		}
		ScopeRuntime.DateTimeQColumnData s0_DeploymentRolesLastUpdated;
		public ScopeRuntime.DateTimeQColumnData DeploymentRolesLastUpdated
		{
			get { return s0_DeploymentRolesLastUpdated; }
			set
			{
				s0_DeploymentRolesLastUpdated = value;
				_columns[36] = value;
			}
		}
		ScopeRuntime.DateTimeQColumnData s0_DeploymentRolesSupportInfoLastUpdated;
		public ScopeRuntime.DateTimeQColumnData DeploymentRolesSupportInfoLastUpdated
		{
			get { return s0_DeploymentRolesSupportInfoLastUpdated; }
			set
			{
				s0_DeploymentRolesSupportInfoLastUpdated = value;
				_columns[37] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_DeploymentRoleToUpgrade;
		public ScopeRuntime.StringColumnData DeploymentRoleToUpgrade
		{
			get { return s0_DeploymentRoleToUpgrade; }
			set
			{
				s0_DeploymentRoleToUpgrade = value;
				_columns[38] = value;
			}
		}
		ScopeRuntime.BooleanQColumnData s0_DeploymentServiceHealingEnabled;
		public ScopeRuntime.BooleanQColumnData DeploymentServiceHealingEnabled
		{
			get { return s0_DeploymentServiceHealingEnabled; }
			set
			{
				s0_DeploymentServiceHealingEnabled = value;
				_columns[39] = value;
			}
		}
		ScopeRuntime.IntegerQColumnData s0_DeploymentServiceInstanceCount;
		public ScopeRuntime.IntegerQColumnData DeploymentServiceInstanceCount
		{
			get { return s0_DeploymentServiceInstanceCount; }
			set
			{
				s0_DeploymentServiceInstanceCount = value;
				_columns[40] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_DeploymentSettings;
		public ScopeRuntime.StringColumnData DeploymentSettings
		{
			get { return s0_DeploymentSettings; }
			set
			{
				s0_DeploymentSettings = value;
				_columns[41] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_DeploymentStatus;
		public ScopeRuntime.StringColumnData DeploymentStatus
		{
			get { return s0_DeploymentStatus; }
			set
			{
				s0_DeploymentStatus = value;
				_columns[42] = value;
			}
		}
		ScopeRuntime.DateTimeQColumnData s0_DeploymentSupportInfoLastUpdated;
		public ScopeRuntime.DateTimeQColumnData DeploymentSupportInfoLastUpdated
		{
			get { return s0_DeploymentSupportInfoLastUpdated; }
			set
			{
				s0_DeploymentSupportInfoLastUpdated = value;
				_columns[43] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_DeploymentTransitionStatus;
		public ScopeRuntime.StringColumnData DeploymentTransitionStatus
		{
			get { return s0_DeploymentTransitionStatus; }
			set
			{
				s0_DeploymentTransitionStatus = value;
				_columns[44] = value;
			}
		}
		ScopeRuntime.BooleanQColumnData s0_DeploymentUpdateInProgress;
		public ScopeRuntime.BooleanQColumnData DeploymentUpdateInProgress
		{
			get { return s0_DeploymentUpdateInProgress; }
			set
			{
				s0_DeploymentUpdateInProgress = value;
				_columns[45] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_DeploymentUpdateType;
		public ScopeRuntime.StringColumnData DeploymentUpdateType
		{
			get { return s0_DeploymentUpdateType; }
			set
			{
				s0_DeploymentUpdateType = value;
				_columns[46] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_DeploymentVIP;
		public ScopeRuntime.StringColumnData DeploymentVIP
		{
			get { return s0_DeploymentVIP; }
			set
			{
				s0_DeploymentVIP = value;
				_columns[47] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_DeploymentVIPIPv6;
		public ScopeRuntime.StringColumnData DeploymentVIPIPv6
		{
			get { return s0_DeploymentVIPIPv6; }
			set
			{
				s0_DeploymentVIPIPv6 = value;
				_columns[48] = value;
			}
		}
		ScopeRuntime.IntegerQColumnData s0_DeploymentWeightedNumberOfExtraSmallRoleInstances;
		public ScopeRuntime.IntegerQColumnData DeploymentWeightedNumberOfExtraSmallRoleInstances
		{
			get { return s0_DeploymentWeightedNumberOfExtraSmallRoleInstances; }
			set
			{
				s0_DeploymentWeightedNumberOfExtraSmallRoleInstances = value;
				_columns[49] = value;
			}
		}
		ScopeRuntime.IntegerQColumnData s0_DeploymentWeightedNumberOfRoleInstances;
		public ScopeRuntime.IntegerQColumnData DeploymentWeightedNumberOfRoleInstances
		{
			get { return s0_DeploymentWeightedNumberOfRoleInstances; }
			set
			{
				s0_DeploymentWeightedNumberOfRoleInstances = value;
				_columns[50] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_FqdnSuffix;
		public ScopeRuntime.StringColumnData FqdnSuffix
		{
			get { return s0_FqdnSuffix; }
			set
			{
				s0_FqdnSuffix = value;
				_columns[51] = value;
			}
		}
		ScopeRuntime.BooleanQColumnData s0_IS_Current;
		public ScopeRuntime.BooleanQColumnData IS_Current
		{
			get { return s0_IS_Current; }
			set
			{
				s0_IS_Current = value;
				_columns[52] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_MigratedFrom;
		public ScopeRuntime.StringColumnData MigratedFrom
		{
			get { return s0_MigratedFrom; }
			set
			{
				s0_MigratedFrom = value;
				_columns[53] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_PackageRequiredFeatures;
		public ScopeRuntime.StringColumnData PackageRequiredFeatures
		{
			get { return s0_PackageRequiredFeatures; }
			set
			{
				s0_PackageRequiredFeatures = value;
				_columns[54] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_PersistentVMs;
		public ScopeRuntime.StringColumnData PersistentVMs
		{
			get { return s0_PersistentVMs; }
			set
			{
				s0_PersistentVMs = value;
				_columns[55] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_RoleOsMap;
		public ScopeRuntime.StringColumnData RoleOsMap
		{
			get { return s0_RoleOsMap; }
			set
			{
				s0_RoleOsMap = value;
				_columns[56] = value;
			}
		}
		ScopeRuntime.DateTimeQColumnData s0_SCD_EndDate;
		public ScopeRuntime.DateTimeQColumnData SCD_EndDate
		{
			get { return s0_SCD_EndDate; }
			set
			{
				s0_SCD_EndDate = value;
				_columns[57] = value;
			}
		}
		ScopeRuntime.DateTimeQColumnData s0_SCD_StartDate;
		public ScopeRuntime.DateTimeQColumnData SCD_StartDate
		{
			get { return s0_SCD_StartDate; }
			set
			{
				s0_SCD_StartDate = value;
				_columns[58] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_SdkVersion;
		public ScopeRuntime.StringColumnData SdkVersion
		{
			get { return s0_SdkVersion; }
			set
			{
				s0_SdkVersion = value;
				_columns[59] = value;
			}
		}
		ScopeRuntime.DateTimeQColumnData s0_TimeMigrated;
		public ScopeRuntime.DateTimeQColumnData TimeMigrated
		{
			get { return s0_TimeMigrated; }
			set
			{
				s0_TimeMigrated = value;
				_columns[60] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_endpoint;
		public ScopeRuntime.StringColumnData endpoint
		{
			get { return s0_endpoint; }
			set
			{
				s0_endpoint = value;
				_columns[61] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_SourceTableName;
		public ScopeRuntime.StringColumnData SourceTableName
		{
			get { return s0_SourceTableName; }
			set
			{
				s0_SourceTableName = value;
				_columns[62] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_AuditCreateDate;
		public ScopeRuntime.StringColumnData AuditCreateDate
		{
			get { return s0_AuditCreateDate; }
			set
			{
				s0_AuditCreateDate = value;
				_columns[63] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_AuditUpdateDate;
		public ScopeRuntime.StringColumnData AuditUpdateDate
		{
			get { return s0_AuditUpdateDate; }
			set
			{
				s0_AuditUpdateDate = value;
				_columns[64] = value;
			}
		}
		public Row_3AD8AF26BDD62668(Schema schema, ColumnData[] columns) : base(schema, columns) { }
		public Row_3AD8AF26BDD62668(Schema schema) : base(schema)
		{
			for (int i = 0; i < _columns.Length; ++i)
			{
				this[i] = _columns[i];
			}
		}
		public Row_3AD8AF26BDD62668() : base(BuildSchema(), BuildColumnData())
		{
			for (int i = 0; i < _columns.Length; ++i)
			{
				this[i] = _columns[i];
			}
		}
		private static Schema BuildSchema()
		{
			Schema schema = new Schema();
			for (int i = 0; i < _columnTable.Length; ++i)
			{
				schema.Add(new ScopeRuntime.ColumnInfo(_columnTable[i].Item1, _columnTable[i].Item3));
			}
			return schema;
		}
		private static ColumnData[] BuildColumnData()
		{
			ColumnData[] columnData = new ColumnData[_columnTable.Length];
			for (int i = 0; i < _columnTable.Length; ++i)
			{
				columnData[i] = _columnTable[i].Item4 != null ? _columnTable[i].Item4() : ColumnDataFactory.Create(_columnTable[i].Item2);
			}
			return columnData;
		}
		public override ColumnData this[int index]
		{
			get { return _columns[index]; }
			set
			{
				_columns[index] = value;

				//  We also need to reset the property
				switch (index)
				{
					case 0:
						s0___date = (ScopeRuntime.DateTimeColumnData)value;
						break;
					case 1:
						s0_SubscriptionGUID = (ScopeRuntime.StringColumnData)value;
						break;
					case 2:
						s0_DeploymentGUID = (ScopeRuntime.StringColumnData)value;
						break;
					case 3:
						s0_DeploymentName = (ScopeRuntime.StringColumnData)value;
						break;
					case 4:
						s0_DeploymentCreateTimestamp = (ScopeRuntime.DateTimeQColumnData)value;
						break;
					case 5:
						s0_HostedServiceName = (ScopeRuntime.StringColumnData)value;
						break;
					case 6:
						s0_FabricGeoId = (ScopeRuntime.StringColumnData)value;
						break;
					case 7:
						s0_DeploymentType = (ScopeRuntime.StringColumnData)value;
						break;
					case 8:
						s0_IsSystemDeployment = (ScopeRuntime.IntegerQColumnData)value;
						break;
					case 9:
						s0_DeploymentCSSInfoLastUpdated = (ScopeRuntime.DateTimeQColumnData)value;
						break;
					case 10:
						s0_DeploymentCurrentUpdateDomain = (ScopeRuntime.IntegerQColumnData)value;
						break;
					case 11:
						s0_DeploymentCurrentUpgradeDomain = (ScopeRuntime.IntegerQColumnData)value;
						break;
					case 12:
						s0_DeploymentCurrentUpgradeDomainState = (ScopeRuntime.IntegerQColumnData)value;
						break;
					case 13:
						s0_DeploymentDescription = (ScopeRuntime.StringColumnData)value;
						break;
					case 14:
						s0_DeploymentDNSGuid = (ScopeRuntime.StringColumnData)value;
						break;
					case 15:
						s0_DeploymentDNSName = (ScopeRuntime.StringColumnData)value;
						break;
					case 16:
						s0_DeploymentFabricTenantStatus = (ScopeRuntime.StringColumnData)value;
						break;
					case 17:
						s0_DeploymentGroup = (ScopeRuntime.StringColumnData)value;
						break;
					case 18:
						s0_DeploymentHost = (ScopeRuntime.StringColumnData)value;
						break;
					case 19:
						s0_DeploymentInputEndpoints = (ScopeRuntime.StringColumnData)value;
						break;
					case 20:
						s0_DeploymentKind = (ScopeRuntime.StringColumnData)value;
						break;
					case 21:
						s0_DeploymentLabel = (ScopeRuntime.StringColumnData)value;
						break;
					case 22:
						s0_DeploymentLastChangingOperationId = (ScopeRuntime.StringColumnData)value;
						break;
					case 23:
						s0_DeploymentLastChangingOperationStarted = (ScopeRuntime.DateTimeQColumnData)value;
						break;
					case 24:
						s0_DeploymentLastServiceHealingTime = (ScopeRuntime.DateTimeQColumnData)value;
						break;
					case 25:
						s0_DeploymentLastUpdated = (ScopeRuntime.DateTimeQColumnData)value;
						break;
					case 26:
						s0_DeploymentLastVipSwapFailed = (ScopeRuntime.BooleanQColumnData)value;
						break;
					case 27:
						s0_DeploymentLastVipSwapFailedTime = (ScopeRuntime.DateTimeQColumnData)value;
						break;
					case 28:
						s0_DeploymentNumUpgradeDomains = (ScopeRuntime.IntegerQColumnData)value;
						break;
					case 29:
						s0_DeploymentOsUpgradePolicy = (ScopeRuntime.StringColumnData)value;
						break;
					case 30:
						s0_DeploymentOsVersion = (ScopeRuntime.StringColumnData)value;
						break;
					case 31:
						s0_DeploymentProgressStatus = (ScopeRuntime.StringColumnData)value;
						break;
					case 32:
						s0_DeploymentRoleInstanceDetails = (ScopeRuntime.StringColumnData)value;
						break;
					case 33:
						s0_DeploymentRoleObjects = (ScopeRuntime.StringColumnData)value;
						break;
					case 34:
						s0_DeploymentRoles = (ScopeRuntime.StringColumnData)value;
						break;
					case 35:
						s0_DeploymentRolesCSSInfoLastUpdated = (ScopeRuntime.DateTimeQColumnData)value;
						break;
					case 36:
						s0_DeploymentRolesLastUpdated = (ScopeRuntime.DateTimeQColumnData)value;
						break;
					case 37:
						s0_DeploymentRolesSupportInfoLastUpdated = (ScopeRuntime.DateTimeQColumnData)value;
						break;
					case 38:
						s0_DeploymentRoleToUpgrade = (ScopeRuntime.StringColumnData)value;
						break;
					case 39:
						s0_DeploymentServiceHealingEnabled = (ScopeRuntime.BooleanQColumnData)value;
						break;
					case 40:
						s0_DeploymentServiceInstanceCount = (ScopeRuntime.IntegerQColumnData)value;
						break;
					case 41:
						s0_DeploymentSettings = (ScopeRuntime.StringColumnData)value;
						break;
					case 42:
						s0_DeploymentStatus = (ScopeRuntime.StringColumnData)value;
						break;
					case 43:
						s0_DeploymentSupportInfoLastUpdated = (ScopeRuntime.DateTimeQColumnData)value;
						break;
					case 44:
						s0_DeploymentTransitionStatus = (ScopeRuntime.StringColumnData)value;
						break;
					case 45:
						s0_DeploymentUpdateInProgress = (ScopeRuntime.BooleanQColumnData)value;
						break;
					case 46:
						s0_DeploymentUpdateType = (ScopeRuntime.StringColumnData)value;
						break;
					case 47:
						s0_DeploymentVIP = (ScopeRuntime.StringColumnData)value;
						break;
					case 48:
						s0_DeploymentVIPIPv6 = (ScopeRuntime.StringColumnData)value;
						break;
					case 49:
						s0_DeploymentWeightedNumberOfExtraSmallRoleInstances = (ScopeRuntime.IntegerQColumnData)value;
						break;
					case 50:
						s0_DeploymentWeightedNumberOfRoleInstances = (ScopeRuntime.IntegerQColumnData)value;
						break;
					case 51:
						s0_FqdnSuffix = (ScopeRuntime.StringColumnData)value;
						break;
					case 52:
						s0_IS_Current = (ScopeRuntime.BooleanQColumnData)value;
						break;
					case 53:
						s0_MigratedFrom = (ScopeRuntime.StringColumnData)value;
						break;
					case 54:
						s0_PackageRequiredFeatures = (ScopeRuntime.StringColumnData)value;
						break;
					case 55:
						s0_PersistentVMs = (ScopeRuntime.StringColumnData)value;
						break;
					case 56:
						s0_RoleOsMap = (ScopeRuntime.StringColumnData)value;
						break;
					case 57:
						s0_SCD_EndDate = (ScopeRuntime.DateTimeQColumnData)value;
						break;
					case 58:
						s0_SCD_StartDate = (ScopeRuntime.DateTimeQColumnData)value;
						break;
					case 59:
						s0_SdkVersion = (ScopeRuntime.StringColumnData)value;
						break;
					case 60:
						s0_TimeMigrated = (ScopeRuntime.DateTimeQColumnData)value;
						break;
					case 61:
						s0_endpoint = (ScopeRuntime.StringColumnData)value;
						break;
					case 62:
						s0_SourceTableName = (ScopeRuntime.StringColumnData)value;
						break;
					case 63:
						s0_AuditCreateDate = (ScopeRuntime.StringColumnData)value;
						break;
					case 64:
						s0_AuditUpdateDate = (ScopeRuntime.StringColumnData)value;
						break;
				}
			}
		}
		public override void Serialize(BinaryWriter writer)
		{
			byte[] ___masking___ = new byte[9];
			___masking___[0] = 1;
			___masking___[1] = 0;
			___masking___[2] = 0;
			___masking___[3] = 0;
			___masking___[4] = 0;
			___masking___[5] = 0;
			___masking___[6] = 0;
			___masking___[7] = 0;
			___masking___[8] = 0;

			bool hasNull = false;
			if (s0_SubscriptionGUID.IsNull())
			{
				hasNull = true;
				___masking___[0] |= (byte)(1 << 1);
			}
			if (s0_DeploymentGUID.IsNull())
			{
				hasNull = true;
				___masking___[0] |= (byte)(1 << 2);
			}
			if (s0_DeploymentName.IsNull())
			{
				hasNull = true;
				___masking___[0] |= (byte)(1 << 3);
			}
			if (s0_DeploymentCreateTimestamp.IsNull())
			{
				hasNull = true;
				___masking___[0] |= (byte)(1 << 4);
			}
			if (s0_HostedServiceName.IsNull())
			{
				hasNull = true;
				___masking___[0] |= (byte)(1 << 5);
			}
			if (s0_FabricGeoId.IsNull())
			{
				hasNull = true;
				___masking___[0] |= (byte)(1 << 6);
			}
			if (s0_DeploymentType.IsNull())
			{
				hasNull = true;
				___masking___[0] |= (byte)(1 << 7);
			}
			if (s0_IsSystemDeployment.IsNull())
			{
				hasNull = true;
				___masking___[1] |= (byte)(1 << 0);
			}
			if (s0_DeploymentCSSInfoLastUpdated.IsNull())
			{
				hasNull = true;
				___masking___[1] |= (byte)(1 << 1);
			}
			if (s0_DeploymentCurrentUpdateDomain.IsNull())
			{
				hasNull = true;
				___masking___[1] |= (byte)(1 << 2);
			}
			if (s0_DeploymentCurrentUpgradeDomain.IsNull())
			{
				hasNull = true;
				___masking___[1] |= (byte)(1 << 3);
			}
			if (s0_DeploymentCurrentUpgradeDomainState.IsNull())
			{
				hasNull = true;
				___masking___[1] |= (byte)(1 << 4);
			}
			if (s0_DeploymentDescription.IsNull())
			{
				hasNull = true;
				___masking___[1] |= (byte)(1 << 5);
			}
			if (s0_DeploymentDNSGuid.IsNull())
			{
				hasNull = true;
				___masking___[1] |= (byte)(1 << 6);
			}
			if (s0_DeploymentDNSName.IsNull())
			{
				hasNull = true;
				___masking___[1] |= (byte)(1 << 7);
			}
			if (s0_DeploymentFabricTenantStatus.IsNull())
			{
				hasNull = true;
				___masking___[2] |= (byte)(1 << 0);
			}
			if (s0_DeploymentGroup.IsNull())
			{
				hasNull = true;
				___masking___[2] |= (byte)(1 << 1);
			}
			if (s0_DeploymentHost.IsNull())
			{
				hasNull = true;
				___masking___[2] |= (byte)(1 << 2);
			}
			if (s0_DeploymentInputEndpoints.IsNull())
			{
				hasNull = true;
				___masking___[2] |= (byte)(1 << 3);
			}
			if (s0_DeploymentKind.IsNull())
			{
				hasNull = true;
				___masking___[2] |= (byte)(1 << 4);
			}
			if (s0_DeploymentLabel.IsNull())
			{
				hasNull = true;
				___masking___[2] |= (byte)(1 << 5);
			}
			if (s0_DeploymentLastChangingOperationId.IsNull())
			{
				hasNull = true;
				___masking___[2] |= (byte)(1 << 6);
			}
			if (s0_DeploymentLastChangingOperationStarted.IsNull())
			{
				hasNull = true;
				___masking___[2] |= (byte)(1 << 7);
			}
			if (s0_DeploymentLastServiceHealingTime.IsNull())
			{
				hasNull = true;
				___masking___[3] |= (byte)(1 << 0);
			}
			if (s0_DeploymentLastUpdated.IsNull())
			{
				hasNull = true;
				___masking___[3] |= (byte)(1 << 1);
			}
			if (s0_DeploymentLastVipSwapFailed.IsNull())
			{
				hasNull = true;
				___masking___[3] |= (byte)(1 << 2);
			}
			if (s0_DeploymentLastVipSwapFailedTime.IsNull())
			{
				hasNull = true;
				___masking___[3] |= (byte)(1 << 3);
			}
			if (s0_DeploymentNumUpgradeDomains.IsNull())
			{
				hasNull = true;
				___masking___[3] |= (byte)(1 << 4);
			}
			if (s0_DeploymentOsUpgradePolicy.IsNull())
			{
				hasNull = true;
				___masking___[3] |= (byte)(1 << 5);
			}
			if (s0_DeploymentOsVersion.IsNull())
			{
				hasNull = true;
				___masking___[3] |= (byte)(1 << 6);
			}
			if (s0_DeploymentProgressStatus.IsNull())
			{
				hasNull = true;
				___masking___[3] |= (byte)(1 << 7);
			}
			if (s0_DeploymentRoleInstanceDetails.IsNull())
			{
				hasNull = true;
				___masking___[4] |= (byte)(1 << 0);
			}
			if (s0_DeploymentRoleObjects.IsNull())
			{
				hasNull = true;
				___masking___[4] |= (byte)(1 << 1);
			}
			if (s0_DeploymentRoles.IsNull())
			{
				hasNull = true;
				___masking___[4] |= (byte)(1 << 2);
			}
			if (s0_DeploymentRolesCSSInfoLastUpdated.IsNull())
			{
				hasNull = true;
				___masking___[4] |= (byte)(1 << 3);
			}
			if (s0_DeploymentRolesLastUpdated.IsNull())
			{
				hasNull = true;
				___masking___[4] |= (byte)(1 << 4);
			}
			if (s0_DeploymentRolesSupportInfoLastUpdated.IsNull())
			{
				hasNull = true;
				___masking___[4] |= (byte)(1 << 5);
			}
			if (s0_DeploymentRoleToUpgrade.IsNull())
			{
				hasNull = true;
				___masking___[4] |= (byte)(1 << 6);
			}
			if (s0_DeploymentServiceHealingEnabled.IsNull())
			{
				hasNull = true;
				___masking___[4] |= (byte)(1 << 7);
			}
			if (s0_DeploymentServiceInstanceCount.IsNull())
			{
				hasNull = true;
				___masking___[5] |= (byte)(1 << 0);
			}
			if (s0_DeploymentSettings.IsNull())
			{
				hasNull = true;
				___masking___[5] |= (byte)(1 << 1);
			}
			if (s0_DeploymentStatus.IsNull())
			{
				hasNull = true;
				___masking___[5] |= (byte)(1 << 2);
			}
			if (s0_DeploymentSupportInfoLastUpdated.IsNull())
			{
				hasNull = true;
				___masking___[5] |= (byte)(1 << 3);
			}
			if (s0_DeploymentTransitionStatus.IsNull())
			{
				hasNull = true;
				___masking___[5] |= (byte)(1 << 4);
			}
			if (s0_DeploymentUpdateInProgress.IsNull())
			{
				hasNull = true;
				___masking___[5] |= (byte)(1 << 5);
			}
			if (s0_DeploymentUpdateType.IsNull())
			{
				hasNull = true;
				___masking___[5] |= (byte)(1 << 6);
			}
			if (s0_DeploymentVIP.IsNull())
			{
				hasNull = true;
				___masking___[5] |= (byte)(1 << 7);
			}
			if (s0_DeploymentVIPIPv6.IsNull())
			{
				hasNull = true;
				___masking___[6] |= (byte)(1 << 0);
			}
			if (s0_DeploymentWeightedNumberOfExtraSmallRoleInstances.IsNull())
			{
				hasNull = true;
				___masking___[6] |= (byte)(1 << 1);
			}
			if (s0_DeploymentWeightedNumberOfRoleInstances.IsNull())
			{
				hasNull = true;
				___masking___[6] |= (byte)(1 << 2);
			}
			if (s0_FqdnSuffix.IsNull())
			{
				hasNull = true;
				___masking___[6] |= (byte)(1 << 3);
			}
			if (s0_IS_Current.IsNull())
			{
				hasNull = true;
				___masking___[6] |= (byte)(1 << 4);
			}
			if (s0_MigratedFrom.IsNull())
			{
				hasNull = true;
				___masking___[6] |= (byte)(1 << 5);
			}
			if (s0_PackageRequiredFeatures.IsNull())
			{
				hasNull = true;
				___masking___[6] |= (byte)(1 << 6);
			}
			if (s0_PersistentVMs.IsNull())
			{
				hasNull = true;
				___masking___[6] |= (byte)(1 << 7);
			}
			if (s0_RoleOsMap.IsNull())
			{
				hasNull = true;
				___masking___[7] |= (byte)(1 << 0);
			}
			if (s0_SCD_EndDate.IsNull())
			{
				hasNull = true;
				___masking___[7] |= (byte)(1 << 1);
			}
			if (s0_SCD_StartDate.IsNull())
			{
				hasNull = true;
				___masking___[7] |= (byte)(1 << 2);
			}
			if (s0_SdkVersion.IsNull())
			{
				hasNull = true;
				___masking___[7] |= (byte)(1 << 3);
			}
			if (s0_TimeMigrated.IsNull())
			{
				hasNull = true;
				___masking___[7] |= (byte)(1 << 4);
			}
			if (s0_endpoint.IsNull())
			{
				hasNull = true;
				___masking___[7] |= (byte)(1 << 5);
			}
			if (s0_SourceTableName.IsNull())
			{
				hasNull = true;
				___masking___[7] |= (byte)(1 << 6);
			}
			if (s0_AuditCreateDate.IsNull())
			{
				hasNull = true;
				___masking___[7] |= (byte)(1 << 7);
			}
			if (s0_AuditUpdateDate.IsNull())
			{
				hasNull = true;
				___masking___[8] |= (byte)(1 << 0);
			}
			if (hasNull)
			{
				writer.Write(___masking___[0]);
				writer.Write(___masking___[1]);
				writer.Write(___masking___[2]);
				writer.Write(___masking___[3]);
				writer.Write(___masking___[4]);
				writer.Write(___masking___[5]);
				writer.Write(___masking___[6]);
				writer.Write(___masking___[7]);
				writer.Write(___masking___[8]);
			}
			else
			{
				writer.Write( (byte) 0);
			}
			s0___date.Serialize(writer);
			if (!s0_SubscriptionGUID.IsNull())
			{
				s0_SubscriptionGUID.Serialize(writer);
			}
			if (!s0_DeploymentGUID.IsNull())
			{
				s0_DeploymentGUID.Serialize(writer);
			}
			if (!s0_DeploymentName.IsNull())
			{
				s0_DeploymentName.Serialize(writer);
			}
			if (!s0_DeploymentCreateTimestamp.IsNull())
			{
				s0_DeploymentCreateTimestamp.Serialize(writer);
			}
			if (!s0_HostedServiceName.IsNull())
			{
				s0_HostedServiceName.Serialize(writer);
			}
			if (!s0_FabricGeoId.IsNull())
			{
				s0_FabricGeoId.Serialize(writer);
			}
			if (!s0_DeploymentType.IsNull())
			{
				s0_DeploymentType.Serialize(writer);
			}
			if (!s0_IsSystemDeployment.IsNull())
			{
				s0_IsSystemDeployment.Serialize(writer);
			}
			if (!s0_DeploymentCSSInfoLastUpdated.IsNull())
			{
				s0_DeploymentCSSInfoLastUpdated.Serialize(writer);
			}
			if (!s0_DeploymentCurrentUpdateDomain.IsNull())
			{
				s0_DeploymentCurrentUpdateDomain.Serialize(writer);
			}
			if (!s0_DeploymentCurrentUpgradeDomain.IsNull())
			{
				s0_DeploymentCurrentUpgradeDomain.Serialize(writer);
			}
			if (!s0_DeploymentCurrentUpgradeDomainState.IsNull())
			{
				s0_DeploymentCurrentUpgradeDomainState.Serialize(writer);
			}
			if (!s0_DeploymentDescription.IsNull())
			{
				s0_DeploymentDescription.Serialize(writer);
			}
			if (!s0_DeploymentDNSGuid.IsNull())
			{
				s0_DeploymentDNSGuid.Serialize(writer);
			}
			if (!s0_DeploymentDNSName.IsNull())
			{
				s0_DeploymentDNSName.Serialize(writer);
			}
			if (!s0_DeploymentFabricTenantStatus.IsNull())
			{
				s0_DeploymentFabricTenantStatus.Serialize(writer);
			}
			if (!s0_DeploymentGroup.IsNull())
			{
				s0_DeploymentGroup.Serialize(writer);
			}
			if (!s0_DeploymentHost.IsNull())
			{
				s0_DeploymentHost.Serialize(writer);
			}
			if (!s0_DeploymentInputEndpoints.IsNull())
			{
				s0_DeploymentInputEndpoints.Serialize(writer);
			}
			if (!s0_DeploymentKind.IsNull())
			{
				s0_DeploymentKind.Serialize(writer);
			}
			if (!s0_DeploymentLabel.IsNull())
			{
				s0_DeploymentLabel.Serialize(writer);
			}
			if (!s0_DeploymentLastChangingOperationId.IsNull())
			{
				s0_DeploymentLastChangingOperationId.Serialize(writer);
			}
			if (!s0_DeploymentLastChangingOperationStarted.IsNull())
			{
				s0_DeploymentLastChangingOperationStarted.Serialize(writer);
			}
			if (!s0_DeploymentLastServiceHealingTime.IsNull())
			{
				s0_DeploymentLastServiceHealingTime.Serialize(writer);
			}
			if (!s0_DeploymentLastUpdated.IsNull())
			{
				s0_DeploymentLastUpdated.Serialize(writer);
			}
			if (!s0_DeploymentLastVipSwapFailed.IsNull())
			{
				s0_DeploymentLastVipSwapFailed.Serialize(writer);
			}
			if (!s0_DeploymentLastVipSwapFailedTime.IsNull())
			{
				s0_DeploymentLastVipSwapFailedTime.Serialize(writer);
			}
			if (!s0_DeploymentNumUpgradeDomains.IsNull())
			{
				s0_DeploymentNumUpgradeDomains.Serialize(writer);
			}
			if (!s0_DeploymentOsUpgradePolicy.IsNull())
			{
				s0_DeploymentOsUpgradePolicy.Serialize(writer);
			}
			if (!s0_DeploymentOsVersion.IsNull())
			{
				s0_DeploymentOsVersion.Serialize(writer);
			}
			if (!s0_DeploymentProgressStatus.IsNull())
			{
				s0_DeploymentProgressStatus.Serialize(writer);
			}
			if (!s0_DeploymentRoleInstanceDetails.IsNull())
			{
				s0_DeploymentRoleInstanceDetails.Serialize(writer);
			}
			if (!s0_DeploymentRoleObjects.IsNull())
			{
				s0_DeploymentRoleObjects.Serialize(writer);
			}
			if (!s0_DeploymentRoles.IsNull())
			{
				s0_DeploymentRoles.Serialize(writer);
			}
			if (!s0_DeploymentRolesCSSInfoLastUpdated.IsNull())
			{
				s0_DeploymentRolesCSSInfoLastUpdated.Serialize(writer);
			}
			if (!s0_DeploymentRolesLastUpdated.IsNull())
			{
				s0_DeploymentRolesLastUpdated.Serialize(writer);
			}
			if (!s0_DeploymentRolesSupportInfoLastUpdated.IsNull())
			{
				s0_DeploymentRolesSupportInfoLastUpdated.Serialize(writer);
			}
			if (!s0_DeploymentRoleToUpgrade.IsNull())
			{
				s0_DeploymentRoleToUpgrade.Serialize(writer);
			}
			if (!s0_DeploymentServiceHealingEnabled.IsNull())
			{
				s0_DeploymentServiceHealingEnabled.Serialize(writer);
			}
			if (!s0_DeploymentServiceInstanceCount.IsNull())
			{
				s0_DeploymentServiceInstanceCount.Serialize(writer);
			}
			if (!s0_DeploymentSettings.IsNull())
			{
				s0_DeploymentSettings.Serialize(writer);
			}
			if (!s0_DeploymentStatus.IsNull())
			{
				s0_DeploymentStatus.Serialize(writer);
			}
			if (!s0_DeploymentSupportInfoLastUpdated.IsNull())
			{
				s0_DeploymentSupportInfoLastUpdated.Serialize(writer);
			}
			if (!s0_DeploymentTransitionStatus.IsNull())
			{
				s0_DeploymentTransitionStatus.Serialize(writer);
			}
			if (!s0_DeploymentUpdateInProgress.IsNull())
			{
				s0_DeploymentUpdateInProgress.Serialize(writer);
			}
			if (!s0_DeploymentUpdateType.IsNull())
			{
				s0_DeploymentUpdateType.Serialize(writer);
			}
			if (!s0_DeploymentVIP.IsNull())
			{
				s0_DeploymentVIP.Serialize(writer);
			}
			if (!s0_DeploymentVIPIPv6.IsNull())
			{
				s0_DeploymentVIPIPv6.Serialize(writer);
			}
			if (!s0_DeploymentWeightedNumberOfExtraSmallRoleInstances.IsNull())
			{
				s0_DeploymentWeightedNumberOfExtraSmallRoleInstances.Serialize(writer);
			}
			if (!s0_DeploymentWeightedNumberOfRoleInstances.IsNull())
			{
				s0_DeploymentWeightedNumberOfRoleInstances.Serialize(writer);
			}
			if (!s0_FqdnSuffix.IsNull())
			{
				s0_FqdnSuffix.Serialize(writer);
			}
			if (!s0_IS_Current.IsNull())
			{
				s0_IS_Current.Serialize(writer);
			}
			if (!s0_MigratedFrom.IsNull())
			{
				s0_MigratedFrom.Serialize(writer);
			}
			if (!s0_PackageRequiredFeatures.IsNull())
			{
				s0_PackageRequiredFeatures.Serialize(writer);
			}
			if (!s0_PersistentVMs.IsNull())
			{
				s0_PersistentVMs.Serialize(writer);
			}
			if (!s0_RoleOsMap.IsNull())
			{
				s0_RoleOsMap.Serialize(writer);
			}
			if (!s0_SCD_EndDate.IsNull())
			{
				s0_SCD_EndDate.Serialize(writer);
			}
			if (!s0_SCD_StartDate.IsNull())
			{
				s0_SCD_StartDate.Serialize(writer);
			}
			if (!s0_SdkVersion.IsNull())
			{
				s0_SdkVersion.Serialize(writer);
			}
			if (!s0_TimeMigrated.IsNull())
			{
				s0_TimeMigrated.Serialize(writer);
			}
			if (!s0_endpoint.IsNull())
			{
				s0_endpoint.Serialize(writer);
			}
			if (!s0_SourceTableName.IsNull())
			{
				s0_SourceTableName.Serialize(writer);
			}
			if (!s0_AuditCreateDate.IsNull())
			{
				s0_AuditCreateDate.Serialize(writer);
			}
			if (!s0_AuditUpdateDate.IsNull())
			{
				s0_AuditUpdateDate.Serialize(writer);
			}
		}

		public override void Deserialize(BinaryReader reader)
		{
			byte[] ___masking___ = new byte[9];
			byte firstByte = reader.ReadByte();
			if (firstByte == 0)
			{
				s0___date.Deserialize(reader);
				s0_SubscriptionGUID.Deserialize(reader);
				s0_DeploymentGUID.Deserialize(reader);
				s0_DeploymentName.Deserialize(reader);
				s0_DeploymentCreateTimestamp.Deserialize(reader);
				s0_HostedServiceName.Deserialize(reader);
				s0_FabricGeoId.Deserialize(reader);
				s0_DeploymentType.Deserialize(reader);
				s0_IsSystemDeployment.Deserialize(reader);
				s0_DeploymentCSSInfoLastUpdated.Deserialize(reader);
				s0_DeploymentCurrentUpdateDomain.Deserialize(reader);
				s0_DeploymentCurrentUpgradeDomain.Deserialize(reader);
				s0_DeploymentCurrentUpgradeDomainState.Deserialize(reader);
				s0_DeploymentDescription.Deserialize(reader);
				s0_DeploymentDNSGuid.Deserialize(reader);
				s0_DeploymentDNSName.Deserialize(reader);
				s0_DeploymentFabricTenantStatus.Deserialize(reader);
				s0_DeploymentGroup.Deserialize(reader);
				s0_DeploymentHost.Deserialize(reader);
				s0_DeploymentInputEndpoints.Deserialize(reader);
				s0_DeploymentKind.Deserialize(reader);
				s0_DeploymentLabel.Deserialize(reader);
				s0_DeploymentLastChangingOperationId.Deserialize(reader);
				s0_DeploymentLastChangingOperationStarted.Deserialize(reader);
				s0_DeploymentLastServiceHealingTime.Deserialize(reader);
				s0_DeploymentLastUpdated.Deserialize(reader);
				s0_DeploymentLastVipSwapFailed.Deserialize(reader);
				s0_DeploymentLastVipSwapFailedTime.Deserialize(reader);
				s0_DeploymentNumUpgradeDomains.Deserialize(reader);
				s0_DeploymentOsUpgradePolicy.Deserialize(reader);
				s0_DeploymentOsVersion.Deserialize(reader);
				s0_DeploymentProgressStatus.Deserialize(reader);
				s0_DeploymentRoleInstanceDetails.Deserialize(reader);
				s0_DeploymentRoleObjects.Deserialize(reader);
				s0_DeploymentRoles.Deserialize(reader);
				s0_DeploymentRolesCSSInfoLastUpdated.Deserialize(reader);
				s0_DeploymentRolesLastUpdated.Deserialize(reader);
				s0_DeploymentRolesSupportInfoLastUpdated.Deserialize(reader);
				s0_DeploymentRoleToUpgrade.Deserialize(reader);
				s0_DeploymentServiceHealingEnabled.Deserialize(reader);
				s0_DeploymentServiceInstanceCount.Deserialize(reader);
				s0_DeploymentSettings.Deserialize(reader);
				s0_DeploymentStatus.Deserialize(reader);
				s0_DeploymentSupportInfoLastUpdated.Deserialize(reader);
				s0_DeploymentTransitionStatus.Deserialize(reader);
				s0_DeploymentUpdateInProgress.Deserialize(reader);
				s0_DeploymentUpdateType.Deserialize(reader);
				s0_DeploymentVIP.Deserialize(reader);
				s0_DeploymentVIPIPv6.Deserialize(reader);
				s0_DeploymentWeightedNumberOfExtraSmallRoleInstances.Deserialize(reader);
				s0_DeploymentWeightedNumberOfRoleInstances.Deserialize(reader);
				s0_FqdnSuffix.Deserialize(reader);
				s0_IS_Current.Deserialize(reader);
				s0_MigratedFrom.Deserialize(reader);
				s0_PackageRequiredFeatures.Deserialize(reader);
				s0_PersistentVMs.Deserialize(reader);
				s0_RoleOsMap.Deserialize(reader);
				s0_SCD_EndDate.Deserialize(reader);
				s0_SCD_StartDate.Deserialize(reader);
				s0_SdkVersion.Deserialize(reader);
				s0_TimeMigrated.Deserialize(reader);
				s0_endpoint.Deserialize(reader);
				s0_SourceTableName.Deserialize(reader);
				s0_AuditCreateDate.Deserialize(reader);
				s0_AuditUpdateDate.Deserialize(reader);
			}
			else
			{
				___masking___[0] = firstByte;
				___masking___[1] = reader.ReadByte();
				___masking___[2] = reader.ReadByte();
				___masking___[3] = reader.ReadByte();
				___masking___[4] = reader.ReadByte();
				___masking___[5] = reader.ReadByte();
				___masking___[6] = reader.ReadByte();
				___masking___[7] = reader.ReadByte();
				___masking___[8] = reader.ReadByte();
				s0___date.Deserialize(reader);
				if ((___masking___[0] & 2) != 2)
				{
					s0_SubscriptionGUID.Deserialize(reader);
				}
				else
				{
					s0_SubscriptionGUID.SetNull();
				}
				if ((___masking___[0] & 4) != 4)
				{
					s0_DeploymentGUID.Deserialize(reader);
				}
				else
				{
					s0_DeploymentGUID.SetNull();
				}
				if ((___masking___[0] & 8) != 8)
				{
					s0_DeploymentName.Deserialize(reader);
				}
				else
				{
					s0_DeploymentName.SetNull();
				}
				if ((___masking___[0] & 16) != 16)
				{
					s0_DeploymentCreateTimestamp.Deserialize(reader);
				}
				else
				{
					s0_DeploymentCreateTimestamp.SetNull();
				}
				if ((___masking___[0] & 32) != 32)
				{
					s0_HostedServiceName.Deserialize(reader);
				}
				else
				{
					s0_HostedServiceName.SetNull();
				}
				if ((___masking___[0] & 64) != 64)
				{
					s0_FabricGeoId.Deserialize(reader);
				}
				else
				{
					s0_FabricGeoId.SetNull();
				}
				if ((___masking___[0] & 128) != 128)
				{
					s0_DeploymentType.Deserialize(reader);
				}
				else
				{
					s0_DeploymentType.SetNull();
				}
				if ((___masking___[1] & 1) != 1)
				{
					s0_IsSystemDeployment.Deserialize(reader);
				}
				else
				{
					s0_IsSystemDeployment.SetNull();
				}
				if ((___masking___[1] & 2) != 2)
				{
					s0_DeploymentCSSInfoLastUpdated.Deserialize(reader);
				}
				else
				{
					s0_DeploymentCSSInfoLastUpdated.SetNull();
				}
				if ((___masking___[1] & 4) != 4)
				{
					s0_DeploymentCurrentUpdateDomain.Deserialize(reader);
				}
				else
				{
					s0_DeploymentCurrentUpdateDomain.SetNull();
				}
				if ((___masking___[1] & 8) != 8)
				{
					s0_DeploymentCurrentUpgradeDomain.Deserialize(reader);
				}
				else
				{
					s0_DeploymentCurrentUpgradeDomain.SetNull();
				}
				if ((___masking___[1] & 16) != 16)
				{
					s0_DeploymentCurrentUpgradeDomainState.Deserialize(reader);
				}
				else
				{
					s0_DeploymentCurrentUpgradeDomainState.SetNull();
				}
				if ((___masking___[1] & 32) != 32)
				{
					s0_DeploymentDescription.Deserialize(reader);
				}
				else
				{
					s0_DeploymentDescription.SetNull();
				}
				if ((___masking___[1] & 64) != 64)
				{
					s0_DeploymentDNSGuid.Deserialize(reader);
				}
				else
				{
					s0_DeploymentDNSGuid.SetNull();
				}
				if ((___masking___[1] & 128) != 128)
				{
					s0_DeploymentDNSName.Deserialize(reader);
				}
				else
				{
					s0_DeploymentDNSName.SetNull();
				}
				if ((___masking___[2] & 1) != 1)
				{
					s0_DeploymentFabricTenantStatus.Deserialize(reader);
				}
				else
				{
					s0_DeploymentFabricTenantStatus.SetNull();
				}
				if ((___masking___[2] & 2) != 2)
				{
					s0_DeploymentGroup.Deserialize(reader);
				}
				else
				{
					s0_DeploymentGroup.SetNull();
				}
				if ((___masking___[2] & 4) != 4)
				{
					s0_DeploymentHost.Deserialize(reader);
				}
				else
				{
					s0_DeploymentHost.SetNull();
				}
				if ((___masking___[2] & 8) != 8)
				{
					s0_DeploymentInputEndpoints.Deserialize(reader);
				}
				else
				{
					s0_DeploymentInputEndpoints.SetNull();
				}
				if ((___masking___[2] & 16) != 16)
				{
					s0_DeploymentKind.Deserialize(reader);
				}
				else
				{
					s0_DeploymentKind.SetNull();
				}
				if ((___masking___[2] & 32) != 32)
				{
					s0_DeploymentLabel.Deserialize(reader);
				}
				else
				{
					s0_DeploymentLabel.SetNull();
				}
				if ((___masking___[2] & 64) != 64)
				{
					s0_DeploymentLastChangingOperationId.Deserialize(reader);
				}
				else
				{
					s0_DeploymentLastChangingOperationId.SetNull();
				}
				if ((___masking___[2] & 128) != 128)
				{
					s0_DeploymentLastChangingOperationStarted.Deserialize(reader);
				}
				else
				{
					s0_DeploymentLastChangingOperationStarted.SetNull();
				}
				if ((___masking___[3] & 1) != 1)
				{
					s0_DeploymentLastServiceHealingTime.Deserialize(reader);
				}
				else
				{
					s0_DeploymentLastServiceHealingTime.SetNull();
				}
				if ((___masking___[3] & 2) != 2)
				{
					s0_DeploymentLastUpdated.Deserialize(reader);
				}
				else
				{
					s0_DeploymentLastUpdated.SetNull();
				}
				if ((___masking___[3] & 4) != 4)
				{
					s0_DeploymentLastVipSwapFailed.Deserialize(reader);
				}
				else
				{
					s0_DeploymentLastVipSwapFailed.SetNull();
				}
				if ((___masking___[3] & 8) != 8)
				{
					s0_DeploymentLastVipSwapFailedTime.Deserialize(reader);
				}
				else
				{
					s0_DeploymentLastVipSwapFailedTime.SetNull();
				}
				if ((___masking___[3] & 16) != 16)
				{
					s0_DeploymentNumUpgradeDomains.Deserialize(reader);
				}
				else
				{
					s0_DeploymentNumUpgradeDomains.SetNull();
				}
				if ((___masking___[3] & 32) != 32)
				{
					s0_DeploymentOsUpgradePolicy.Deserialize(reader);
				}
				else
				{
					s0_DeploymentOsUpgradePolicy.SetNull();
				}
				if ((___masking___[3] & 64) != 64)
				{
					s0_DeploymentOsVersion.Deserialize(reader);
				}
				else
				{
					s0_DeploymentOsVersion.SetNull();
				}
				if ((___masking___[3] & 128) != 128)
				{
					s0_DeploymentProgressStatus.Deserialize(reader);
				}
				else
				{
					s0_DeploymentProgressStatus.SetNull();
				}
				if ((___masking___[4] & 1) != 1)
				{
					s0_DeploymentRoleInstanceDetails.Deserialize(reader);
				}
				else
				{
					s0_DeploymentRoleInstanceDetails.SetNull();
				}
				if ((___masking___[4] & 2) != 2)
				{
					s0_DeploymentRoleObjects.Deserialize(reader);
				}
				else
				{
					s0_DeploymentRoleObjects.SetNull();
				}
				if ((___masking___[4] & 4) != 4)
				{
					s0_DeploymentRoles.Deserialize(reader);
				}
				else
				{
					s0_DeploymentRoles.SetNull();
				}
				if ((___masking___[4] & 8) != 8)
				{
					s0_DeploymentRolesCSSInfoLastUpdated.Deserialize(reader);
				}
				else
				{
					s0_DeploymentRolesCSSInfoLastUpdated.SetNull();
				}
				if ((___masking___[4] & 16) != 16)
				{
					s0_DeploymentRolesLastUpdated.Deserialize(reader);
				}
				else
				{
					s0_DeploymentRolesLastUpdated.SetNull();
				}
				if ((___masking___[4] & 32) != 32)
				{
					s0_DeploymentRolesSupportInfoLastUpdated.Deserialize(reader);
				}
				else
				{
					s0_DeploymentRolesSupportInfoLastUpdated.SetNull();
				}
				if ((___masking___[4] & 64) != 64)
				{
					s0_DeploymentRoleToUpgrade.Deserialize(reader);
				}
				else
				{
					s0_DeploymentRoleToUpgrade.SetNull();
				}
				if ((___masking___[4] & 128) != 128)
				{
					s0_DeploymentServiceHealingEnabled.Deserialize(reader);
				}
				else
				{
					s0_DeploymentServiceHealingEnabled.SetNull();
				}
				if ((___masking___[5] & 1) != 1)
				{
					s0_DeploymentServiceInstanceCount.Deserialize(reader);
				}
				else
				{
					s0_DeploymentServiceInstanceCount.SetNull();
				}
				if ((___masking___[5] & 2) != 2)
				{
					s0_DeploymentSettings.Deserialize(reader);
				}
				else
				{
					s0_DeploymentSettings.SetNull();
				}
				if ((___masking___[5] & 4) != 4)
				{
					s0_DeploymentStatus.Deserialize(reader);
				}
				else
				{
					s0_DeploymentStatus.SetNull();
				}
				if ((___masking___[5] & 8) != 8)
				{
					s0_DeploymentSupportInfoLastUpdated.Deserialize(reader);
				}
				else
				{
					s0_DeploymentSupportInfoLastUpdated.SetNull();
				}
				if ((___masking___[5] & 16) != 16)
				{
					s0_DeploymentTransitionStatus.Deserialize(reader);
				}
				else
				{
					s0_DeploymentTransitionStatus.SetNull();
				}
				if ((___masking___[5] & 32) != 32)
				{
					s0_DeploymentUpdateInProgress.Deserialize(reader);
				}
				else
				{
					s0_DeploymentUpdateInProgress.SetNull();
				}
				if ((___masking___[5] & 64) != 64)
				{
					s0_DeploymentUpdateType.Deserialize(reader);
				}
				else
				{
					s0_DeploymentUpdateType.SetNull();
				}
				if ((___masking___[5] & 128) != 128)
				{
					s0_DeploymentVIP.Deserialize(reader);
				}
				else
				{
					s0_DeploymentVIP.SetNull();
				}
				if ((___masking___[6] & 1) != 1)
				{
					s0_DeploymentVIPIPv6.Deserialize(reader);
				}
				else
				{
					s0_DeploymentVIPIPv6.SetNull();
				}
				if ((___masking___[6] & 2) != 2)
				{
					s0_DeploymentWeightedNumberOfExtraSmallRoleInstances.Deserialize(reader);
				}
				else
				{
					s0_DeploymentWeightedNumberOfExtraSmallRoleInstances.SetNull();
				}
				if ((___masking___[6] & 4) != 4)
				{
					s0_DeploymentWeightedNumberOfRoleInstances.Deserialize(reader);
				}
				else
				{
					s0_DeploymentWeightedNumberOfRoleInstances.SetNull();
				}
				if ((___masking___[6] & 8) != 8)
				{
					s0_FqdnSuffix.Deserialize(reader);
				}
				else
				{
					s0_FqdnSuffix.SetNull();
				}
				if ((___masking___[6] & 16) != 16)
				{
					s0_IS_Current.Deserialize(reader);
				}
				else
				{
					s0_IS_Current.SetNull();
				}
				if ((___masking___[6] & 32) != 32)
				{
					s0_MigratedFrom.Deserialize(reader);
				}
				else
				{
					s0_MigratedFrom.SetNull();
				}
				if ((___masking___[6] & 64) != 64)
				{
					s0_PackageRequiredFeatures.Deserialize(reader);
				}
				else
				{
					s0_PackageRequiredFeatures.SetNull();
				}
				if ((___masking___[6] & 128) != 128)
				{
					s0_PersistentVMs.Deserialize(reader);
				}
				else
				{
					s0_PersistentVMs.SetNull();
				}
				if ((___masking___[7] & 1) != 1)
				{
					s0_RoleOsMap.Deserialize(reader);
				}
				else
				{
					s0_RoleOsMap.SetNull();
				}
				if ((___masking___[7] & 2) != 2)
				{
					s0_SCD_EndDate.Deserialize(reader);
				}
				else
				{
					s0_SCD_EndDate.SetNull();
				}
				if ((___masking___[7] & 4) != 4)
				{
					s0_SCD_StartDate.Deserialize(reader);
				}
				else
				{
					s0_SCD_StartDate.SetNull();
				}
				if ((___masking___[7] & 8) != 8)
				{
					s0_SdkVersion.Deserialize(reader);
				}
				else
				{
					s0_SdkVersion.SetNull();
				}
				if ((___masking___[7] & 16) != 16)
				{
					s0_TimeMigrated.Deserialize(reader);
				}
				else
				{
					s0_TimeMigrated.SetNull();
				}
				if ((___masking___[7] & 32) != 32)
				{
					s0_endpoint.Deserialize(reader);
				}
				else
				{
					s0_endpoint.SetNull();
				}
				if ((___masking___[7] & 64) != 64)
				{
					s0_SourceTableName.Deserialize(reader);
				}
				else
				{
					s0_SourceTableName.SetNull();
				}
				if ((___masking___[7] & 128) != 128)
				{
					s0_AuditCreateDate.Deserialize(reader);
				}
				else
				{
					s0_AuditCreateDate.SetNull();
				}
				if ((___masking___[8] & 1) != 1)
				{
					s0_AuditUpdateDate.Deserialize(reader);
				}
				else
				{
					s0_AuditUpdateDate.SetNull();
				}
			}
		}
	}


	public class Row_DB50E023E6902EA6 : Row
	{
		private static readonly System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>[] _columnTable = 
		{
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("SubscriptionGUID", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("DeploymentGUID", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("DeploymentName", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("DeploymentCreateTimestamp", ColumnDataType.DateTimeQ, typeof(DateTime?), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("HostedServiceName", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("FabricGeoId", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("DeploymentType", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("IsSystemDeployment", ColumnDataType.IntegerQ, typeof(int?), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("DeploymentCSSInfoLastUpdated", ColumnDataType.DateTimeQ, typeof(DateTime?), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("DeploymentCurrentUpdateDomain", ColumnDataType.IntegerQ, typeof(int?), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("DeploymentCurrentUpgradeDomain", ColumnDataType.IntegerQ, typeof(int?), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("DeploymentCurrentUpgradeDomainState", ColumnDataType.IntegerQ, typeof(int?), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("DeploymentDescription", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("DeploymentDNSGuid", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("DeploymentDNSName", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("DeploymentFabricTenantStatus", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("DeploymentGroup", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("DeploymentHost", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("DeploymentInputEndpoints", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("DeploymentKind", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("DeploymentLabel", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("DeploymentLastChangingOperationId", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("DeploymentLastChangingOperationStarted", ColumnDataType.DateTimeQ, typeof(DateTime?), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("DeploymentLastServiceHealingTime", ColumnDataType.DateTimeQ, typeof(DateTime?), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("DeploymentLastUpdated", ColumnDataType.DateTimeQ, typeof(DateTime?), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("DeploymentLastVipSwapFailed", ColumnDataType.BooleanQ, typeof(bool?), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("DeploymentLastVipSwapFailedTime", ColumnDataType.DateTimeQ, typeof(DateTime?), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("DeploymentNumUpgradeDomains", ColumnDataType.IntegerQ, typeof(int?), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("DeploymentOsUpgradePolicy", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("DeploymentOsVersion", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("DeploymentProgressStatus", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("DeploymentRoleInstanceDetails", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("DeploymentRoleObjects", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("DeploymentRoles", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("DeploymentRolesCSSInfoLastUpdated", ColumnDataType.DateTimeQ, typeof(DateTime?), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("DeploymentRolesLastUpdated", ColumnDataType.DateTimeQ, typeof(DateTime?), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("DeploymentRolesSupportInfoLastUpdated", ColumnDataType.DateTimeQ, typeof(DateTime?), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("DeploymentRoleToUpgrade", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("DeploymentServiceHealingEnabled", ColumnDataType.BooleanQ, typeof(bool?), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("DeploymentServiceInstanceCount", ColumnDataType.IntegerQ, typeof(int?), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("DeploymentSettings", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("DeploymentStatus", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("DeploymentSupportInfoLastUpdated", ColumnDataType.DateTimeQ, typeof(DateTime?), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("DeploymentTransitionStatus", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("DeploymentUpdateInProgress", ColumnDataType.BooleanQ, typeof(bool?), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("DeploymentUpdateType", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("DeploymentVIP", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("DeploymentVIPIPv6", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("DeploymentWeightedNumberOfExtraSmallRoleInstances", ColumnDataType.IntegerQ, typeof(int?), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("DeploymentWeightedNumberOfRoleInstances", ColumnDataType.IntegerQ, typeof(int?), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("FqdnSuffix", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("IS_Current", ColumnDataType.BooleanQ, typeof(bool?), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("MigratedFrom", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("PackageRequiredFeatures", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("PersistentVMs", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("RoleOsMap", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("SCD_EndDate", ColumnDataType.DateTimeQ, typeof(DateTime?), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("SCD_StartDate", ColumnDataType.DateTimeQ, typeof(DateTime?), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("SdkVersion", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("TimeMigrated", ColumnDataType.DateTimeQ, typeof(DateTime?), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("endpoint", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("SourceTableName", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("AuditCreateDate", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("AuditUpdateDate", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("__date", ColumnDataType.DateTime, typeof(DateTime), null),
		};
		ScopeRuntime.StringColumnData s0_SubscriptionGUID;
		public ScopeRuntime.StringColumnData SubscriptionGUID
		{
			get { return s0_SubscriptionGUID; }
			set
			{
				s0_SubscriptionGUID = value;
				_columns[0] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_DeploymentGUID;
		public ScopeRuntime.StringColumnData DeploymentGUID
		{
			get { return s0_DeploymentGUID; }
			set
			{
				s0_DeploymentGUID = value;
				_columns[1] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_DeploymentName;
		public ScopeRuntime.StringColumnData DeploymentName
		{
			get { return s0_DeploymentName; }
			set
			{
				s0_DeploymentName = value;
				_columns[2] = value;
			}
		}
		ScopeRuntime.DateTimeQColumnData s0_DeploymentCreateTimestamp;
		public ScopeRuntime.DateTimeQColumnData DeploymentCreateTimestamp
		{
			get { return s0_DeploymentCreateTimestamp; }
			set
			{
				s0_DeploymentCreateTimestamp = value;
				_columns[3] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_HostedServiceName;
		public ScopeRuntime.StringColumnData HostedServiceName
		{
			get { return s0_HostedServiceName; }
			set
			{
				s0_HostedServiceName = value;
				_columns[4] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_FabricGeoId;
		public ScopeRuntime.StringColumnData FabricGeoId
		{
			get { return s0_FabricGeoId; }
			set
			{
				s0_FabricGeoId = value;
				_columns[5] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_DeploymentType;
		public ScopeRuntime.StringColumnData DeploymentType
		{
			get { return s0_DeploymentType; }
			set
			{
				s0_DeploymentType = value;
				_columns[6] = value;
			}
		}
		ScopeRuntime.IntegerQColumnData s0_IsSystemDeployment;
		public ScopeRuntime.IntegerQColumnData IsSystemDeployment
		{
			get { return s0_IsSystemDeployment; }
			set
			{
				s0_IsSystemDeployment = value;
				_columns[7] = value;
			}
		}
		ScopeRuntime.DateTimeQColumnData s0_DeploymentCSSInfoLastUpdated;
		public ScopeRuntime.DateTimeQColumnData DeploymentCSSInfoLastUpdated
		{
			get { return s0_DeploymentCSSInfoLastUpdated; }
			set
			{
				s0_DeploymentCSSInfoLastUpdated = value;
				_columns[8] = value;
			}
		}
		ScopeRuntime.IntegerQColumnData s0_DeploymentCurrentUpdateDomain;
		public ScopeRuntime.IntegerQColumnData DeploymentCurrentUpdateDomain
		{
			get { return s0_DeploymentCurrentUpdateDomain; }
			set
			{
				s0_DeploymentCurrentUpdateDomain = value;
				_columns[9] = value;
			}
		}
		ScopeRuntime.IntegerQColumnData s0_DeploymentCurrentUpgradeDomain;
		public ScopeRuntime.IntegerQColumnData DeploymentCurrentUpgradeDomain
		{
			get { return s0_DeploymentCurrentUpgradeDomain; }
			set
			{
				s0_DeploymentCurrentUpgradeDomain = value;
				_columns[10] = value;
			}
		}
		ScopeRuntime.IntegerQColumnData s0_DeploymentCurrentUpgradeDomainState;
		public ScopeRuntime.IntegerQColumnData DeploymentCurrentUpgradeDomainState
		{
			get { return s0_DeploymentCurrentUpgradeDomainState; }
			set
			{
				s0_DeploymentCurrentUpgradeDomainState = value;
				_columns[11] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_DeploymentDescription;
		public ScopeRuntime.StringColumnData DeploymentDescription
		{
			get { return s0_DeploymentDescription; }
			set
			{
				s0_DeploymentDescription = value;
				_columns[12] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_DeploymentDNSGuid;
		public ScopeRuntime.StringColumnData DeploymentDNSGuid
		{
			get { return s0_DeploymentDNSGuid; }
			set
			{
				s0_DeploymentDNSGuid = value;
				_columns[13] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_DeploymentDNSName;
		public ScopeRuntime.StringColumnData DeploymentDNSName
		{
			get { return s0_DeploymentDNSName; }
			set
			{
				s0_DeploymentDNSName = value;
				_columns[14] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_DeploymentFabricTenantStatus;
		public ScopeRuntime.StringColumnData DeploymentFabricTenantStatus
		{
			get { return s0_DeploymentFabricTenantStatus; }
			set
			{
				s0_DeploymentFabricTenantStatus = value;
				_columns[15] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_DeploymentGroup;
		public ScopeRuntime.StringColumnData DeploymentGroup
		{
			get { return s0_DeploymentGroup; }
			set
			{
				s0_DeploymentGroup = value;
				_columns[16] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_DeploymentHost;
		public ScopeRuntime.StringColumnData DeploymentHost
		{
			get { return s0_DeploymentHost; }
			set
			{
				s0_DeploymentHost = value;
				_columns[17] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_DeploymentInputEndpoints;
		public ScopeRuntime.StringColumnData DeploymentInputEndpoints
		{
			get { return s0_DeploymentInputEndpoints; }
			set
			{
				s0_DeploymentInputEndpoints = value;
				_columns[18] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_DeploymentKind;
		public ScopeRuntime.StringColumnData DeploymentKind
		{
			get { return s0_DeploymentKind; }
			set
			{
				s0_DeploymentKind = value;
				_columns[19] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_DeploymentLabel;
		public ScopeRuntime.StringColumnData DeploymentLabel
		{
			get { return s0_DeploymentLabel; }
			set
			{
				s0_DeploymentLabel = value;
				_columns[20] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_DeploymentLastChangingOperationId;
		public ScopeRuntime.StringColumnData DeploymentLastChangingOperationId
		{
			get { return s0_DeploymentLastChangingOperationId; }
			set
			{
				s0_DeploymentLastChangingOperationId = value;
				_columns[21] = value;
			}
		}
		ScopeRuntime.DateTimeQColumnData s0_DeploymentLastChangingOperationStarted;
		public ScopeRuntime.DateTimeQColumnData DeploymentLastChangingOperationStarted
		{
			get { return s0_DeploymentLastChangingOperationStarted; }
			set
			{
				s0_DeploymentLastChangingOperationStarted = value;
				_columns[22] = value;
			}
		}
		ScopeRuntime.DateTimeQColumnData s0_DeploymentLastServiceHealingTime;
		public ScopeRuntime.DateTimeQColumnData DeploymentLastServiceHealingTime
		{
			get { return s0_DeploymentLastServiceHealingTime; }
			set
			{
				s0_DeploymentLastServiceHealingTime = value;
				_columns[23] = value;
			}
		}
		ScopeRuntime.DateTimeQColumnData s0_DeploymentLastUpdated;
		public ScopeRuntime.DateTimeQColumnData DeploymentLastUpdated
		{
			get { return s0_DeploymentLastUpdated; }
			set
			{
				s0_DeploymentLastUpdated = value;
				_columns[24] = value;
			}
		}
		ScopeRuntime.BooleanQColumnData s0_DeploymentLastVipSwapFailed;
		public ScopeRuntime.BooleanQColumnData DeploymentLastVipSwapFailed
		{
			get { return s0_DeploymentLastVipSwapFailed; }
			set
			{
				s0_DeploymentLastVipSwapFailed = value;
				_columns[25] = value;
			}
		}
		ScopeRuntime.DateTimeQColumnData s0_DeploymentLastVipSwapFailedTime;
		public ScopeRuntime.DateTimeQColumnData DeploymentLastVipSwapFailedTime
		{
			get { return s0_DeploymentLastVipSwapFailedTime; }
			set
			{
				s0_DeploymentLastVipSwapFailedTime = value;
				_columns[26] = value;
			}
		}
		ScopeRuntime.IntegerQColumnData s0_DeploymentNumUpgradeDomains;
		public ScopeRuntime.IntegerQColumnData DeploymentNumUpgradeDomains
		{
			get { return s0_DeploymentNumUpgradeDomains; }
			set
			{
				s0_DeploymentNumUpgradeDomains = value;
				_columns[27] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_DeploymentOsUpgradePolicy;
		public ScopeRuntime.StringColumnData DeploymentOsUpgradePolicy
		{
			get { return s0_DeploymentOsUpgradePolicy; }
			set
			{
				s0_DeploymentOsUpgradePolicy = value;
				_columns[28] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_DeploymentOsVersion;
		public ScopeRuntime.StringColumnData DeploymentOsVersion
		{
			get { return s0_DeploymentOsVersion; }
			set
			{
				s0_DeploymentOsVersion = value;
				_columns[29] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_DeploymentProgressStatus;
		public ScopeRuntime.StringColumnData DeploymentProgressStatus
		{
			get { return s0_DeploymentProgressStatus; }
			set
			{
				s0_DeploymentProgressStatus = value;
				_columns[30] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_DeploymentRoleInstanceDetails;
		public ScopeRuntime.StringColumnData DeploymentRoleInstanceDetails
		{
			get { return s0_DeploymentRoleInstanceDetails; }
			set
			{
				s0_DeploymentRoleInstanceDetails = value;
				_columns[31] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_DeploymentRoleObjects;
		public ScopeRuntime.StringColumnData DeploymentRoleObjects
		{
			get { return s0_DeploymentRoleObjects; }
			set
			{
				s0_DeploymentRoleObjects = value;
				_columns[32] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_DeploymentRoles;
		public ScopeRuntime.StringColumnData DeploymentRoles
		{
			get { return s0_DeploymentRoles; }
			set
			{
				s0_DeploymentRoles = value;
				_columns[33] = value;
			}
		}
		ScopeRuntime.DateTimeQColumnData s0_DeploymentRolesCSSInfoLastUpdated;
		public ScopeRuntime.DateTimeQColumnData DeploymentRolesCSSInfoLastUpdated
		{
			get { return s0_DeploymentRolesCSSInfoLastUpdated; }
			set
			{
				s0_DeploymentRolesCSSInfoLastUpdated = value;
				_columns[34] = value;
			}
		}
		ScopeRuntime.DateTimeQColumnData s0_DeploymentRolesLastUpdated;
		public ScopeRuntime.DateTimeQColumnData DeploymentRolesLastUpdated
		{
			get { return s0_DeploymentRolesLastUpdated; }
			set
			{
				s0_DeploymentRolesLastUpdated = value;
				_columns[35] = value;
			}
		}
		ScopeRuntime.DateTimeQColumnData s0_DeploymentRolesSupportInfoLastUpdated;
		public ScopeRuntime.DateTimeQColumnData DeploymentRolesSupportInfoLastUpdated
		{
			get { return s0_DeploymentRolesSupportInfoLastUpdated; }
			set
			{
				s0_DeploymentRolesSupportInfoLastUpdated = value;
				_columns[36] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_DeploymentRoleToUpgrade;
		public ScopeRuntime.StringColumnData DeploymentRoleToUpgrade
		{
			get { return s0_DeploymentRoleToUpgrade; }
			set
			{
				s0_DeploymentRoleToUpgrade = value;
				_columns[37] = value;
			}
		}
		ScopeRuntime.BooleanQColumnData s0_DeploymentServiceHealingEnabled;
		public ScopeRuntime.BooleanQColumnData DeploymentServiceHealingEnabled
		{
			get { return s0_DeploymentServiceHealingEnabled; }
			set
			{
				s0_DeploymentServiceHealingEnabled = value;
				_columns[38] = value;
			}
		}
		ScopeRuntime.IntegerQColumnData s0_DeploymentServiceInstanceCount;
		public ScopeRuntime.IntegerQColumnData DeploymentServiceInstanceCount
		{
			get { return s0_DeploymentServiceInstanceCount; }
			set
			{
				s0_DeploymentServiceInstanceCount = value;
				_columns[39] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_DeploymentSettings;
		public ScopeRuntime.StringColumnData DeploymentSettings
		{
			get { return s0_DeploymentSettings; }
			set
			{
				s0_DeploymentSettings = value;
				_columns[40] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_DeploymentStatus;
		public ScopeRuntime.StringColumnData DeploymentStatus
		{
			get { return s0_DeploymentStatus; }
			set
			{
				s0_DeploymentStatus = value;
				_columns[41] = value;
			}
		}
		ScopeRuntime.DateTimeQColumnData s0_DeploymentSupportInfoLastUpdated;
		public ScopeRuntime.DateTimeQColumnData DeploymentSupportInfoLastUpdated
		{
			get { return s0_DeploymentSupportInfoLastUpdated; }
			set
			{
				s0_DeploymentSupportInfoLastUpdated = value;
				_columns[42] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_DeploymentTransitionStatus;
		public ScopeRuntime.StringColumnData DeploymentTransitionStatus
		{
			get { return s0_DeploymentTransitionStatus; }
			set
			{
				s0_DeploymentTransitionStatus = value;
				_columns[43] = value;
			}
		}
		ScopeRuntime.BooleanQColumnData s0_DeploymentUpdateInProgress;
		public ScopeRuntime.BooleanQColumnData DeploymentUpdateInProgress
		{
			get { return s0_DeploymentUpdateInProgress; }
			set
			{
				s0_DeploymentUpdateInProgress = value;
				_columns[44] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_DeploymentUpdateType;
		public ScopeRuntime.StringColumnData DeploymentUpdateType
		{
			get { return s0_DeploymentUpdateType; }
			set
			{
				s0_DeploymentUpdateType = value;
				_columns[45] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_DeploymentVIP;
		public ScopeRuntime.StringColumnData DeploymentVIP
		{
			get { return s0_DeploymentVIP; }
			set
			{
				s0_DeploymentVIP = value;
				_columns[46] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_DeploymentVIPIPv6;
		public ScopeRuntime.StringColumnData DeploymentVIPIPv6
		{
			get { return s0_DeploymentVIPIPv6; }
			set
			{
				s0_DeploymentVIPIPv6 = value;
				_columns[47] = value;
			}
		}
		ScopeRuntime.IntegerQColumnData s0_DeploymentWeightedNumberOfExtraSmallRoleInstances;
		public ScopeRuntime.IntegerQColumnData DeploymentWeightedNumberOfExtraSmallRoleInstances
		{
			get { return s0_DeploymentWeightedNumberOfExtraSmallRoleInstances; }
			set
			{
				s0_DeploymentWeightedNumberOfExtraSmallRoleInstances = value;
				_columns[48] = value;
			}
		}
		ScopeRuntime.IntegerQColumnData s0_DeploymentWeightedNumberOfRoleInstances;
		public ScopeRuntime.IntegerQColumnData DeploymentWeightedNumberOfRoleInstances
		{
			get { return s0_DeploymentWeightedNumberOfRoleInstances; }
			set
			{
				s0_DeploymentWeightedNumberOfRoleInstances = value;
				_columns[49] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_FqdnSuffix;
		public ScopeRuntime.StringColumnData FqdnSuffix
		{
			get { return s0_FqdnSuffix; }
			set
			{
				s0_FqdnSuffix = value;
				_columns[50] = value;
			}
		}
		ScopeRuntime.BooleanQColumnData s0_IS_Current;
		public ScopeRuntime.BooleanQColumnData IS_Current
		{
			get { return s0_IS_Current; }
			set
			{
				s0_IS_Current = value;
				_columns[51] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_MigratedFrom;
		public ScopeRuntime.StringColumnData MigratedFrom
		{
			get { return s0_MigratedFrom; }
			set
			{
				s0_MigratedFrom = value;
				_columns[52] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_PackageRequiredFeatures;
		public ScopeRuntime.StringColumnData PackageRequiredFeatures
		{
			get { return s0_PackageRequiredFeatures; }
			set
			{
				s0_PackageRequiredFeatures = value;
				_columns[53] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_PersistentVMs;
		public ScopeRuntime.StringColumnData PersistentVMs
		{
			get { return s0_PersistentVMs; }
			set
			{
				s0_PersistentVMs = value;
				_columns[54] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_RoleOsMap;
		public ScopeRuntime.StringColumnData RoleOsMap
		{
			get { return s0_RoleOsMap; }
			set
			{
				s0_RoleOsMap = value;
				_columns[55] = value;
			}
		}
		ScopeRuntime.DateTimeQColumnData s0_SCD_EndDate;
		public ScopeRuntime.DateTimeQColumnData SCD_EndDate
		{
			get { return s0_SCD_EndDate; }
			set
			{
				s0_SCD_EndDate = value;
				_columns[56] = value;
			}
		}
		ScopeRuntime.DateTimeQColumnData s0_SCD_StartDate;
		public ScopeRuntime.DateTimeQColumnData SCD_StartDate
		{
			get { return s0_SCD_StartDate; }
			set
			{
				s0_SCD_StartDate = value;
				_columns[57] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_SdkVersion;
		public ScopeRuntime.StringColumnData SdkVersion
		{
			get { return s0_SdkVersion; }
			set
			{
				s0_SdkVersion = value;
				_columns[58] = value;
			}
		}
		ScopeRuntime.DateTimeQColumnData s0_TimeMigrated;
		public ScopeRuntime.DateTimeQColumnData TimeMigrated
		{
			get { return s0_TimeMigrated; }
			set
			{
				s0_TimeMigrated = value;
				_columns[59] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_endpoint;
		public ScopeRuntime.StringColumnData endpoint
		{
			get { return s0_endpoint; }
			set
			{
				s0_endpoint = value;
				_columns[60] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_SourceTableName;
		public ScopeRuntime.StringColumnData SourceTableName
		{
			get { return s0_SourceTableName; }
			set
			{
				s0_SourceTableName = value;
				_columns[61] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_AuditCreateDate;
		public ScopeRuntime.StringColumnData AuditCreateDate
		{
			get { return s0_AuditCreateDate; }
			set
			{
				s0_AuditCreateDate = value;
				_columns[62] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_AuditUpdateDate;
		public ScopeRuntime.StringColumnData AuditUpdateDate
		{
			get { return s0_AuditUpdateDate; }
			set
			{
				s0_AuditUpdateDate = value;
				_columns[63] = value;
			}
		}
		ScopeRuntime.DateTimeColumnData s0___date;
		public ScopeRuntime.DateTimeColumnData __date
		{
			get { return s0___date; }
			set
			{
				s0___date = value;
				_columns[64] = value;
			}
		}
		public Row_DB50E023E6902EA6(Schema schema, ColumnData[] columns) : base(schema, columns) { }
		public Row_DB50E023E6902EA6(Schema schema) : base(schema)
		{
			for (int i = 0; i < _columns.Length; ++i)
			{
				this[i] = _columns[i];
			}
		}
		public Row_DB50E023E6902EA6() : base(BuildSchema(), BuildColumnData())
		{
			for (int i = 0; i < _columns.Length; ++i)
			{
				this[i] = _columns[i];
			}
		}
		private static Schema BuildSchema()
		{
			Schema schema = new Schema();
			for (int i = 0; i < _columnTable.Length; ++i)
			{
				schema.Add(new ScopeRuntime.ColumnInfo(_columnTable[i].Item1, _columnTable[i].Item3));
			}
			return schema;
		}
		private static ColumnData[] BuildColumnData()
		{
			ColumnData[] columnData = new ColumnData[_columnTable.Length];
			for (int i = 0; i < _columnTable.Length; ++i)
			{
				columnData[i] = _columnTable[i].Item4 != null ? _columnTable[i].Item4() : ColumnDataFactory.Create(_columnTable[i].Item2);
			}
			return columnData;
		}
		public override ColumnData this[int index]
		{
			get { return _columns[index]; }
			set
			{
				_columns[index] = value;

				//  We also need to reset the property
				switch (index)
				{
					case 0:
						s0_SubscriptionGUID = (ScopeRuntime.StringColumnData)value;
						break;
					case 1:
						s0_DeploymentGUID = (ScopeRuntime.StringColumnData)value;
						break;
					case 2:
						s0_DeploymentName = (ScopeRuntime.StringColumnData)value;
						break;
					case 3:
						s0_DeploymentCreateTimestamp = (ScopeRuntime.DateTimeQColumnData)value;
						break;
					case 4:
						s0_HostedServiceName = (ScopeRuntime.StringColumnData)value;
						break;
					case 5:
						s0_FabricGeoId = (ScopeRuntime.StringColumnData)value;
						break;
					case 6:
						s0_DeploymentType = (ScopeRuntime.StringColumnData)value;
						break;
					case 7:
						s0_IsSystemDeployment = (ScopeRuntime.IntegerQColumnData)value;
						break;
					case 8:
						s0_DeploymentCSSInfoLastUpdated = (ScopeRuntime.DateTimeQColumnData)value;
						break;
					case 9:
						s0_DeploymentCurrentUpdateDomain = (ScopeRuntime.IntegerQColumnData)value;
						break;
					case 10:
						s0_DeploymentCurrentUpgradeDomain = (ScopeRuntime.IntegerQColumnData)value;
						break;
					case 11:
						s0_DeploymentCurrentUpgradeDomainState = (ScopeRuntime.IntegerQColumnData)value;
						break;
					case 12:
						s0_DeploymentDescription = (ScopeRuntime.StringColumnData)value;
						break;
					case 13:
						s0_DeploymentDNSGuid = (ScopeRuntime.StringColumnData)value;
						break;
					case 14:
						s0_DeploymentDNSName = (ScopeRuntime.StringColumnData)value;
						break;
					case 15:
						s0_DeploymentFabricTenantStatus = (ScopeRuntime.StringColumnData)value;
						break;
					case 16:
						s0_DeploymentGroup = (ScopeRuntime.StringColumnData)value;
						break;
					case 17:
						s0_DeploymentHost = (ScopeRuntime.StringColumnData)value;
						break;
					case 18:
						s0_DeploymentInputEndpoints = (ScopeRuntime.StringColumnData)value;
						break;
					case 19:
						s0_DeploymentKind = (ScopeRuntime.StringColumnData)value;
						break;
					case 20:
						s0_DeploymentLabel = (ScopeRuntime.StringColumnData)value;
						break;
					case 21:
						s0_DeploymentLastChangingOperationId = (ScopeRuntime.StringColumnData)value;
						break;
					case 22:
						s0_DeploymentLastChangingOperationStarted = (ScopeRuntime.DateTimeQColumnData)value;
						break;
					case 23:
						s0_DeploymentLastServiceHealingTime = (ScopeRuntime.DateTimeQColumnData)value;
						break;
					case 24:
						s0_DeploymentLastUpdated = (ScopeRuntime.DateTimeQColumnData)value;
						break;
					case 25:
						s0_DeploymentLastVipSwapFailed = (ScopeRuntime.BooleanQColumnData)value;
						break;
					case 26:
						s0_DeploymentLastVipSwapFailedTime = (ScopeRuntime.DateTimeQColumnData)value;
						break;
					case 27:
						s0_DeploymentNumUpgradeDomains = (ScopeRuntime.IntegerQColumnData)value;
						break;
					case 28:
						s0_DeploymentOsUpgradePolicy = (ScopeRuntime.StringColumnData)value;
						break;
					case 29:
						s0_DeploymentOsVersion = (ScopeRuntime.StringColumnData)value;
						break;
					case 30:
						s0_DeploymentProgressStatus = (ScopeRuntime.StringColumnData)value;
						break;
					case 31:
						s0_DeploymentRoleInstanceDetails = (ScopeRuntime.StringColumnData)value;
						break;
					case 32:
						s0_DeploymentRoleObjects = (ScopeRuntime.StringColumnData)value;
						break;
					case 33:
						s0_DeploymentRoles = (ScopeRuntime.StringColumnData)value;
						break;
					case 34:
						s0_DeploymentRolesCSSInfoLastUpdated = (ScopeRuntime.DateTimeQColumnData)value;
						break;
					case 35:
						s0_DeploymentRolesLastUpdated = (ScopeRuntime.DateTimeQColumnData)value;
						break;
					case 36:
						s0_DeploymentRolesSupportInfoLastUpdated = (ScopeRuntime.DateTimeQColumnData)value;
						break;
					case 37:
						s0_DeploymentRoleToUpgrade = (ScopeRuntime.StringColumnData)value;
						break;
					case 38:
						s0_DeploymentServiceHealingEnabled = (ScopeRuntime.BooleanQColumnData)value;
						break;
					case 39:
						s0_DeploymentServiceInstanceCount = (ScopeRuntime.IntegerQColumnData)value;
						break;
					case 40:
						s0_DeploymentSettings = (ScopeRuntime.StringColumnData)value;
						break;
					case 41:
						s0_DeploymentStatus = (ScopeRuntime.StringColumnData)value;
						break;
					case 42:
						s0_DeploymentSupportInfoLastUpdated = (ScopeRuntime.DateTimeQColumnData)value;
						break;
					case 43:
						s0_DeploymentTransitionStatus = (ScopeRuntime.StringColumnData)value;
						break;
					case 44:
						s0_DeploymentUpdateInProgress = (ScopeRuntime.BooleanQColumnData)value;
						break;
					case 45:
						s0_DeploymentUpdateType = (ScopeRuntime.StringColumnData)value;
						break;
					case 46:
						s0_DeploymentVIP = (ScopeRuntime.StringColumnData)value;
						break;
					case 47:
						s0_DeploymentVIPIPv6 = (ScopeRuntime.StringColumnData)value;
						break;
					case 48:
						s0_DeploymentWeightedNumberOfExtraSmallRoleInstances = (ScopeRuntime.IntegerQColumnData)value;
						break;
					case 49:
						s0_DeploymentWeightedNumberOfRoleInstances = (ScopeRuntime.IntegerQColumnData)value;
						break;
					case 50:
						s0_FqdnSuffix = (ScopeRuntime.StringColumnData)value;
						break;
					case 51:
						s0_IS_Current = (ScopeRuntime.BooleanQColumnData)value;
						break;
					case 52:
						s0_MigratedFrom = (ScopeRuntime.StringColumnData)value;
						break;
					case 53:
						s0_PackageRequiredFeatures = (ScopeRuntime.StringColumnData)value;
						break;
					case 54:
						s0_PersistentVMs = (ScopeRuntime.StringColumnData)value;
						break;
					case 55:
						s0_RoleOsMap = (ScopeRuntime.StringColumnData)value;
						break;
					case 56:
						s0_SCD_EndDate = (ScopeRuntime.DateTimeQColumnData)value;
						break;
					case 57:
						s0_SCD_StartDate = (ScopeRuntime.DateTimeQColumnData)value;
						break;
					case 58:
						s0_SdkVersion = (ScopeRuntime.StringColumnData)value;
						break;
					case 59:
						s0_TimeMigrated = (ScopeRuntime.DateTimeQColumnData)value;
						break;
					case 60:
						s0_endpoint = (ScopeRuntime.StringColumnData)value;
						break;
					case 61:
						s0_SourceTableName = (ScopeRuntime.StringColumnData)value;
						break;
					case 62:
						s0_AuditCreateDate = (ScopeRuntime.StringColumnData)value;
						break;
					case 63:
						s0_AuditUpdateDate = (ScopeRuntime.StringColumnData)value;
						break;
					case 64:
						s0___date = (ScopeRuntime.DateTimeColumnData)value;
						break;
				}
			}
		}
		public override void Serialize(BinaryWriter writer)
		{
			byte[] ___masking___ = new byte[9];
			___masking___[0] = 1;
			___masking___[1] = 0;
			___masking___[2] = 0;
			___masking___[3] = 0;
			___masking___[4] = 0;
			___masking___[5] = 0;
			___masking___[6] = 0;
			___masking___[7] = 0;
			___masking___[8] = 0;

			bool hasNull = false;
			if (s0_SubscriptionGUID.IsNull())
			{
				hasNull = true;
				___masking___[0] |= (byte)(1 << 1);
			}
			if (s0_DeploymentGUID.IsNull())
			{
				hasNull = true;
				___masking___[0] |= (byte)(1 << 2);
			}
			if (s0_DeploymentName.IsNull())
			{
				hasNull = true;
				___masking___[0] |= (byte)(1 << 3);
			}
			if (s0_DeploymentCreateTimestamp.IsNull())
			{
				hasNull = true;
				___masking___[0] |= (byte)(1 << 4);
			}
			if (s0_HostedServiceName.IsNull())
			{
				hasNull = true;
				___masking___[0] |= (byte)(1 << 5);
			}
			if (s0_FabricGeoId.IsNull())
			{
				hasNull = true;
				___masking___[0] |= (byte)(1 << 6);
			}
			if (s0_DeploymentType.IsNull())
			{
				hasNull = true;
				___masking___[0] |= (byte)(1 << 7);
			}
			if (s0_IsSystemDeployment.IsNull())
			{
				hasNull = true;
				___masking___[1] |= (byte)(1 << 0);
			}
			if (s0_DeploymentCSSInfoLastUpdated.IsNull())
			{
				hasNull = true;
				___masking___[1] |= (byte)(1 << 1);
			}
			if (s0_DeploymentCurrentUpdateDomain.IsNull())
			{
				hasNull = true;
				___masking___[1] |= (byte)(1 << 2);
			}
			if (s0_DeploymentCurrentUpgradeDomain.IsNull())
			{
				hasNull = true;
				___masking___[1] |= (byte)(1 << 3);
			}
			if (s0_DeploymentCurrentUpgradeDomainState.IsNull())
			{
				hasNull = true;
				___masking___[1] |= (byte)(1 << 4);
			}
			if (s0_DeploymentDescription.IsNull())
			{
				hasNull = true;
				___masking___[1] |= (byte)(1 << 5);
			}
			if (s0_DeploymentDNSGuid.IsNull())
			{
				hasNull = true;
				___masking___[1] |= (byte)(1 << 6);
			}
			if (s0_DeploymentDNSName.IsNull())
			{
				hasNull = true;
				___masking___[1] |= (byte)(1 << 7);
			}
			if (s0_DeploymentFabricTenantStatus.IsNull())
			{
				hasNull = true;
				___masking___[2] |= (byte)(1 << 0);
			}
			if (s0_DeploymentGroup.IsNull())
			{
				hasNull = true;
				___masking___[2] |= (byte)(1 << 1);
			}
			if (s0_DeploymentHost.IsNull())
			{
				hasNull = true;
				___masking___[2] |= (byte)(1 << 2);
			}
			if (s0_DeploymentInputEndpoints.IsNull())
			{
				hasNull = true;
				___masking___[2] |= (byte)(1 << 3);
			}
			if (s0_DeploymentKind.IsNull())
			{
				hasNull = true;
				___masking___[2] |= (byte)(1 << 4);
			}
			if (s0_DeploymentLabel.IsNull())
			{
				hasNull = true;
				___masking___[2] |= (byte)(1 << 5);
			}
			if (s0_DeploymentLastChangingOperationId.IsNull())
			{
				hasNull = true;
				___masking___[2] |= (byte)(1 << 6);
			}
			if (s0_DeploymentLastChangingOperationStarted.IsNull())
			{
				hasNull = true;
				___masking___[2] |= (byte)(1 << 7);
			}
			if (s0_DeploymentLastServiceHealingTime.IsNull())
			{
				hasNull = true;
				___masking___[3] |= (byte)(1 << 0);
			}
			if (s0_DeploymentLastUpdated.IsNull())
			{
				hasNull = true;
				___masking___[3] |= (byte)(1 << 1);
			}
			if (s0_DeploymentLastVipSwapFailed.IsNull())
			{
				hasNull = true;
				___masking___[3] |= (byte)(1 << 2);
			}
			if (s0_DeploymentLastVipSwapFailedTime.IsNull())
			{
				hasNull = true;
				___masking___[3] |= (byte)(1 << 3);
			}
			if (s0_DeploymentNumUpgradeDomains.IsNull())
			{
				hasNull = true;
				___masking___[3] |= (byte)(1 << 4);
			}
			if (s0_DeploymentOsUpgradePolicy.IsNull())
			{
				hasNull = true;
				___masking___[3] |= (byte)(1 << 5);
			}
			if (s0_DeploymentOsVersion.IsNull())
			{
				hasNull = true;
				___masking___[3] |= (byte)(1 << 6);
			}
			if (s0_DeploymentProgressStatus.IsNull())
			{
				hasNull = true;
				___masking___[3] |= (byte)(1 << 7);
			}
			if (s0_DeploymentRoleInstanceDetails.IsNull())
			{
				hasNull = true;
				___masking___[4] |= (byte)(1 << 0);
			}
			if (s0_DeploymentRoleObjects.IsNull())
			{
				hasNull = true;
				___masking___[4] |= (byte)(1 << 1);
			}
			if (s0_DeploymentRoles.IsNull())
			{
				hasNull = true;
				___masking___[4] |= (byte)(1 << 2);
			}
			if (s0_DeploymentRolesCSSInfoLastUpdated.IsNull())
			{
				hasNull = true;
				___masking___[4] |= (byte)(1 << 3);
			}
			if (s0_DeploymentRolesLastUpdated.IsNull())
			{
				hasNull = true;
				___masking___[4] |= (byte)(1 << 4);
			}
			if (s0_DeploymentRolesSupportInfoLastUpdated.IsNull())
			{
				hasNull = true;
				___masking___[4] |= (byte)(1 << 5);
			}
			if (s0_DeploymentRoleToUpgrade.IsNull())
			{
				hasNull = true;
				___masking___[4] |= (byte)(1 << 6);
			}
			if (s0_DeploymentServiceHealingEnabled.IsNull())
			{
				hasNull = true;
				___masking___[4] |= (byte)(1 << 7);
			}
			if (s0_DeploymentServiceInstanceCount.IsNull())
			{
				hasNull = true;
				___masking___[5] |= (byte)(1 << 0);
			}
			if (s0_DeploymentSettings.IsNull())
			{
				hasNull = true;
				___masking___[5] |= (byte)(1 << 1);
			}
			if (s0_DeploymentStatus.IsNull())
			{
				hasNull = true;
				___masking___[5] |= (byte)(1 << 2);
			}
			if (s0_DeploymentSupportInfoLastUpdated.IsNull())
			{
				hasNull = true;
				___masking___[5] |= (byte)(1 << 3);
			}
			if (s0_DeploymentTransitionStatus.IsNull())
			{
				hasNull = true;
				___masking___[5] |= (byte)(1 << 4);
			}
			if (s0_DeploymentUpdateInProgress.IsNull())
			{
				hasNull = true;
				___masking___[5] |= (byte)(1 << 5);
			}
			if (s0_DeploymentUpdateType.IsNull())
			{
				hasNull = true;
				___masking___[5] |= (byte)(1 << 6);
			}
			if (s0_DeploymentVIP.IsNull())
			{
				hasNull = true;
				___masking___[5] |= (byte)(1 << 7);
			}
			if (s0_DeploymentVIPIPv6.IsNull())
			{
				hasNull = true;
				___masking___[6] |= (byte)(1 << 0);
			}
			if (s0_DeploymentWeightedNumberOfExtraSmallRoleInstances.IsNull())
			{
				hasNull = true;
				___masking___[6] |= (byte)(1 << 1);
			}
			if (s0_DeploymentWeightedNumberOfRoleInstances.IsNull())
			{
				hasNull = true;
				___masking___[6] |= (byte)(1 << 2);
			}
			if (s0_FqdnSuffix.IsNull())
			{
				hasNull = true;
				___masking___[6] |= (byte)(1 << 3);
			}
			if (s0_IS_Current.IsNull())
			{
				hasNull = true;
				___masking___[6] |= (byte)(1 << 4);
			}
			if (s0_MigratedFrom.IsNull())
			{
				hasNull = true;
				___masking___[6] |= (byte)(1 << 5);
			}
			if (s0_PackageRequiredFeatures.IsNull())
			{
				hasNull = true;
				___masking___[6] |= (byte)(1 << 6);
			}
			if (s0_PersistentVMs.IsNull())
			{
				hasNull = true;
				___masking___[6] |= (byte)(1 << 7);
			}
			if (s0_RoleOsMap.IsNull())
			{
				hasNull = true;
				___masking___[7] |= (byte)(1 << 0);
			}
			if (s0_SCD_EndDate.IsNull())
			{
				hasNull = true;
				___masking___[7] |= (byte)(1 << 1);
			}
			if (s0_SCD_StartDate.IsNull())
			{
				hasNull = true;
				___masking___[7] |= (byte)(1 << 2);
			}
			if (s0_SdkVersion.IsNull())
			{
				hasNull = true;
				___masking___[7] |= (byte)(1 << 3);
			}
			if (s0_TimeMigrated.IsNull())
			{
				hasNull = true;
				___masking___[7] |= (byte)(1 << 4);
			}
			if (s0_endpoint.IsNull())
			{
				hasNull = true;
				___masking___[7] |= (byte)(1 << 5);
			}
			if (s0_SourceTableName.IsNull())
			{
				hasNull = true;
				___masking___[7] |= (byte)(1 << 6);
			}
			if (s0_AuditCreateDate.IsNull())
			{
				hasNull = true;
				___masking___[7] |= (byte)(1 << 7);
			}
			if (s0_AuditUpdateDate.IsNull())
			{
				hasNull = true;
				___masking___[8] |= (byte)(1 << 0);
			}
			if (hasNull)
			{
				writer.Write(___masking___[0]);
				writer.Write(___masking___[1]);
				writer.Write(___masking___[2]);
				writer.Write(___masking___[3]);
				writer.Write(___masking___[4]);
				writer.Write(___masking___[5]);
				writer.Write(___masking___[6]);
				writer.Write(___masking___[7]);
				writer.Write(___masking___[8]);
			}
			else
			{
				writer.Write( (byte) 0);
			}
			if (!s0_SubscriptionGUID.IsNull())
			{
				s0_SubscriptionGUID.Serialize(writer);
			}
			if (!s0_DeploymentGUID.IsNull())
			{
				s0_DeploymentGUID.Serialize(writer);
			}
			if (!s0_DeploymentName.IsNull())
			{
				s0_DeploymentName.Serialize(writer);
			}
			if (!s0_DeploymentCreateTimestamp.IsNull())
			{
				s0_DeploymentCreateTimestamp.Serialize(writer);
			}
			if (!s0_HostedServiceName.IsNull())
			{
				s0_HostedServiceName.Serialize(writer);
			}
			if (!s0_FabricGeoId.IsNull())
			{
				s0_FabricGeoId.Serialize(writer);
			}
			if (!s0_DeploymentType.IsNull())
			{
				s0_DeploymentType.Serialize(writer);
			}
			if (!s0_IsSystemDeployment.IsNull())
			{
				s0_IsSystemDeployment.Serialize(writer);
			}
			if (!s0_DeploymentCSSInfoLastUpdated.IsNull())
			{
				s0_DeploymentCSSInfoLastUpdated.Serialize(writer);
			}
			if (!s0_DeploymentCurrentUpdateDomain.IsNull())
			{
				s0_DeploymentCurrentUpdateDomain.Serialize(writer);
			}
			if (!s0_DeploymentCurrentUpgradeDomain.IsNull())
			{
				s0_DeploymentCurrentUpgradeDomain.Serialize(writer);
			}
			if (!s0_DeploymentCurrentUpgradeDomainState.IsNull())
			{
				s0_DeploymentCurrentUpgradeDomainState.Serialize(writer);
			}
			if (!s0_DeploymentDescription.IsNull())
			{
				s0_DeploymentDescription.Serialize(writer);
			}
			if (!s0_DeploymentDNSGuid.IsNull())
			{
				s0_DeploymentDNSGuid.Serialize(writer);
			}
			if (!s0_DeploymentDNSName.IsNull())
			{
				s0_DeploymentDNSName.Serialize(writer);
			}
			if (!s0_DeploymentFabricTenantStatus.IsNull())
			{
				s0_DeploymentFabricTenantStatus.Serialize(writer);
			}
			if (!s0_DeploymentGroup.IsNull())
			{
				s0_DeploymentGroup.Serialize(writer);
			}
			if (!s0_DeploymentHost.IsNull())
			{
				s0_DeploymentHost.Serialize(writer);
			}
			if (!s0_DeploymentInputEndpoints.IsNull())
			{
				s0_DeploymentInputEndpoints.Serialize(writer);
			}
			if (!s0_DeploymentKind.IsNull())
			{
				s0_DeploymentKind.Serialize(writer);
			}
			if (!s0_DeploymentLabel.IsNull())
			{
				s0_DeploymentLabel.Serialize(writer);
			}
			if (!s0_DeploymentLastChangingOperationId.IsNull())
			{
				s0_DeploymentLastChangingOperationId.Serialize(writer);
			}
			if (!s0_DeploymentLastChangingOperationStarted.IsNull())
			{
				s0_DeploymentLastChangingOperationStarted.Serialize(writer);
			}
			if (!s0_DeploymentLastServiceHealingTime.IsNull())
			{
				s0_DeploymentLastServiceHealingTime.Serialize(writer);
			}
			if (!s0_DeploymentLastUpdated.IsNull())
			{
				s0_DeploymentLastUpdated.Serialize(writer);
			}
			if (!s0_DeploymentLastVipSwapFailed.IsNull())
			{
				s0_DeploymentLastVipSwapFailed.Serialize(writer);
			}
			if (!s0_DeploymentLastVipSwapFailedTime.IsNull())
			{
				s0_DeploymentLastVipSwapFailedTime.Serialize(writer);
			}
			if (!s0_DeploymentNumUpgradeDomains.IsNull())
			{
				s0_DeploymentNumUpgradeDomains.Serialize(writer);
			}
			if (!s0_DeploymentOsUpgradePolicy.IsNull())
			{
				s0_DeploymentOsUpgradePolicy.Serialize(writer);
			}
			if (!s0_DeploymentOsVersion.IsNull())
			{
				s0_DeploymentOsVersion.Serialize(writer);
			}
			if (!s0_DeploymentProgressStatus.IsNull())
			{
				s0_DeploymentProgressStatus.Serialize(writer);
			}
			if (!s0_DeploymentRoleInstanceDetails.IsNull())
			{
				s0_DeploymentRoleInstanceDetails.Serialize(writer);
			}
			if (!s0_DeploymentRoleObjects.IsNull())
			{
				s0_DeploymentRoleObjects.Serialize(writer);
			}
			if (!s0_DeploymentRoles.IsNull())
			{
				s0_DeploymentRoles.Serialize(writer);
			}
			if (!s0_DeploymentRolesCSSInfoLastUpdated.IsNull())
			{
				s0_DeploymentRolesCSSInfoLastUpdated.Serialize(writer);
			}
			if (!s0_DeploymentRolesLastUpdated.IsNull())
			{
				s0_DeploymentRolesLastUpdated.Serialize(writer);
			}
			if (!s0_DeploymentRolesSupportInfoLastUpdated.IsNull())
			{
				s0_DeploymentRolesSupportInfoLastUpdated.Serialize(writer);
			}
			if (!s0_DeploymentRoleToUpgrade.IsNull())
			{
				s0_DeploymentRoleToUpgrade.Serialize(writer);
			}
			if (!s0_DeploymentServiceHealingEnabled.IsNull())
			{
				s0_DeploymentServiceHealingEnabled.Serialize(writer);
			}
			if (!s0_DeploymentServiceInstanceCount.IsNull())
			{
				s0_DeploymentServiceInstanceCount.Serialize(writer);
			}
			if (!s0_DeploymentSettings.IsNull())
			{
				s0_DeploymentSettings.Serialize(writer);
			}
			if (!s0_DeploymentStatus.IsNull())
			{
				s0_DeploymentStatus.Serialize(writer);
			}
			if (!s0_DeploymentSupportInfoLastUpdated.IsNull())
			{
				s0_DeploymentSupportInfoLastUpdated.Serialize(writer);
			}
			if (!s0_DeploymentTransitionStatus.IsNull())
			{
				s0_DeploymentTransitionStatus.Serialize(writer);
			}
			if (!s0_DeploymentUpdateInProgress.IsNull())
			{
				s0_DeploymentUpdateInProgress.Serialize(writer);
			}
			if (!s0_DeploymentUpdateType.IsNull())
			{
				s0_DeploymentUpdateType.Serialize(writer);
			}
			if (!s0_DeploymentVIP.IsNull())
			{
				s0_DeploymentVIP.Serialize(writer);
			}
			if (!s0_DeploymentVIPIPv6.IsNull())
			{
				s0_DeploymentVIPIPv6.Serialize(writer);
			}
			if (!s0_DeploymentWeightedNumberOfExtraSmallRoleInstances.IsNull())
			{
				s0_DeploymentWeightedNumberOfExtraSmallRoleInstances.Serialize(writer);
			}
			if (!s0_DeploymentWeightedNumberOfRoleInstances.IsNull())
			{
				s0_DeploymentWeightedNumberOfRoleInstances.Serialize(writer);
			}
			if (!s0_FqdnSuffix.IsNull())
			{
				s0_FqdnSuffix.Serialize(writer);
			}
			if (!s0_IS_Current.IsNull())
			{
				s0_IS_Current.Serialize(writer);
			}
			if (!s0_MigratedFrom.IsNull())
			{
				s0_MigratedFrom.Serialize(writer);
			}
			if (!s0_PackageRequiredFeatures.IsNull())
			{
				s0_PackageRequiredFeatures.Serialize(writer);
			}
			if (!s0_PersistentVMs.IsNull())
			{
				s0_PersistentVMs.Serialize(writer);
			}
			if (!s0_RoleOsMap.IsNull())
			{
				s0_RoleOsMap.Serialize(writer);
			}
			if (!s0_SCD_EndDate.IsNull())
			{
				s0_SCD_EndDate.Serialize(writer);
			}
			if (!s0_SCD_StartDate.IsNull())
			{
				s0_SCD_StartDate.Serialize(writer);
			}
			if (!s0_SdkVersion.IsNull())
			{
				s0_SdkVersion.Serialize(writer);
			}
			if (!s0_TimeMigrated.IsNull())
			{
				s0_TimeMigrated.Serialize(writer);
			}
			if (!s0_endpoint.IsNull())
			{
				s0_endpoint.Serialize(writer);
			}
			if (!s0_SourceTableName.IsNull())
			{
				s0_SourceTableName.Serialize(writer);
			}
			if (!s0_AuditCreateDate.IsNull())
			{
				s0_AuditCreateDate.Serialize(writer);
			}
			if (!s0_AuditUpdateDate.IsNull())
			{
				s0_AuditUpdateDate.Serialize(writer);
			}
			s0___date.Serialize(writer);
		}

		public override void Deserialize(BinaryReader reader)
		{
			byte[] ___masking___ = new byte[9];
			byte firstByte = reader.ReadByte();
			if (firstByte == 0)
			{
				s0_SubscriptionGUID.Deserialize(reader);
				s0_DeploymentGUID.Deserialize(reader);
				s0_DeploymentName.Deserialize(reader);
				s0_DeploymentCreateTimestamp.Deserialize(reader);
				s0_HostedServiceName.Deserialize(reader);
				s0_FabricGeoId.Deserialize(reader);
				s0_DeploymentType.Deserialize(reader);
				s0_IsSystemDeployment.Deserialize(reader);
				s0_DeploymentCSSInfoLastUpdated.Deserialize(reader);
				s0_DeploymentCurrentUpdateDomain.Deserialize(reader);
				s0_DeploymentCurrentUpgradeDomain.Deserialize(reader);
				s0_DeploymentCurrentUpgradeDomainState.Deserialize(reader);
				s0_DeploymentDescription.Deserialize(reader);
				s0_DeploymentDNSGuid.Deserialize(reader);
				s0_DeploymentDNSName.Deserialize(reader);
				s0_DeploymentFabricTenantStatus.Deserialize(reader);
				s0_DeploymentGroup.Deserialize(reader);
				s0_DeploymentHost.Deserialize(reader);
				s0_DeploymentInputEndpoints.Deserialize(reader);
				s0_DeploymentKind.Deserialize(reader);
				s0_DeploymentLabel.Deserialize(reader);
				s0_DeploymentLastChangingOperationId.Deserialize(reader);
				s0_DeploymentLastChangingOperationStarted.Deserialize(reader);
				s0_DeploymentLastServiceHealingTime.Deserialize(reader);
				s0_DeploymentLastUpdated.Deserialize(reader);
				s0_DeploymentLastVipSwapFailed.Deserialize(reader);
				s0_DeploymentLastVipSwapFailedTime.Deserialize(reader);
				s0_DeploymentNumUpgradeDomains.Deserialize(reader);
				s0_DeploymentOsUpgradePolicy.Deserialize(reader);
				s0_DeploymentOsVersion.Deserialize(reader);
				s0_DeploymentProgressStatus.Deserialize(reader);
				s0_DeploymentRoleInstanceDetails.Deserialize(reader);
				s0_DeploymentRoleObjects.Deserialize(reader);
				s0_DeploymentRoles.Deserialize(reader);
				s0_DeploymentRolesCSSInfoLastUpdated.Deserialize(reader);
				s0_DeploymentRolesLastUpdated.Deserialize(reader);
				s0_DeploymentRolesSupportInfoLastUpdated.Deserialize(reader);
				s0_DeploymentRoleToUpgrade.Deserialize(reader);
				s0_DeploymentServiceHealingEnabled.Deserialize(reader);
				s0_DeploymentServiceInstanceCount.Deserialize(reader);
				s0_DeploymentSettings.Deserialize(reader);
				s0_DeploymentStatus.Deserialize(reader);
				s0_DeploymentSupportInfoLastUpdated.Deserialize(reader);
				s0_DeploymentTransitionStatus.Deserialize(reader);
				s0_DeploymentUpdateInProgress.Deserialize(reader);
				s0_DeploymentUpdateType.Deserialize(reader);
				s0_DeploymentVIP.Deserialize(reader);
				s0_DeploymentVIPIPv6.Deserialize(reader);
				s0_DeploymentWeightedNumberOfExtraSmallRoleInstances.Deserialize(reader);
				s0_DeploymentWeightedNumberOfRoleInstances.Deserialize(reader);
				s0_FqdnSuffix.Deserialize(reader);
				s0_IS_Current.Deserialize(reader);
				s0_MigratedFrom.Deserialize(reader);
				s0_PackageRequiredFeatures.Deserialize(reader);
				s0_PersistentVMs.Deserialize(reader);
				s0_RoleOsMap.Deserialize(reader);
				s0_SCD_EndDate.Deserialize(reader);
				s0_SCD_StartDate.Deserialize(reader);
				s0_SdkVersion.Deserialize(reader);
				s0_TimeMigrated.Deserialize(reader);
				s0_endpoint.Deserialize(reader);
				s0_SourceTableName.Deserialize(reader);
				s0_AuditCreateDate.Deserialize(reader);
				s0_AuditUpdateDate.Deserialize(reader);
				s0___date.Deserialize(reader);
			}
			else
			{
				___masking___[0] = firstByte;
				___masking___[1] = reader.ReadByte();
				___masking___[2] = reader.ReadByte();
				___masking___[3] = reader.ReadByte();
				___masking___[4] = reader.ReadByte();
				___masking___[5] = reader.ReadByte();
				___masking___[6] = reader.ReadByte();
				___masking___[7] = reader.ReadByte();
				___masking___[8] = reader.ReadByte();
				if ((___masking___[0] & 2) != 2)
				{
					s0_SubscriptionGUID.Deserialize(reader);
				}
				else
				{
					s0_SubscriptionGUID.SetNull();
				}
				if ((___masking___[0] & 4) != 4)
				{
					s0_DeploymentGUID.Deserialize(reader);
				}
				else
				{
					s0_DeploymentGUID.SetNull();
				}
				if ((___masking___[0] & 8) != 8)
				{
					s0_DeploymentName.Deserialize(reader);
				}
				else
				{
					s0_DeploymentName.SetNull();
				}
				if ((___masking___[0] & 16) != 16)
				{
					s0_DeploymentCreateTimestamp.Deserialize(reader);
				}
				else
				{
					s0_DeploymentCreateTimestamp.SetNull();
				}
				if ((___masking___[0] & 32) != 32)
				{
					s0_HostedServiceName.Deserialize(reader);
				}
				else
				{
					s0_HostedServiceName.SetNull();
				}
				if ((___masking___[0] & 64) != 64)
				{
					s0_FabricGeoId.Deserialize(reader);
				}
				else
				{
					s0_FabricGeoId.SetNull();
				}
				if ((___masking___[0] & 128) != 128)
				{
					s0_DeploymentType.Deserialize(reader);
				}
				else
				{
					s0_DeploymentType.SetNull();
				}
				if ((___masking___[1] & 1) != 1)
				{
					s0_IsSystemDeployment.Deserialize(reader);
				}
				else
				{
					s0_IsSystemDeployment.SetNull();
				}
				if ((___masking___[1] & 2) != 2)
				{
					s0_DeploymentCSSInfoLastUpdated.Deserialize(reader);
				}
				else
				{
					s0_DeploymentCSSInfoLastUpdated.SetNull();
				}
				if ((___masking___[1] & 4) != 4)
				{
					s0_DeploymentCurrentUpdateDomain.Deserialize(reader);
				}
				else
				{
					s0_DeploymentCurrentUpdateDomain.SetNull();
				}
				if ((___masking___[1] & 8) != 8)
				{
					s0_DeploymentCurrentUpgradeDomain.Deserialize(reader);
				}
				else
				{
					s0_DeploymentCurrentUpgradeDomain.SetNull();
				}
				if ((___masking___[1] & 16) != 16)
				{
					s0_DeploymentCurrentUpgradeDomainState.Deserialize(reader);
				}
				else
				{
					s0_DeploymentCurrentUpgradeDomainState.SetNull();
				}
				if ((___masking___[1] & 32) != 32)
				{
					s0_DeploymentDescription.Deserialize(reader);
				}
				else
				{
					s0_DeploymentDescription.SetNull();
				}
				if ((___masking___[1] & 64) != 64)
				{
					s0_DeploymentDNSGuid.Deserialize(reader);
				}
				else
				{
					s0_DeploymentDNSGuid.SetNull();
				}
				if ((___masking___[1] & 128) != 128)
				{
					s0_DeploymentDNSName.Deserialize(reader);
				}
				else
				{
					s0_DeploymentDNSName.SetNull();
				}
				if ((___masking___[2] & 1) != 1)
				{
					s0_DeploymentFabricTenantStatus.Deserialize(reader);
				}
				else
				{
					s0_DeploymentFabricTenantStatus.SetNull();
				}
				if ((___masking___[2] & 2) != 2)
				{
					s0_DeploymentGroup.Deserialize(reader);
				}
				else
				{
					s0_DeploymentGroup.SetNull();
				}
				if ((___masking___[2] & 4) != 4)
				{
					s0_DeploymentHost.Deserialize(reader);
				}
				else
				{
					s0_DeploymentHost.SetNull();
				}
				if ((___masking___[2] & 8) != 8)
				{
					s0_DeploymentInputEndpoints.Deserialize(reader);
				}
				else
				{
					s0_DeploymentInputEndpoints.SetNull();
				}
				if ((___masking___[2] & 16) != 16)
				{
					s0_DeploymentKind.Deserialize(reader);
				}
				else
				{
					s0_DeploymentKind.SetNull();
				}
				if ((___masking___[2] & 32) != 32)
				{
					s0_DeploymentLabel.Deserialize(reader);
				}
				else
				{
					s0_DeploymentLabel.SetNull();
				}
				if ((___masking___[2] & 64) != 64)
				{
					s0_DeploymentLastChangingOperationId.Deserialize(reader);
				}
				else
				{
					s0_DeploymentLastChangingOperationId.SetNull();
				}
				if ((___masking___[2] & 128) != 128)
				{
					s0_DeploymentLastChangingOperationStarted.Deserialize(reader);
				}
				else
				{
					s0_DeploymentLastChangingOperationStarted.SetNull();
				}
				if ((___masking___[3] & 1) != 1)
				{
					s0_DeploymentLastServiceHealingTime.Deserialize(reader);
				}
				else
				{
					s0_DeploymentLastServiceHealingTime.SetNull();
				}
				if ((___masking___[3] & 2) != 2)
				{
					s0_DeploymentLastUpdated.Deserialize(reader);
				}
				else
				{
					s0_DeploymentLastUpdated.SetNull();
				}
				if ((___masking___[3] & 4) != 4)
				{
					s0_DeploymentLastVipSwapFailed.Deserialize(reader);
				}
				else
				{
					s0_DeploymentLastVipSwapFailed.SetNull();
				}
				if ((___masking___[3] & 8) != 8)
				{
					s0_DeploymentLastVipSwapFailedTime.Deserialize(reader);
				}
				else
				{
					s0_DeploymentLastVipSwapFailedTime.SetNull();
				}
				if ((___masking___[3] & 16) != 16)
				{
					s0_DeploymentNumUpgradeDomains.Deserialize(reader);
				}
				else
				{
					s0_DeploymentNumUpgradeDomains.SetNull();
				}
				if ((___masking___[3] & 32) != 32)
				{
					s0_DeploymentOsUpgradePolicy.Deserialize(reader);
				}
				else
				{
					s0_DeploymentOsUpgradePolicy.SetNull();
				}
				if ((___masking___[3] & 64) != 64)
				{
					s0_DeploymentOsVersion.Deserialize(reader);
				}
				else
				{
					s0_DeploymentOsVersion.SetNull();
				}
				if ((___masking___[3] & 128) != 128)
				{
					s0_DeploymentProgressStatus.Deserialize(reader);
				}
				else
				{
					s0_DeploymentProgressStatus.SetNull();
				}
				if ((___masking___[4] & 1) != 1)
				{
					s0_DeploymentRoleInstanceDetails.Deserialize(reader);
				}
				else
				{
					s0_DeploymentRoleInstanceDetails.SetNull();
				}
				if ((___masking___[4] & 2) != 2)
				{
					s0_DeploymentRoleObjects.Deserialize(reader);
				}
				else
				{
					s0_DeploymentRoleObjects.SetNull();
				}
				if ((___masking___[4] & 4) != 4)
				{
					s0_DeploymentRoles.Deserialize(reader);
				}
				else
				{
					s0_DeploymentRoles.SetNull();
				}
				if ((___masking___[4] & 8) != 8)
				{
					s0_DeploymentRolesCSSInfoLastUpdated.Deserialize(reader);
				}
				else
				{
					s0_DeploymentRolesCSSInfoLastUpdated.SetNull();
				}
				if ((___masking___[4] & 16) != 16)
				{
					s0_DeploymentRolesLastUpdated.Deserialize(reader);
				}
				else
				{
					s0_DeploymentRolesLastUpdated.SetNull();
				}
				if ((___masking___[4] & 32) != 32)
				{
					s0_DeploymentRolesSupportInfoLastUpdated.Deserialize(reader);
				}
				else
				{
					s0_DeploymentRolesSupportInfoLastUpdated.SetNull();
				}
				if ((___masking___[4] & 64) != 64)
				{
					s0_DeploymentRoleToUpgrade.Deserialize(reader);
				}
				else
				{
					s0_DeploymentRoleToUpgrade.SetNull();
				}
				if ((___masking___[4] & 128) != 128)
				{
					s0_DeploymentServiceHealingEnabled.Deserialize(reader);
				}
				else
				{
					s0_DeploymentServiceHealingEnabled.SetNull();
				}
				if ((___masking___[5] & 1) != 1)
				{
					s0_DeploymentServiceInstanceCount.Deserialize(reader);
				}
				else
				{
					s0_DeploymentServiceInstanceCount.SetNull();
				}
				if ((___masking___[5] & 2) != 2)
				{
					s0_DeploymentSettings.Deserialize(reader);
				}
				else
				{
					s0_DeploymentSettings.SetNull();
				}
				if ((___masking___[5] & 4) != 4)
				{
					s0_DeploymentStatus.Deserialize(reader);
				}
				else
				{
					s0_DeploymentStatus.SetNull();
				}
				if ((___masking___[5] & 8) != 8)
				{
					s0_DeploymentSupportInfoLastUpdated.Deserialize(reader);
				}
				else
				{
					s0_DeploymentSupportInfoLastUpdated.SetNull();
				}
				if ((___masking___[5] & 16) != 16)
				{
					s0_DeploymentTransitionStatus.Deserialize(reader);
				}
				else
				{
					s0_DeploymentTransitionStatus.SetNull();
				}
				if ((___masking___[5] & 32) != 32)
				{
					s0_DeploymentUpdateInProgress.Deserialize(reader);
				}
				else
				{
					s0_DeploymentUpdateInProgress.SetNull();
				}
				if ((___masking___[5] & 64) != 64)
				{
					s0_DeploymentUpdateType.Deserialize(reader);
				}
				else
				{
					s0_DeploymentUpdateType.SetNull();
				}
				if ((___masking___[5] & 128) != 128)
				{
					s0_DeploymentVIP.Deserialize(reader);
				}
				else
				{
					s0_DeploymentVIP.SetNull();
				}
				if ((___masking___[6] & 1) != 1)
				{
					s0_DeploymentVIPIPv6.Deserialize(reader);
				}
				else
				{
					s0_DeploymentVIPIPv6.SetNull();
				}
				if ((___masking___[6] & 2) != 2)
				{
					s0_DeploymentWeightedNumberOfExtraSmallRoleInstances.Deserialize(reader);
				}
				else
				{
					s0_DeploymentWeightedNumberOfExtraSmallRoleInstances.SetNull();
				}
				if ((___masking___[6] & 4) != 4)
				{
					s0_DeploymentWeightedNumberOfRoleInstances.Deserialize(reader);
				}
				else
				{
					s0_DeploymentWeightedNumberOfRoleInstances.SetNull();
				}
				if ((___masking___[6] & 8) != 8)
				{
					s0_FqdnSuffix.Deserialize(reader);
				}
				else
				{
					s0_FqdnSuffix.SetNull();
				}
				if ((___masking___[6] & 16) != 16)
				{
					s0_IS_Current.Deserialize(reader);
				}
				else
				{
					s0_IS_Current.SetNull();
				}
				if ((___masking___[6] & 32) != 32)
				{
					s0_MigratedFrom.Deserialize(reader);
				}
				else
				{
					s0_MigratedFrom.SetNull();
				}
				if ((___masking___[6] & 64) != 64)
				{
					s0_PackageRequiredFeatures.Deserialize(reader);
				}
				else
				{
					s0_PackageRequiredFeatures.SetNull();
				}
				if ((___masking___[6] & 128) != 128)
				{
					s0_PersistentVMs.Deserialize(reader);
				}
				else
				{
					s0_PersistentVMs.SetNull();
				}
				if ((___masking___[7] & 1) != 1)
				{
					s0_RoleOsMap.Deserialize(reader);
				}
				else
				{
					s0_RoleOsMap.SetNull();
				}
				if ((___masking___[7] & 2) != 2)
				{
					s0_SCD_EndDate.Deserialize(reader);
				}
				else
				{
					s0_SCD_EndDate.SetNull();
				}
				if ((___masking___[7] & 4) != 4)
				{
					s0_SCD_StartDate.Deserialize(reader);
				}
				else
				{
					s0_SCD_StartDate.SetNull();
				}
				if ((___masking___[7] & 8) != 8)
				{
					s0_SdkVersion.Deserialize(reader);
				}
				else
				{
					s0_SdkVersion.SetNull();
				}
				if ((___masking___[7] & 16) != 16)
				{
					s0_TimeMigrated.Deserialize(reader);
				}
				else
				{
					s0_TimeMigrated.SetNull();
				}
				if ((___masking___[7] & 32) != 32)
				{
					s0_endpoint.Deserialize(reader);
				}
				else
				{
					s0_endpoint.SetNull();
				}
				if ((___masking___[7] & 64) != 64)
				{
					s0_SourceTableName.Deserialize(reader);
				}
				else
				{
					s0_SourceTableName.SetNull();
				}
				if ((___masking___[7] & 128) != 128)
				{
					s0_AuditCreateDate.Deserialize(reader);
				}
				else
				{
					s0_AuditCreateDate.SetNull();
				}
				if ((___masking___[8] & 1) != 1)
				{
					s0_AuditUpdateDate.Deserialize(reader);
				}
				else
				{
					s0_AuditUpdateDate.SetNull();
				}
				s0___date.Deserialize(reader);
			}
		}
	}


	public static System.Type[] __UdtTypeTable__ =
	{
		
	};

	public static class __OperatorFactory__
	{
	}
}

	static public class UDTExtensionWrapper
	{
                public static T Create<T>() where T : new() 
                { 
                    return new T(); 
                }

                private static readonly Dictionary<System.Collections.Generic.IEqualityComparer<string>, byte> StringComparerToByteMap =
                    new Dictionary<System.Collections.Generic.IEqualityComparer<string>, byte>()
                    {
                        {System.Collections.Generic.EqualityComparer<string>.Default, 0},
                        {System.StringComparer.CurrentCulture, 1},
                        {System.StringComparer.CurrentCultureIgnoreCase, 2},
                        {System.StringComparer.InvariantCulture, 3},
                        {System.StringComparer.InvariantCultureIgnoreCase, 4},
                        {System.StringComparer.Ordinal, 5},
                        {System.StringComparer.OrdinalIgnoreCase, 6},
                    };

                private static readonly Dictionary<byte, System.Collections.Generic.IEqualityComparer<string>> ByteToStringComparerMap =
                    System.Linq.Enumerable.ToDictionary(StringComparerToByteMap, kvp => kvp.Value, kvp => kvp.Key);

                public static void Read(BinaryValueReader reader, out System.StringComparer value)
                {
                    byte comparerKey;
                    reader.Read(out comparerKey);
                    value = ByteToStringComparerMap[comparerKey] as System.StringComparer;
                }

                public static void Write(BinaryValueWriter writer, System.StringComparer value)
                {
                    // If System.StringComparer is not one of the 6 we recognize, comparerKey should be 0.
                    byte comparerKey;
                    StringComparerToByteMap.TryGetValue(value as System.Collections.Generic.IEqualityComparer<string> ?? System.Collections.Generic.EqualityComparer<string>.Default, out comparerKey);
                    writer.Write(comparerKey);
                }

                static public ScopeStruct       ScopeClone(this ScopeStruct value, ReferenceHashTable<object> seenObject)
                {
                    return (ScopeStruct)new StructColumnData(value).Clone().Value;
                }

                static public ScopeMap<K,V>     ScopeClone<K,V>(this ScopeMap<K,V> value, ReferenceHashTable<object> seenObject)
                {
                    return (ScopeMap<K,V>)new MapColumnData<K,V>(value).Clone().Value;
                }

                static public ScopeArray<T>     ScopeClone<T>(this ScopeArray<T> value, ReferenceHashTable<object> seenObject)
                {
                    return (ScopeArray<T>)new ArrayColumnData<T>(value).Clone().Value;
                }

                static public void Write<T>(BinaryValueWriter writer, ScopeArray<T> v)
                {
                    writer.Write(v);
                }

                static public void Read<T>(BinaryValueReader reader, out ScopeArray<T> v)
                {
                    reader.Read(out v);
                } 

                static public void Write<K,V>(BinaryValueWriter writer, ScopeMap<K,V> v)
                {
                    writer.Write(v);
                }

                static public void Read<K,V>(BinaryValueReader reader, out ScopeMap<K,V> v)
                {
                    reader.Read(out v);
                }                 
                

	}