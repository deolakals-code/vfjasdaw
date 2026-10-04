// Assembly: System.dll
// Namespace: System.ComponentModel
[Usage(4, AllowMultiple = False, Inherited = True)]
public sealed class DesignerCategoryAttribute : Attribute // TypeDefIndex: 14165
{
	// Fields
	public static readonly DesignerCategoryAttribute Component; // 0x0
	public static readonly DesignerCategoryAttribute Default; // 0x8
	public static readonly DesignerCategoryAttribute Form; // 0x10
	public static readonly DesignerCategoryAttribute Generic; // 0x18
	[CompilerGenerated]
	private readonly string <Category>k__BackingField; // 0x10

	// Properties
	public string Category { get; }
	public override object TypeId { get; }

	// Methods

	// RVA: 0x349DD98 Offset: 0x3499D98 VA: 0x349DD98
	public void .ctor() { }

	// RVA: 0x349DDF8 Offset: 0x3499DF8 VA: 0x349DDF8
	public void .ctor(string category) { }

	[CompilerGenerated]
	// RVA: 0x349DE28 Offset: 0x3499E28 VA: 0x349DE28
	public string get_Category() { }

	// RVA: 0x349DE30 Offset: 0x3499E30 VA: 0x349DE30 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x349DEC0 Offset: 0x3499EC0 VA: 0x349DEC0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x349DEE0 Offset: 0x3499EE0 VA: 0x349DEE0 Slot: 6
	public override bool IsDefaultAttribute() { }

	// RVA: 0x349DF58 Offset: 0x3499F58 VA: 0x349DF58 Slot: 4
	public override object get_TypeId() { }

	// RVA: 0x349DF90 Offset: 0x3499F90 VA: 0x349DF90
	private static void .cctor() { }
}
