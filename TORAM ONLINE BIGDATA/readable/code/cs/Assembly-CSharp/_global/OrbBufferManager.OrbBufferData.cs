// Assembly: Assembly-CSharp.dll
// Namespace: 
public class OrbBufferManager.OrbBufferData // TypeDefIndex: 2139
{
	// Fields
	[CompilerGenerated]
	private int <ItemId>k__BackingField; // 0x10
	[CompilerGenerated]
	private float <LocalTime>k__BackingField; // 0x14
	[CompilerGenerated]
	private int <Value>k__BackingField; // 0x18

	// Properties
	public int ItemId { get; set; }
	public DateTime TimeLeft { get; }
	public float LocalTime { get; set; }
	public int Value { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x214DB7C Offset: 0x2149B7C VA: 0x214DB7C
	public int get_ItemId() { }

	[CompilerGenerated]
	// RVA: 0x214DB84 Offset: 0x2149B84 VA: 0x214DB84
	private void set_ItemId(int value) { }

	// RVA: 0x214DB8C Offset: 0x2149B8C VA: 0x214DB8C
	public DateTime get_TimeLeft() { }

	[CompilerGenerated]
	// RVA: 0x214DBD4 Offset: 0x2149BD4 VA: 0x214DBD4
	public float get_LocalTime() { }

	[CompilerGenerated]
	// RVA: 0x214DBDC Offset: 0x2149BDC VA: 0x214DBDC
	private void set_LocalTime(float value) { }

	[CompilerGenerated]
	// RVA: 0x214DBE4 Offset: 0x2149BE4 VA: 0x214DBE4
	public int get_Value() { }

	[CompilerGenerated]
	// RVA: 0x214DBEC Offset: 0x2149BEC VA: 0x214DBEC
	private void set_Value(int value) { }

	// RVA: 0x214DBF4 Offset: 0x2149BF4 VA: 0x214DBF4
	public void .ctor(int itemId, DateTime timeLeft, int val) { }

	// RVA: 0x214D5B0 Offset: 0x21495B0 VA: 0x214D5B0
	public void .ctor(OrbBonusData data) { }

	// RVA: 0x214D938 Offset: 0x2149938 VA: 0x214D938
	public void UpdateData(OrbBonusData data) { }

	// RVA: 0x214D784 Offset: 0x2149784 VA: 0x214D784
	public void Update() { }

	// RVA: 0x214DAE4 Offset: 0x2149AE4 VA: 0x214DAE4
	public void UpdateValue(int updateValue) { }
}
