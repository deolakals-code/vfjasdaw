// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events
public class WeeklyTrophyEvent : PacketBase // TypeDefIndex: 12636
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

	// RVA: 0x36369E4 Offset: 0x36329E4 VA: 0x36369E4
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x36369EC Offset: 0x36329EC VA: 0x36369EC
	public int get_AvatarUuid() { }

	[CompilerGenerated]
	// RVA: 0x36369F4 Offset: 0x36329F4 VA: 0x36369F4
	public void set_AvatarUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x36369FC Offset: 0x36329FC VA: 0x36369FC
	public bool get_InitFlag() { }

	[CompilerGenerated]
	// RVA: 0x3636A04 Offset: 0x3632A04 VA: 0x3636A04
	public void set_InitFlag(bool value) { }

	[CompilerGenerated]
	// RVA: 0x3636A10 Offset: 0x3632A10 VA: 0x3636A10
	public TrophyData[] get_TrophyList() { }

	[CompilerGenerated]
	// RVA: 0x3636A18 Offset: 0x3632A18 VA: 0x3636A18
	public void set_TrophyList(TrophyData[] value) { }

	// RVA: 0x3636A20 Offset: 0x3632A20 VA: 0x3636A20
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x3636B10 Offset: 0x3632B10 VA: 0x3636B10
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x3636B9C Offset: 0x3632B9C VA: 0x3636B9C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3636BA4 Offset: 0x3632BA4 VA: 0x3636BA4 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3636D58 Offset: 0x3632D58 VA: 0x3636D58 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
