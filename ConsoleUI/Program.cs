using Business.Concretes;
using DataAccess.Concretes.EntityFramework;
using Entities.Concretes;

namespace ConsoleUI
{
    ////İkinci aşama. Önceki derste (çarşamba) oluşturduğumuz 4 varlığı (entity) //TobetoCourseAcademy projesine uygulayınız. 
    /////program.cs de mutlaka veri girişleri yapınız.
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Course
            Course course1 = new Course
            {
                CategoryId = 1,
                Description = "test",
                ImageUrl = "test",
                Name = "C#",
                Price = 35
            };
            Course course2 = new Course
            {
                CategoryId = 1,
                Description = "test",
                ImageUrl = "test",
                Name = "JAVA",
                Price = 35
            };
            Course course3 = new Course
            {
                Id = 3,
                CategoryId = 2,
                Description = "test",
                ImageUrl = "test",
                Name = "JavaScript",
                Price = 35
            };

            #endregion

            #region Category
            Category category1 = new Category { Name = "Backend" };
            Category category2 = new Category { Name = "FrontEnd" };

            #endregion

            #region Instructor
            Instructor instructor1 = new Instructor {FirstName = "Kadir ", LastName = "Avşar" };
            Instructor instructor2 = new Instructor {FirstName = "Metin ", LastName = "Koyuncu" };
            Instructor instructor3 = new Instructor { FirstName = "Özkan ", LastName = "Akkaya" };
            Instructor instructor4 = new Instructor {FirstName = "Burak ", LastName = "Tan" };
            #endregion

            //Kurs Ve Eğitmen İlişkileri
            List<Course> courses = new List<Course>() { course1, course2, course3 };
            CourseManager courseManager = new CourseManager(new EfCourseDal());
            courseManager.Delete(course3);
            foreach (var course in courses)
            {
                //courseManager.Add(course);
            }

            List<Category> categories = new List<Category>() { category1,category2 };
            CategoryManager courseManager1 = new CategoryManager(new EfCategoryDal());
            foreach (var course in categories)
            {
                //courseManager1.Add(course);
            }

            List<Instructor> instructors = new List<Instructor>() { instructor1, instructor2,instructor3,instructor4 };
            InstructorManager instructorManager = new InstructorManager(new EfInstructorDal());
            foreach (var instructor in instructors)
            {
                //instructorManager.Add(instructor);
            }





        }
    }
}