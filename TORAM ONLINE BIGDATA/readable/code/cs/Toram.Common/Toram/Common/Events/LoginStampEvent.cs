// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events
public class LoginStampEvent : PacketBase // TypeDefIndex: 12630
{
	// Fields
	[CompilerGenerated]
	private int <AvatarUuid>k__BackingField; // 0x20
	[CompilerGenerated]
	private StampData <StampData>k__BackingField; // 0x28
	[CompilerGenerated]
	private StampCardData <StampCard>k__BackingField; // 0x30
	[CompilerGenerated]
	private StampCardData <RewardCard>k__BackingField; // 0x38
	[CompilerGenerated]
	private bool <IsMonth>k__BackingField; // 0x40

	// Properties
	[PacketParameter(Code = 1)]
	public int AvatarUuid { get; set; }
	[PacketClass(Code = 199)]
	public StampData StampData { get; set; }
	[PacketClass(Code = 162, IsOptional = True)]
	public StampCardData StampCard { get; set; }
	[PacketClass(Code = 122, IsOptional = True)]
	public StampCardData RewardCard { get; set; }
	[PacketParameter(Code = 43)]
	public bool IsMonth { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3635404 Offset: 0x3631404 VA: 0x3635404
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x363540C Offset: 0x363140C VA: 0x363540C
	public int get_AvatarUuid() { }

	[CompilerGenerated]
	// RVA: 0x3635414 Offset: 0x3631414 VA: 0x3635414
	public void set_AvatarUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x363541C Offset: 0x363141C VA: 0x363541C
	public StampData get_StampData() { }

	[CompilerGenerated]
	// RVA: 0x3635424 Offset: 0x3631424 VA: 0x3635424
	public void set_StampData(StampData value) { }

	[CompilerGenerated]
	// RVA: 0x363542C Offset: 0x363142C VA: 0x363542C
	public StampCardData get_StampCard() { }

	[CompilerGenerated]
	// RVA: 0x3635434 Offset: 0x3631434 VA: 0x3635434
	public void set_StampCard(StampCardData value) { }

	[CompilerGenerated]
	// RVA: 0x363543C Offset: 0x363143C VA: 0x363543C
	public StampCardData get_RewardCard() { }

	[CompilerGenerated]
	// RVA: 0x3635444 Offset: 0x3631444 VA: 0x3635444
	public void set_RewardCard(StampCardData value) { }

	[CompilerGenerated]
	// RVA: 0x363544C Offset: 0x363144C VA: 0x363544C
	public bool get_IsMonth() { }

	[CompilerGenerated]
	// RVA: 0x3635454 Offset: 0x3631454 VA: 0x3635454
	public void set_IsMonth(bool value) { }

	// RVA: 0x3635460 Offset: 0x3631460 VA: 0x3635460
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x36356E0 Offset: 0x36316E0 VA: 0x36356E0
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x36357B4 Offset: 0x36317B4 VA: 0x36357B4 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36357BC Offset: 0x36317BC VA: 0x36357BC Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3635944 Offset: 0x3631944 VA: 0x3635944 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
