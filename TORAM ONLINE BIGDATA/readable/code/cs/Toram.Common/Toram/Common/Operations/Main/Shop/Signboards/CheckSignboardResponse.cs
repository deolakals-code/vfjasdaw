// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Shop.Signboards
public class CheckSignboardResponse : OperationResponseBase // TypeDefIndex: 11961
{
	// Fields
	[CompilerGenerated]
	private SignboardInfo <Info>k__BackingField; // 0x20

	// Properties
	public SignboardInfo Info { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x376E420 Offset: 0x376A420 VA: 0x376E420
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x376E428 Offset: 0x376A428 VA: 0x376E428
	public SignboardInfo get_Info() { }

	[CompilerGenerated]
	// RVA: 0x376E430 Offset: 0x376A430 VA: 0x376E430
	public void set_Info(SignboardInfo value) { }

	// RVA: 0x376E438 Offset: 0x376A438 VA: 0x376E438
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x376E558 Offset: 0x376A558 VA: 0x376E558
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x376E5D4 Offset: 0x376A5D4 VA: 0x376E5D4 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x376E5DC Offset: 0x376A5DC VA: 0x376E5DC Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x376E5E4 Offset: 0x376A5E4 VA: 0x376E5E4 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x376E67C Offset: 0x376A67C VA: 0x376E67C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
