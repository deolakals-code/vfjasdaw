// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Battle
public class AbnormalStateEndEvent : PacketBase // TypeDefIndex: 12712
{
	// Fields
	[CompilerGenerated]
	private int <AvatarUuid>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <ArchetypeType>k__BackingField; // 0x24
	[CompilerGenerated]
	private byte[] <AbnormalState>k__BackingField; // 0x28
	[CompilerGenerated]
	private byte[] <AbnormalLocalId>k__BackingField; // 0x30
	[CompilerGenerated]
	private byte <AbnormalEndType>k__BackingField; // 0x38
	[CompilerGenerated]
	private GameStatusData <GameStatus>k__BackingField; // 0x40

	// Properties
	[PacketParameter(Code = 1)]
	public int AvatarUuid { get; set; }
	[PacketParameter(Code = 55)]
	public byte ArchetypeType { get; set; }
	[PacketParameter(Code = 204)]
	public byte[] AbnormalState { get; set; }
	[PacketParameter(Code = 108)]
	public byte[] AbnormalLocalId { get; set; }
	[PacketParameter(Code = 195)]
	public byte AbnormalEndType { get; set; }
	[PacketParameter(Code = 70, IsOptional = True)]
	public GameStatusData GameStatus { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3647808 Offset: 0x3643808 VA: 0x3647808
	public void .ctor() { }

	// RVA: 0x3647810 Offset: 0x3643810 VA: 0x3647810
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3647818 Offset: 0x3643818 VA: 0x3647818
	public int get_AvatarUuid() { }

	[CompilerGenerated]
	// RVA: 0x3647820 Offset: 0x3643820 VA: 0x3647820
	public void set_AvatarUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x3647828 Offset: 0x3643828 VA: 0x3647828
	public byte get_ArchetypeType() { }

	[CompilerGenerated]
	// RVA: 0x3647830 Offset: 0x3643830 VA: 0x3647830
	public void set_ArchetypeType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3647838 Offset: 0x3643838 VA: 0x3647838
	public byte[] get_AbnormalState() { }

	[CompilerGenerated]
	// RVA: 0x3647840 Offset: 0x3643840 VA: 0x3647840
	public void set_AbnormalState(byte[] value) { }

	[CompilerGenerated]
	// RVA: 0x3647848 Offset: 0x3643848 VA: 0x3647848
	public byte[] get_AbnormalLocalId() { }

	[CompilerGenerated]
	// RVA: 0x3647850 Offset: 0x3643850 VA: 0x3647850
	public void set_AbnormalLocalId(byte[] value) { }

	[CompilerGenerated]
	// RVA: 0x3647858 Offset: 0x3643858 VA: 0x3647858
	public byte get_AbnormalEndType() { }

	[CompilerGenerated]
	// RVA: 0x3647860 Offset: 0x3643860 VA: 0x3647860
	public void set_AbnormalEndType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3647868 Offset: 0x3643868 VA: 0x3647868
	public GameStatusData get_GameStatus() { }

	[CompilerGenerated]
	// RVA: 0x3647870 Offset: 0x3643870 VA: 0x3647870
	public void set_GameStatus(GameStatusData value) { }

	// RVA: 0x3647878 Offset: 0x3643878 VA: 0x3647878 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3647880 Offset: 0x3643880 VA: 0x3647880 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3647BD4 Offset: 0x3643BD4 VA: 0x3647BD4 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
