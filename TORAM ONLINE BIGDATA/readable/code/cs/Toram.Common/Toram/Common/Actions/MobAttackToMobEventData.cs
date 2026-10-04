// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Actions
public class MobAttackToMobEventData : UnityHashBase // TypeDefIndex: 13166
{
	// Fields
	[CompilerGenerated]
	private MobResponseData <MobData>k__BackingField; // 0x20
	[CompilerGenerated]
	private MobResponseData[] <MobList>k__BackingField; // 0x28

	// Properties
	[UnityHash(Code = 20)]
	public MobResponseData MobData { get; set; }
	[UnityHash(Code = 21)]
	public MobResponseData[] MobList { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x36BB930 Offset: 0x36B7930 VA: 0x36BB930
	public void .ctor(Dictionary<object, object> paramters) { }

	[CompilerGenerated]
	// RVA: 0x36BB938 Offset: 0x36B7938 VA: 0x36BB938
	public MobResponseData get_MobData() { }

	[CompilerGenerated]
	// RVA: 0x36BB940 Offset: 0x36B7940 VA: 0x36BB940
	public void set_MobData(MobResponseData value) { }

	[CompilerGenerated]
	// RVA: 0x36BB948 Offset: 0x36B7948 VA: 0x36BB948
	public MobResponseData[] get_MobList() { }

	[CompilerGenerated]
	// RVA: 0x36BB950 Offset: 0x36B7950 VA: 0x36BB950
	public void set_MobList(MobResponseData[] value) { }

	// RVA: 0x36BB958 Offset: 0x36B7958 VA: 0x36BB958 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36BB960 Offset: 0x36B7960 VA: 0x36BB960 Slot: 6
	public override Dictionary<object, object> GetValue() { }

	// RVA: 0x36BBAA0 Offset: 0x36B7AA0 VA: 0x36BBAA0 Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }
}
