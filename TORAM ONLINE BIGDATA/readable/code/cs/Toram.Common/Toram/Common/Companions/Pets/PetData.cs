// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Companions.Pets
public class PetData : CompanionData // TypeDefIndex: 12950
{
	// Fields
	[CompilerGenerated]
	private int <MonsterUuid>k__BackingField; // 0x38
	[CompilerGenerated]
	private PetStatusData <Status>k__BackingField; // 0x40
	[CompilerGenerated]
	private PetPotentialData <Potential>k__BackingField; // 0x48
	[CompilerGenerated]
	private PetGameStatusData <GameStatus>k__BackingField; // 0x50
	[CompilerGenerated]
	private PetBattleStatusData <BattleStatus>k__BackingField; // 0x58
	[CompilerGenerated]
	private PetBreedStatusData <BreedStatus>k__BackingField; // 0x60
	[CompilerGenerated]
	private PetModelData <Model>k__BackingField; // 0x68
	[CompilerGenerated]
	private PetSkillData[] <SkillList>k__BackingField; // 0x70

	// Properties
	[UnityHash(Code = 184)]
	public int MonsterUuid { get; set; }
	[UnityHash(Code = 181, IsOptional = True)]
	public PetStatusData Status { get; set; }
	[UnityHash(Code = 85, IsOptional = True)]
	public PetPotentialData Potential { get; set; }
	[UnityHash(Code = 70, IsOptional = True)]
	public PetGameStatusData GameStatus { get; set; }
	[UnityHash(Code = 75, IsOptional = True)]
	public PetBattleStatusData BattleStatus { get; set; }
	[UnityHash(Code = 206, IsOptional = True)]
	public PetBreedStatusData BreedStatus { get; set; }
	[UnityHash(Code = 199, IsOptional = True)]
	public PetModelData Model { get; set; }
	[UnityHash(Code = 102, IsOptional = True)]
	public PetSkillData[] SkillList { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x367FBA4 Offset: 0x367BBA4 VA: 0x367FBA4
	public void .ctor() { }

	// RVA: 0x367D66C Offset: 0x367966C VA: 0x367D66C
	public void .ctor(Dictionary<object, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x367FBAC Offset: 0x367BBAC VA: 0x367FBAC
	public int get_MonsterUuid() { }

	[CompilerGenerated]
	// RVA: 0x367FBB4 Offset: 0x367BBB4 VA: 0x367FBB4
	public void set_MonsterUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x367FBBC Offset: 0x367BBBC VA: 0x367FBBC
	public PetStatusData get_Status() { }

	[CompilerGenerated]
	// RVA: 0x367FBC4 Offset: 0x367BBC4 VA: 0x367FBC4
	public void set_Status(PetStatusData value) { }

	[CompilerGenerated]
	// RVA: 0x367FBCC Offset: 0x367BBCC VA: 0x367FBCC
	public PetPotentialData get_Potential() { }

	[CompilerGenerated]
	// RVA: 0x367FBD4 Offset: 0x367BBD4 VA: 0x367FBD4
	public void set_Potential(PetPotentialData value) { }

	[CompilerGenerated]
	// RVA: 0x367FBDC Offset: 0x367BBDC VA: 0x367FBDC
	public PetGameStatusData get_GameStatus() { }

	[CompilerGenerated]
	// RVA: 0x367FBE4 Offset: 0x367BBE4 VA: 0x367FBE4
	public void set_GameStatus(PetGameStatusData value) { }

	[CompilerGenerated]
	// RVA: 0x367FBEC Offset: 0x367BBEC VA: 0x367FBEC
	public PetBattleStatusData get_BattleStatus() { }

	[CompilerGenerated]
	// RVA: 0x367FBF4 Offset: 0x367BBF4 VA: 0x367FBF4
	public void set_BattleStatus(PetBattleStatusData value) { }

	[CompilerGenerated]
	// RVA: 0x367FBFC Offset: 0x367BBFC VA: 0x367FBFC
	public PetBreedStatusData get_BreedStatus() { }

	[CompilerGenerated]
	// RVA: 0x367FC04 Offset: 0x367BC04 VA: 0x367FC04
	public void set_BreedStatus(PetBreedStatusData value) { }

	[CompilerGenerated]
	// RVA: 0x367FC0C Offset: 0x367BC0C VA: 0x367FC0C
	public PetModelData get_Model() { }

	[CompilerGenerated]
	// RVA: 0x367FC14 Offset: 0x367BC14 VA: 0x367FC14
	public void set_Model(PetModelData value) { }

	[CompilerGenerated]
	// RVA: 0x367FC1C Offset: 0x367BC1C VA: 0x367FC1C
	public PetSkillData[] get_SkillList() { }

	[CompilerGenerated]
	// RVA: 0x367FC24 Offset: 0x367BC24 VA: 0x367FC24
	public void set_SkillList(PetSkillData[] value) { }

	// RVA: 0x367FC2C Offset: 0x367BC2C VA: 0x367FC2C
	private void SetClass(Dictionary<object, object> parameters) { }

	// RVA: 0x3680234 Offset: 0x367C234 VA: 0x3680234
	private void GetClass(Dictionary<object, object> parameters) { }

	// RVA: 0x36804D4 Offset: 0x367C4D4 VA: 0x36804D4 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36804DC Offset: 0x367C4DC VA: 0x36804DC Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }

	// RVA: 0x368064C Offset: 0x367C64C VA: 0x368064C Slot: 6
	public override Dictionary<object, object> GetValue() { }
}
