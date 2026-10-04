// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Loader
public class LoadAvatarCheckResponse : PacketBase // TypeDefIndex: 11543
{
	// Fields
	[CompilerGenerated]
	private int <WaitingPerson>k__BackingField; // 0x20
	[CompilerGenerated]
	private short <ReturnCode>k__BackingField; // 0x24

	// Properties
	public int WaitingPerson { get; set; }
	public short ReturnCode { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x37179E0 Offset: 0x37139E0 VA: 0x37179E0
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x37179E8 Offset: 0x37139E8 VA: 0x37179E8
	public int get_WaitingPerson() { }

	[CompilerGenerated]
	// RVA: 0x37179F0 Offset: 0x37139F0 VA: 0x37179F0
	public void set_WaitingPerson(int value) { }

	[CompilerGenerated]
	// RVA: 0x37179F8 Offset: 0x37139F8 VA: 0x37179F8
	public short get_ReturnCode() { }

	[CompilerGenerated]
	// RVA: 0x3717A00 Offset: 0x3713A00 VA: 0x3717A00
	public void set_ReturnCode(short value) { }

	// RVA: 0x3717A08 Offset: 0x3713A08 VA: 0x3717A08 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3717A10 Offset: 0x3713A10 VA: 0x3717A10 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3717B88 Offset: 0x3713B88 VA: 0x3717B88 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
