// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Guilds.GuildRaid
public class GuildHeldRaid : OperationRequestBase // TypeDefIndex: 12438
{
	// Fields
	[CompilerGenerated]
	private int <RaidId>k__BackingField; // 0x20
	[CompilerGenerated]
	private bool <IsPractice>k__BackingField; // 0x24

	// Properties
	[PacketParameter(Code = 0)]
	public int RaidId { get; set; }
	[PacketParameter(Code = 20)]
	public bool IsPractice { get; set; }
	public override byte SubCode { get; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x36082E4 Offset: 0x36042E4 VA: 0x36082E4
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x36082EC Offset: 0x36042EC VA: 0x36082EC
	public int get_RaidId() { }

	[CompilerGenerated]
	// RVA: 0x36082F4 Offset: 0x36042F4 VA: 0x36082F4
	public void set_RaidId(int value) { }

	[CompilerGenerated]
	// RVA: 0x36082FC Offset: 0x36042FC VA: 0x36082FC
	public bool get_IsPractice() { }

	[CompilerGenerated]
	// RVA: 0x3608304 Offset: 0x3604304 VA: 0x3608304
	public void set_IsPractice(bool value) { }

	// RVA: 0x3608310 Offset: 0x3604310 VA: 0x3608310 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3608318 Offset: 0x3604318 VA: 0x3608318 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3608320 Offset: 0x3604320 VA: 0x3608320 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x36083F0 Offset: 0x36043F0 VA: 0x36083F0 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
