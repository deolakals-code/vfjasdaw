// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Battle
public class UpdateBossScoreEvent : PacketBase // TypeDefIndex: 12710
{
	// Fields
	[CompilerGenerated]
	private int <ArchetypeId>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <Type>k__BackingField; // 0x24
	[CompilerGenerated]
	private long <Val>k__BackingField; // 0x28
	[CompilerGenerated]
	private byte <Flag>k__BackingField; // 0x30
	[CompilerGenerated]
	private int <Uid>k__BackingField; // 0x34

	// Properties
	[PacketParameter(Code = 74)]
	public int ArchetypeId { get; set; }
	[PacketParameter(Code = 245)]
	public byte Type { get; set; }
	[PacketParameter(Code = 195)]
	public long Val { get; set; }
	[PacketParameter(Code = 43)]
	public byte Flag { get; set; }
	[PacketParameter(Code = 88)]
	public int Uid { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3646E30 Offset: 0x3642E30 VA: 0x3646E30
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3646E38 Offset: 0x3642E38 VA: 0x3646E38
	public int get_ArchetypeId() { }

	[CompilerGenerated]
	// RVA: 0x3646E40 Offset: 0x3642E40 VA: 0x3646E40
	public void set_ArchetypeId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3646E48 Offset: 0x3642E48 VA: 0x3646E48
	public byte get_Type() { }

	[CompilerGenerated]
	// RVA: 0x3646E50 Offset: 0x3642E50 VA: 0x3646E50
	public void set_Type(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3646E58 Offset: 0x3642E58 VA: 0x3646E58
	public long get_Val() { }

	[CompilerGenerated]
	// RVA: 0x3646E60 Offset: 0x3642E60 VA: 0x3646E60
	public void set_Val(long value) { }

	[CompilerGenerated]
	// RVA: 0x3646E68 Offset: 0x3642E68 VA: 0x3646E68
	public byte get_Flag() { }

	[CompilerGenerated]
	// RVA: 0x3646E70 Offset: 0x3642E70 VA: 0x3646E70
	public void set_Flag(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3646E78 Offset: 0x3642E78 VA: 0x3646E78
	public int get_Uid() { }

	[CompilerGenerated]
	// RVA: 0x3646E80 Offset: 0x3642E80 VA: 0x3646E80
	public void set_Uid(int value) { }

	// RVA: 0x3646E88 Offset: 0x3642E88 VA: 0x3646E88 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3646E90 Offset: 0x3642E90 VA: 0x3646E90 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x36470F0 Offset: 0x36430F0 VA: 0x36470F0 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
