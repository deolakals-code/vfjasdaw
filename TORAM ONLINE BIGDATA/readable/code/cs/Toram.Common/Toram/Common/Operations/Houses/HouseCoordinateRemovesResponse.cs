// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses
public class HouseCoordinateRemovesResponse : OperationRequestBase // TypeDefIndex: 12167
{
	// Fields
	[CompilerGenerated]
	private int[] <RemoveList>k__BackingField; // 0x20

	// Properties
	public int[] RemoveList { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3793FA4 Offset: 0x378FFA4 VA: 0x3793FA4
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3793FAC Offset: 0x378FFAC VA: 0x3793FAC
	public int[] get_RemoveList() { }

	[CompilerGenerated]
	// RVA: 0x3793FB4 Offset: 0x378FFB4 VA: 0x3793FB4
	public void set_RemoveList(int[] value) { }

	// RVA: 0x3793FBC Offset: 0x378FFBC VA: 0x3793FBC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3793FC4 Offset: 0x378FFC4 VA: 0x3793FC4 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3793FCC Offset: 0x378FFCC VA: 0x3793FCC Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3794124 Offset: 0x3790124 VA: 0x3794124 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
