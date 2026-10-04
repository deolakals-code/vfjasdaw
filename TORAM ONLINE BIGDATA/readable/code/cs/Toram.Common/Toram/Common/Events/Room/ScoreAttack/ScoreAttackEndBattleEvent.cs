// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Room.ScoreAttack
public class ScoreAttackEndBattleEvent : EventSubBase // TypeDefIndex: 12801
{
	// Fields
	[CompilerGenerated]
	private bool <IsRetire>k__BackingField; // 0x20
	[CompilerGenerated]
	private ScoreAttackResultData <Result>k__BackingField; // 0x28
	[CompilerGenerated]
	private byte <RegistFailedType>k__BackingField; // 0x30
	[CompilerGenerated]
	private List<byte> <NewRecordList>k__BackingField; // 0x38

	// Properties
	public bool IsRetire { get; set; }
	public ScoreAttackResultData Result { get; set; }
	public byte RegistFailedType { get; set; }
	public List<byte> NewRecordList { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x365C7D4 Offset: 0x36587D4 VA: 0x365C7D4
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x365C7DC Offset: 0x36587DC VA: 0x365C7DC
	public bool get_IsRetire() { }

	[CompilerGenerated]
	// RVA: 0x365C7E4 Offset: 0x36587E4 VA: 0x365C7E4
	public void set_IsRetire(bool value) { }

	[CompilerGenerated]
	// RVA: 0x365C7F0 Offset: 0x36587F0 VA: 0x365C7F0
	public ScoreAttackResultData get_Result() { }

	[CompilerGenerated]
	// RVA: 0x365C7F8 Offset: 0x36587F8 VA: 0x365C7F8
	public void set_Result(ScoreAttackResultData value) { }

	[CompilerGenerated]
	// RVA: 0x365C800 Offset: 0x3658800 VA: 0x365C800
	public byte get_RegistFailedType() { }

	[CompilerGenerated]
	// RVA: 0x365C808 Offset: 0x3658808 VA: 0x365C808
	public void set_RegistFailedType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x365C810 Offset: 0x3658810 VA: 0x365C810
	public List<byte> get_NewRecordList() { }

	[CompilerGenerated]
	// RVA: 0x365C818 Offset: 0x3658818 VA: 0x365C818
	public void set_NewRecordList(List<byte> value) { }

	// RVA: 0x365C820 Offset: 0x3658820 VA: 0x365C820 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x365C828 Offset: 0x3658828 VA: 0x365C828 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x365C830 Offset: 0x3658830 VA: 0x365C830 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x365C99C Offset: 0x365899C VA: 0x365C99C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
