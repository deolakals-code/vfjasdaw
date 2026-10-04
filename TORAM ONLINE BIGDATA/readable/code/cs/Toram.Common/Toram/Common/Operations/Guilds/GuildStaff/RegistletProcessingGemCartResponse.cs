// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Guilds.GuildStaff
public class RegistletProcessingGemCartResponse : OperationResponseBase // TypeDefIndex: 12419
{
	// Fields
	[CompilerGenerated]
	private int <GemPowder>k__BackingField; // 0x20
	[CompilerGenerated]
	private long[] <UuidList>k__BackingField; // 0x28

	// Properties
	[PacketParameter(Code = 10)]
	public int GemPowder { get; set; }
	[PacketParameter(Code = 15)]
	public long[] UuidList { get; set; }
	public override byte SubCode { get; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3604638 Offset: 0x3600638 VA: 0x3604638
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3604640 Offset: 0x3600640 VA: 0x3604640
	public int get_GemPowder() { }

	[CompilerGenerated]
	// RVA: 0x3604648 Offset: 0x3600648 VA: 0x3604648
	public void set_GemPowder(int value) { }

	[CompilerGenerated]
	// RVA: 0x3604650 Offset: 0x3600650 VA: 0x3604650
	public long[] get_UuidList() { }

	[CompilerGenerated]
	// RVA: 0x3604658 Offset: 0x3600658 VA: 0x3604658
	public void set_UuidList(long[] value) { }

	// RVA: 0x3604660 Offset: 0x3600660 VA: 0x3604660 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3604668 Offset: 0x3600668 VA: 0x3604668 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3604670 Offset: 0x3600670 VA: 0x3604670 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x3604724 Offset: 0x3600724 VA: 0x3604724 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
