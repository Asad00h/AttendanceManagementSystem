using System;

public class Class1
{
	public Class1()
	{
		 // List to hold all employees
        public static List<Employee> Employees { get; } = new List<Employee>
                        {
                            new Employee(01, "Asad"),
                            new Employee(02, "Asad2"),
                            new Employee(03, "Asad3"),
                            new Employee(04, "Asad4"),
                            new Employee(05, "Wudi"),
                            new Employee(06, "Marua"),
                            new Employee(07, "Marua2"),
                            new Employee(08, "Marua3"),
                            new Employee(09, "Marua4"),
                            new Employee(10, "Rana")
                        };

    // Method to perform the end-of-day absenteeism check
    public static void EndOfDayCheck()
    {
        var startTime = new TimeSpan(8, 0, 0);    // 8:00 AM
        var endTime = new TimeSpan(17, 30, 0);    // 5:30 PM

        foreach (var employee in EmployeeData.Employees)
        {
            // Skip if Absenteeism was manually set in ModifyAttendanceForm
            if (employee.Absenteeism == 1 && employee.CheckInTime.HasValue && employee.CheckOutTime.HasValue)
            {
                Console.WriteLine($"{employee.Name}'s Absenteeism status manually set to 'Absent'. Skipping automatic check.");
                continue;
            }

            // Automatic checks
            if (!employee.CheckInTime.HasValue && !employee.CheckOutTime.HasValue)
            {
                employee.SetAbsenteeism(1);  // Mark as absent if no check-in/out
                Console.WriteLine($"{employee.Name} marked as Absent.");
            }
            else if (employee.CheckInTime.HasValue && employee.CheckOutTime.HasValue)
            {
                employee.SetAbsenteeism(0);  // Mark as present if check-in/out exists
                employee.Tardiness = employee.CheckInTime.Value.TimeOfDay > startTime ? 1 : 0;
                employee.EarlyDepartures = employee.CheckOutTime.Value.TimeOfDay < endTime ? 1 : 0;

                Console.WriteLine($"{employee.Name} attendance updated: Tardiness = {employee.Tardiness}, Early Departure = {employee.EarlyDepartures}");
            }
        }
    }

}

}
