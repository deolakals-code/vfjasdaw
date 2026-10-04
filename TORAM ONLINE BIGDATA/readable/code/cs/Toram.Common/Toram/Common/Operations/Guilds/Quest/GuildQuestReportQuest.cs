// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Guilds.Quest
public class GuildQuestReportQuest : OperationRequestBase // TypeDefIndex: 12429
{
	// Fields
	[CompilerGenerated]
	private byte <No>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <Value>k__BackingField; // 0x24
	[CompilerGenerated]
	private byte <Clear>k__BackingField; // 0x28

	// Properties
	[PacketParameter(Code = 10)]
	public byte No { get; set; }
	[PacketParameter(Code = 11, IsOptional = True)]
	public int Value { get; set; }
	[PacketParameter(Code = 12, IsOptional = True)]
	public byte Clear { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x36063B0 Offset: 0x36023B0 VA: 0x36063B0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x36063B8 Offset: 0x36023B8 VA: 0x36063B8
	public byte get_No() { }

	[CompilerGenerated]
	// RVA: 0x36063C0 Offset: 0x36023C0 VA: 0x36063C0
	public void set_No(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36063C8 Offset: 0x36023C8 VA: 0x36063C8
	public int get_Value() { }

	[CompilerGenerated]
	// RVA: 0x36063D0 Offset: 0x36023D0 VA: 0x36063D0
	public void set_Value(int value) { }

	[CompilerGenerated]
	// RVA: 0x36063D8 Offset: 0x36023D8 VA: 0x36063D8
	public byte get_Clear() { }

	[CompilerGenerated]
	// RVA: 0x36063E0 Offset: 0x36023E0 VA: 0x36063E0
	public void set_Clear(byte value) { }

	// RVA: 0x36063E8 Offset: 0x36023E8 VA: 0x36063E8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36063F0 Offset: 0x36023F0 VA: 0x36063F0 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x36063F8 Offset: 0x36023F8 VA: 0x36063F8 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x360650C Offset: 0x360250C VA: 0x360650C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
