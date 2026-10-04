// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Actions
public class MobEventAttackResponseData : UnityHashBase // TypeDefIndex: 13139
{
	// Fields
	[CompilerGenerated]
	private PlayerStatusData <PlayerStatus>k__BackingField; // 0x20
	[CompilerGenerated]
	private AbnormalData <AddAbnormal>k__BackingField; // 0x28
	[CompilerGenerated]
	private MobResponseData <MobData>k__BackingField; // 0x30
	[CompilerGenerated]
	private ActionAppendData <AppendData>k__BackingField; // 0x38
	[CompilerGenerated]
	private byte <EventAttackType>k__BackingField; // 0x40

	// Properties
	public PlayerStatusData PlayerStatus { get; set; }
	public AbnormalData AddAbnormal { get; set; }
	public MobResponseData MobData { get; set; }
	public ActionAppendData AppendData { get; set; }
	public byte EventAttackType { get; set; }
	public override byte Code { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x36B1068 Offset: 0x36AD068 VA: 0x36B1068
	public PlayerStatusData get_PlayerStatus() { }

	[CompilerGenerated]
	// RVA: 0x36B1070 Offset: 0x36AD070 VA: 0x36B1070
	public void set_PlayerStatus(PlayerStatusData value) { }

	[CompilerGenerated]
	// RVA: 0x36B1078 Offset: 0x36AD078 VA: 0x36B1078
	public AbnormalData get_AddAbnormal() { }

	[CompilerGenerated]
	// RVA: 0x36B1080 Offset: 0x36AD080 VA: 0x36B1080
	public void set_AddAbnormal(AbnormalData value) { }

	[CompilerGenerated]
	// RVA: 0x36B1088 Offset: 0x36AD088 VA: 0x36B1088
	public MobResponseData get_MobData() { }

	[CompilerGenerated]
	// RVA: 0x36B1090 Offset: 0x36AD090 VA: 0x36B1090
	public void set_MobData(MobResponseData value) { }

	[CompilerGenerated]
	// RVA: 0x36B1098 Offset: 0x36AD098 VA: 0x36B1098
	public ActionAppendData get_AppendData() { }

	[CompilerGenerated]
	// RVA: 0x36B10A0 Offset: 0x36AD0A0 VA: 0x36B10A0
	public void set_AppendData(ActionAppendData value) { }

	[CompilerGenerated]
	// RVA: 0x36B10A8 Offset: 0x36AD0A8 VA: 0x36B10A8
	public byte get_EventAttackType() { }

	[CompilerGenerated]
	// RVA: 0x36B10B0 Offset: 0x36AD0B0 VA: 0x36B10B0
	public void set_EventAttackType(byte value) { }

	// RVA: 0x36B10B8 Offset: 0x36AD0B8 VA: 0x36B10B8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36B10C0 Offset: 0x36AD0C0 VA: 0x36B10C0
	public void .ctor(Dictionary<object, object> parameters) { }

	// RVA: 0x36B10C8 Offset: 0x36AD0C8 VA: 0x36B10C8 Slot: 6
	public override Dictionary<object, object> GetValue() { }

	// RVA: 0x36B12E4 Offset: 0x36AD2E4 VA: 0x36B12E4 Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }
}
