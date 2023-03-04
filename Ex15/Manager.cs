using Ex15.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Ex15
{
    internal class Manager
    {
        private static List<Major> majors = new List<Major>() { };
        enum StudentType
        {
            RegularStudent,
            ExchangeStudent
        }

        enum MenuOption
        {
            ListAll,
            AddStudent,
            ViewInformation,
            ViewAverageScore,
            ViewTotalStudentsOfEachMajor,
            ViewHighestEntryPointOfEachMajor,
            ViewExchangeStudent,
            ViewGoodStudent,
            ViewHighestMarkOfEachSemester,
            ViewSortedListByStartYear,
            ViewNumberOfStudentsByYear,
            Exit
        }
        public static void Menu()
        {
            while (true)
            {
                Console.WriteLine("=====================================================================");
                Console.WriteLine("1: Show list students");
                Console.WriteLine("2: Add a student");
                Console.WriteLine("3: View student information"); // 4. Phương thức xác định sinh viên có phải là chính quy hay không?
                Console.WriteLine("4: View average score by semester"); // 6. Phương thức lấy điểm trung bình các môn học của sinh viên dựa vào học kỳ cho trước
                Console.WriteLine("5: Total student of each major"); // 7. Phương thức xác định tổng số sinh viên chính quy của khoa?
                Console.WriteLine("6: View highest entry point of each major"); // 8. Tìm ra sinh viên có điểm đầu vào cao nhất ở mỗi khoa
                Console.WriteLine("7: View exchange students by partner institution"); // 9. Ở mỗi khoa, lấy ra danh sách các sinh viên tại chức tại nơi liên kết đào tạo cho trước
                Console.WriteLine("8: View good student at latest semester"); // 10. Ở mỗi khoa, lấy ra danh sách sinh viên có điểm trung bình ở học kỳ gần nhất(là học kỳ cuối cùng trong danh sách kết quả học tập của sinh viên) từ 8.0 trở lên
                Console.WriteLine("9: View highest mark of each semester"); // 11. Ở mỗi khoa, tìm ra sinh viên có điểm trung bình học kỳ cao nhất (ở bất kỳ học kỳ nào)
                Console.WriteLine("10: View sorted list by start year"); // 12. Ở mỗi khoa, sắp xếp danh sách sinh viên tăng dần theo loại và giảm dần theo năm vào học(sử dụng interface Comparable hoặc Comparator
                Console.WriteLine("11: View number of student by year"); // 13. Ở mỗi khoa, thống kê số lượng sinh viên theo năm vào học. Ví dụ 2020: 100,2019: 90, 2018: 120.
                Console.WriteLine("12: Exit");
                Console.WriteLine("Your choice: ");
                MenuOption option = (MenuOption)Validation.CheckOption(Enum.GetNames(typeof(MenuOption)).Length);
                switch (option)
                {
                    case MenuOption.ListAll:
                        ListAll();
                        break;
                    case MenuOption.AddStudent:
                        AddStudent();
                        break;
                    case MenuOption.ViewInformation:
                        ViewInformation();
                        break;
                    case MenuOption.ViewAverageScore:
                        ViewAverageScore();
                        break;
                    case MenuOption.ViewTotalStudentsOfEachMajor:
                        ViewTotalStudentsOfEachMajor();
                        break;
                    case MenuOption.ViewHighestEntryPointOfEachMajor:
                        ViewHighestEntryPointOfEachMajor();
                        break;
                    case MenuOption.ViewExchangeStudent:
                        ViewExchangeStudent();
                        break;
                    case MenuOption.ViewGoodStudent:
                        ViewGoodStudent();
                        break;
                    case MenuOption.ViewHighestMarkOfEachSemester:
                        ViewHighestMarkOfEachSemester();
                        break;
                    case MenuOption.ViewSortedListByStartYear:
                        ViewSortedListByStartYear();
                        break;
                    case MenuOption.ViewNumberOfStudentsByYear:
                        ViewNumberOfStudentsByYear();
                        break;
                    case MenuOption.Exit:
                        return;
                }
            }
        }

        private static StudentType ChooseStudentType()
        {
            Console.WriteLine("1. Regular student");
            Console.WriteLine("2. Exchange student");
            Console.WriteLine("Choose one:");
            StudentType option = (StudentType)Validation.CheckOption(Enum.GetNames(typeof(MenuOption)).Length);
            return option;
        }

        private static void ViewNumberOfStudentsByYear()
        {
            majors.ForEach(major =>
            {
                Console.WriteLine(major.Name);
                Dictionary<int, int> yearNumberOfStudentPairs = new Dictionary<int, int>();
                major.Students.ForEach(student =>
                {
                    if (!yearNumberOfStudentPairs.ContainsKey(student.StartYear))
                    {
                        yearNumberOfStudentPairs.Add(student.StartYear, 1);
                    }
                    else
                    {
                        yearNumberOfStudentPairs[student.StartYear]++;
                    }
                });
                Console.WriteLine("{0}: {1}", yearNumberOfStudentPairs.Keys, yearNumberOfStudentPairs.Values);
            });
        }

        private static void ViewSortedListByStartYear()
        {
            majors.ForEach(major =>
            {
                Console.WriteLine(major.Name);
                List<Student> sorted = major.Students.OrderBy(s => s.StartYear).ToList();
                sorted.ForEach(student =>
                {
                    student.Show();
                });
            });
        }

        private static void ViewHighestMarkOfEachSemester()
        {
            int count = 0;
            majors.ForEach(major =>
            {
                Console.WriteLine(major.Name);
                Dictionary<string, float> semesterWithHighestMark = new Dictionary<string, float>();
                major.Students.ForEach(student =>
                {
                    student.MarkReports.ForEach(markReport =>
                    {
                        if (!semesterWithHighestMark.ContainsKey(markReport.SemesterName))
                        {
                            semesterWithHighestMark.Add(markReport.SemesterName, markReport.AverageMark);
                            count++;
                        }
                        else
                        {
                            if (semesterWithHighestMark[markReport.SemesterName] < markReport.AverageMark)
                            {
                                semesterWithHighestMark[markReport.SemesterName] = markReport.AverageMark;
                            }
                        }
                    });

                });
                foreach (var item in semesterWithHighestMark)
                {
                    Console.WriteLine("Semester: {0} - Highest mark: {1}", item.Key, item.Value);
                }
            });
            if (count == 0) Console.WriteLine("No data!");
        }

        private static void ViewGoodStudent()
        {
            const float goodMark = 8;
            int count = 0;
            majors.ForEach(major =>
            {
                Console.WriteLine(major.Name);
                major.Students.ForEach(student =>
                {
                    if (student.MarkReports.LastOrDefault().AverageMark >= goodMark)
                    {
                        student.Show();
                        count++;
                    }
                });
            });
            if (count == 0) Console.WriteLine("Not found!");
        }

        private static void ViewExchangeStudent()
        {
            Console.WriteLine("Enter partner institution:");
            string partnerInstitutionEntered = Validation.CheckInputString();
            int count = 0;
            majors.ForEach(m =>
            {
                Console.WriteLine(m.Name);
                m.Students.ForEach(student =>
                {
                    if (student.GetType() == typeof(StudentExchange))
                    {
                        StudentExchange studentExchange = (StudentExchange)student;
                        if (string.Equals(studentExchange.PartnerInstitution, partnerInstitutionEntered, StringComparison.OrdinalIgnoreCase))
                        {
                            student.Show();
                            count++;
                        }
                    }
                });
            });
            if (count == 0) Console.WriteLine("Not found!");
        }

        private static void ViewHighestEntryPointOfEachMajor()
        {
            majors.ForEach(m =>
            {
                float highest = m.Students.Max(s => s.EntryPoint);
                Console.WriteLine("{0} - Highest entry point: {1}", m.Name, highest);
            });
        }

        private static void ViewTotalStudentsOfEachMajor()
        {
            majors.ForEach(m =>
            {
                Console.WriteLine("{0} - Total student: {1}", m.Name, m.Students.Count);
            });
        }

        private static void ViewAverageScore()
        {
            Console.WriteLine("Enter semester:");
            string semesterEntered = Validation.CheckInputString();
            int count = 0;
            majors.ForEach(m =>
            {
                m.Students.ForEach(s =>
                {
                    s.MarkReports.ForEach(mr =>
                    {
                        if (string.Equals(mr.SemesterName, semesterEntered, StringComparison.OrdinalIgnoreCase))
                        {
                            s.Show();
                            count++;
                        }
                    });
                });
            });
            if (count == 0)
            {
                Console.WriteLine("Not found!");
            }
        }

        private static void ViewInformation()
        {
            Console.WriteLine("Enter student ID:");
            string id = Validation.CheckInputString();
            Student student = null;
            majors.ForEach(m =>
            {
                m.Students.ForEach(s =>
                {
                    if (string.Equals(s.ID, id, StringComparison.OrdinalIgnoreCase))
                    {
                        student = s;
                    }
                });
            });
            if (student == null)
            {
                Console.WriteLine("Not found!");
                return;
            }
            student.Show();
        }

        private static void AddStudent()
        {
            switch (ChooseStudentType())
            {
                case StudentType.RegularStudent:
                    AddRegularStudent();
                    break;
                case StudentType.ExchangeStudent:
                    AddExchangeStudent();
                    break;
            }
        }
        private static Student CreateStudent()
        {
            Console.WriteLine("Enter ID:");
            string id = Validation.CheckInputString();
            Console.WriteLine("Enter name:");
            string name = Validation.CheckInputString();
            Console.WriteLine("Enter BirthDate:");
            DateTime birthDate = Validation.CheckInputDate();
            Console.WriteLine("Enter StartYear:");
            int startYear = Validation.CheckInputIntLimit(1, 3000);
            Console.WriteLine("Enter EntryPoint:");
            float entryPoint = Validation.CheckInputFloatLimit(0, 10);
            Console.WriteLine("Enter MarkReport:");
            List<MarkReport> markReports = CreateMarkReports();
            Student student = new Student(id, name, birthDate, startYear, entryPoint, markReports);
            return student;
        }
        private static List<MarkReport> CreateMarkReports()
        {
            List<MarkReport> markReports = new List<MarkReport>();
            while (true)
            {
                Console.WriteLine("Enter SemesterName:");
                string name = Validation.CheckInputString();
                Console.WriteLine("Enter AverageMark:");
                float averageMark = Validation.CheckInputFloatLimit(0, 10);
                MarkReport markReport = new MarkReport(name, averageMark);
                markReports.Add(markReport);
                Console.WriteLine("Continue?[y/n]");
                bool option = Validation.CheckInputBoolean();
                if (!option) { return markReports; }
            }
        }
        private static void AddStudentToMajor(Student student)
        {
            Console.WriteLine("Enter Major:");
            string majorName = Validation.CheckInputString();
            Major foundMajor = majors.Find(m => m.Name == majorName);
            if (foundMajor != null)
            {
                foundMajor.AddStudent(student);
                return;
            }
            Major newMajor = new Major(majorName);
            newMajor.AddStudent(student);
            majors.Add(newMajor);
            Console.WriteLine("Added!");
        }
        private static void AddRegularStudent()
        {
            Student student = CreateStudent();
            AddStudentToMajor(student);
        }

        private static void AddExchangeStudent()
        {
            Student student = CreateStudent();
            Console.WriteLine("Enter PartnerInstitution:");
            string partnerInstitution = Validation.CheckInputString();
            Student studentExchange = new StudentExchange(student.ID, student.Fullname, student.BirthDate, student.StartYear, student.EntryPoint, student.MarkReports, partnerInstitution);
            AddStudentToMajor(studentExchange);
        }
        public static void ListAll()
        {
            majors.ForEach(m => m.Students.ForEach(s => s.Show()));
        }
    }
}
