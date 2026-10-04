// Assembly: Assembly-CSharp.dll
// Namespace: 
public class RhythmNotesData // TypeDefIndex: 6194
{
	// Fields
	[CompilerGenerated]
	private RhythmNotesData.NotesType <Type>k__BackingField; // 0x10
	[CompilerGenerated]
	private int <Id>k__BackingField; // 0x14
	[CompilerGenerated]
	private int <Lane>k__BackingField; // 0x18
	[CompilerGenerated]
	private float <Scale>k__BackingField; // 0x1C
	[CompilerGenerated]
	private float <Seconds>k__BackingField; // 0x20
	[CompilerGenerated]
	private float <Advance>k__BackingField; // 0x24
	[CompilerGenerated]
	private bool <IsHit>k__BackingField; // 0x28
	[CompilerGenerated]
	private RhythmNotesData.StateType <State>k__BackingField; // 0x2C
	public const float CriticalTime = 0.1;
	public const float HitTime = 0.225;
	public const float GrazeTime = 0.3;

	// Properties
	public RhythmNotesData.NotesType Type { get; set; }
	public int Id { get; set; }
	public int Lane { get; set; }
	public float Scale { get; set; }
	public float Seconds { get; set; }
	public float Advance { get; set; }
	public bool IsHit { get; set; }
	public RhythmNotesData.StateType State { get; set; }
	public bool IsFlick { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x18B50B4 Offset: 0x18B10B4 VA: 0x18B50B4
	public RhythmNotesData.NotesType get_Type() { }

	[CompilerGenerated]
	// RVA: 0x18B50BC Offset: 0x18B10BC VA: 0x18B50BC
	private void set_Type(RhythmNotesData.NotesType value) { }

	[CompilerGenerated]
	// RVA: 0x18B50C4 Offset: 0x18B10C4 VA: 0x18B50C4
	public int get_Id() { }

	[CompilerGenerated]
	// RVA: 0x18B50CC Offset: 0x18B10CC VA: 0x18B50CC
	private void set_Id(int value) { }

	[CompilerGenerated]
	// RVA: 0x18B50D4 Offset: 0x18B10D4 VA: 0x18B50D4
	public int get_Lane() { }

	[CompilerGenerated]
	// RVA: 0x18B50DC Offset: 0x18B10DC VA: 0x18B50DC
	private void set_Lane(int value) { }

	[CompilerGenerated]
	// RVA: 0x18B50E4 Offset: 0x18B10E4 VA: 0x18B50E4
	public float get_Scale() { }

	[CompilerGenerated]
	// RVA: 0x18B50EC Offset: 0x18B10EC VA: 0x18B50EC
	private void set_Scale(float value) { }

	[CompilerGenerated]
	// RVA: 0x18B50F4 Offset: 0x18B10F4 VA: 0x18B50F4
	public float get_Seconds() { }

	[CompilerGenerated]
	// RVA: 0x18B50FC Offset: 0x18B10FC VA: 0x18B50FC
	private void set_Seconds(float value) { }

	[CompilerGenerated]
	// RVA: 0x18B5104 Offset: 0x18B1104 VA: 0x18B5104
	public float get_Advance() { }

	[CompilerGenerated]
	// RVA: 0x18B510C Offset: 0x18B110C VA: 0x18B510C
	private void set_Advance(float value) { }

	[CompilerGenerated]
	// RVA: 0x18B5114 Offset: 0x18B1114 VA: 0x18B5114
	public bool get_IsHit() { }

	[CompilerGenerated]
	// RVA: 0x18B511C Offset: 0x18B111C VA: 0x18B511C
	private void set_IsHit(bool value) { }

	[CompilerGenerated]
	// RVA: 0x18B5128 Offset: 0x18B1128 VA: 0x18B5128
	public RhythmNotesData.StateType get_State() { }

	[CompilerGenerated]
	// RVA: 0x18B5130 Offset: 0x18B1130 VA: 0x18B5130
	private void set_State(RhythmNotesData.StateType value) { }

	// RVA: 0x18B5138 Offset: 0x18B1138 VA: 0x18B5138
	public bool get_IsFlick() { }

	// RVA: 0x18B514C Offset: 0x18B114C VA: 0x18B514C
	public void .ctor() { }

	// RVA: 0x18B518C Offset: 0x18B118C VA: 0x18B518C
	public void .ctor(int id, int lane, float seconds, RhythmNotesData.NotesType type, float advanceTime) { }

	// RVA: 0x18B517C Offset: 0x18B117C VA: 0x18B517C
	private void InitOtherData() { }

	// RVA: 0x18B51E4 Offset: 0x18B11E4 VA: 0x18B51E4
	public bool UpdateState(float nowTime) { }

	// RVA: 0x18B52D0 Offset: 0x18B12D0 VA: 0x18B52D0
	public bool HitCheck(float nowTime, out int rank) { }

	// RVA: 0x18B544C Offset: 0x18B144C VA: 0x18B544C
	public bool CheckFlick(float nowTime, int lane) { }

	// RVA: 0x18B53DC Offset: 0x18B13DC VA: 0x18B53DC
	public int GetRank(float seconds) { }

	// RVA: 0x18B5538 Offset: 0x18B1538 VA: 0x18B5538
	public void SetState(RhythmNotesData.StateType type) { }
}
