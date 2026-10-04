// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Rooms
public class GroupMemberStatusData : UnityHashBase, IRoomMemberStatus // TypeDefIndex: 11285
{
	// Fields
	[CompilerGenerated]
	private byte <ArchetypeType>k__BackingField; // 0x19
	[CompilerGenerated]
	private int <ArchetypeId>k__BackingField; // 0x1C
	[CompilerGenerated]
	private byte <HpRate>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <State>k__BackingField; // 0x21
	[CompilerGenerated]
	private int <TeamId>k__BackingField; // 0x24

	// Properties
	[UnityHash(Code = 55, IsOptional = True)]
	public byte ArchetypeType { get; set; }
	[UnityHash(Code = 74)]
	public int ArchetypeId { get; set; }
	[UnityHash(Code = 46, Default = 100, IsOptional = True)]
	public byte HpRate { get; set; }
	[UnityHash(Code = 44, IsOptional = True)]
	public byte State { get; set; }
	public int TeamId { get; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x36D781C Offset: 0x36D381C VA: 0x36D781C
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x36D7824 Offset: 0x36D3824 VA: 0x36D7824 Slot: 7
	public byte get_ArchetypeType() { }

	[CompilerGenerated]
	// RVA: 0x36D782C Offset: 0x36D382C VA: 0x36D782C
	public void set_ArchetypeType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36D7834 Offset: 0x36D3834 VA: 0x36D7834 Slot: 8
	public int get_ArchetypeId() { }

	[CompilerGenerated]
	// RVA: 0x36D783C Offset: 0x36D383C VA: 0x36D783C
	public void set_ArchetypeId(int value) { }

	[CompilerGenerated]
	// RVA: 0x36D7844 Offset: 0x36D3844 VA: 0x36D7844 Slot: 9
	public byte get_HpRate() { }

	[CompilerGenerated]
	// RVA: 0x36D784C Offset: 0x36D384C VA: 0x36D784C
	public void set_HpRate(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36D7854 Offset: 0x36D3854 VA: 0x36D7854 Slot: 10
	public byte get_State() { }

	[CompilerGenerated]
	// RVA: 0x36D785C Offset: 0x36D385C VA: 0x36D785C
	public void set_State(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36D7864 Offset: 0x36D3864 VA: 0x36D7864 Slot: 11
	public int get_TeamId() { }

	// RVA: 0x36D786C Offset: 0x36D386C VA: 0x36D786C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36D7874 Offset: 0x36D3874 VA: 0x36D7874 Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }

	// RVA: 0x36D7B8C Offset: 0x36D3B8C VA: 0x36D7B8C Slot: 6
	public override Dictionary<object, object> GetValue() { }
}
