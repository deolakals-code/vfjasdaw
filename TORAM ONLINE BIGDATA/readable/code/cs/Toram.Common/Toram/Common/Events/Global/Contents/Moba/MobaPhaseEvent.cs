// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Global.Contents.Moba
public class MobaPhaseEvent : EventSubBase // TypeDefIndex: 12677
{
	// Fields
	[CompilerGenerated]
	private MobaPhaseData <Phase>k__BackingField; // 0x20
	[CompilerGenerated]
	private MobaDamageAreaData <Area>k__BackingField; // 0x28
	[CompilerGenerated]
	private short <MemberNum>k__BackingField; // 0x30
	[CompilerGenerated]
	private byte <Round>k__BackingField; // 0x32

	// Properties
	public MobaPhaseData Phase { get; set; }
	public MobaDamageAreaData Area { get; set; }
	public short MemberNum { get; set; }
	public byte Round { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x363F7C8 Offset: 0x363B7C8 VA: 0x363F7C8
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x363F7D0 Offset: 0x363B7D0 VA: 0x363F7D0
	public MobaPhaseData get_Phase() { }

	[CompilerGenerated]
	// RVA: 0x363F7D8 Offset: 0x363B7D8 VA: 0x363F7D8
	public void set_Phase(MobaPhaseData value) { }

	[CompilerGenerated]
	// RVA: 0x363F7E0 Offset: 0x363B7E0 VA: 0x363F7E0
	public MobaDamageAreaData get_Area() { }

	[CompilerGenerated]
	// RVA: 0x363F7E8 Offset: 0x363B7E8 VA: 0x363F7E8
	public void set_Area(MobaDamageAreaData value) { }

	[CompilerGenerated]
	// RVA: 0x363F7F0 Offset: 0x363B7F0 VA: 0x363F7F0
	public short get_MemberNum() { }

	[CompilerGenerated]
	// RVA: 0x363F7F8 Offset: 0x363B7F8 VA: 0x363F7F8
	public void set_MemberNum(short value) { }

	[CompilerGenerated]
	// RVA: 0x363F800 Offset: 0x363B800 VA: 0x363F800
	public byte get_Round() { }

	[CompilerGenerated]
	// RVA: 0x363F808 Offset: 0x363B808 VA: 0x363F808
	public void set_Round(byte value) { }

	// RVA: 0x363F810 Offset: 0x363B810 VA: 0x363F810 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x363F818 Offset: 0x363B818 VA: 0x363F818 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x363F820 Offset: 0x363B820 VA: 0x363F820 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x363F958 Offset: 0x363B958 VA: 0x363F958 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
