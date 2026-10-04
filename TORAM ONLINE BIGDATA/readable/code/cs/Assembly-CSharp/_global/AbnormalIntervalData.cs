// Assembly: Assembly-CSharp.dll
// Namespace: 
public class AbnormalIntervalData : AbnormalData // TypeDefIndex: 1642
{
	// Fields
	[CompilerGenerated]
	private float <Interval>k__BackingField; // 0x28
	[CompilerGenerated]
	private float <IntervalTime>k__BackingField; // 0x2C
	[CompilerGenerated]
	private int <ExecCount>k__BackingField; // 0x30

	// Properties
	public float Interval { get; set; }
	public float IntervalTime { get; set; }
	public int ExecCount { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x209FD28 Offset: 0x209BD28 VA: 0x209FD28
	public float get_Interval() { }

	[CompilerGenerated]
	// RVA: 0x209FD30 Offset: 0x209BD30 VA: 0x209FD30
	private void set_Interval(float value) { }

	[CompilerGenerated]
	// RVA: 0x209FD38 Offset: 0x209BD38 VA: 0x209FD38
	public float get_IntervalTime() { }

	[CompilerGenerated]
	// RVA: 0x209FD40 Offset: 0x209BD40 VA: 0x209FD40
	private void set_IntervalTime(float value) { }

	[CompilerGenerated]
	// RVA: 0x209FD48 Offset: 0x209BD48 VA: 0x209FD48
	public int get_ExecCount() { }

	[CompilerGenerated]
	// RVA: 0x209FD50 Offset: 0x209BD50 VA: 0x209FD50
	private void set_ExecCount(int value) { }

	// RVA: 0x209FD58 Offset: 0x209BD58 VA: 0x209FD58
	public void .ctor(AbnormalType type, float time, float resistTime, float interval, byte localId, bool isForce, Action<AbnormalData> callback) { }

	// RVA: 0x209FD80 Offset: 0x209BD80 VA: 0x209FD80 Slot: 4
	public override bool Update(float dtime) { }
}
