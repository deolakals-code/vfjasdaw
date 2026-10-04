// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Global.Contents.Moba
public class MobaCheckLoginResponse : OperationResponseBase // TypeDefIndex: 11593
{
	// Fields
	[CompilerGenerated]
	private short <ReturnCode>k__BackingField; // 0x20

	// Properties
	public short ReturnCode { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3721044 Offset: 0x371D044 VA: 0x3721044
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x372104C Offset: 0x371D04C VA: 0x372104C
	public short get_ReturnCode() { }

	[CompilerGenerated]
	// RVA: 0x3721054 Offset: 0x371D054 VA: 0x3721054
	public void set_ReturnCode(short value) { }

	// RVA: 0x372105C Offset: 0x371D05C VA: 0x372105C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3721064 Offset: 0x371D064 VA: 0x3721064 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x372106C Offset: 0x371D06C VA: 0x372106C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x3721108 Offset: 0x371D108 VA: 0x3721108 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
