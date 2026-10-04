// Assembly: Assembly-CSharp.dll
// Namespace: 
public interface MobActionManagerBase // TypeDefIndex: 915
{
	// Properties
	public abstract float Size { get; }
	public abstract bool IsDead { get; }
	public abstract bool IsDeadOrLocalDead { get; }
	public abstract bool IsValid { get; }
	public abstract bool IsBattleActive { get; }
	public abstract bool IsDummy { get; }
	public abstract CharacterActionManagerBase CharacterActionManagerBase { get; }
	public abstract string MobName { get; }
	public abstract MobStatus MobStatus { get; }
	public abstract IMobStatusCalculator MobBattleStatus { get; }
	public abstract AbnormalStateManager AbnormalStateManager { get; }
	public abstract MobBuffManager BuffManager { get; }
	public abstract GameObject MainPlayer { get; }
	public abstract GameObject Target { get; }
	public abstract bool IsPlayerManaged { get; }
	public abstract float PlayerDistance { get; }
	public abstract int PlayerMeterDistance { get; }
	public abstract bool IsBoss { get; }
	public abstract bool IsTargetable { get; }
	public abstract bool HideNameLabel { get; }
	public abstract bool SystemInvincible { get; }
	public abstract GameObject gameObject { get; }
	public abstract Transform transform { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract float get_Size();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool get_IsDead();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool get_IsDeadOrLocalDead();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract bool get_IsValid();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool get_IsBattleActive();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool get_IsDummy();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract CharacterActionManagerBase get_CharacterActionManagerBase();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract string get_MobName();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract MobStatus get_MobStatus();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract IMobStatusCalculator get_MobBattleStatus();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract AbnormalStateManager get_AbnormalStateManager();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract MobBuffManager get_BuffManager();

	// RVA: -1 Offset: -1 Slot: 12
	public abstract GameObject get_MainPlayer();

	// RVA: -1 Offset: -1 Slot: 13
	public abstract GameObject get_Target();

	// RVA: -1 Offset: -1 Slot: 14
	public abstract bool get_IsPlayerManaged();

	// RVA: -1 Offset: -1 Slot: 15
	public abstract float get_PlayerDistance();

	// RVA: -1 Offset: -1 Slot: 16
	public abstract int get_PlayerMeterDistance();

	// RVA: -1 Offset: -1 Slot: 17
	public abstract bool get_IsBoss();

	// RVA: -1 Offset: -1 Slot: 18
	public abstract bool get_IsTargetable();

	// RVA: -1 Offset: -1 Slot: 19
	public abstract bool get_HideNameLabel();

	// RVA: -1 Offset: -1 Slot: 20
	public abstract bool get_SystemInvincible();

	// RVA: -1 Offset: -1 Slot: 21
	public abstract GameObject get_gameObject();

	// RVA: -1 Offset: -1 Slot: 22
	public abstract Transform get_transform();

	// RVA: -1 Offset: -1 Slot: 23
	public abstract bool CheckMultiFlag(MobMultiFlag flag);

	// RVA: -1 Offset: -1 Slot: 24
	public abstract bool TryGetProperties<T>(MonsterPropertyType id, out T properties);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-MobActionManagerBase.TryGetProperties<object>
	*/

	// RVA: -1 Offset: -1 Slot: 25
	public abstract float GetHpPercent();

	// RVA: -1 Offset: -1 Slot: 26
	public abstract bool GetHate();

	// RVA: -1 Offset: -1 Slot: 27
	public abstract bool HasPlayerHate(bool includingZeroHate = False);

	// RVA: -1 Offset: -1 Slot: 28
	public abstract bool HasOtherPlayerHate(int archetypeId, byte archetypeType);

	// RVA: -1 Offset: -1 Slot: 29
	public abstract bool CorrectionTarget();

	// RVA: -1 Offset: -1 Slot: 30
	public abstract bool CheckTargetMob(Vector3 pos, out GameObject target);

	// RVA: -1 Offset: -1 Slot: 31
	public abstract Vector3 GetNearTargetPosition(Vector3 pos);

	// RVA: -1 Offset: -1 Slot: 32
	public abstract bool GetNearTargetDist(Vector3 pos, float rad, float height, float dist, out GameObject target, out float updateDist);

	// RVA: -1 Offset: -1 Slot: 33
	public abstract bool GetNearTargetInCameraDist(Plane[] planes, Vector3 pos, float rad, float height, float dist, out GameObject target, out float updateDist);

	// RVA: -1 Offset: -1 Slot: 34
	public abstract bool GetFarTargetInCameraDist(Plane[] planes, Vector3 pos, float rad, float height, float dist, out GameObject target, out float updateDist);

	// RVA: -1 Offset: -1 Slot: 35
	public abstract void InitManagedMob(GameObject target, bool isActiveInvoke);

	// RVA: -1 Offset: -1 Slot: 36
	public abstract MobSendData CreateMobSendData();

	// RVA: -1 Offset: -1 Slot: 37
	public abstract MobSendDataLight CreateMobSendDataLight();

	// RVA: -1 Offset: -1 Slot: 38
	public abstract MobIdData CreateMobIdData();

	// RVA: -1 Offset: -1 Slot: 39
	public abstract bool MobToEnemy();

	// RVA: -1 Offset: -1 Slot: 40
	public abstract bool CheckMobRangeAttck(Transform actor);

	// RVA: -1 Offset: -1 Slot: 41
	public abstract bool CheckDamageMissing();
}
