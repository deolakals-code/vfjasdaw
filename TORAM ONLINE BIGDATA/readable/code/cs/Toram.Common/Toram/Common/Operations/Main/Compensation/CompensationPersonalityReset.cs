// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Compensation
public class CompensationPersonalityReset : OperationRequestBase // TypeDefIndex: 12029
{
	// Fields
	[CompilerGenerated]
	private byte <CompensationNum>k__BackingField; // 0x20

	// Properties
	[PacketParameter(Code = 253)]
	public byte CompensationNum { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3779D28 Offset: 0x3775D28 VA: 0x3779D28
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3779D30 Offset: 0x3775D30 VA: 0x3779D30
	public byte get_CompensationNum() { }

	[CompilerGenerated]
	// RVA: 0x3779D38 Offset: 0x3775D38 VA: 0x3779D38
	public void set_CompensationNum(byte value) { }

	// RVA: 0x3779D40 Offset: 0x3775D40 VA: 0x3779D40 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3779D48 Offset: 0x3775D48 VA: 0x3779D48 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3779D50 Offset: 0x3775D50 VA: 0x3779D50 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3779E70 Offset: 0x3775E70 VA: 0x3779E70 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
