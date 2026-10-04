// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Battle
public class MobKilledEvent : PacketBase // TypeDefIndex: 12719
{
	// Fields
	[CompilerGenerated]
	private int <ArchetypeId>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <ArchetypeType>k__BackingField; // 0x24
	[CompilerGenerated]
	private MobIdData[] <MobIds>k__BackingField; // 0x28

	// Properties
	[PacketParameter(Code = 74)]
	public int ArchetypeId { get; set; }
	[PacketParameter(Code = 55)]
	public byte ArchetypeType { get; set; }
	[PacketClass(Code = 89, IsOptional = True)]
	public MobIdData[] MobIds { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x36497E8 Offset: 0x36457E8 VA: 0x36497E8
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x36497F0 Offset: 0x36457F0 VA: 0x36497F0
	public int get_ArchetypeId() { }

	[CompilerGenerated]
	// RVA: 0x36497F8 Offset: 0x36457F8 VA: 0x36497F8
	public void set_ArchetypeId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3649800 Offset: 0x3645800 VA: 0x3649800
	public byte get_ArchetypeType() { }

	[CompilerGenerated]
	// RVA: 0x3649808 Offset: 0x3645808 VA: 0x3649808
	public void set_ArchetypeType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3649810 Offset: 0x3645810 VA: 0x3649810
	public MobIdData[] get_MobIds() { }

	[CompilerGenerated]
	// RVA: 0x3649818 Offset: 0x3645818 VA: 0x3649818
	public void set_MobIds(MobIdData[] value) { }

	// RVA: 0x3649820 Offset: 0x3645820 VA: 0x3649820
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x3649920 Offset: 0x3645920 VA: 0x3649920
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x36499AC Offset: 0x36459AC VA: 0x36499AC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36499B4 Offset: 0x36459B4 VA: 0x36499B4 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3649B68 Offset: 0x3645B68 VA: 0x3649B68 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
