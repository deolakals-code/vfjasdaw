// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Rooms
public class RaidRoomSetting : BinaryBase // TypeDefIndex: 11289
{
	// Fields
	[CompilerGenerated]
	private short <Level>k__BackingField; // 0x1A
	[CompilerGenerated]
	private short <Flag>k__BackingField; // 0x1C
	[CompilerGenerated]
	private byte <MatchingState>k__BackingField; // 0x1E

	// Properties
	public short Level { get; set; }
	public short Flag { get; set; }
	public byte MatchingState { get; set; }
	public bool IsAnnihilated { get; }
	public bool IsSecondPartyManaged { get; }
	public bool IsSecondPartyAccepting { get; }
	public bool EnableSecondParty { get; }
	public bool EnableMatching { get; }
	public bool IsRoomEnd { get; }

	// Methods

	// RVA: 0x36D8098 Offset: 0x36D4098 VA: 0x36D8098
	public void .ctor(byte[] binary) { }

	[CompilerGenerated]
	// RVA: 0x36D80A0 Offset: 0x36D40A0 VA: 0x36D80A0
	public short get_Level() { }

	[CompilerGenerated]
	// RVA: 0x36D80A8 Offset: 0x36D40A8 VA: 0x36D80A8
	private void set_Level(short value) { }

	[CompilerGenerated]
	// RVA: 0x36D80B0 Offset: 0x36D40B0 VA: 0x36D80B0
	public short get_Flag() { }

	[CompilerGenerated]
	// RVA: 0x36D80B8 Offset: 0x36D40B8 VA: 0x36D80B8
	private void set_Flag(short value) { }

	[CompilerGenerated]
	// RVA: 0x36D80C0 Offset: 0x36D40C0 VA: 0x36D80C0
	public byte get_MatchingState() { }

	[CompilerGenerated]
	// RVA: 0x36D80C8 Offset: 0x36D40C8 VA: 0x36D80C8
	private void set_MatchingState(byte value) { }

	// RVA: 0x36D80D0 Offset: 0x36D40D0 VA: 0x36D80D0
	public bool get_IsAnnihilated() { }

	// RVA: 0x36D80DC Offset: 0x36D40DC VA: 0x36D80DC
	public bool get_IsSecondPartyManaged() { }

	// RVA: 0x36D80E8 Offset: 0x36D40E8 VA: 0x36D80E8
	public bool get_IsSecondPartyAccepting() { }

	// RVA: 0x36D80F4 Offset: 0x36D40F4 VA: 0x36D80F4
	public bool get_EnableSecondParty() { }

	// RVA: 0x36D8100 Offset: 0x36D4100 VA: 0x36D8100
	public bool get_EnableMatching() { }

	// RVA: 0x36D810C Offset: 0x36D410C VA: 0x36D810C
	public bool get_IsRoomEnd() { }

	// RVA: 0x36D8118 Offset: 0x36D4118 VA: 0x36D8118 Slot: 4
	protected override bool SetValue(MemoryStream ms, bool isThrow) { }

	// RVA: 0x36D8238 Offset: 0x36D4238 VA: 0x36D8238 Slot: 7
	protected override void GetBinary(MemoryStream ms, bool isThrow) { }
}
