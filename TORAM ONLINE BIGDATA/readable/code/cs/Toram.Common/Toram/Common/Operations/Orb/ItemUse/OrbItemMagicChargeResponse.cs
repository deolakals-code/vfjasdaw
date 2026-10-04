// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Orb.ItemUse
public class OrbItemMagicChargeResponse : OperationResponseBase // TypeDefIndex: 11858
{
	// Fields
	[CompilerGenerated]
	private byte <OrbUseResult>k__BackingField; // 0x20
	[CompilerGenerated]
	private OrbItemData <OrbItem>k__BackingField; // 0x28
	[CompilerGenerated]
	private AvatarGameStatusData <AvatarStatus>k__BackingField; // 0x30

	// Properties
	[PacketParameter(Code = 13)]
	public byte OrbUseResult { get; set; }
	[PacketClass(Code = 231, IsOptional = True)]
	public OrbItemData OrbItem { get; set; }
	[PacketClass(Code = 201, IsOptional = True)]
	public AvatarGameStatusData AvatarStatus { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3758884 Offset: 0x3754884 VA: 0x3758884
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x375888C Offset: 0x375488C VA: 0x375888C
	public byte get_OrbUseResult() { }

	[CompilerGenerated]
	// RVA: 0x3758894 Offset: 0x3754894 VA: 0x3758894
	public void set_OrbUseResult(byte value) { }

	[CompilerGenerated]
	// RVA: 0x375889C Offset: 0x375489C VA: 0x375889C
	public OrbItemData get_OrbItem() { }

	[CompilerGenerated]
	// RVA: 0x37588A4 Offset: 0x37548A4 VA: 0x37588A4
	public void set_OrbItem(OrbItemData value) { }

	[CompilerGenerated]
	// RVA: 0x37588AC Offset: 0x37548AC VA: 0x37588AC
	public AvatarGameStatusData get_AvatarStatus() { }

	[CompilerGenerated]
	// RVA: 0x37588B4 Offset: 0x37548B4 VA: 0x37588B4
	public void set_AvatarStatus(AvatarGameStatusData value) { }

	// RVA: 0x37588BC Offset: 0x37548BC VA: 0x37588BC
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x3758AA4 Offset: 0x3754AA4 VA: 0x3758AA4
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x3758B4C Offset: 0x3754B4C VA: 0x3758B4C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3758B54 Offset: 0x3754B54 VA: 0x3758B54 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3758B5C Offset: 0x3754B5C VA: 0x3758B5C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3758C8C Offset: 0x3754C8C VA: 0x3758C8C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
