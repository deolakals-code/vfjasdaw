// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Fishing
public class CreateFishingRodResponse : OperationResponseBase // TypeDefIndex: 11663
{
	// Fields
	[CompilerGenerated]
	private FishingRodData <FishingRodData>k__BackingField; // 0x20
	[CompilerGenerated]
	private MaterialData[] <MaterialList>k__BackingField; // 0x28
	[CompilerGenerated]
	private byte <EquipIndex>k__BackingField; // 0x30

	// Properties
	[PacketParameter(Code = 2)]
	public FishingRodData FishingRodData { get; set; }
	[PacketParameter(Code = 15)]
	public MaterialData[] MaterialList { get; set; }
	[PacketParameter(Code = 10)]
	public byte EquipIndex { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x372D578 Offset: 0x3729578 VA: 0x372D578
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x372D580 Offset: 0x3729580 VA: 0x372D580
	public FishingRodData get_FishingRodData() { }

	[CompilerGenerated]
	// RVA: 0x372D588 Offset: 0x3729588 VA: 0x372D588
	public void set_FishingRodData(FishingRodData value) { }

	[CompilerGenerated]
	// RVA: 0x372D590 Offset: 0x3729590 VA: 0x372D590
	public MaterialData[] get_MaterialList() { }

	[CompilerGenerated]
	// RVA: 0x372D598 Offset: 0x3729598 VA: 0x372D598
	public void set_MaterialList(MaterialData[] value) { }

	[CompilerGenerated]
	// RVA: 0x372D5A0 Offset: 0x37295A0 VA: 0x372D5A0
	public byte get_EquipIndex() { }

	[CompilerGenerated]
	// RVA: 0x372D5A8 Offset: 0x37295A8 VA: 0x372D5A8
	public void set_EquipIndex(byte value) { }

	// RVA: 0x372D5B0 Offset: 0x37295B0 VA: 0x372D5B0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x372D5B8 Offset: 0x37295B8 VA: 0x372D5B8 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x372D5C0 Offset: 0x37295C0 VA: 0x372D5C0 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x372D6C4 Offset: 0x37296C4 VA: 0x372D6C4 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
