// Assembly: mscorlib.dll
// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class TypeInformation // TypeDefIndex: 10418
{
	// Fields
	private string fullTypeName; // 0x10
	private string assemblyString; // 0x18
	private bool hasTypeForwardedFrom; // 0x20

	// Properties
	internal string FullTypeName { get; }
	internal string AssemblyString { get; }
	internal bool HasTypeForwardedFrom { get; }

	// Methods

	// RVA: 0x2F125A4 Offset: 0x2F0E5A4 VA: 0x2F125A4
	internal string get_FullTypeName() { }

	// RVA: 0x2F125AC Offset: 0x2F0E5AC VA: 0x2F125AC
	internal string get_AssemblyString() { }

	// RVA: 0x2F125B4 Offset: 0x2F0E5B4 VA: 0x2F125B4
	internal bool get_HasTypeForwardedFrom() { }

	// RVA: 0x2F0E288 Offset: 0x2F0A288 VA: 0x2F0E288
	internal void .ctor(string fullTypeName, string assemblyString, bool hasTypeForwardedFrom) { }
}
