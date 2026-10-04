// Assembly: mscorlib.dll
// Namespace: System.Runtime.Serialization.Formatters.Binary
[DefaultMember("Item")]
[Serializable]
internal sealed class IntSizedArray : ICloneable // TypeDefIndex: 10427
{
	// Fields
	internal int[] objects; // 0x10
	internal int[] negObjects; // 0x18

	// Properties
	internal int Item { get; set; }

	// Methods

	// RVA: 0x2F1B604 Offset: 0x2F17604 VA: 0x2F1B604
	public void .ctor() { }

	// RVA: 0x2F1B684 Offset: 0x2F17684 VA: 0x2F1B684
	private void .ctor(IntSizedArray sizedArray) { }

	// RVA: 0x2F1B798 Offset: 0x2F17798 VA: 0x2F1B798 Slot: 4
	public object Clone() { }

	// RVA: 0x2F1B7F0 Offset: 0x2F177F0 VA: 0x2F1B7F0
	internal int get_Item(int index) { }

	// RVA: 0x2F1B868 Offset: 0x2F17868 VA: 0x2F1B868
	internal void set_Item(int index, int value) { }

	// RVA: 0x2F1B920 Offset: 0x2F17920 VA: 0x2F1B920
	internal void IncreaseCapacity(int index) { }
}
