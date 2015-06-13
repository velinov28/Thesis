﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Thesis.Model
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="GymDatabase")]
	public partial class WorkSchedulesDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertWorkSchedule(WorkSchedule instance);
    partial void UpdateWorkSchedule(WorkSchedule instance);
    partial void DeleteWorkSchedule(WorkSchedule instance);
    #endregion
		
		public WorkSchedulesDataContext() : 
				base(global::Thesis.Properties.Settings.Default.GymDatabaseConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public WorkSchedulesDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public WorkSchedulesDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public WorkSchedulesDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public WorkSchedulesDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<WorkSchedule> WorkSchedules
		{
			get
			{
				return this.GetTable<WorkSchedule>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.AddWorkSchedule")]
		public int AddWorkSchedule([global::System.Data.Linq.Mapping.ParameterAttribute(Name="WorkerId", DbType="Int")] System.Nullable<int> workerId, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Shift", DbType="Int")] System.Nullable<int> shift, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="WorkingTime", DbType="NChar(40)")] string workingTime, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Date", DbType="Date")] System.Nullable<System.DateTime> date)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), workerId, shift, workingTime, date);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.DeleteWorkSchedule")]
		public int DeleteWorkSchedule([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Id", DbType="Int")] System.Nullable<int> id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), id);
			return ((int)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.WorkSchedules")]
	public partial class WorkSchedule : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private int _WorkerId;
		
		private int _Shift;
		
		private string _WorkingTime;
		
		private System.DateTime _Date;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnWorkerIdChanging(int value);
    partial void OnWorkerIdChanged();
    partial void OnShiftChanging(int value);
    partial void OnShiftChanged();
    partial void OnWorkingTimeChanging(string value);
    partial void OnWorkingTimeChanged();
    partial void OnDateChanging(System.DateTime value);
    partial void OnDateChanged();
    #endregion
		
		public WorkSchedule()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_WorkerId", DbType="Int NOT NULL")]
		public int WorkerId
		{
			get
			{
				return this._WorkerId;
			}
			set
			{
				if ((this._WorkerId != value))
				{
					this.OnWorkerIdChanging(value);
					this.SendPropertyChanging();
					this._WorkerId = value;
					this.SendPropertyChanged("WorkerId");
					this.OnWorkerIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Shift", DbType="Int NOT NULL")]
		public int Shift
		{
			get
			{
				return this._Shift;
			}
			set
			{
				if ((this._Shift != value))
				{
					this.OnShiftChanging(value);
					this.SendPropertyChanging();
					this._Shift = value;
					this.SendPropertyChanged("Shift");
					this.OnShiftChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_WorkingTime", DbType="NChar(40) NOT NULL", CanBeNull=false)]
		public string WorkingTime
		{
			get
			{
				return this._WorkingTime;
			}
			set
			{
				if ((this._WorkingTime != value))
				{
					this.OnWorkingTimeChanging(value);
					this.SendPropertyChanging();
					this._WorkingTime = value;
					this.SendPropertyChanged("WorkingTime");
					this.OnWorkingTimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Date", DbType="Date NOT NULL")]
		public System.DateTime Date
		{
			get
			{
				return this._Date;
			}
			set
			{
				if ((this._Date != value))
				{
					this.OnDateChanging(value);
					this.SendPropertyChanging();
					this._Date = value;
					this.SendPropertyChanged("Date");
					this.OnDateChanged();
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
}
#pragma warning restore 1591
