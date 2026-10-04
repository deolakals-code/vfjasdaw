// Assembly: Assembly-CSharp.dll
// Namespace: 
[Serializable]
public class BlackKnightPlayerStatus // TypeDefIndex: 4169
{
	// Fields
	[SerializeField]
	private string name; // 0x10
	private Dictionary<BlackKnightPlayerStatus.InvincibleType, float> invincibleTimer; // 0x18
	private readonly Dictionary<BlackKnightPlayerStatus.InvincibleType, float> invincibleTimeList; // 0x20
	private int hp; // 0x28
	private int maxHp; // 0x2C
	private readonly int recoveryResurrectionHp; // 0x30
	private int mp; // 0x34
	private const int maxMp = 10;
	private float recoveryMpTimer; // 0x38
	private const float recoveryMpTime = 3;
	private int atk; // 0x3C
	private readonly int defaultAtk; // 0x40
	private int mAtk; // 0x44
	private readonly int defaultMAtk; // 0x48
	private int def; // 0x4C
	private int maxDef; // 0x50
	private const int defaultMaxDef = 10;
	private float recoveryDefTimer; // 0x54
	private readonly Dictionary<BlackKnightPlayerStatus.DefRecoveryTimeType, float> recoveryDefIntervalTime; // 0x58
	private bool isStartRecoveryDef; // 0x60
	private int crt; // 0x64
	private Action endMirageStepCallback; // 0x68
	private List<BlackKnightCristaId> equipCristaList; // 0x70
	private readonly Dictionary<BlackKnightCristaId, byte> hpUpCristaList; // 0x78
	private readonly Dictionary<BlackKnightCristaId, byte> defUpCristaList; // 0x80
	private readonly Dictionary<BlackKnightCristaId, byte> atkUpCristaList; // 0x88
	private readonly Dictionary<BlackKnightCristaId, byte> mAtkUpCristaList; // 0x90
	private readonly Dictionary<BlackKnightCristaId, byte> crtUpCristaList; // 0x98
	private readonly Dictionary<BlackKnightCristaId, byte> discountCristaList; // 0xA0
	private readonly Dictionary<BlackKnightCristaId, byte> firstAidCristaList; // 0xA8
	[CompilerGenerated]
	private bool <IsInit>k__BackingField; // 0xB0
	[CompilerGenerated]
	private int <RecoveryCount>k__BackingField; // 0xB4

	// Properties
	public bool IsInit { get; set; }
	public string Name { get; }
	public int Hp { get; }
	public int Mp { get; }
	public int Crt { get; }
	public int Atk { get; }
	public int MAtk { get; }
	public int Def { get; }
	public bool IsDead { get; }
	public bool IsInvincible { get; }
	public float MaxHp { get; }
	public int RecoveryCount { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x249EEF8 Offset: 0x249AEF8 VA: 0x249EEF8
	public bool get_IsInit() { }

	[CompilerGenerated]
	// RVA: 0x249EF00 Offset: 0x249AF00 VA: 0x249EF00
	private void set_IsInit(bool value) { }

	// RVA: 0x249EF0C Offset: 0x249AF0C VA: 0x249EF0C
	public string get_Name() { }

	// RVA: 0x249EF14 Offset: 0x249AF14 VA: 0x249EF14
	public int get_Hp() { }

	// RVA: 0x249EF1C Offset: 0x249AF1C VA: 0x249EF1C
	public int get_Mp() { }

	// RVA: 0x249EF24 Offset: 0x249AF24 VA: 0x249EF24
	public int get_Crt() { }

	// RVA: 0x249EF2C Offset: 0x249AF2C VA: 0x249EF2C
	public int get_Atk() { }

	// RVA: 0x249EF34 Offset: 0x249AF34 VA: 0x249EF34
	public int get_MAtk() { }

	// RVA: 0x249EF3C Offset: 0x249AF3C VA: 0x249EF3C
	public int get_Def() { }

	// RVA: 0x249CAD4 Offset: 0x2498AD4 VA: 0x249CAD4
	public bool get_IsDead() { }

	// RVA: 0x2494B68 Offset: 0x2490B68 VA: 0x2494B68
	public bool get_IsInvincible() { }

	// RVA: 0x249EF44 Offset: 0x249AF44 VA: 0x249EF44
	public float get_MaxHp() { }

	[CompilerGenerated]
	// RVA: 0x249EF50 Offset: 0x249AF50 VA: 0x249EF50
	public int get_RecoveryCount() { }

	[CompilerGenerated]
	// RVA: 0x249EF58 Offset: 0x249AF58 VA: 0x249EF58
	private void set_RecoveryCount(int value) { }

	// RVA: 0x2499EDC Offset: 0x2495EDC VA: 0x2499EDC
	public void Initialize(string name, int[] reinforceCounts) { }

	// RVA: 0x249ADA0 Offset: 0x2496DA0 VA: 0x249ADA0
	public void UpdateStatus(bool isGround) { }

	// RVA: 0x2495B0C Offset: 0x2491B0C VA: 0x2495B0C
	public float GetDefPercent() { }

	// RVA: 0x249C78C Offset: 0x249878C VA: 0x249C78C
	public bool Damage(int damage) { }

	// RVA: 0x249F054 Offset: 0x249B054 VA: 0x249F054
	public void SetHp(int setHp) { }

	// RVA: 0x2496434 Offset: 0x2492434 VA: 0x2496434
	public void AddHp(int addHp) { }

	// RVA: 0x2496388 Offset: 0x2492388 VA: 0x2496388
	public void AddAtk(int add) { }

	// RVA: 0x24963D8 Offset: 0x24923D8 VA: 0x24963D8
	public void AddDef(int add) { }

	// RVA: 0x24964B4 Offset: 0x24924B4 VA: 0x24964B4
	public void AddMAtk(int add) { }

	// RVA: 0x249F05C Offset: 0x249B05C VA: 0x249F05C
	public bool EnoughMp(int use) { }

	// RVA: 0x249D45C Offset: 0x249945C VA: 0x249D45C
	public bool PaySkillMp(int use) { }

	// RVA: 0x249D020 Offset: 0x2499020 VA: 0x249D020
	public void StartMpRecovery() { }

	// RVA: 0x249EF60 Offset: 0x249AF60 VA: 0x249EF60
	private void InitializeCrista() { }

	// RVA: 0x249F1F8 Offset: 0x249B1F8 VA: 0x249F1F8
	public void ChangeCrstaState(int id) { }

	// RVA: 0x249F06C Offset: 0x249B06C VA: 0x249F06C
	public void ChangeCrstaState(BlackKnightCristaId id) { }

	// RVA: 0x249F150 Offset: 0x249B150 VA: 0x249F150
	public void InitCristaStatus() { }

	// RVA: 0x24967CC Offset: 0x24927CC VA: 0x24967CC
	public bool ContainsEquipCrista(BlackKnightCristaId id) { }

	// RVA: 0x2496520 Offset: 0x2492520 VA: 0x2496520
	public int GetCristaBonus(BlackKnightPlayerStatus.CristaStatusType type) { }

	// RVA: 0x249C1F0 Offset: 0x24981F0 VA: 0x249C1F0
	public bool InvokeMirageStep(Action endCallback) { }

	// RVA: 0x249991C Offset: 0x249591C VA: 0x249991C
	public void .ctor() { }
}
