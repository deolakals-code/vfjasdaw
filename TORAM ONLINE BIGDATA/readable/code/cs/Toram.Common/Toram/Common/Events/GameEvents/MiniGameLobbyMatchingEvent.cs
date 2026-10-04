// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.GameEvents
public class MiniGameLobbyMatchingEvent : EventSubBase // TypeDefIndex: 12685
{
	// Fields
	[CompilerGenerated]
	private int <LobbyId>k__BackingField; // 0x20
	[CompilerGenerated]
	private bool <LobbyMatching>k__BackingField; // 0x24
	[CompilerGenerated]
	private MemberData[] <Members>k__BackingField; // 0x28

	// Properties
	public int LobbyId { get; set; }
	public bool LobbyMatching { get; set; }
	public MemberData[] Members { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x36418BC Offset: 0x363D8BC VA: 0x36418BC
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x36418C4 Offset: 0x363D8C4 VA: 0x36418C4
	public int get_LobbyId() { }

	[CompilerGenerated]
	// RVA: 0x36418CC Offset: 0x363D8CC VA: 0x36418CC
	public void set_LobbyId(int value) { }

	[CompilerGenerated]
	// RVA: 0x36418D4 Offset: 0x363D8D4 VA: 0x36418D4
	public bool get_LobbyMatching() { }

	[CompilerGenerated]
	// RVA: 0x36418DC Offset: 0x363D8DC VA: 0x36418DC
	public void set_LobbyMatching(bool value) { }

	[CompilerGenerated]
	// RVA: 0x36418E8 Offset: 0x363D8E8 VA: 0x36418E8
	public MemberData[] get_Members() { }

	[CompilerGenerated]
	// RVA: 0x36418F0 Offset: 0x363D8F0 VA: 0x36418F0
	public void set_Members(MemberData[] value) { }

	// RVA: 0x36418F8 Offset: 0x363D8F8 VA: 0x36418F8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3641900 Offset: 0x363D900 VA: 0x3641900 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3641908 Offset: 0x363D908 VA: 0x3641908
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x36419F8 Offset: 0x363D9F8 VA: 0x36419F8
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x3641A84 Offset: 0x363DA84 VA: 0x3641A84 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3641C0C Offset: 0x363DC0C VA: 0x3641C0C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
