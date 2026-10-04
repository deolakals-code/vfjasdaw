// Assembly: Assembly-CSharp.dll
// Namespace: 
[Serializable]
public class MobActionPattern // TypeDefIndex: 918
{
	// Fields
	[SerializeField]
	private short commandId; // 0x10
	[SerializeField]
	private int attack; // 0x14
	[SerializeField]
	private byte stable; // 0x18
	[SerializeField]
	private byte range; // 0x19
	[SerializeField]
	private float delay; // 0x1C
	[SerializeField]
	private ElementType element; // 0x20
	[SerializeField]
	private byte crt; // 0x24
	[SerializeField]
	private int crtDmg; // 0x28
	[SerializeField]
	private int flee; // 0x2C
	[SerializeField]
	private int effect; // 0x30
	[SerializeField]
	private int effectGrant; // 0x34
	[SerializeField]
	private int effectTime; // 0x38
	[SerializeField]
	private MobActionType type; // 0x3C
	[SerializeField]
	private byte motion; // 0x40
	[SerializeField]
	private float startSoundTiming; // 0x44
	[SerializeField]
	private int startSoundEffect; // 0x48
	[SerializeField]
	private float attackSoundTiming; // 0x4C
	[SerializeField]
	private int attackSoundEffect; // 0x50
	[SerializeField]
	private int hitEffectId; // 0x54
	[SerializeField]
	private byte hitEffectMotionNo; // 0x58
	[SerializeField]
	private short combo; // 0x5A
	[SerializeField]
	private int[] val; // 0x60
	[SerializeField]
	private int probability; // 0x68
	[SerializeField]
	private short commonFlag; // 0x6C

	// Properties
	public int CommandId { get; }
	public int Attack { get; }
	public int Stable { get; }
	public int Range { get; }
	public float Delay { get; }
	public ElementType Element { get; }
	public int Crt { get; }
	public int CrtDmg { get; }
	public int Flee { get; }
	public int Effect { get; }
	public int EffectGrant { get; }
	public int EffectTime { get; }
	public MobActionType ActionType { get; }
	public int Motion { get; }
	public float StartSoundTiming { get; }
	public int StartSound { get; }
	public float AttackSoundTiming { get; }
	public int AttackSound { get; }
	public int HitEffectId { get; }
	public int HitEffectMotion { get; }
	public int Combo { get; }
	public int Probability { get; }
	public short CommonFlag { get; }
	public int Value1 { get; }
	public int Value2 { get; }
	public int Value3 { get; }
	public int Value4 { get; }
	public int Value5 { get; }
	public int Value6 { get; }
	public int Value7 { get; }
	public int Value8 { get; }
	public int Value9 { get; }
	public int Value10 { get; }
	public int Value11 { get; }
	public int Value12 { get; }
	public int Value13 { get; }
	public int Value14 { get; }
	public int Value15 { get; }
	public int Value16 { get; }
	public int Value17 { get; }
	public int Value18 { get; }
	public int Value19 { get; }
	public int Value20 { get; }

	// Methods

	// RVA: 0x1F0458C Offset: 0x1F0058C VA: 0x1F0458C
	public int get_CommandId() { }

	// RVA: 0x1F04594 Offset: 0x1F00594 VA: 0x1F04594
	public int get_Attack() { }

	// RVA: 0x1F0459C Offset: 0x1F0059C VA: 0x1F0459C
	public int get_Stable() { }

	// RVA: 0x1F045A4 Offset: 0x1F005A4 VA: 0x1F045A4
	public int get_Range() { }

	// RVA: 0x1F045AC Offset: 0x1F005AC VA: 0x1F045AC
	public float get_Delay() { }

	// RVA: 0x1F045B4 Offset: 0x1F005B4 VA: 0x1F045B4
	public ElementType get_Element() { }

	// RVA: 0x1F045BC Offset: 0x1F005BC VA: 0x1F045BC
	public int get_Crt() { }

	// RVA: 0x1F045C4 Offset: 0x1F005C4 VA: 0x1F045C4
	public int get_CrtDmg() { }

	// RVA: 0x1F045CC Offset: 0x1F005CC VA: 0x1F045CC
	public int get_Flee() { }

	// RVA: 0x1F045D4 Offset: 0x1F005D4 VA: 0x1F045D4
	public int get_Effect() { }

	// RVA: 0x1F045DC Offset: 0x1F005DC VA: 0x1F045DC
	public int get_EffectGrant() { }

