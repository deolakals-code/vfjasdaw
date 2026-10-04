// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Rooms
public class RoomMemberStatusData : BinaryBase, IRoomMemberStatus // TypeDefIndex: 11292
{
	// Fields
	[CompilerGenerated]
	private byte <ArchetypeType>k__BackingField; // 0x19
	[CompilerGenerated]
	private int <ArchetypeId>k__BackingField; // 0x1C
	[CompilerGenerated]
	private int <TeamId>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <HpRate>k__BackingField; // 0x24
	[CompilerGenerated]
	private byte <State>k__BackingField; // 0x25

	// Properties
	public byte ArchetypeType { get; set; }
	public int ArchetypeId { get; set; }
	public int TeamId { get; set; }
	public byte HpRate { get; set; }
	public byte State { get; set; }

	// Methods

	// RVA: 0x36D8818 Offset: 0x36D4818 VA: 0x36D8818
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x36D8820 Offset: 0x36D4820 VA: 0x36D8820 Slot: 8
	public byte get_ArchetypeType() { }

	[CompilerGenerated]
	// RVA: 0x36D8828 Offset: 0x36D4828 VA: 0x36D8828
	private void set_ArchetypeType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36D8830 Offset: 0x36D4830 VA: 0x36D8830 Slot: 9
	public int get_ArchetypeId() { }

	[CompilerGenerated]
	// RVA: 0x36D8838 Offset: 0x36D4838 VA: 0x36D8838
	private void set_ArchetypeId(int value) { }

	[CompilerGenerated]
	// RVA: 0x36D8840 Offset: 0x36D4840 VA: 0x36D8840 Slot: 12
	public int get_TeamId() { }

	[CompilerGenerated]
	// RVA: 0x36D8848 Offset: 0x36D4848 VA: 0x36D8848
	private void set_TeamId(int value) { }

	[CompilerGenerated]
	// RVA: 0x36D8850 Offset: 0x36D4850 VA: 0x36D8850 Slot: 10
	public byte get_HpRate() { }

	[CompilerGenerated]
	// RVA: 0x36D8858 Offset: 0x36D4858 VA: 0x36D8858
	private void set_HpRate(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36D8860 Offset: 0x36D4860 VA: 0x36D8860 Slot: 11
	public byte get_State() { }

	[CompilerGenerated]
	// RVA: 0x36D8868 Offset: 0x36D4868 VA: 0x36D8868
	private void set_State(byte value) { }

	// RVA: 0x36D8870 Offset: 0x36D4870 VA: 0x36D8870 Slot: 4
	protected override bool SetValue(MemoryStream ms, bool isThrow) { }

	// RVA: 0x36D89B8 Offset: 0x36D49B8 VA: 0x36D89B8 Slot: 7
	protected override void GetBinary(MemoryStream ms, bool isThrow) { }
}
