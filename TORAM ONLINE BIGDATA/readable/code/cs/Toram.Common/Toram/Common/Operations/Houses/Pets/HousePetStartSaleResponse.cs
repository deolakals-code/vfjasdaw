// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses.Pets
public class HousePetStartSaleResponse : OperationResponseBase // TypeDefIndex: 12299
{
	// Fields
	[CompilerGenerated]
	private byte <Flag>k__BackingField; // 0x20

	// Properties
	public byte Flag { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35EEB34 Offset: 0x35EAB34 VA: 0x35EEB34
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x35EEB3C Offset: 0x35EAB3C VA: 0x35EEB3C
	public byte get_Flag() { }

	[CompilerGenerated]
	// RVA: 0x35EEB44 Offset: 0x35EAB44 VA: 0x35EEB44
	public void set_Flag(byte value) { }

	// RVA: 0x35EEB4C Offset: 0x35EAB4C VA: 0x35EEB4C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35EEB54 Offset: 0x35EAB54 VA: 0x35EEB54 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35EEB5C Offset: 0x35EAB5C VA: 0x35EEB5C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x35EEBFC Offset: 0x35EABFC VA: 0x35EEBFC Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
