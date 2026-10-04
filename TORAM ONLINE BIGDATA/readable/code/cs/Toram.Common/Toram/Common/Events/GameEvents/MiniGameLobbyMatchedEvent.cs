// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.GameEvents
public class MiniGameLobbyMatchedEvent : EventSubBase // TypeDefIndex: 12684
{
	// Fields
	[CompilerGenerated]
	private int <LobbyId>k__BackingField; // 0x20
	[CompilerGenerated]
	private bool <LobbyMatched>k__BackingField; // 0x24

	// Properties
	public int LobbyId { get; set; }
	public bool LobbyMatched { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3641624 Offset: 0x363D624 VA: 0x3641624
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x364162C Offset: 0x363D62C VA: 0x364162C
	public int get_LobbyId() { }

	[CompilerGenerated]
	// RVA: 0x3641634 Offset: 0x363D634 VA: 0x3641634
	public void set_LobbyId(int value) { }

	[CompilerGenerated]
	// RVA: 0x364163C Offset: 0x363D63C VA: 0x364163C
	public bool get_LobbyMatched() { }

	[CompilerGenerated]
	// RVA: 0x3641644 Offset: 0x363D644 VA: 0x3641644
	public void set_LobbyMatched(bool value) { }

	// RVA: 0x3641650 Offset: 0x363D650 VA: 0x3641650 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3641658 Offset: 0x363D658 VA: 0x3641658 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3641660 Offset: 0x363D660 VA: 0x3641660
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x3641664 Offset: 0x363D664 VA: 0x3641664
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x3641668 Offset: 0x363D668 VA: 0x3641668 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x36417E0 Offset: 0x363D7E0 VA: 0x36417E0 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
