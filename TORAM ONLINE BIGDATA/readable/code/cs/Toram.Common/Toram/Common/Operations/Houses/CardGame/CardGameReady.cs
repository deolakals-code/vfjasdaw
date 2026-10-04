// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses.CardGame
public class CardGameReady : OperationRequestBase // TypeDefIndex: 12275
{
	// Fields
	[CompilerGenerated]
	private CardGameSettingData <Setting>k__BackingField; // 0x20

	// Properties
	public CardGameSettingData Setting { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35EAE70 Offset: 0x35E6E70 VA: 0x35EAE70
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x35EAE78 Offset: 0x35E6E78 VA: 0x35EAE78
	public CardGameSettingData get_Setting() { }

	[CompilerGenerated]
	// RVA: 0x35EAE80 Offset: 0x35E6E80 VA: 0x35EAE80
	public void set_Setting(CardGameSettingData value) { }

	// RVA: 0x35EAE88 Offset: 0x35E6E88 VA: 0x35EAE88 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35EAE90 Offset: 0x35E6E90 VA: 0x35EAE90 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35EAE98 Offset: 0x35E6E98 VA: 0x35EAE98 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x35EB034 Offset: 0x35E7034 VA: 0x35EB034 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
