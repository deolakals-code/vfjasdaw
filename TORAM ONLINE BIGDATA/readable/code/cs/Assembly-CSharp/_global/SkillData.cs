// Assembly: Assembly-CSharp.dll
// Namespace: 
public class SkillData // TypeDefIndex: 3588
{
	// Fields
	[CompilerGenerated]
	private SkillMasterData <MasterData>k__BackingField; // 0x10
	[CompilerGenerated]
	private byte <Level>k__BackingField; // 0x18
	[CompilerGenerated]
	private SkillId <SkillId>k__BackingField; // 0x1C
	[CompilerGenerated]
	private SkillData.SettingFlag <Flag>k__BackingField; // 0x20

	// Properties
	public SkillMasterData MasterData { get; set; }
	public byte Level { get; set; }
	public SkillId SkillId { get; set; }
	public SkillData.SettingFlag Flag { get; set; }
	public bool IsNormal { get; }
	public bool IsStarGem { get; }
	public bool IsAvatar { get; }
	public bool IsNinja { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x23967B8 Offset: 0x23927B8 VA: 0x23967B8
	public SkillMasterData get_MasterData() { }

	[CompilerGenerated]
	// RVA: 0x23967C0 Offset: 0x23927C0 VA: 0x23967C0
	private void set_MasterData(SkillMasterData value) { }

	[CompilerGenerated]
	// RVA: 0x23967C8 Offset: 0x23927C8 VA: 0x23967C8
	public byte get_Level() { }

	[CompilerGenerated]
	// RVA: 0x23967D0 Offset: 0x23927D0 VA: 0x23967D0
	private void set_Level(byte value) { }

	[CompilerGenerated]
	// RVA: 0x23967D8 Offset: 0x23927D8 VA: 0x23967D8
	public SkillId get_SkillId() { }

	[CompilerGenerated]
	// RVA: 0x23967E0 Offset: 0x23927E0 VA: 0x23967E0
	private void set_SkillId(SkillId value) { }

	[CompilerGenerated]
	// RVA: 0x23967E8 Offset: 0x23927E8 VA: 0x23967E8
	public SkillData.SettingFlag get_Flag() { }

	[CompilerGenerated]
	// RVA: 0x23967F0 Offset: 0x23927F0 VA: 0x23967F0
	private void set_Flag(SkillData.SettingFlag value) { }

	// RVA: 0x23967F8 Offset: 0x23927F8 VA: 0x23967F8
	public bool get_IsNormal() { }

	// RVA: 0x2396808 Offset: 0x2392808 VA: 0x2396808
	public bool get_IsStarGem() { }

	// RVA: 0x2396818 Offset: 0x2392818 VA: 0x2396818
	public bool get_IsAvatar() { }

	// RVA: 0x2396828 Offset: 0x2392828 VA: 0x2396828
	public bool get_IsNinja() { }

	// RVA: 0x2396838 Offset: 0x2392838 VA: 0x2396838
	public void .ctor(SkillId id, byte lv, SkillMasterData master, SkillData.SettingFlag flag) { }

	// RVA: 0x239688C Offset: 0x239288C VA: 0x239688C
	public void UpdateLevel(byte lv) { }
}
