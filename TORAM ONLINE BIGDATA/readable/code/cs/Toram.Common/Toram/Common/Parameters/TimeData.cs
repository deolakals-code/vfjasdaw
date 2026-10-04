// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Parameters
public class TimeData : UnityHashBase // TypeDefIndex: 11133
{
	// Fields
	[CompilerGenerated]
	private long <Time>k__BackingField; // 0x20
	[CompilerGenerated]
	private long <TargetTime>k__BackingField; // 0x28

	// Properties
	[UnityHash(Code = 172, IsOptional = True)]
	public long Time { get; set; }
	[UnityHash(Code = 189, IsOptional = True)]
	public long TargetTime { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x35C5D28 Offset: 0x35C1D28 VA: 0x35C5D28
	public void .ctor(Dictionary<object, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x35C5D30 Offset: 0x35C1D30 VA: 0x35C5D30
	public long get_Time() { }

	[CompilerGenerated]
	// RVA: 0x35C5D38 Offset: 0x35C1D38 VA: 0x35C5D38
	public void set_Time(long value) { }

	[CompilerGenerated]
	// RVA: 0x35C5D40 Offset: 0x35C1D40 VA: 0x35C5D40
	public long get_TargetTime() { }

	[CompilerGenerated]
	// RVA: 0x35C5D48 Offset: 0x35C1D48 VA: 0x35C5D48
	public void set_TargetTime(long value) { }

	// RVA: 0x35C5D50 Offset: 0x35C1D50 VA: 0x35C5D50 Slot: 3
	public override string ToString() { }

	// RVA: 0x35C5F68 Offset: 0x35C1F68 VA: 0x35C5F68 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35C5F70 Offset: 0x35C1F70 VA: 0x35C5F70 Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }

	// RVA: 0x35C61A8 Offset: 0x35C21A8 VA: 0x35C61A8 Slot: 6
	public override Dictionary<object, object> GetValue() { }
}
