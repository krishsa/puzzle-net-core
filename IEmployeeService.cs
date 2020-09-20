interface IIEmployeeService
{
    static int retirementAge = 60;

    string getName();

    int getRetirementAge()
    {
        return retirementAge;
    }
}