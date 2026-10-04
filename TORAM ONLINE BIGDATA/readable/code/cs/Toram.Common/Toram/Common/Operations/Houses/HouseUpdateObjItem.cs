// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses
public class HouseUpdateObjItem : OperationRequestBase // TypeDefIndex: 12191
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

	// RVA: 0x35DE3B8 Offset: 0x35DA3B8 VA: 0x35DE3B8
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x35DE3C0 Offset: 0x35DA3C0 VA: 0x35DE3C0
	public int get_ObjId() { }

	[CompilerGenerated]
	// RVA: 0x35DE3C8 Offset: 0x35DA3C8 VA: 0x35DE3C8
	public void set_ObjId(int value) { }

	[CompilerGenerated]
	// RVA: 0x35DE3D0 Offset: 0x35DA3D0 VA: 0x35DE3D0
	public byte get_Flag() { }

	[CompilerGenerated]
	// RVA: 0x35DE3D8 Offset: 0x35DA3D8 VA: 0x35DE3D8
	public void set_Flag(byte value) { }

	[CompilerGenerated]
	// RVA: 0x35DE3E0 Offset: 0x35DA3E0 VA: 0x35DE3E0
	public int[] get_Binary() { }

	[CompilerGenerated]
	// RVA: 0x35DE3E8 Offset: 0x35DA3E8 VA: 0x35DE3E8
	public void set_Binary(int[] value) { }

	// RVA: 0x35DE3F0 Offset: 0x35DA3F0 VA: 0x35DE3F0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35DE3F8 Offset: 0x35DA3F8 VA: 0x35DE3F8 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35DE400 Offset: 0x35DA400 VA: 0x35DE400 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x35DE548 Offset: 0x35DA548 VA: 0x35DE548 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
