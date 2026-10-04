// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Contents.Moba
public class MobaJoinGameData : BinaryBase // TypeDefIndex: 11219
{
	// Fields
	[CompilerGenerated]
	private byte <GameType>k__BackingField; // 0x19
	[CompilerGenerated]
	private byte <SelectGameId>k__BackingField; // 0x1A
	[CompilerGenerated]
	private byte <PartyGameId>k__BackingField; // 0x1B
	[CompilerGenerated]
	private byte <MatchingGameId>k__BackingField; // 0x1C

	// Properties
	public byte GameType { get; set; }
	public byte SelectGameId { get; set; }
	public byte PartyGameId { get; set; }
	public byte MatchingGameId { get; set; }

	// Methods

	// RVA: 0x35DC8A0 Offset: 0x35D88A0 VA: 0x35DC8A0
	public void .ctor() { }

	// RVA: 0x35DC8A8 Offset: 0x35D88A8 VA: 0x35DC8A8
	public void .ctor(byte[] binary) { }

	[CompilerGenerated]
	// RVA: 0x35DC8B0 Offset: 0x35D88B0 VA: 0x35DC8B0
	public byte get_GameType() { }

	[CompilerGenerated]
	// RVA: 0x35DC8B8 Offset: 0x35D88B8 VA: 0x35DC8B8
	public void set_GameType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x35DC8C0 Offset: 0x35D88C0 VA: 0x35DC8C0
	public byte get_SelectGameId() { }

	[CompilerGenerated]
	// RVA: 0x35DC8C8 Offset: 0x35D88C8 VA: 0x35DC8C8
	public void set_SelectGameId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x35DC8D0 Offset: 0x35D88D0 VA: 0x35DC8D0
	public byte get_PartyGameId() { }

	[CompilerGenerated]
	// RVA: 0x35DC8D8 Offset: 0x35D88D8 VA: 0x35DC8D8
	public void set_PartyGameId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x35DC8E0 Offset: 0x35D88E0 VA: 0x35DC8E0
	public byte get_MatchingGameId() { }

	[CompilerGenerated]
	// RVA: 0x35DC8E8 Offset: 0x35D88E8 VA: 0x35DC8E8
	public void set_MatchingGameId(byte value) { }

	// RVA: 0x35DC8F0 Offset: 0x35D88F0 VA: 0x35DC8F0 Slot: 3
	public override string ToString() { }

	// RVA: 0x35DCAE0 Offset: 0x35D8AE0 VA: 0x35DCAE0 Slot: 7
	protected override void GetBinary(MemoryStream ms, bool isThrow) { }

	// RVA: 0x35DCB3C Offset: 0x35D8B3C VA: 0x35DCB3C Slot: 4
	protected override bool SetValue(MemoryStream ms, bool isThrow) { }
}
