// Assembly: System.dll
// Namespace: System.ComponentModel
[Usage(32767)]
public sealed class DesignOnlyAttribute : Attribute // TypeDefIndex: 14164
{
	// Fields
	[CompilerGenerated]
	private readonly bool <IsDesignOnly>k__BackingField; // 0x10
	public static readonly DesignOnlyAttribute Yes; // 0x0
	public static readonly DesignOnlyAttribute No; // 0x8
	public static readonly DesignOnlyAttribute Default; // 0x10

	// Properties
	public bool IsDesignOnly { get; }

	// Methods

	// RVA: 0x349DAE8 Offset: 0x3499AE8 VA: 0x349DAE8
	public void .ctor(bool isDesignOnly) { }

	[CompilerGenerated]
	// RVA: 0x349DB10 Offset: 0x3499B10 VA: 0x349DB10
	public bool get_IsDesignOnly() { }

	// RVA: 0x349DB18 Offset: 0x3499B18 VA: 0x349DB18 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x349DBFC Offset: 0x3499BFC VA: 0x349DBFC Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x349DC68 Offset: 0x3499C68 VA: 0x349DC68 Slot: 6
	public override bool IsDefaultAttribute() { }

	// RVA: 0x349DCE8 Offset: 0x3499CE8 VA: 0x349DCE8
	private static void .cctor() { }
}
