// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses.CardGame
public class CardGameSettingUpdate : OperationRequestBase // TypeDefIndex: 12276
{
	// Fields
	[CompilerGenerated]
	private CardGameSettingData <Setting>k__BackingField; // 0x20

	// Properties
	public CardGameSettingData Setting { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35EB0BC Offset: 0x35E70BC VA: 0x35EB0BC
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x35EB0C4 Offset: 0x35E70C4 VA: 0x35EB0C4
	public CardGameSettingData get_Setting() { }

	[CompilerGenerated]
	// RVA: 0x35EB0CC Offset: 0x35E70CC VA: 0x35EB0CC
	public void set_Setting(CardGameSettingData value) { }

	// RVA: 0x35EB0D4 Offset: 0x35E70D4 VA: 0x35EB0D4 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35EB0DC Offset: 0x35E70DC VA: 0x35EB0DC Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35EB0E4 Offset: 0x35E70E4 VA: 0x35EB0E4 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x35EB280 Offset: 0x35E7280 VA: 0x35EB280 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
