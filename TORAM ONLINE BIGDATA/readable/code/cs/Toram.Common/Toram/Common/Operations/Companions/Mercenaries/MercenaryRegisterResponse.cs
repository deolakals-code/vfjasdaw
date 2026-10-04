// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Companions.Mercenaries
public class MercenaryRegisterResponse : OperationResponseBase // TypeDefIndex: 11387
{
	// Fields
	[CompilerGenerated]
	private MercenaryEmployeeData <MyEmployee>k__BackingField; // 0x20

	// Properties
	public MercenaryEmployeeData MyEmployee { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x36FF7B0 Offset: 0x36FB7B0 VA: 0x36FF7B0
	public void .ctor() { }

	// RVA: 0x36FF7B8 Offset: 0x36FB7B8 VA: 0x36FF7B8
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x36FF7C0 Offset: 0x36FB7C0 VA: 0x36FF7C0
	public MercenaryEmployeeData get_MyEmployee() { }

	[CompilerGenerated]
	// RVA: 0x36FF7C8 Offset: 0x36FB7C8 VA: 0x36FF7C8
	public void set_MyEmployee(MercenaryEmployeeData value) { }

	// RVA: 0x36FF7D0 Offset: 0x36FB7D0 VA: 0x36FF7D0
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x36FF8EC Offset: 0x36FB8EC VA: 0x36FF8EC
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x36FF968 Offset: 0x36FB968 VA: 0x36FF968 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36FF970 Offset: 0x36FB970 VA: 0x36FF970 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x36FF978 Offset: 0x36FB978 VA: 0x36FF978 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x36FFA10 Offset: 0x36FBA10 VA: 0x36FFA10 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
