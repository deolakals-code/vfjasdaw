// Assembly: Assembly-CSharp.dll
// Namespace: 
[Serializable]
public class MobStatusMaster // TypeDefIndex: 1029
{
	// Fields
	public const int DungeonRate = 1000000;
	[SerializeField]
	private int id; // 0x10
	[SerializeField]
	private int uuid; // 0x14
	[SerializeField]
	private byte roomId; // 0x18
	[SerializeField]
	private string name; // 0x20
	[SerializeField]
	private int lv; // 0x28
	[SerializeField]
	private int exp; // 0x2C
	[SerializeField]
	private int maxHp; // 0x30
	[SerializeField]
	private byte expDefNormal; // 0x34
	[SerializeField]
	private byte expDefSkill; // 0x35
	[SerializeField]
	private byte expDefMagic; // 0x36
	[SerializeField]
	private int necessaryHit; // 0x38
	[SerializeField]
	private int def; // 0x3C
	[SerializeField]
	private int mdef; // 0x40
	[SerializeField]
	private int cutAtk; // 0x44
	[SerializeField]
	private int cutMatk; // 0x48
	[SerializeField]
	private int guard; // 0x4C
	[SerializeField]
	private int avoid; // 0x50
	[SerializeField]
	private ElementType element; // 0x54
	[SerializeField]
	private MobMultiFlag flag; // 0x58
	[SerializeField]
	private int model; // 0x5C
	[SerializeField]
	private byte size; // 0x60
	[SerializeField]
	private int scale; // 0x64
	[SerializeField]
	private int color1; // 0x68
	[SerializeField]
	private int color2; // 0x6C
	[SerializeField]
	private int color3; // 0x70
	[SerializeField]
	private int moveSpeed; // 0x74
	[SerializeField]
	private byte persona; // 0x78
	[SerializeField]
	private int personaValue; // 0x7C
	private Dictionary<int, MobActionPattern> actionPatternList; // 0x80
	private Dictionary<int, MobActionPattern> exActionPatternList; // 0x88
	private Dictionary<int, int> partsList; // 0x90
	private Dictionary<int, MobModeData> modeList; // 0x98
	public MobPropertyManager mobPropertyMaster; // 0xA0
	private MobHyperModeGroup hyperModeGroup; // 0xA8
	[CompilerGenerated]
	private int <FieldId>k__BackingField; // 0xB0
	[CompilerGenerated]
	private int <ActionTotalProbability>k__BackingField; // 0xB4

