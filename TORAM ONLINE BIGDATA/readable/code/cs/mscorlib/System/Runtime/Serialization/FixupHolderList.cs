// Assembly: mscorlib.dll
// Namespace: System.Runtime.Serialization
[Serializable]
internal class FixupHolderList // TypeDefIndex: 10356
{
	// Fields
	internal FixupHolder[] m_values; // 0x10
	internal int m_count; // 0x18

	// Methods

	// RVA: 0x2F02D0C Offset: 0x2EFED0C VA: 0x2F02D0C
	internal void .ctor() { }

	// RVA: 0x2F02E18 Offset: 0x2EFEE18 VA: 0x2F02E18
	internal void .ctor(int startingSize) { }

	// RVA: 0x2F02E8C Offset: 0x2EFEE8C VA: 0x2F02E8C Slot: 4
	internal virtual void Add(FixupHolder fixup) { }

	// RVA: 0x2F02F38 Offset: 0x2EFEF38 VA: 0x2F02F38
	private void EnlargeArray() { }
}
