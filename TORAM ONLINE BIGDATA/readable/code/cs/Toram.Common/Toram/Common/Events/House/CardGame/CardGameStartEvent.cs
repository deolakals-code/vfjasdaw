// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.House.CardGame
public class CardGameStartEvent : EventSubBase // TypeDefIndex: 12835
{
	// Fields
	[CompilerGenerated]
	private CardGameSettingData <Setting>k__BackingField; // 0x20
	[CompilerGenerated]
	private CardGameMemberData[] <Members>k__BackingField; // 0x28
	[CompilerGenerated]
	private CardGameTurnTableData <TableData>k__BackingField; // 0x30

	// Properties
	public CardGameSettingData Setting { get; set; }
	public CardGameMemberData[] Members { get; set; }
	public CardGameTurnTableData TableData { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3664CD4 Offset: 0x3660CD4 VA: 0x3664CD4
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3664CDC Offset: 0x3660CDC VA: 0x3664CDC
	public CardGameSettingData get_Setting() { }

	[CompilerGenerated]
	// RVA: 0x3664CE4 Offset: 0x3660CE4 VA: 0x3664CE4
	public void set_Setting(CardGameSettingData value) { }

	[CompilerGenerated]
	// RVA: 0x3664CEC Offset: 0x3660CEC VA: 0x3664CEC
	public CardGameMemberData[] get_Members() { }

	[CompilerGenerated]
	// RVA: 0x3664CF4 Offset: 0x3660CF4 VA: 0x3664CF4
	public void set_Members(CardGameMemberData[] value) { }

	[CompilerGenerated]
	// RVA: 0x3664CFC Offset: 0x3660CFC VA: 0x3664CFC
	public CardGameTurnTableData get_TableData() { }

	[CompilerGenerated]
	// RVA: 0x3664D04 Offset: 0x3660D04 VA: 0x3664D04
	public void set_TableData(CardGameTurnTableData value) { }

	// RVA: 0x3664D0C Offset: 0x3660D0C VA: 0x3664D0C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3664D14 Offset: 0x3660D14 VA: 0x3664D14 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3664D1C Offset: 0x3660D1C VA: 0x3664D1C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3665018 Offset: 0x3661018 VA: 0x3665018 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
