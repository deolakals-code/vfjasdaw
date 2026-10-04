// Assembly: Assembly-CSharp.dll
// Namespace: 
[Serializable]
public class GemCartBufferManager // TypeDefIndex: 2244
{
	// Fields
	private PlayerDataManager playerDataManager; // 0x10
	private Dictionary<short, GemCartBufferBase> gemCartBufList; // 0x18
	private List<GemCartId> relatedPetStatusGemCartIdList; // 0x20
	private List<GemCartId> relatedMercenaryStatusGemCartIdList; // 0x28

	// Methods

	// RVA: 0x21762CC Offset: 0x21722CC VA: 0x21762CC
	public void .ctor(Transform actor) { }

	// RVA: 0x2176590 Offset: 0x2172590 VA: 0x2176590
	public void Initialize(GemCartData[] cartData, GemCartEquipData[] equips) { }

	// RVA: 0x2176FE0 Offset: 0x2172FE0 VA: 0x2176FE0
	public bool ContainsBuffer(short id) { }

	// RVA: 0x2177038 Offset: 0x2173038 VA: 0x2177038
	public GemCartBufferBase GetGemCartBuffer(short id) { }

	// RVA: 0x21770D8 Offset: 0x21730D8 VA: 0x21770D8
	public int GetBufferLevel(short id) { }

	// RVA: 0x2177170 Offset: 0x2173170 VA: 0x2177170
	public void Update() { }

	// RVA: 0x21772D0 Offset: 0x21732D0 VA: 0x21772D0
	public void RemoveGemCartBuffer(short id) { }

	// RVA: 0x2176844 Offset: 0x2172844 VA: 0x2176844
	public void ClearBuffer() { }

	// RVA: 0x2176A6C Offset: 0x2172A6C VA: 0x2176A6C
	public void UpdateEquipGemCartData(short id, short updateLv) { }

	// RVA: 0x2177720 Offset: 0x2173720 VA: 0x2177720
	public void UpdatePetGemCart(PetMember pet) { }

	// RVA: 0x2177978 Offset: 0x2173978 VA: 0x2177978
	public void UpdateMercenaryGemCart(MercenaryMember mercenary) { }

	// RVA: 0x2177BD0 Offset: 0x2173BD0 VA: 0x2177BD0
	public void ChangeEquipGemCartData(UpdateGemCartData[] equips) { }

	// RVA: 0x2177D84 Offset: 0x2173D84 VA: 0x2177D84
	public void ClearBuffCoolDown() { }

	// RVA: 0x2177ED8 Offset: 0x2173ED8 VA: 0x2177ED8
	public float GetBufferValue(GemCartBufferId id) { }

	// RVA: 0x2178050 Offset: 0x2174050 VA: 0x2178050
	public float GetRecieveDamageRate(PlayerStatusBase status, Transform damageTrans, MobAttackBase mobAttack) { }

	// RVA: 0x2178640 Offset: 0x2174640 VA: 0x2178640
	public float GetLastDamageRate(PlayerStatusBase status) { }

	// RVA: 0x21787BC Offset: 0x21747BC VA: 0x21787BC
	public float GetNormalAttackRate() { }

	// RVA: 0x21787C4 Offset: 0x21747C4 VA: 0x21787C4
	public ElementType GetTalentElementType() { }
}
