// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations
public interface IStatusData // TypeDefIndex: 11358
{
	// Properties
	public abstract PrimaryStatusData PrimaryStatus { get; }
	public abstract GameStatusData GameStatus { get; }
	public abstract AvatarGameStatusData AvatarGameStatus { get; }
	public abstract Dictionary<short, byte> SkillList { get; }
	public abstract SkillComboData[] SkillCombo { get; }
	public abstract ProficiencyData ProficiencyData { get; }
	public abstract StarGemEquipData[] StarGemEquips { get; }
	public abstract RegistletData RegistletData { get; }
	public abstract GemCartData[] GemCartBag { get; }
	public abstract GemCartEquipData[] GemCartEquipList { get; }
	public abstract Dictionary<short, byte[]> ExSkillConfigList { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract PrimaryStatusData get_PrimaryStatus();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract GameStatusData get_GameStatus();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract AvatarGameStatusData get_AvatarGameStatus();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract Dictionary<short, byte> get_SkillList();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract SkillComboData[] get_SkillCombo();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract ProficiencyData get_ProficiencyData();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract StarGemEquipData[] get_StarGemEquips();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract RegistletData get_RegistletData();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract GemCartData[] get_GemCartBag();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract GemCartEquipData[] get_GemCartEquipList();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract Dictionary<short, byte[]> get_ExSkillConfigList();
}
