// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses.Cuisine
public class CuisineChangeType : OperationRequestBase // TypeDefIndex: 12247
{
	// Fields
	[CompilerGenerated]
	private byte <Type>k__BackingField; // 0x20

	// Properties
	[PacketParameter(Code = 245)]
	public byte Type { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35E6C58 Offset: 0x35E2C58 VA: 0x35E6C58
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x35E6C60 Offset: 0x35E2C60 VA: 0x35E6C60
	public byte get_Type() { }

	[CompilerGenerated]
	// RVA: 0x35E6C68 Offset: 0x35E2C68 VA: 0x35E6C68
	public void set_Type(byte value) { }

	// RVA: 0x35E6C70 Offset: 0x35E2C70 VA: 0x35E6C70
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x35E6C74 Offset: 0x35E2C74 VA: 0x35E6C74
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x35E6C78 Offset: 0x35E2C78 VA: 0x35E6C78 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35E6C80 Offset: 0x35E2C80 VA: 0x35E6C80 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35E6C88 Offset: 0x35E2C88 VA: 0x35E6C88 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x35E6DA8 Offset: 0x35E2DA8 VA: 0x35E6DA8 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
