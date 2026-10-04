// Assembly: Assembly-CSharp.dll
// Namespace: 
public class SkillComboManager // TypeDefIndex: 3582
{
	// Fields
	public const int MaxComboLine = 20;
	private byte comboPoint; // 0x10
	private Dictionary<int, byte> useComboPointList; // 0x18
	private readonly Dictionary<byte, SkillComboLine> comboLines; // 0x20
	private SkillComboState comboState; // 0x28
	private SkillComboState currentActionCombo; // 0x30
	private Pair<PlayerAttackBase, byte> bloodyCombo; // 0x38
	private int bloodyValue; // 0x40

	// Properties
	public byte ComboPoint { get; }
	public List<SkillId> FirstSkillIds { get; }
	public List<SkillComboLine> SkillComboLines { get; }
	public SkillComboState CurrentComboState { get; }
	public bool ComboStarted { get; }
	public bool IsComboEnd { get; }
	public SkillComboState CurrentRunCombo { get; }
	public bool IsComboRun { get; }

	// Methods

	// RVA: 0x2391C04 Offset: 0x238DC04 VA: 0x2391C04
	public byte get_ComboPoint() { }

	// RVA: 0x2391C0C Offset: 0x238DC0C VA: 0x2391C0C
	public List<SkillId> get_FirstSkillIds() { }

	// RVA: 0x2391E1C Offset: 0x238DE1C VA: 0x2391E1C
	public List<SkillComboLine> get_SkillComboLines() { }

	// RVA: 0x2391E88 Offset: 0x238DE88 VA: 0x2391E88
	public SkillComboState get_CurrentComboState() { }

	// RVA: 0x2391E90 Offset: 0x238DE90 VA: 0x2391E90
	public bool get_ComboStarted() { }

	// RVA: 0x2391EE4 Offset: 0x238DEE4 VA: 0x2391EE4
	public bool get_IsComboEnd() { }

	// RVA: 0x2391EF4 Offset: 0x238DEF4 VA: 0x2391EF4
	public SkillComboState get_CurrentRunCombo() { }

	// RVA: 0x2391EFC Offset: 0x238DEFC VA: 0x2391EFC
	public bool get_IsComboRun() { }

	// RVA: 0x2391F0C Offset: 0x238DF0C VA: 0x2391F0C
	public void Initialize(byte comboPoint, SkillComboData[] data) { }

	// RVA: 0x2392254 Offset: 0x238E254 VA: 0x2392254
	public bool CheckFirstSkillId(SkillId skillId) { }

	// RVA: 0x23923FC Offset: 0x238E3FC VA: 0x23923FC
	public bool CheckEnableFirstSkillId(SkillId skillId) { }

	// RVA: 0x23925AC Offset: 0x238E5AC VA: 0x23925AC
	public SkillComboLine GetComboLine(byte id) { }

	// RVA: 0x239269C Offset: 0x238E69C VA: 0x239269C
	public void ComboLineUpdate(byte capacity) { }

	// RVA: 0x2392760 Offset: 0x238E760 VA: 0x2392760
	public byte GetComboLineReleasedPosition() { }

	// RVA: 0x239285C Offset: 0x238E85C VA: 0x239285C
	public void SetComboLine(byte id, SkillComboLine line) { }

	// RVA: 0x23928E0 Offset: 0x238E8E0 VA: 0x23928E0
	public void SetComboEnable(byte id, bool enable) { }

	// RVA: 0x2392960 Offset: 0x238E960 VA: 0x2392960
	public void SetComboPoint(int cp) { }

	// RVA: 0x2392968 Offset: 0x238E968 VA: 0x2392968
	public byte GetUseComboPoint(int id) { }

	// RVA: 0x23929FC Offset: 0x238E9FC VA: 0x23929FC
	public byte GetRestPoint(int id) { }

	// RVA: 0x2392090 Offset: 0x238E090 VA: 0x2392090
	public void UpdateComboPoint() { }

	// RVA: 0x2392A90 Offset: 0x238EA90 VA: 0x2392A90
	public void UpdateComboPoint(int id) { }

	// RVA: 0x2392B80 Offset: 0x238EB80 VA: 0x2392B80
	public SkillComboData[] GetComboData() { }

	// RVA: 0x2392E5C Offset: 0x238EE5C VA: 0x2392E5C
	public SkillComboData GetComboData(byte id) { }

	// RVA: 0x2392F40 Offset: 0x238EF40 VA: 0x2392F40
	public void Update() { }

	// RVA: 0x2392F44 Offset: 0x238EF44 VA: 0x2392F44
	public bool CheckCombo(SkillActionBase skill, SkillEqLimitFlag equip, PlayerActionManagerBase playerActionManager) { }

	// RVA: 0x23937E4 Offset: 0x238F7E4 VA: 0x23937E4
	public void EndCombo() { }

	// RVA: 0x2393804 Offset: 0x238F804 VA: 0x2393804
	public void ComboClear() { }

	// RVA: 0x23938B8 Offset: 0x238F8B8 VA: 0x23938B8
	public bool CheckCurrentComboType(SkillComboType type) { }

	// RVA: 0x2393958 Offset: 0x238F958 VA: 0x2393958
	public bool ComboStart(PlayerAttackBase skill) { }

	// RVA: 0x23938AC Offset: 0x238F8AC VA: 0x23938AC
	public void ComboRunEnd() { }

	// RVA: 0x2393D08 Offset: 0x238FD08 VA: 0x2393D08
	public bool CheckRunComboType(SkillComboType type) { }

	// RVA: 0x2393D30 Offset: 0x238FD30 VA: 0x2393D30
	public bool CheckStartingComboWorksProperly(PlayerActionManagerBase playerAction) { }

	// RVA: 0x2394168 Offset: 0x2390168 VA: 0x2394168
	public bool OverrideBloodSuckingSkill(PlayerAttackBase skill, bool resetDamage) { }

	// RVA: 0x23941D8 Offset: 0x23901D8 VA: 0x23941D8
	public bool CheckBloodSuckingSkill(int skillId, int localId) { }

	// RVA: 0x239426C Offset: 0x239026C VA: 0x239426C
	public void DamageAccumulation(SkillActionBase action, int damage) { }

	// RVA: 0x2394340 Offset: 0x2390340 VA: 0x2394340
	public void BloodySkillEnd(SkillActionBase action, PlayerStatusBase status) { }

	// RVA: 0x2394688 Offset: 0x2390688 VA: 0x2394688
	public int GetToughValue() { }

	// RVA: 0x23946BC Offset: 0x23906BC VA: 0x23946BC
	public bool CheckReflection() { }

	// RVA: 0x23946E4 Offset: 0x23906E4 VA: 0x23946E4
	public bool ReceiveReflectionDamage() { }

	// RVA: 0x239474C Offset: 0x239074C VA: 0x239474C
	public void .ctor() { }
}
