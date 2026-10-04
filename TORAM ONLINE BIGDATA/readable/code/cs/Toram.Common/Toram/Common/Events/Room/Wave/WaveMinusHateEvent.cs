// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Room.Wave
public class WaveMinusHateEvent : EventSubBase // TypeDefIndex: 12758
{
	// Fields
	[CompilerGenerated]
	private int[] <TargetId>k__BackingField; // 0x20

	// Properties
	[PacketClass(Code = 96)]
	public int[] TargetId { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3652978 Offset: 0x364E978 VA: 0x3652978
	public int[] get_TargetId() { }

	[CompilerGenerated]
	// RVA: 0x3652980 Offset: 0x364E980 VA: 0x3652980
	public void set_TargetId(int[] value) { }

	// RVA: 0x3652988 Offset: 0x364E988 VA: 0x3652988 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3652990 Offset: 0x364E990 VA: 0x3652990 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3652998 Offset: 0x364E998 VA: 0x3652998
	public void .ctor(Dictionary<byte, object> parameters) { }

	// RVA: 0x36529A0 Offset: 0x364E9A0 VA: 0x36529A0 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3652B10 Offset: 0x364EB10 VA: 0x3652B10 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x3652A38 Offset: 0x364EA38 VA: 0x3652A38
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x3652B44 Offset: 0x364EB44 VA: 0x3652B44
	private void GetClass(Dictionary<byte, object> parameters) { }
}
