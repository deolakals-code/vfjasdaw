// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Rooms.Lobby
public class RoomLobbyBattleStart : OperationRequestBase // TypeDefIndex: 11773
{
	// Fields
	[CompilerGenerated]
	private short[] <Position>k__BackingField; // 0x20
	[CompilerGenerated]
	private short <Rotation>k__BackingField; // 0x28
	[CompilerGenerated]
	private EmergencyPositionData <EmergencyPositionData>k__BackingField; // 0x30
	[CompilerGenerated]
	private byte[] <BonusList>k__BackingField; // 0x38
	[CompilerGenerated]
	private RoomMemberData[] <MemberList>k__BackingField; // 0x40
	[CompilerGenerated]
	private int[] <SupportItemList>k__BackingField; // 0x48
	[CompilerGenerated]
	private int[] <SupportOrbItemList>k__BackingField; // 0x50
	[CompilerGenerated]
	private int <GuildId>k__BackingField; // 0x58

	// Properties
	public short[] Position { get; set; }
	public short Rotation { get; set; }
	public EmergencyPositionData EmergencyPositionData { get; set; }
	public byte[] BonusList { get; set; }
	public RoomMemberData[] MemberList { get; set; }
	public int[] SupportItemList { get; set; }
	public int[] SupportOrbItemList { get; set; }
	public int GuildId { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x374780C Offset: 0x374380C VA: 0x374780C
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3747814 Offset: 0x3743814 VA: 0x3747814
	public short[] get_Position() { }

	[CompilerGenerated]
	// RVA: 0x374781C Offset: 0x374381C VA: 0x374781C
	public void set_Position(short[] value) { }

	[CompilerGenerated]
	// RVA: 0x3747824 Offset: 0x3743824 VA: 0x3747824
	public short get_Rotation() { }

	[CompilerGenerated]
	// RVA: 0x374782C Offset: 0x374382C VA: 0x374782C
	public void set_Rotation(short value) { }

	[CompilerGenerated]
	// RVA: 0x3747834 Offset: 0x3743834 VA: 0x3747834
	public EmergencyPositionData get_EmergencyPositionData() { }

	[CompilerGenerated]
	// RVA: 0x374783C Offset: 0x374383C VA: 0x374783C
	public void set_EmergencyPositionData(EmergencyPositionData value) { }

	[CompilerGenerated]
	// RVA: 0x3747844 Offset: 0x3743844 VA: 0x3747844
	public byte[] get_BonusList() { }

	[CompilerGenerated]
	// RVA: 0x374784C Offset: 0x374384C VA: 0x374784C
	public void set_BonusList(byte[] value) { }

	[CompilerGenerated]
	// RVA: 0x3747854 Offset: 0x3743854 VA: 0x3747854
	public RoomMemberData[] get_MemberList() { }

	[CompilerGenerated]
	// RVA: 0x374785C Offset: 0x374385C VA: 0x374785C
	public void set_MemberList(RoomMemberData[] value) { }

	[CompilerGenerated]
	// RVA: 0x3747864 Offset: 0x3743864 VA: 0x3747864
	public int[] get_SupportItemList() { }

	[CompilerGenerated]
	// RVA: 0x374786C Offset: 0x374386C VA: 0x374786C
	public void set_SupportItemList(int[] value) { }

	[CompilerGenerated]
	// RVA: 0x3747874 Offset: 0x3743874 VA: 0x3747874
	public int[] get_SupportOrbItemList() { }

	[CompilerGenerated]
	// RVA: 0x374787C Offset: 0x374387C VA: 0x374787C
	public void set_SupportOrbItemList(int[] value) { }

	[CompilerGenerated]
	// RVA: 0x3747884 Offset: 0x3743884 VA: 0x3747884
	public int get_GuildId() { }

	[CompilerGenerated]
	// RVA: 0x374788C Offset: 0x374388C VA: 0x374788C
	public void set_GuildId(int value) { }

	// RVA: 0x3747894 Offset: 0x3743894 VA: 0x3747894 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x374789C Offset: 0x374389C VA: 0x374789C Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x37478A4 Offset: 0x37438A4 VA: 0x37478A4 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3747DD4 Offset: 0x3743DD4 VA: 0x3747DD4 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
