// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.GameEvents
public class MiniGameLobbyMemberStateEvent : EventSubBase // TypeDefIndex: 12686
{
	// Fields
	[CompilerGenerated]
	private int <LobbyId>k__BackingField; // 0x20
	[CompilerGenerated]
	private bool <LobbyMatching>k__BackingField; // 0x24
	[CompilerGenerated]
	private bool <LobbyMatched>k__BackingField; // 0x25
	[CompilerGenerated]
	private MemberData[] <Members>k__BackingField; // 0x28

	// Properties
	public int LobbyId { get; set; }
	public bool LobbyMatching { get; set; }
	public bool LobbyMatched { get; set; }
	public MemberData[] Members { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3641CF4 Offset: 0x363DCF4 VA: 0x3641CF4
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3641CFC Offset: 0x363DCFC VA: 0x3641CFC
	public int get_LobbyId() { }

	[CompilerGenerated]
	// RVA: 0x3641D04 Offset: 0x363DD04 VA: 0x3641D04
	public void set_LobbyId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3641D0C Offset: 0x363DD0C VA: 0x3641D0C
	public bool get_LobbyMatching() { }

	[CompilerGenerated]
	// RVA: 0x3641D14 Offset: 0x363DD14 VA: 0x3641D14
	public void set_LobbyMatching(bool value) { }

	[CompilerGenerated]
	// RVA: 0x3641D20 Offset: 0x363DD20 VA: 0x3641D20
	public bool get_LobbyMatched() { }

	[CompilerGenerated]
	// RVA: 0x3641D28 Offset: 0x363DD28 VA: 0x3641D28
	public void set_LobbyMatched(bool value) { }

	[CompilerGenerated]
	// RVA: 0x3641D34 Offset: 0x363DD34 VA: 0x3641D34
	public MemberData[] get_Members() { }

	[CompilerGenerated]
	// RVA: 0x3641D3C Offset: 0x363DD3C VA: 0x3641D3C
	public void set_Members(MemberData[] value) { }

	// RVA: 0x3641D44 Offset: 0x363DD44 VA: 0x3641D44 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3641D4C Offset: 0x363DD4C VA: 0x3641D4C Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3641D54 Offset: 0x363DD54 VA: 0x3641D54
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x3641E44 Offset: 0x363DE44 VA: 0x3641E44
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x3641ED0 Offset: 0x363DED0 VA: 0x3641ED0 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x36420A4 Offset: 0x363E0A4 VA: 0x36420A4 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
