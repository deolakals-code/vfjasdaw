// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Actions
public class MobAttackResponseData : UnityHashBase // TypeDefIndex: 13163
{
	// Fields
	[CompilerGenerated]
	private byte <DamageId>k__BackingField; // 0x19
	[CompilerGenerated]
	private PlayerStatusData <PlayerStatus>k__BackingField; // 0x20
	[CompilerGenerated]
	private MobResponseData <MobData>k__BackingField; // 0x28
	[CompilerGenerated]
	private MobResponseData[] <MobList>k__BackingField; // 0x30
	[CompilerGenerated]
	private ActionAppendData <AppendData>k__BackingField; // 0x38

	// Properties
	[UnityHash(Code = 23)]
	public byte DamageId { get; set; }
	[UnityHash(Code = 7)]
	public PlayerStatusData PlayerStatus { get; set; }
	[UnityHash(Code = 20)]
	public MobResponseData MobData { get; set; }
	[UnityHash(Code = 21, IsOptional = True)]
	public MobResponseData[] MobList { get; set; }
	[UnityHash(Code = 55, IsOptional = True)]
	public ActionAppendData AppendData { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x36BA004 Offset: 0x36B6004 VA: 0x36BA004
	public void .ctor(Dictionary<object, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x36BA00C Offset: 0x36B600C VA: 0x36BA00C
	public byte get_DamageId() { }

	[CompilerGenerated]
	// RVA: 0x36BA014 Offset: 0x36B6014 VA: 0x36BA014
	public void set_DamageId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36BA01C Offset: 0x36B601C VA: 0x36BA01C
	public PlayerStatusData get_PlayerStatus() { }

	[CompilerGenerated]
	// RVA: 0x36BA024 Offset: 0x36B6024 VA: 0x36BA024
	public void set_PlayerStatus(PlayerStatusData value) { }

	[CompilerGenerated]
	// RVA: 0x36BA02C Offset: 0x36B602C VA: 0x36BA02C
	public MobResponseData get_MobData() { }

	[CompilerGenerated]
	// RVA: 0x36BA034 Offset: 0x36B6034 VA: 0x36BA034
	public void set_MobData(MobResponseData value) { }

	[CompilerGenerated]
	// RVA: 0x36BA03C Offset: 0x36B603C VA: 0x36BA03C
	public MobResponseData[] get_MobList() { }

	[CompilerGenerated]
	// RVA: 0x36BA044 Offset: 0x36B6044 VA: 0x36BA044
	public void set_MobList(MobResponseData[] value) { }

	[CompilerGenerated]
	// RVA: 0x36BA04C Offset: 0x36B604C VA: 0x36BA04C
	public ActionAppendData get_AppendData() { }

	[CompilerGenerated]
	// RVA: 0x36BA054 Offset: 0x36B6054 VA: 0x36BA054
	public void set_AppendData(ActionAppendData value) { }

	// RVA: 0x36BA05C Offset: 0x36B605C VA: 0x36BA05C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36BA064 Offset: 0x36B6064 VA: 0x36BA064 Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }

	// RVA: 0x36BA4D0 Offset: 0x36B64D0 VA: 0x36BA4D0 Slot: 6
	public override Dictionary<object, object> GetValue() { }
}
