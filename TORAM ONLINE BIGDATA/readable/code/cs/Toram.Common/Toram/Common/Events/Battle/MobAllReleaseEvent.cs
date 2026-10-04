// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Battle
public class MobAllReleaseEvent : PacketBase // TypeDefIndex: 12718
{
	// Fields
	[CompilerGenerated]
	private int <ArchetypeId>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <ArchetypeType>k__BackingField; // 0x24

	// Properties
	[PacketParameter(Code = 74)]
	public int ArchetypeId { get; set; }
	[PacketParameter(Code = 55)]
	public byte ArchetypeType { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3649500 Offset: 0x3645500 VA: 0x3649500
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3649508 Offset: 0x3645508 VA: 0x3649508
	public int get_ArchetypeId() { }

	[CompilerGenerated]
	// RVA: 0x3649510 Offset: 0x3645510 VA: 0x3649510
	public void set_ArchetypeId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3649518 Offset: 0x3645518 VA: 0x3649518
	public byte get_ArchetypeType() { }

	[CompilerGenerated]
	// RVA: 0x3649520 Offset: 0x3645520 VA: 0x3649520
	public void set_ArchetypeType(byte value) { }

	// RVA: 0x3649528 Offset: 0x3645528 VA: 0x3649528 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3649530 Offset: 0x3645530 VA: 0x3649530 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x36496D4 Offset: 0x36456D4 VA: 0x36496D4 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
