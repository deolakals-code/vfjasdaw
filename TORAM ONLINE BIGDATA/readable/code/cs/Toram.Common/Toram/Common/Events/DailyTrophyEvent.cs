// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events
public class DailyTrophyEvent : PacketBase // TypeDefIndex: 12625
{
	// Fields
	[CompilerGenerated]
	private int <AvatarUuid>k__BackingField; // 0x20
	[CompilerGenerated]
	private bool <InitFlag>k__BackingField; // 0x24
	[CompilerGenerated]
	private TrophyData[] <TrophyList>k__BackingField; // 0x28

	// Properties
	[PacketParameter(Code = 1)]
	public int AvatarUuid { get; set; }
	[PacketParameter(Code = 43, IsOptional = True)]
	public bool InitFlag { get; set; }
	[PacketClass(Code = 162, IsOptional = True)]
	public TrophyData[] TrophyList { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3633C40 Offset: 0x362FC40 VA: 0x3633C40
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3633C48 Offset: 0x362FC48 VA: 0x3633C48
	public int get_AvatarUuid() { }

	[CompilerGenerated]
	// RVA: 0x3633C50 Offset: 0x362FC50 VA: 0x3633C50
	public void set_AvatarUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x3633C58 Offset: 0x362FC58 VA: 0x3633C58
	public bool get_InitFlag() { }

	[CompilerGenerated]
	// RVA: 0x3633C60 Offset: 0x362FC60 VA: 0x3633C60
	public void set_InitFlag(bool value) { }

	[CompilerGenerated]
	// RVA: 0x3633C6C Offset: 0x362FC6C VA: 0x3633C6C
	public TrophyData[] get_TrophyList() { }

	[CompilerGenerated]
	// RVA: 0x3633C74 Offset: 0x362FC74 VA: 0x3633C74
	public void set_TrophyList(TrophyData[] value) { }

	// RVA: 0x3633C7C Offset: 0x362FC7C VA: 0x3633C7C
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x3633D6C Offset: 0x362FD6C VA: 0x3633D6C
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x3633DF8 Offset: 0x362FDF8 VA: 0x3633DF8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3633E00 Offset: 0x362FE00 VA: 0x3633E00 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3633FB4 Offset: 0x362FFB4 VA: 0x3633FB4 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
