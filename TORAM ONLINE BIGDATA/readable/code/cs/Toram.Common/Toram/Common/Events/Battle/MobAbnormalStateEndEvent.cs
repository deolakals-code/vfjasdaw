// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Battle
public class MobAbnormalStateEndEvent : PacketBase // TypeDefIndex: 12717
{
	// Fields
	[CompilerGenerated]
	private int <AvatarUuid>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <ArchetypeType>k__BackingField; // 0x24
	[CompilerGenerated]
	private MobIdData <MobIdData>k__BackingField; // 0x28
	[CompilerGenerated]
	private byte <AbnormalState>k__BackingField; // 0x30
	[CompilerGenerated]
	private byte <AbnormalEndType>k__BackingField; // 0x31

	// Properties
	[PacketParameter(Code = 1)]
	public int AvatarUuid { get; set; }
	[PacketParameter(Code = 55)]
	public byte ArchetypeType { get; set; }
	[PacketParameter(Code = 76)]
	public MobIdData MobIdData { get; set; }
	[PacketParameter(Code = 204)]
	public byte AbnormalState { get; set; }
	[PacketParameter(Code = 195)]
	public byte AbnormalEndType { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3649030 Offset: 0x3645030 VA: 0x3649030
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3649038 Offset: 0x3645038 VA: 0x3649038
	public int get_AvatarUuid() { }

	[CompilerGenerated]
	// RVA: 0x3649040 Offset: 0x3645040 VA: 0x3649040
	public void set_AvatarUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x3649048 Offset: 0x3645048 VA: 0x3649048
	public byte get_ArchetypeType() { }

	[CompilerGenerated]
	// RVA: 0x3649050 Offset: 0x3645050 VA: 0x3649050
	public void set_ArchetypeType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3649058 Offset: 0x3645058 VA: 0x3649058
	public MobIdData get_MobIdData() { }

	[CompilerGenerated]
	// RVA: 0x3649060 Offset: 0x3645060 VA: 0x3649060
	public void set_MobIdData(MobIdData value) { }

	[CompilerGenerated]
	// RVA: 0x3649068 Offset: 0x3645068 VA: 0x3649068
	public byte get_AbnormalState() { }

	[CompilerGenerated]
	// RVA: 0x3649070 Offset: 0x3645070 VA: 0x3649070
	public void set_AbnormalState(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3649078 Offset: 0x3645078 VA: 0x3649078
	public byte get_AbnormalEndType() { }

	[CompilerGenerated]
	// RVA: 0x3649080 Offset: 0x3645080 VA: 0x3649080
	public void set_AbnormalEndType(byte value) { }

	// RVA: 0x3649088 Offset: 0x3645088 VA: 0x3649088 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3649090 Offset: 0x3645090 VA: 0x3649090 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3649374 Offset: 0x3645374 VA: 0x3649374 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
