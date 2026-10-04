// Assembly: Assembly-CSharp.dll
// Namespace: 
public class HandlingerOfGodspeedBuf : SkillBufferDataBase // TypeDefIndex: 3187
{
	// Fields
	private const int MaxCverlayCount = 3;
	private int aspd; // 0x20
	private int actionSpeed; // 0x24
	private int avoid; // 0x28
	private int maxMp; // 0x2C
	private int physicsResist; // 0x30
	private int magicResist; // 0x34
	private int cverlayCount; // 0x38
	private int bufTakeId; // 0x3C
	private PlayerStatusBase playerStatus; // 0x40
	private int[] effectUidList; // 0x48

	// Properties
	public override SkillId SkillId { get; }
	public override int BufEffectTakeId { get; }

	// Methods

	// RVA: 0x2331A20 Offset: 0x232DA20 VA: 0x2331A20 Slot: 4
	public override SkillId get_SkillId() { }

	// RVA: 0x2331A28 Offset: 0x232DA28 VA: 0x2331A28 Slot: 8
	public override int get_BufEffectTakeId() { }

	// RVA: 0x2331A30 Offset: 0x232DA30 VA: 0x2331A30
	public void .ctor(byte lv) { }

	// RVA: 0x2331B30 Offset: 0x232DB30 VA: 0x2331B30 Slot: 12
	public override int GetParam(int id) { }

	// RVA: 0x2331D04 Offset: 0x232DD04 VA: 0x2331D04 Slot: 11
	public override void Updata() { }

	// RVA: 0x2331D58 Offset: 0x232DD58 VA: 0x2331D58
	public void DamageFunction(PlayerActionManagerBase playerAction, SkillDamageData damageData) { }

	// RVA: 0x2331EE8 Offset: 0x232DEE8 VA: 0x2331EE8
	public void DamageFunction(PlayerActionManagerBase playerAction, MobaMobResponseData responseData) { }

	// RVA: 0x233207C Offset: 0x232E07C VA: 0x233207C
	public void NextParam(ItemDBData.ItemType type, int prevCount, byte level, PlayerStatusBase status, int takeUid) { }

	// RVA: 0x23321D0 Offset: 0x232E1D0 VA: 0x23321D0
	public void UpdateParam(ItemDBData.ItemType type, int cverlayCount, byte level, PlayerActionManagerBase playerAction) { }

	// RVA: 0x2332030 Offset: 0x232E030 VA: 0x2332030
	private void CalcParam(ItemDBData.ItemType type) { }

	// RVA: 0x2331BEC Offset: 0x232DBEC VA: 0x2331BEC
	private int GetGodSpearHandlingParam(SkillBufferId id) { }
}
