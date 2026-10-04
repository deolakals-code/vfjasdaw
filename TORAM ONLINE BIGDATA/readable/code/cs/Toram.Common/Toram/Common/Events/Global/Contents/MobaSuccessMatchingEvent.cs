// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Global.Contents
public class MobaSuccessMatchingEvent : EventSubBase // TypeDefIndex: 12659
{
	// Fields
	[CompilerGenerated]
	private byte <MatchingGameId>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <MatchingGameType>k__BackingField; // 0x21
	[CompilerGenerated]
	private int <LobbyUniqueId>k__BackingField; // 0x24
	[CompilerGenerated]
	private byte <PartyGameId>k__BackingField; // 0x28

	// Properties
	public byte MatchingGameId { get; set; }
	public byte MatchingGameType { get; set; }
	public int LobbyUniqueId { get; set; }
	public byte PartyGameId { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x363BA40 Offset: 0x3637A40 VA: 0x363BA40
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x363BA48 Offset: 0x3637A48 VA: 0x363BA48
	public byte get_MatchingGameId() { }

	[CompilerGenerated]
	// RVA: 0x363BA50 Offset: 0x3637A50 VA: 0x363BA50
	public void set_MatchingGameId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x363BA58 Offset: 0x3637A58 VA: 0x363BA58
	public byte get_MatchingGameType() { }

	[CompilerGenerated]
	// RVA: 0x363BA60 Offset: 0x3637A60 VA: 0x363BA60
	public void set_MatchingGameType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x363BA68 Offset: 0x3637A68 VA: 0x363BA68
	public int get_LobbyUniqueId() { }

	[CompilerGenerated]
	// RVA: 0x363BA70 Offset: 0x3637A70 VA: 0x363BA70
	public void set_LobbyUniqueId(int value) { }

	[CompilerGenerated]
	// RVA: 0x363BA78 Offset: 0x3637A78 VA: 0x363BA78
	public byte get_PartyGameId() { }

	[CompilerGenerated]
	// RVA: 0x363BA80 Offset: 0x3637A80 VA: 0x363BA80
	public void set_PartyGameId(byte value) { }

	// RVA: 0x363BA88 Offset: 0x3637A88 VA: 0x363BA88 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x363BA90 Offset: 0x3637A90 VA: 0x363BA90 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x363BA98 Offset: 0x3637A98 VA: 0x363BA98 Slot: 3
	public override string ToString() { }

	// RVA: 0x363BB70 Offset: 0x3637B70 VA: 0x363BB70 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x363BCA0 Offset: 0x3637CA0 VA: 0x363BCA0 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
