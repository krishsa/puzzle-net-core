class EmployeeService : IIEmployeeService
{
    public string getName()
    {

        return "SPSA";
    }

    public int getRetirementAge()
    {
        IIEmployeeService.retirementAge = 30;
        return IIEmployeeService.retirementAge;
    }
}