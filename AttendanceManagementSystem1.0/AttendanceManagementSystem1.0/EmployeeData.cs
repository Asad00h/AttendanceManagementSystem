using System;
using System.Collections.Generic;
using System.Linq;

namespace AttendanceManagementSystem
{
    public static class EmployeeData
    {
        public static List<Employee> Employees { get; } = new List<Employee>
        {
            new Employee(1, "Asad"),
            new Employee(02, "Asad2"),
            new Employee(03, "Asad3"),
            new Employee(04, "Asad4"),
            new Employee(05, "Akash"),
            new Employee(06, "Omi"),
            new Employee(07, "Wudi"),
            new Employee(08, "Marua"),
            new Employee(09, "Marua2"),
            new Employee(10, "Marua3")
        };

        public static void EndOfDayCheck()
        {
            var startTime = new TimeSpan(8, 0, 0);
            var endTime = new TimeSpan(17, 30, 0);

            foreach (var employee in Employees)
            {
                if (employee.Absenteeism == 1 && employee.CheckInTime.HasValue && employee.CheckOutTime.HasValue)
                {
                    continue;
                }

                if (!employee.CheckInTime.HasValue && !employee.CheckOutTime.HasValue)
                {
                    employee.SetAbsenteeism(1);
                }
                else if (employee.CheckInTime.HasValue && employee.CheckOutTime.HasValue)
                {
                    employee.SetAbsenteeism(0);
                    employee.Tardiness = employee.CheckInTime.Value.TimeOfDay > startTime ? 1 : 0;
                    employee.EarlyDepartures = employee.CheckOutTime.Value.TimeOfDay < endTime ? 1 : 0;
                }
            }
        }
    }
}
