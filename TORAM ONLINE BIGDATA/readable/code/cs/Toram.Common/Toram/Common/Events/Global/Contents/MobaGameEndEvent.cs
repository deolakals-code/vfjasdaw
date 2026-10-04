// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Global.Contents
public class MobaGameEndEvent : EventSubBase // TypeDefIndex: 12654
{
	// Fields
	[CompilerGenerated]
	private byte <MatchingGameId>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <MatchingGameType>k__BackingField; // 0x21

	// Properties
	public byte MatchingGameId { get; set; }
	public byte MatchingGameType { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x363A8F0 Offset: 0x36368F0 VA: 0x363A8F0
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x363A8F8 Offset: 0x36368F8 VA: 0x363A8F8
	public byte get_MatchingGameId() { }

	[CompilerGenerated]
	// RVA: 0x363A900 Offset: 0x3636900 VA: 0x363A900
	public void set_MatchingGameId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x363A908 Offset: 0x3636908 VA: 0x363A908
	public byte get_MatchingGameType() { }

	[CompilerGenerated]
	// RVA: 0x363A910 Offset: 0x3636910 VA: 0x363A910
	public void set_MatchingGameType(byte value) { }

	// RVA: 0x363A918 Offset: 0x3636918 VA: 0x363A918 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x363A920 Offset: 0x3636920 VA: 0x363A920 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x363A928 Offset: 0x3636928 VA: 0x363A928 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x363A9EC Offset: 0x36369EC VA: 0x363A9EC Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
