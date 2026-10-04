// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Rooms.Boss
public class CheckRaidBossSymbol : OperationRequestBase // TypeDefIndex: 11780
{
	// Fields
	[CompilerGenerated]
	private int <FieldId>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <RoomId>k__BackingField; // 0x24
	[CompilerGenerated]
	private byte <Flag>k__BackingField; // 0x25

	// Properties
	public int FieldId { get; set; }
	public byte RoomId { get; set; }
	public byte Flag { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x37491D0 Offset: 0x37451D0 VA: 0x37491D0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x37491D8 Offset: 0x37451D8 VA: 0x37491D8
	public int get_FieldId() { }

	[CompilerGenerated]
	// RVA: 0x37491E0 Offset: 0x37451E0 VA: 0x37491E0
	public void set_FieldId(int value) { }

	[CompilerGenerated]
	// RVA: 0x37491E8 Offset: 0x37451E8 VA: 0x37491E8
	public byte get_RoomId() { }

	[CompilerGenerated]
	// RVA: 0x37491F0 Offset: 0x37451F0 VA: 0x37491F0
	public void set_RoomId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x37491F8 Offset: 0x37451F8 VA: 0x37491F8
	public byte get_Flag() { }

	[CompilerGenerated]
	// RVA: 0x3749200 Offset: 0x3745200 VA: 0x3749200
	public void set_Flag(byte value) { }

	// RVA: 0x3749208 Offset: 0x3745208 VA: 0x3749208
	public void SetForcibly(bool isForcibly) { }

	// RVA: 0x3749234 Offset: 0x3745234 VA: 0x3749234
	public void SetDetail(bool isDetail) { }

	// RVA: 0x3749254 Offset: 0x3745254 VA: 0x3749254
	public void SetMatching(bool isMatching) { }

	// RVA: 0x3749274 Offset: 0x3745274 VA: 0x3749274
	public void SetSecondParty(bool isSecondParty) { }

	// RVA: 0x3749218 Offset: 0x3745218 VA: 0x3749218
	private void SetFlag(byte flag, bool isOn) { }

	// RVA: 0x3749294 Offset: 0x3745294 VA: 0x3749294 Slot: 3
	public override string ToString() { }

	// RVA: 0x3749350 Offset: 0x3745350 VA: 0x3749350 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3749358 Offset: 0x3745358 VA: 0x3749358 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3749360 Offset: 0x3745360 VA: 0x3749360 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3749524 Offset: 0x3745524 VA: 0x3749524 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
