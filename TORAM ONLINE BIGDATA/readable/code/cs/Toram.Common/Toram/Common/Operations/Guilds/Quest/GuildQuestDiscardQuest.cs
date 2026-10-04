// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Guilds.Quest
public class GuildQuestDiscardQuest : OperationRequestBase // TypeDefIndex: 12425
{
	// Fields
	[CompilerGenerated]
	private byte <No>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <NextType>k__BackingField; // 0x21

	// Properties
	[PacketParameter(Code = 10)]
	public byte No { get; set; }
	[PacketParameter(Code = 1)]
	public byte NextType { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x36054E4 Offset: 0x36014E4 VA: 0x36054E4
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x36054EC Offset: 0x36014EC VA: 0x36054EC
	public byte get_No() { }

	[CompilerGenerated]
	// RVA: 0x36054F4 Offset: 0x36014F4 VA: 0x36054F4
	public void set_No(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36054FC Offset: 0x36014FC VA: 0x36054FC
	public byte get_NextType() { }

	[CompilerGenerated]
	// RVA: 0x3605504 Offset: 0x3601504 VA: 0x3605504
	public void set_NextType(byte value) { }

	// RVA: 0x360550C Offset: 0x360150C VA: 0x360550C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3605514 Offset: 0x3601514 VA: 0x3605514 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x360551C Offset: 0x360151C VA: 0x360551C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x36055E4 Offset: 0x36015E4 VA: 0x36055E4 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
