// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.MiniGame
public class MiniGameLobbyReadyResponse : OperationResponseBase // TypeDefIndex: 12007
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

	// RVA: 0x377610C Offset: 0x377210C VA: 0x377610C
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3776114 Offset: 0x3772114 VA: 0x3776114
	public int get_LobbyId() { }

	[CompilerGenerated]
	// RVA: 0x377611C Offset: 0x377211C VA: 0x377611C
	public void set_LobbyId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3776124 Offset: 0x3772124 VA: 0x3776124
	public bool get_LobbyMatching() { }

	[CompilerGenerated]
	// RVA: 0x377612C Offset: 0x377212C VA: 0x377612C
	public void set_LobbyMatching(bool value) { }

	[CompilerGenerated]
	// RVA: 0x3776138 Offset: 0x3772138 VA: 0x3776138
	public bool get_LobbyMatched() { }

	[CompilerGenerated]
	// RVA: 0x3776140 Offset: 0x3772140 VA: 0x3776140
	public void set_LobbyMatched(bool value) { }

	[CompilerGenerated]
	// RVA: 0x377614C Offset: 0x377214C VA: 0x377614C
	public MemberData[] get_Members() { }

	[CompilerGenerated]
	// RVA: 0x3776154 Offset: 0x3772154 VA: 0x3776154
	public void set_Members(MemberData[] value) { }

	// RVA: 0x377615C Offset: 0x377215C VA: 0x377615C
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x377624C Offset: 0x377224C VA: 0x377624C
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x37762D8 Offset: 0x37722D8 VA: 0x37762D8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x37762E0 Offset: 0x37722E0 VA: 0x37762E0 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x37762E8 Offset: 0x37722E8 VA: 0x37762E8 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x37764BC Offset: 0x37724BC VA: 0x37764BC Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
