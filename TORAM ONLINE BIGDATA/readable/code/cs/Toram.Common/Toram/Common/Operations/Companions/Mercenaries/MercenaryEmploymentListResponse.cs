// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Companions.Mercenaries
public class MercenaryEmploymentListResponse : OperationResponseBase // TypeDefIndex: 11386
{
	// Fields
	[CompilerGenerated]
	private byte <EmploymentType>k__BackingField; // 0x20
	[CompilerGenerated]
	private MercenaryEmployeeData[] <EmploymentList>k__BackingField; // 0x28
	[CompilerGenerated]
	private DateTime <LatestTime>k__BackingField; // 0x30
	[CompilerGenerated]
	private TimeSpan <LeftTime>k__BackingField; // 0x38

	// Properties
	public byte EmploymentType { get; set; }
	public MercenaryEmployeeData[] EmploymentList { get; set; }
	public DateTime LatestTime { get; set; }
	public TimeSpan LeftTime { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x36FF2E0 Offset: 0x36FB2E0 VA: 0x36FF2E0
	public void .ctor() { }

	// RVA: 0x36FF2E8 Offset: 0x36FB2E8 VA: 0x36FF2E8
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x36FF2F0 Offset: 0x36FB2F0 VA: 0x36FF2F0
	public byte get_EmploymentType() { }

	[CompilerGenerated]
	// RVA: 0x36FF2F8 Offset: 0x36FB2F8 VA: 0x36FF2F8
	public void set_EmploymentType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36FF300 Offset: 0x36FB300 VA: 0x36FF300
	public MercenaryEmployeeData[] get_EmploymentList() { }

	[CompilerGenerated]
	// RVA: 0x36FF308 Offset: 0x36FB308 VA: 0x36FF308
	public void set_EmploymentList(MercenaryEmployeeData[] value) { }

	[CompilerGenerated]
	// RVA: 0x36FF310 Offset: 0x36FB310 VA: 0x36FF310
	public DateTime get_LatestTime() { }

	[CompilerGenerated]
	// RVA: 0x36FF318 Offset: 0x36FB318 VA: 0x36FF318
	public void set_LatestTime(DateTime value) { }

	[CompilerGenerated]
	// RVA: 0x36FF320 Offset: 0x36FB320 VA: 0x36FF320
	public TimeSpan get_LeftTime() { }

	[CompilerGenerated]
	// RVA: 0x36FF328 Offset: 0x36FB328 VA: 0x36FF328
	public void set_LeftTime(TimeSpan value) { }

	// RVA: 0x36FF330 Offset: 0x36FB330 VA: 0x36FF330 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36FF338 Offset: 0x36FB338 VA: 0x36FF338 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x36FF340 Offset: 0x36FB340 VA: 0x36FF340 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x36FF610 Offset: 0x36FB610 VA: 0x36FF610 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
