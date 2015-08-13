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

	public class Row_CDC7BED34563CD4E : Row
	{
		private static readonly System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>[] _columnTable = 
		{
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("PreciseTimeStamp", ColumnDataType.DateTime, typeof(DateTime), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("StartTime", ColumnDataType.DateTime, typeof(DateTime), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("EndTime", ColumnDataType.DateTime, typeof(DateTime), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("LogicalContainerId", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("RoleInstanceName", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("TenantName", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("RoleInstanceId", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("TenantId", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("NodeId", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("ContainerId", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("DataCenter", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("Cluster", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("RoleType", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("TransitionSignature", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("CADCategory", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("RCAEngineCategory", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("RCALevel1", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("RCALevel2", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("Duration", ColumnDataType.Double, typeof(double), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("RCA", ColumnDataType.String, typeof(string), null),
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("EventList", ColumnDataType.String, typeof(string), null),
		};
		ScopeRuntime.DateTimeColumnData s0_PreciseTimeStamp;
		public ScopeRuntime.DateTimeColumnData PreciseTimeStamp
		{
			get { return s0_PreciseTimeStamp; }
			set
			{
				s0_PreciseTimeStamp = value;
				_columns[0] = value;
			}
		}
		ScopeRuntime.DateTimeColumnData s0_StartTime;
		public ScopeRuntime.DateTimeColumnData StartTime
		{
			get { return s0_StartTime; }
			set
			{
				s0_StartTime = value;
				_columns[1] = value;
			}
		}
		ScopeRuntime.DateTimeColumnData s0_EndTime;
		public ScopeRuntime.DateTimeColumnData EndTime
		{
			get { return s0_EndTime; }
			set
			{
				s0_EndTime = value;
				_columns[2] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_LogicalContainerId;
		public ScopeRuntime.StringColumnData LogicalContainerId
		{
			get { return s0_LogicalContainerId; }
			set
			{
				s0_LogicalContainerId = value;
				_columns[3] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_RoleInstanceName;
		public ScopeRuntime.StringColumnData RoleInstanceName
		{
			get { return s0_RoleInstanceName; }
			set
			{
				s0_RoleInstanceName = value;
				_columns[4] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_TenantName;
		public ScopeRuntime.StringColumnData TenantName
		{
			get { return s0_TenantName; }
			set
			{
				s0_TenantName = value;
				_columns[5] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_RoleInstanceId;
		public ScopeRuntime.StringColumnData RoleInstanceId
		{
			get { return s0_RoleInstanceId; }
			set
			{
				s0_RoleInstanceId = value;
				_columns[6] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_TenantId;
		public ScopeRuntime.StringColumnData TenantId
		{
			get { return s0_TenantId; }
			set
			{
				s0_TenantId = value;
				_columns[7] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_NodeId;
		public ScopeRuntime.StringColumnData NodeId
		{
			get { return s0_NodeId; }
			set
			{
				s0_NodeId = value;
				_columns[8] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_ContainerId;
		public ScopeRuntime.StringColumnData ContainerId
		{
			get { return s0_ContainerId; }
			set
			{
				s0_ContainerId = value;
				_columns[9] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_DataCenter;
		public ScopeRuntime.StringColumnData DataCenter
		{
			get { return s0_DataCenter; }
			set
			{
				s0_DataCenter = value;
				_columns[10] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_Cluster;
		public ScopeRuntime.StringColumnData Cluster
		{
			get { return s0_Cluster; }
			set
			{
				s0_Cluster = value;
				_columns[11] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_RoleType;
		public ScopeRuntime.StringColumnData RoleType
		{
			get { return s0_RoleType; }
			set
			{
				s0_RoleType = value;
				_columns[12] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_TransitionSignature;
		public ScopeRuntime.StringColumnData TransitionSignature
		{
			get { return s0_TransitionSignature; }
			set
			{
				s0_TransitionSignature = value;
				_columns[13] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_CADCategory;
		public ScopeRuntime.StringColumnData CADCategory
		{
			get { return s0_CADCategory; }
			set
			{
				s0_CADCategory = value;
				_columns[14] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_RCAEngineCategory;
		public ScopeRuntime.StringColumnData RCAEngineCategory
		{
			get { return s0_RCAEngineCategory; }
			set
			{
				s0_RCAEngineCategory = value;
				_columns[15] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_RCALevel1;
		public ScopeRuntime.StringColumnData RCALevel1
		{
			get { return s0_RCALevel1; }
			set
			{
				s0_RCALevel1 = value;
				_columns[16] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_RCALevel2;
		public ScopeRuntime.StringColumnData RCALevel2
		{
			get { return s0_RCALevel2; }
			set
			{
				s0_RCALevel2 = value;
				_columns[17] = value;
			}
		}
		ScopeRuntime.DoubleColumnData s0_Duration;
		public ScopeRuntime.DoubleColumnData Duration
		{
			get { return s0_Duration; }
			set
			{
				s0_Duration = value;
				_columns[18] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_RCA;
		public ScopeRuntime.StringColumnData RCA
		{
			get { return s0_RCA; }
			set
			{
				s0_RCA = value;
				_columns[19] = value;
			}
		}
		ScopeRuntime.StringColumnData s0_EventList;
		public ScopeRuntime.StringColumnData EventList
		{
			get { return s0_EventList; }
			set
			{
				s0_EventList = value;
				_columns[20] = value;
			}
		}
		public Row_CDC7BED34563CD4E(Schema schema, ColumnData[] columns) : base(schema, columns) { }
		public Row_CDC7BED34563CD4E(Schema schema) : base(schema)
		{
			for (int i = 0; i < _columns.Length; ++i)
			{
				this[i] = _columns[i];
			}
		}
		public Row_CDC7BED34563CD4E() : base(BuildSchema(), BuildColumnData())
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
						s0_PreciseTimeStamp = (ScopeRuntime.DateTimeColumnData)value;
						break;
					case 1:
						s0_StartTime = (ScopeRuntime.DateTimeColumnData)value;
						break;
					case 2:
						s0_EndTime = (ScopeRuntime.DateTimeColumnData)value;
						break;
					case 3:
						s0_LogicalContainerId = (ScopeRuntime.StringColumnData)value;
						break;
					case 4:
						s0_RoleInstanceName = (ScopeRuntime.StringColumnData)value;
						break;
					case 5:
						s0_TenantName = (ScopeRuntime.StringColumnData)value;
						break;
					case 6:
						s0_RoleInstanceId = (ScopeRuntime.StringColumnData)value;
						break;
					case 7:
						s0_TenantId = (ScopeRuntime.StringColumnData)value;
						break;
					case 8:
						s0_NodeId = (ScopeRuntime.StringColumnData)value;
						break;
					case 9:
						s0_ContainerId = (ScopeRuntime.StringColumnData)value;
						break;
					case 10:
						s0_DataCenter = (ScopeRuntime.StringColumnData)value;
						break;
					case 11:
						s0_Cluster = (ScopeRuntime.StringColumnData)value;
						break;
					case 12:
						s0_RoleType = (ScopeRuntime.StringColumnData)value;
						break;
					case 13:
						s0_TransitionSignature = (ScopeRuntime.StringColumnData)value;
						break;
					case 14:
						s0_CADCategory = (ScopeRuntime.StringColumnData)value;
						break;
					case 15:
						s0_RCAEngineCategory = (ScopeRuntime.StringColumnData)value;
						break;
					case 16:
						s0_RCALevel1 = (ScopeRuntime.StringColumnData)value;
						break;
					case 17:
						s0_RCALevel2 = (ScopeRuntime.StringColumnData)value;
						break;
					case 18:
						s0_Duration = (ScopeRuntime.DoubleColumnData)value;
						break;
					case 19:
						s0_RCA = (ScopeRuntime.StringColumnData)value;
						break;
					case 20:
						s0_EventList = (ScopeRuntime.StringColumnData)value;
						break;
				}
			}
		}
		public override void Serialize(BinaryWriter writer)
		{
			byte[] ___masking___ = new byte[3];
			___masking___[0] = 1;
			___masking___[1] = 0;
			___masking___[2] = 0;

			bool hasNull = false;
			if (s0_LogicalContainerId.IsNull())
			{
				hasNull = true;
				___masking___[0] |= (byte)(1 << 1);
			}
			if (s0_RoleInstanceName.IsNull())
			{
				hasNull = true;
				___masking___[0] |= (byte)(1 << 2);
			}
			if (s0_TenantName.IsNull())
			{
				hasNull = true;
				___masking___[0] |= (byte)(1 << 3);
			}
			if (s0_RoleInstanceId.IsNull())
			{
				hasNull = true;
				___masking___[0] |= (byte)(1 << 4);
			}
			if (s0_TenantId.IsNull())
			{
				hasNull = true;
				___masking___[0] |= (byte)(1 << 5);
			}
			if (s0_NodeId.IsNull())
			{
				hasNull = true;
				___masking___[0] |= (byte)(1 << 6);
			}
			if (s0_ContainerId.IsNull())
			{
				hasNull = true;
				___masking___[0] |= (byte)(1 << 7);
			}
			if (s0_DataCenter.IsNull())
			{
				hasNull = true;
				___masking___[1] |= (byte)(1 << 0);
			}
			if (s0_Cluster.IsNull())
			{
				hasNull = true;
				___masking___[1] |= (byte)(1 << 1);
			}
			if (s0_RoleType.IsNull())
			{
				hasNull = true;
				___masking___[1] |= (byte)(1 << 2);
			}
			if (s0_TransitionSignature.IsNull())
			{
				hasNull = true;
				___masking___[1] |= (byte)(1 << 3);
			}
			if (s0_CADCategory.IsNull())
			{
				hasNull = true;
				___masking___[1] |= (byte)(1 << 4);
			}
			if (s0_RCAEngineCategory.IsNull())
			{
				hasNull = true;
				___masking___[1] |= (byte)(1 << 5);
			}
			if (s0_RCALevel1.IsNull())
			{
				hasNull = true;
				___masking___[1] |= (byte)(1 << 6);
			}
			if (s0_RCALevel2.IsNull())
			{
				hasNull = true;
				___masking___[1] |= (byte)(1 << 7);
			}
			if (s0_RCA.IsNull())
			{
				hasNull = true;
				___masking___[2] |= (byte)(1 << 0);
			}
			if (s0_EventList.IsNull())
			{
				hasNull = true;
				___masking___[2] |= (byte)(1 << 1);
			}
			if (hasNull)
			{
				writer.Write(___masking___[0]);
				writer.Write(___masking___[1]);
				writer.Write(___masking___[2]);
			}
			else
			{
				writer.Write( (byte) 0);
			}
			s0_PreciseTimeStamp.Serialize(writer);
			s0_StartTime.Serialize(writer);
			s0_EndTime.Serialize(writer);
			if (!s0_LogicalContainerId.IsNull())
			{
				s0_LogicalContainerId.Serialize(writer);
			}
			if (!s0_RoleInstanceName.IsNull())
			{
				s0_RoleInstanceName.Serialize(writer);
			}
			if (!s0_TenantName.IsNull())
			{
				s0_TenantName.Serialize(writer);
			}
			if (!s0_RoleInstanceId.IsNull())
			{
				s0_RoleInstanceId.Serialize(writer);
			}
			if (!s0_TenantId.IsNull())
			{
				s0_TenantId.Serialize(writer);
			}
			if (!s0_NodeId.IsNull())
			{
				s0_NodeId.Serialize(writer);
			}
			if (!s0_ContainerId.IsNull())
			{
				s0_ContainerId.Serialize(writer);
			}
			if (!s0_DataCenter.IsNull())
			{
				s0_DataCenter.Serialize(writer);
			}
			if (!s0_Cluster.IsNull())
			{
				s0_Cluster.Serialize(writer);
			}
			if (!s0_RoleType.IsNull())
			{
				s0_RoleType.Serialize(writer);
			}
			if (!s0_TransitionSignature.IsNull())
			{
				s0_TransitionSignature.Serialize(writer);
			}
			if (!s0_CADCategory.IsNull())
			{
				s0_CADCategory.Serialize(writer);
			}
			if (!s0_RCAEngineCategory.IsNull())
			{
				s0_RCAEngineCategory.Serialize(writer);
			}
			if (!s0_RCALevel1.IsNull())
			{
				s0_RCALevel1.Serialize(writer);
			}
			if (!s0_RCALevel2.IsNull())
			{
				s0_RCALevel2.Serialize(writer);
			}
			s0_Duration.Serialize(writer);
			if (!s0_RCA.IsNull())
			{
				s0_RCA.Serialize(writer);
			}
			if (!s0_EventList.IsNull())
			{
				s0_EventList.Serialize(writer);
			}
		}

		public override void Deserialize(BinaryReader reader)
		{
			byte[] ___masking___ = new byte[3];
			byte firstByte = reader.ReadByte();
			if (firstByte == 0)
			{
				s0_PreciseTimeStamp.Deserialize(reader);
				s0_StartTime.Deserialize(reader);
				s0_EndTime.Deserialize(reader);
				s0_LogicalContainerId.Deserialize(reader);
				s0_RoleInstanceName.Deserialize(reader);
				s0_TenantName.Deserialize(reader);
				s0_RoleInstanceId.Deserialize(reader);
				s0_TenantId.Deserialize(reader);
				s0_NodeId.Deserialize(reader);
				s0_ContainerId.Deserialize(reader);
				s0_DataCenter.Deserialize(reader);
				s0_Cluster.Deserialize(reader);
				s0_RoleType.Deserialize(reader);
				s0_TransitionSignature.Deserialize(reader);
				s0_CADCategory.Deserialize(reader);
				s0_RCAEngineCategory.Deserialize(reader);
				s0_RCALevel1.Deserialize(reader);
				s0_RCALevel2.Deserialize(reader);
				s0_Duration.Deserialize(reader);
				s0_RCA.Deserialize(reader);
				s0_EventList.Deserialize(reader);
			}
			else
			{
				___masking___[0] = firstByte;
				___masking___[1] = reader.ReadByte();
				___masking___[2] = reader.ReadByte();
				s0_PreciseTimeStamp.Deserialize(reader);
				s0_StartTime.Deserialize(reader);
				s0_EndTime.Deserialize(reader);
				if ((___masking___[0] & 2) != 2)
				{
					s0_LogicalContainerId.Deserialize(reader);
				}
				else
				{
					s0_LogicalContainerId.SetNull();
				}
				if ((___masking___[0] & 4) != 4)
				{
					s0_RoleInstanceName.Deserialize(reader);
				}
				else
				{
					s0_RoleInstanceName.SetNull();
				}
				if ((___masking___[0] & 8) != 8)
				{
					s0_TenantName.Deserialize(reader);
				}
				else
				{
					s0_TenantName.SetNull();
				}
				if ((___masking___[0] & 16) != 16)
				{
					s0_RoleInstanceId.Deserialize(reader);
				}
				else
				{
					s0_RoleInstanceId.SetNull();
				}
				if ((___masking___[0] & 32) != 32)
				{
					s0_TenantId.Deserialize(reader);
				}
				else
				{
					s0_TenantId.SetNull();
				}
				if ((___masking___[0] & 64) != 64)
				{
					s0_NodeId.Deserialize(reader);
				}
				else
				{
					s0_NodeId.SetNull();
				}
				if ((___masking___[0] & 128) != 128)
				{
					s0_ContainerId.Deserialize(reader);
				}
				else
				{
					s0_ContainerId.SetNull();
				}
				if ((___masking___[1] & 1) != 1)
				{
					s0_DataCenter.Deserialize(reader);
				}
				else
				{
					s0_DataCenter.SetNull();
				}
				if ((___masking___[1] & 2) != 2)
				{
					s0_Cluster.Deserialize(reader);
				}
				else
				{
					s0_Cluster.SetNull();
				}
				if ((___masking___[1] & 4) != 4)
				{
					s0_RoleType.Deserialize(reader);
				}
				else
				{
					s0_RoleType.SetNull();
				}
				if ((___masking___[1] & 8) != 8)
				{
					s0_TransitionSignature.Deserialize(reader);
				}
				else
				{
					s0_TransitionSignature.SetNull();
				}
				if ((___masking___[1] & 16) != 16)
				{
					s0_CADCategory.Deserialize(reader);
				}
				else
				{
					s0_CADCategory.SetNull();
				}
				if ((___masking___[1] & 32) != 32)
				{
					s0_RCAEngineCategory.Deserialize(reader);
				}
				else
				{
					s0_RCAEngineCategory.SetNull();
				}
				if ((___masking___[1] & 64) != 64)
				{
					s0_RCALevel1.Deserialize(reader);
				}
				else
				{
					s0_RCALevel1.SetNull();
				}
				if ((___masking___[1] & 128) != 128)
				{
					s0_RCALevel2.Deserialize(reader);
				}
				else
				{
					s0_RCALevel2.SetNull();
				}
				s0_Duration.Deserialize(reader);
				if ((___masking___[2] & 1) != 1)
				{
					s0_RCA.Deserialize(reader);
				}
				else
				{
					s0_RCA.SetNull();
				}
				if ((___masking___[2] & 2) != 2)
				{
					s0_EventList.Deserialize(reader);
				}
				else
				{
					s0_EventList.SetNull();
				}
			}
		}
	}


	public class Row_DeploymentName_String : Row
	{
		private static readonly System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>[] _columnTable = 
		{
			new System.Tuple<string,ColumnDataType,Type,ColumnDataCtor>("DeploymentName", ColumnDataType.String, typeof(string), null),
		};
		ScopeRuntime.StringColumnData s0_DeploymentName;
		public ScopeRuntime.StringColumnData DeploymentName
		{
			get { return s0_DeploymentName; }
			set
			{
				s0_DeploymentName = value;
				_columns[0] = value;
			}
		}
		public Row_DeploymentName_String(Schema schema, ColumnData[] columns) : base(schema, columns) { }
		public Row_DeploymentName_String(Schema schema) : base(schema)
		{
			for (int i = 0; i < _columns.Length; ++i)
			{
				this[i] = _columns[i];
			}
		}
		public Row_DeploymentName_String() : base(BuildSchema(), BuildColumnData())
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
						s0_DeploymentName = (ScopeRuntime.StringColumnData)value;
						break;
				}
			}
		}
		public override void Serialize(BinaryWriter writer)
		{
			byte[] ___masking___ = new byte[1];
			___masking___[0] = 1;

			bool hasNull = false;
			if (s0_DeploymentName.IsNull())
			{
				hasNull = true;
				___masking___[0] |= (byte)(1 << 1);
			}
			if (hasNull)
			{
				writer.Write(___masking___[0]);
			}
			else
			{
				writer.Write( (byte) 0);
			}
			if (!s0_DeploymentName.IsNull())
			{
				s0_DeploymentName.Serialize(writer);
			}
		}

		public override void Deserialize(BinaryReader reader)
		{
			byte[] ___masking___ = new byte[1];
			byte firstByte = reader.ReadByte();
			if (firstByte == 0)
			{
				s0_DeploymentName.Deserialize(reader);
			}
			else
			{
				___masking___[0] = firstByte;
				if ((___masking___[0] & 2) != 2)
				{
					s0_DeploymentName.Deserialize(reader);
				}
				else
				{
					s0_DeploymentName.SetNull();
				}
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