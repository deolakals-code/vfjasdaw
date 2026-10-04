// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Actions
public class MobEventAttackEventData : UnityHashBase // TypeDefIndex: 13138
{
	// Fields
	[CompilerGenerated]
	private MobResponseData <MobData>k__BackingField; // 0x20
	[CompilerGenerated]
	private AbnormalData <AddAbnormal>k__BackingField; // 0x28
	[CompilerGenerated]
	private ActionAppendData <AppendData>k__BackingField; // 0x30
	[CompilerGenerated]
	private byte <EventAttackType>k__BackingField; // 0x38

	// Properties
	public MobResponseData MobData { get; set; }
	public AbnormalData AddAbnormal { get; set; }
	public ActionAppendData AppendData { get; set; }
	public byte EventAttackType { get; set; }
	public override byte Code { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x36B09EC Offset: 0x36AC9EC VA: 0x36B09EC
	public MobResponseData get_MobData() { }

	[CompilerGenerated]
	// RVA: 0x36B09F4 Offset: 0x36AC9F4 VA: 0x36B09F4
	public void set_MobData(MobResponseData value) { }

	[CompilerGenerated]
	// RVA: 0x36B09FC Offset: 0x36AC9FC VA: 0x36B09FC
	public AbnormalData get_AddAbnormal() { }

	[CompilerGenerated]
	// RVA: 0x36B0A04 Offset: 0x36ACA04 VA: 0x36B0A04
	public void set_AddAbnormal(AbnormalData value) { }

	[CompilerGenerated]
	// RVA: 0x36B0A0C Offset: 0x36ACA0C VA: 0x36B0A0C
	public ActionAppendData get_AppendData() { }

	[CompilerGenerated]
	// RVA: 0x36B0A14 Offset: 0x36ACA14 VA: 0x36B0A14
	public void set_AppendData(ActionAppendData value) { }

	[CompilerGenerated]
	// RVA: 0x36B0A1C Offset: 0x36ACA1C VA: 0x36B0A1C
	public byte get_EventAttackType() { }

	[CompilerGenerated]
	// RVA: 0x36B0A24 Offset: 0x36ACA24 VA: 0x36B0A24
	public void set_EventAttackType(byte value) { }

	// RVA: 0x36B0A2C Offset: 0x36ACA2C VA: 0x36B0A2C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36B0A34 Offset: 0x36ACA34 VA: 0x36B0A34
	public void .ctor(Dictionary<object, object> parameters) { }

	// RVA: 0x36B0A3C Offset: 0x36ACA3C VA: 0x36B0A3C Slot: 6
	public override Dictionary<object, object> GetValue() { }

	// RVA: 0x36B0C0C Offset: 0x36ACC0C VA: 0x36B0C0C Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }
}
