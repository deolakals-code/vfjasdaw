// Assembly: Assembly-CSharp.dll
// Namespace: 
public class ItemRandomPropertyData // TypeDefIndex: 2030
{
	// Fields
	[CompilerGenerated]
	private bool <IsValid>k__BackingField; // 0x10
	private readonly ItemRandomPropertyMasterData master; // 0x18
	private float leftTime; // 0x20
	private float coolDownLeftTime; // 0x24
	private short stack; // 0x28
	private static List<BonusType> instantBonusList; // 0x0
	private static List<BonusType> damageBonusList; // 0x8

	// Properties
	public short PropertyId { get; }
	public ActStatusType ActStatus { get; }
	public float ReflectionRate { get; }
	public ItemRandomPropertyConditionType ConditionType1 { get; }
	public int ConditionValue1 { get; }
	public ItemRandomPropertyConditionType ConditionType2 { get; }
	public int ConditionValue2 { get; }
	public byte EffectTime { get; }
	public byte EffectStatus { get; }
	public short EffectReflectionRate { get; }
	public float CoolDownTime { get; }
	public bool IsValid { get; set; }
	public float CoolDownLeftTime { get; }
	public float EffectLeftTime { get; }
	public short Stack { get; }
	public byte StackStatus { get; }
	public int StackReflectionRate { get; }

	// Methods

	// RVA: 0x2137800 Offset: 0x2133800 VA: 0x2137800
	public void .ctor(ItemRandomPropertyMasterData master) { }

	// RVA: 0x2137830 Offset: 0x2133830 VA: 0x2137830
	public short get_PropertyId() { }

	// RVA: 0x213784C Offset: 0x213384C VA: 0x213784C
	public ActStatusType get_ActStatus() { }

	// RVA: 0x2137868 Offset: 0x2133868 VA: 0x2137868
	public float get_ReflectionRate() { }

	// RVA: 0x2137890 Offset: 0x2133890 VA: 0x2137890
	public ItemRandomPropertyConditionType get_ConditionType1() { }

	// RVA: 0x21378AC Offset: 0x21338AC VA: 0x21378AC
	public int get_ConditionValue1() { }

	// RVA: 0x21378C8 Offset: 0x21338C8 VA: 0x21378C8
	public ItemRandomPropertyConditionType get_ConditionType2() { }

	// RVA: 0x21378E4 Offset: 0x21338E4 VA: 0x21378E4
	public int get_ConditionValue2() { }

	// RVA: 0x2137900 Offset: 0x2133900 VA: 0x2137900
	public byte get_EffectTime() { }

	// RVA: 0x213791C Offset: 0x213391C VA: 0x213791C
	public byte get_EffectStatus() { }

	// RVA: 0x2137938 Offset: 0x2133938 VA: 0x2137938
	public short get_EffectReflectionRate() { }

	// RVA: 0x2137954 Offset: 0x2133954 VA: 0x2137954
	public float get_CoolDownTime() { }

	[CompilerGenerated]
	// RVA: 0x2137974 Offset: 0x2133974 VA: 0x2137974
	public bool get_IsValid() { }

	[CompilerGenerated]
	// RVA: 0x213797C Offset: 0x213397C VA: 0x213797C
	private void set_IsValid(bool value) { }

	// RVA: 0x2137988 Offset: 0x2133988 VA: 0x2137988
	public float get_CoolDownLeftTime() { }

	// RVA: 0x2137990 Offset: 0x2133990 VA: 0x2137990
	public float get_EffectLeftTime() { }

	// RVA: 0x2137998 Offset: 0x2133998 VA: 0x2137998
	public short get_Stack() { }

	// RVA: 0x21379A0 Offset: 0x21339A0 VA: 0x21379A0
	public byte get_StackStatus() { }

	// RVA: 0x21379BC Offset: 0x21339BC VA: 0x21379BC
	public int get_StackReflectionRate() { }

	// RVA: 0x21379D8 Offset: 0x21339D8 VA: 0x21379D8
	public void Update() { }

	// RVA: 0x2137A58 Offset: 0x2133A58 VA: 0x2137A58
	public void Active(short stack, PlayerStatusBase playerStatus) { }

	// RVA: 0x2137A48 Offset: 0x2133A48 VA: 0x2137A48
	public void Stop() { }

	// RVA: 0x2137B4C Offset: 0x2133B4C VA: 0x2137B4C
	public List<BonusParameter> ToBonusParameter() { }

	// RVA: 0x2137D94 Offset: 0x2133D94 VA: 0x2137D94
	public Dictionary<BonusType, short> GetDamageBonusParameter() { }

	// RVA: 0x2137EFC Offset: 0x2133EFC VA: 0x2137EFC
	public int GetAddStatus(byte type, PlayerStatusBase playerStatus) { }

	// RVA: 0x2137AB4 Offset: 0x2133AB4 VA: 0x2137AB4
	public int GetEffectTime(PlayerStatusBase playerStatus) { }

	// RVA: 0x2138934 Offset: 0x2134934 VA: 0x2138934
	public int GetMaxStack(PlayerStatusBase playerStatus) { }

	// RVA: 0x21389CC Offset: 0x21349CC VA: 0x21389CC
	public bool IsStackIcon() { }

	// RVA: 0x2138A04 Offset: 0x2134A04 VA: 0x2138A04
	private static void .cctor() { }
}
