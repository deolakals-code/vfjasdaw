// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Systems
public class SystemBanEvent : PacketBase // TypeDefIndex: 12732
{
	// Fields
	[CompilerGenerated]
	private int <AvatarUuid>k__BackingField; // 0x20
	[CompilerGenerated]
	private OffenderData <Offender>k__BackingField; // 0x28

	// Properties
	public int AvatarUuid { get; set; }
	public OffenderData Offender { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x364CAFC Offset: 0x3648AFC VA: 0x364CAFC
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x364CB04 Offset: 0x3648B04 VA: 0x364CB04
	public int get_AvatarUuid() { }

	[CompilerGenerated]
	// RVA: 0x364CB0C Offset: 0x3648B0C VA: 0x364CB0C
	public void set_AvatarUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x364CB14 Offset: 0x3648B14 VA: 0x364CB14
	public OffenderData get_Offender() { }

	[CompilerGenerated]
	// RVA: 0x364CB1C Offset: 0x3648B1C VA: 0x364CB1C
	public void set_Offender(OffenderData value) { }

	// RVA: 0x364CB24 Offset: 0x3648B24 VA: 0x364CB24 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x364CB2C Offset: 0x3648B2C VA: 0x364CB2C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x364CD18 Offset: 0x3648D18 VA: 0x364CD18 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
