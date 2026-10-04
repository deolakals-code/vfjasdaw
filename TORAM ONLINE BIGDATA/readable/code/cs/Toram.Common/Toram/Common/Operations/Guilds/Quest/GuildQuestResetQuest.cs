// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Guilds.Quest
public class GuildQuestResetQuest : OperationRequestBase // TypeDefIndex: 12423
{
	// Fields
	[CompilerGenerated]
	private byte <No>k__BackingField; // 0x20

	// Properties
	[PacketParameter(Code = 10)]
	public byte No { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x36050C4 Offset: 0x36010C4 VA: 0x36050C4
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x36050CC Offset: 0x36010CC VA: 0x36050CC
	public byte get_No() { }

	[CompilerGenerated]
	// RVA: 0x36050D4 Offset: 0x36010D4 VA: 0x36050D4
	public void set_No(byte value) { }

	// RVA: 0x36050DC Offset: 0x36010DC VA: 0x36050DC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36050E4 Offset: 0x36010E4 VA: 0x36050E4 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x36050EC Offset: 0x36010EC VA: 0x36050EC Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x3605188 Offset: 0x3601188 VA: 0x3605188 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
