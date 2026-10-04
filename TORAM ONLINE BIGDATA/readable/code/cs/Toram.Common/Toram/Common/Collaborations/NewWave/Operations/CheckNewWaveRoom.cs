// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Collaborations.NewWave.Operations
public class CheckNewWaveRoom : OperationRequestBase // TypeDefIndex: 13045
{
	// Fields
	[CompilerGenerated]
	private int <FieldId>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <RoomId>k__BackingField; // 0x24
	[CompilerGenerated]
	private byte <Flag>k__BackingField; // 0x25

	// Properties
	[PacketParameter(Code = 60)]
	public int FieldId { get; set; }
	[PacketParameter(Code = 106)]
	public byte RoomId { get; set; }
	public byte Flag { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3696690 Offset: 0x3692690 VA: 0x3696690
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3696698 Offset: 0x3692698 VA: 0x3696698
	public int get_FieldId() { }

	[CompilerGenerated]
	// RVA: 0x36966A0 Offset: 0x36926A0 VA: 0x36966A0
	public void set_FieldId(int value) { }

	[CompilerGenerated]
	// RVA: 0x36966A8 Offset: 0x36926A8 VA: 0x36966A8
	public byte get_RoomId() { }

	[CompilerGenerated]
	// RVA: 0x36966B0 Offset: 0x36926B0 VA: 0x36966B0
	public void set_RoomId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36966B8 Offset: 0x36926B8 VA: 0x36966B8
	public byte get_Flag() { }

	[CompilerGenerated]
	// RVA: 0x36966C0 Offset: 0x36926C0 VA: 0x36966C0
	public void set_Flag(byte value) { }

	// RVA: 0x36966C8 Offset: 0x36926C8 VA: 0x36966C8
	public void SetForcibly(bool isForcibly) { }

	// RVA: 0x36966F4 Offset: 0x36926F4 VA: 0x36966F4
	public void SetMatching(bool isMatching) { }

	// RVA: 0x36966D8 Offset: 0x36926D8 VA: 0x36966D8
	private void SetFlag(byte flag, bool isOn) { }

	// RVA: 0x3696714 Offset: 0x3692714 VA: 0x3696714 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x369671C Offset: 0x369271C VA: 0x369671C Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3696724 Offset: 0x3692724 VA: 0x3696724 Slot: 3
	public override string ToString() { }

	// RVA: 0x36967E0 Offset: 0x36927E0 VA: 0x36967E0 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x36969A4 Offset: 0x36929A4 VA: 0x36969A4 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
