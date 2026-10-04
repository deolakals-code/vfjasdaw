// Assembly: Assembly-CSharp.dll
// Namespace: 
public class StampManager // TypeDefIndex: 3767
{
	// Fields
	[CompilerGenerated]
	private StampCardData <StampCard>k__BackingField; // 0x10
	[CompilerGenerated]
	private StampCardData <RewardCard>k__BackingField; // 0x18
	[CompilerGenerated]
	private StampData <Stamp>k__BackingField; // 0x20
	[CompilerGenerated]
	private bool <IsCarryOver>k__BackingField; // 0x28

	// Properties
	public StampCardData StampCard { get; set; }
	public StampCardData RewardCard { get; set; }
	public StampData Stamp { get; set; }
	public bool IsFirstLogin { get; }
	public bool IsCarryOver { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x23E34CC Offset: 0x23DF4CC VA: 0x23E34CC
	public StampCardData get_StampCard() { }

	[CompilerGenerated]
	// RVA: 0x23E34D4 Offset: 0x23DF4D4 VA: 0x23E34D4
	private void set_StampCard(StampCardData value) { }

	[CompilerGenerated]
	// RVA: 0x23E34DC Offset: 0x23DF4DC VA: 0x23E34DC
	public StampCardData get_RewardCard() { }

	[CompilerGenerated]
	// RVA: 0x23E34E4 Offset: 0x23DF4E4 VA: 0x23E34E4
	private void set_RewardCard(StampCardData value) { }

	[CompilerGenerated]
	// RVA: 0x23E34EC Offset: 0x23DF4EC VA: 0x23E34EC
	public StampData get_Stamp() { }

	[CompilerGenerated]
	// RVA: 0x23E34F4 Offset: 0x23DF4F4 VA: 0x23E34F4
	private void set_Stamp(StampData value) { }

	// RVA: 0x23E34FC Offset: 0x23DF4FC VA: 0x23E34FC
	public bool get_IsFirstLogin() { }

	[CompilerGenerated]
	// RVA: 0x23E351C Offset: 0x23DF51C VA: 0x23E351C
	public bool get_IsCarryOver() { }

	[CompilerGenerated]
	// RVA: 0x23E3524 Offset: 0x23DF524 VA: 0x23E3524
	private void set_IsCarryOver(bool value) { }

	// RVA: 0x23E3530 Offset: 0x23DF530 VA: 0x23E3530
	public void Initialize(LoginStampEvent stampEvent) { }

	// RVA: 0x23E35D4 Offset: 0x23DF5D4 VA: 0x23E35D4
	public void StampClear() { }

	// RVA: 0x23E35F8 Offset: 0x23DF5F8 VA: 0x23E35F8
	public void UpdateReward(StampCardData reward) { }

	// RVA: 0x23E366C Offset: 0x23DF66C VA: 0x23E366C
	public void .ctor() { }
}
