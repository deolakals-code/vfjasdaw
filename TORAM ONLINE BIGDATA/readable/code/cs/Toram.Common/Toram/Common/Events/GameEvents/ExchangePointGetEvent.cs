// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.GameEvents
public class ExchangePointGetEvent : PacketBase // TypeDefIndex: 12679
{
	// Fields
	[CompilerGenerated]
	private short <ExchangeId>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <AddPoint>k__BackingField; // 0x24
	[CompilerGenerated]
	private Dictionary<byte, int> <Datas>k__BackingField; // 0x28
	[CompilerGenerated]
	private int <ItemBonusRate>k__BackingField; // 0x30
	[CompilerGenerated]
	private int <LvDiffPoint>k__BackingField; // 0x34
	[CompilerGenerated]
	private byte <Boost>k__BackingField; // 0x38

	// Properties
	[PacketParameter(Code = 245)]
	public short ExchangeId { get; set; }
	[PacketParameter(Code = 205)]
	public int AddPoint { get; set; }
	public Dictionary<byte, int> Datas { get; set; }
	public int ItemBonusRate { get; set; }
	public int LvDiffPoint { get; set; }
	public byte Boost { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3640420 Offset: 0x363C420 VA: 0x3640420
	public void .ctor() { }

	// RVA: 0x3640428 Offset: 0x363C428 VA: 0x3640428
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3640430 Offset: 0x363C430 VA: 0x3640430
	public short get_ExchangeId() { }

	[CompilerGenerated]
	// RVA: 0x3640438 Offset: 0x363C438 VA: 0x3640438
	public void set_ExchangeId(short value) { }

	[CompilerGenerated]
	// RVA: 0x3640440 Offset: 0x363C440 VA: 0x3640440
	public int get_AddPoint() { }

	[CompilerGenerated]
	// RVA: 0x3640448 Offset: 0x363C448 VA: 0x3640448
	public void set_AddPoint(int value) { }

	[CompilerGenerated]
	// RVA: 0x3640450 Offset: 0x363C450 VA: 0x3640450
	public Dictionary<byte, int> get_Datas() { }

	[CompilerGenerated]
	// RVA: 0x3640458 Offset: 0x363C458 VA: 0x3640458
	public void set_Datas(Dictionary<byte, int> value) { }

	[CompilerGenerated]
	// RVA: 0x3640460 Offset: 0x363C460 VA: 0x3640460
	public int get_ItemBonusRate() { }

	[CompilerGenerated]
	// RVA: 0x3640468 Offset: 0x363C468 VA: 0x3640468
	public void set_ItemBonusRate(int value) { }

	[CompilerGenerated]
	// RVA: 0x3640470 Offset: 0x363C470 VA: 0x3640470
	public int get_LvDiffPoint() { }

	[CompilerGenerated]
	// RVA: 0x3640478 Offset: 0x363C478 VA: 0x3640478
	public void set_LvDiffPoint(int value) { }

	[CompilerGenerated]
	// RVA: 0x3640480 Offset: 0x363C480 VA: 0x3640480
	public byte get_Boost() { }

	[CompilerGenerated]
	// RVA: 0x3640488 Offset: 0x363C488 VA: 0x3640488
	public void set_Boost(byte value) { }

	// RVA: 0x3640490 Offset: 0x363C490 VA: 0x3640490 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3640498 Offset: 0x363C498 VA: 0x3640498 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3640798 Offset: 0x363C798 VA: 0x3640798 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
