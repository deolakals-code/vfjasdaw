// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Room.Wave
public class WaveMoveDefenceObjectEvent : EventSubBase // TypeDefIndex: 12762
{
	// Fields
	[CompilerGenerated]
	private WaveTargetData <DefenceObject>k__BackingField; // 0x20

	// Properties
	[PacketClass(Code = 73, IsOptional = True)]
	public WaveTargetData DefenceObject { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x365377C Offset: 0x364F77C VA: 0x365377C
	public WaveTargetData get_DefenceObject() { }

	[CompilerGenerated]
	// RVA: 0x3653784 Offset: 0x364F784 VA: 0x3653784
	public void set_DefenceObject(WaveTargetData value) { }

	// RVA: 0x365378C Offset: 0x364F78C VA: 0x365378C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3653794 Offset: 0x364F794 VA: 0x3653794 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x365379C Offset: 0x364F79C VA: 0x365379C
	public void .ctor(Dictionary<byte, object> parameters) { }

	// RVA: 0x36537A4 Offset: 0x364F7A4 VA: 0x36537A4 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3653958 Offset: 0x364F958 VA: 0x3653958 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x365383C Offset: 0x364F83C VA: 0x365383C
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x365398C Offset: 0x364F98C VA: 0x365398C
	private void GetClass(Dictionary<byte, object> parameters) { }
}
