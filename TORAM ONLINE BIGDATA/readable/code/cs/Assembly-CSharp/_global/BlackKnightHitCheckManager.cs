// Assembly: Assembly-CSharp.dll
// Namespace: 
public class BlackKnightHitCheckManager // TypeDefIndex: 4149
{
	// Fields
	private Dictionary<int, BlackKnightHitAreaData> hitList; // 0x10
	private List<BlackKnightPlayerSkillBase> checkSkillList; // 0x18
	private List<BlackKnightPlayerSkillBase> hitSkillList; // 0x20
	private BlackKnightMobObjectManager mobObjManager; // 0x28

	// Methods

	// RVA: 0x249375C Offset: 0x248F75C VA: 0x249375C
	public void Update() { }

	// RVA: 0x2493760 Offset: 0x248F760 VA: 0x2493760
	private void UpdateHitSkill() { }

	// RVA: 0x24938CC Offset: 0x248F8CC VA: 0x24938CC
	public void SetMobObjectManager(BlackKnightMobObjectManager manager) { }

	// RVA: 0x24938D4 Offset: 0x248F8D4 VA: 0x24938D4
	public void SetCheckPlayerSkill(BlackKnightPlayerSkillBase skill) { }

	// RVA: 0x24939B8 Offset: 0x248F9B8 VA: 0x24939B8
	public bool CheckHitBullet(BlackKnightPlayerSkillBase skill, Vector3 pos, float size, int uid) { }

	// RVA: 0x2493B58 Offset: 0x248FB58 VA: 0x2493B58
	public bool CheckHitLancer(BlackKnightMagicLancer skill, Transform trans, int uid) { }

	// RVA: 0x249383C Offset: 0x248F83C VA: 0x249383C
	private void RemoveCheckPlayerSkill(BlackKnightPlayerSkillBase skill) { }

	// RVA: 0x2493D34 Offset: 0x248FD34 VA: 0x2493D34
	public bool CheckHitMobToPlayer(Dictionary<int, BlackKnightHitAreaData[]> enemyAtk, BlackKnightPlayerManager playerMng, out Dictionary<int, BlackKnightHitAreaData> hitAreaList) { }

	// RVA: 0x2494018 Offset: 0x2490018 VA: 0x2494018
	public bool CheckHitPlayerToMob(out List<BlackKnightPlayerSkillBase> skillList) { }

	// RVA: 0x2493FC4 Offset: 0x248FFC4 VA: 0x2493FC4
	public bool CheckHitAttack(BlackKnightHitAreaData hitArea, BlackKnightCharacterManagerBase chara) { }

	// RVA: 0x249449C Offset: 0x249049C VA: 0x249449C
	public bool CheckContactPlayerToMob(GuideRail guideRail, BlackKnightPlayerManager playerManager) { }

	// RVA: 0x2494BD0 Offset: 0x2490BD0 VA: 0x2494BD0
	private bool CheckSlipThrough(BlackKnightPlayerManager player, BlackKnightMobManagerBase mob, GuideRail guideRail, out float dist) { }

	// RVA: 0x2494FF8 Offset: 0x2490FF8 VA: 0x2494FF8
	public void .ctor() { }
}
