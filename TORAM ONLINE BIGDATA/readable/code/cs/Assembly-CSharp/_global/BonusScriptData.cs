// Assembly: Assembly-CSharp.dll
// Namespace: 
[Serializable]
public class BonusScriptData // TypeDefIndex: 1741
{
	// Fields
	private List<ReflectionBonusParameter> bonusData; // 0x10
	private List<ReflectionBonusParameter> buffData; // 0x18
	private List<ReflectionBonusParameter> debuffData; // 0x20
	private IList<BonusParameter> bonusLines; // 0x28
	[CompilerGenerated]
	private BonusType <Type>k__BackingField; // 0x30
	[CompilerGenerated]
	private float <LastUpdateTime>k__BackingField; // 0x34
	[CompilerGenerated]
	private bool <IsEnd>k__BackingField; // 0x38
	[CompilerGenerated]
	private int <CurrentLine>k__BackingField; // 0x3C
	[CompilerGenerated]
	private bool <UseTime>k__BackingField; // 0x40
	[CompilerGenerated]
	private float <ElapsedDiffTime>k__BackingField; // 0x44
	[CompilerGenerated]
	private int <BaseTime>k__BackingField; // 0x48
	[CompilerGenerated]
	private float <RestTime>k__BackingField; // 0x4C
	[CompilerGenerated]
	private bool <UseInterval>k__BackingField; // 0x50
	[CompilerGenerated]
	private int <Interval>k__BackingField; // 0x54
	[CompilerGenerated]
	private float <IntervalTime>k__BackingField; // 0x58
	[CompilerGenerated]
	private int <BaseDelay>k__BackingField; // 0x5C
	[CompilerGenerated]
	private float <Delay>k__BackingField; // 0x60
	[CompilerGenerated]
	private int <MaxInvokeCount>k__BackingField; // 0x64
	[CompilerGenerated]
	private int <InvokeCount>k__BackingField; // 0x68
	[CompilerGenerated]
	private int <Value>k__BackingField; // 0x6C
	[CompilerGenerated]
	private int <ReturnLine>k__BackingField; // 0x70
	[CompilerGenerated]
	private int <AddCount>k__BackingField; // 0x74
	[CompilerGenerated]
	private int <SpecialValue>k__BackingField; // 0x78
	private int autoSkillPercent; // 0x7C

	// Properties
	public List<ReflectionBonusParameter> Bonus { get; }
	public List<ReflectionBonusParameter> Buff { get; }
	public IList<ReflectionBonusParameter> Debuff { get; }
	public IList<BonusParameter> BonusLines { get; }
	public BonusParameter CurrentBonusLine { get; }
	public BonusType Type { get; set; }
	public float LastUpdateTime { get; set; }
	public bool IsEnd { get; set; }
	public int CurrentLine { get; set; }
	public bool UseTime { get; set; }
	public float ElapsedDiffTime { get; set; }
	public int BaseTime { get; set; }
	public float RestTime { get; set; }
	public bool UseInterval { get; set; }
	public int Interval { get; set; }
	public float IntervalTime { get; set; }
	public int BaseDelay { get; set; }
	public float Delay { get; set; }
	public int MaxInvokeCount { get; set; }
	public int InvokeCount { get; set; }
	public int Value { get; set; }
	public int ReturnLine { get; set; }
	public int AddCount { get; set; }
	public int SpecialValue { get; set; }

	// Methods

	// RVA: 0x20BCCE4 Offset: 0x20B8CE4 VA: 0x20BCCE4
	public List<ReflectionBonusParameter> get_Bonus() { }

	// RVA: 0x20BCDD8 Offset: 0x20B8DD8 VA: 0x20BCDD8
	public List<ReflectionBonusParameter> get_Buff() { }

	// RVA: 0x20BCECC Offset: 0x20B8ECC VA: 0x20BCECC
	public IList<ReflectionBonusParameter> get_Debuff() { }

	// RVA: 0x20BCFC0 Offset: 0x20B8FC0 VA: 0x20BCFC0
	public IList<BonusParameter> get_BonusLines() { }

	// RVA: 0x20BCFC8 Offset: 0x20B8FC8 VA: 0x20BCFC8
	public BonusParameter get_CurrentBonusLine() { }

	[CompilerGenerated]
	// RVA: 0x20BD100 Offset: 0x20B9100 VA: 0x20BD100
	public BonusType get_Type() { }

	[CompilerGenerated]
	// RVA: 0x20BD108 Offset: 0x20B9108 VA: 0x20BD108
	private void set_Type(BonusType value) { }

	[CompilerGenerated]
	// RVA: 0x20BD110 Offset: 0x20B9110 VA: 0x20BD110
	public float get_LastUpdateTime() { }

	[CompilerGenerated]
	// RVA: 0x20BD118 Offset: 0x20B9118 VA: 0x20BD118
	public void set_LastUpdateTime(float value) { }

	[CompilerGenerated]
	// RVA: 0x20BD120 Offset: 0x20B9120 VA: 0x20BD120
	public bool get_IsEnd() { }

