// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Shop.Signboards
public class ContentExecuteSignboardResponse : OperationResponseBase // TypeDefIndex: 11963
{
	// Fields
	[CompilerGenerated]
	private RewardResponseDatav2 <Reward>k__BackingField; // 0x20
	[CompilerGenerated]
	private ExpenseResponseData <Expense>k__BackingField; // 0x28

	// Properties
	public RewardResponseDatav2 Reward { get; set; }
	public ExpenseResponseData Expense { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x376EB7C Offset: 0x376AB7C VA: 0x376EB7C
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x376EB84 Offset: 0x376AB84 VA: 0x376EB84
	public RewardResponseDatav2 get_Reward() { }

	[CompilerGenerated]
	// RVA: 0x376EB8C Offset: 0x376AB8C VA: 0x376EB8C
	public void set_Reward(RewardResponseDatav2 value) { }

	[CompilerGenerated]
	// RVA: 0x376EB94 Offset: 0x376AB94 VA: 0x376EB94
	public ExpenseResponseData get_Expense() { }

	[CompilerGenerated]
	// RVA: 0x376EB9C Offset: 0x376AB9C VA: 0x376EB9C
	public void set_Expense(ExpenseResponseData value) { }

	// RVA: 0x376EBA4 Offset: 0x376ABA4 VA: 0x376EBA4 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x376EBAC Offset: 0x376ABAC VA: 0x376EBAC Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x376EBB4 Offset: 0x376ABB4 VA: 0x376EBB4 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x376EE20 Offset: 0x376AE20 VA: 0x376EE20 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
