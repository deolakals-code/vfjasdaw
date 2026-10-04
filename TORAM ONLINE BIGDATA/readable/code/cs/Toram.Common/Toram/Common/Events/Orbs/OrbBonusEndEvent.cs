// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Orbs
public class OrbBonusEndEvent : PacketBase // TypeDefIndex: 12648
{
	// Fields
	[CompilerGenerated]
	private OrbBonusData <BonusData>k__BackingField; // 0x20

	// Properties
	[PacketClass(Code = 206, IsOptional = True)]
	public OrbBonusData BonusData { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x363925C Offset: 0x363525C VA: 0x363925C
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3639264 Offset: 0x3635264 VA: 0x3639264
	public OrbBonusData get_BonusData() { }

	[CompilerGenerated]
	// RVA: 0x363926C Offset: 0x363526C VA: 0x363926C
	public void set_BonusData(OrbBonusData value) { }

	// RVA: 0x3639274 Offset: 0x3635274 VA: 0x3639274
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x3639394 Offset: 0x3635394 VA: 0x3639394
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x3639410 Offset: 0x3635410 VA: 0x3639410 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3639418 Offset: 0x3635418 VA: 0x3639418 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x36394B0 Offset: 0x36354B0 VA: 0x36394B0 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
