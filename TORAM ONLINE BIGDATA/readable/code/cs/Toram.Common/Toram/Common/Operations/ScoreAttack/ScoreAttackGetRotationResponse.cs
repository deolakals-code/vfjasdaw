// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.ScoreAttack
public class ScoreAttackGetRotationResponse : OperationResponseBase // TypeDefIndex: 11733
{
	// Fields
	[CompilerGenerated]
	private byte <CurrentRotationId>k__BackingField; // 0x20
	[CompilerGenerated]
	private TimeSpan <CurrentRotationLeftTime>k__BackingField; // 0x28
	[CompilerGenerated]
	private ScoreAttackRotationData[] <RotationList>k__BackingField; // 0x30
	[CompilerGenerated]
	private bool <IsSuspended>k__BackingField; // 0x38

	// Properties
	public byte CurrentRotationId { get; set; }
	public TimeSpan CurrentRotationLeftTime { get; set; }
	public ScoreAttackRotationData[] RotationList { get; set; }
	public bool IsSuspended { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x373E7DC Offset: 0x373A7DC VA: 0x373E7DC
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x373E7E4 Offset: 0x373A7E4 VA: 0x373E7E4
	public byte get_CurrentRotationId() { }

	[CompilerGenerated]
	// RVA: 0x373E7EC Offset: 0x373A7EC VA: 0x373E7EC
	public void set_CurrentRotationId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x373E7F4 Offset: 0x373A7F4 VA: 0x373E7F4
	public TimeSpan get_CurrentRotationLeftTime() { }

	[CompilerGenerated]
	// RVA: 0x373E7FC Offset: 0x373A7FC VA: 0x373E7FC
	public void set_CurrentRotationLeftTime(TimeSpan value) { }

	[CompilerGenerated]
	// RVA: 0x373E804 Offset: 0x373A804 VA: 0x373E804
	public ScoreAttackRotationData[] get_RotationList() { }

	[CompilerGenerated]
	// RVA: 0x373E80C Offset: 0x373A80C VA: 0x373E80C
	public void set_RotationList(ScoreAttackRotationData[] value) { }

	[CompilerGenerated]
	// RVA: 0x373E814 Offset: 0x373A814 VA: 0x373E814
	public bool get_IsSuspended() { }

	[CompilerGenerated]
	// RVA: 0x373E81C Offset: 0x373A81C VA: 0x373E81C
	public void set_IsSuspended(bool value) { }

	// RVA: 0x373E828 Offset: 0x373A828 VA: 0x373E828 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x373E830 Offset: 0x373A830 VA: 0x373E830 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x373E838 Offset: 0x373A838 VA: 0x373E838 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x373E9C0 Offset: 0x373A9C0 VA: 0x373E9C0 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
