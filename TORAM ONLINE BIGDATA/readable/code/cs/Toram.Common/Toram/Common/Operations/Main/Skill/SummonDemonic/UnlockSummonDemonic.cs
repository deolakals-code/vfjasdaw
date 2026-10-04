// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Skill.SummonDemonic
public class UnlockSummonDemonic : OperationRequestBase // TypeDefIndex: 12120
{
	// Fields
	[CompilerGenerated]
	private byte <UnlockNo>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <UseOrb>k__BackingField; // 0x24
	[CompilerGenerated]
	private int <OrbNum>k__BackingField; // 0x28

	// Properties
	public byte UnlockNo { get; set; }
	public int UseOrb { get; set; }
	public int OrbNum { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x378B77C Offset: 0x378777C VA: 0x378B77C
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x378B784 Offset: 0x3787784 VA: 0x378B784
	public byte get_UnlockNo() { }

	[CompilerGenerated]
	// RVA: 0x378B78C Offset: 0x378778C VA: 0x378B78C
	public void set_UnlockNo(byte value) { }

	[CompilerGenerated]
	// RVA: 0x378B794 Offset: 0x3787794 VA: 0x378B794
	public int get_UseOrb() { }

	[CompilerGenerated]
	// RVA: 0x378B79C Offset: 0x378779C VA: 0x378B79C
	public void set_UseOrb(int value) { }

	[CompilerGenerated]
	// RVA: 0x378B7A4 Offset: 0x37877A4 VA: 0x378B7A4
	public int get_OrbNum() { }

	[CompilerGenerated]
	// RVA: 0x378B7AC Offset: 0x37877AC VA: 0x378B7AC
	public void set_OrbNum(int value) { }

	// RVA: 0x378B7B4 Offset: 0x37877B4 VA: 0x378B7B4 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x378B7BC Offset: 0x37877BC VA: 0x378B7BC Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x378B7C4 Offset: 0x37877C4 VA: 0x378B7C4 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x378B8D0 Offset: 0x37878D0 VA: 0x378B8D0 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
