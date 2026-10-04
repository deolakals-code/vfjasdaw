// Assembly: Toram.Common.dll
// Namespace: 
public class FishingRandomTargetData.ProgressData : BinaryBase // TypeDefIndex: 11196
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

	// RVA: 0x35D695C Offset: 0x35D295C VA: 0x35D695C
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x35D6964 Offset: 0x35D2964 VA: 0x35D6964
	public byte get_ConditionType() { }

	[CompilerGenerated]
	// RVA: 0x35D696C Offset: 0x35D296C VA: 0x35D696C
	public void set_ConditionType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x35D6974 Offset: 0x35D2974 VA: 0x35D6974
	public Dictionary<byte, int[]> get_OptionalConditionList() { }

	[CompilerGenerated]
	// RVA: 0x35D697C Offset: 0x35D297C VA: 0x35D697C
	public void set_OptionalConditionList(Dictionary<byte, int[]> value) { }

	[CompilerGenerated]
	// RVA: 0x35D6984 Offset: 0x35D2984 VA: 0x35D6984
	public long get_TargetValue() { }

	[CompilerGenerated]
	// RVA: 0x35D698C Offset: 0x35D298C VA: 0x35D698C
	public void set_TargetValue(long value) { }

	[CompilerGenerated]
	// RVA: 0x35D6994 Offset: 0x35D2994 VA: 0x35D6994
	public long get_CurrentValue() { }

	[CompilerGenerated]
	// RVA: 0x35D699C Offset: 0x35D299C VA: 0x35D699C
	public void set_CurrentValue(long value) { }

	// RVA: 0x35D69A4 Offset: 0x35D29A4 VA: 0x35D69A4 Slot: 7
	protected override void GetBinary(MemoryStream ms, bool isThrow) { }

	// RVA: 0x35D6BA0 Offset: 0x35D2BA0 VA: 0x35D6BA0 Slot: 4
	protected override bool SetValue(MemoryStream ms, bool isThrow) { }
}
