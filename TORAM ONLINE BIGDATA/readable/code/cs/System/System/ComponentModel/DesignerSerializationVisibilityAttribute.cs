// Assembly: System.dll
// Namespace: System.ComponentModel
[Usage(960)]
public sealed class DesignerSerializationVisibilityAttribute : Attribute // TypeDefIndex: 14167
{
	// Fields
	public static readonly DesignerSerializationVisibilityAttribute Content; // 0x0
	public static readonly DesignerSerializationVisibilityAttribute Hidden; // 0x8
	public static readonly DesignerSerializationVisibilityAttribute Visible; // 0x10
	public static readonly DesignerSerializationVisibilityAttribute Default; // 0x18
	[CompilerGenerated]
	private readonly DesignerSerializationVisibility <Visibility>k__BackingField; // 0x10

	// Properties
	public DesignerSerializationVisibility Visibility { get; }

	// Methods

	// RVA: 0x349E0EC Offset: 0x349A0EC VA: 0x349E0EC
	public void .ctor(DesignerSerializationVisibility visibility) { }

	[CompilerGenerated]
	// RVA: 0x349E114 Offset: 0x349A114 VA: 0x349E114
	public DesignerSerializationVisibility get_Visibility() { }

	// RVA: 0x349E11C Offset: 0x349A11C VA: 0x349E11C Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x349E1F4 Offset: 0x349A1F4 VA: 0x349E1F4 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x349E1FC Offset: 0x349A1FC VA: 0x349E1FC Slot: 6
	public override bool IsDefaultAttribute() { }

	// RVA: 0x349E264 Offset: 0x349A264 VA: 0x349E264
	private static void .cctor() { }
}
