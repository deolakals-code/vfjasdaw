// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Communication.Guild
public class GuildJoinEvent : PacketBase // TypeDefIndex: 12917
{
	// Fields
	private int version; // 0x20
	[CompilerGenerated]
	private int <GuildId>k__BackingField; // 0x24
	[CompilerGenerated]
	private UserData <UserData>k__BackingField; // 0x28
	[CompilerGenerated]
	private int <MemberNum>k__BackingField; // 0x30

	// Properties
	public int GuildId { get; set; }
	public UserData UserData { get; set; }
	public int MemberNum { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3677B64 Offset: 0x3673B64 VA: 0x3677B64
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3677B6C Offset: 0x3673B6C VA: 0x3677B6C
	public int get_GuildId() { }

	[CompilerGenerated]
	// RVA: 0x3677B74 Offset: 0x3673B74 VA: 0x3677B74
	public void set_GuildId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3677B7C Offset: 0x3673B7C VA: 0x3677B7C
	public UserData get_UserData() { }

	[CompilerGenerated]
	// RVA: 0x3677B84 Offset: 0x3673B84 VA: 0x3677B84
	public void set_UserData(UserData value) { }

	[CompilerGenerated]
	// RVA: 0x3677B8C Offset: 0x3673B8C VA: 0x3677B8C
	public int get_MemberNum() { }

	[CompilerGenerated]
	// RVA: 0x3677B94 Offset: 0x3673B94 VA: 0x3677B94
	public void set_MemberNum(int value) { }

	// RVA: 0x3677B9C Offset: 0x3673B9C VA: 0x3677B9C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3677BA4 Offset: 0x3673BA4 VA: 0x3677BA4 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3677E70 Offset: 0x3673E70 VA: 0x3677E70 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
