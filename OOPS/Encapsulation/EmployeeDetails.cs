public class EmployeeDetails
{
    private string _employeeName;
    public string EmployeeName
    {
        set => _employeeName = value;
        get => _employeeName;
    }

    private float _employeeSalary;
    public float EmployeeSalary
    {
        set => _employeeSalary = value;
        get => _employeeSalary;
    }

}