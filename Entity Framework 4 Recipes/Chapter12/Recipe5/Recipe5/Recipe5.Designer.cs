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
#region EDM Relationship Metadata

[assembly: EdmRelationshipAttribute("EFRecipesModel", "FK_Class_Course", "Course", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(Recipe5.Course), "Class", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(Recipe5.Class), true)]
[assembly: EdmRelationshipAttribute("EFRecipesModel", "FK_Enrollment_Class", "Class", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(Recipe5.Class), "Enrollment", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(Recipe5.Enrollment), true)]

#endregion

namespace Recipe5
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class EFRecipesEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new EFRecipesEntities object using the connection string found in the 'EFRecipesEntities' section of the application configuration file.
        /// </summary>
        public EFRecipesEntities() : base("name=EFRecipesEntities", "EFRecipesEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new EFRecipesEntities object.
        /// </summary>
        public EFRecipesEntities(string connectionString) : base(connectionString, "EFRecipesEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new EFRecipesEntities object.
        /// </summary>
        public EFRecipesEntities(EntityConnection connection) : base(connection, "EFRecipesEntities")
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
        public ObjectSet<Class> Classes
        {
            get
            {
                if ((_Classes == null))
                {
                    _Classes = base.CreateObjectSet<Class>("Classes");
                }
                return _Classes;
            }
        }
        private ObjectSet<Class> _Classes;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Course> Courses
        {
            get
            {
                if ((_Courses == null))
                {
                    _Courses = base.CreateObjectSet<Course>("Courses");
                }
                return _Courses;
            }
        }
        private ObjectSet<Course> _Courses;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Enrollment> Enrollments
        {
            get
            {
                if ((_Enrollments == null))
                {
                    _Enrollments = base.CreateObjectSet<Enrollment>("Enrollments");
                }
                return _Enrollments;
            }
        }
        private ObjectSet<Enrollment> _Enrollments;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Classes EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToClasses(Class @class)
        {
            base.AddObject("Classes", @class);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Courses EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToCourses(Course course)
        {
            base.AddObject("Courses", course);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Enrollments EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToEnrollments(Enrollment enrollment)
        {
            base.AddObject("Enrollments", enrollment);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="EFRecipesModel", Name="Class")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Class : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Class object.
        /// </summary>
        /// <param name="classId">Initial value of the ClassId property.</param>
        /// <param name="courseId">Initial value of the CourseId property.</param>
        /// <param name="instructor">Initial value of the Instructor property.</param>
        public static Class CreateClass(global::System.Int32 classId, global::System.Int32 courseId, global::System.String instructor)
        {
            Class @class = new Class();
            @class.ClassId = classId;
            @class.CourseId = courseId;
            @class.Instructor = instructor;
            return @class;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 ClassId
        {
            get
            {
                return _ClassId;
            }
            set
            {
                if (_ClassId != value)
                {
                    OnClassIdChanging(value);
                    ReportPropertyChanging("ClassId");
                    _ClassId = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("ClassId");
                    OnClassIdChanged();
                }
            }
        }
        private global::System.Int32 _ClassId;
        partial void OnClassIdChanging(global::System.Int32 value);
        partial void OnClassIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 CourseId
        {
            get
            {
                return _CourseId;
            }
            set
            {
                OnCourseIdChanging(value);
                ReportPropertyChanging("CourseId");
                _CourseId = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("CourseId");
                OnCourseIdChanged();
            }
        }
        private global::System.Int32 _CourseId;
        partial void OnCourseIdChanging(global::System.Int32 value);
        partial void OnCourseIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Instructor
        {
            get
            {
                return _Instructor;
            }
            set
            {
                OnInstructorChanging(value);
                ReportPropertyChanging("Instructor");
                _Instructor = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Instructor");
                OnInstructorChanged();
            }
        }
        private global::System.String _Instructor;
        partial void OnInstructorChanging(global::System.String value);
        partial void OnInstructorChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("EFRecipesModel", "FK_Class_Course", "Course")]
        public Course Course
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Course>("EFRecipesModel.FK_Class_Course", "Course").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Course>("EFRecipesModel.FK_Class_Course", "Course").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Course> CourseReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Course>("EFRecipesModel.FK_Class_Course", "Course");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Course>("EFRecipesModel.FK_Class_Course", "Course", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("EFRecipesModel", "FK_Enrollment_Class", "Enrollment")]
        public EntityCollection<Enrollment> Enrollments
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Enrollment>("EFRecipesModel.FK_Enrollment_Class", "Enrollment");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Enrollment>("EFRecipesModel.FK_Enrollment_Class", "Enrollment", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="EFRecipesModel", Name="Course")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Course : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Course object.
        /// </summary>
        /// <param name="courseId">Initial value of the CourseId property.</param>
        /// <param name="courseName">Initial value of the CourseName property.</param>
        public static Course CreateCourse(global::System.Int32 courseId, global::System.String courseName)
        {
            Course course = new Course();
            course.CourseId = courseId;
            course.CourseName = courseName;
            return course;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 CourseId
        {
            get
            {
                return _CourseId;
            }
            set
            {
                if (_CourseId != value)
                {
                    OnCourseIdChanging(value);
                    ReportPropertyChanging("CourseId");
                    _CourseId = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("CourseId");
                    OnCourseIdChanged();
                }
            }
        }
        private global::System.Int32 _CourseId;
        partial void OnCourseIdChanging(global::System.Int32 value);
        partial void OnCourseIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String CourseName
        {
            get
            {
                return _CourseName;
            }
            set
            {
                OnCourseNameChanging(value);
                ReportPropertyChanging("CourseName");
                _CourseName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("CourseName");
                OnCourseNameChanged();
            }
        }
        private global::System.String _CourseName;
        partial void OnCourseNameChanging(global::System.String value);
        partial void OnCourseNameChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("EFRecipesModel", "FK_Class_Course", "Class")]
        public EntityCollection<Class> Classes
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Class>("EFRecipesModel.FK_Class_Course", "Class");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Class>("EFRecipesModel.FK_Class_Course", "Class", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="EFRecipesModel", Name="Enrollment")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Enrollment : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Enrollment object.
        /// </summary>
        /// <param name="enrollmentId">Initial value of the EnrollmentId property.</param>
        /// <param name="classId">Initial value of the ClassId property.</param>
        /// <param name="student">Initial value of the Student property.</param>
        public static Enrollment CreateEnrollment(global::System.Int32 enrollmentId, global::System.Int32 classId, global::System.String student)
        {
            Enrollment enrollment = new Enrollment();
            enrollment.EnrollmentId = enrollmentId;
            enrollment.ClassId = classId;
            enrollment.Student = student;
            return enrollment;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 EnrollmentId
        {
            get
            {
                return _EnrollmentId;
            }
            set
            {
                if (_EnrollmentId != value)
                {
                    OnEnrollmentIdChanging(value);
                    ReportPropertyChanging("EnrollmentId");
                    _EnrollmentId = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("EnrollmentId");
                    OnEnrollmentIdChanged();
                }
            }
        }
        private global::System.Int32 _EnrollmentId;
        partial void OnEnrollmentIdChanging(global::System.Int32 value);
        partial void OnEnrollmentIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 ClassId
        {
            get
            {
                return _ClassId;
            }
            set
            {
                OnClassIdChanging(value);
                ReportPropertyChanging("ClassId");
                _ClassId = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("ClassId");
                OnClassIdChanged();
            }
        }
        private global::System.Int32 _ClassId;
        partial void OnClassIdChanging(global::System.Int32 value);
        partial void OnClassIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Student
        {
            get
            {
                return _Student;
            }
            set
            {
                OnStudentChanging(value);
                ReportPropertyChanging("Student");
                _Student = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Student");
                OnStudentChanged();
            }
        }
        private global::System.String _Student;
        partial void OnStudentChanging(global::System.String value);
        partial void OnStudentChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("EFRecipesModel", "FK_Enrollment_Class", "Class")]
        public Class Class
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Class>("EFRecipesModel.FK_Enrollment_Class", "Class").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Class>("EFRecipesModel.FK_Enrollment_Class", "Class").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Class> ClassReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Class>("EFRecipesModel.FK_Enrollment_Class", "Class");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Class>("EFRecipesModel.FK_Enrollment_Class", "Class", value);
                }
            }
        }

        #endregion
    }

    #endregion
    
}
