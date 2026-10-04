// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Actions
public class MobEventAttackData : UnityHashBase // TypeDefIndex: 13137
{
	// Fields
	[CompilerGenerated]
	private MobSendData <MobData>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <Damage>k__BackingField; // 0x28
	[CompilerGenerated]
	private AbnormalData <AbnormalData>k__BackingField; // 0x30
	[CompilerGenerated]
	private bool <IsForceAbnormal>k__BackingField; // 0x38
	[CompilerGenerated]
	private byte <Flag>k__BackingField; // 0x39
	[CompilerGenerated]
	private ActionAppendData <AppendData>k__BackingField; // 0x40
	[CompilerGenerated]
	private byte <EventAttackType>k__BackingField; // 0x48

	// Properties
	public MobSendData MobData { get; set; }
	public int Damage { get; set; }
	public AbnormalData AbnormalData { get; set; }
	public bool IsForceAbnormal { get; set; }
	public byte Flag { get; set; }
	public ActionAppendData AppendData { get; set; }
	public byte EventAttackType { get; set; }
	public override byte Code { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x36B0160 Offset: 0x36AC160 VA: 0x36B0160
	public MobSendData get_MobData() { }

	[CompilerGenerated]
	// RVA: 0x36B0168 Offset: 0x36AC168 VA: 0x36B0168
	public void set_MobData(MobSendData value) { }

	[CompilerGenerated]
	// RVA: 0x36B0170 Offset: 0x36AC170 VA: 0x36B0170
	public int get_Damage() { }

	[CompilerGenerated]
	// RVA: 0x36B0178 Offset: 0x36AC178 VA: 0x36B0178
	public void set_Damage(int value) { }

	[CompilerGenerated]
	// RVA: 0x36B0180 Offset: 0x36AC180 VA: 0x36B0180
	public AbnormalData get_AbnormalData() { }

	[CompilerGenerated]
	// RVA: 0x36B0188 Offset: 0x36AC188 VA: 0x36B0188
	public void set_AbnormalData(AbnormalData value) { }

	[CompilerGenerated]
	// RVA: 0x36B0190 Offset: 0x36AC190 VA: 0x36B0190
	public bool get_IsForceAbnormal() { }

	[CompilerGenerated]
	// RVA: 0x36B0198 Offset: 0x36AC198 VA: 0x36B0198
	public void set_IsForceAbnormal(bool value) { }

	[CompilerGenerated]
	// RVA: 0x36B01A4 Offset: 0x36AC1A4 VA: 0x36B01A4
	public byte get_Flag() { }

	[CompilerGenerated]
	// RVA: 0x36B01AC Offset: 0x36AC1AC VA: 0x36B01AC
	public void set_Flag(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36B01B4 Offset: 0x36AC1B4 VA: 0x36B01B4
	public ActionAppendData get_AppendData() { }

	[CompilerGenerated]
	// RVA: 0x36B01BC Offset: 0x36AC1BC VA: 0x36B01BC
	public void set_AppendData(ActionAppendData value) { }

	[CompilerGenerated]
	// RVA: 0x36B01C4 Offset: 0x36AC1C4 VA: 0x36B01C4
	public byte get_EventAttackType() { }

	[CompilerGenerated]
	// RVA: 0x36B01CC Offset: 0x36AC1CC VA: 0x36B01CC
	public void set_EventAttackType(byte value) { }

	// RVA: 0x36B01D4 Offset: 0x36AC1D4 VA: 0x36B01D4 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36B01DC Offset: 0x36AC1DC VA: 0x36B01DC
	public void .ctor() { }

	// RVA: 0x36B01E4 Offset: 0x36AC1E4 VA: 0x36B01E4 Slot: 6
	public override Dictionary<object, object> GetValue() { }

	// RVA: 0x36B049C Offset: 0x36AC49C VA: 0x36B049C Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }
}
