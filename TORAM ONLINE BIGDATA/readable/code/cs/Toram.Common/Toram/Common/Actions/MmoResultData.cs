// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Actions
public class MmoResultData : UnityHashBase // TypeDefIndex: 13134
{
	// Fields
	[CompilerGenerated]
	private BattleResultData <BattleResult>k__BackingField; // 0x20
	[CompilerGenerated]
	private MonsterResultData[] <MobResult>k__BackingField; // 0x28

	// Properties
	public BattleResultData BattleResult { get; set; }
	public MonsterResultData[] MobResult { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x36AF7B4 Offset: 0x36AB7B4 VA: 0x36AF7B4
	public void .ctor(Dictionary<object, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x36AF7BC Offset: 0x36AB7BC VA: 0x36AF7BC
	public BattleResultData get_BattleResult() { }

	[CompilerGenerated]
	// RVA: 0x36AF7C4 Offset: 0x36AB7C4 VA: 0x36AF7C4
	public void set_BattleResult(BattleResultData value) { }

	[CompilerGenerated]
	// RVA: 0x36AF7CC Offset: 0x36AB7CC VA: 0x36AF7CC
	public MonsterResultData[] get_MobResult() { }

	[CompilerGenerated]
	// RVA: 0x36AF7D4 Offset: 0x36AB7D4 VA: 0x36AF7D4
	public void set_MobResult(MonsterResultData[] value) { }

	// RVA: 0x36AF7DC Offset: 0x36AB7DC VA: 0x36AF7DC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36AF7E4 Offset: 0x36AB7E4 VA: 0x36AF7E4 Slot: 6
	public override Dictionary<object, object> GetValue() { }

	// RVA: 0x36AF938 Offset: 0x36AB938 VA: 0x36AF938 Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }
}
