// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.House.CardGame
public class CardGameKickoutEvent : EventSubBase // TypeDefIndex: 12832
{
	// Fields
	[CompilerGenerated]
	private CardGameSettingData <Setting>k__BackingField; // 0x20

	// Properties
	public CardGameSettingData Setting { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x36643A8 Offset: 0x36603A8 VA: 0x36643A8
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x36643B0 Offset: 0x36603B0 VA: 0x36643B0
	public CardGameSettingData get_Setting() { }

	[CompilerGenerated]
	// RVA: 0x36643B8 Offset: 0x36603B8 VA: 0x36643B8
	public void set_Setting(CardGameSettingData value) { }

	// RVA: 0x36643C0 Offset: 0x36603C0 VA: 0x36643C0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36643C8 Offset: 0x36603C8 VA: 0x36643C8 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x36643D0 Offset: 0x36603D0 VA: 0x36643D0 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x366456C Offset: 0x366056C VA: 0x366456C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
