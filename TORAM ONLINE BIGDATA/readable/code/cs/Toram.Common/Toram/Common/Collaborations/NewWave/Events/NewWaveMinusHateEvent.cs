// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Collaborations.NewWave.Events
public class NewWaveMinusHateEvent : EventSubBase // TypeDefIndex: 13051
{
	// Fields
	[CompilerGenerated]
	private int[] <BufferTargetId>k__BackingField; // 0x20
	[CompilerGenerated]
	private short <LastDamageRate>k__BackingField; // 0x28

	// Properties
	[PacketClass(Code = 96)]
	public int[] BufferTargetId { get; set; }
	public short LastDamageRate { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3698234 Offset: 0x3694234 VA: 0x3698234
	public int[] get_BufferTargetId() { }

	[CompilerGenerated]
	// RVA: 0x369823C Offset: 0x369423C VA: 0x369823C
	public void set_BufferTargetId(int[] value) { }

	[CompilerGenerated]
	// RVA: 0x3698244 Offset: 0x3694244 VA: 0x3698244
	public short get_LastDamageRate() { }

	[CompilerGenerated]
	// RVA: 0x369824C Offset: 0x369424C VA: 0x369824C
	public void set_LastDamageRate(short value) { }

	// RVA: 0x3698254 Offset: 0x3694254 VA: 0x3698254 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x369825C Offset: 0x369425C VA: 0x369825C Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3698264 Offset: 0x3694264 VA: 0x3698264
	public void .ctor(Dictionary<byte, object> parameters) { }

	// RVA: 0x369826C Offset: 0x369426C VA: 0x369826C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3698450 Offset: 0x3694450 VA: 0x3698450 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x3698304 Offset: 0x3694304 VA: 0x3698304
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x3698484 Offset: 0x3694484 VA: 0x3698484
	private void GetClass(Dictionary<byte, object> parameters) { }
}
