// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Skill
public class UnlockHuntingOneResponse : OperationResponseBase // TypeDefIndex: 12100
{
	// Fields
	[CompilerGenerated]
	private long <Model>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <Orb>k__BackingField; // 0x28
	[CompilerGenerated]
	private int <PaidOrb>k__BackingField; // 0x2C

	// Properties
	public long Model { get; set; }
	public int Orb { get; set; }
	public int PaidOrb { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3787240 Offset: 0x3783240 VA: 0x3787240
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3787248 Offset: 0x3783248 VA: 0x3787248
	public long get_Model() { }

	[CompilerGenerated]
	// RVA: 0x3787250 Offset: 0x3783250 VA: 0x3787250
	public void set_Model(long value) { }

	[CompilerGenerated]
	// RVA: 0x3787258 Offset: 0x3783258 VA: 0x3787258
	public int get_Orb() { }

	[CompilerGenerated]
	// RVA: 0x3787260 Offset: 0x3783260 VA: 0x3787260
	public void set_Orb(int value) { }

	[CompilerGenerated]
	// RVA: 0x3787268 Offset: 0x3783268 VA: 0x3787268
	public int get_PaidOrb() { }

	[CompilerGenerated]
	// RVA: 0x3787270 Offset: 0x3783270 VA: 0x3787270
	public void set_PaidOrb(int value) { }

	// RVA: 0x3787278 Offset: 0x3783278 VA: 0x3787278 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3787280 Offset: 0x3783280 VA: 0x3787280 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3787288 Offset: 0x3783288 VA: 0x3787288 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x3787394 Offset: 0x3783394 VA: 0x3787394 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
