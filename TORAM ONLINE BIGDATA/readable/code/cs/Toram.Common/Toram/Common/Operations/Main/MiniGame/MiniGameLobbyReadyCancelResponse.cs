// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.MiniGame
public class MiniGameLobbyReadyCancelResponse : OperationResponseBase // TypeDefIndex: 12006
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

	// RVA: 0x3775C44 Offset: 0x3771C44 VA: 0x3775C44
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3775C4C Offset: 0x3771C4C VA: 0x3775C4C
	public int get_LobbyId() { }

	[CompilerGenerated]
	// RVA: 0x3775C54 Offset: 0x3771C54 VA: 0x3775C54
	public void set_LobbyId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3775C5C Offset: 0x3771C5C VA: 0x3775C5C
	public bool get_LobbyMatching() { }

	[CompilerGenerated]
	// RVA: 0x3775C64 Offset: 0x3771C64 VA: 0x3775C64
	public void set_LobbyMatching(bool value) { }

	[CompilerGenerated]
	// RVA: 0x3775C70 Offset: 0x3771C70 VA: 0x3775C70
	public bool get_LobbyMatched() { }

	[CompilerGenerated]
	// RVA: 0x3775C78 Offset: 0x3771C78 VA: 0x3775C78
	public void set_LobbyMatched(bool value) { }

	[CompilerGenerated]
	// RVA: 0x3775C84 Offset: 0x3771C84 VA: 0x3775C84
	public MemberData[] get_Members() { }

	[CompilerGenerated]
	// RVA: 0x3775C8C Offset: 0x3771C8C VA: 0x3775C8C
	public void set_Members(MemberData[] value) { }

	// RVA: 0x3775C94 Offset: 0x3771C94 VA: 0x3775C94
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x3775D84 Offset: 0x3771D84 VA: 0x3775D84
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x3775E10 Offset: 0x3771E10 VA: 0x3775E10 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3775E18 Offset: 0x3771E18 VA: 0x3775E18 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3775E20 Offset: 0x3771E20 VA: 0x3775E20 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3775FF4 Offset: 0x3771FF4 VA: 0x3775FF4 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
