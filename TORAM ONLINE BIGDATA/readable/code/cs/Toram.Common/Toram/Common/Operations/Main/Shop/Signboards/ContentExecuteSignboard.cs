// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Shop.Signboards
public class ContentExecuteSignboard : OperationRequestBase // TypeDefIndex: 11962
{
	// Fields
	[CompilerGenerated]
	private int <TargetId>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <SignboardType>k__BackingField; // 0x24
	[CompilerGenerated]
	private int <RequiredItemId>k__BackingField; // 0x28
	[CompilerGenerated]
	private DateTime <SignboardDate>k__BackingField; // 0x30
	[CompilerGenerated]
	private int <AutoLockFlag>k__BackingField; // 0x38

	// Properties
	public int TargetId { get; set; }
	public byte SignboardType { get; set; }
	public int RequiredItemId { get; set; }
	public DateTime SignboardDate { get; set; }
	public int AutoLockFlag { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x376E6B0 Offset: 0x376A6B0 VA: 0x376E6B0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x376E6B8 Offset: 0x376A6B8 VA: 0x376E6B8
	public int get_TargetId() { }

	[CompilerGenerated]
	// RVA: 0x376E6C0 Offset: 0x376A6C0 VA: 0x376E6C0
	public void set_TargetId(int value) { }

	[CompilerGenerated]
	// RVA: 0x376E6C8 Offset: 0x376A6C8 VA: 0x376E6C8
	public byte get_SignboardType() { }

	[CompilerGenerated]
	// RVA: 0x376E6D0 Offset: 0x376A6D0 VA: 0x376E6D0
	public void set_SignboardType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x376E6D8 Offset: 0x376A6D8 VA: 0x376E6D8
	public int get_RequiredItemId() { }

	[CompilerGenerated]
	// RVA: 0x376E6E0 Offset: 0x376A6E0 VA: 0x376E6E0
	public void set_RequiredItemId(int value) { }

	[CompilerGenerated]
	// RVA: 0x376E6E8 Offset: 0x376A6E8 VA: 0x376E6E8
	public DateTime get_SignboardDate() { }

	[CompilerGenerated]
	// RVA: 0x376E6F0 Offset: 0x376A6F0 VA: 0x376E6F0
	public void set_SignboardDate(DateTime value) { }

	[CompilerGenerated]
	// RVA: 0x376E6F8 Offset: 0x376A6F8 VA: 0x376E6F8
	public int get_AutoLockFlag() { }

	[CompilerGenerated]
	// RVA: 0x376E700 Offset: 0x376A700 VA: 0x376E700
	public void set_AutoLockFlag(int value) { }

	// RVA: 0x376E708 Offset: 0x376A708 VA: 0x376E708
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x376E70C Offset: 0x376A70C VA: 0x376E70C
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x376E710 Offset: 0x376A710 VA: 0x376E710 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x376E718 Offset: 0x376A718 VA: 0x376E718 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x376E720 Offset: 0x376A720 VA: 0x376E720 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x376E9C4 Offset: 0x376A9C4 VA: 0x376E9C4 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
