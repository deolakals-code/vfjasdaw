// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MobaTreasureBonusManager // TypeDefIndex: 2128
{
	// Fields
	[CompilerGenerated]
	private bool <IsPeaceFlower>k__BackingField; // 0x10
	public const int MaxBonusSlotNum = 2;
	private const float PeaceFlowerCoolDownTime = 10;
	private readonly MobaTreasureBonusDataBase[] bonusSlot; // 0x18
	private float peaceFlowerCoolDownTimer; // 0x20
	private float detectionSlabTimer; // 0x24

	// Properties
	public bool IsInvincible { get; }
	public bool IsPeaceFlower { get; set; }

	// Methods

	// RVA: 0x2147054 Offset: 0x2143054 VA: 0x2147054
	public bool get_IsInvincible() { }

	[CompilerGenerated]
	// RVA: 0x214705C Offset: 0x214305C VA: 0x214705C
	public bool get_IsPeaceFlower() { }

	[CompilerGenerated]
	// RVA: 0x2147064 Offset: 0x2143064 VA: 0x2147064
	private void set_IsPeaceFlower(bool value) { }

	// RVA: 0x2147070 Offset: 0x2143070 VA: 0x2147070
	public void .ctor() { }

	// RVA: 0x21470E0 Offset: 0x21430E0 VA: 0x21470E0
	public void Initialize() { }

	// RVA: 0x21470EC Offset: 0x21430EC VA: 0x21470EC
	public void Update() { }

	// RVA: 0x2147144 Offset: 0x2143144 VA: 0x2147144
	public void MoveAction() { }

	// RVA: 0x214714C Offset: 0x214314C VA: 0x214714C
	public void UpdateBonus(short[] supplyEquips) { }

	// RVA: 0x214721C Offset: 0x214321C VA: 0x214721C
	public void AddBonus(byte slotNo, short itemId) { }

	// RVA: 0x21471CC Offset: 0x21431CC VA: 0x21471CC
	public void RemoveBonus(byte slotNo) { }

	// RVA: 0x21472B4 Offset: 0x21432B4 VA: 0x21472B4
	public bool CheckEquipSlotNo(byte slotNo) { }

	// RVA: 0x21476E0 Offset: 0x21436E0 VA: 0x21476E0
	public bool CheckEmpty(byte slotNo) { }

	// RVA: 0x2147730 Offset: 0x2143730 VA: 0x2147730
	public int GetSlotItemId(byte slotNo) { }

	// RVA: 0x2147794 Offset: 0x2143794 VA: 0x2147794
	public MobaTreasureBonusDataBase GetSlotBonusData(byte slotNo) { }

	// RVA: 0x21477E0 Offset: 0x21437E0 VA: 0x21477E0
	public bool TryGetGroupBonus(MobaTreasureBonusGroup group, out MobaTreasureBonusDataBase slot1, out MobaTreasureBonusDataBase slot2) { }

	// RVA: 0x21478F0 Offset: 0x21438F0 VA: 0x21478F0
	public bool TryGetEmptySlotNo(out byte slotNo) { }

	// RVA: 0x2147940 Offset: 0x2143940 VA: 0x2147940
	public bool[] CheckCanUseBonus() { }

	// RVA: 0x21472E4 Offset: 0x21432E4 VA: 0x21472E4
	public static MobaTreasureBonusDataBase CreateBonus(short itemId) { }

	// RVA: 0x2147A48 Offset: 0x2143A48 VA: 0x2147A48
	public int ActivationDetectionSlabLevel() { }

	// RVA: 0x2147B34 Offset: 0x2143B34 VA: 0x2147B34
	public bool PeaceFlower(PlayerStatusBase status, out float invincibleTimer) { }
}
