// Assembly: System.dll
// Namespace: System.ComponentModel
[Usage(32767)]
public sealed class BrowsableAttribute : Attribute // TypeDefIndex: 14162
{
	// Fields
	public static readonly BrowsableAttribute Yes; // 0x0
	public static readonly BrowsableAttribute No; // 0x8
	public static readonly BrowsableAttribute Default; // 0x10
	[CompilerGenerated]
	private readonly bool <Browsable>k__BackingField; // 0x10

	// Properties
	public bool Browsable { get; }

	// Methods

	// RVA: 0x349D2DC Offset: 0x34992DC VA: 0x349D2DC
	public void .ctor(bool browsable) { }

	[CompilerGenerated]
	// RVA: 0x349D304 Offset: 0x3499304 VA: 0x349D304
	public bool get_Browsable() { }

	// RVA: 0x349D30C Offset: 0x349930C VA: 0x349D30C Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x349D3F0 Offset: 0x34993F0 VA: 0x349D3F0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x349D45C Offset: 0x349945C VA: 0x349D45C Slot: 6
	public override bool IsDefaultAttribute() { }

	// RVA: 0x349D4C4 Offset: 0x34994C4 VA: 0x349D4C4
	private static void .cctor() { }
}
