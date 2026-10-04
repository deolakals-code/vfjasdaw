// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Shop.Signboards
public class PutUpSignboardResponse : OperationResponseBase // TypeDefIndex: 11967
{
	// Fields
	[CompilerGenerated]
	private SignboardInfo <Info>k__BackingField; // 0x20
	[CompilerGenerated]
	private ExpenseResponseData <Expense>k__BackingField; // 0x28

	// Properties
	public SignboardInfo Info { get; set; }
	public ExpenseResponseData Expense { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x376F75C Offset: 0x376B75C VA: 0x376F75C
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x376F764 Offset: 0x376B764 VA: 0x376F764
	public SignboardInfo get_Info() { }

	[CompilerGenerated]
	// RVA: 0x376F76C Offset: 0x376B76C VA: 0x376F76C
	public void set_Info(SignboardInfo value) { }

	[CompilerGenerated]
	// RVA: 0x376F774 Offset: 0x376B774 VA: 0x376F774
	public ExpenseResponseData get_Expense() { }

	[CompilerGenerated]
	// RVA: 0x376F77C Offset: 0x376B77C VA: 0x376F77C
	public void set_Expense(ExpenseResponseData value) { }

	// RVA: 0x376F784 Offset: 0x376B784 VA: 0x376F784
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x376F964 Offset: 0x376B964 VA: 0x376F964
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x376FA0C Offset: 0x376BA0C VA: 0x376FA0C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x376FA14 Offset: 0x376BA14 VA: 0x376FA14 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x376FA1C Offset: 0x376BA1C VA: 0x376FA1C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x376FAB4 Offset: 0x376BAB4 VA: 0x376FAB4 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
