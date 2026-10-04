// Assembly: mscorlib.dll
// Namespace: System.Runtime.Serialization
internal class ObjectHolderList // TypeDefIndex: 10358
{
	// Fields
	internal ObjectHolder[] m_values; // 0x10
	internal int m_count; // 0x18

	// Properties
	internal int Version { get; }
	internal int Count { get; }

	// Methods

	// RVA: 0x2EFF11C Offset: 0x2EFB11C VA: 0x2EFF11C
	internal void .ctor() { }

	// RVA: 0x2F030DC Offset: 0x2EFF0DC VA: 0x2F030DC
	internal void .ctor(int startingSize) { }

	// RVA: 0x2F03150 Offset: 0x2EFF150 VA: 0x2F03150 Slot: 4
	internal virtual void Add(ObjectHolder value) { }

	// RVA: 0x2F02058 Offset: 0x2EFE058 VA: 0x2F02058
	internal ObjectHolderListEnumerator GetFixupEnumerator() { }

	// RVA: 0x2F031C8 Offset: 0x2EFF1C8 VA: 0x2F031C8
	private void EnlargeArray() { }

	// RVA: 0x2F032C0 Offset: 0x2EFF2C0 VA: 0x2F032C0
	internal int get_Version() { }

	// RVA: 0x2F032C8 Offset: 0x2EFF2C8 VA: 0x2F032C8
	internal int get_Count() { }
}
