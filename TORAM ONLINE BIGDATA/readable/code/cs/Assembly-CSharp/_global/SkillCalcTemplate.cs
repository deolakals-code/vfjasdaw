// Assembly: Assembly-CSharp.dll
// Namespace: 
[DefaultMember("Item")]
public class SkillCalcTemplate // TypeDefIndex: 2583
{
	// Fields
	private BindingVariable[] StepArray; // 0x10
	private List<string> log; // 0x18
	[CompilerGenerated]
	private SkillId <SkillId>k__BackingField; // 0x20

	// Properties
	public SkillId SkillId { get; set; }
	public float Item { get; }

	// Methods

	// RVA: 0x21FF484 Offset: 0x21FB484 VA: 0x21FF484
	private SkillCalcTemplate.Type checkType(SkillCalcTemplate.CalcStep step) { }

	// RVA: 0x21FF4A8 Offset: 0x21FB4A8 VA: 0x21FF4A8
	private bool isType(SkillCalcTemplate.Type type, SkillCalcTemplate.Type type2) { }

	[CompilerGenerated]
	// RVA: 0x21FF4B4 Offset: 0x21FB4B4 VA: 0x21FF4B4
	public SkillId get_SkillId() { }

	[CompilerGenerated]
	// RVA: 0x21FF4BC Offset: 0x21FB4BC VA: 0x21FF4BC
	public void set_SkillId(SkillId value) { }

	// RVA: 0x21FF4C4 Offset: 0x21FB4C4 VA: 0x21FF4C4
	public float get_Item(SkillCalcTemplate.CalcStep value) { }

	// RVA: 0x21F789C Offset: 0x21F389C VA: 0x21F789C
	public void .ctor() { }

	// RVA: 0x21FF504 Offset: 0x21FB504 VA: 0x21FF504
	public int GetDamage() { }

	// RVA: 0x220000C Offset: 0x21FC00C VA: 0x220000C
	private void AddLog(string data, object[] param) { }

	// RVA: 0x2200010 Offset: 0x21FC010 VA: 0x2200010
	public void ShowLog() { }

	// RVA: 0x21FB9BC Offset: 0x21F79BC VA: 0x21FB9BC
	public bool CheckStepResult(SkillCalcTemplate.CalcStep index) { }

	// RVA: 0x2200120 Offset: 0x21FC120 VA: 0x2200120
	public float[] DumpCalcLog() { }

	// RVA: 0x22008EC Offset: 0x21FC8EC VA: 0x22008EC
	public void AddConstant(SkillCalcTemplate.CalcStep index, Func<float> data) { }

	// RVA: 0x21F7BA0 Offset: 0x21F3BA0 VA: 0x21F7BA0
	public void AddConstant(SkillCalcTemplate.CalcStep index, float data) { }

	// RVA: 0x21FA944 Offset: 0x21F6944 VA: 0x21FA944
	public void SetConstant(SkillCalcTemplate.CalcStep index, float data) { }

	// RVA: 0x2200A4C Offset: 0x21FCA4C VA: 0x2200A4C
	public void SetConstant(SkillCalcTemplate.CalcStep index, Func<float> data) { }

	// RVA: 0x2200B48 Offset: 0x21FCB48 VA: 0x2200B48
	public void AddRate(SkillCalcTemplate.CalcStep index, Func<float> data) { }

	// RVA: 0x21F7A74 Offset: 0x21F3A74 VA: 0x21F7A74
	public void AddRate(SkillCalcTemplate.CalcStep index, float data) { }

	// RVA: 0x21F92A4 Offset: 0x21F52A4 VA: 0x21F92A4
	public void SetRate(SkillCalcTemplate.CalcStep index, float data) { }

	// RVA: 0x2200CAC Offset: 0x21FCCAC VA: 0x2200CAC
	public void SetRate(SkillCalcTemplate.CalcStep index, Func<float> data) { }

	// RVA: 0x2200014 Offset: 0x21FC014 VA: 0x2200014
	public void SetCheck(SkillCalcTemplate.CalcStep index, bool data) { }

	// RVA: 0x21FBA4C Offset: 0x21F7A4C VA: 0x21FBA4C
	public void TakeInCheckCalcStep(SkillCalcTemplate.CalcStep step, SkillCalcTemplate template) { }

	// RVA: 0x2200DAC Offset: 0x21FCDAC VA: 0x2200DAC
	public void SetCalcValue(SkillCalcTemplate.CalcStep index, float value) { }
}
