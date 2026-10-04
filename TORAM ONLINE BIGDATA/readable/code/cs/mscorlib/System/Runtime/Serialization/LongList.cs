// Assembly: mscorlib.dll
// Namespace: System.Runtime.Serialization
[Serializable]
internal class LongList // TypeDefIndex: 10357
{
	// Fields
	private long[] m_values; // 0x10
	private int m_count; // 0x18
	private int m_totalItems; // 0x1C
	private int m_currentItem; // 0x20

	// Properties
	internal int Count { get; }
	internal long Current { get; }

	// Methods

	// RVA: 0x2F02D2C Offset: 0x2EFED2C VA: 0x2F02D2C
	internal void .ctor() { }

	// RVA: 0x2F02FCC Offset: 0x2EFEFCC VA: 0x2F02FCC
	internal void .ctor(int startingSize) { }

	// RVA: 0x2F02D34 Offset: 0x2EFED34 VA: 0x2F02D34
	internal void Add(long value) { }

	// RVA: 0x2F030D4 Offset: 0x2EFF0D4 VA: 0x2F030D4
	internal int get_Count() { }

	// RVA: 0x2F00EE4 Offset: 0x2EFCEE4 VA: 0x2F00EE4
	internal void StartEnumeration() { }

	// RVA: 0x2F00F30 Offset: 0x2EFCF30 VA: 0x2F00F30
	internal bool MoveNext() { }

	// RVA: 0x2F00EF0 Offset: 0x2EFCEF0 VA: 0x2F00EF0
	internal long get_Current() { }

	// RVA: 0x2F02C80 Offset: 0x2EFEC80 VA: 0x2F02C80
	internal bool RemoveElement(long value) { }

	// RVA: 0x2F03040 Offset: 0x2EFF040 VA: 0x2F03040
	private void EnlargeArray() { }
}
