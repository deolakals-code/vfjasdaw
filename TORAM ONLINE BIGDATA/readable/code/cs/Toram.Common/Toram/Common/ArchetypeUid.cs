// Assembly: Toram.Common.dll
// Namespace: Toram.Common
public struct ArchetypeUid : IComparable, IComparable<ArchetypeUid>, IEquatable<ArchetypeUid> // TypeDefIndex: 11059
{
	// Fields
	private long _uid; // 0x0

	// Properties
	public long Uid { get; }
	public int Id { get; }
	public byte Type { get; }
	public bool IsZero { get; }

	// Methods

	// RVA: 0x35B1A34 Offset: 0x35ADA34 VA: 0x35B1A34
	public void .ctor(byte type, int id) { }

	// RVA: 0x35B1A48 Offset: 0x35ADA48 VA: 0x35B1A48
	public void .ctor(long uid) { }

	// RVA: 0x35B1A50 Offset: 0x35ADA50 VA: 0x35B1A50
	public long get_Uid() { }

	// RVA: 0x35B1A58 Offset: 0x35ADA58 VA: 0x35B1A58
	public int get_Id() { }

	// RVA: 0x35B1A60 Offset: 0x35ADA60 VA: 0x35B1A60
	public byte get_Type() { }

	// RVA: 0x35B1A68 Offset: 0x35ADA68 VA: 0x35B1A68
	public bool get_IsZero() { }

	// RVA: 0x35B1A78 Offset: 0x35ADA78 VA: 0x35B1A78
	public bool IsArchetype(byte type, int id) { }

	// RVA: 0x35B1A98 Offset: 0x35ADA98 VA: 0x35B1A98
	public bool IsArchetype(ArchetypeUid archetypeUid) { }

	// RVA: 0x35B1ABC Offset: 0x35ADABC VA: 0x35B1ABC Slot: 4
	public int CompareTo(object obj) { }

	// RVA: 0x35B1BA8 Offset: 0x35ADBA8 VA: 0x35B1BA8 Slot: 5
	public int CompareTo(ArchetypeUid value) { }

	// RVA: 0x35B1BC4 Offset: 0x35ADBC4 VA: 0x35B1BC4 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x35B1C50 Offset: 0x35ADC50 VA: 0x35B1C50 Slot: 6
	public bool Equals(ArchetypeUid other) { }

	// RVA: 0x35B1C74 Offset: 0x35ADC74 VA: 0x35B1C74
	public bool Equals(byte archetypeType, int archetypeId) { }

	// RVA: 0x35B1C94 Offset: 0x35ADC94 VA: 0x35B1C94 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x35B1C9C Offset: 0x35ADC9C VA: 0x35B1C9C Slot: 3
	public override string ToString() { }

	// RVA: 0x35B1D58 Offset: 0x35ADD58 VA: 0x35B1D58
	public static bool op_Equality(ArchetypeUid a, ArchetypeUid b) { }
}
