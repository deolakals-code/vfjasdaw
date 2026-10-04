// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Orb.ItemUse
public class OrbItemRespawnResponse : OperationResponseBase // TypeDefIndex: 11860
{
	// Fields
	[CompilerGenerated]
	private byte <OrbUseResult>k__BackingField; // 0x20
	[CompilerGenerated]
	private OrbItemData <OrbItem>k__BackingField; // 0x28
	[CompilerGenerated]
	private GameStatusData <GameStatus>k__BackingField; // 0x30
	[CompilerGenerated]
	private GameStatusData <PetGameStatus>k__BackingField; // 0x38

	// Properties
	[PacketParameter(Code = 13)]
	public byte OrbUseResult { get; set; }
	[PacketClass(Code = 231, IsOptional = True)]
	public OrbItemData OrbItem { get; set; }
	[PacketClass(Code = 70, IsOptional = True)]
	public GameStatusData GameStatus { get; set; }
	[PacketClass(Code = 181, IsOptional = True)]
	public GameStatusData PetGameStatus { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3758D60 Offset: 0x3754D60 VA: 0x3758D60
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3758D68 Offset: 0x3754D68 VA: 0x3758D68
	public byte get_OrbUseResult() { }

	[CompilerGenerated]
	// RVA: 0x3758D70 Offset: 0x3754D70 VA: 0x3758D70
	public void set_OrbUseResult(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3758D78 Offset: 0x3754D78 VA: 0x3758D78
	public OrbItemData get_OrbItem() { }

	[CompilerGenerated]
	// RVA: 0x3758D80 Offset: 0x3754D80 VA: 0x3758D80
	public void set_OrbItem(OrbItemData value) { }

	[CompilerGenerated]
	// RVA: 0x3758D88 Offset: 0x3754D88 VA: 0x3758D88
	public GameStatusData get_GameStatus() { }

	[CompilerGenerated]
	// RVA: 0x3758D90 Offset: 0x3754D90 VA: 0x3758D90
	public void set_GameStatus(GameStatusData value) { }

	[CompilerGenerated]
	// RVA: 0x3758D98 Offset: 0x3754D98 VA: 0x3758D98
	public GameStatusData get_PetGameStatus() { }

	[CompilerGenerated]
	// RVA: 0x3758DA0 Offset: 0x3754DA0 VA: 0x3758DA0
	public void set_PetGameStatus(GameStatusData value) { }

	// RVA: 0x3758DA8 Offset: 0x3754DA8 VA: 0x3758DA8
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x3759038 Offset: 0x3755038 VA: 0x3759038
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x375910C Offset: 0x375510C VA: 0x375910C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3759114 Offset: 0x3755114 VA: 0x3759114 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x375911C Offset: 0x375511C VA: 0x375911C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x375924C Offset: 0x375524C VA: 0x375924C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
