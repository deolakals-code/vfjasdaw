// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Guilds.BBS
public class GuildBBSUpdatePublishFlag : OperationRequestBase // TypeDefIndex: 12449
{
	// Fields
	[CompilerGenerated]
	private byte <PublishFlag>k__BackingField; // 0x20
	[CompilerGenerated]
	private string <Comment>k__BackingField; // 0x28
	[CompilerGenerated]
	private byte <JoinType>k__BackingField; // 0x30
	[CompilerGenerated]
	private byte <ConditionsType>k__BackingField; // 0x31
	[CompilerGenerated]
	private int <ConditionsValue>k__BackingField; // 0x34

	// Properties
	public byte PublishFlag { get; set; }
	public string Comment { get; set; }
	public byte JoinType { get; set; }
	public byte ConditionsType { get; set; }
	public int ConditionsValue { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3609A08 Offset: 0x3605A08 VA: 0x3609A08
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3609A10 Offset: 0x3605A10 VA: 0x3609A10
	public byte get_PublishFlag() { }

	[CompilerGenerated]
	// RVA: 0x3609A18 Offset: 0x3605A18 VA: 0x3609A18
	public void set_PublishFlag(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3609A20 Offset: 0x3605A20 VA: 0x3609A20
	public string get_Comment() { }

	[CompilerGenerated]
	// RVA: 0x3609A28 Offset: 0x3605A28 VA: 0x3609A28
	public void set_Comment(string value) { }

	[CompilerGenerated]
	// RVA: 0x3609A30 Offset: 0x3605A30 VA: 0x3609A30
	public byte get_JoinType() { }

	[CompilerGenerated]
	// RVA: 0x3609A38 Offset: 0x3605A38 VA: 0x3609A38
	public void set_JoinType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3609A40 Offset: 0x3605A40 VA: 0x3609A40
	public byte get_ConditionsType() { }

	[CompilerGenerated]
	// RVA: 0x3609A48 Offset: 0x3605A48 VA: 0x3609A48
	public void set_ConditionsType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3609A50 Offset: 0x3605A50 VA: 0x3609A50
	public int get_ConditionsValue() { }

	[CompilerGenerated]
	// RVA: 0x3609A58 Offset: 0x3605A58 VA: 0x3609A58
	public void set_ConditionsValue(int value) { }

	// RVA: 0x3609A60 Offset: 0x3605A60 VA: 0x3609A60 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3609A68 Offset: 0x3605A68 VA: 0x3609A68 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3609A70 Offset: 0x3605A70 VA: 0x3609A70 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3609CD0 Offset: 0x3605CD0 VA: 0x3609CD0 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
