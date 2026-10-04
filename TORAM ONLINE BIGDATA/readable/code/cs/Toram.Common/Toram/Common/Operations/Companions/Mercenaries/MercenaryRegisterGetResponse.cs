// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Companions.Mercenaries
public class MercenaryRegisterGetResponse : OperationResponseBase // TypeDefIndex: 11385
{
	// Fields
	[CompilerGenerated]
	private MercenaryEmployeeData <MyEmployee>k__BackingField; // 0x20

	// Properties
	public MercenaryEmployeeData MyEmployee { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x36FF050 Offset: 0x36FB050 VA: 0x36FF050
	public void .ctor() { }

	// RVA: 0x36FF058 Offset: 0x36FB058 VA: 0x36FF058
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x36FF060 Offset: 0x36FB060 VA: 0x36FF060
	public MercenaryEmployeeData get_MyEmployee() { }

	[CompilerGenerated]
	// RVA: 0x36FF068 Offset: 0x36FB068 VA: 0x36FF068
	public void set_MyEmployee(MercenaryEmployeeData value) { }

	// RVA: 0x36FF070 Offset: 0x36FB070 VA: 0x36FF070
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x36FF18C Offset: 0x36FB18C VA: 0x36FF18C
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x36FF208 Offset: 0x36FB208 VA: 0x36FF208 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36FF210 Offset: 0x36FB210 VA: 0x36FF210 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x36FF218 Offset: 0x36FB218 VA: 0x36FF218 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x36FF2B0 Offset: 0x36FB2B0 VA: 0x36FF2B0 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
