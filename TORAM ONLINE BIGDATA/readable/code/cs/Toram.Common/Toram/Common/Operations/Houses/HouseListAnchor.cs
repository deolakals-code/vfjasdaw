// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses
public class HouseListAnchor : OperationRequestBase // TypeDefIndex: 12157
{
	// Fields
	[CompilerGenerated]
	private int <TargetArchetypeId>k__BackingField; // 0x20

	// Properties
	[PacketClass(Code = 74)]
	public int TargetArchetypeId { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3792DA4 Offset: 0x378EDA4 VA: 0x3792DA4
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3792DAC Offset: 0x378EDAC VA: 0x3792DAC
	public int get_TargetArchetypeId() { }

	[CompilerGenerated]
	// RVA: 0x3792DB4 Offset: 0x378EDB4 VA: 0x3792DB4
	public void set_TargetArchetypeId(int value) { }

	// RVA: 0x3792DBC Offset: 0x378EDBC VA: 0x3792DBC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3792DC4 Offset: 0x378EDC4 VA: 0x3792DC4 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3792DCC Offset: 0x378EDCC VA: 0x3792DCC Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3792EEC Offset: 0x378EEEC VA: 0x3792EEC Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
