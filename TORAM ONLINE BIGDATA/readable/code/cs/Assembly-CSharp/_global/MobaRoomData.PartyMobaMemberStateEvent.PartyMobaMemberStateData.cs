// Assembly: Assembly-CSharp.dll
// Namespace: 
private class MobaRoomData.PartyMobaMemberStateEvent.PartyMobaMemberStateData : IPartyMemberStateData // TypeDefIndex: 2389
{
	// Fields
	[CompilerGenerated]
	private readonly int <ArchetypeId>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly string <UserName>k__BackingField; // 0x18
	private UserStateType bitState; // 0x20

	// Properties
	public byte ArchetypeType { get; }
	public int ArchetypeId { get; }
	public string UserName { get; }
	public int FieldId { get; }
	public byte FieldType { get; }
	public int RoomId { get; }
	public short Level { get; }
	public byte Weapon { get; }
	public byte SubWeapon { get; }
	public byte State { get; }
	public int AdditionalId { get; }

	// Methods

	// RVA: 0x21A8840 Offset: 0x21A4840 VA: 0x21A8840 Slot: 4
	public byte get_ArchetypeType() { }

	[CompilerGenerated]
	// RVA: 0x21A8848 Offset: 0x21A4848 VA: 0x21A8848 Slot: 5
	public int get_ArchetypeId() { }

	[CompilerGenerated]
	// RVA: 0x21A8850 Offset: 0x21A4850 VA: 0x21A8850 Slot: 6
	public string get_UserName() { }

	// RVA: 0x21A8858 Offset: 0x21A4858 VA: 0x21A8858 Slot: 7
	public int get_FieldId() { }

	// RVA: 0x21A88A8 Offset: 0x21A48A8 VA: 0x21A88A8 Slot: 8
	public byte get_FieldType() { }

	// RVA: 0x21A88B0 Offset: 0x21A48B0 VA: 0x21A88B0 Slot: 9
	public int get_RoomId() { }

	// RVA: 0x21A88B8 Offset: 0x21A48B8 VA: 0x21A88B8 Slot: 10
	public short get_Level() { }

	// RVA: 0x21A88C0 Offset: 0x21A48C0 VA: 0x21A88C0 Slot: 11
	public byte get_Weapon() { }

	// RVA: 0x21A88C8 Offset: 0x21A48C8 VA: 0x21A88C8 Slot: 12
	public byte get_SubWeapon() { }

	// RVA: 0x21A88D0 Offset: 0x21A48D0 VA: 0x21A88D0 Slot: 13
	public byte get_State() { }

	// RVA: 0x21A88D8 Offset: 0x21A48D8 VA: 0x21A88D8 Slot: 14
	public int get_AdditionalId() { }

	// RVA: 0x21A85F0 Offset: 0x21A45F0 VA: 0x21A85F0
	public void .ctor(MobaMemberData state) { }

	// RVA: 0x21A8830 Offset: 0x21A4830 VA: 0x21A8830
	public void CheckStateData(byte memberStateBitType) { }
}
