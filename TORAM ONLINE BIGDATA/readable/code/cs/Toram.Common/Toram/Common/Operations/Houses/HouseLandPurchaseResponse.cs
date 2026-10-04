// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses
public class HouseLandPurchaseResponse : OperationResponseBase // TypeDefIndex: 12179
{
	// Fields
	[CompilerGenerated]
	private int <Gold>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <Orb>k__BackingField; // 0x24
	[CompilerGenerated]
	private int <PaidOrb>k__BackingField; // 0x28
	[CompilerGenerated]
	private short <PointX>k__BackingField; // 0x2C
	[CompilerGenerated]
	private short <PointZ>k__BackingField; // 0x2E
	[CompilerGenerated]
	private byte <Width>k__BackingField; // 0x30
	[CompilerGenerated]
	private byte <Height>k__BackingField; // 0x31
	[CompilerGenerated]
	private byte <BreedNum>k__BackingField; // 0x32

	// Properties
	[PacketClass(Code = 28)]
	public int Gold { get; set; }
	[PacketParameter(Code = 229)]
	public int Orb { get; set; }
	public int PaidOrb { get; set; }
	[PacketClass(Code = 205)]
	public short PointX { get; set; }
	[PacketClass(Code = 54)]
	public short PointZ { get; set; }
	[PacketClass(Code = 250)]
	public byte Width { get; set; }
	[PacketClass(Code = 251)]
	public byte Height { get; set; }
	[PacketClass(Code = 21, IsOptional = True)]
	public byte BreedNum { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3796310 Offset: 0x3792310 VA: 0x3796310
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3796318 Offset: 0x3792318 VA: 0x3796318
	public int get_Gold() { }

	[CompilerGenerated]
	// RVA: 0x3796320 Offset: 0x3792320 VA: 0x3796320
	public void set_Gold(int value) { }

	[CompilerGenerated]
	// RVA: 0x3796328 Offset: 0x3792328 VA: 0x3796328
	public int get_Orb() { }

	[CompilerGenerated]
	// RVA: 0x3796330 Offset: 0x3792330 VA: 0x3796330
	public void set_Orb(int value) { }

	[CompilerGenerated]
	// RVA: 0x3796338 Offset: 0x3792338 VA: 0x3796338
	public int get_PaidOrb() { }

	[CompilerGenerated]
	// RVA: 0x3796340 Offset: 0x3792340 VA: 0x3796340
	public void set_PaidOrb(int value) { }

	[CompilerGenerated]
	// RVA: 0x3796348 Offset: 0x3792348 VA: 0x3796348
	public short get_PointX() { }

	[CompilerGenerated]
	// RVA: 0x3796350 Offset: 0x3792350 VA: 0x3796350
	public void set_PointX(short value) { }

	[CompilerGenerated]
	// RVA: 0x3796358 Offset: 0x3792358 VA: 0x3796358
	public short get_PointZ() { }

	[CompilerGenerated]
	// RVA: 0x3796360 Offset: 0x3792360 VA: 0x3796360
	public void set_PointZ(short value) { }

	[CompilerGenerated]
	// RVA: 0x3796368 Offset: 0x3792368 VA: 0x3796368
	public byte get_Width() { }

	[CompilerGenerated]
	// RVA: 0x3796370 Offset: 0x3792370 VA: 0x3796370
	public void set_Width(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3796378 Offset: 0x3792378 VA: 0x3796378
	public byte get_Height() { }

	[CompilerGenerated]
	// RVA: 0x3796380 Offset: 0x3792380 VA: 0x3796380
	public void set_Height(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3796388 Offset: 0x3792388 VA: 0x3796388
	public byte get_BreedNum() { }

	[CompilerGenerated]
	// RVA: 0x3796390 Offset: 0x3792390 VA: 0x3796390
	public void set_BreedNum(byte value) { }

	// RVA: 0x3796398 Offset: 0x3792398 VA: 0x3796398 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x37963A0 Offset: 0x37923A0 VA: 0x37963A0 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x37963A8 Offset: 0x37923A8 VA: 0x37963A8 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3796718 Offset: 0x3792718 VA: 0x3796718 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
