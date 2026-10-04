// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Global.Contents
public class MobaCancelMatchingEvent : EventSubBase // TypeDefIndex: 12657
{
	// Fields
	[CompilerGenerated]
	private byte <MatchingGameId>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <MatchingGameType>k__BackingField; // 0x21
	[CompilerGenerated]
	private byte <PartyGameId>k__BackingField; // 0x22
	[CompilerGenerated]
	private int <LobbyUniqueId>k__BackingField; // 0x24
	[CompilerGenerated]
	private short <ReturnCode>k__BackingField; // 0x28

	// Properties
	public byte MatchingGameId { get; set; }
	public byte MatchingGameType { get; set; }
	public byte PartyGameId { get; set; }
	public int LobbyUniqueId { get; set; }
	public short ReturnCode { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x363B270 Offset: 0x3637270 VA: 0x363B270
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x363B278 Offset: 0x3637278 VA: 0x363B278
	public byte get_MatchingGameId() { }

	[CompilerGenerated]
	// RVA: 0x363B280 Offset: 0x3637280 VA: 0x363B280
	public void set_MatchingGameId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x363B288 Offset: 0x3637288 VA: 0x363B288
	public byte get_MatchingGameType() { }

	[CompilerGenerated]
	// RVA: 0x363B290 Offset: 0x3637290 VA: 0x363B290
	public void set_MatchingGameType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x363B298 Offset: 0x3637298 VA: 0x363B298
	public byte get_PartyGameId() { }

	[CompilerGenerated]
	// RVA: 0x363B2A0 Offset: 0x36372A0 VA: 0x363B2A0
	public void set_PartyGameId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x363B2A8 Offset: 0x36372A8 VA: 0x363B2A8
	public int get_LobbyUniqueId() { }

	[CompilerGenerated]
	// RVA: 0x363B2B0 Offset: 0x36372B0 VA: 0x363B2B0
	public void set_LobbyUniqueId(int value) { }

	[CompilerGenerated]
	// RVA: 0x363B2B8 Offset: 0x36372B8 VA: 0x363B2B8
	public short get_ReturnCode() { }

	[CompilerGenerated]
	// RVA: 0x363B2C0 Offset: 0x36372C0 VA: 0x363B2C0
	public void set_ReturnCode(short value) { }

	// RVA: 0x363B2C8 Offset: 0x36372C8 VA: 0x363B2C8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x363B2D0 Offset: 0x36372D0 VA: 0x363B2D0 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x363B2D8 Offset: 0x36372D8 VA: 0x363B2D8 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x363B44C Offset: 0x363744C VA: 0x363B44C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
