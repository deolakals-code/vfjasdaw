// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Guilds.GuildStaff
public class RegistletChangeGemCartEquipResponse : OperationResponseBase // TypeDefIndex: 12416
{
	// Fields
	[CompilerGenerated]
	private GemCartEquipData[] <UpdateEquips>k__BackingField; // 0x20
	[CompilerGenerated]
	private PlayerStatusData <PlayerStatus>k__BackingField; // 0x28

	// Properties
	[PacketClass(Code = 15)]
	public GemCartEquipData[] UpdateEquips { get; set; }
	[PacketClass(Code = 2)]
	public PlayerStatusData PlayerStatus { get; set; }
	public override byte SubCode { get; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3603EA4 Offset: 0x35FFEA4 VA: 0x3603EA4
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3603EAC Offset: 0x35FFEAC VA: 0x3603EAC
	public GemCartEquipData[] get_UpdateEquips() { }

	[CompilerGenerated]
	// RVA: 0x3603EB4 Offset: 0x35FFEB4 VA: 0x3603EB4
	public void set_UpdateEquips(GemCartEquipData[] value) { }

	[CompilerGenerated]
	// RVA: 0x3603EBC Offset: 0x35FFEBC VA: 0x3603EBC
	public PlayerStatusData get_PlayerStatus() { }

	[CompilerGenerated]
	// RVA: 0x3603EC4 Offset: 0x35FFEC4 VA: 0x3603EC4
	public void set_PlayerStatus(PlayerStatusData value) { }

	// RVA: 0x3603ECC Offset: 0x35FFECC VA: 0x3603ECC Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3603ED4 Offset: 0x35FFED4 VA: 0x3603ED4 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3603EDC Offset: 0x35FFEDC VA: 0x3603EDC Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x3603F98 Offset: 0x35FFF98 VA: 0x3603F98 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
