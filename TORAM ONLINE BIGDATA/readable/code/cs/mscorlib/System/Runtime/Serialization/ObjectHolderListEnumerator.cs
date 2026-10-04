// Assembly: mscorlib.dll
// Namespace: System.Runtime.Serialization
internal class ObjectHolderListEnumerator // TypeDefIndex: 10359
{
	// Fields
	private bool m_isFixupEnumerator; // 0x10
	private ObjectHolderList m_list; // 0x18
	private int m_startingVersion; // 0x20
	private int m_currPos; // 0x24

	// Properties
	internal ObjectHolder Current { get; }

	// Methods

	// RVA: 0x2F0325C Offset: 0x2EFF25C VA: 0x2F0325C
	internal void .ctor(ObjectHolderList list, bool isFixupEnumerator) { }

	// RVA: 0x2F0210C Offset: 0x2EFE10C VA: 0x2F0210C
	internal bool MoveNext() { }

	// RVA: 0x2F020B4 Offset: 0x2EFE0B4 VA: 0x2F020B4
	internal ObjectHolder get_Current() { }
}
