using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex15
{
    internal class Manager
    {

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
            ViewNumberOfStudentByYear,
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
                    case MenuOption.ViewNumberOfStudentByYear:
                        ViewNumberOfStudentByYear();
                        break;
                    case MenuOption.Exit:
                        return;
                }
            }
        }
        public static void ListAll() { }
        private static void ViewNumberOfStudentByYear()
        {
            throw new NotImplementedException();
        }

        private static void ViewSortedListByStartYear()
        {
            throw new NotImplementedException();
        }

        private static void ViewHighestMarkOfEachSemester()
        {
            throw new NotImplementedException();
        }

        private static void ViewGoodStudent()
        {
            throw new NotImplementedException();
        }

        private static void ViewExchangeStudent()
        {
            throw new NotImplementedException();
        }

        private static void ViewHighestEntryPointOfEachMajor()
        {
            throw new NotImplementedException();
        }

        private static void ViewTotalStudentsOfEachMajor()
        {
            throw new NotImplementedException();
        }

        private static void ViewAverageScore()
        {
            throw new NotImplementedException();
        }

        private static void ViewInformation()
        {
            throw new NotImplementedException();
        }

        private static void AddStudent()
        {
            throw new NotImplementedException();
        }


    }
}
