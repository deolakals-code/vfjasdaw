// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Battle.MobBuff
public class MobBuffEndEvent : EventSubBase // TypeDefIndex: 12725
{
	// Fields
	[CompilerGenerated]
	private MobIdData <MobIdData>k__BackingField; // 0x20
	[CompilerGenerated]
	private short <Id>k__BackingField; // 0x28

	// Properties
	[PacketClass(Code = 29)]
	public MobIdData MobIdData { get; set; }
	[PacketParameter(Code = 0)]
	public short Id { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x364B9F0 Offset: 0x36479F0 VA: 0x364B9F0
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x364B9F8 Offset: 0x36479F8 VA: 0x364B9F8
	public MobIdData get_MobIdData() { }

	[CompilerGenerated]
	// RVA: 0x364BA00 Offset: 0x3647A00 VA: 0x364BA00
	public void set_MobIdData(MobIdData value) { }

	[CompilerGenerated]
	// RVA: 0x364BA08 Offset: 0x3647A08 VA: 0x364BA08
	public short get_Id() { }

	[CompilerGenerated]
	// RVA: 0x364BA10 Offset: 0x3647A10 VA: 0x364BA10
	public void set_Id(short value) { }

	// RVA: 0x364BA18 Offset: 0x3647A18 VA: 0x364BA18 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x364BA20 Offset: 0x3647A20 VA: 0x364BA20 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x364BA28 Offset: 0x3647A28 VA: 0x364BA28 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x364BAF4 Offset: 0x3647AF4 VA: 0x364BAF4 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
