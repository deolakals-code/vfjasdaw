// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.House.CardGame
public class CardGameGiveupEvent : EventSubBase // TypeDefIndex: 12831
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

	// RVA: 0x3664068 Offset: 0x3660068 VA: 0x3664068
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3664070 Offset: 0x3660070 VA: 0x3664070
	public CardGameSettingData get_Setting() { }

	[CompilerGenerated]
	// RVA: 0x3664078 Offset: 0x3660078 VA: 0x3664078
	public void set_Setting(CardGameSettingData value) { }

	[CompilerGenerated]
	// RVA: 0x3664080 Offset: 0x3660080 VA: 0x3664080
	public CardGameMemberData[] get_Members() { }

	[CompilerGenerated]
	// RVA: 0x3664088 Offset: 0x3660088 VA: 0x3664088
	public void set_Members(CardGameMemberData[] value) { }

	// RVA: 0x3664090 Offset: 0x3660090 VA: 0x3664090 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3664098 Offset: 0x3660098 VA: 0x3664098 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x36640A0 Offset: 0x36600A0 VA: 0x36640A0 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x36642E4 Offset: 0x36602E4 VA: 0x36642E4 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
