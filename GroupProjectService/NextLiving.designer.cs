#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GroupProjectService
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Database")]
	public partial class DataClassesDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertAccomadation(Accomadation instance);
    partial void UpdateAccomadation(Accomadation instance);
    partial void DeleteAccomadation(Accomadation instance);
    partial void InsertUser(User instance);
    partial void UpdateUser(User instance);
    partial void DeleteUser(User instance);
    partial void InsertAccomadationBooking(AccomadationBooking instance);
    partial void UpdateAccomadationBooking(AccomadationBooking instance);
    partial void DeleteAccomadationBooking(AccomadationBooking instance);
    partial void InsertAdmin(Admin instance);
    partial void UpdateAdmin(Admin instance);
    partial void DeleteAdmin(Admin instance);
    partial void InsertOwner(Owner instance);
    partial void UpdateOwner(Owner instance);
    partial void DeleteOwner(Owner instance);
    partial void InsertStudent(Student instance);
    partial void UpdateStudent(Student instance);
    partial void DeleteStudent(Student instance);
    #endregion
		
		public DataClassesDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Accomadation> Accomadations
		{
			get
			{
				return this.GetTable<Accomadation>();
			}
		}
		
		public System.Data.Linq.Table<User> Users
		{
			get
			{
				return this.GetTable<User>();
			}
		}
		
		public System.Data.Linq.Table<AccomadationBooking> AccomadationBookings
		{
			get
			{
				return this.GetTable<AccomadationBooking>();
			}
		}
		
		public System.Data.Linq.Table<Admin> Admins
		{
			get
			{
				return this.GetTable<Admin>();
			}
		}
		
		public System.Data.Linq.Table<BookMark> BookMarks
		{
			get
			{
				return this.GetTable<BookMark>();
			}
		}
		
		public System.Data.Linq.Table<Owner> Owners
		{
			get
			{
				return this.GetTable<Owner>();
			}
		}
		
		public System.Data.Linq.Table<Student> Students
		{
			get
			{
				return this.GetTable<Student>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Accomadation")]
	public partial class Accomadation : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _AccomadationId;
		
		private string _AccomadationName;
		
		private string _AccomadationLocation;
		
		private System.Nullable<int> _AccomadationRating;
		
		private string _AccomadationFacilities;
		
		private string _AccomadationDescription;
		
		private System.Nullable<int> _OwnerId;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnAccomadationIdChanging(int value);
    partial void OnAccomadationIdChanged();
    partial void OnAccomadationNameChanging(string value);
    partial void OnAccomadationNameChanged();
    partial void OnAccomadationLocationChanging(string value);
    partial void OnAccomadationLocationChanged();
    partial void OnAccomadationRatingChanging(System.Nullable<int> value);
    partial void OnAccomadationRatingChanged();
    partial void OnAccomadationFacilitiesChanging(string value);
    partial void OnAccomadationFacilitiesChanged();
    partial void OnAccomadationDescriptionChanging(string value);
    partial void OnAccomadationDescriptionChanged();
    partial void OnOwnerIdChanging(System.Nullable<int> value);
    partial void OnOwnerIdChanged();
    #endregion
		
		public Accomadation()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AccomadationId", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int AccomadationId
		{
			get
			{
				return this._AccomadationId;
			}
			set
			{
				if ((this._AccomadationId != value))
				{
					this.OnAccomadationIdChanging(value);
					this.SendPropertyChanging();
					this._AccomadationId = value;
					this.SendPropertyChanged("AccomadationId");
					this.OnAccomadationIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AccomadationName", DbType="VarChar(50)")]
		public string AccomadationName
		{
			get
			{
				return this._AccomadationName;
			}
			set
			{
				if ((this._AccomadationName != value))
				{
					this.OnAccomadationNameChanging(value);
					this.SendPropertyChanging();
					this._AccomadationName = value;
					this.SendPropertyChanged("AccomadationName");
					this.OnAccomadationNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AccomadationLocation", DbType="VarChar(50)")]
		public string AccomadationLocation
		{
			get
			{
				return this._AccomadationLocation;
			}
			set
			{
				if ((this._AccomadationLocation != value))
				{
					this.OnAccomadationLocationChanging(value);
					this.SendPropertyChanging();
					this._AccomadationLocation = value;
					this.SendPropertyChanged("AccomadationLocation");
					this.OnAccomadationLocationChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AccomadationRating", DbType="Int")]
		public System.Nullable<int> AccomadationRating
		{
			get
			{
				return this._AccomadationRating;
			}
			set
			{
				if ((this._AccomadationRating != value))
				{
					this.OnAccomadationRatingChanging(value);
					this.SendPropertyChanging();
					this._AccomadationRating = value;
					this.SendPropertyChanged("AccomadationRating");
					this.OnAccomadationRatingChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AccomadationFacilities", DbType="VarChar(50)")]
		public string AccomadationFacilities
		{
			get
			{
				return this._AccomadationFacilities;
			}
			set
			{
				if ((this._AccomadationFacilities != value))
				{
					this.OnAccomadationFacilitiesChanging(value);
					this.SendPropertyChanging();
					this._AccomadationFacilities = value;
					this.SendPropertyChanged("AccomadationFacilities");
					this.OnAccomadationFacilitiesChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AccomadationDescription", DbType="VarChar(50)")]
		public string AccomadationDescription
		{
			get
			{
				return this._AccomadationDescription;
			}
			set
			{
				if ((this._AccomadationDescription != value))
				{
					this.OnAccomadationDescriptionChanging(value);
					this.SendPropertyChanging();
					this._AccomadationDescription = value;
					this.SendPropertyChanged("AccomadationDescription");
					this.OnAccomadationDescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OwnerId", DbType="Int")]
		public System.Nullable<int> OwnerId
		{
			get
			{
				return this._OwnerId;
			}
			set
			{
				if ((this._OwnerId != value))
				{
					this.OnOwnerIdChanging(value);
					this.SendPropertyChanging();
					this._OwnerId = value;
					this.SendPropertyChanged("OwnerId");
					this.OnOwnerIdChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.[User]")]
	public partial class User : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _UserId;
		
		private string _UserName;
		
		private string _UserSurname;
		
		private string _UserType;
		
		private string _UserContact;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUserIdChanging(int value);
    partial void OnUserIdChanged();
    partial void OnUserNameChanging(string value);
    partial void OnUserNameChanged();
    partial void OnUserSurnameChanging(string value);
    partial void OnUserSurnameChanged();
    partial void OnUserTypeChanging(string value);
    partial void OnUserTypeChanged();
    partial void OnUserContactChanging(string value);
    partial void OnUserContactChanged();
    #endregion
		
		public User()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserId", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int UserId
		{
			get
			{
				return this._UserId;
			}
			set
			{
				if ((this._UserId != value))
				{
					this.OnUserIdChanging(value);
					this.SendPropertyChanging();
					this._UserId = value;
					this.SendPropertyChanged("UserId");
					this.OnUserIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserName", DbType="VarChar(50)")]
		public string UserName
		{
			get
			{
				return this._UserName;
			}
			set
			{
				if ((this._UserName != value))
				{
					this.OnUserNameChanging(value);
					this.SendPropertyChanging();
					this._UserName = value;
					this.SendPropertyChanged("UserName");
					this.OnUserNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserSurname", DbType="VarChar(50)")]
		public string UserSurname
		{
			get
			{
				return this._UserSurname;
			}
			set
			{
				if ((this._UserSurname != value))
				{
					this.OnUserSurnameChanging(value);
					this.SendPropertyChanging();
					this._UserSurname = value;
					this.SendPropertyChanged("UserSurname");
					this.OnUserSurnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserType", DbType="VarChar(50)")]
		public string UserType
		{
			get
			{
				return this._UserType;
			}
			set
			{
				if ((this._UserType != value))
				{
					this.OnUserTypeChanging(value);
					this.SendPropertyChanging();
					this._UserType = value;
					this.SendPropertyChanged("UserType");
					this.OnUserTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserContact", DbType="VarChar(50)")]
		public string UserContact
		{
			get
			{
				return this._UserContact;
			}
			set
			{
				if ((this._UserContact != value))
				{
					this.OnUserContactChanging(value);
					this.SendPropertyChanging();
					this._UserContact = value;
					this.SendPropertyChanged("UserContact");
					this.OnUserContactChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.AccomadationBookings")]
	public partial class AccomadationBooking : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _BookingsId;
		
		private string _BookingDate;
		
		private System.Nullable<int> _AcoomadationID;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnBookingsIdChanging(int value);
    partial void OnBookingsIdChanged();
    partial void OnBookingDateChanging(string value);
    partial void OnBookingDateChanged();
    partial void OnAcoomadationIDChanging(System.Nullable<int> value);
    partial void OnAcoomadationIDChanged();
    #endregion
		
		public AccomadationBooking()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BookingsId", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int BookingsId
		{
			get
			{
				return this._BookingsId;
			}
			set
			{
				if ((this._BookingsId != value))
				{
					this.OnBookingsIdChanging(value);
					this.SendPropertyChanging();
					this._BookingsId = value;
					this.SendPropertyChanged("BookingsId");
					this.OnBookingsIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BookingDate", DbType="VarChar(50)")]
		public string BookingDate
		{
			get
			{
				return this._BookingDate;
			}
			set
			{
				if ((this._BookingDate != value))
				{
					this.OnBookingDateChanging(value);
					this.SendPropertyChanging();
					this._BookingDate = value;
					this.SendPropertyChanged("BookingDate");
					this.OnBookingDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AcoomadationID", DbType="Int")]
		public System.Nullable<int> AcoomadationID
		{
			get
			{
				return this._AcoomadationID;
			}
			set
			{
				if ((this._AcoomadationID != value))
				{
					this.OnAcoomadationIDChanging(value);
					this.SendPropertyChanging();
					this._AcoomadationID = value;
					this.SendPropertyChanged("AcoomadationID");
					this.OnAcoomadationIDChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Admin")]
	public partial class Admin : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _AdminId;
		
		private string _AdminPassword;
		
		private string _AdminUsername;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnAdminIdChanging(int value);
    partial void OnAdminIdChanged();
    partial void OnAdminPasswordChanging(string value);
    partial void OnAdminPasswordChanged();
    partial void OnAdminUsernameChanging(string value);
    partial void OnAdminUsernameChanged();
    #endregion
		
		public Admin()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AdminId", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int AdminId
		{
			get
			{
				return this._AdminId;
			}
			set
			{
				if ((this._AdminId != value))
				{
					this.OnAdminIdChanging(value);
					this.SendPropertyChanging();
					this._AdminId = value;
					this.SendPropertyChanged("AdminId");
					this.OnAdminIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AdminPassword", DbType="VarChar(50)")]
		public string AdminPassword
		{
			get
			{
				return this._AdminPassword;
			}
			set
			{
				if ((this._AdminPassword != value))
				{
					this.OnAdminPasswordChanging(value);
					this.SendPropertyChanging();
					this._AdminPassword = value;
					this.SendPropertyChanged("AdminPassword");
					this.OnAdminPasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AdminUsername", DbType="VarChar(50)")]
		public string AdminUsername
		{
			get
			{
				return this._AdminUsername;
			}
			set
			{
				if ((this._AdminUsername != value))
				{
					this.OnAdminUsernameChanging(value);
					this.SendPropertyChanging();
					this._AdminUsername = value;
					this.SendPropertyChanged("AdminUsername");
					this.OnAdminUsernameChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.BookMark")]
	public partial class BookMark
	{
		
		private System.Nullable<int> _StudentId;
		
		private System.Nullable<int> _AccomadationId;
		
		private System.Nullable<int> _BookmarkID;
		
		public BookMark()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StudentId", DbType="Int")]
		public System.Nullable<int> StudentId
		{
			get
			{
				return this._StudentId;
			}
			set
			{
				if ((this._StudentId != value))
				{
					this._StudentId = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AccomadationId", DbType="Int")]
		public System.Nullable<int> AccomadationId
		{
			get
			{
				return this._AccomadationId;
			}
			set
			{
				if ((this._AccomadationId != value))
				{
					this._AccomadationId = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BookmarkID", DbType="Int")]
		public System.Nullable<int> BookmarkID
		{
			get
			{
				return this._BookmarkID;
			}
			set
			{
				if ((this._BookmarkID != value))
				{
					this._BookmarkID = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Owner")]
	public partial class Owner : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _OwnerId;
		
		private System.Nullable<int> _UserId;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnOwnerIdChanging(int value);
    partial void OnOwnerIdChanged();
    partial void OnUserIdChanging(System.Nullable<int> value);
    partial void OnUserIdChanged();
    #endregion
		
		public Owner()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OwnerId", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int OwnerId
		{
			get
			{
				return this._OwnerId;
			}
			set
			{
				if ((this._OwnerId != value))
				{
					this.OnOwnerIdChanging(value);
					this.SendPropertyChanging();
					this._OwnerId = value;
					this.SendPropertyChanged("OwnerId");
					this.OnOwnerIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserId", DbType="Int")]
		public System.Nullable<int> UserId
		{
			get
			{
				return this._UserId;
			}
			set
			{
				if ((this._UserId != value))
				{
					this.OnUserIdChanging(value);
					this.SendPropertyChanging();
					this._UserId = value;
					this.SendPropertyChanged("UserId");
					this.OnUserIdChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Student")]
	public partial class Student : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _StudentId;
		
		private System.Nullable<int> _UserId;
		
		private System.Nullable<int> _FundingStatus;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnStudentIdChanging(int value);
    partial void OnStudentIdChanged();
    partial void OnUserIdChanging(System.Nullable<int> value);
    partial void OnUserIdChanged();
    partial void OnFundingStatusChanging(System.Nullable<int> value);
    partial void OnFundingStatusChanged();
    #endregion
		
		public Student()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StudentId", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int StudentId
		{
			get
			{
				return this._StudentId;
			}
			set
			{
				if ((this._StudentId != value))
				{
					this.OnStudentIdChanging(value);
					this.SendPropertyChanging();
					this._StudentId = value;
					this.SendPropertyChanged("StudentId");
					this.OnStudentIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserId", DbType="Int")]
		public System.Nullable<int> UserId
		{
			get
			{
				return this._UserId;
			}
			set
			{
				if ((this._UserId != value))
				{
					this.OnUserIdChanging(value);
					this.SendPropertyChanging();
					this._UserId = value;
					this.SendPropertyChanged("UserId");
					this.OnUserIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FundingStatus", DbType="Int")]
		public System.Nullable<int> FundingStatus
		{
			get
			{
				return this._FundingStatus;
			}
			set
			{
				if ((this._FundingStatus != value))
				{
					this.OnFundingStatusChanging(value);
					this.SendPropertyChanging();
					this._FundingStatus = value;
					this.SendPropertyChanged("FundingStatus");
					this.OnFundingStatusChanged();
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
