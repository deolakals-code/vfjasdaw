// Assembly: Assembly-CSharp.dll
// Namespace: 
public class CounterForceBuf : SkillBufferDataBase // TypeDefIndex: 3106
{
	// Fields
	private const int maxSkillCount = 3;
	private PlayerActionManagerBase playerAction; // 0x20
	private PlayerBattleManager battleManager; // 0x28
	private MobaPlayerBattleManager mobaBattleManager; // 0x30
	private List<SkillActionBase> skillList; // 0x38
	private float range; // 0x40

	// Properties
	public override SkillId SkillId { get; }
	public override SkillBufferFlag Flag { get; }

	// Methods

	// RVA: 0x2322D48 Offset: 0x231ED48 VA: 0x2322D48 Slot: 4
	public override SkillId get_SkillId() { }

	// RVA: 0x2322D50 Offset: 0x231ED50 VA: 0x2322D50 Slot: 9
	public override SkillBufferFlag get_Flag() { }

	// RVA: 0x2322D58 Offset: 0x231ED58 VA: 0x2322D58
	public void .ctor(byte lv, PlayerActionManagerBase playerAction) { }

	// RVA: 0x2323088 Offset: 0x231F088 VA: 0x2323088 Slot: 12
	public override int GetParam(int id) { }

	// RVA: 0x2323090 Offset: 0x231F090 VA: 0x2323090 Slot: 11
	public override void Updata() { }

	// RVA: 0x23230E4 Offset: 0x231F0E4 VA: 0x23230E4
	private bool CheckInSight(Vector3 targetPos, float size) { }

	// RVA: 0x232322C Offset: 0x231F22C VA: 0x232322C
	public void RecevePlayerDamaged(GameObject enemy) { }

	// RVA: 0x232343C Offset: 0x231F43C VA: 0x232343C
	public void ReceveOtherPlayerDamaged(GameObject actor, float size, GameObject enemy) { }

	// RVA: 0x232365C Offset: 0x231F65C VA: 0x232365C
	public void EndSkill(SkillActionBase skill) { }
}
