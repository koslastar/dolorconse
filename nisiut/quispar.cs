using System;
using System.Xml;

public class Employee
{
    public decimal Salary { get; set; }
    // Other properties
}

public class XmlSerializerExample
{
    public void SerializeEmployeeSalary(Employee employee)
    {
        using (XmlWriter writer = XmlWriter.Create("employee.xml"))
        {
            writer.WriteStartDocument();
            writer.WriteStartElement("Employee");
            
            writer.WriteElementString("Salary", employee.Salary.ToString());

            // Serialize other properties if needed

            writer.WriteEndElement();
            writer.WriteEndDocument();
        }
    }
}
