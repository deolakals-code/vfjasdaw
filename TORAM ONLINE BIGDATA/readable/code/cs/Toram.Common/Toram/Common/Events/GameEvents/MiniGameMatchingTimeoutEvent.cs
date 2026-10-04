// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.GameEvents
public class MiniGameMatchingTimeoutEvent : EventSubBase // TypeDefIndex: 12688
{
	// Fields
	[CompilerGenerated]
	private int <TeamId>k__BackingField; // 0x20
	[CompilerGenerated]
	private bool <LobbyMatching>k__BackingField; // 0x24
	[CompilerGenerated]
	private MemberData[] <Members>k__BackingField; // 0x28

	// Properties
	public int TeamId { get; set; }
	public bool LobbyMatching { get; set; }
	public MemberData[] Members { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3642428 Offset: 0x363E428 VA: 0x3642428
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3642430 Offset: 0x363E430 VA: 0x3642430
	public int get_TeamId() { }

	[CompilerGenerated]
	// RVA: 0x3642438 Offset: 0x363E438 VA: 0x3642438
	public void set_TeamId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3642440 Offset: 0x363E440 VA: 0x3642440
	public bool get_LobbyMatching() { }

	[CompilerGenerated]
	// RVA: 0x3642448 Offset: 0x363E448 VA: 0x3642448
	public void set_LobbyMatching(bool value) { }

	[CompilerGenerated]
	// RVA: 0x3642454 Offset: 0x363E454 VA: 0x3642454
	public MemberData[] get_Members() { }

	[CompilerGenerated]
	// RVA: 0x364245C Offset: 0x363E45C VA: 0x364245C
	public void set_Members(MemberData[] value) { }

	// RVA: 0x3642464 Offset: 0x363E464 VA: 0x3642464 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x364246C Offset: 0x363E46C VA: 0x364246C Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3642474 Offset: 0x363E474 VA: 0x3642474
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x3642564 Offset: 0x363E564 VA: 0x3642564
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x36425F0 Offset: 0x363E5F0 VA: 0x36425F0 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3642778 Offset: 0x363E778 VA: 0x3642778 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
