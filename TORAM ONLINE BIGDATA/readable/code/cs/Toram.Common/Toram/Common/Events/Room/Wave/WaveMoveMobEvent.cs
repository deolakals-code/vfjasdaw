// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Room.Wave
public class WaveMoveMobEvent : EventSubBase // TypeDefIndex: 12763
{
	// Fields
	[CompilerGenerated]
	private MobData[] <MobList>k__BackingField; // 0x20

	// Properties
	[PacketClass(Code = 89, IsOptional = True)]
	public MobData[] MobList { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3653A08 Offset: 0x364FA08 VA: 0x3653A08
	public MobData[] get_MobList() { }

	[CompilerGenerated]
	// RVA: 0x3653A10 Offset: 0x364FA10 VA: 0x3653A10
	public void set_MobList(MobData[] value) { }

	// RVA: 0x3653A18 Offset: 0x364FA18 VA: 0x3653A18 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3653A20 Offset: 0x364FA20 VA: 0x3653A20 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3653A28 Offset: 0x364FA28 VA: 0x3653A28
	public void .ctor(Dictionary<byte, object> parameters) { }

	// RVA: 0x3653A30 Offset: 0x364FA30 VA: 0x3653A30 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3653BC8 Offset: 0x364FBC8 VA: 0x3653BC8 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x3653AC8 Offset: 0x364FAC8 VA: 0x3653AC8
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x3653BFC Offset: 0x364FBFC VA: 0x3653BFC
	private void GetClass(Dictionary<byte, object> parameters) { }
}
