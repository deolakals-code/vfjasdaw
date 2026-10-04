// Assembly: mscorlib.dll
// Namespace: System.Runtime.Versioning
[Usage(1, AllowMultiple = False, Inherited = False)]
public sealed class TargetFrameworkAttribute : Attribute // TypeDefIndex: 10328
{
	// Fields
	private string _frameworkName; // 0x10
	private string _frameworkDisplayName; // 0x18

	// Properties
	public string FrameworkDisplayName { set; }

	// Methods

	// RVA: 0x2EFA778 Offset: 0x2EF6778 VA: 0x2EFA778
	public void .ctor(string frameworkName) { }

	// RVA: 0x2EFA7F4 Offset: 0x2EF67F4 VA: 0x2EFA7F4
	public void set_FrameworkDisplayName(string value) { }
}
