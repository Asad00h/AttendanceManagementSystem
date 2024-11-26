using System;

namespace AttendanceManagementSystem
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public DateTime? CheckInTime { get; set; }
        public DateTime? CheckOutTime { get; set; }
        public int Tardiness { get; set; }
        public int EarlyDepartures { get; set; }
        public int Absenteeism { get; private set; }

        private readonly TimeSpan _startTime = new TimeSpan(8, 0, 0);
        private readonly TimeSpan _endTime = new TimeSpan(17, 30, 0);

        public Employee(int employeeID, string employeename)
        {
            EmployeeID = employeeID;
            EmployeeName = employeename;
            CheckInTime = null;
            CheckOutTime = null;
            Tardiness = 0;
            EarlyDepartures = 0;
            Absenteeism = 0;
        }

        public void CheckIn(DateTime now)
        {
            CheckInTime = now;
            Tardiness = CheckInTime.Value.TimeOfDay > _startTime ? 1 : 0;
        }

        public void CheckOut()
        {
            CheckOutTime = DateTime.Now;
            EarlyDepartures = CheckOutTime.Value.TimeOfDay < _endTime ? 1 : 0;
        }

        public void SetAbsenteeism(int value)
        {
            Absenteeism = value;
        }
    }
}
