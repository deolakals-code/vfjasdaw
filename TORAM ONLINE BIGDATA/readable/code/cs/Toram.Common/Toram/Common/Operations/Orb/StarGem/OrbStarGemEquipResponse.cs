// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Orb.StarGem
public class OrbStarGemEquipResponse : OperationResponseBase // TypeDefIndex: 11832
{
	// Fields
	[CompilerGenerated]
	private StarGemEquipData[] <StarGemEquips>k__BackingField; // 0x20
	[CompilerGenerated]
	private StarGemData[] <StarGems>k__BackingField; // 0x28
	[CompilerGenerated]
	private PlayerStatusData <PlayerStatus>k__BackingField; // 0x30

	// Properties
	public StarGemEquipData[] StarGemEquips { get; set; }
	public StarGemData[] StarGems { get; set; }
	public PlayerStatusData PlayerStatus { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3753238 Offset: 0x374F238 VA: 0x3753238
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3753240 Offset: 0x374F240 VA: 0x3753240
	public StarGemEquipData[] get_StarGemEquips() { }

	[CompilerGenerated]
	// RVA: 0x3753248 Offset: 0x374F248 VA: 0x3753248
	public void set_StarGemEquips(StarGemEquipData[] value) { }

	[CompilerGenerated]
	// RVA: 0x3753250 Offset: 0x374F250 VA: 0x3753250
	public StarGemData[] get_StarGems() { }

	[CompilerGenerated]
	// RVA: 0x3753258 Offset: 0x374F258 VA: 0x3753258
	public void set_StarGems(StarGemData[] value) { }

	[CompilerGenerated]
	// RVA: 0x3753260 Offset: 0x374F260 VA: 0x3753260
	public PlayerStatusData get_PlayerStatus() { }

	[CompilerGenerated]
	// RVA: 0x3753268 Offset: 0x374F268 VA: 0x3753268
	public void set_PlayerStatus(PlayerStatusData value) { }

	// RVA: 0x3753270 Offset: 0x374F270 VA: 0x3753270
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x37534A4 Offset: 0x374F4A4 VA: 0x37534A4
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x3753598 Offset: 0x374F598 VA: 0x3753598 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x37535A0 Offset: 0x374F5A0 VA: 0x37535A0 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x37535A8 Offset: 0x374F5A8 VA: 0x37535A8 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3753640 Offset: 0x374F640 VA: 0x3753640 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
