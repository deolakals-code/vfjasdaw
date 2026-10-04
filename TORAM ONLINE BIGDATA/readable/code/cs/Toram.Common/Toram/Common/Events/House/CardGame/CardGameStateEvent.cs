// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.House.CardGame
public class CardGameStateEvent : EventSubBase // TypeDefIndex: 12836
{
	// Fields
	[CompilerGenerated]
	private CardGameSettingData <Setting>k__BackingField; // 0x20
	[CompilerGenerated]
	private CardGameMemberData[] <Members>k__BackingField; // 0x28

	// Properties
	public CardGameSettingData Setting { get; set; }
	public CardGameMemberData[] Members { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3665108 Offset: 0x3661108 VA: 0x3665108
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3665110 Offset: 0x3661110 VA: 0x3665110
	public CardGameSettingData get_Setting() { }

	[CompilerGenerated]
	// RVA: 0x3665118 Offset: 0x3661118 VA: 0x3665118
	public void set_Setting(CardGameSettingData value) { }

	[CompilerGenerated]
	// RVA: 0x3665120 Offset: 0x3661120 VA: 0x3665120
	public CardGameMemberData[] get_Members() { }

	[CompilerGenerated]
	// RVA: 0x3665128 Offset: 0x3661128 VA: 0x3665128
	public void set_Members(CardGameMemberData[] value) { }

	// RVA: 0x3665130 Offset: 0x3661130 VA: 0x3665130 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3665138 Offset: 0x3661138 VA: 0x3665138 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3665140 Offset: 0x3661140 VA: 0x3665140 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3665384 Offset: 0x3661384 VA: 0x3665384 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
