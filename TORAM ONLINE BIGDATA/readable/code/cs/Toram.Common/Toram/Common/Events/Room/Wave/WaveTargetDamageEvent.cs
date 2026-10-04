// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Room.Wave
public class WaveTargetDamageEvent : EventSubBase // TypeDefIndex: 12759
{
	// Fields
	[CompilerGenerated]
	private short <TargetId>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <TargetHp>k__BackingField; // 0x24
	[CompilerGenerated]
	private int <Damage>k__BackingField; // 0x28

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }
	[PacketParameter(Code = 96)]
	public short TargetId { get; set; }
	[PacketParameter(Code = 25)]
	public int TargetHp { get; set; }
	[PacketParameter(Code = 195)]
	public int Damage { get; set; }

	// Methods

	// RVA: 0x3652BA0 Offset: 0x364EBA0 VA: 0x3652BA0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3652BA8 Offset: 0x364EBA8 VA: 0x3652BA8 Slot: 7
	public override byte get_SubCode() { }

	[CompilerGenerated]
	// RVA: 0x3652BB0 Offset: 0x364EBB0 VA: 0x3652BB0
	public short get_TargetId() { }

	[CompilerGenerated]
	// RVA: 0x3652BB8 Offset: 0x364EBB8 VA: 0x3652BB8
	public void set_TargetId(short value) { }

	[CompilerGenerated]
	// RVA: 0x3652BC0 Offset: 0x364EBC0 VA: 0x3652BC0
	public int get_TargetHp() { }

	[CompilerGenerated]
	// RVA: 0x3652BC8 Offset: 0x364EBC8 VA: 0x3652BC8
	public void set_TargetHp(int value) { }

	[CompilerGenerated]
	// RVA: 0x3652BD0 Offset: 0x364EBD0 VA: 0x3652BD0
	public int get_Damage() { }

	[CompilerGenerated]
	// RVA: 0x3652BD8 Offset: 0x364EBD8 VA: 0x3652BD8
	public void set_Damage(int value) { }

	// RVA: 0x3652BE0 Offset: 0x364EBE0 VA: 0x3652BE0
	public void .ctor(Dictionary<byte, object> parameters) { }

	// RVA: 0x3652BE8 Offset: 0x364EBE8 VA: 0x3652BE8
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x3652BEC Offset: 0x364EBEC VA: 0x3652BEC
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x3652BF0 Offset: 0x364EBF0 VA: 0x3652BF0 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3652DB4 Offset: 0x364EDB4 VA: 0x3652DB4 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
