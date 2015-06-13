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
	public partial class InventoryDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertInventory(Inventory instance);
    partial void UpdateInventory(Inventory instance);
    partial void DeleteInventory(Inventory instance);
    #endregion
		
		public InventoryDataContext() : 
				base(global::Thesis.Properties.Settings.Default.GymDatabaseConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public InventoryDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public InventoryDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public InventoryDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public InventoryDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Inventory> Inventories
		{
			get
			{
				return this.GetTable<Inventory>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.AddInventory")]
		public int AddInventory([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Name", DbType="NChar(50)")] string name, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Type", DbType="NChar(50)")] string type, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Brand", DbType="NChar(40)")] string brand, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Amount", DbType="NChar(20)")] string amount, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="DeliveryDate", DbType="Date")] System.Nullable<System.DateTime> deliveryDate, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="NumberOfRepairs", DbType="Int")] System.Nullable<int> numberOfRepairs, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ExpirationDate", DbType="Date")] System.Nullable<System.DateTime> expirationDate, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="FutureDateChange", DbType="Date")] System.Nullable<System.DateTime> futureDateChange, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="DeliveryPrice", DbType="Money")] System.Nullable<decimal> deliveryPrice, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ProviderId", DbType="Int")] System.Nullable<int> providerId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), name, type, brand, amount, deliveryDate, numberOfRepairs, expirationDate, futureDateChange, deliveryPrice, providerId);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.DeleteInventory")]
		public int DeleteInventory([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Id", DbType="Int")] System.Nullable<int> id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), id);
			return ((int)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Inventory")]
	public partial class Inventory : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Name;
		
		private string _Type;
		
		private string _Brand;
		
		private string _Amount;
		
		private System.Nullable<System.DateTime> _DeliveryDate;
		
		private System.Nullable<int> _NumberOfRepairs;
		
		private System.Nullable<System.DateTime> _ExpirationDate;
		
		private System.Nullable<System.DateTime> _FutureDateChange;
		
		private decimal _DeliveryPrice;
		
		private System.Nullable<int> _ProviderId;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnTypeChanging(string value);
    partial void OnTypeChanged();
    partial void OnBrandChanging(string value);
    partial void OnBrandChanged();
    partial void OnAmountChanging(string value);
    partial void OnAmountChanged();
    partial void OnDeliveryDateChanging(System.Nullable<System.DateTime> value);
    partial void OnDeliveryDateChanged();
    partial void OnNumberOfRepairsChanging(System.Nullable<int> value);
    partial void OnNumberOfRepairsChanged();
    partial void OnExpirationDateChanging(System.Nullable<System.DateTime> value);
    partial void OnExpirationDateChanged();
    partial void OnFutureDateChangeChanging(System.Nullable<System.DateTime> value);
    partial void OnFutureDateChangeChanged();
    partial void OnDeliveryPriceChanging(decimal value);
    partial void OnDeliveryPriceChanged();
    partial void OnProviderIdChanging(System.Nullable<int> value);
    partial void OnProviderIdChanged();
    #endregion
		
		public Inventory()
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NChar(50) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Type", DbType="NChar(50)")]
		public string Type
		{
			get
			{
				return this._Type;
			}
			set
			{
				if ((this._Type != value))
				{
					this.OnTypeChanging(value);
					this.SendPropertyChanging();
					this._Type = value;
					this.SendPropertyChanged("Type");
					this.OnTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Brand", DbType="NChar(40)")]
		public string Brand
		{
			get
			{
				return this._Brand;
			}
			set
			{
				if ((this._Brand != value))
				{
					this.OnBrandChanging(value);
					this.SendPropertyChanging();
					this._Brand = value;
					this.SendPropertyChanged("Brand");
					this.OnBrandChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Amount", DbType="NChar(20) NOT NULL", CanBeNull=false)]
		public string Amount
		{
			get
			{
				return this._Amount;
			}
			set
			{
				if ((this._Amount != value))
				{
					this.OnAmountChanging(value);
					this.SendPropertyChanging();
					this._Amount = value;
					this.SendPropertyChanged("Amount");
					this.OnAmountChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DeliveryDate", DbType="Date")]
		public System.Nullable<System.DateTime> DeliveryDate
		{
			get
			{
				return this._DeliveryDate;
			}
			set
			{
				if ((this._DeliveryDate != value))
				{
					this.OnDeliveryDateChanging(value);
					this.SendPropertyChanging();
					this._DeliveryDate = value;
					this.SendPropertyChanged("DeliveryDate");
					this.OnDeliveryDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NumberOfRepairs", DbType="Int")]
		public System.Nullable<int> NumberOfRepairs
		{
			get
			{
				return this._NumberOfRepairs;
			}
			set
			{
				if ((this._NumberOfRepairs != value))
				{
					this.OnNumberOfRepairsChanging(value);
					this.SendPropertyChanging();
					this._NumberOfRepairs = value;
					this.SendPropertyChanged("NumberOfRepairs");
					this.OnNumberOfRepairsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ExpirationDate", DbType="Date")]
		public System.Nullable<System.DateTime> ExpirationDate
		{
			get
			{
				return this._ExpirationDate;
			}
			set
			{
				if ((this._ExpirationDate != value))
				{
					this.OnExpirationDateChanging(value);
					this.SendPropertyChanging();
					this._ExpirationDate = value;
					this.SendPropertyChanged("ExpirationDate");
					this.OnExpirationDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FutureDateChange", DbType="Date")]
		public System.Nullable<System.DateTime> FutureDateChange
		{
			get
			{
				return this._FutureDateChange;
			}
			set
			{
				if ((this._FutureDateChange != value))
				{
					this.OnFutureDateChangeChanging(value);
					this.SendPropertyChanging();
					this._FutureDateChange = value;
					this.SendPropertyChanged("FutureDateChange");
					this.OnFutureDateChangeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DeliveryPrice", DbType="Money NOT NULL")]
		public decimal DeliveryPrice
		{
			get
			{
				return this._DeliveryPrice;
			}
			set
			{
				if ((this._DeliveryPrice != value))
				{
					this.OnDeliveryPriceChanging(value);
					this.SendPropertyChanging();
					this._DeliveryPrice = value;
					this.SendPropertyChanged("DeliveryPrice");
					this.OnDeliveryPriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProviderId", DbType="Int")]
		public System.Nullable<int> ProviderId
		{
			get
			{
				return this._ProviderId;
			}
			set
			{
				if ((this._ProviderId != value))
				{
					this.OnProviderIdChanging(value);
					this.SendPropertyChanging();
					this._ProviderId = value;
					this.SendPropertyChanged("ProviderId");
					this.OnProviderIdChanged();
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