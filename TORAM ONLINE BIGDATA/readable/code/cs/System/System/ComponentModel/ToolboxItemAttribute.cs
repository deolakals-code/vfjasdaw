// Assembly: System.dll
// Namespace: System.ComponentModel
[Usage(32767)]
public class ToolboxItemAttribute : Attribute // TypeDefIndex: 14197
{
	// Fields
	private string _toolboxItemTypeName; // 0x10
	public static readonly ToolboxItemAttribute Default; // 0x0
	public static readonly ToolboxItemAttribute None; // 0x8

	// Properties
	public string ToolboxItemTypeName { get; }

	// Methods

	// RVA: 0x34A7CD0 Offset: 0x34A3CD0 VA: 0x34A7CD0 Slot: 6
	public override bool IsDefaultAttribute() { }

	// RVA: 0x34A7D38 Offset: 0x34A3D38 VA: 0x34A7D38
	public void .ctor(bool defaultType) { }

	// RVA: 0x34A7DA4 Offset: 0x34A3DA4 VA: 0x34A7DA4
	public void .ctor(string toolboxItemTypeName) { }

	// RVA: 0x34A7E38 Offset: 0x34A3E38 VA: 0x34A7E38
	public string get_ToolboxItemTypeName() { }

	// RVA: 0x34A7E8C Offset: 0x34A3E8C VA: 0x34A7E8C Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x34A7F88 Offset: 0x34A3F88 VA: 0x34A7F88 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x34A7FAC Offset: 0x34A3FAC VA: 0x34A7FAC
	private static void .cctor() { }
}
