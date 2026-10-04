// Assembly: mscorlib.dll
// Namespace: System.Runtime.Serialization.Formatters.Binary
[DefaultMember("Item")]
[Serializable]
internal sealed class SizedArray : ICloneable // TypeDefIndex: 10426
{
	// Fields
	internal object[] objects; // 0x10
	internal object[] negObjects; // 0x18

	// Properties
	internal object Item { get; set; }

	// Methods

	// RVA: 0x2F1B010 Offset: 0x2F17010 VA: 0x2F1B010
	internal void .ctor() { }

	// RVA: 0x2F1B090 Offset: 0x2F17090 VA: 0x2F1B090
	internal void .ctor(int length) { }

	// RVA: 0x2F1B11C Offset: 0x2F1711C VA: 0x2F1B11C
	private void .ctor(SizedArray sizedArray) { }

	// RVA: 0x2F1B1F4 Offset: 0x2F171F4 VA: 0x2F1B1F4 Slot: 4
	public object Clone() { }

	// RVA: 0x2F1B24C Offset: 0x2F1724C VA: 0x2F1B24C
	internal object get_Item(int index) { }

	// RVA: 0x2F1B2C0 Offset: 0x2F172C0 VA: 0x2F1B2C0
	internal void set_Item(int index, object value) { }

	// RVA: 0x2F1B3C8 Offset: 0x2F173C8 VA: 0x2F1B3C8
	internal void IncreaseCapacity(int index) { }
}