	[CompilerGenerated]
	// RVA: 0x20BD128 Offset: 0x20B9128 VA: 0x20BD128
	private void set_IsEnd(bool value) { }

	[CompilerGenerated]
	// RVA: 0x20BD134 Offset: 0x20B9134 VA: 0x20BD134
	public int get_CurrentLine() { }

	[CompilerGenerated]
	// RVA: 0x20BD13C Offset: 0x20B913C VA: 0x20BD13C
	private void set_CurrentLine(int value) { }

	[CompilerGenerated]
	// RVA: 0x20BD144 Offset: 0x20B9144 VA: 0x20BD144
	public bool get_UseTime() { }

	[CompilerGenerated]
	// RVA: 0x20BD14C Offset: 0x20B914C VA: 0x20BD14C
	private void set_UseTime(bool value) { }

	[CompilerGenerated]
	// RVA: 0x20BD158 Offset: 0x20B9158 VA: 0x20BD158
	public float get_ElapsedDiffTime() { }

	[CompilerGenerated]
	// RVA: 0x20BD160 Offset: 0x20B9160 VA: 0x20BD160
	private void set_ElapsedDiffTime(float value) { }

	[CompilerGenerated]
	// RVA: 0x20BD168 Offset: 0x20B9168 VA: 0x20BD168
	public int get_BaseTime() { }

	[CompilerGenerated]
	// RVA: 0x20BD170 Offset: 0x20B9170 VA: 0x20BD170
	private void set_BaseTime(int value) { }

	[CompilerGenerated]
	// RVA: 0x20BD178 Offset: 0x20B9178 VA: 0x20BD178
	public float get_RestTime() { }

	[CompilerGenerated]
	// RVA: 0x20BD180 Offset: 0x20B9180 VA: 0x20BD180
	private void set_RestTime(float value) { }

	[CompilerGenerated]
	// RVA: 0x20BD188 Offset: 0x20B9188 VA: 0x20BD188
	public bool get_UseInterval() { }

	[CompilerGenerated]
	// RVA: 0x20BD190 Offset: 0x20B9190 VA: 0x20BD190
	private void set_UseInterval(bool value) { }

	[CompilerGenerated]
	// RVA: 0x20BD19C Offset: 0x20B919C VA: 0x20BD19C
	public int get_Interval() { }

	[CompilerGenerated]
	// RVA: 0x20BD1A4 Offset: 0x20B91A4 VA: 0x20BD1A4
	private void set_Interval(int value) { }

	[CompilerGenerated]
	// RVA: 0x20BD1AC Offset: 0x20B91AC VA: 0x20BD1AC
	public float get_IntervalTime() { }

	[CompilerGenerated]
	// RVA: 0x20BD1B4 Offset: 0x20B91B4 VA: 0x20BD1B4
	private void set_IntervalTime(float value) { }

	[CompilerGenerated]
	// RVA: 0x20BD1BC Offset: 0x20B91BC VA: 0x20BD1BC
	public int get_BaseDelay() { }

	[CompilerGenerated]
	// RVA: 0x20BD1C4 Offset: 0x20B91C4 VA: 0x20BD1C4
	private void set_BaseDelay(int value) { }

	[CompilerGenerated]
	// RVA: 0x20BD1CC Offset: 0x20B91CC VA: 0x20BD1CC
	public float get_Delay() { }

	[CompilerGenerated]
	// RVA: 0x20BD1D4 Offset: 0x20B91D4 VA: 0x20BD1D4
	private void set_Delay(float value) { }

	[CompilerGenerated]
	// RVA: 0x20BD1DC Offset: 0x20B91DC VA: 0x20BD1DC
	public int get_MaxInvokeCount() { }

	[CompilerGenerated]
	// RVA: 0x20BD1E4 Offset: 0x20B91E4 VA: 0x20BD1E4
	private void set_MaxInvokeCount(int value) { }

	[CompilerGenerated]
	// RVA: 0x20BD1EC Offset: 0x20B91EC VA: 0x20BD1EC
	public int get_InvokeCount() { }

	[CompilerGenerated]
	// RVA: 0x20BD1F4 Offset: 0x20B91F4 VA: 0x20BD1F4
	private void set_InvokeCount(int value) { }

	[CompilerGenerated]
	// RVA: 0x20BD1FC Offset: 0x20B91FC VA: 0x20BD1FC
	public int get_Value() { }

	[CompilerGenerated]
	// RVA: 0x20BD204 Offset: 0x20B9204 VA: 0x20BD204
	private void set_Value(int value) { }

	[CompilerGenerated]
	// RVA: 0x20BD20C Offset: 0x20B920C VA: 0x20BD20C
	public int get_ReturnLine() { }

	[CompilerGenerated]
	// RVA: 0x20BD214 Offset: 0x20B9214 VA: 0x20BD214
	private void set_ReturnLine(int value) { }

	[CompilerGenerated]
	// RVA: 0x20BD21C Offset: 0x20B921C VA: 0x20BD21C
	public int get_AddCount() { }

