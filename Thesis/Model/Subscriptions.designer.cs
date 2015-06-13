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
	public partial class SubscriptionsDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertSubscription(Subscription instance);
    partial void UpdateSubscription(Subscription instance);
    partial void DeleteSubscription(Subscription instance);
    #endregion
		
		public SubscriptionsDataContext() : 
				base(global::Thesis.Properties.Settings.Default.GymDatabaseConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public SubscriptionsDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SubscriptionsDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SubscriptionsDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SubscriptionsDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Subscription> Subscriptions
		{
			get
			{
				return this.GetTable<Subscription>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.AddSubscription")]
		public int AddSubscription([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Name", DbType="NChar(30)")] string name, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Price", DbType="Money")] System.Nullable<decimal> price, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Duration_months", DbType="Int")] System.Nullable<int> duration_months, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Visits", DbType="Int")] System.Nullable<int> visits)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), name, price, duration_months, visits);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.DeleteSubscription")]
		public int DeleteSubscription([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Id", DbType="Int")] System.Nullable<int> id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), id);
			return ((int)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Subscriptions")]
	public partial class Subscription : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Name;
		
		private decimal _Price;
		
		private int _Duration_months;
		
		private System.Nullable<int> _Visits;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnPriceChanging(decimal value);
    partial void OnPriceChanged();
    partial void OnDuration_monthsChanging(int value);
    partial void OnDuration_monthsChanged();
    partial void OnVisitsChanging(System.Nullable<int> value);
    partial void OnVisitsChanged();
    #endregion
		
		public Subscription()
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NChar(30) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Price", DbType="Money NOT NULL")]
		public decimal Price
		{
			get
			{
				return this._Price;
			}
			set
			{
				if ((this._Price != value))
				{
					this.OnPriceChanging(value);
					this.SendPropertyChanging();
					this._Price = value;
					this.SendPropertyChanged("Price");
					this.OnPriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Duration_months", DbType="Int NOT NULL")]
		public int Duration_months
		{
			get
			{
				return this._Duration_months;
			}
			set
			{
				if ((this._Duration_months != value))
				{
					this.OnDuration_monthsChanging(value);
					this.SendPropertyChanging();
					this._Duration_months = value;
					this.SendPropertyChanged("Duration_months");
					this.OnDuration_monthsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Visits", DbType="Int")]
		public System.Nullable<int> Visits
		{
			get
			{
				return this._Visits;
			}
			set
			{
				if ((this._Visits != value))
				{
					this.OnVisitsChanging(value);
					this.SendPropertyChanging();
					this._Visits = value;
					this.SendPropertyChanged("Visits");
					this.OnVisitsChanged();
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