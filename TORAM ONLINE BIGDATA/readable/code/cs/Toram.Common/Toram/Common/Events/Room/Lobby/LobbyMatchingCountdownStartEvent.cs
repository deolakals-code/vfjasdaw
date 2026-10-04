// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Room.Lobby
public class LobbyMatchingCountdownStartEvent : EventSubBase // TypeDefIndex: 12768
{
	// Fields
	[CompilerGenerated]
	private int <CountdownSec>k__BackingField; // 0x20

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }
	public int CountdownSec { get; set; }

	// Methods

	// RVA: 0x3654D68 Offset: 0x3650D68 VA: 0x3654D68
	public void .ctor(Dictionary<byte, object> parameters) { }

	// RVA: 0x3654D70 Offset: 0x3650D70 VA: 0x3654D70 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3654D78 Offset: 0x3650D78 VA: 0x3654D78 Slot: 7
	public override byte get_SubCode() { }

	[CompilerGenerated]
	// RVA: 0x3654D80 Offset: 0x3650D80 VA: 0x3654D80
	public int get_CountdownSec() { }

	[CompilerGenerated]
	// RVA: 0x3654D88 Offset: 0x3650D88 VA: 0x3654D88
	public void set_CountdownSec(int value) { }

	// RVA: 0x3654D90 Offset: 0x3650D90 VA: 0x3654D90 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3654EDC Offset: 0x3650EDC VA: 0x3654EDC Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