	// RVA: 0x1F045E4 Offset: 0x1F005E4 VA: 0x1F045E4
	public int get_EffectTime() { }

	// RVA: 0x1F045EC Offset: 0x1F005EC VA: 0x1F045EC
	public MobActionType get_ActionType() { }

	// RVA: 0x1F045F4 Offset: 0x1F005F4 VA: 0x1F045F4
	public int get_Motion() { }

	// RVA: 0x1F045FC Offset: 0x1F005FC VA: 0x1F045FC
	public float get_StartSoundTiming() { }

	// RVA: 0x1F04604 Offset: 0x1F00604 VA: 0x1F04604
	public int get_StartSound() { }

	// RVA: 0x1F0460C Offset: 0x1F0060C VA: 0x1F0460C
	public float get_AttackSoundTiming() { }

	// RVA: 0x1F04614 Offset: 0x1F00614 VA: 0x1F04614
	public int get_AttackSound() { }

	// RVA: 0x1F0461C Offset: 0x1F0061C VA: 0x1F0461C
	public int get_HitEffectId() { }

	// RVA: 0x1F04624 Offset: 0x1F00624 VA: 0x1F04624
	public int get_HitEffectMotion() { }

	// RVA: 0x1F0462C Offset: 0x1F0062C VA: 0x1F0462C
	public int get_Combo() { }

	// RVA: 0x1F04634 Offset: 0x1F00634 VA: 0x1F04634
	public int get_Probability() { }

	// RVA: 0x1F0463C Offset: 0x1F0063C VA: 0x1F0463C
	public short get_CommonFlag() { }

	// RVA: 0x1F04644 Offset: 0x1F00644 VA: 0x1F04644
	public int get_Value1() { }

	// RVA: 0x1F0466C Offset: 0x1F0066C VA: 0x1F0466C
	public int get_Value2() { }

	// RVA: 0x1F04698 Offset: 0x1F00698 VA: 0x1F04698
	public int get_Value3() { }

	// RVA: 0x1F046C4 Offset: 0x1F006C4 VA: 0x1F046C4
	public int get_Value4() { }

	// RVA: 0x1F046F0 Offset: 0x1F006F0 VA: 0x1F046F0
	public int get_Value5() { }

	// RVA: 0x1F0471C Offset: 0x1F0071C VA: 0x1F0471C
	public int get_Value6() { }

	// RVA: 0x1F04748 Offset: 0x1F00748 VA: 0x1F04748
	public int get_Value7() { }

	// RVA: 0x1F04774 Offset: 0x1F00774 VA: 0x1F04774
	public int get_Value8() { }

	// RVA: 0x1F047A0 Offset: 0x1F007A0 VA: 0x1F047A0
	public int get_Value9() { }

	// RVA: 0x1F047CC Offset: 0x1F007CC VA: 0x1F047CC
	public int get_Value10() { }

	// RVA: 0x1F047F8 Offset: 0x1F007F8 VA: 0x1F047F8
	public int get_Value11() { }

	// RVA: 0x1F04824 Offset: 0x1F00824 VA: 0x1F04824
	public int get_Value12() { }

	// RVA: 0x1F04850 Offset: 0x1F00850 VA: 0x1F04850
	public int get_Value13() { }

	// RVA: 0x1F0487C Offset: 0x1F0087C VA: 0x1F0487C
	public int get_Value14() { }

	// RVA: 0x1F048A8 Offset: 0x1F008A8 VA: 0x1F048A8
	public int get_Value15() { }

	// RVA: 0x1F048D4 Offset: 0x1F008D4 VA: 0x1F048D4
	public int get_Value16() { }

	// RVA: 0x1F04900 Offset: 0x1F00900 VA: 0x1F04900
	public int get_Value17() { }

	// RVA: 0x1F0492C Offset: 0x1F0092C VA: 0x1F0492C
	public int get_Value18() { }

	// RVA: 0x1F04958 Offset: 0x1F00958 VA: 0x1F04958
	public int get_Value19() { }

	// RVA: 0x1F04984 Offset: 0x1F00984 VA: 0x1F04984
	public int get_Value20() { }

	// RVA: 0x1F049B0 Offset: 0x1F009B0 VA: 0x1F049B0
	public static MobActionPattern CreateActionPattern(int version, BinaryReader reader) { }

	// RVA: 0x1F0508C Offset: 0x1F0108C VA: 0x1F0508C
	public void .ctor() { }
}
