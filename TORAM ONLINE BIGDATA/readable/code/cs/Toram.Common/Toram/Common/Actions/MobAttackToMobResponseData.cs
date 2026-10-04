// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Actions
public class MobAttackToMobResponseData : UnityHashBase // TypeDefIndex: 13167
{
	// Fields
	[CompilerGenerated]
	private byte <DamageId>k__BackingField; // 0x19
	[CompilerGenerated]
	private MobResponseData <MobData>k__BackingField; // 0x20
	[CompilerGenerated]
	private MobResponseData[] <MobList>k__BackingField; // 0x28

	// Properties
	[UnityHash(Code = 50)]
	public byte DamageId { get; set; }
	[UnityHash(Code = 20)]
	public MobResponseData MobData { get; set; }
	[UnityHash(Code = 21)]
	public MobResponseData[] MobList { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x36BBCE0 Offset: 0x36B7CE0 VA: 0x36BBCE0
	public void .ctor(Dictionary<object, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x36BBCE8 Offset: 0x36B7CE8 VA: 0x36BBCE8
	public byte get_DamageId() { }

	[CompilerGenerated]
	// RVA: 0x36BBCF0 Offset: 0x36B7CF0 VA: 0x36BBCF0
	public void set_DamageId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36BBCF8 Offset: 0x36B7CF8 VA: 0x36BBCF8
	public MobResponseData get_MobData() { }

	[CompilerGenerated]
	// RVA: 0x36BBD00 Offset: 0x36B7D00 VA: 0x36BBD00
	public void set_MobData(MobResponseData value) { }

	[CompilerGenerated]
	// RVA: 0x36BBD08 Offset: 0x36B7D08 VA: 0x36BBD08
	public MobResponseData[] get_MobList() { }

	[CompilerGenerated]
	// RVA: 0x36BBD10 Offset: 0x36B7D10 VA: 0x36BBD10
	public void set_MobList(MobResponseData[] value) { }

	// RVA: 0x36BBD18 Offset: 0x36B7D18 VA: 0x36BBD18 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36BBD20 Offset: 0x36B7D20 VA: 0x36BBD20 Slot: 6
	public override Dictionary<object, object> GetValue() { }

	// RVA: 0x36BBEA8 Offset: 0x36B7EA8 VA: 0x36BBEA8 Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }
}
