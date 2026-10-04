// Assembly: System.dll
// Namespace: System.ComponentModel
public class ListChangedEventArgs : EventArgs // TypeDefIndex: 14216
{
	// Fields
	[CompilerGenerated]
	private readonly ListChangedType <ListChangedType>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly int <NewIndex>k__BackingField; // 0x14
	[CompilerGenerated]
	private readonly int <OldIndex>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly PropertyDescriptor <PropertyDescriptor>k__BackingField; // 0x20

	// Properties
	public ListChangedType ListChangedType { get; }
	public int NewIndex { get; }
	public int OldIndex { get; }

	// Methods

	// RVA: 0x34AC2D8 Offset: 0x34A82D8 VA: 0x34AC2D8
	public void .ctor(ListChangedType listChangedType, int newIndex) { }

	// RVA: 0x34AC360 Offset: 0x34A8360 VA: 0x34AC360
	public void .ctor(ListChangedType listChangedType, int newIndex, PropertyDescriptor propDesc) { }

	// RVA: 0x34AC39C Offset: 0x34A839C VA: 0x34AC39C
	public void .ctor(ListChangedType listChangedType, PropertyDescriptor propDesc) { }

	// RVA: 0x34AC2E0 Offset: 0x34A82E0 VA: 0x34AC2E0
	public void .ctor(ListChangedType listChangedType, int newIndex, int oldIndex) { }

	[CompilerGenerated]
	// RVA: 0x34AC418 Offset: 0x34A8418 VA: 0x34AC418
	public ListChangedType get_ListChangedType() { }

	[CompilerGenerated]
	// RVA: 0x34AC420 Offset: 0x34A8420 VA: 0x34AC420
	public int get_NewIndex() { }

	[CompilerGenerated]
	// RVA: 0x34AC428 Offset: 0x34A8428 VA: 0x34AC428
	public int get_OldIndex() { }
}
