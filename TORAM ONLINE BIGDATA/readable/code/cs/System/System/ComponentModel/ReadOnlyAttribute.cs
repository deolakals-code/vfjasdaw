// Assembly: System.dll
// Namespace: System.ComponentModel
[Usage(32767)]
public sealed class ReadOnlyAttribute : Attribute // TypeDefIndex: 14174
{
	// Fields
	public static readonly ReadOnlyAttribute Yes; // 0x0
	public static readonly ReadOnlyAttribute No; // 0x8
	public static readonly ReadOnlyAttribute Default; // 0x10
	[CompilerGenerated]
	private readonly bool <IsReadOnly>k__BackingField; // 0x10

	// Properties
	public bool IsReadOnly { get; }

	// Methods

	// RVA: 0x349E644 Offset: 0x349A644 VA: 0x349E644
	public void .ctor(bool isReadOnly) { }

	[CompilerGenerated]
	// RVA: 0x349E66C Offset: 0x349A66C VA: 0x349E66C
	public bool get_IsReadOnly() { }

	// RVA: 0x349E674 Offset: 0x349A674 VA: 0x349E674 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x349E758 Offset: 0x349A758 VA: 0x349E758 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x349E760 Offset: 0x349A760 VA: 0x349E760 Slot: 6
	public override bool IsDefaultAttribute() { }

	// RVA: 0x349E7E0 Offset: 0x349A7E0 VA: 0x349E7E0
	private static void .cctor() { }
}
