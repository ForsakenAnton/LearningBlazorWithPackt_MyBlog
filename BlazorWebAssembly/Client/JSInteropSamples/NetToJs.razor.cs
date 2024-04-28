using System.Runtime.InteropServices.JavaScript;

namespace BlazorWebAssembly.Client.JSInteropSamples;

public partial class NetToJs
{
    [JSImport("showAlert", "nettojs")]
    internal static partial string ShowAlert(string message);
}
