﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyAttendance
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="MyAttendanceDB")]
	public partial class MyDataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertAttendanceTbl(AttendanceTbl instance);
    partial void UpdateAttendanceTbl(AttendanceTbl instance);
    partial void DeleteAttendanceTbl(AttendanceTbl instance);
    #endregion
		
		public MyDataClasses1DataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["MyAttendanceDBConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public MyDataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MyDataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MyDataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MyDataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<AttendanceTbl> AttendanceTbls
		{
			get
			{
				return this.GetTable<AttendanceTbl>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.AddNewAttendance")]
		public int AddNewAttendance([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Fname", DbType="VarChar(50)")] string fname, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Lname", DbType="VarChar(50)")] string lname, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="TID", DbType="Int")] System.Nullable<int> tID, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="PID", DbType="Int")] System.Nullable<int> pID, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="IT", DbType="VarChar(50)")] string iT, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="OT", DbType="VarChar(50)")] string oT)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), fname, lname, tID, pID, iT, oT);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.GetAllAttendance")]
		public ISingleResult<GetAllAttendanceResult> GetAllAttendance()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<GetAllAttendanceResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.GetAttendanceForDay")]
		public ISingleResult<GetAttendanceForDayResult> GetAttendanceForDay([global::System.Data.Linq.Mapping.ParameterAttribute(Name="SDate", DbType="DateTime")] System.Nullable<System.DateTime> sDate)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), sDate);
			return ((ISingleResult<GetAttendanceForDayResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.CheckAttendance")]
		public ISingleResult<CheckAttendanceResult> CheckAttendance([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Fname", DbType="VarChar(50)")] string fname, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Lname", DbType="VarChar(50)")] string lname, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="TID", DbType="Int")] System.Nullable<int> tID, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="PID", DbType="Int")] System.Nullable<int> pID)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), fname, lname, tID, pID);
			return ((ISingleResult<CheckAttendanceResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.CheckAttStatus")]
		public ISingleResult<CheckAttStatusResult> CheckAttStatus([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Fname", DbType="VarChar(50)")] string fname, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Lname", DbType="VarChar(50)")] string lname, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="TID", DbType="Int")] System.Nullable<int> tID, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="PID", DbType="Int")] System.Nullable<int> pID)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), fname, lname, tID, pID);
			return ((ISingleResult<CheckAttStatusResult>)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.AttendanceTbl")]
	public partial class AttendanceTbl : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private long _ATID;
		
		private System.Nullable<int> _FKBID;
		
		private string _fname;
		
		private string _lname;
		
		private System.Nullable<int> _FkTechID;
		
		private System.Nullable<int> _FkPID;
		
		private string _InTime;
		
		private string _OutTime;
		
		private System.Nullable<System.DateTime> _AtDate;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnATIDChanging(long value);
    partial void OnATIDChanged();
    partial void OnFKBIDChanging(System.Nullable<int> value);
    partial void OnFKBIDChanged();
    partial void OnfnameChanging(string value);
    partial void OnfnameChanged();
    partial void OnlnameChanging(string value);
    partial void OnlnameChanged();
    partial void OnFkTechIDChanging(System.Nullable<int> value);
    partial void OnFkTechIDChanged();
    partial void OnFkPIDChanging(System.Nullable<int> value);
    partial void OnFkPIDChanged();
    partial void OnInTimeChanging(string value);
    partial void OnInTimeChanged();
    partial void OnOutTimeChanging(string value);
    partial void OnOutTimeChanged();
    partial void OnAtDateChanging(System.Nullable<System.DateTime> value);
    partial void OnAtDateChanged();
    #endregion
		
		public AttendanceTbl()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ATID", AutoSync=AutoSync.OnInsert, DbType="BigInt NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public long ATID
		{
			get
			{
				return this._ATID;
			}
			set
			{
				if ((this._ATID != value))
				{
					this.OnATIDChanging(value);
					this.SendPropertyChanging();
					this._ATID = value;
					this.SendPropertyChanged("ATID");
					this.OnATIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FKBID", DbType="Int")]
		public System.Nullable<int> FKBID
		{
			get
			{
				return this._FKBID;
			}
			set
			{
				if ((this._FKBID != value))
				{
					this.OnFKBIDChanging(value);
					this.SendPropertyChanging();
					this._FKBID = value;
					this.SendPropertyChanged("FKBID");
					this.OnFKBIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fname", DbType="VarChar(50)")]
		public string fname
		{
			get
			{
				return this._fname;
			}
			set
			{
				if ((this._fname != value))
				{
					this.OnfnameChanging(value);
					this.SendPropertyChanging();
					this._fname = value;
					this.SendPropertyChanged("fname");
					this.OnfnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_lname", DbType="VarChar(50)")]
		public string lname
		{
			get
			{
				return this._lname;
			}
			set
			{
				if ((this._lname != value))
				{
					this.OnlnameChanging(value);
					this.SendPropertyChanging();
					this._lname = value;
					this.SendPropertyChanged("lname");
					this.OnlnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FkTechID", DbType="Int")]
		public System.Nullable<int> FkTechID
		{
			get
			{
				return this._FkTechID;
			}
			set
			{
				if ((this._FkTechID != value))
				{
					this.OnFkTechIDChanging(value);
					this.SendPropertyChanging();
					this._FkTechID = value;
					this.SendPropertyChanged("FkTechID");
					this.OnFkTechIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FkPID", DbType="Int")]
		public System.Nullable<int> FkPID
		{
			get
			{
				return this._FkPID;
			}
			set
			{
				if ((this._FkPID != value))
				{
					this.OnFkPIDChanging(value);
					this.SendPropertyChanging();
					this._FkPID = value;
					this.SendPropertyChanged("FkPID");
					this.OnFkPIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_InTime", DbType="VarChar(50)")]
		public string InTime
		{
			get
			{
				return this._InTime;
			}
			set
			{
				if ((this._InTime != value))
				{
					this.OnInTimeChanging(value);
					this.SendPropertyChanging();
					this._InTime = value;
					this.SendPropertyChanged("InTime");
					this.OnInTimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OutTime", DbType="VarChar(50)")]
		public string OutTime
		{
			get
			{
				return this._OutTime;
			}
			set
			{
				if ((this._OutTime != value))
				{
					this.OnOutTimeChanging(value);
					this.SendPropertyChanging();
					this._OutTime = value;
					this.SendPropertyChanged("OutTime");
					this.OnOutTimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AtDate", DbType="DateTime")]
		public System.Nullable<System.DateTime> AtDate
		{
			get
			{
				return this._AtDate;
			}
			set
			{
				if ((this._AtDate != value))
				{
					this.OnAtDateChanging(value);
					this.SendPropertyChanging();
					this._AtDate = value;
					this.SendPropertyChanged("AtDate");
					this.OnAtDateChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	public partial class GetAllAttendanceResult
	{
		
		private long _ATID;
		
		private string _fname;
		
		private string _lname;
		
		private System.Nullable<int> _FkTechID;
		
		private System.Nullable<int> _FkPID;
		
		private string _InTime;
		
		private string _OutTime;
		
		private System.Nullable<System.DateTime> _AtDate;
		
		private int _PID;
		
		private string _PName;
		
		private string _Duration;
		
		private int _TechID;
		
		private string _TechName;
		
		public GetAllAttendanceResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ATID", DbType="BigInt NOT NULL")]
		public long ATID
		{
			get
			{
				return this._ATID;
			}
			set
			{
				if ((this._ATID != value))
				{
					this._ATID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fname", DbType="VarChar(50)")]
		public string fname
		{
			get
			{
				return this._fname;
			}
			set
			{
				if ((this._fname != value))
				{
					this._fname = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_lname", DbType="VarChar(50)")]
		public string lname
		{
			get
			{
				return this._lname;
			}
			set
			{
				if ((this._lname != value))
				{
					this._lname = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FkTechID", DbType="Int")]
		public System.Nullable<int> FkTechID
		{
			get
			{
				return this._FkTechID;
			}
			set
			{
				if ((this._FkTechID != value))
				{
					this._FkTechID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FkPID", DbType="Int")]
		public System.Nullable<int> FkPID
		{
			get
			{
				return this._FkPID;
			}
			set
			{
				if ((this._FkPID != value))
				{
					this._FkPID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_InTime", DbType="VarChar(50)")]
		public string InTime
		{
			get
			{
				return this._InTime;
			}
			set
			{
				if ((this._InTime != value))
				{
					this._InTime = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OutTime", DbType="VarChar(50)")]
		public string OutTime
		{
			get
			{
				return this._OutTime;
			}
			set
			{
				if ((this._OutTime != value))
				{
					this._OutTime = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AtDate", DbType="DateTime")]
		public System.Nullable<System.DateTime> AtDate
		{
			get
			{
				return this._AtDate;
			}
			set
			{
				if ((this._AtDate != value))
				{
					this._AtDate = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PID", DbType="Int NOT NULL")]
		public int PID
		{
			get
			{
				return this._PID;
			}
			set
			{
				if ((this._PID != value))
				{
					this._PID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PName", DbType="VarChar(50)")]
		public string PName
		{
			get
			{
				return this._PName;
			}
			set
			{
				if ((this._PName != value))
				{
					this._PName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Duration", DbType="VarChar(50)")]
		public string Duration
		{
			get
			{
				return this._Duration;
			}
			set
			{
				if ((this._Duration != value))
				{
					this._Duration = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TechID", DbType="Int NOT NULL")]
		public int TechID
		{
			get
			{
				return this._TechID;
			}
			set
			{
				if ((this._TechID != value))
				{
					this._TechID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TechName", DbType="VarChar(50)")]
		public string TechName
		{
			get
			{
				return this._TechName;
			}
			set
			{
				if ((this._TechName != value))
				{
					this._TechName = value;
				}
			}
		}
	}
	
	public partial class GetAttendanceForDayResult
	{
		
		private long _ATID;
		
		private string _fname;
		
		private string _lname;
		
		private System.Nullable<int> _FkTechID;
		
		private System.Nullable<int> _FkPID;
		
		private string _InTime;
		
		private string _OutTime;
		
		private System.Nullable<System.DateTime> _AtDate;
		
		private int _PID;
		
		private string _PName;
		
		private string _Duration;
		
		private int _TechID;
		
		private string _TechName;
		
		public GetAttendanceForDayResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ATID", DbType="BigInt NOT NULL")]
		public long ATID
		{
			get
			{
				return this._ATID;
			}
			set
			{
				if ((this._ATID != value))
				{
					this._ATID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fname", DbType="VarChar(50)")]
		public string fname
		{
			get
			{
				return this._fname;
			}
			set
			{
				if ((this._fname != value))
				{
					this._fname = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_lname", DbType="VarChar(50)")]
		public string lname
		{
			get
			{
				return this._lname;
			}
			set
			{
				if ((this._lname != value))
				{
					this._lname = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FkTechID", DbType="Int")]
		public System.Nullable<int> FkTechID
		{
			get
			{
				return this._FkTechID;
			}
			set
			{
				if ((this._FkTechID != value))
				{
					this._FkTechID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FkPID", DbType="Int")]
		public System.Nullable<int> FkPID
		{
			get
			{
				return this._FkPID;
			}
			set
			{
				if ((this._FkPID != value))
				{
					this._FkPID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_InTime", DbType="VarChar(50)")]
		public string InTime
		{
			get
			{
				return this._InTime;
			}
			set
			{
				if ((this._InTime != value))
				{
					this._InTime = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OutTime", DbType="VarChar(50)")]
		public string OutTime
		{
			get
			{
				return this._OutTime;
			}
			set
			{
				if ((this._OutTime != value))
				{
					this._OutTime = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AtDate", DbType="DateTime")]
		public System.Nullable<System.DateTime> AtDate
		{
			get
			{
				return this._AtDate;
			}
			set
			{
				if ((this._AtDate != value))
				{
					this._AtDate = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PID", DbType="Int NOT NULL")]
		public int PID
		{
			get
			{
				return this._PID;
			}
			set
			{
				if ((this._PID != value))
				{
					this._PID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PName", DbType="VarChar(50)")]
		public string PName
		{
			get
			{
				return this._PName;
			}
			set
			{
				if ((this._PName != value))
				{
					this._PName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Duration", DbType="VarChar(50)")]
		public string Duration
		{
			get
			{
				return this._Duration;
			}
			set
			{
				if ((this._Duration != value))
				{
					this._Duration = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TechID", DbType="Int NOT NULL")]
		public int TechID
		{
			get
			{
				return this._TechID;
			}
			set
			{
				if ((this._TechID != value))
				{
					this._TechID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TechName", DbType="VarChar(50)")]
		public string TechName
		{
			get
			{
				return this._TechName;
			}
			set
			{
				if ((this._TechName != value))
				{
					this._TechName = value;
				}
			}
		}
	}
	
	public partial class CheckAttendanceResult
	{
		
		private System.Nullable<int> _Column1;
		
		public CheckAttendanceResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="", Storage="_Column1", DbType="Int")]
		public System.Nullable<int> Column1
		{
			get
			{
				return this._Column1;
			}
			set
			{
				if ((this._Column1 != value))
				{
					this._Column1 = value;
				}
			}
		}
	}
	
	public partial class CheckAttStatusResult
	{
		
		private long _ATID;
		
		private string _fname;
		
		private string _lname;
		
		private System.Nullable<int> _FkTechID;
		
		private System.Nullable<int> _FkPID;
		
		private string _InTime;
		
		private string _OutTime;
		
		private System.Nullable<System.DateTime> _AtDate;
		
		public CheckAttStatusResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ATID", DbType="BigInt NOT NULL")]
		public long ATID
		{
			get
			{
				return this._ATID;
			}
			set
			{
				if ((this._ATID != value))
				{
					this._ATID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fname", DbType="VarChar(50)")]
		public string fname
		{
			get
			{
				return this._fname;
			}
			set
			{
				if ((this._fname != value))
				{
					this._fname = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_lname", DbType="VarChar(50)")]
		public string lname
		{
			get
			{
				return this._lname;
			}
			set
			{
				if ((this._lname != value))
				{
					this._lname = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FkTechID", DbType="Int")]
		public System.Nullable<int> FkTechID
		{
			get
			{
				return this._FkTechID;
			}
			set
			{
				if ((this._FkTechID != value))
				{
					this._FkTechID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FkPID", DbType="Int")]
		public System.Nullable<int> FkPID
		{
			get
			{
				return this._FkPID;
			}
			set
			{
				if ((this._FkPID != value))
				{
					this._FkPID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_InTime", DbType="VarChar(50)")]
		public string InTime
		{
			get
			{
				return this._InTime;
			}
			set
			{
				if ((this._InTime != value))
				{
					this._InTime = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OutTime", DbType="VarChar(50)")]
		public string OutTime
		{
			get
			{
				return this._OutTime;
			}
			set
			{
				if ((this._OutTime != value))
				{
					this._OutTime = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AtDate", DbType="DateTime")]
		public System.Nullable<System.DateTime> AtDate
		{
			get
			{
				return this._AtDate;
			}
			set
			{
				if ((this._AtDate != value))
				{
					this._AtDate = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
