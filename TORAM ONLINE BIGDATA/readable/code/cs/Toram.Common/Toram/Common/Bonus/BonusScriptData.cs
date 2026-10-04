// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Bonus
public class BonusScriptData : BinaryBase // TypeDefIndex: 13090
{
	// Fields
	private List<BonusParameter> scriptParams; // 0x20
	private List<ReflectionBonusParameter> reflectionBonusList; // 0x28
	private List<ReflectionBonusParameter> reflectionBuffList; // 0x30
	private List<ReflectionBonusParameter> reflectionDebuffList; // 0x38
	private List<ReflectionBonusParameter> reflectionDamageList; // 0x40
	[CompilerGenerated]
	private float <Time>k__BackingField; // 0x48
	[CompilerGenerated]
	private int <Interval>k__BackingField; // 0x4C

	// Properties
	public IList<BonusParameter> ScriptParams { get; }
	private float Time { set; }
	private int Interval { set; }

	// Methods

	// RVA: 0x36A0D3C Offset: 0x369CD3C VA: 0x36A0D3C
	public IList<BonusParameter> get_ScriptParams() { }

	[CompilerGenerated]
	// RVA: 0x36A0D8C Offset: 0x369CD8C VA: 0x36A0D8C
	private void set_Time(float value) { }

	[CompilerGenerated]
	// RVA: 0x36A0D94 Offset: 0x369CD94 VA: 0x36A0D94
	private void set_Interval(int value) { }

	// RVA: 0x36A0C34 Offset: 0x369CC34 VA: 0x36A0C34
	public void .ctor(MemoryStream ms) { }

	// RVA: 0x36A0D9C Offset: 0x369CD9C VA: 0x36A0D9C
	private void Initialize() { }

	// RVA: 0x36A0E90 Offset: 0x369CE90 VA: 0x36A0E90 Slot: 4
	protected override bool SetValue(MemoryStream ms, bool isThrow) { }

	// RVA: 0x36A110C Offset: 0x369D10C VA: 0x36A110C Slot: 7
	protected override void GetBinary(MemoryStream ms, bool isThrow) { }
}
