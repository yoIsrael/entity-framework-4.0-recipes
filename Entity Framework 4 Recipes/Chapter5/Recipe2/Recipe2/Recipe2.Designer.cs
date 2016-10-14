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
[assembly: EdmRelationshipAttribute("EFRecipesModel", "FK_Section_Course", "Course", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(Recipe2.Course), "Section", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(Recipe2.Section), true)]
[assembly: EdmRelationshipAttribute("EFRecipesModel", "FK_Section_Instructor", "Instructor", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(Recipe2.Instructor), "Section", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(Recipe2.Section), true)]
[assembly: EdmRelationshipAttribute("EFRecipesModel", "SectionStudent", "Section", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(Recipe2.Section), "Student", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(Recipe2.Student))]
#endregion

namespace Recipe2
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
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new EFRecipesEntities object.
        /// </summary>
        public EFRecipesEntities(string connectionString) : base(connectionString, "EFRecipesEntities")
        {
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new EFRecipesEntities object.
        /// </summary>
        public EFRecipesEntities(EntityConnection connection) : base(connection, "EFRecipesEntities")
        {
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
        public ObjectSet<Instructor> Instructors
        {
            get
            {
                if ((_Instructors == null))
                {
                    _Instructors = base.CreateObjectSet<Instructor>("Instructors");
                }
                return _Instructors;
            }
        }
        private ObjectSet<Instructor> _Instructors;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Section> Sections
        {
            get
            {
                if ((_Sections == null))
                {
                    _Sections = base.CreateObjectSet<Section>("Sections");
                }
                return _Sections;
            }
        }
        private ObjectSet<Section> _Sections;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Student> Students
        {
            get
            {
                if ((_Students == null))
                {
                    _Students = base.CreateObjectSet<Student>("Students");
                }
                return _Students;
            }
        }
        private ObjectSet<Student> _Students;
    
        #endregion
        #region AddTo Methods
            
        /// <summary>
        /// Deprecated Method for adding a new object to the Courses EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToCourses(Course course)
        {
            base.AddObject("Courses", course);
        }
            
        /// <summary>
        /// Deprecated Method for adding a new object to the Instructors EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToInstructors(Instructor instructor)
        {
            base.AddObject("Instructors", instructor);
        }
            
        /// <summary>
        /// Deprecated Method for adding a new object to the Sections EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToSections(Section section)
        {
            base.AddObject("Sections", section);
        }
            
        /// <summary>
        /// Deprecated Method for adding a new object to the Students EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToStudents(Student student)
        {
            base.AddObject("Students", student);
        }
        #endregion
    }
    
    #endregion
    
    
    #region Entities
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
        /// <param name="title">Initial value of the Title property.</param>
        public static Course CreateCourse(global::System.Int32 courseId, global::System.String title)
        {
            Course course = new Course();
            course.CourseId = courseId;
            
            course.Title = title;
            
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
        public global::System.String Title
        {
            get
            {
                return _Title;
            }
            set
            {
                OnTitleChanging(value);
                ReportPropertyChanging("Title");
                _Title = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Title");
                OnTitleChanged();
            }
                
        }
        private global::System.String _Title;
        partial void OnTitleChanging(global::System.String value);
        partial void OnTitleChanged();
        
        #endregion
    
        #region Navigation Properties
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("EFRecipesModel", "FK_Section_Course", "Section")] 
        public EntityCollection<Section> Sections
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Section>("EFRecipesModel.FK_Section_Course", "Section");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Section>("EFRecipesModel.FK_Section_Course", "Section", value);
                }
            }
        }
        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="EFRecipesModel", Name="Instructor")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Instructor : EntityObject
    {
        #region Factory Method
        /// <summary>
        /// Create a new Instructor object.
        /// </summary>
        /// <param name="instructorId">Initial value of the InstructorId property.</param>
        /// <param name="name">Initial value of the Name property.</param>
        public static Instructor CreateInstructor(global::System.Int32 instructorId, global::System.String name)
        {
            Instructor instructor = new Instructor();
            instructor.InstructorId = instructorId;
            
            instructor.Name = name;
            
            return instructor;
        }
        #endregion

        #region Primitive Properties
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 InstructorId
        {
            get
            {
                return _InstructorId;
            }
            set
            {
                if (_InstructorId != value)
                {
                    OnInstructorIdChanging(value);
                    ReportPropertyChanging("InstructorId");
                    _InstructorId = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("InstructorId");
                    OnInstructorIdChanged();
                }
            }
                
        }
        private global::System.Int32 _InstructorId;
        partial void OnInstructorIdChanging(global::System.Int32 value);
        partial void OnInstructorIdChanged();
        
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                OnNameChanging(value);
                ReportPropertyChanging("Name");
                _Name = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Name");
                OnNameChanged();
            }
                
        }
        private global::System.String _Name;
        partial void OnNameChanging(global::System.String value);
        partial void OnNameChanged();
        
        #endregion
    
        #region Navigation Properties
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("EFRecipesModel", "FK_Section_Instructor", "Section")] 
        public EntityCollection<Section> Sections
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Section>("EFRecipesModel.FK_Section_Instructor", "Section");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Section>("EFRecipesModel.FK_Section_Instructor", "Section", value);
                }
            }
        }
        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="EFRecipesModel", Name="Section")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Section : EntityObject
    {
        #region Factory Method
        /// <summary>
        /// Create a new Section object.
        /// </summary>
        /// <param name="sectionId">Initial value of the SectionId property.</param>
        /// <param name="instructorId">Initial value of the InstructorId property.</param>
        /// <param name="courseId">Initial value of the CourseId property.</param>
        public static Section CreateSection(global::System.Int32 sectionId, global::System.Int32 instructorId, global::System.Int32 courseId)
        {
            Section section = new Section();
            section.SectionId = sectionId;
            
            section.InstructorId = instructorId;
            
            section.CourseId = courseId;
            
            return section;
        }
        #endregion

        #region Primitive Properties
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 SectionId
        {
            get
            {
                return _SectionId;
            }
            set
            {
                if (_SectionId != value)
                {
                    OnSectionIdChanging(value);
                    ReportPropertyChanging("SectionId");
                    _SectionId = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("SectionId");
                    OnSectionIdChanged();
                }
            }
                
        }
        private global::System.Int32 _SectionId;
        partial void OnSectionIdChanging(global::System.Int32 value);
        partial void OnSectionIdChanged();
        
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 InstructorId
        {
            get
            {
                return _InstructorId;
            }
            set
            {
                OnInstructorIdChanging(value);
                ReportPropertyChanging("InstructorId");
                _InstructorId = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("InstructorId");
                OnInstructorIdChanged();
            }
                
        }
        private global::System.Int32 _InstructorId;
        partial void OnInstructorIdChanging(global::System.Int32 value);
        partial void OnInstructorIdChanged();
        
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
        
        #endregion
    
        #region Navigation Properties
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("EFRecipesModel", "FK_Section_Course", "Course")] 
        public Course Course
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Course>("EFRecipesModel.FK_Section_Course", "Course").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Course>("EFRecipesModel.FK_Section_Course", "Course").Value = value;
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
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Course>("EFRecipesModel.FK_Section_Course", "Course");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Course>("EFRecipesModel.FK_Section_Course", "Course", value);
                }
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("EFRecipesModel", "FK_Section_Instructor", "Instructor")] 
        public Instructor Instructor
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Instructor>("EFRecipesModel.FK_Section_Instructor", "Instructor").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Instructor>("EFRecipesModel.FK_Section_Instructor", "Instructor").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Instructor> InstructorReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Instructor>("EFRecipesModel.FK_Section_Instructor", "Instructor");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Instructor>("EFRecipesModel.FK_Section_Instructor", "Instructor", value);
                }
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("EFRecipesModel", "SectionStudent", "Student")] 
        public EntityCollection<Student> Students
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Student>("EFRecipesModel.SectionStudent", "Student");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Student>("EFRecipesModel.SectionStudent", "Student", value);
                }
            }
        }
        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="EFRecipesModel", Name="Student")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Student : EntityObject
    {
        #region Factory Method
        /// <summary>
        /// Create a new Student object.
        /// </summary>
        /// <param name="studentId">Initial value of the StudentId property.</param>
        /// <param name="name">Initial value of the Name property.</param>
        public static Student CreateStudent(global::System.Int32 studentId, global::System.String name)
        {
            Student student = new Student();
            student.StudentId = studentId;
            
            student.Name = name;
            
            return student;
        }
        #endregion

        #region Primitive Properties
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 StudentId
        {
            get
            {
                return _StudentId;
            }
            set
            {
                if (_StudentId != value)
                {
                    OnStudentIdChanging(value);
                    ReportPropertyChanging("StudentId");
                    _StudentId = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("StudentId");
                    OnStudentIdChanged();
                }
            }
                
        }
        private global::System.Int32 _StudentId;
        partial void OnStudentIdChanging(global::System.Int32 value);
        partial void OnStudentIdChanged();
        
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                OnNameChanging(value);
                ReportPropertyChanging("Name");
                _Name = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Name");
                OnNameChanged();
            }
                
        }
        private global::System.String _Name;
        partial void OnNameChanging(global::System.String value);
        partial void OnNameChanged();
        
        #endregion
    
        #region Navigation Properties
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("EFRecipesModel", "SectionStudent", "Section")] 
        public EntityCollection<Section> Sections
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Section>("EFRecipesModel.SectionStudent", "Section");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Section>("EFRecipesModel.SectionStudent", "Section", value);
                }
            }
        }
        #endregion
    }
    
    #endregion
    
}
