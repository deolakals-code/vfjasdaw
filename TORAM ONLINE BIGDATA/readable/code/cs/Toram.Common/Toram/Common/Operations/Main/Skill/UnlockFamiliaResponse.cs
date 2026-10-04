// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Skill
public class UnlockFamiliaResponse : OperationResponseBase // TypeDefIndex: 12111
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

	// RVA: 0x3789240 Offset: 0x3785240 VA: 0x3789240
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3789248 Offset: 0x3785248 VA: 0x3789248
	public long get_Model() { }

	[CompilerGenerated]
	// RVA: 0x3789250 Offset: 0x3785250 VA: 0x3789250
	public void set_Model(long value) { }

	[CompilerGenerated]
	// RVA: 0x3789258 Offset: 0x3785258 VA: 0x3789258
	public int get_Orb() { }

	[CompilerGenerated]
	// RVA: 0x3789260 Offset: 0x3785260 VA: 0x3789260
	public void set_Orb(int value) { }

	[CompilerGenerated]
	// RVA: 0x3789268 Offset: 0x3785268 VA: 0x3789268
	public int get_PaidOrb() { }

	[CompilerGenerated]
	// RVA: 0x3789270 Offset: 0x3785270 VA: 0x3789270
	public void set_PaidOrb(int value) { }

	// RVA: 0x3789278 Offset: 0x3785278 VA: 0x3789278 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3789280 Offset: 0x3785280 VA: 0x3789280 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3789288 Offset: 0x3785288 VA: 0x3789288 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x378944C Offset: 0x378544C VA: 0x378944C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
