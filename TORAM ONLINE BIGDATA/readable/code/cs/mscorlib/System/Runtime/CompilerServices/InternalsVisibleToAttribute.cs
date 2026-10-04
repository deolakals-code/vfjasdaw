// Assembly: mscorlib.dll
// Namespace: System.Runtime.CompilerServices
[Usage(1, AllowMultiple = True, Inherited = False)]
public sealed class InternalsVisibleToAttribute : Attribute // TypeDefIndex: 10539
{
	// Fields
	private string _assemblyName; // 0x10
	private bool _allInternalsVisible; // 0x18

	// Properties
	public bool AllInternalsVisible { set; }

	// Methods

	// RVA: 0x2F22708 Offset: 0x2F1E708 VA: 0x2F22708
	public void .ctor(string assemblyName) { }

	// RVA: 0x2F22740 Offset: 0x2F1E740 VA: 0x2F22740
	public void set_AllInternalsVisible(bool value) { }
}
