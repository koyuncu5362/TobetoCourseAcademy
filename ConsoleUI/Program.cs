using Business.Concretes;
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
                Id = 1,
                CategoryId = 1,
                Description = "test",
                ImageUrl = "test",
                Name = "C#",
                Price = 35
            };
            Course course2 = new Course
            {
                Id = 2,
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
                Name = "React",
                Price = 35
            };
            CourseManager courseManager = new CourseManager();
            courseManager.Add(course1);
            courseManager.Add(course2);
            courseManager.Add(course3);
            #endregion

            #region Category
            Category category1 = new Category { Id = 1, Name = "Backend" };
            Category category2 = new Category { Id = 2, Name = "FrontEnd" };
            CategoryManager manager = new CategoryManager();
            manager.Add(category1);
            manager.Add(category2);
            #endregion

            #region Instructor
            Instructor instructor1 = new Instructor { Id = 1, FirstName = "Kadir ", LastName = "Avşar" };
            Instructor instructor2 = new Instructor { Id = 2, FirstName = "Metin ", LastName = "Koyuncu" };
            Instructor instructor3 = new Instructor { Id = 3, FirstName = "Özkan ", LastName = "Akkaya" };
            Instructor instructor4 = new Instructor { Id = 4, FirstName = "Burak ", LastName = "Tan" };
            InstructorManager instructorManager = new InstructorManager();
            instructorManager.Add(instructor1);
            instructorManager.Add(instructor2);
            instructorManager.Add(instructor3);
            instructorManager.Add(instructor4);
            #endregion

            //Kurs Ve Eğitmen İlişkileri
            CourseInstructor courseInstructor = new CourseInstructor { Id = 1, CourseId = 1, InstructorId = 1 };
            CourseInstructor courseInstructor2 = new CourseInstructor { Id = 2, CourseId = 1, InstructorId = 2 };
            CourseInstructor courseInstructor3 = new CourseInstructor { Id = 3, CourseId = 2, InstructorId = 3 };
            CourseInstructor courseInstructor4 = new CourseInstructor { Id = 4, CourseId = 2, InstructorId = 4 };
            CourseInstructor courseInstructor5 = new CourseInstructor { Id = 5, CourseId = 3, InstructorId = 1 };
            CourseInstructor courseInstructor6 = new CourseInstructor { Id = 6, CourseId = 3, InstructorId = 4 };

            //Kategorilere Kurs Ekleme
            category1.Courses = new Course[] { course1 };
            category2.Courses = new Course[] { course2, course3 };


            Instructor[] ınstructors = new Instructor[] { instructor1, instructor2, instructor3, instructor4 };

            //Eğitmenlere Kurs Ekleme
            instructor1.GetCourseInstructor = new CourseInstructor[] { courseInstructor, courseInstructor2 };
            instructor2.GetCourseInstructor = new CourseInstructor[] { courseInstructor3, courseInstructor4, courseInstructor5, courseInstructor6 };
            instructor3.GetCourseInstructor = new CourseInstructor[] { courseInstructor2, courseInstructor };
            instructor4.GetCourseInstructor = new CourseInstructor[] { courseInstructor4, courseInstructor5, courseInstructor6 };

            //Kurslara Kategori Ekleme
            course1.Category = category1;
            course2.Category = category2;
            course3.Category = category2;

            course1.GetCourseInstructor = new CourseInstructor[] { courseInstructor, courseInstructor2 };
            course2.GetCourseInstructor = new CourseInstructor[] { courseInstructor3, courseInstructor4 };
            course3.GetCourseInstructor = new CourseInstructor[] { courseInstructor5, courseInstructor6 };

            Console.Clear();
            foreach (var course in category1.Courses)
            {
                Console.WriteLine("Kurs Adı: " + course.Name);
                Console.WriteLine("Kurs Açıklaması: " + course.Description);
                Console.Write("Eğitmenler: ");
                foreach (var instructor in course.GetCourseInstructor)
                {
                    foreach (var item in ınstructors)
                    {
                        if (item.Id == instructor.InstructorId)
                        {
                            Console.WriteLine(item.FirstName + " " + item.LastName + " ,");
                        }
                    }
                    Console.WriteLine(instructor.Instructor?.FirstName);
                }
                Console.WriteLine("Fiyatı: " + course.Price);
                Console.WriteLine("Kategorisi: " + course.Category.Name);

            }
            Console.WriteLine();

            foreach (var course in category2.Courses)
            {
                Console.WriteLine("Kurs Adı: " + course.Name);
                Console.WriteLine("Kurs Açıklaması: " + course.Description);
                Console.Write("Eğitmenler: ");
                foreach (var instructor in course.GetCourseInstructor)
                {
                    foreach (var item in ınstructors)
                    {
                        if (item.Id == instructor.InstructorId)
                        {
                            Console.WriteLine(item.FirstName + " " + item.LastName + " ,");
                        }
                    }
                    Console.WriteLine(instructor.Instructor?.FirstName);
                }
                Console.WriteLine("Fiyatı: " + course.Price);
                Console.WriteLine("Kategorisi: " + course.Category.Name);
            }
        }
    }
}