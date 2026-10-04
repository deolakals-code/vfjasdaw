// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Communication.Guild
public class GuildExileEvent : PacketBase // TypeDefIndex: 12914
{
	// Fields
	private int version; // 0x20
	[CompilerGenerated]
	private int <GuildId>k__BackingField; // 0x24
	[CompilerGenerated]
	private int <ArchetypeId>k__BackingField; // 0x28
	[CompilerGenerated]
	private string <UserName>k__BackingField; // 0x30
	[CompilerGenerated]
	private GameStatusData <GameStatus>k__BackingField; // 0x38
	[CompilerGenerated]
	private int <MemberNum>k__BackingField; // 0x40

	// Properties
	[PacketParameter(Code = 219)]
	public int GuildId { get; set; }
	[PacketParameter(Code = 74)]
	public int ArchetypeId { get; set; }
	[PacketParameter(Code = 66)]
	public string UserName { get; set; }
	[PacketParameter(Code = 70)]
	public GameStatusData GameStatus { get; set; }
	public int MemberNum { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x367701C Offset: 0x367301C VA: 0x367701C
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3677024 Offset: 0x3673024 VA: 0x3677024
	public int get_GuildId() { }

	[CompilerGenerated]
	// RVA: 0x367702C Offset: 0x367302C VA: 0x367702C
	public void set_GuildId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3677034 Offset: 0x3673034 VA: 0x3677034
	public int get_ArchetypeId() { }

	[CompilerGenerated]
	// RVA: 0x367703C Offset: 0x367303C VA: 0x367703C
	public void set_ArchetypeId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3677044 Offset: 0x3673044 VA: 0x3677044
	public string get_UserName() { }

	[CompilerGenerated]
	// RVA: 0x367704C Offset: 0x367304C VA: 0x367704C
	public void set_UserName(string value) { }

	[CompilerGenerated]
	// RVA: 0x3677054 Offset: 0x3673054 VA: 0x3677054
	public GameStatusData get_GameStatus() { }

	[CompilerGenerated]
	// RVA: 0x367705C Offset: 0x367305C VA: 0x367705C
	public void set_GameStatus(GameStatusData value) { }

	[CompilerGenerated]
	// RVA: 0x3677064 Offset: 0x3673064 VA: 0x3677064
	public int get_MemberNum() { }

	[CompilerGenerated]
	// RVA: 0x367706C Offset: 0x367306C VA: 0x367706C
	public void set_MemberNum(int value) { }

	// RVA: 0x3677074 Offset: 0x3673074 VA: 0x3677074 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x367707C Offset: 0x367307C VA: 0x367707C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x36773D4 Offset: 0x36733D4 VA: 0x36773D4 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
