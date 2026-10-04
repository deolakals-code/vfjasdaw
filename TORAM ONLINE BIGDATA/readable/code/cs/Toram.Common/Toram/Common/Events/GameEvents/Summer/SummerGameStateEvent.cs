// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.GameEvents.Summer
public class SummerGameStateEvent : EventSubBase // TypeDefIndex: 12693
{
	// Fields
	[CompilerGenerated]
	private byte <GameState>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <Point>k__BackingField; // 0x24
	[CompilerGenerated]
	private byte <JoinMemberNum>k__BackingField; // 0x28
	[CompilerGenerated]
	private byte <MemberNum>k__BackingField; // 0x29
	[CompilerGenerated]
	private byte <WaveId>k__BackingField; // 0x2A
	[CompilerGenerated]
	private byte <AliveMemberNum>k__BackingField; // 0x2B

	// Properties
	public byte GameState { get; set; }
	public int Point { get; set; }
	public byte JoinMemberNum { get; set; }
	public byte MemberNum { get; set; }
	public byte WaveId { get; set; }
	public byte AliveMemberNum { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3643410 Offset: 0x363F410 VA: 0x3643410
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3643418 Offset: 0x363F418 VA: 0x3643418
	public byte get_GameState() { }

	[CompilerGenerated]
	// RVA: 0x3643420 Offset: 0x363F420 VA: 0x3643420
	public void set_GameState(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3643428 Offset: 0x363F428 VA: 0x3643428
	public int get_Point() { }

	[CompilerGenerated]
	// RVA: 0x3643430 Offset: 0x363F430 VA: 0x3643430
	public void set_Point(int value) { }

	[CompilerGenerated]
	// RVA: 0x3643438 Offset: 0x363F438 VA: 0x3643438
	public byte get_JoinMemberNum() { }

	[CompilerGenerated]
	// RVA: 0x3643440 Offset: 0x363F440 VA: 0x3643440
	public void set_JoinMemberNum(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3643448 Offset: 0x363F448 VA: 0x3643448
	public byte get_MemberNum() { }

	[CompilerGenerated]
	// RVA: 0x3643450 Offset: 0x363F450 VA: 0x3643450
	public void set_MemberNum(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3643458 Offset: 0x363F458 VA: 0x3643458
	public byte get_WaveId() { }

	[CompilerGenerated]
	// RVA: 0x3643460 Offset: 0x363F460 VA: 0x3643460
	public void set_WaveId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3643468 Offset: 0x363F468 VA: 0x3643468
	public byte get_AliveMemberNum() { }

	[CompilerGenerated]
	// RVA: 0x3643470 Offset: 0x363F470 VA: 0x3643470
	public void set_AliveMemberNum(byte value) { }

	// RVA: 0x3643478 Offset: 0x363F478 VA: 0x3643478 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3643480 Offset: 0x363F480 VA: 0x3643480 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3643488 Offset: 0x363F488 VA: 0x3643488 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3643718 Offset: 0x363F718 VA: 0x3643718 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
