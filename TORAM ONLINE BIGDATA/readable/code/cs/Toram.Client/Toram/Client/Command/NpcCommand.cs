// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Command
[CLSCompliant(False)]
public static class NpcCommand // TypeDefIndex: 15135
{
	// Methods

	// RVA: 0x3596D5C Offset: 0x3592D5C VA: 0x3596D5C
	private static void SendNpcAction(Game game, ArchetypeUid archetype, ActionCode actionCode, UnityHashBase actionParam, bool isGuarantee = True) { }

	// RVA: 0x3596E80 Offset: 0x3592E80 VA: 0x3596E80
	public static void Move(Game game, ArchetypeUid archetype, short[] position, float rotation) { }

	// RVA: 0x3596F44 Offset: 0x3592F44 VA: 0x3596F44
	public static void Move(Game game, ArchetypeUid archetype, short[] position, float rotation, short speed) { }

	// RVA: 0x3597018 Offset: 0x3593018 VA: 0x3597018
	public static void AttackStart(Game game, ArchetypeUid archetype, AttackStartData attackData) { }

	// RVA: 0x3597028 Offset: 0x3593028 VA: 0x3597028
	public static void Attack(Game game, ArchetypeUid archetype, short skillId, byte localId, byte damageId, List<MobDamageData> targetList) { }

	// RVA: 0x3597104 Offset: 0x3593104 VA: 0x3597104
	public static void AttackEnd(Game game, ArchetypeUid archetype, short skillId, byte localId) { }

	// RVA: 0x3597198 Offset: 0x3593198 VA: 0x3597198
	public static void SkillCancel(Game game, ArchetypeUid archetype, short skillId, byte localId) { }

	// RVA: 0x359722C Offset: 0x359322C VA: 0x359722C
	public static void SkillMotionEnd(Game game, ArchetypeUid archetype, short skillId, byte localId) { }

	// RVA: 0x35972C0 Offset: 0x35932C0 VA: 0x35972C0
	public static void BattleEndCheck(Game game, ArchetypeUid archetype) { }

	// RVA: 0x35972D0 Offset: 0x35932D0 VA: 0x35972D0
	public static void SkillEvent(Game game, ArchetypeUid archetype, SkillEventData skillEvent) { }

	// RVA: 0x35972E0 Offset: 0x35932E0 VA: 0x35972E0
	public static void SupportStart(Game game, ArchetypeUid archetype, SupportStartData supportData) { }

	// RVA: 0x35972F0 Offset: 0x35932F0 VA: 0x35972F0
	public static void SupportSelf(Game game, ArchetypeUid archetype, short skillId, byte localId) { }

	// RVA: 0x3597384 Offset: 0x3593384 VA: 0x3597384
	public static void Support(Game game, ArchetypeUid archetype, short skillId, byte localId, List<TargetPlayerData> targetList) { }

	// RVA: 0x3597470 Offset: 0x3593470 VA: 0x3597470
	public static void SupportEnd(Game game, ArchetypeUid archetype, short skillId, byte localId) { }

	// RVA: 0x3597504 Offset: 0x3593504 VA: 0x3597504
	public static void MobActionStart(Game game, ArchetypeUid archetype, MobActionStartData sendData) { }

	// RVA: 0x3597514 Offset: 0x3593514 VA: 0x3597514
	public static void MobAttack(Game game, ArchetypeUid archetype, MobAttackData sendData) { }

	// RVA: 0x3597524 Offset: 0x3593524 VA: 0x3597524
	public static void MobSupport(Game game, ArchetypeUid archetype, MobAttackData sendData) { }

	// RVA: 0x3597534 Offset: 0x3593534 VA: 0x3597534
	public static void MobEventAttack(Game game, ArchetypeUid archetype, MobEventAttackData attackData) { }

	// RVA: 0x3597544 Offset: 0x3593544 VA: 0x3597544
	public static void Emotion(Game game, ArchetypeUid archetype, byte emotionType, byte emotionId) { }

	// RVA: 0x35975D8 Offset: 0x35935D8 VA: 0x35975D8
	public static void Emotion(Game game, ArchetypeUid archetype, byte emotionType, byte emotionId, short[] position, short rotation) { }

	// RVA: 0x3597690 Offset: 0x3593690 VA: 0x3597690
	public static void EmotionSitDown(Game game, ArchetypeUid archetype, byte emotionId) { }

	// RVA: 0x3597714 Offset: 0x3593714 VA: 0x3597714
	public static void EmotionCancel(Game game, ArchetypeUid archetype) { }
}
