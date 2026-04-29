class Employee
{
    public int id { get; set; }
    public string name { get; set; }
    public string deparment { get; set; }


    public override bool Equals(object obj)
    {
        if (obj == null || !(obj is Employee) )
            return false;

        var emp = obj as Employee;

        return this.id == emp.id
            && this.name == emp.name
            && this.deparment == emp.deparment;
    }
    public override int GetHashCode()
    {
        int hash = 13;
        hash = (hash * 7) + id.GetHashCode();
        hash = (hash * 7) + name.GetHashCode();
        hash = (hash * 7) + deparment.GetHashCode();
        return hash;
    }
    //public static bool operator ==(Employee a, Employee b) => a.Equals(b);
    //public static bool operator !=(Employee a, Employee b) => !a.Equals(b);
}
