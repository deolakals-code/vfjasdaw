// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Actions
public class SupportDelayData : UnityHashBase // TypeDefIndex: 13200
{
	// Fields
	[CompilerGenerated]
	private short <SkillId>k__BackingField; // 0x1A
	[CompilerGenerated]
	private TargetPlayerData[] <TargetList>k__BackingField; // 0x20
	[CompilerGenerated]
	private ActionAppendData <AppendData>k__BackingField; // 0x28

	// Properties
	[UnityHash(Code = 39)]
	public short SkillId { get; set; }
	[UnityHash(Code = 6, IsOptional = True)]
	public TargetPlayerData[] TargetList { get; set; }
	public ActionAppendData AppendData { get; set; }
	public override byte Code { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x36C7448 Offset: 0x36C3448 VA: 0x36C7448
	public short get_SkillId() { }

	[CompilerGenerated]
	// RVA: 0x36C7450 Offset: 0x36C3450 VA: 0x36C7450
	public void set_SkillId(short value) { }

	[CompilerGenerated]
	// RVA: 0x36C7458 Offset: 0x36C3458 VA: 0x36C7458
	public TargetPlayerData[] get_TargetList() { }

	[CompilerGenerated]
	// RVA: 0x36C7460 Offset: 0x36C3460 VA: 0x36C7460
	public void set_TargetList(TargetPlayerData[] value) { }

	[CompilerGenerated]
	// RVA: 0x36C7468 Offset: 0x36C3468 VA: 0x36C7468
	public ActionAppendData get_AppendData() { }

	[CompilerGenerated]
	// RVA: 0x36C7470 Offset: 0x36C3470 VA: 0x36C7470
	public void set_AppendData(ActionAppendData value) { }

	// RVA: 0x36C7478 Offset: 0x36C3478 VA: 0x36C7478 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36C7480 Offset: 0x36C3480 VA: 0x36C7480
	public void .ctor() { }

	// RVA: 0x36C7488 Offset: 0x36C3488 VA: 0x36C7488 Slot: 6
	public override Dictionary<object, object> GetValue() { }

	// RVA: 0x36C7634 Offset: 0x36C3634 VA: 0x36C7634 Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }
}
