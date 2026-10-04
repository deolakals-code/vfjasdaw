// Assembly: System.dll
// Namespace: System.ComponentModel
[Usage(32767)]
public sealed class ListBindableAttribute : Attribute // TypeDefIndex: 14215
{
	// Fields
	public static readonly ListBindableAttribute Yes; // 0x0
	public static readonly ListBindableAttribute No; // 0x8
	public static readonly ListBindableAttribute Default; // 0x10
	private bool _isDefault; // 0x10
	[CompilerGenerated]
	private readonly bool <ListBindable>k__BackingField; // 0x11

	// Properties
	public bool ListBindable { get; }

	// Methods

	// RVA: 0x34AC0D4 Offset: 0x34A80D4 VA: 0x34AC0D4
	public void .ctor(bool listBindable) { }

	[CompilerGenerated]
	// RVA: 0x34AC0FC Offset: 0x34A80FC VA: 0x34AC0FC
	public bool get_ListBindable() { }

	// RVA: 0x34AC104 Offset: 0x34A8104 VA: 0x34AC104 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x34AC19C Offset: 0x34A819C VA: 0x34AC19C Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x34AC1A4 Offset: 0x34A81A4 VA: 0x34AC1A4 Slot: 6
	public override bool IsDefaultAttribute() { }

	// RVA: 0x34AC228 Offset: 0x34A8228 VA: 0x34AC228
	private static void .cctor() { }
}
