// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses.Cultivation
public class CultivationWateringResponse : OperationResponseBase // TypeDefIndex: 12206
{
	// Fields
	[CompilerGenerated]
	private short <Index>k__BackingField; // 0x20

	// Properties
	[PacketParameter(Code = 153)]
	public short Index { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35E0C34 Offset: 0x35DCC34 VA: 0x35E0C34
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x35E0C3C Offset: 0x35DCC3C VA: 0x35E0C3C
	public short get_Index() { }

	[CompilerGenerated]
	// RVA: 0x35E0C44 Offset: 0x35DCC44 VA: 0x35E0C44
	public void set_Index(short value) { }

	// RVA: 0x35E0C4C Offset: 0x35DCC4C VA: 0x35E0C4C
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x35E0C50 Offset: 0x35DCC50 VA: 0x35E0C50
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x35E0C54 Offset: 0x35DCC54 VA: 0x35E0C54 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35E0C5C Offset: 0x35DCC5C VA: 0x35E0C5C Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35E0C64 Offset: 0x35DCC64 VA: 0x35E0C64 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x35E0D84 Offset: 0x35DCD84 VA: 0x35E0D84 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
