// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Global.Contents
public class MobaStartMatchingEvent : EventSubBase // TypeDefIndex: 12658
{
	// Fields
	[CompilerGenerated]
	private short <ReturnCode>k__BackingField; // 0x20
	[CompilerGenerated]
	private MobaGameData <Game>k__BackingField; // 0x28
	[CompilerGenerated]
	private byte <PartyGameId>k__BackingField; // 0x30

	// Properties
	public short ReturnCode { get; set; }
	public MobaGameData Game { get; set; }
	public byte PartyGameId { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x363B6AC Offset: 0x36376AC VA: 0x363B6AC
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x363B6B4 Offset: 0x36376B4 VA: 0x363B6B4
	public short get_ReturnCode() { }

	[CompilerGenerated]
	// RVA: 0x363B6BC Offset: 0x36376BC VA: 0x363B6BC
	public void set_ReturnCode(short value) { }

	[CompilerGenerated]
	// RVA: 0x363B6C4 Offset: 0x36376C4 VA: 0x363B6C4
	public MobaGameData get_Game() { }

	[CompilerGenerated]
	// RVA: 0x363B6CC Offset: 0x36376CC VA: 0x363B6CC
	public void set_Game(MobaGameData value) { }

	[CompilerGenerated]
	// RVA: 0x363B6D4 Offset: 0x36376D4 VA: 0x363B6D4
	public byte get_PartyGameId() { }

	[CompilerGenerated]
	// RVA: 0x363B6DC Offset: 0x36376DC VA: 0x363B6DC
	public void set_PartyGameId(byte value) { }

	// RVA: 0x363B6E4 Offset: 0x36376E4 VA: 0x363B6E4 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x363B6EC Offset: 0x36376EC VA: 0x363B6EC Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x363B6F4 Offset: 0x36376F4 VA: 0x363B6F4 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x363B7F4 Offset: 0x36377F4 VA: 0x363B7F4 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
