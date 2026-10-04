// Assembly: System.dll
// Namespace: System.ComponentModel
[Usage(32767)]
public sealed class RefreshPropertiesAttribute : Attribute // TypeDefIndex: 14274
{
	// Fields
	public static readonly RefreshPropertiesAttribute All; // 0x0
	public static readonly RefreshPropertiesAttribute Repaint; // 0x8
	public static readonly RefreshPropertiesAttribute Default; // 0x10
	private RefreshProperties refresh; // 0x10

	// Properties
	public RefreshProperties RefreshProperties { get; }

	// Methods

	// RVA: 0x34CED4C Offset: 0x34CAD4C VA: 0x34CED4C
	public void .ctor(RefreshProperties refresh) { }

	// RVA: 0x34CED74 Offset: 0x34CAD74 VA: 0x34CED74
	public RefreshProperties get_RefreshProperties() { }

	// RVA: 0x34CED7C Offset: 0x34CAD7C VA: 0x34CED7C Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x34CEDEC Offset: 0x34CADEC VA: 0x34CEDEC Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x34CEDF4 Offset: 0x34CADF4 VA: 0x34CEDF4 Slot: 6
	public override bool IsDefaultAttribute() { }

	// RVA: 0x34CEE5C Offset: 0x34CAE5C VA: 0x34CEE5C
	private static void .cctor() { }
}
