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
	public partial class SalariesDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertSalary(Salary instance);
    partial void UpdateSalary(Salary instance);
    partial void DeleteSalary(Salary instance);
    #endregion
		
		public SalariesDataContext() : 
				base(global::Thesis.Properties.Settings.Default.GymDatabaseConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public SalariesDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SalariesDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SalariesDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SalariesDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Salary> Salaries
		{
			get
			{
				return this.GetTable<Salary>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.AddSalary")]
		public int AddSalary([global::System.Data.Linq.Mapping.ParameterAttribute(Name="WorkerId", DbType="Int")] System.Nullable<int> workerId, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Date", DbType="Date")] System.Nullable<System.DateTime> date, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Salary", DbType="Money")] System.Nullable<decimal> salary, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Bonus", DbType="Money")] System.Nullable<decimal> bonus)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), workerId, date, salary, bonus);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.DeleteSalary")]
		public int DeleteSalary([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Id", DbType="Int")] System.Nullable<int> id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), id);
			return ((int)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Salaries")]
	public partial class Salary : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private int _WorkerId;
		
		private System.DateTime _Date;
		
		private decimal _Salaryy;
		
		private System.Nullable<decimal> _Bonus;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnWorkerIdChanging(int value);
    partial void OnWorkerIdChanged();
    partial void OnDateChanging(System.DateTime value);
    partial void OnDateChanged();
    partial void OnSalaryyChanging(decimal value);
    partial void OnSalaryyChanged();
    partial void OnBonusChanging(System.Nullable<decimal> value);
    partial void OnBonusChanged();
    #endregion
		
		public Salary()
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="Salary", Storage="_Salaryy", DbType="Money NOT NULL")]
		public decimal Salaryy
		{
			get
			{
				return this._Salaryy;
			}
			set
			{
				if ((this._Salaryy != value))
				{
					this.OnSalaryyChanging(value);
					this.SendPropertyChanging();
					this._Salaryy = value;
					this.SendPropertyChanged("Salaryy");
					this.OnSalaryyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Bonus", DbType="Money")]
		public System.Nullable<decimal> Bonus
		{
			get
			{
				return this._Bonus;
			}
			set
			{
				if ((this._Bonus != value))
				{
					this.OnBonusChanging(value);
					this.SendPropertyChanging();
					this._Bonus = value;
					this.SendPropertyChanged("Bonus");
					this.OnBonusChanged();
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