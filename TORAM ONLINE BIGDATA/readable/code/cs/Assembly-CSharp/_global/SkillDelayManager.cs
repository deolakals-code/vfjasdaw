// Assembly: Assembly-CSharp.dll
// Namespace: 
public class SkillDelayManager : MonoBehaviour // TypeDefIndex: 672
{
	// Fields
	private Dictionary<SkillId, float> usedSkillList; // 0x20
	private List<SkillId> allStop; // 0x28
	private ISkillDelayTimeTable delayTimeTable; // 0x30

	// Methods

	// RVA: 0x1ABB124 Offset: 0x1AB7124 VA: 0x1ABB124
	private void Update() { }

	[IteratorStateMachine(typeof(SkillDelayManager.<GetParam>d__4))]
	// RVA: 0x1ABB428 Offset: 0x1AB7428 VA: 0x1ABB428
	public IEnumerable<string> GetParam() { }

	// RVA: 0x1ABB4D8 Offset: 0x1AB74D8 VA: 0x1ABB4D8
	public void Initialize(ISkillDelayTimeTable table) { }

	// RVA: 0x1ABB4E0 Offset: 0x1AB74E0 VA: 0x1ABB4E0
	public bool CheckSkillAvailable(SkillId skillId) { }

	// RVA: 0x1ABB6D0 Offset: 0x1AB76D0 VA: 0x1ABB6D0
	public void UseSkill(SkillActionBase skill) { }

	// RVA: 0x1ABB908 Offset: 0x1AB7908 VA: 0x1ABB908
	public void .ctor() { }
}
