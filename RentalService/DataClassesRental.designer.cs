﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace RentalService
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="RentalCarCaseDB")]
	public partial class DataClassesRentalDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region 可扩展性方法定义
    partial void OnCreated();
    partial void InsertRental(Rental instance);
    partial void UpdateRental(Rental instance);
    partial void DeleteRental(Rental instance);
    #endregion
		
		public DataClassesRentalDataContext() : 
				base(global::RentalService.Properties.Settings.Default.RentalCarCaseDBConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesRentalDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesRentalDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesRentalDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesRentalDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Rental> Rental
		{
			get
			{
				return this.GetTable<Rental>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Rental")]
	public partial class Rental : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _RentalID;
		
		private System.Nullable<int> _CustomerID;
		
		private string _CarID;
		
		private System.Nullable<int> _PickUpLocation;
		
		private System.Nullable<int> _DropOffLocation;
		
		private System.Nullable<System.DateTime> _PickUpDateTime;
		
		private System.Nullable<System.DateTime> _DropOffDateTime;
		
		private string _PaymentStatus;
		
		private string _Comments;
		
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnRentalIDChanging(int value);
    partial void OnRentalIDChanged();
    partial void OnCustomerIDChanging(System.Nullable<int> value);
    partial void OnCustomerIDChanged();
    partial void OnCarIDChanging(string value);
    partial void OnCarIDChanged();
    partial void OnPickUpLocationChanging(System.Nullable<int> value);
    partial void OnPickUpLocationChanged();
    partial void OnDropOffLocationChanging(System.Nullable<int> value);
    partial void OnDropOffLocationChanged();
    partial void OnPickUpDateTimeChanging(System.Nullable<System.DateTime> value);
    partial void OnPickUpDateTimeChanged();
    partial void OnDropOffDateTimeChanging(System.Nullable<System.DateTime> value);
    partial void OnDropOffDateTimeChanged();
    partial void OnPaymentStatusChanging(string value);
    partial void OnPaymentStatusChanged();
    partial void OnCommentsChanging(string value);
    partial void OnCommentsChanged();
    #endregion
		
		public Rental()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RentalID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int RentalID
		{
			get
			{
				return this._RentalID;
			}
			set
			{
				if ((this._RentalID != value))
				{
					this.OnRentalIDChanging(value);
					this.SendPropertyChanging();
					this._RentalID = value;
					this.SendPropertyChanged("RentalID");
					this.OnRentalIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CustomerID", DbType="Int")]
		public System.Nullable<int> CustomerID
		{
			get
			{
				return this._CustomerID;
			}
			set
			{
				if ((this._CustomerID != value))
				{
					this.OnCustomerIDChanging(value);
					this.SendPropertyChanging();
					this._CustomerID = value;
					this.SendPropertyChanged("CustomerID");
					this.OnCustomerIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CarID", DbType="NVarChar(50)")]
		public string CarID
		{
			get
			{
				return this._CarID;
			}
			set
			{
				if ((this._CarID != value))
				{
					this.OnCarIDChanging(value);
					this.SendPropertyChanging();
					this._CarID = value;
					this.SendPropertyChanged("CarID");
					this.OnCarIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PickUpLocation", DbType="Int")]
		public System.Nullable<int> PickUpLocation
		{
			get
			{
				return this._PickUpLocation;
			}
			set
			{
				if ((this._PickUpLocation != value))
				{
					this.OnPickUpLocationChanging(value);
					this.SendPropertyChanging();
					this._PickUpLocation = value;
					this.SendPropertyChanged("PickUpLocation");
					this.OnPickUpLocationChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DropOffLocation", DbType="Int")]
		public System.Nullable<int> DropOffLocation
		{
			get
			{
				return this._DropOffLocation;
			}
			set
			{
				if ((this._DropOffLocation != value))
				{
					this.OnDropOffLocationChanging(value);
					this.SendPropertyChanging();
					this._DropOffLocation = value;
					this.SendPropertyChanged("DropOffLocation");
					this.OnDropOffLocationChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PickUpDateTime", DbType="DateTime")]
		public System.Nullable<System.DateTime> PickUpDateTime
		{
			get
			{
				return this._PickUpDateTime;
			}
			set
			{
				if ((this._PickUpDateTime != value))
				{
					this.OnPickUpDateTimeChanging(value);
					this.SendPropertyChanging();
					this._PickUpDateTime = value;
					this.SendPropertyChanged("PickUpDateTime");
					this.OnPickUpDateTimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DropOffDateTime", DbType="DateTime")]
		public System.Nullable<System.DateTime> DropOffDateTime
		{
			get
			{
				return this._DropOffDateTime;
			}
			set
			{
				if ((this._DropOffDateTime != value))
				{
					this.OnDropOffDateTimeChanging(value);
					this.SendPropertyChanging();
					this._DropOffDateTime = value;
					this.SendPropertyChanged("DropOffDateTime");
					this.OnDropOffDateTimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PaymentStatus", DbType="Char(3)")]
		public string PaymentStatus
		{
			get
			{
				return this._PaymentStatus;
			}
			set
			{
				if ((this._PaymentStatus != value))
				{
					this.OnPaymentStatusChanging(value);
					this.SendPropertyChanging();
					this._PaymentStatus = value;
					this.SendPropertyChanged("PaymentStatus");
					this.OnPaymentStatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Comments", DbType="NVarChar(1000)")]
		public string Comments
		{
			get
			{
				return this._Comments;
			}
			set
			{
				if ((this._Comments != value))
				{
					this.OnCommentsChanging(value);
					this.SendPropertyChanging();
					this._Comments = value;
					this.SendPropertyChanged("Comments");
					this.OnCommentsChanged();
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