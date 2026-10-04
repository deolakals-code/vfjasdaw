// Assembly: System.Data.dll
// Namespace: System.Data
[IsReadOnly]
internal struct IndexField // TypeDefIndex: 14767
{
	// Fields
	public readonly DataColumn Column; // 0x0
	public readonly bool IsDescending; // 0x8

	// Methods

	// RVA: 0x320EDE0 Offset: 0x320ADE0 VA: 0x320EDE0
	internal void .ctor(DataColumn column, bool isDescending) { }

	// RVA: 0x320EE08 Offset: 0x320AE08 VA: 0x320EE08
	public static bool op_Equality(IndexField if1, IndexField if2) { }

	// RVA: 0x320EE24 Offset: 0x320AE24 VA: 0x320EE24 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x320EEB4 Offset: 0x320AEB4 VA: 0x320EEB4 Slot: 2
	public override int GetHashCode() { }
}
