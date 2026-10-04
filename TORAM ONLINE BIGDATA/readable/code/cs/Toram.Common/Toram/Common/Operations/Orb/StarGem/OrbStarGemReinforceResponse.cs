// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Orb.StarGem
public class OrbStarGemReinforceResponse : OperationResponseBase // TypeDefIndex: 11838
{
	// Fields
	[CompilerGenerated]
	private StarGemData <UpdateStarGem>k__BackingField; // 0x20
	[CompilerGenerated]
	private StarGemData <DeleteStarGem>k__BackingField; // 0x28
	[CompilerGenerated]
	private PlayerStatusData <PlayerStatus>k__BackingField; // 0x30

	// Properties
	public StarGemData UpdateStarGem { get; set; }
	public StarGemData DeleteStarGem { get; set; }
	public PlayerStatusData PlayerStatus { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x37542C8 Offset: 0x37502C8 VA: 0x37542C8
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x37542D0 Offset: 0x37502D0 VA: 0x37542D0
	public StarGemData get_UpdateStarGem() { }

	[CompilerGenerated]
	// RVA: 0x37542D8 Offset: 0x37502D8 VA: 0x37542D8
	public void set_UpdateStarGem(StarGemData value) { }

	[CompilerGenerated]
	// RVA: 0x37542E0 Offset: 0x37502E0 VA: 0x37542E0
	public StarGemData get_DeleteStarGem() { }

	[CompilerGenerated]
	// RVA: 0x37542E8 Offset: 0x37502E8 VA: 0x37542E8
	public void set_DeleteStarGem(StarGemData value) { }

	[CompilerGenerated]
	// RVA: 0x37542F0 Offset: 0x37502F0 VA: 0x37542F0
	public PlayerStatusData get_PlayerStatus() { }

	[CompilerGenerated]
	// RVA: 0x37542F8 Offset: 0x37502F8 VA: 0x37542F8
	public void set_PlayerStatus(PlayerStatusData value) { }

	// RVA: 0x3754300 Offset: 0x3750300 VA: 0x3754300
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x3754578 Offset: 0x3750578 VA: 0x3754578
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x375464C Offset: 0x375064C VA: 0x375464C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3754654 Offset: 0x3750654 VA: 0x3754654 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x375465C Offset: 0x375065C VA: 0x375465C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x37546F4 Offset: 0x37506F4 VA: 0x37546F4 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
