// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Skill
public class ChangeFamilia : OperationRequestBase // TypeDefIndex: 12101
{
	// Fields
	[CompilerGenerated]
	private byte <SelectNo>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <Color>k__BackingField; // 0x24
	[CompilerGenerated]
	private int <Flag>k__BackingField; // 0x28

	// Properties
	public byte SelectNo { get; set; }
	public int Color { get; set; }
	public int Flag { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3787558 Offset: 0x3783558 VA: 0x3787558
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3787560 Offset: 0x3783560 VA: 0x3787560
	public byte get_SelectNo() { }

	[CompilerGenerated]
	// RVA: 0x3787568 Offset: 0x3783568 VA: 0x3787568
	public void set_SelectNo(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3787570 Offset: 0x3783570 VA: 0x3787570
	public int get_Color() { }

	[CompilerGenerated]
	// RVA: 0x3787578 Offset: 0x3783578 VA: 0x3787578
	public void set_Color(int value) { }

	[CompilerGenerated]
	// RVA: 0x3787580 Offset: 0x3783580 VA: 0x3787580
	public int get_Flag() { }

	[CompilerGenerated]
	// RVA: 0x3787588 Offset: 0x3783588 VA: 0x3787588
	public void set_Flag(int value) { }

	// RVA: 0x3787590 Offset: 0x3783590 VA: 0x3787590 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3787598 Offset: 0x3783598 VA: 0x3787598 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x37875A0 Offset: 0x37835A0 VA: 0x37875A0 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3787790 Offset: 0x3783790 VA: 0x3787790 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
