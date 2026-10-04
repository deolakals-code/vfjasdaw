// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Fishing
public class ProcessFishingFishResponse : OperationResponseBase // TypeDefIndex: 11660
{
	// Fields
	[CompilerGenerated]
	private short[] <IndexList>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <FoodPoint>k__BackingField; // 0x28

	// Properties
	[PacketParameter(Code = 15)]
	public short[] IndexList { get; set; }
	[PacketParameter(Code = 10)]
	public int FoodPoint { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x372CDDC Offset: 0x3728DDC VA: 0x372CDDC
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x372CDE4 Offset: 0x3728DE4 VA: 0x372CDE4
	public short[] get_IndexList() { }

	[CompilerGenerated]
	// RVA: 0x372CDEC Offset: 0x3728DEC VA: 0x372CDEC
	public void set_IndexList(short[] value) { }

	[CompilerGenerated]
	// RVA: 0x372CDF4 Offset: 0x3728DF4 VA: 0x372CDF4
	public int get_FoodPoint() { }

	[CompilerGenerated]
	// RVA: 0x372CDFC Offset: 0x3728DFC VA: 0x372CDFC
	public void set_FoodPoint(int value) { }

	// RVA: 0x372CE04 Offset: 0x3728E04 VA: 0x372CE04 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x372CE0C Offset: 0x3728E0C VA: 0x372CE0C Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x372CE14 Offset: 0x3728E14 VA: 0x372CE14 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x372CEC4 Offset: 0x3728EC4 VA: 0x372CEC4 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
