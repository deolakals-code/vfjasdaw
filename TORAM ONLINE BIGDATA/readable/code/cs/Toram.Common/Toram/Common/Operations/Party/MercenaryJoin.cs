// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Party
public class MercenaryJoin : OperationRequestBase // TypeDefIndex: 11462
{
	// Fields
	[CompilerGenerated]
	private int <Gold>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <EmploymentType>k__BackingField; // 0x24
	[CompilerGenerated]
	private int <MercenaryId>k__BackingField; // 0x28
	[CompilerGenerated]
	private DateTime <RegisterDate>k__BackingField; // 0x30

	// Properties
	public int Gold { get; set; }
	public byte EmploymentType { get; set; }
	public int MercenaryId { get; set; }
	public DateTime RegisterDate { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x370E148 Offset: 0x370A148 VA: 0x370E148
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x370E150 Offset: 0x370A150 VA: 0x370E150
	public int get_Gold() { }

	[CompilerGenerated]
	// RVA: 0x370E158 Offset: 0x370A158 VA: 0x370E158
	public void set_Gold(int value) { }

	[CompilerGenerated]
	// RVA: 0x370E160 Offset: 0x370A160 VA: 0x370E160
	public byte get_EmploymentType() { }

	[CompilerGenerated]
	// RVA: 0x370E168 Offset: 0x370A168 VA: 0x370E168
	public void set_EmploymentType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x370E170 Offset: 0x370A170 VA: 0x370E170
	public int get_MercenaryId() { }

	[CompilerGenerated]
	// RVA: 0x370E178 Offset: 0x370A178 VA: 0x370E178
	public void set_MercenaryId(int value) { }

	[CompilerGenerated]
	// RVA: 0x370E180 Offset: 0x370A180 VA: 0x370E180
	public DateTime get_RegisterDate() { }

	[CompilerGenerated]
	// RVA: 0x370E188 Offset: 0x370A188 VA: 0x370E188
	public void set_RegisterDate(DateTime value) { }

	// RVA: 0x370E190 Offset: 0x370A190 VA: 0x370E190 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x370E198 Offset: 0x370A198 VA: 0x370E198 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x370E1A0 Offset: 0x370A1A0 VA: 0x370E1A0 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x370E3D4 Offset: 0x370A3D4 VA: 0x370E3D4 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
