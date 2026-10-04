// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Mob
public class CaptureStartEvent : EventSubBase // TypeDefIndex: 12640
{
	// Fields
	[CompilerGenerated]
	private int <ArchetypeId>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <TargetId>k__BackingField; // 0x24
	[CompilerGenerated]
	private short <OrgTimer>k__BackingField; // 0x28
	[CompilerGenerated]
	private short <NowTimer>k__BackingField; // 0x2A
	[CompilerGenerated]
	private short <MaxGauge>k__BackingField; // 0x2C
	[CompilerGenerated]
	private short <NowGauge>k__BackingField; // 0x2E
	[CompilerGenerated]
	private short <NowRegist>k__BackingField; // 0x30

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }
	[PacketParameter(Code = 74)]
	public int ArchetypeId { get; set; }
	[PacketParameter(Code = 96, IsOptional = True)]
	public int TargetId { get; set; }
	[PacketParameter(Code = 119)]
	public short OrgTimer { get; set; }
	[PacketParameter(Code = 172)]
	public short NowTimer { get; set; }
	[PacketParameter(Code = 202)]
	public short MaxGauge { get; set; }
	[PacketParameter(Code = 46)]
	public short NowGauge { get; set; }
	[PacketParameter(Code = 204)]
	public short NowRegist { get; set; }

	// Methods

	// RVA: 0x363751C Offset: 0x363351C VA: 0x363751C
	public void .ctor(Dictionary<byte, object> parameters) { }

	// RVA: 0x3637524 Offset: 0x3633524 VA: 0x3637524 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x363752C Offset: 0x363352C VA: 0x363752C Slot: 7
	public override byte get_SubCode() { }

	[CompilerGenerated]
	// RVA: 0x3637534 Offset: 0x3633534 VA: 0x3637534
	public int get_ArchetypeId() { }

	[CompilerGenerated]
	// RVA: 0x363753C Offset: 0x363353C VA: 0x363753C
	public void set_ArchetypeId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3637544 Offset: 0x3633544 VA: 0x3637544
	public int get_TargetId() { }

	[CompilerGenerated]
	// RVA: 0x363754C Offset: 0x363354C VA: 0x363754C
	public void set_TargetId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3637554 Offset: 0x3633554 VA: 0x3637554
	public short get_OrgTimer() { }

	[CompilerGenerated]
	// RVA: 0x363755C Offset: 0x363355C VA: 0x363755C
	public void set_OrgTimer(short value) { }

	[CompilerGenerated]
	// RVA: 0x3637564 Offset: 0x3633564 VA: 0x3637564
	public short get_NowTimer() { }

	[CompilerGenerated]
	// RVA: 0x363756C Offset: 0x363356C VA: 0x363756C
	public void set_NowTimer(short value) { }

	[CompilerGenerated]
	// RVA: 0x3637574 Offset: 0x3633574 VA: 0x3637574
	public short get_MaxGauge() { }

	[CompilerGenerated]
	// RVA: 0x363757C Offset: 0x363357C VA: 0x363757C
	public void set_MaxGauge(short value) { }

	[CompilerGenerated]
	// RVA: 0x3637584 Offset: 0x3633584 VA: 0x3637584
	public short get_NowGauge() { }

	[CompilerGenerated]
	// RVA: 0x363758C Offset: 0x363358C VA: 0x363758C
	public void set_NowGauge(short value) { }

	[CompilerGenerated]
	// RVA: 0x3637594 Offset: 0x3633594 VA: 0x3637594
	public short get_NowRegist() { }

	[CompilerGenerated]
	// RVA: 0x363759C Offset: 0x363359C VA: 0x363759C
	public void set_NowRegist(short value) { }

	// RVA: 0x36375A4 Offset: 0x36335A4 VA: 0x36375A4 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x36378A4 Offset: 0x36338A4 VA: 0x36378A4 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
