// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events
public class MarketUpdateEvent : PacketBase // TypeDefIndex: 12631
{
	// Fields
	[CompilerGenerated]
	private int <AvatarUuid>k__BackingField; // 0x20
	[CompilerGenerated]
	private MarketResultData <MarketResult>k__BackingField; // 0x28

	// Properties
	[PacketParameter(Code = 1)]
	public int AvatarUuid { get; set; }
	[PacketClass(Code = 84, IsOptional = True)]
	public MarketResultData MarketResult { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3635A60 Offset: 0x3631A60 VA: 0x3635A60
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3635A68 Offset: 0x3631A68 VA: 0x3635A68
	public int get_AvatarUuid() { }

	[CompilerGenerated]
	// RVA: 0x3635A70 Offset: 0x3631A70 VA: 0x3635A70
	public void set_AvatarUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x3635A78 Offset: 0x3631A78 VA: 0x3635A78
	public MarketResultData get_MarketResult() { }

	[CompilerGenerated]
	// RVA: 0x3635A80 Offset: 0x3631A80 VA: 0x3635A80
	public void set_MarketResult(MarketResultData value) { }

	// RVA: 0x3635A88 Offset: 0x3631A88 VA: 0x3635A88
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x3635BA8 Offset: 0x3631BA8 VA: 0x3635BA8
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x3635C24 Offset: 0x3631C24 VA: 0x3635C24 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3635C2C Offset: 0x3631C2C VA: 0x3635C2C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3635D5C Offset: 0x3631D5C VA: 0x3635D5C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
