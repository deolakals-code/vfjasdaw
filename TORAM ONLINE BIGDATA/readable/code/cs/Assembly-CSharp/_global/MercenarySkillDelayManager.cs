// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MercenarySkillDelayManager : MonoBehaviour // TypeDefIndex: 668
{
	// Fields
	private Dictionary<SkillId, float> usedSkillDelayList; // 0x20
	private Dictionary<SkillId, float> clientDriverDelayList; // 0x28
	private ISkillDelayTimeTable delayTimeTable; // 0x30
	private SkillId lastAction; // 0x38

	// Methods

	[IteratorStateMachine(typeof(MercenarySkillDelayManager.<GetParam>d__4))]
	// RVA: 0x1ABA7F4 Offset: 0x1AB67F4 VA: 0x1ABA7F4
	public IEnumerable<string> GetParam() { }

	// RVA: 0x1ABA8A4 Offset: 0x1AB68A4 VA: 0x1ABA8A4
	private void Update() { }

	// RVA: 0x1ABAB2C Offset: 0x1AB6B2C VA: 0x1ABAB2C
	public void Initialize(ISkillDelayTimeTable table) { }

	// RVA: 0x1ABAB34 Offset: 0x1AB6B34 VA: 0x1ABAB34
	public bool CheckLastTimeActionDone() { }

	// RVA: 0x1ABAB44 Offset: 0x1AB6B44 VA: 0x1ABAB44
	public void LastActionReset() { }

	// RVA: 0x1AB9628 Offset: 0x1AB5628 VA: 0x1AB9628
	public bool CheckSkillAvailable(SkillId skillId) { }

	// RVA: 0x1AB8F24 Offset: 0x1AB4F24 VA: 0x1AB8F24
	public void UseSkill(SkillActionBase skill) { }

	// RVA: 0x1ABAB50 Offset: 0x1AB6B50 VA: 0x1ABAB50
	public void ReusableSkill(SkillId skillId) { }

	// RVA: 0x1AB8D18 Offset: 0x1AB4D18 VA: 0x1AB8D18
	public void ResetClear() { }

	// RVA: 0x1ABABE0 Offset: 0x1AB6BE0 VA: 0x1ABABE0
	public void .ctor() { }
}
