// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.MiniGame
public class MiniGameLobbyJoinResponse : OperationResponseBase // TypeDefIndex: 12005
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

	// RVA: 0x377577C Offset: 0x377177C VA: 0x377577C
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3775784 Offset: 0x3771784 VA: 0x3775784
	public int get_LobbyId() { }

	[CompilerGenerated]
	// RVA: 0x377578C Offset: 0x377178C VA: 0x377578C
	public void set_LobbyId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3775794 Offset: 0x3771794 VA: 0x3775794
	public bool get_LobbyMatching() { }

	[CompilerGenerated]
	// RVA: 0x377579C Offset: 0x377179C VA: 0x377579C
	public void set_LobbyMatching(bool value) { }

	[CompilerGenerated]
	// RVA: 0x37757A8 Offset: 0x37717A8 VA: 0x37757A8
	public bool get_LobbyMatched() { }

	[CompilerGenerated]
	// RVA: 0x37757B0 Offset: 0x37717B0 VA: 0x37757B0
	public void set_LobbyMatched(bool value) { }

	[CompilerGenerated]
	// RVA: 0x37757BC Offset: 0x37717BC VA: 0x37757BC
	public MemberData[] get_Members() { }

	[CompilerGenerated]
	// RVA: 0x37757C4 Offset: 0x37717C4 VA: 0x37757C4
	public void set_Members(MemberData[] value) { }

	// RVA: 0x37757CC Offset: 0x37717CC VA: 0x37757CC
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x37758BC Offset: 0x37718BC VA: 0x37758BC
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x3775948 Offset: 0x3771948 VA: 0x3775948 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3775950 Offset: 0x3771950 VA: 0x3775950 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3775958 Offset: 0x3771958 VA: 0x3775958 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3775B2C Offset: 0x3771B2C VA: 0x3775B2C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
