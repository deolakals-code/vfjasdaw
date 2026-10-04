// Assembly: Assembly-CSharp.dll
// Namespace: 
public class SkillTextManager : TextManagerBase // TypeDefIndex: 5273
{
	// Fields
	private Dictionary<int, SkillTextManagerData> TextData; // 0x18

	// Methods

	// RVA: 0x261E538 Offset: 0x261A538 VA: 0x261E538 Slot: 6
	public override void Initialize(byte[] binary) { }

	// RVA: -1 Offset: -1 Slot: 4
	public override T Get<T>(int id) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26EEA80 Offset: 0x26EAA80 VA: 0x26EEA80
	|-SkillTextManager.Get<object>
	*/

	// RVA: 0x261EEAC Offset: 0x261AEAC VA: 0x261EEAC
	private void AddDebugText() { }

	// RVA: 0x261EEB0 Offset: 0x261AEB0 VA: 0x261EEB0 Slot: 7
	public override void Clear() { }

	// RVA: 0x261EF08 Offset: 0x261AF08 VA: 0x261EF08
	public string GetSkillName(int skillId) { }

	// RVA: 0x261EFC0 Offset: 0x261AFC0 VA: 0x261EFC0
	public string GetSkillName(int skillId, string key) { }

	// RVA: 0x261F134 Offset: 0x261B134 VA: 0x261F134
	public string GetSkillName(int skillId, ElementType elementType) { }

	// RVA: 0x261F2E4 Offset: 0x261B2E4 VA: 0x261F2E4
	public string GetSkillInfo(int skillId) { }

	// RVA: 0x261F39C Offset: 0x261B39C VA: 0x261F39C
	public string GetSkillInfo(int skillId, string key) { }

	// RVA: 0x261F510 Offset: 0x261B510 VA: 0x261F510
	public Dictionary<int, string> GetDatas() { }

	// RVA: 0x261F6E8 Offset: 0x261B6E8 VA: 0x261F6E8
	public void .ctor() { }
}
