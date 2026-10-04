// Assembly: Assembly-CSharp.dll
// Namespace: 
public class CacheArchetypeUid : IUserArchetype // TypeDefIndex: 1544
{
	// Fields
	private ArchetypeUid archetypeUid; // 0x10
	private byte regionCode; // 0x18
	private string name; // 0x20
	private bool isGMEventPlayer; // 0x28

	// Properties
	public ArchetypeUid ArchetypeUid { get; }
	public bool IsAvatarArchetype { get; }
	public string UserName { get; }
	public bool IsGMEventPlayer { get; }
	public byte RegionCode { get; }

	// Methods

	// RVA: 0x2088E00 Offset: 0x2084E00 VA: 0x2088E00 Slot: 5
	public ArchetypeUid get_ArchetypeUid() { }

	// RVA: 0x2088E08 Offset: 0x2084E08 VA: 0x2088E08 Slot: 4
	public bool get_IsAvatarArchetype() { }

	// RVA: 0x2088E4C Offset: 0x2084E4C VA: 0x2088E4C Slot: 6
	public string get_UserName() { }

	// RVA: 0x2088E54 Offset: 0x2084E54 VA: 0x2088E54 Slot: 7
	public bool get_IsGMEventPlayer() { }

	// RVA: 0x2088E5C Offset: 0x2084E5C VA: 0x2088E5C Slot: 8
	public byte get_RegionCode() { }

	// RVA: 0x2088E64 Offset: 0x2084E64 VA: 0x2088E64
	public void .ctor(byte type, int id, string userName) { }

	// RVA: 0x2088E6C Offset: 0x2084E6C VA: 0x2088E6C
	public void .ctor(byte type, int id, string userName, byte regionCode) { }

	// RVA: 0x2088EE0 Offset: 0x2084EE0 VA: 0x2088EE0
	public void .ctor(ArchetypeUid uid, string userName, byte regionCode) { }

	// RVA: 0x2088F2C Offset: 0x2084F2C VA: 0x2088F2C
	public void .ctor(Archetype archetype, bool isGMPlayer) { }
}
