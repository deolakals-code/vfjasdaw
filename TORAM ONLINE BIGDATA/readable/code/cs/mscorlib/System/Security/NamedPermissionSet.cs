// Assembly: mscorlib.dll
// Namespace: System.Security
[ComVisible(True)]
[Serializable]
public sealed class NamedPermissionSet : PermissionSet // TypeDefIndex: 10070
{
	// Fields
	private string name; // 0x30
	private string description; // 0x38

	// Properties
	public string Name { get; set; }

	// Methods

	// RVA: 0x2EA2DCC Offset: 0x2E9EDCC VA: 0x2EA2DCC
	internal void .ctor() { }

	// RVA: 0x2EA2E8C Offset: 0x2E9EE8C VA: 0x2EA2E8C
	public void .ctor(string name, PermissionState state) { }

	// RVA: 0x2EA2FFC Offset: 0x2E9EFFC VA: 0x2EA2FFC
	public void .ctor(string name) { }

	// RVA: 0x2EA3004 Offset: 0x2E9F004 VA: 0x2EA3004
	public string get_Name() { }

	// RVA: 0x2EA2F3C Offset: 0x2E9EF3C VA: 0x2EA2F3C
	public void set_Name(string value) { }

	// RVA: 0x2EA300C Offset: 0x2E9F00C VA: 0x2EA300C Slot: 13
	public override SecurityElement ToXml() { }

	[ComVisible(False)]
	// RVA: 0x2EA34FC Offset: 0x2E9F4FC VA: 0x2EA34FC Slot: 0
	public override bool Equals(object obj) { }

	[ComVisible(False)]
	// RVA: 0x2EA3728 Offset: 0x2E9F728 VA: 0x2EA3728 Slot: 2
	public override int GetHashCode() { }
}
