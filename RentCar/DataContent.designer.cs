﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RentCar
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="RentaCar")]
	public partial class DataContentDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertKullanici(Kullanici instance);
    partial void UpdateKullanici(Kullanici instance);
    partial void DeleteKullanici(Kullanici instance);
    partial void InsertMarka(Marka instance);
    partial void UpdateMarka(Marka instance);
    partial void DeleteMarka(Marka instance);
    partial void InsertArac(Arac instance);
    partial void UpdateArac(Arac instance);
    partial void DeleteArac(Arac instance);
    partial void InsertKirala(Kirala instance);
    partial void UpdateKirala(Kirala instance);
    partial void DeleteKirala(Kirala instance);
    #endregion
		
		public DataContentDataContext() : 
				base(global::RentCar.Properties.Settings.Default.RentaCarConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataContentDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataContentDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataContentDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataContentDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Kullanici> Kullanicis
		{
			get
			{
				return this.GetTable<Kullanici>();
			}
		}
		
		public System.Data.Linq.Table<Marka> Markas
		{
			get
			{
				return this.GetTable<Marka>();
			}
		}
		
		public System.Data.Linq.Table<Arac> Aracs
		{
			get
			{
				return this.GetTable<Arac>();
			}
		}
		
		public System.Data.Linq.Table<Kirala> Kiralas
		{
			get
			{
				return this.GetTable<Kirala>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Kullanici")]
	public partial class Kullanici : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _KullaniciID;
		
		private string _KullaniciAdi;
		
		private string _KullaniciSifre;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnKullaniciIDChanging(int value);
    partial void OnKullaniciIDChanged();
    partial void OnKullaniciAdiChanging(string value);
    partial void OnKullaniciAdiChanged();
    partial void OnKullaniciSifreChanging(string value);
    partial void OnKullaniciSifreChanged();
    #endregion
		
		public Kullanici()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_KullaniciID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int KullaniciID
		{
			get
			{
				return this._KullaniciID;
			}
			set
			{
				if ((this._KullaniciID != value))
				{
					this.OnKullaniciIDChanging(value);
					this.SendPropertyChanging();
					this._KullaniciID = value;
					this.SendPropertyChanged("KullaniciID");
					this.OnKullaniciIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_KullaniciAdi", DbType="NVarChar(20)")]
		public string KullaniciAdi
		{
			get
			{
				return this._KullaniciAdi;
			}
			set
			{
				if ((this._KullaniciAdi != value))
				{
					this.OnKullaniciAdiChanging(value);
					this.SendPropertyChanging();
					this._KullaniciAdi = value;
					this.SendPropertyChanged("KullaniciAdi");
					this.OnKullaniciAdiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_KullaniciSifre", DbType="NVarChar(20)")]
		public string KullaniciSifre
		{
			get
			{
				return this._KullaniciSifre;
			}
			set
			{
				if ((this._KullaniciSifre != value))
				{
					this.OnKullaniciSifreChanging(value);
					this.SendPropertyChanging();
					this._KullaniciSifre = value;
					this.SendPropertyChanged("KullaniciSifre");
					this.OnKullaniciSifreChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Marka")]
	public partial class Marka : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MarkaID;
		
		private string _MarkaAdi;
		
		private EntitySet<Arac> _Aracs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMarkaIDChanging(int value);
    partial void OnMarkaIDChanged();
    partial void OnMarkaAdiChanging(string value);
    partial void OnMarkaAdiChanged();
    #endregion
		
		public Marka()
		{
			this._Aracs = new EntitySet<Arac>(new Action<Arac>(this.attach_Aracs), new Action<Arac>(this.detach_Aracs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MarkaID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MarkaID
		{
			get
			{
				return this._MarkaID;
			}
			set
			{
				if ((this._MarkaID != value))
				{
					this.OnMarkaIDChanging(value);
					this.SendPropertyChanging();
					this._MarkaID = value;
					this.SendPropertyChanged("MarkaID");
					this.OnMarkaIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MarkaAdi", DbType="NVarChar(20)")]
		public string MarkaAdi
		{
			get
			{
				return this._MarkaAdi;
			}
			set
			{
				if ((this._MarkaAdi != value))
				{
					this.OnMarkaAdiChanging(value);
					this.SendPropertyChanging();
					this._MarkaAdi = value;
					this.SendPropertyChanged("MarkaAdi");
					this.OnMarkaAdiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Marka_Arac", Storage="_Aracs", ThisKey="MarkaID", OtherKey="Marka")]
		public EntitySet<Arac> Aracs
		{
			get
			{
				return this._Aracs;
			}
			set
			{
				this._Aracs.Assign(value);
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
		
		private void attach_Aracs(Arac entity)
		{
			this.SendPropertyChanging();
			entity.Marka1 = this;
		}
		
		private void detach_Aracs(Arac entity)
		{
			this.SendPropertyChanging();
			entity.Marka1 = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Arac")]
	public partial class Arac : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _AracID;
		
		private string _AracAdi;
		
		private System.Nullable<int> _Marka;
		
		private System.Nullable<int> _Model;
		
		private string _Plaka;
		
		private string _Yakıt;
		
		private System.Nullable<int> _Ucret;
		
		private string _Durum;
		
		private EntitySet<Kirala> _Kiralas;
		
		private EntityRef<Marka> _Marka1;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnAracIDChanging(int value);
    partial void OnAracIDChanged();
    partial void OnAracAdiChanging(string value);
    partial void OnAracAdiChanged();
    partial void OnMarkaChanging(System.Nullable<int> value);
    partial void OnMarkaChanged();
    partial void OnModelChanging(System.Nullable<int> value);
    partial void OnModelChanged();
    partial void OnPlakaChanging(string value);
    partial void OnPlakaChanged();
    partial void OnYakıtChanging(string value);
    partial void OnYakıtChanged();
    partial void OnUcretChanging(System.Nullable<int> value);
    partial void OnUcretChanged();
    partial void OnDurumChanging(string value);
    partial void OnDurumChanged();
    #endregion
		
		public Arac()
		{
			this._Kiralas = new EntitySet<Kirala>(new Action<Kirala>(this.attach_Kiralas), new Action<Kirala>(this.detach_Kiralas));
			this._Marka1 = default(EntityRef<Marka>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AracID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int AracID
		{
			get
			{
				return this._AracID;
			}
			set
			{
				if ((this._AracID != value))
				{
					this.OnAracIDChanging(value);
					this.SendPropertyChanging();
					this._AracID = value;
					this.SendPropertyChanged("AracID");
					this.OnAracIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AracAdi", DbType="NVarChar(20)")]
		public string AracAdi
		{
			get
			{
				return this._AracAdi;
			}
			set
			{
				if ((this._AracAdi != value))
				{
					this.OnAracAdiChanging(value);
					this.SendPropertyChanging();
					this._AracAdi = value;
					this.SendPropertyChanged("AracAdi");
					this.OnAracAdiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Marka", DbType="Int")]
		public System.Nullable<int> Marka
		{
			get
			{
				return this._Marka;
			}
			set
			{
				if ((this._Marka != value))
				{
					if (this._Marka1.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMarkaChanging(value);
					this.SendPropertyChanging();
					this._Marka = value;
					this.SendPropertyChanged("Marka");
					this.OnMarkaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Model", DbType="Int")]
		public System.Nullable<int> Model
		{
			get
			{
				return this._Model;
			}
			set
			{
				if ((this._Model != value))
				{
					this.OnModelChanging(value);
					this.SendPropertyChanging();
					this._Model = value;
					this.SendPropertyChanged("Model");
					this.OnModelChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Plaka", DbType="NVarChar(20)")]
		public string Plaka
		{
			get
			{
				return this._Plaka;
			}
			set
			{
				if ((this._Plaka != value))
				{
					this.OnPlakaChanging(value);
					this.SendPropertyChanging();
					this._Plaka = value;
					this.SendPropertyChanged("Plaka");
					this.OnPlakaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Yakıt", DbType="NVarChar(20)")]
		public string Yakıt
		{
			get
			{
				return this._Yakıt;
			}
			set
			{
				if ((this._Yakıt != value))
				{
					this.OnYakıtChanging(value);
					this.SendPropertyChanging();
					this._Yakıt = value;
					this.SendPropertyChanged("Yakıt");
					this.OnYakıtChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ucret", DbType="Int")]
		public System.Nullable<int> Ucret
		{
			get
			{
				return this._Ucret;
			}
			set
			{
				if ((this._Ucret != value))
				{
					this.OnUcretChanging(value);
					this.SendPropertyChanging();
					this._Ucret = value;
					this.SendPropertyChanged("Ucret");
					this.OnUcretChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Durum", DbType="NVarChar(50)")]
		public string Durum
		{
			get
			{
				return this._Durum;
			}
			set
			{
				if ((this._Durum != value))
				{
					this.OnDurumChanging(value);
					this.SendPropertyChanging();
					this._Durum = value;
					this.SendPropertyChanged("Durum");
					this.OnDurumChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Arac_Kirala", Storage="_Kiralas", ThisKey="AracID", OtherKey="AracID")]
		public EntitySet<Kirala> Kiralas
		{
			get
			{
				return this._Kiralas;
			}
			set
			{
				this._Kiralas.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Marka_Arac", Storage="_Marka1", ThisKey="Marka", OtherKey="MarkaID", IsForeignKey=true)]
		public Marka Marka1
		{
			get
			{
				return this._Marka1.Entity;
			}
			set
			{
				Marka previousValue = this._Marka1.Entity;
				if (((previousValue != value) 
							|| (this._Marka1.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Marka1.Entity = null;
						previousValue.Aracs.Remove(this);
					}
					this._Marka1.Entity = value;
					if ((value != null))
					{
						value.Aracs.Add(this);
						this._Marka = value.MarkaID;
					}
					else
					{
						this._Marka = default(Nullable<int>);
					}
					this.SendPropertyChanged("Marka1");
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
		
		private void attach_Kiralas(Kirala entity)
		{
			this.SendPropertyChanging();
			entity.Arac = this;
		}
		
		private void detach_Kiralas(Kirala entity)
		{
			this.SendPropertyChanging();
			entity.Arac = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Kirala")]
	public partial class Kirala : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _MusteriAd;
		
		private string _MusteriSoyad;
		
		private string _MusteriTc;
		
		private System.Nullable<int> _AracID;
		
		private System.Nullable<System.DateTime> _Alim;
		
		private System.Nullable<int> _Toplam;
		
		private System.Nullable<System.DateTime> _Teslim;
		
		private EntityRef<Arac> _Arac;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnMusteriAdChanging(string value);
    partial void OnMusteriAdChanged();
    partial void OnMusteriSoyadChanging(string value);
    partial void OnMusteriSoyadChanged();
    partial void OnMusteriTcChanging(string value);
    partial void OnMusteriTcChanged();
    partial void OnAracIDChanging(System.Nullable<int> value);
    partial void OnAracIDChanged();
    partial void OnAlimChanging(System.Nullable<System.DateTime> value);
    partial void OnAlimChanged();
    partial void OnToplamChanging(System.Nullable<int> value);
    partial void OnToplamChanged();
    partial void OnTeslimChanging(System.Nullable<System.DateTime> value);
    partial void OnTeslimChanged();
    #endregion
		
		public Kirala()
		{
			this._Arac = default(EntityRef<Arac>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MusteriAd", DbType="NVarChar(20)")]
		public string MusteriAd
		{
			get
			{
				return this._MusteriAd;
			}
			set
			{
				if ((this._MusteriAd != value))
				{
					this.OnMusteriAdChanging(value);
					this.SendPropertyChanging();
					this._MusteriAd = value;
					this.SendPropertyChanged("MusteriAd");
					this.OnMusteriAdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MusteriSoyad", DbType="NVarChar(20)")]
		public string MusteriSoyad
		{
			get
			{
				return this._MusteriSoyad;
			}
			set
			{
				if ((this._MusteriSoyad != value))
				{
					this.OnMusteriSoyadChanging(value);
					this.SendPropertyChanging();
					this._MusteriSoyad = value;
					this.SendPropertyChanged("MusteriSoyad");
					this.OnMusteriSoyadChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MusteriTc", DbType="NVarChar(11)")]
		public string MusteriTc
		{
			get
			{
				return this._MusteriTc;
			}
			set
			{
				if ((this._MusteriTc != value))
				{
					this.OnMusteriTcChanging(value);
					this.SendPropertyChanging();
					this._MusteriTc = value;
					this.SendPropertyChanged("MusteriTc");
					this.OnMusteriTcChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AracID", DbType="Int")]
		public System.Nullable<int> AracID
		{
			get
			{
				return this._AracID;
			}
			set
			{
				if ((this._AracID != value))
				{
					if (this._Arac.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnAracIDChanging(value);
					this.SendPropertyChanging();
					this._AracID = value;
					this.SendPropertyChanged("AracID");
					this.OnAracIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Alim", DbType="Date")]
		public System.Nullable<System.DateTime> Alim
		{
			get
			{
				return this._Alim;
			}
			set
			{
				if ((this._Alim != value))
				{
					this.OnAlimChanging(value);
					this.SendPropertyChanging();
					this._Alim = value;
					this.SendPropertyChanged("Alim");
					this.OnAlimChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Toplam", DbType="Int")]
		public System.Nullable<int> Toplam
		{
			get
			{
				return this._Toplam;
			}
			set
			{
				if ((this._Toplam != value))
				{
					this.OnToplamChanging(value);
					this.SendPropertyChanging();
					this._Toplam = value;
					this.SendPropertyChanged("Toplam");
					this.OnToplamChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Teslim", DbType="Date")]
		public System.Nullable<System.DateTime> Teslim
		{
			get
			{
				return this._Teslim;
			}
			set
			{
				if ((this._Teslim != value))
				{
					this.OnTeslimChanging(value);
					this.SendPropertyChanging();
					this._Teslim = value;
					this.SendPropertyChanged("Teslim");
					this.OnTeslimChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Arac_Kirala", Storage="_Arac", ThisKey="AracID", OtherKey="AracID", IsForeignKey=true)]
		public Arac Arac
		{
			get
			{
				return this._Arac.Entity;
			}
			set
			{
				Arac previousValue = this._Arac.Entity;
				if (((previousValue != value) 
							|| (this._Arac.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Arac.Entity = null;
						previousValue.Kiralas.Remove(this);
					}
					this._Arac.Entity = value;
					if ((value != null))
					{
						value.Kiralas.Add(this);
						this._AracID = value.AracID;
					}
					else
					{
						this._AracID = default(Nullable<int>);
					}
					this.SendPropertyChanged("Arac");
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
