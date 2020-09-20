class Domain

{
    private string name; // Field, Variable, Member Variable, Property, Instance variable
    private static string office; // static variable, class variable

    public void setName(string name) // Function, Method, member function
    {
        this.name = name;
    }

    public string getName()
    {
        return this.name;
    }

    public string age { get; set; }

}