// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses
public class HouseBelonginsListResponse : OperationResponseBase // TypeDefIndex: 12162
{
	// Fields
	[CompilerGenerated]
	private byte <BinaryState>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte[] <BelonginsBin>k__BackingField; // 0x28

	// Properties
	public byte BinaryState { get; set; }
	public byte[] BelonginsBin { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x37933AC Offset: 0x378F3AC VA: 0x37933AC
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x37933B4 Offset: 0x378F3B4 VA: 0x37933B4
	public byte get_BinaryState() { }

	[CompilerGenerated]
	// RVA: 0x37933BC Offset: 0x378F3BC VA: 0x37933BC
	public void set_BinaryState(byte value) { }

	[CompilerGenerated]
	// RVA: 0x37933C4 Offset: 0x378F3C4 VA: 0x37933C4
	public byte[] get_BelonginsBin() { }

	[CompilerGenerated]
	// RVA: 0x37933CC Offset: 0x378F3CC VA: 0x37933CC
	public void set_BelonginsBin(byte[] value) { }

	// RVA: 0x37933D4 Offset: 0x378F3D4 VA: 0x37933D4
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x37933D8 Offset: 0x378F3D8 VA: 0x37933D8
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x37933DC Offset: 0x378F3DC VA: 0x37933DC
	public byte[] GetHouseBinary() { }

	// RVA: 0x3793454 Offset: 0x378F454 VA: 0x3793454 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x379345C Offset: 0x378F45C VA: 0x379345C Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3793464 Offset: 0x378F464 VA: 0x3793464 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3793614 Offset: 0x378F614 VA: 0x3793614 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
