// Assembly: System.Runtime.Serialization.dll
// Namespace: System.Runtime.Serialization
[Usage(384, Inherited = False, AllowMultiple = False)]
public sealed class DataMemberAttribute : Attribute // TypeDefIndex: 17933
{
	// Fields
	private string name; // 0x10
	private int order; // 0x18
	private bool isRequired; // 0x1C
	private bool emitDefaultValue; // 0x1D

	// Properties
	public string Name { get; }
	public int Order { get; }
	public bool IsRequired { get; }
	public bool EmitDefaultValue { get; }

	// Methods

	// RVA: 0x32AA394 Offset: 0x32A6394 VA: 0x32AA394
	public string get_Name() { }

	// RVA: 0x32AA39C Offset: 0x32A639C VA: 0x32AA39C
	public int get_Order() { }

	// RVA: 0x32AA3A4 Offset: 0x32A63A4 VA: 0x32AA3A4
	public bool get_IsRequired() { }

	// RVA: 0x32AA3AC Offset: 0x32A63AC VA: 0x32AA3AC
	public bool get_EmitDefaultValue() { }
}
