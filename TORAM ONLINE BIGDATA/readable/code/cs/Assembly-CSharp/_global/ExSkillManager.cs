// Assembly: Assembly-CSharp.dll
// Namespace: 
public class ExSkillManager // TypeDefIndex: 1821
{
	// Fields
	private Dictionary<SkillId, ExSkillDataBase> exSkillList; // 0x10

	// Methods

	// RVA: 0x20E4DFC Offset: 0x20E0DFC VA: 0x20E4DFC
	public void Initialize(Dictionary<short, byte[]> ExSkillConfigList) { }

	// RVA: 0x20E5100 Offset: 0x20E1100 VA: 0x20E5100
	public void UpdateExSkillData(SkillId skillId, ExSkillDataBase exSkillData) { }

	// RVA: 0x20E51CC Offset: 0x20E11CC VA: 0x20E51CC
	public bool ContainsExSkillData(SkillId skillId) { }

	// RVA: 0x20E5224 Offset: 0x20E1224 VA: 0x20E5224
	public bool TryGetExSkillData(SkillId skillId, out ExSkillDataBase exSkillData) { }

	// RVA: -1 Offset: -1
	public bool TryGetExSkillData<T>(SkillId skillId, out T exSkillData) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26BF46C Offset: 0x26BB46C VA: 0x26BF46C
	|-ExSkillManager.TryGetExSkillData<object>
	*/

	// RVA: 0x20E528C Offset: 0x20E128C VA: 0x20E528C
	public bool SendUpdateExSkill(ExSkillDataBase exSkillData) { }

	// RVA: 0x20E4FD8 Offset: 0x20E0FD8 VA: 0x20E4FD8
	public static ExSkillDataBase CreateExSkillData(SkillId skillId, byte[] binary) { }

	// RVA: 0x20E54BC Offset: 0x20E14BC VA: 0x20E54BC
	public void .ctor() { }
}
