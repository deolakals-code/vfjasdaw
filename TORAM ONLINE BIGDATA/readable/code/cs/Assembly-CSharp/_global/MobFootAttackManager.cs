// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MobFootAttackManager // TypeDefIndex: 932
{
	// Fields
	private const float FootEffectLoopTime = 1;
	private const float RegularCommunicationInterval = 3;
	private readonly GameObject actor; // 0x10
	private readonly EnemyMobActionManagerBase actionManager; // 0x18
	private MobSkillActionManager skillActionManager; // 0x20
	private readonly TakeController takeController; // 0x28
	private readonly PlayerDataManager player; // 0x30
	private readonly CharacterMove charaMove; // 0x38
	private MobStatusMaster statusMaster; // 0x40
	private MobPropertyMaster activePropertyMaster; // 0x48
	private bool active; // 0x50
	private float coolTime; // 0x54
	private float footEffectTimer; // 0x58
	private bool prevMove; // 0x5C
	private float pauseTime; // 0x60
	private bool isRoomEntreeStagingFlag; // 0x64
	private float regularCommunicationTimer; // 0x68

	// Methods

	// RVA: 0x1F07F00 Offset: 0x1F03F00 VA: 0x1F07F00
	public void .ctor(GameObject actor, EnemyMobActionManagerBase actionManager, CharacterMove charaMove) { }

	// RVA: 0x1F07FDC Offset: 0x1F03FDC VA: 0x1F07FDC
	public void Update() { }

	// RVA: 0x1F08C84 Offset: 0x1F04C84 VA: 0x1F08C84
	public void SetMobStatusMaster(MobStatusMaster master) { }

	// RVA: 0x1F090F0 Offset: 0x1F050F0 VA: 0x1F090F0
	public void AssistMoveStart() { }

	// RVA: 0x1F09168 Offset: 0x1F05168 VA: 0x1F09168
	public void AssistMoveEnd() { }

	// RVA: 0x1F09204 Offset: 0x1F05204 VA: 0x1F09204
	public void ActiveMovePatternStart() { }

	// RVA: 0x1F0927C Offset: 0x1F0527C VA: 0x1F0927C
	public void ActiveMovePatternEnd() { }

	// RVA: 0x1F08E14 Offset: 0x1F04E14 VA: 0x1F08E14
	public void SetActive(bool active) { }

	// RVA: 0x1F09318 Offset: 0x1F05318 VA: 0x1F09318
	public void RoomEnterStart() { }

	// RVA: 0x1F09324 Offset: 0x1F05324 VA: 0x1F09324
	public void AbnormalAssistMoveStop() { }

	// RVA: 0x1F08678 Offset: 0x1F04678 VA: 0x1F08678
	private void PauseUpdate() { }

	// RVA: 0x1F086CC Offset: 0x1F046CC VA: 0x1F086CC
	private void RegularCommunication() { }

	// RVA: 0x1F08814 Offset: 0x1F04814 VA: 0x1F08814
	private void UpdateFootEffect() { }

	// RVA: 0x1F08FA4 Offset: 0x1F04FA4 VA: 0x1F08FA4
	private void PlayFootEffect() { }

	// RVA: 0x1F088B4 Offset: 0x1F048B4 VA: 0x1F088B4
	private bool CheckRange(Transform targetTranform) { }

	// RVA: 0x1F08940 Offset: 0x1F04940 VA: 0x1F08940
	private void FootAttack(MobActionPattern actionPattern, GameObject target, PlayerActionManagerBase targetActionManager) { }

	// RVA: 0x1F08A9C Offset: 0x1F04A9C VA: 0x1F08A9C
	private void NpcFootAttack(MobActionPattern actionPattern, GameObject target, PlayerActionManagerBase targetActionManager, ArchetypeUid targetArchetypeUid) { }
}
