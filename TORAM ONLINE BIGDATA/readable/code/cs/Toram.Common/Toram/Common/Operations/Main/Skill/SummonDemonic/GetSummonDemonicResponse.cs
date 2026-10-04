// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Skill.SummonDemonic
public class GetSummonDemonicResponse : OperationResponseBase // TypeDefIndex: 12119
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

	// RVA: 0x378B3C0 Offset: 0x37873C0 VA: 0x378B3C0
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x378B3C8 Offset: 0x37873C8 VA: 0x378B3C8
	public byte get_SelectNo() { }

	[CompilerGenerated]
	// RVA: 0x378B3D0 Offset: 0x37873D0 VA: 0x378B3D0
	public void set_SelectNo(byte value) { }

	[CompilerGenerated]
	// RVA: 0x378B3D8 Offset: 0x37873D8 VA: 0x378B3D8
	public int get_Color() { }

	[CompilerGenerated]
	// RVA: 0x378B3E0 Offset: 0x37873E0 VA: 0x378B3E0
	public void set_Color(int value) { }

	[CompilerGenerated]
	// RVA: 0x378B3E8 Offset: 0x37873E8 VA: 0x378B3E8
	public long get_Model() { }

	[CompilerGenerated]
	// RVA: 0x378B3F0 Offset: 0x37873F0 VA: 0x378B3F0
	public void set_Model(long value) { }

	[CompilerGenerated]
	// RVA: 0x378B3F8 Offset: 0x37873F8 VA: 0x378B3F8
	public int get_Flag() { }

	[CompilerGenerated]
	// RVA: 0x378B400 Offset: 0x3787400 VA: 0x378B400
	public void set_Flag(int value) { }

	// RVA: 0x378B408 Offset: 0x3787408 VA: 0x378B408 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x378B410 Offset: 0x3787410 VA: 0x378B410 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x378B418 Offset: 0x3787418 VA: 0x378B418 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x378B560 Offset: 0x3787560 VA: 0x378B560 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
