// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Room.TreasureHunt
public class TreasureHuntAcquireTreasureEvent : EventSubBase // TypeDefIndex: 12789
{
	// Fields
	[CompilerGenerated]
	private byte[] <TreasureRanks>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <LocalId>k__BackingField; // 0x28
	[CompilerGenerated]
	private byte <Type>k__BackingField; // 0x29

	// Properties
	[PacketClass(Code = 195)]
	public byte[] TreasureRanks { get; set; }
	[PacketClass(Code = 200)]
	public byte LocalId { get; set; }
	[PacketClass(Code = 245)]
	public byte Type { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3659554 Offset: 0x3655554 VA: 0x3659554
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x365955C Offset: 0x365555C VA: 0x365955C
	public byte[] get_TreasureRanks() { }

	[CompilerGenerated]
	// RVA: 0x3659564 Offset: 0x3655564 VA: 0x3659564
	public void set_TreasureRanks(byte[] value) { }

	[CompilerGenerated]
	// RVA: 0x365956C Offset: 0x365556C VA: 0x365956C
	public byte get_LocalId() { }

	[CompilerGenerated]
	// RVA: 0x3659574 Offset: 0x3655574 VA: 0x3659574
	public void set_LocalId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x365957C Offset: 0x365557C VA: 0x365957C
	public byte get_Type() { }

	[CompilerGenerated]
	// RVA: 0x3659584 Offset: 0x3655584 VA: 0x3659584
	public void set_Type(byte value) { }

	// RVA: 0x365958C Offset: 0x365558C VA: 0x365958C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3659594 Offset: 0x3655594 VA: 0x3659594 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x365959C Offset: 0x365559C VA: 0x365959C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x3659674 Offset: 0x3655674 VA: 0x3659674 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
