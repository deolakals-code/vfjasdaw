// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Orb
public class OrbItemCheck : OperationRequestBase // TypeDefIndex: 11809
{
	// Fields
	[CompilerGenerated]
	private int <ItemId>k__BackingField; // 0x20

	// Properties
	[PacketParameter(Code = 91)]
	public int ItemId { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x374F7A4 Offset: 0x374B7A4 VA: 0x374F7A4
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x374F7AC Offset: 0x374B7AC VA: 0x374F7AC
	public int get_ItemId() { }

	[CompilerGenerated]
	// RVA: 0x374F7B4 Offset: 0x374B7B4 VA: 0x374F7B4
	public void set_ItemId(int value) { }

	// RVA: 0x374F7BC Offset: 0x374B7BC VA: 0x374F7BC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x374F7C4 Offset: 0x374B7C4 VA: 0x374F7C4 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x374F7CC Offset: 0x374B7CC VA: 0x374F7CC Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x374F8EC Offset: 0x374B8EC VA: 0x374F8EC Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