	[CompilerGenerated]
	// RVA: 0x20BD224 Offset: 0x20B9224 VA: 0x20BD224
	private void set_AddCount(int value) { }

	[CompilerGenerated]
	// RVA: 0x20BD22C Offset: 0x20B922C VA: 0x20BD22C
	public int get_SpecialValue() { }

	[CompilerGenerated]
	// RVA: 0x20BD234 Offset: 0x20B9234 VA: 0x20BD234
	private void set_SpecialValue(int value) { }

	// RVA: 0x20BD23C Offset: 0x20B923C VA: 0x20BD23C
	public void .ctor(IList<BonusParameter> bonusLines) { }

	// RVA: 0x20BD724 Offset: 0x20B9724 VA: 0x20BD724
	public void SetReturnLine(int line) { }

	// RVA: 0x20BD72C Offset: 0x20B972C VA: 0x20BD72C
	public void Return() { }

	// RVA: 0x20BD738 Offset: 0x20B9738 VA: 0x20BD738
	public void Next() { }

	// RVA: 0x20BD748 Offset: 0x20B9748 VA: 0x20BD748
	public void Next(int count) { }

	// RVA: 0x20BD758 Offset: 0x20B9758 VA: 0x20BD758
	public void End() { }

	// RVA: 0x20BD764 Offset: 0x20B9764 VA: 0x20BD764
	public void SetTime(BonusType type, int time) { }

	// RVA: 0x20BD798 Offset: 0x20B9798 VA: 0x20BD798
	public void SetRepeatWait(int time) { }

	// RVA: 0x20BD848 Offset: 0x20B9848 VA: 0x20BD848
	public void SetStartWait(int time) { }

	// RVA: 0x20BD8FC Offset: 0x20B98FC VA: 0x20BD8FC
	public void SetElapsedTime(float time) { }

	// RVA: 0x20BD918 Offset: 0x20B9918 VA: 0x20BD918
	public void ClearElapsedTime() { }

	// RVA: 0x20BD920 Offset: 0x20B9920 VA: 0x20BD920
	public float ForwardElapsedDiffTime(float dTime) { }

	// RVA: 0x20BD93C Offset: 0x20B993C VA: 0x20BD93C
	public void ForwardTime(float dTime) { }

	// RVA: 0x20BD958 Offset: 0x20B9958 VA: 0x20BD958
	public bool FowardDelay(float dTime) { }

	// RVA: 0x20BD9A4 Offset: 0x20B99A4 VA: 0x20BD9A4
	public bool FowardInterval(float dTime) { }

	// RVA: 0x20BD9DC Offset: 0x20B99DC VA: 0x20BD9DC
	public void CheckInvokeCount() { }

	// RVA: 0x20BDA24 Offset: 0x20B9A24 VA: 0x20BDA24
	public void FowardInvokeCount() { }

	// RVA: 0x20BDA58 Offset: 0x20B9A58 VA: 0x20BDA58
	public void SkipInvokeCount() { }

	// RVA: 0x20BDB68 Offset: 0x20B9B68 VA: 0x20BDB68
	public void AddBonus(BonusType type, int val, bool instant) { }

	// RVA: 0x20BDD58 Offset: 0x20B9D58 VA: 0x20BDD58
	public void AddBuff(BonusType type, int val, bool instant) { }

	// RVA: 0x20BDF48 Offset: 0x20B9F48 VA: 0x20BDF48
	public void AddDebuff(BonusType type, int value) { }

	// RVA: 0x20BE128 Offset: 0x20BA128 VA: 0x20BE128
	public void SetAutoSkillPercent(int val) { }

	// RVA: 0x20BE130 Offset: 0x20BA130 VA: 0x20BE130
	public void SetValue(int val) { }

	// RVA: 0x20BE138 Offset: 0x20BA138 VA: 0x20BE138
	public void AddValue(int val) { }

	// RVA: 0x20BE148 Offset: 0x20BA148 VA: 0x20BE148
	public void ProductValue(int val) { }

	// RVA: 0x20BE168 Offset: 0x20BA168 VA: 0x20BE168
	public void SetAddCount(int addCount) { }

	// RVA: 0x20BE170 Offset: 0x20BA170 VA: 0x20BE170
	public void SetSpecialValue(int value) { }

	// RVA: 0x20BE178 Offset: 0x20BA178 VA: 0x20BE178
	public void AddSpecialValue(int value) { }

	[CompilerGenerated]
	// RVA: 0x20BE188 Offset: 0x20BA188 VA: 0x20BE188
	private void <get_Bonus>b__6_0(ReflectionBonusParameter x) { }

	[CompilerGenerated]
	// RVA: 0x20BE1F8 Offset: 0x20BA1F8 VA: 0x20BE1F8
	private void <get_Buff>b__8_0(ReflectionBonusParameter x) { }

	[CompilerGenerated]
	// RVA: 0x20BE268 Offset: 0x20BA268 VA: 0x20BE268
	private void <get_Debuff>b__10_0(ReflectionBonusParameter x) { }
}
