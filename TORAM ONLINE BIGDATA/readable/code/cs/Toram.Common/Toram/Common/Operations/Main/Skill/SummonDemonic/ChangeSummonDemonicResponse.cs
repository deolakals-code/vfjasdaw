// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Skill.SummonDemonic
public class ChangeSummonDemonicResponse : OperationResponseBase // TypeDefIndex: 12118
{
	// Fields
	[CompilerGenerated]
	private byte <SelectNo>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <Color>k__BackingField; // 0x24
	[CompilerGenerated]
	private long <Model>k__BackingField; // 0x28
	[CompilerGenerated]
	private int <Flag>k__BackingField; // 0x30

	// Properties
	public byte SelectNo { get; set; }
	public int Color { get; set; }
	public long Model { get; set; }
	public int Flag { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x378B004 Offset: 0x3787004 VA: 0x378B004
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x378B00C Offset: 0x378700C VA: 0x378B00C
	public byte get_SelectNo() { }

	[CompilerGenerated]
	// RVA: 0x378B014 Offset: 0x3787014 VA: 0x378B014
	public void set_SelectNo(byte value) { }

	[CompilerGenerated]
	// RVA: 0x378B01C Offset: 0x378701C VA: 0x378B01C
	public int get_Color() { }

	[CompilerGenerated]
	// RVA: 0x378B024 Offset: 0x3787024 VA: 0x378B024
	public void set_Color(int value) { }

	[CompilerGenerated]
	// RVA: 0x378B02C Offset: 0x378702C VA: 0x378B02C
	public long get_Model() { }

	[CompilerGenerated]
	// RVA: 0x378B034 Offset: 0x3787034 VA: 0x378B034
	public void set_Model(long value) { }

	[CompilerGenerated]
	// RVA: 0x378B03C Offset: 0x378703C VA: 0x378B03C
	public int get_Flag() { }

	[CompilerGenerated]
	// RVA: 0x378B044 Offset: 0x3787044 VA: 0x378B044
	public void set_Flag(int value) { }

	// RVA: 0x378B04C Offset: 0x378704C VA: 0x378B04C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x378B054 Offset: 0x3787054 VA: 0x378B054 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x378B05C Offset: 0x378705C VA: 0x378B05C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x378B1A4 Offset: 0x37871A4 VA: 0x378B1A4 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
