// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses.Cuisine
public class CuisineDineOut : OperationRequestBase // TypeDefIndex: 12259
{
	// Fields
	[CompilerGenerated]
	private int <OtherAid>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <Id>k__BackingField; // 0x24
	[CompilerGenerated]
	private byte <Lv>k__BackingField; // 0x28
	[CompilerGenerated]
	private byte <Type>k__BackingField; // 0x29

	// Properties
	[PacketParameter(Code = 1)]
	public int OtherAid { get; set; }
	[PacketParameter(Code = 200)]
	public int Id { get; set; }
	[PacketParameter(Code = 101)]
	public byte Lv { get; set; }
	[PacketParameter(Code = 245)]
	public byte Type { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35E869C Offset: 0x35E469C VA: 0x35E869C
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x35E86A4 Offset: 0x35E46A4 VA: 0x35E86A4
	public int get_OtherAid() { }

	[CompilerGenerated]
	// RVA: 0x35E86AC Offset: 0x35E46AC VA: 0x35E86AC
	public void set_OtherAid(int value) { }

	[CompilerGenerated]
	// RVA: 0x35E86B4 Offset: 0x35E46B4 VA: 0x35E86B4
	public int get_Id() { }

	[CompilerGenerated]
	// RVA: 0x35E86BC Offset: 0x35E46BC VA: 0x35E86BC
	public void set_Id(int value) { }

	[CompilerGenerated]
	// RVA: 0x35E86C4 Offset: 0x35E46C4 VA: 0x35E86C4
	public byte get_Lv() { }

	[CompilerGenerated]
	// RVA: 0x35E86CC Offset: 0x35E46CC VA: 0x35E86CC
	public void set_Lv(byte value) { }

	[CompilerGenerated]
	// RVA: 0x35E86D4 Offset: 0x35E46D4 VA: 0x35E86D4
	public byte get_Type() { }

	[CompilerGenerated]
	// RVA: 0x35E86DC Offset: 0x35E46DC VA: 0x35E86DC
	public void set_Type(byte value) { }

	// RVA: 0x35E86E4 Offset: 0x35E46E4 VA: 0x35E86E4
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x35E86E8 Offset: 0x35E46E8 VA: 0x35E86E8
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x35E86EC Offset: 0x35E46EC VA: 0x35E86EC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35E86F4 Offset: 0x35E46F4 VA: 0x35E86F4 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35E86FC Offset: 0x35E46FC VA: 0x35E86FC Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x35E8938 Offset: 0x35E4938 VA: 0x35E8938 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
