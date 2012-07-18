﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]

namespace GolfStopp.Data
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class golfstoppdbEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new golfstoppdbEntities object using the connection string found in the 'golfstoppdbEntities' section of the application configuration file.
        /// </summary>
        public golfstoppdbEntities() : base("name=golfstoppdbEntities", "golfstoppdbEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new golfstoppdbEntities object.
        /// </summary>
        public golfstoppdbEntities(string connectionString) : base(connectionString, "golfstoppdbEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new golfstoppdbEntities object.
        /// </summary>
        public golfstoppdbEntities(EntityConnection connection) : base(connection, "golfstoppdbEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<clubs> clubs
        {
            get
            {
                if ((_clubs == null))
                {
                    _clubs = base.CreateObjectSet<clubs>("clubs");
                }
                return _clubs;
            }
        }
        private ObjectSet<clubs> _clubs;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<courses> courses
        {
            get
            {
                if ((_courses == null))
                {
                    _courses = base.CreateObjectSet<courses>("courses");
                }
                return _courses;
            }
        }
        private ObjectSet<courses> _courses;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the clubs EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToclubs(clubs clubs)
        {
            base.AddObject("clubs", clubs);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the courses EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTocourses(courses courses)
        {
            base.AddObject("courses", courses);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="golfstoppdbModel", Name="clubs")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class clubs : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new clubs object.
        /// </summary>
        /// <param name="id">Initial value of the id property.</param>
        public static clubs Createclubs(global::System.String id)
        {
            clubs clubs = new clubs();
            clubs.id = id;
            return clubs;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String id
        {
            get
            {
                return _id;
            }
            set
            {
                if (_id != value)
                {
                    OnidChanging(value);
                    ReportPropertyChanging("id");
                    _id = StructuralObject.SetValidValue(value, false);
                    ReportPropertyChanged("id");
                    OnidChanged();
                }
            }
        }
        private global::System.String _id;
        partial void OnidChanging(global::System.String value);
        partial void OnidChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String name
        {
            get
            {
                return _name;
            }
            set
            {
                OnnameChanging(value);
                ReportPropertyChanging("name");
                _name = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("name");
                OnnameChanged();
            }
        }
        private global::System.String _name;
        partial void OnnameChanging(global::System.String value);
        partial void OnnameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String golfseId
        {
            get
            {
                return _golfseId;
            }
            set
            {
                OngolfseIdChanging(value);
                ReportPropertyChanging("golfseId");
                _golfseId = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("golfseId");
                OngolfseIdChanged();
            }
        }
        private global::System.String _golfseId;
        partial void OngolfseIdChanging(global::System.String value);
        partial void OngolfseIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Double> mapLat
        {
            get
            {
                return _mapLat;
            }
            set
            {
                OnmapLatChanging(value);
                ReportPropertyChanging("mapLat");
                _mapLat = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("mapLat");
                OnmapLatChanged();
            }
        }
        private Nullable<global::System.Double> _mapLat;
        partial void OnmapLatChanging(Nullable<global::System.Double> value);
        partial void OnmapLatChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Double> mapLng
        {
            get
            {
                return _mapLng;
            }
            set
            {
                OnmapLngChanging(value);
                ReportPropertyChanging("mapLng");
                _mapLng = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("mapLng");
                OnmapLngChanged();
            }
        }
        private Nullable<global::System.Double> _mapLng;
        partial void OnmapLngChanging(Nullable<global::System.Double> value);
        partial void OnmapLngChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String homepage
        {
            get
            {
                return _homepage;
            }
            set
            {
                OnhomepageChanging(value);
                ReportPropertyChanging("homepage");
                _homepage = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("homepage");
                OnhomepageChanged();
            }
        }
        private global::System.String _homepage;
        partial void OnhomepageChanging(global::System.String value);
        partial void OnhomepageChanged();

        #endregion
    
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="golfstoppdbModel", Name="courses")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class courses : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new courses object.
        /// </summary>
        /// <param name="id">Initial value of the id property.</param>
        /// <param name="clubId">Initial value of the clubId property.</param>
        public static courses Createcourses(global::System.String id, global::System.String clubId)
        {
            courses courses = new courses();
            courses.id = id;
            courses.clubId = clubId;
            return courses;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String id
        {
            get
            {
                return _id;
            }
            set
            {
                if (_id != value)
                {
                    OnidChanging(value);
                    ReportPropertyChanging("id");
                    _id = StructuralObject.SetValidValue(value, false);
                    ReportPropertyChanged("id");
                    OnidChanged();
                }
            }
        }
        private global::System.String _id;
        partial void OnidChanging(global::System.String value);
        partial void OnidChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String clubId
        {
            get
            {
                return _clubId;
            }
            set
            {
                OnclubIdChanging(value);
                ReportPropertyChanging("clubId");
                _clubId = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("clubId");
                OnclubIdChanged();
            }
        }
        private global::System.String _clubId;
        partial void OnclubIdChanging(global::System.String value);
        partial void OnclubIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String name
        {
            get
            {
                return _name;
            }
            set
            {
                OnnameChanging(value);
                ReportPropertyChanging("name");
                _name = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("name");
                OnnameChanged();
            }
        }
        private global::System.String _name;
        partial void OnnameChanging(global::System.String value);
        partial void OnnameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> par
        {
            get
            {
                return _par;
            }
            set
            {
                OnparChanging(value);
                ReportPropertyChanging("par");
                _par = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("par");
                OnparChanged();
            }
        }
        private Nullable<global::System.Int32> _par;
        partial void OnparChanging(Nullable<global::System.Int32> value);
        partial void OnparChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> numberOfHoles
        {
            get
            {
                return _numberOfHoles;
            }
            set
            {
                OnnumberOfHolesChanging(value);
                ReportPropertyChanging("numberOfHoles");
                _numberOfHoles = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("numberOfHoles");
                OnnumberOfHolesChanged();
            }
        }
        private Nullable<global::System.Int32> _numberOfHoles;
        partial void OnnumberOfHolesChanging(Nullable<global::System.Int32> value);
        partial void OnnumberOfHolesChanged();

        #endregion
    
    }

    #endregion
    
}
