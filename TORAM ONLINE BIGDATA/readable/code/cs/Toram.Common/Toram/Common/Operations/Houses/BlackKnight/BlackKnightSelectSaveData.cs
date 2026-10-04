// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses.BlackKnight
public class BlackKnightSelectSaveData : OperationRequestBase // TypeDefIndex: 12238
{
	// Fields
	[CompilerGenerated]
	private byte <SaveId>k__BackingField; // 0x20

	// Properties
	public byte SaveId { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35E5900 Offset: 0x35E1900 VA: 0x35E5900
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x35E5908 Offset: 0x35E1908 VA: 0x35E5908
	public byte get_SaveId() { }

	[CompilerGenerated]
	// RVA: 0x35E5910 Offset: 0x35E1910 VA: 0x35E5910
	public void set_SaveId(byte value) { }

	// RVA: 0x35E5918 Offset: 0x35E1918 VA: 0x35E5918 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35E5920 Offset: 0x35E1920 VA: 0x35E5920 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35E5928 Offset: 0x35E1928 VA: 0x35E5928 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x35E59C8 Offset: 0x35E19C8 VA: 0x35E59C8 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
