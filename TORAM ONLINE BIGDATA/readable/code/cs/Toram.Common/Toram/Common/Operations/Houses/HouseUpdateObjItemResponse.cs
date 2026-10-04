// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses
public class HouseUpdateObjItemResponse : OperationResponseBase // TypeDefIndex: 12192
{
	// Fields
	[CompilerGenerated]
	private int <ObjId>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <Flag>k__BackingField; // 0x24
	[CompilerGenerated]
	private int[] <Binary>k__BackingField; // 0x28

	// Properties
	public int ObjId { get; set; }
	public byte Flag { get; set; }
	public int[] Binary { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35DE638 Offset: 0x35DA638 VA: 0x35DE638
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x35DE640 Offset: 0x35DA640 VA: 0x35DE640
	public int get_ObjId() { }

	[CompilerGenerated]
	// RVA: 0x35DE648 Offset: 0x35DA648 VA: 0x35DE648
	public void set_ObjId(int value) { }

	[CompilerGenerated]
	// RVA: 0x35DE650 Offset: 0x35DA650 VA: 0x35DE650
	public byte get_Flag() { }

	[CompilerGenerated]
	// RVA: 0x35DE658 Offset: 0x35DA658 VA: 0x35DE658
	public void set_Flag(byte value) { }

	[CompilerGenerated]
	// RVA: 0x35DE660 Offset: 0x35DA660 VA: 0x35DE660
	public int[] get_Binary() { }

	[CompilerGenerated]
	// RVA: 0x35DE668 Offset: 0x35DA668 VA: 0x35DE668
	public void set_Binary(int[] value) { }

	// RVA: 0x35DE670 Offset: 0x35DA670 VA: 0x35DE670 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35DE678 Offset: 0x35DA678 VA: 0x35DE678 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35DE680 Offset: 0x35DA680 VA: 0x35DE680 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x35DE85C Offset: 0x35DA85C VA: 0x35DE85C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
