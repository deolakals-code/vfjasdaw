// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events
public class TrophyEvent : PacketBase // TypeDefIndex: 12635
{
	// Fields
	[CompilerGenerated]
	private int <AvatarUuid>k__BackingField; // 0x20
	[CompilerGenerated]
	private Dictionary<int, byte> <TrophyData>k__BackingField; // 0x28

	// Properties
	[PacketParameter(Code = 1)]
	public int AvatarUuid { get; set; }
	[PacketParameter(Code = 162, IsOptional = True)]
	public Dictionary<int, byte> TrophyData { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3636708 Offset: 0x3632708 VA: 0x3636708
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3636710 Offset: 0x3632710 VA: 0x3636710
	public int get_AvatarUuid() { }

	[CompilerGenerated]
	// RVA: 0x3636718 Offset: 0x3632718 VA: 0x3636718
	public void set_AvatarUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x3636720 Offset: 0x3632720 VA: 0x3636720
	public Dictionary<int, byte> get_TrophyData() { }

	[CompilerGenerated]
	// RVA: 0x3636728 Offset: 0x3632728 VA: 0x3636728
	public void set_TrophyData(Dictionary<int, byte> value) { }

	// RVA: 0x3636730 Offset: 0x3632730 VA: 0x3636730 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3636738 Offset: 0x3632738 VA: 0x3636738 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x36368F8 Offset: 0x36328F8 VA: 0x36368F8 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
