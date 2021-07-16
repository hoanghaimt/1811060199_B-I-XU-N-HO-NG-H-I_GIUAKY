﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Thuhanh.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="TinTuc")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertTheloaitin(Theloaitin instance);
    partial void UpdateTheloaitin(Theloaitin instance);
    partial void DeleteTheloaitin(Theloaitin instance);
    partial void InsertTintuc(Tintuc instance);
    partial void UpdateTintuc(Tintuc instance);
    partial void DeleteTintuc(Tintuc instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["TinTucConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Theloaitin> Theloaitins
		{
			get
			{
				return this.GetTable<Theloaitin>();
			}
		}
		
		public System.Data.Linq.Table<Tintuc> Tintucs
		{
			get
			{
				return this.GetTable<Tintuc>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Theloaitin")]
	public partial class Theloaitin : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Maloai;
		
		private string _Tentheloai;
		
		private EntitySet<Tintuc> _Tintucs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaloaiChanging(int value);
    partial void OnMaloaiChanged();
    partial void OnTentheloaiChanging(string value);
    partial void OnTentheloaiChanged();
    #endregion
		
		public Theloaitin()
		{
			this._Tintucs = new EntitySet<Tintuc>(new Action<Tintuc>(this.attach_Tintucs), new Action<Tintuc>(this.detach_Tintucs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Maloai", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Maloai
		{
			get
			{
				return this._Maloai;
			}
			set
			{
				if ((this._Maloai != value))
				{
					this.OnMaloaiChanging(value);
					this.SendPropertyChanging();
					this._Maloai = value;
					this.SendPropertyChanged("Maloai");
					this.OnMaloaiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Tentheloai", DbType="NVarChar(200)")]
		public string Tentheloai
		{
			get
			{
				return this._Tentheloai;
			}
			set
			{
				if ((this._Tentheloai != value))
				{
					this.OnTentheloaiChanging(value);
					this.SendPropertyChanging();
					this._Tentheloai = value;
					this.SendPropertyChanged("Tentheloai");
					this.OnTentheloaiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Theloaitin_Tintuc", Storage="_Tintucs", ThisKey="Maloai", OtherKey="Maloai")]
		public EntitySet<Tintuc> Tintucs
		{
			get
			{
				return this._Tintucs;
			}
			set
			{
				this._Tintucs.Assign(value);
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
		
		private void attach_Tintucs(Tintuc entity)
		{
			this.SendPropertyChanging();
			entity.Theloaitin = this;
		}
		
		private void detach_Tintucs(Tintuc entity)
		{
			this.SendPropertyChanging();
			entity.Theloaitin = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Tintuc")]
	public partial class Tintuc : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaTin;
		
		private string _Tieudetin;
		
		private string _Noidungtin;
		
		private System.Nullable<int> _Maloai;
		
		private EntityRef<Theloaitin> _Theloaitin;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaTinChanging(int value);
    partial void OnMaTinChanged();
    partial void OnTieudetinChanging(string value);
    partial void OnTieudetinChanged();
    partial void OnNoidungtinChanging(string value);
    partial void OnNoidungtinChanged();
    partial void OnMaloaiChanging(System.Nullable<int> value);
    partial void OnMaloaiChanged();
    #endregion
		
		public Tintuc()
		{
			this._Theloaitin = default(EntityRef<Theloaitin>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaTin", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int MaTin
		{
			get
			{
				return this._MaTin;
			}
			set
			{
				if ((this._MaTin != value))
				{
					this.OnMaTinChanging(value);
					this.SendPropertyChanging();
					this._MaTin = value;
					this.SendPropertyChanged("MaTin");
					this.OnMaTinChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Tieudetin", DbType="NVarChar(200)")]
		public string Tieudetin
		{
			get
			{
				return this._Tieudetin;
			}
			set
			{
				if ((this._Tieudetin != value))
				{
					this.OnTieudetinChanging(value);
					this.SendPropertyChanging();
					this._Tieudetin = value;
					this.SendPropertyChanged("Tieudetin");
					this.OnTieudetinChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Noidungtin", DbType="NText", UpdateCheck=UpdateCheck.Never)]
		public string Noidungtin
		{
			get
			{
				return this._Noidungtin;
			}
			set
			{
				if ((this._Noidungtin != value))
				{
					this.OnNoidungtinChanging(value);
					this.SendPropertyChanging();
					this._Noidungtin = value;
					this.SendPropertyChanged("Noidungtin");
					this.OnNoidungtinChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Maloai", DbType="Int")]
		public System.Nullable<int> Maloai
		{
			get
			{
				return this._Maloai;
			}
			set
			{
				if ((this._Maloai != value))
				{
					if (this._Theloaitin.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaloaiChanging(value);
					this.SendPropertyChanging();
					this._Maloai = value;
					this.SendPropertyChanged("Maloai");
					this.OnMaloaiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Theloaitin_Tintuc", Storage="_Theloaitin", ThisKey="Maloai", OtherKey="Maloai", IsForeignKey=true)]
		public Theloaitin Theloaitin
		{
			get
			{
				return this._Theloaitin.Entity;
			}
			set
			{
				Theloaitin previousValue = this._Theloaitin.Entity;
				if (((previousValue != value) 
							|| (this._Theloaitin.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Theloaitin.Entity = null;
						previousValue.Tintucs.Remove(this);
					}
					this._Theloaitin.Entity = value;
					if ((value != null))
					{
						value.Tintucs.Add(this);
						this._Maloai = value.Maloai;
					}
					else
					{
						this._Maloai = default(Nullable<int>);
					}
					this.SendPropertyChanged("Theloaitin");
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