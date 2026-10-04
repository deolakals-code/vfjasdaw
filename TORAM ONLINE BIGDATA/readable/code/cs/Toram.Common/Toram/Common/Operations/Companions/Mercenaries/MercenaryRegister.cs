// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Companions.Mercenaries
public class MercenaryRegister : OperationRequestBase // TypeDefIndex: 11389
{
	// Fields
	[CompilerGenerated]
	private byte <StanceType>k__BackingField; // 0x20
	[CompilerGenerated]
	private Dictionary<short, byte> <Skills>k__BackingField; // 0x28

	// Properties
	public byte StanceType { get; set; }
	public Dictionary<short, byte> Skills { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x36FFA40 Offset: 0x36FBA40 VA: 0x36FFA40
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x36FFA48 Offset: 0x36FBA48 VA: 0x36FFA48
	public byte get_StanceType() { }

	[CompilerGenerated]
	// RVA: 0x36FFA50 Offset: 0x36FBA50 VA: 0x36FFA50
	public void set_StanceType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36FFA58 Offset: 0x36FBA58 VA: 0x36FFA58
	public Dictionary<short, byte> get_Skills() { }

	[CompilerGenerated]
	// RVA: 0x36FFA60 Offset: 0x36FBA60 VA: 0x36FFA60
	public void set_Skills(Dictionary<short, byte> value) { }

	// RVA: 0x36FFA68 Offset: 0x36FBA68 VA: 0x36FFA68 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36FFA70 Offset: 0x36FBA70 VA: 0x36FFA70 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x36FFA78 Offset: 0x36FBA78 VA: 0x36FFA78 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x36FFC38 Offset: 0x36FBC38 VA: 0x36FFC38 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
