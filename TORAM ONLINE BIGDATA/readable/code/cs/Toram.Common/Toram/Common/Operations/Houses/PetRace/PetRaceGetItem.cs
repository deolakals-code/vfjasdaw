// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses.PetRace
public class PetRaceGetItem : OperationRequestBase // TypeDefIndex: 12217
{
	// Fields
	[CompilerGenerated]
	private byte <GetItemNo>k__BackingField; // 0x20

	// Properties
	public byte GetItemNo { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35E27A8 Offset: 0x35DE7A8 VA: 0x35E27A8
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x35E27B0 Offset: 0x35DE7B0 VA: 0x35E27B0
	public byte get_GetItemNo() { }

	[CompilerGenerated]
	// RVA: 0x35E27B8 Offset: 0x35DE7B8 VA: 0x35E27B8
	public void set_GetItemNo(byte value) { }

	// RVA: 0x35E27C0 Offset: 0x35DE7C0 VA: 0x35E27C0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35E27C8 Offset: 0x35DE7C8 VA: 0x35E27C8 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35E27D0 Offset: 0x35DE7D0 VA: 0x35E27D0 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x35E2870 Offset: 0x35DE870 VA: 0x35E2870 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
