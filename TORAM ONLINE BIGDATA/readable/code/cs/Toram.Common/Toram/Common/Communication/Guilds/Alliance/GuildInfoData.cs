// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Communication.Guilds.Alliance
public class GuildInfoData : PacketBase // TypeDefIndex: 13038
{
	// Fields
	[CompilerGenerated]
	private int <GuildId>k__BackingField; // 0x20
	[CompilerGenerated]
	private string <GuildName>k__BackingField; // 0x28
	[CompilerGenerated]
	private string <MasterName>k__BackingField; // 0x30
	[CompilerGenerated]
	private byte <MemberNum>k__BackingField; // 0x38
	[CompilerGenerated]
	private DateTime <ChatLinkDate>k__BackingField; // 0x40

	// Properties
	public int GuildId { get; set; }
	public string GuildName { get; set; }
	public string MasterName { get; set; }
	public byte MemberNum { get; set; }
	public DateTime ChatLinkDate { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3693CA4 Offset: 0x368FCA4 VA: 0x3693CA4
	public void .ctor() { }

	// RVA: 0x3693CAC Offset: 0x368FCAC VA: 0x3693CAC
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3693CB4 Offset: 0x368FCB4 VA: 0x3693CB4
	public int get_GuildId() { }

	[CompilerGenerated]
	// RVA: 0x3693CBC Offset: 0x368FCBC VA: 0x3693CBC
	protected void set_GuildId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3693CC4 Offset: 0x368FCC4 VA: 0x3693CC4
	public string get_GuildName() { }

	[CompilerGenerated]
	// RVA: 0x3693CCC Offset: 0x368FCCC VA: 0x3693CCC
	protected void set_GuildName(string value) { }

	[CompilerGenerated]
	// RVA: 0x3693CD4 Offset: 0x368FCD4 VA: 0x3693CD4
	public string get_MasterName() { }

	[CompilerGenerated]
	// RVA: 0x3693CDC Offset: 0x368FCDC VA: 0x3693CDC
	protected void set_MasterName(string value) { }

	[CompilerGenerated]
	// RVA: 0x3693CE4 Offset: 0x368FCE4 VA: 0x3693CE4
	public byte get_MemberNum() { }

	[CompilerGenerated]
	// RVA: 0x3693CEC Offset: 0x368FCEC VA: 0x3693CEC
	protected void set_MemberNum(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3693CF4 Offset: 0x368FCF4 VA: 0x3693CF4
	public DateTime get_ChatLinkDate() { }

	[CompilerGenerated]
	// RVA: 0x3693CFC Offset: 0x368FCFC VA: 0x3693CFC
	protected void set_ChatLinkDate(DateTime value) { }

	// RVA: 0x3693D04 Offset: 0x368FD04 VA: 0x3693D04 Slot: 3
	public override string ToString() { }

	// RVA: 0x3693F40 Offset: 0x368FF40 VA: 0x3693F40 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3693F48 Offset: 0x368FF48 VA: 0x3693F48 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x3694128 Offset: 0x3690128 VA: 0x3694128 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
