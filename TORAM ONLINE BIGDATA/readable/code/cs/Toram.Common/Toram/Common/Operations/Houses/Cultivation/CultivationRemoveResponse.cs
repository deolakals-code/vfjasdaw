// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses.Cultivation
public class CultivationRemoveResponse : OperationResponseBase // TypeDefIndex: 12204
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

	// RVA: 0x35E07B8 Offset: 0x35DC7B8 VA: 0x35E07B8
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x35E07C0 Offset: 0x35DC7C0 VA: 0x35E07C0
	public short get_Index() { }

	[CompilerGenerated]
	// RVA: 0x35E07C8 Offset: 0x35DC7C8 VA: 0x35E07C8
	public void set_Index(short value) { }

	// RVA: 0x35E07D0 Offset: 0x35DC7D0 VA: 0x35E07D0
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x35E07D4 Offset: 0x35DC7D4 VA: 0x35E07D4
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x35E07D8 Offset: 0x35DC7D8 VA: 0x35E07D8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35E07E0 Offset: 0x35DC7E0 VA: 0x35E07E0 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35E07E8 Offset: 0x35DC7E8 VA: 0x35E07E8 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x35E0908 Offset: 0x35DC908 VA: 0x35E0908 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