	// Properties
	public int FieldId { get; set; }
	public int Id { get; }
	public int Uuid { get; }
	public byte RoomId { get; }
	public string Name { get; }
	public int Level { get; }
	public int Exp { get; }
	public int MaxHp { get; }
	public byte ExpDefNormal { get; }
	public byte ExpDefSkill { get; }
	public byte ExpDefMagic { get; }
	public int NecessaryHit { get; }
	public int Def { get; }
	public int MagicDef { get; }
	public int CutAttack { get; }
	public int CutMagicAttack { get; }
	public int GuardProbability { get; }
	public int AvoidProbability { get; }
	public MobMultiFlag MultiFlag { get; }
	public ElementType Element { get; }
	public int Model { get; }
	public int Size { get; }
	public int Scale { get; }
	public int Color1 { get; }
	public int Color2 { get; }
	public int Color3 { get; }
	public int MoveSpeed { get; }
	public byte Persona { get; }
	public int PersonaValue { get; }
	public int ActionTotalProbability { get; set; }
	public Dictionary<int, MobActionPattern> ActionPattern { get; }
	public Dictionary<int, MobActionPattern> ExtensionActionPattern { get; }
	public Dictionary<int, int> PartsList { get; }
	public Dictionary<int, MobModeData> ModeList { get; }
	public MobPropertyManager MobPropertyMaster { get; }
	public MobHyperModeGroup HyperModeGroup { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1F376A0 Offset: 0x1F336A0 VA: 0x1F376A0
	public int get_FieldId() { }

	[CompilerGenerated]
	// RVA: 0x1F376A8 Offset: 0x1F336A8 VA: 0x1F376A8
	private void set_FieldId(int value) { }

	// RVA: 0x1F376B0 Offset: 0x1F336B0 VA: 0x1F376B0
	public int get_Id() { }

	// RVA: 0x1F376B8 Offset: 0x1F336B8 VA: 0x1F376B8
	public int get_Uuid() { }

	// RVA: 0x1F376C0 Offset: 0x1F336C0 VA: 0x1F376C0
	public byte get_RoomId() { }

	// RVA: 0x1F376C8 Offset: 0x1F336C8 VA: 0x1F376C8
	public string get_Name() { }

	// RVA: 0x1F376D0 Offset: 0x1F336D0 VA: 0x1F376D0
	public int get_Level() { }

	// RVA: 0x1F376D8 Offset: 0x1F336D8 VA: 0x1F376D8
	public int get_Exp() { }

	// RVA: 0x1F376E0 Offset: 0x1F336E0 VA: 0x1F376E0
	public int get_MaxHp() { }

	// RVA: 0x1F376E8 Offset: 0x1F336E8 VA: 0x1F376E8
	public byte get_ExpDefNormal() { }

	// RVA: 0x1F376F0 Offset: 0x1F336F0 VA: 0x1F376F0
	public byte get_ExpDefSkill() { }

	// RVA: 0x1F376F8 Offset: 0x1F336F8 VA: 0x1F376F8
	public byte get_ExpDefMagic() { }

	// RVA: 0x1F37700 Offset: 0x1F33700 VA: 0x1F37700
	public int get_NecessaryHit() { }

	// RVA: 0x1F37708 Offset: 0x1F33708 VA: 0x1F37708
	public int get_Def() { }

	// RVA: 0x1F37710 Offset: 0x1F33710 VA: 0x1F37710
	public int get_MagicDef() { }

	// RVA: 0x1F37718 Offset: 0x1F33718 VA: 0x1F37718
	public int get_CutAttack() { }

	// RVA: 0x1F37720 Offset: 0x1F33720 VA: 0x1F37720
	public int get_CutMagicAttack() { }

	// RVA: 0x1F37728 Offset: 0x1F33728 VA: 0x1F37728
	public int get_GuardProbability() { }

	// RVA: 0x1F37730 Offset: 0x1F33730 VA: 0x1F37730
	public int get_AvoidProbability() { }

	// RVA: 0x1F37738 Offset: 0x1F33738 VA: 0x1F37738
	public MobMultiFlag get_MultiFlag() { }

	// RVA: 0x1F37740 Offset: 0x1F33740 VA: 0x1F37740
	public ElementType get_Element() { }

	// RVA: 0x1F37748 Offset: 0x1F33748 VA: 0x1F37748
	public int get_Model() { }

	// RVA: 0x1F37750 Offset: 0x1F33750 VA: 0x1F37750
	public int get_Size() { }

	// RVA: 0x1F37758 Offset: 0x1F33758 VA: 0x1F37758
	public int get_Scale() { }

	// RVA: 0x1F37760 Offset: 0x1F33760 VA: 0x1F37760
	public int get_Color1() { }

	// RVA: 0x1F37768 Offset: 0x1F33768 VA: 0x1F37768
	public int get_Color2() { }

	// RVA: 0x1F37770 Offset: 0x1F33770 VA: 0x1F37770
	public int get_Color3() { }

	// RVA: 0x1F37778 Offset: 0x1F33778 VA: 0x1F37778
	public int get_MoveSpeed() { }

	// RVA: 0x1F37780 Offset: 0x1F33780 VA: 0x1F37780
	public byte get_Persona() { }

	// RVA: 0x1F37788 Offset: 0x1F33788 VA: 0x1F37788
	public int get_PersonaValue() { }

	[CompilerGenerated]
	// RVA: 0x1F37790 Offset: 0x1F33790 VA: 0x1F37790
	public int get_ActionTotalProbability() { }

	[CompilerGenerated]
	// RVA: 0x1F37798 Offset: 0x1F33798 VA: 0x1F37798
	private void set_ActionTotalProbability(int value) { }

	// RVA: 0x1F377A0 Offset: 0x1F337A0 VA: 0x1F377A0
	public Dictionary<int, MobActionPattern> get_ActionPattern() { }

	// RVA: 0x1F377A8 Offset: 0x1F337A8 VA: 0x1F377A8
	public Dictionary<int, MobActionPattern> get_ExtensionActionPattern() { }

	// RVA: 0x1F377B0 Offset: 0x1F337B0 VA: 0x1F377B0
	public Dictionary<int, int> get_PartsList() { }

	// RVA: 0x1F377B8 Offset: 0x1F337B8 VA: 0x1F377B8
	public Dictionary<int, MobModeData> get_ModeList() { }

	// RVA: 0x1F377C0 Offset: 0x1F337C0 VA: 0x1F377C0
	public MobPropertyManager get_MobPropertyMaster() { }

	// RVA: 0x1F377C8 Offset: 0x1F337C8 VA: 0x1F377C8
	public MobHyperModeGroup get_HyperModeGroup() { }

	// RVA: 0x1F377D0 Offset: 0x1F337D0 VA: 0x1F377D0
	public MobActionPattern GetActionPattern(int id) { }

	// RVA: 0x1F37864 Offset: 0x1F33864 VA: 0x1F37864
	public void SetMobPropertyMaster(MobPropertyMaster[] masterData) { }

	// RVA: 0x1F3788C Offset: 0x1F3388C VA: 0x1F3788C
	public void SetMobHyperModeGroup(MobHyperModeGroup group) { }

	// RVA: 0x1F37894 Offset: 0x1F33894 VA: 0x1F37894
	public static MobStatusMaster CreateStatusMaster(int fieldId, int version, BinaryReader reader) { }

	// RVA: 0x1F37D9C Offset: 0x1F33D9C VA: 0x1F37D9C
	public void .ctor() { }
}
