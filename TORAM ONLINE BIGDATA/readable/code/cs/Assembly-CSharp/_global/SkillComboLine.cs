// Assembly: Assembly-CSharp.dll
// Namespace: 
public class SkillComboLine // TypeDefIndex: 3580
{
	// Fields
	public const int MaxComboDepth = 10;
	private readonly List<SkillComboParam> comboParam; // 0x10
	private List<SkillEqLimitFlag> skillEqLimitFlagList; // 0x18
	private bool ngCheck; // 0x20
	private readonly List<SkillId> ngSkillList; // 0x28
	[CompilerGenerated]
	private bool <IsValid>k__BackingField; // 0x30
	[CompilerGenerated]
	private bool <Enable>k__BackingField; // 0x31
	[CompilerGenerated]
	private byte <Id>k__BackingField; // 0x32
	[CompilerGenerated]
	private byte <UseComboPoint>k__BackingField; // 0x33

	// Properties
	public bool IsValid { get; set; }
	public bool Enable { get; set; }
	public byte Id { get; set; }
	public int Count { get; }
	public byte UseComboPoint { get; set; }
	public List<SkillComboParam> ComboParam { get; }
	public SkillComboParam FirstSkill { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x238F620 Offset: 0x238B620 VA: 0x238F620
	public bool get_IsValid() { }

	[CompilerGenerated]
	// RVA: 0x238F628 Offset: 0x238B628 VA: 0x238F628
	private void set_IsValid(bool value) { }

	[CompilerGenerated]
	// RVA: 0x238F634 Offset: 0x238B634 VA: 0x238F634
	public bool get_Enable() { }

	[CompilerGenerated]
	// RVA: 0x238F63C Offset: 0x238B63C VA: 0x238F63C
	private void set_Enable(bool value) { }

	[CompilerGenerated]
	// RVA: 0x238F648 Offset: 0x238B648 VA: 0x238F648
	public byte get_Id() { }

	[CompilerGenerated]
	// RVA: 0x238F650 Offset: 0x238B650 VA: 0x238F650
	private void set_Id(byte value) { }

	// RVA: 0x238F658 Offset: 0x238B658 VA: 0x238F658
	public int get_Count() { }

	[CompilerGenerated]
	// RVA: 0x238F6A0 Offset: 0x238B6A0 VA: 0x238F6A0
	public byte get_UseComboPoint() { }

	[CompilerGenerated]
	// RVA: 0x238F6A8 Offset: 0x238B6A8 VA: 0x238F6A8
	private void set_UseComboPoint(byte value) { }

	// RVA: 0x238F6B0 Offset: 0x238B6B0 VA: 0x238F6B0
	public List<SkillComboParam> get_ComboParam() { }

	// RVA: 0x238F6B8 Offset: 0x238B6B8 VA: 0x238F6B8
	public SkillComboParam get_FirstSkill() { }

	// RVA: 0x238F724 Offset: 0x238B724 VA: 0x238F724
	public void .ctor(byte id) { }

	// RVA: 0x238FEC0 Offset: 0x238BEC0 VA: 0x238FEC0
	public void .ctor(byte id, bool enable, short[] skillIds, byte[] types) { }

	// RVA: 0x2390C5C Offset: 0x238CC5C VA: 0x2390C5C
	public void SetComboData(SkillComboData data) { }

	// RVA: 0x2390E2C Offset: 0x238CE2C VA: 0x2390E2C
	public void SetEnable(bool setEnable) { }

	// RVA: 0x2390E38 Offset: 0x238CE38 VA: 0x2390E38
	public short[] GetSkillIds() { }

	// RVA: 0x239107C Offset: 0x238D07C VA: 0x239107C
	public byte[] GetTypes() { }

	// RVA: 0x23912C0 Offset: 0x238D2C0 VA: 0x23912C0
	public SkillComboParam CreateParam() { }

	// RVA: 0x23913D4 Offset: 0x238D3D4 VA: 0x23913D4
	public void RemoveParame(int index) { }

	// RVA: 0x23907FC Offset: 0x238C7FC VA: 0x23907FC
	public void Validate() { }

	// RVA: 0x23914C8 Offset: 0x238D4C8 VA: 0x23914C8
	public bool CheckEqLimitFlag(SkillEqLimitFlag flag, SkillManager skillManager) { }

	// RVA: 0x23918F8 Offset: 0x238D8F8 VA: 0x23918F8
	public bool ExistsSkill(SkillId id) { }

	// RVA: 0x23919D8 Offset: 0x238D9D8 VA: 0x23919D8
	public bool IsLastSkill(SkillId id) { }
}
