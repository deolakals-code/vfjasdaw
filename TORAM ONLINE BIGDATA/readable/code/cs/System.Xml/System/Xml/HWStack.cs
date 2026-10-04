// Assembly: System.Xml.dll
// Namespace: System.Xml
[DefaultMember("Item")]
internal class HWStack : ICloneable // TypeDefIndex: 13424
{
	// Fields
	private object[] stack; // 0x10
	private int growthRate; // 0x18
	private int used; // 0x1C
	private int size; // 0x20
	private int limit; // 0x24

	// Properties
	internal object Item { get; set; }
	internal int Length { get; }

	// Methods

	// RVA: 0x33C911C Offset: 0x33C511C VA: 0x33C911C
	internal void .ctor(int GrowthRate) { }

	// RVA: 0x33C9124 Offset: 0x33C5124 VA: 0x33C9124
	internal void .ctor(int GrowthRate, int limit) { }

	// RVA: 0x33C91A4 Offset: 0x33C51A4 VA: 0x33C91A4
	internal object Push() { }

	// RVA: 0x33C92E4 Offset: 0x33C52E4 VA: 0x33C92E4
	internal object Pop() { }

	// RVA: 0x33C932C Offset: 0x33C532C VA: 0x33C932C
	internal object Peek() { }

	// RVA: 0x33C9370 Offset: 0x33C5370 VA: 0x33C9370
	internal void AddToTop(object o) { }

	// RVA: 0x33C93EC Offset: 0x33C53EC VA: 0x33C93EC
	internal object get_Item(int index) { }

	// RVA: 0x33C9460 Offset: 0x33C5460 VA: 0x33C9460
	internal void set_Item(int index, object value) { }

	// RVA: 0x33C950C Offset: 0x33C550C VA: 0x33C950C
	internal int get_Length() { }

	// RVA: 0x33C9514 Offset: 0x33C5514 VA: 0x33C9514
	private void .ctor(object[] stack, int growthRate, int used, int size) { }

	// RVA: 0x33C9564 Offset: 0x33C5564 VA: 0x33C9564 Slot: 4
	public object Clone() { }
}
