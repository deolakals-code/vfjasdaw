// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Npcs
public class NpcOtherData : UnityHashBase // TypeDefIndex: 11156
{
	// Fields
	[CompilerGenerated]
	private int <NpcId>k__BackingField; // 0x1C
	[CompilerGenerated]
	private NpcMotionData[] <NpcMotionList>k__BackingField; // 0x20
	[CompilerGenerated]
	private NpcSkillData[] <NpcSkillList>k__BackingField; // 0x28
	[CompilerGenerated]
	private short <Lv>k__BackingField; // 0x30

	// Properties
	[UnityHash(Code = 74)]
	public int NpcId { get; set; }
	[UnityHash(Code = 143, IsOptional = True)]
	public NpcMotionData[] NpcMotionList { get; set; }
	[UnityHash(Code = 102, IsOptional = True)]
	public NpcSkillData[] NpcSkillList { get; set; }
	[UnityHash(Code = 29, IsOptional = True)]
	public short Lv { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x35CB408 Offset: 0x35C7408 VA: 0x35CB408
	public void .ctor(Dictionary<object, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x35CB410 Offset: 0x35C7410 VA: 0x35CB410
	public int get_NpcId() { }

	[CompilerGenerated]
	// RVA: 0x35CB418 Offset: 0x35C7418 VA: 0x35CB418
	public void set_NpcId(int value) { }

	[CompilerGenerated]
	// RVA: 0x35CB420 Offset: 0x35C7420 VA: 0x35CB420
	public NpcMotionData[] get_NpcMotionList() { }

	[CompilerGenerated]
	// RVA: 0x35CB428 Offset: 0x35C7428 VA: 0x35CB428
	public void set_NpcMotionList(NpcMotionData[] value) { }

	[CompilerGenerated]
	// RVA: 0x35CB430 Offset: 0x35C7430 VA: 0x35CB430
	public NpcSkillData[] get_NpcSkillList() { }

	[CompilerGenerated]
	// RVA: 0x35CB438 Offset: 0x35C7438 VA: 0x35CB438
	public void set_NpcSkillList(NpcSkillData[] value) { }

	[CompilerGenerated]
	// RVA: 0x35CB440 Offset: 0x35C7440 VA: 0x35CB440
	public short get_Lv() { }

	[CompilerGenerated]
	// RVA: 0x35CB448 Offset: 0x35C7448 VA: 0x35CB448
	public void set_Lv(short value) { }

	// RVA: 0x35CB450 Offset: 0x35C7450 VA: 0x35CB450
	private void SetClass(Dictionary<object, object> parameters) { }

	// RVA: 0x35CB634 Offset: 0x35C7634 VA: 0x35CB634
	private void GetClass(Dictionary<object, object> parameters) { }

	// RVA: 0x35CB758 Offset: 0x35C7758 VA: 0x35CB758 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35CB760 Offset: 0x35C7760 VA: 0x35CB760 Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }

	// RVA: 0x35CB97C Offset: 0x35C797C VA: 0x35CB97C Slot: 6
	public override Dictionary<object, object> GetValue() { }
}
