// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses.BlackKnight
public class BlackKnightUpdateRankingResponse : OperationResponseBase // TypeDefIndex: 12243
{
	// Fields
	[CompilerGenerated]
	private byte <Type>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <StageId>k__BackingField; // 0x21
	[CompilerGenerated]
	private Dictionary<int, int> <Ranking>k__BackingField; // 0x28

	// Properties
	public byte Type { get; set; }
	public byte StageId { get; set; }
	public Dictionary<int, int> Ranking { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35E6490 Offset: 0x35E2490 VA: 0x35E6490
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x35E6498 Offset: 0x35E2498 VA: 0x35E6498
	public byte get_Type() { }

	[CompilerGenerated]
	// RVA: 0x35E64A0 Offset: 0x35E24A0 VA: 0x35E64A0
	public void set_Type(byte value) { }

	[CompilerGenerated]
	// RVA: 0x35E64A8 Offset: 0x35E24A8 VA: 0x35E64A8
	public byte get_StageId() { }

	[CompilerGenerated]
	// RVA: 0x35E64B0 Offset: 0x35E24B0 VA: 0x35E64B0
	public void set_StageId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x35E64B8 Offset: 0x35E24B8 VA: 0x35E64B8
	public Dictionary<int, int> get_Ranking() { }

	[CompilerGenerated]
	// RVA: 0x35E64C0 Offset: 0x35E24C0 VA: 0x35E64C0
	public void set_Ranking(Dictionary<int, int> value) { }

	// RVA: 0x35E64C8 Offset: 0x35E24C8 VA: 0x35E64C8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35E64D0 Offset: 0x35E24D0 VA: 0x35E64D0 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35E64D8 Offset: 0x35E24D8 VA: 0x35E64D8 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x35E65B4 Offset: 0x35E25B4 VA: 0x35E65B4 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
