// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Communication
public class GuildBoosterData : UnityHashBase // TypeDefIndex: 12985
{
	// Fields
	[CompilerGenerated]
	private byte <BoosterType>k__BackingField; // 0x19
	[CompilerGenerated]
	private DateTime <BoostTime>k__BackingField; // 0x20
	[CompilerGenerated]
	private DateTime <CollectTime>k__BackingField; // 0x28
	[CompilerGenerated]
	private DateTime <PresentTime>k__BackingField; // 0x30
	[CompilerGenerated]
	private int <BoostRate>k__BackingField; // 0x38

	// Properties
	[UnityHash(Code = 245)]
	public byte BoosterType { get; set; }
	[UnityHash(Code = 172)]
	public DateTime BoostTime { get; set; }
	[UnityHash(Code = 190)]
	public DateTime CollectTime { get; set; }
	[UnityHash(Code = 199)]
	public DateTime PresentTime { get; set; }
	[UnityHash(Code = 195)]
	public int BoostRate { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3688118 Offset: 0x3684118 VA: 0x3688118
	public void .ctor() { }

	// RVA: 0x3688120 Offset: 0x3684120 VA: 0x3688120
	public void .ctor(Dictionary<object, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3688128 Offset: 0x3684128 VA: 0x3688128
	public byte get_BoosterType() { }

	[CompilerGenerated]
	// RVA: 0x3688130 Offset: 0x3684130 VA: 0x3688130
	public void set_BoosterType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3688138 Offset: 0x3684138 VA: 0x3688138
	public DateTime get_BoostTime() { }

	[CompilerGenerated]
	// RVA: 0x3688140 Offset: 0x3684140 VA: 0x3688140
	public void set_BoostTime(DateTime value) { }

	[CompilerGenerated]
	// RVA: 0x3688148 Offset: 0x3684148 VA: 0x3688148
	public DateTime get_CollectTime() { }

	[CompilerGenerated]
	// RVA: 0x3688150 Offset: 0x3684150 VA: 0x3688150
	public void set_CollectTime(DateTime value) { }

	[CompilerGenerated]
	// RVA: 0x3688158 Offset: 0x3684158 VA: 0x3688158
	public DateTime get_PresentTime() { }

	[CompilerGenerated]
	// RVA: 0x3688160 Offset: 0x3684160 VA: 0x3688160
	public void set_PresentTime(DateTime value) { }

	[CompilerGenerated]
	// RVA: 0x3688168 Offset: 0x3684168 VA: 0x3688168
	public int get_BoostRate() { }

	[CompilerGenerated]
	// RVA: 0x3688170 Offset: 0x3684170 VA: 0x3688170
	public void set_BoostRate(int value) { }

	// RVA: 0x3688178 Offset: 0x3684178 VA: 0x3688178 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3688180 Offset: 0x3684180 VA: 0x3688180 Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }

	// RVA: 0x36884A4 Offset: 0x36844A4 VA: 0x36884A4 Slot: 6
	public override Dictionary<object, object> GetValue() { }
}
