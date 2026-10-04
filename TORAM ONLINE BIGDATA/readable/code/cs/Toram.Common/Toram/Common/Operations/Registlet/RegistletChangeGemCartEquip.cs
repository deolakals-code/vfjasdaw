// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Registlet
public class RegistletChangeGemCartEquip : OperationRequestBase // TypeDefIndex: 11445
{
	// Fields
	[CompilerGenerated]
	private Dictionary<byte, long> <Equips>k__BackingField; // 0x20

	// Properties
	[PacketParameter(Code = 15)]
	public Dictionary<byte, long> Equips { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x370BBFC Offset: 0x3707BFC VA: 0x370BBFC
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x370BC04 Offset: 0x3707C04 VA: 0x370BC04
	public Dictionary<byte, long> get_Equips() { }

	[CompilerGenerated]
	// RVA: 0x370BC0C Offset: 0x3707C0C VA: 0x370BC0C
	public void set_Equips(Dictionary<byte, long> value) { }

	// RVA: 0x370BC14 Offset: 0x3707C14 VA: 0x370BC14 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x370BC1C Offset: 0x3707C1C VA: 0x370BC1C Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x370BC24 Offset: 0x3707C24 VA: 0x370BC24 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x370BC90 Offset: 0x3707C90 VA: 0x370BC90 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
