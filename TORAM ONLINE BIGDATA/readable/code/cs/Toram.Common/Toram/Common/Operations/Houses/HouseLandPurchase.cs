// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses
public class HouseLandPurchase : OperationRequestBase // TypeDefIndex: 12178
{
	// Fields
	[CompilerGenerated]
	private int <Orb>k__BackingField; // 0x20
	[CompilerGenerated]
	private bool <IsDirect>k__BackingField; // 0x24
	[CompilerGenerated]
	private int <Gold>k__BackingField; // 0x28
	[CompilerGenerated]
	private byte <Width>k__BackingField; // 0x2C
	[CompilerGenerated]
	private byte <Height>k__BackingField; // 0x2D
	[CompilerGenerated]
	private byte <BuyArea>k__BackingField; // 0x2E

	// Properties
	[PacketClass(Code = 229)]
	public int Orb { get; set; }
	[PacketClass(Code = 43)]
	public bool IsDirect { get; set; }
	[PacketClass(Code = 28)]
	public int Gold { get; set; }
	[PacketClass(Code = 250)]
	public byte Width { get; set; }
	[PacketClass(Code = 251)]
	public byte Height { get; set; }
	[PacketClass(Code = 65)]
	public byte BuyArea { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3795E58 Offset: 0x3791E58 VA: 0x3795E58
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3795E60 Offset: 0x3791E60 VA: 0x3795E60
	public int get_Orb() { }

	[CompilerGenerated]
	// RVA: 0x3795E68 Offset: 0x3791E68 VA: 0x3795E68
	public void set_Orb(int value) { }

	[CompilerGenerated]
	// RVA: 0x3795E70 Offset: 0x3791E70 VA: 0x3795E70
	public bool get_IsDirect() { }

	[CompilerGenerated]
	// RVA: 0x3795E78 Offset: 0x3791E78 VA: 0x3795E78
	public void set_IsDirect(bool value) { }

	[CompilerGenerated]
	// RVA: 0x3795E84 Offset: 0x3791E84 VA: 0x3795E84
	public int get_Gold() { }

	[CompilerGenerated]
	// RVA: 0x3795E8C Offset: 0x3791E8C VA: 0x3795E8C
	public void set_Gold(int value) { }

	[CompilerGenerated]
	// RVA: 0x3795E94 Offset: 0x3791E94 VA: 0x3795E94
	public byte get_Width() { }

	[CompilerGenerated]
	// RVA: 0x3795E9C Offset: 0x3791E9C VA: 0x3795E9C
	public void set_Width(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3795EA4 Offset: 0x3791EA4 VA: 0x3795EA4
	public byte get_Height() { }

	[CompilerGenerated]
	// RVA: 0x3795EAC Offset: 0x3791EAC VA: 0x3795EAC
	public void set_Height(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3795EB4 Offset: 0x3791EB4 VA: 0x3795EB4
	public byte get_BuyArea() { }

	[CompilerGenerated]
	// RVA: 0x3795EBC Offset: 0x3791EBC VA: 0x3795EBC
	public void set_BuyArea(byte value) { }

	// RVA: 0x3795EC4 Offset: 0x3791EC4 VA: 0x3795EC4 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3795ECC Offset: 0x3791ECC VA: 0x3795ECC Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3795ED4 Offset: 0x3791ED4 VA: 0x3795ED4 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3796178 Offset: 0x3792178 VA: 0x3796178 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
