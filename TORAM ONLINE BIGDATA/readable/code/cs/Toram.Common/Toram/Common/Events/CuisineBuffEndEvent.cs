// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events
public class CuisineBuffEndEvent : PacketBase // TypeDefIndex: 12603
{
	// Fields
	[CompilerGenerated]
	private PlayerStatusData <PlayerStatus>k__BackingField; // 0x20

	// Properties
	[PacketParameter(Code = 180)]
	public PlayerStatusData PlayerStatus { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x362EAFC Offset: 0x362AAFC VA: 0x362EAFC
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x362EB04 Offset: 0x362AB04 VA: 0x362EB04
	public PlayerStatusData get_PlayerStatus() { }

	[CompilerGenerated]
	// RVA: 0x362EB0C Offset: 0x362AB0C VA: 0x362EB0C
	public void set_PlayerStatus(PlayerStatusData value) { }

	// RVA: 0x362EB14 Offset: 0x362AB14 VA: 0x362EB14
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x362EB18 Offset: 0x362AB18 VA: 0x362EB18
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x362EB1C Offset: 0x362AB1C VA: 0x362EB1C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x362EB24 Offset: 0x362AB24 VA: 0x362EB24 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x362EC94 Offset: 0x362AC94 VA: 0x362EC94 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
