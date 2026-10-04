// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Global.Contents
public class MobaPartyStateEvent : EventSubBase // TypeDefIndex: 12656
{
	// Fields
	[CompilerGenerated]
	private byte <GameId>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <PartyId>k__BackingField; // 0x24
	[CompilerGenerated]
	private byte <PartyGameId>k__BackingField; // 0x28
	[CompilerGenerated]
	private Dictionary<int, byte> <Members>k__BackingField; // 0x30

	// Properties
	public byte GameId { get; set; }
	public int PartyId { get; set; }
	public byte PartyGameId { get; set; }
	public Dictionary<int, byte> Members { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x363AE8C Offset: 0x3636E8C VA: 0x363AE8C
	public void .ctor() { }

	// RVA: 0x363AE94 Offset: 0x3636E94 VA: 0x363AE94
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x363AE9C Offset: 0x3636E9C VA: 0x363AE9C
	public byte get_GameId() { }

	[CompilerGenerated]
	// RVA: 0x363AEA4 Offset: 0x3636EA4 VA: 0x363AEA4
	public void set_GameId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x363AEAC Offset: 0x3636EAC VA: 0x363AEAC
	public int get_PartyId() { }

	[CompilerGenerated]
	// RVA: 0x363AEB4 Offset: 0x3636EB4 VA: 0x363AEB4
	public void set_PartyId(int value) { }

	[CompilerGenerated]
	// RVA: 0x363AEBC Offset: 0x3636EBC VA: 0x363AEBC
	public byte get_PartyGameId() { }

	[CompilerGenerated]
	// RVA: 0x363AEC4 Offset: 0x3636EC4 VA: 0x363AEC4
	public void set_PartyGameId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x363AECC Offset: 0x3636ECC VA: 0x363AECC
	public Dictionary<int, byte> get_Members() { }

	[CompilerGenerated]
	// RVA: 0x363AED4 Offset: 0x3636ED4 VA: 0x363AED4
	public void set_Members(Dictionary<int, byte> value) { }

	// RVA: 0x363AEDC Offset: 0x3636EDC VA: 0x363AEDC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x363AEE4 Offset: 0x3636EE4 VA: 0x363AEE4 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x363AEEC Offset: 0x3636EEC VA: 0x363AEEC Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x363B00C Offset: 0x363700C VA: 0x363B00C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
