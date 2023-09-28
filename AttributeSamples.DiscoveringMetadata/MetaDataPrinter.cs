using AttributeSamples.CustomAttributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AttributeSamples.DiscoveringMetadata;

public class MetaDataPrinter
{
    private readonly Type type;

    public MetaDataPrinter(Type type)
    {
        this.type = type;
    }
    public void Print()
    {
        PrintMainInfo(); 
        PrintMethodInfo();
        PrintPropertyInfo();
        printFieldInfo();
        PrintCodeChangeHistory();
    }

    private void printFieldInfo()
    {
        Console.WriteLine($"***************** Field Information of type {type.Name} *******************");
        var feildInfos = type.GetFields();
        foreach (var feildInfo in feildInfos)
        {
            Console.WriteLine($"{feildInfo.Name}, {feildInfo.FieldType}");
        }
    }

    private void PrintPropertyInfo()
    {
        Console.WriteLine($"***************** Properties Information of type {type.Name} *******************");
        var propertyInfos = type.GetProperties();
        foreach ( var propertyInfo in propertyInfos )
        {
            Console.WriteLine($"{propertyInfo.Name}, {propertyInfo.PropertyType}");
        }

    }

    private void PrintMethodInfo()
    {
        Console.WriteLine($"***************** Method Information of type {type.Name} *******************");
        var methodInfo = type.GetMethods();
        foreach ( var method in methodInfo )
        {
            Console.Write($"{method.Name} (");
            var parameters = method.GetParameters();
            foreach ( var param in parameters )
            {
                Console.Write($"{param.ParameterType}, {param.Name}");
            }
            Console.WriteLine(")");
        }

    }

    private void PrintCodeChangeHistory()
    {
        Console.WriteLine($"***************** Change history of  {type.Name} *******************");
        var attributes = type.GetCustomAttributes(typeof(CodeChangeHistoryAttribute));
        foreach (CodeChangeHistoryAttribute attribute in attributes )
        {
            Console.WriteLine($"Change date  time : {attribute.ChangeDateTime} \t\t Is bug fixed: {attribute.IsBug} \t\t {attribute.Description}");
        }

    }
    private void PrintMainInfo()
    {
        Console.WriteLine($"***************** Information of type {type.Name} *******************");
        Console.WriteLine($"FullName: {type.FullName}");
        Console.WriteLine($"AssemblyQualifiedName :{type.AssemblyQualifiedName}");
        Console.WriteLine($"IsAbstract :{type.IsAbstract}");
    }
}
