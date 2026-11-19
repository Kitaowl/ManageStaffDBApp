using ManageStaffDBApp.Data;
using System.Linq;

namespace ManageStaffDBApp.Model
{
    public static class DataWorker
    {
        //создать отдел
        public static string CreateDepartment(string name)
        {
            string result = "Уже существует";
            using(ApplicationContext db = new ApplicationContext())
            {
                //проверяем существует ли отдел
                bool checkIsExist = db.Departments.Any(el => el.Name == name);
                if (!checkIsExist)
                {
                    Department newDepartment = new Department { Name = name };
                    db.Departments.Add(newDepartment);
                    db.SaveChanges();
                    result = "Сделано!";
                }
                return result;
            }
        }
        //создать позицию

        public static string CreatePosition(string name, decimal salary, int MaxNumber, Department department)
        {
            string result = "Уже существует";
            using (ApplicationContext db = new ApplicationContext())
            {
                //проверяем существует ли позиция
                bool checkIsExist = db.Departments.Any(el => el.Name == name && el.Salary == salary);
                if (!checkIsExist)
                {
                    Department newDepartment = new Department 
                    { Name = name,
                        Salary = salary,
                        MaxNumber = maxNumber,
                        DepartmentId = department.Id
                    };
                    db.Departments.Add(newDepartment);
                    db.SaveChanges();
                    result = "Сделано!";
                }
                return result;
            }
        }
        //создать сотрудника


        //удаление отдела

        //удаление позиции

        //удаление сотрудника


        //редактирование отдела

        //редактирование позиции

        //редактирование сотрудника
    }
}
