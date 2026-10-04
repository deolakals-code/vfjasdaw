// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Mob
public class CaptureUpdateEvent : EventSubBase // TypeDefIndex: 12642
{
	// Fields
	[CompilerGenerated]
	private int <TargetId>k__BackingField; // 0x20
	[CompilerGenerated]
	private short <NowTimer>k__BackingField; // 0x24
	[CompilerGenerated]
	private short <NowGauge>k__BackingField; // 0x26
	[CompilerGenerated]
	private short <NowRegist>k__BackingField; // 0x28

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }
	[PacketParameter(Code = 96, IsOptional = True)]
	public int TargetId { get; set; }
	[PacketParameter(Code = 172)]
	public short NowTimer { get; set; }
	[PacketParameter(Code = 46)]
	public short NowGauge { get; set; }
	[PacketParameter(Code = 204)]
	public short NowRegist { get; set; }

	// Methods

	// RVA: 0x3637DD4 Offset: 0x3633DD4 VA: 0x3637DD4
	public void .ctor(Dictionary<byte, object> parameters) { }

	// RVA: 0x3637DDC Offset: 0x3633DDC VA: 0x3637DDC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3637DE4 Offset: 0x3633DE4 VA: 0x3637DE4 Slot: 7
	public override byte get_SubCode() { }

	[CompilerGenerated]
	// RVA: 0x3637DEC Offset: 0x3633DEC VA: 0x3637DEC
	public int get_TargetId() { }

	[CompilerGenerated]
	// RVA: 0x3637DF4 Offset: 0x3633DF4 VA: 0x3637DF4
	public void set_TargetId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3637DFC Offset: 0x3633DFC VA: 0x3637DFC
	public short get_NowTimer() { }

	[CompilerGenerated]
	// RVA: 0x3637E04 Offset: 0x3633E04 VA: 0x3637E04
	public void set_NowTimer(short value) { }

	[CompilerGenerated]
	// RVA: 0x3637E0C Offset: 0x3633E0C VA: 0x3637E0C
	public short get_NowGauge() { }

	[CompilerGenerated]
	// RVA: 0x3637E14 Offset: 0x3633E14 VA: 0x3637E14
	public void set_NowGauge(short value) { }

	[CompilerGenerated]
	// RVA: 0x3637E1C Offset: 0x3633E1C VA: 0x3637E1C
	public short get_NowRegist() { }

	[CompilerGenerated]
	// RVA: 0x3637E24 Offset: 0x3633E24 VA: 0x3637E24
	public void set_NowRegist(short value) { }

	// RVA: 0x3637E2C Offset: 0x3633E2C VA: 0x3637E2C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3638060 Offset: 0x3634060 VA: 0x3638060 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
