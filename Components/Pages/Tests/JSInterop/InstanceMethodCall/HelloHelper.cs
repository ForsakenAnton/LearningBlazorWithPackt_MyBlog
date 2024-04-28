
using Microsoft.JSInterop;
using System.Xml.Linq;

namespace Components.Pages.Tests.JSInterop.InstanceMethodCall;

public class HelloHelper
{
    public string Name { get; set; }

    public HelloHelper(string name)
    {
        Name = name;
    }


    [JSInvokable]
    public string SayHello()
    {
        return $"Hello, {Name}!";
    }
}