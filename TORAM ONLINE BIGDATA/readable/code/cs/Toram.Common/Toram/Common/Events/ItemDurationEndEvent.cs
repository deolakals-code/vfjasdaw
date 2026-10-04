// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events
public class ItemDurationEndEvent : PacketBase // TypeDefIndex: 12607
{
	// Fields
	[CompilerGenerated]
	private byte <ArchetypeType>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <ArchetypeId>k__BackingField; // 0x24
	[CompilerGenerated]
	private PlayerStatusData <PlayerStatus>k__BackingField; // 0x28

	// Properties
	public byte ArchetypeType { get; set; }
	public int ArchetypeId { get; set; }
	public PlayerStatusData PlayerStatus { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x362F43C Offset: 0x362B43C VA: 0x362F43C
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x362F444 Offset: 0x362B444 VA: 0x362F444
	public byte get_ArchetypeType() { }

	[CompilerGenerated]
	// RVA: 0x362F44C Offset: 0x362B44C VA: 0x362F44C
	public void set_ArchetypeType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x362F454 Offset: 0x362B454 VA: 0x362F454
	public int get_ArchetypeId() { }

	[CompilerGenerated]
	// RVA: 0x362F45C Offset: 0x362B45C VA: 0x362F45C
	public void set_ArchetypeId(int value) { }

	[CompilerGenerated]
	// RVA: 0x362F464 Offset: 0x362B464 VA: 0x362F464
	public PlayerStatusData get_PlayerStatus() { }

	[CompilerGenerated]
	// RVA: 0x362F46C Offset: 0x362B46C VA: 0x362F46C
	public void set_PlayerStatus(PlayerStatusData value) { }

	// RVA: 0x362F474 Offset: 0x362B474 VA: 0x362F474 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x362F47C Offset: 0x362B47C VA: 0x362F47C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x362F5B4 Offset: 0x362B5B4 VA: 0x362F5B4 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
