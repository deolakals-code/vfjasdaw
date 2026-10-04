// Assembly: Toram.Common.dll
// Namespace: 
public class TrophyProgressData.ProgressData : BinaryBase // TypeDefIndex: 11072
{
	// Fields
	[CompilerGenerated]
	private byte <ConditionType>k__BackingField; // 0x19
	[CompilerGenerated]
	private Dictionary<byte, int[]> <OptionalConditionList>k__BackingField; // 0x20
	[CompilerGenerated]
	private long <TargetValue>k__BackingField; // 0x28
	[CompilerGenerated]
	private long <CurrentValue>k__BackingField; // 0x30

	// Properties
	public byte ConditionType { get; set; }
	public Dictionary<byte, int[]> OptionalConditionList { get; set; }
	public long TargetValue { get; set; }
	public long CurrentValue { get; set; }

	// Methods

	// RVA: 0x35B27C4 Offset: 0x35AE7C4 VA: 0x35B27C4
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x35B27CC Offset: 0x35AE7CC VA: 0x35B27CC
	public byte get_ConditionType() { }

	[CompilerGenerated]
	// RVA: 0x35B27D4 Offset: 0x35AE7D4 VA: 0x35B27D4
	public void set_ConditionType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x35B27DC Offset: 0x35AE7DC VA: 0x35B27DC
	public Dictionary<byte, int[]> get_OptionalConditionList() { }

	[CompilerGenerated]
	// RVA: 0x35B27E4 Offset: 0x35AE7E4 VA: 0x35B27E4
	public void set_OptionalConditionList(Dictionary<byte, int[]> value) { }

	[CompilerGenerated]
	// RVA: 0x35B27EC Offset: 0x35AE7EC VA: 0x35B27EC
	public long get_TargetValue() { }

	[CompilerGenerated]
	// RVA: 0x35B27F4 Offset: 0x35AE7F4 VA: 0x35B27F4
	public void set_TargetValue(long value) { }

	[CompilerGenerated]
	// RVA: 0x35B27FC Offset: 0x35AE7FC VA: 0x35B27FC
	public long get_CurrentValue() { }

	[CompilerGenerated]
	// RVA: 0x35B2804 Offset: 0x35AE804 VA: 0x35B2804
	public void set_CurrentValue(long value) { }

	// RVA: 0x35B280C Offset: 0x35AE80C VA: 0x35B280C Slot: 7
	protected override void GetBinary(MemoryStream ms, bool isThrow) { }

	// RVA: 0x35B2A08 Offset: 0x35AEA08 VA: 0x35B2A08 Slot: 4
	protected override bool SetValue(MemoryStream ms, bool isThrow) { }
}
