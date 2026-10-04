// Assembly: Assembly-CSharp.dll
// Namespace: 
public class BCRankingData // TypeDefIndex: 1832
{
	// Fields
	[CompilerGenerated]
	private BCRankingItemType <MainWeapon>k__BackingField; // 0x10
	[CompilerGenerated]
	private BCRankingItemType <SubWeapon>k__BackingField; // 0x12
	[CompilerGenerated]
	private BCollaborationRankingSendData[] <Ranking>k__BackingField; // 0x18
	[CompilerGenerated]
	private BCRankingPropertiesData <PropertyFirst>k__BackingField; // 0x20
	[CompilerGenerated]
	private BCRankingPropertiesData <PropertySecond>k__BackingField; // 0x28
	[CompilerGenerated]
	private BCRankingPropertiesData <PropertyThird>k__BackingField; // 0x30
	[CompilerGenerated]
	private int <ElapsedTime>k__BackingField; // 0x38
	private const int CheckMinutes = 5;
	private DateTime getTime; // 0x40

	// Properties
	public BCRankingItemType MainWeapon { get; set; }
	public BCRankingItemType SubWeapon { get; set; }
	public BCollaborationRankingSendData[] Ranking { get; set; }
	public BCRankingPropertiesData PropertyFirst { get; set; }
	public BCRankingPropertiesData PropertySecond { get; set; }
	public BCRankingPropertiesData PropertyThird { get; set; }
	public int ElapsedTime { get; set; }
	public bool IsUpdateTime { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x20EBD68 Offset: 0x20E7D68 VA: 0x20EBD68
	public BCRankingItemType get_MainWeapon() { }

	[CompilerGenerated]
	// RVA: 0x20EBD70 Offset: 0x20E7D70 VA: 0x20EBD70
	private void set_MainWeapon(BCRankingItemType value) { }

	[CompilerGenerated]
	// RVA: 0x20EBD78 Offset: 0x20E7D78 VA: 0x20EBD78
	public BCRankingItemType get_SubWeapon() { }

	[CompilerGenerated]
	// RVA: 0x20EBD80 Offset: 0x20E7D80 VA: 0x20EBD80
	private void set_SubWeapon(BCRankingItemType value) { }

	[CompilerGenerated]
	// RVA: 0x20EBD88 Offset: 0x20E7D88 VA: 0x20EBD88
	public BCollaborationRankingSendData[] get_Ranking() { }

	[CompilerGenerated]
	// RVA: 0x20EBD90 Offset: 0x20E7D90 VA: 0x20EBD90
	private void set_Ranking(BCollaborationRankingSendData[] value) { }

	[CompilerGenerated]
	// RVA: 0x20EBD98 Offset: 0x20E7D98 VA: 0x20EBD98
	public BCRankingPropertiesData get_PropertyFirst() { }

	[CompilerGenerated]
	// RVA: 0x20EBDA0 Offset: 0x20E7DA0 VA: 0x20EBDA0
	private void set_PropertyFirst(BCRankingPropertiesData value) { }

	[CompilerGenerated]
	// RVA: 0x20EBDA8 Offset: 0x20E7DA8 VA: 0x20EBDA8
	public BCRankingPropertiesData get_PropertySecond() { }

	[CompilerGenerated]
	// RVA: 0x20EBDB0 Offset: 0x20E7DB0 VA: 0x20EBDB0
	private void set_PropertySecond(BCRankingPropertiesData value) { }

	[CompilerGenerated]
	// RVA: 0x20EBDB8 Offset: 0x20E7DB8 VA: 0x20EBDB8
	public BCRankingPropertiesData get_PropertyThird() { }

	[CompilerGenerated]
	// RVA: 0x20EBDC0 Offset: 0x20E7DC0 VA: 0x20EBDC0
	private void set_PropertyThird(BCRankingPropertiesData value) { }

	[CompilerGenerated]
	// RVA: 0x20EBDC8 Offset: 0x20E7DC8 VA: 0x20EBDC8
	public int get_ElapsedTime() { }

	[CompilerGenerated]
	// RVA: 0x20EBDD0 Offset: 0x20E7DD0 VA: 0x20EBDD0
	private void set_ElapsedTime(int value) { }

	// RVA: 0x20EBDD8 Offset: 0x20E7DD8 VA: 0x20EBDD8
	public bool get_IsUpdateTime() { }

	// RVA: 0x20EB768 Offset: 0x20E7768 VA: 0x20EB768
	public void .ctor(BCollaborationGetRankingResponse responseData) { }

	// RVA: 0x20EBEB0 Offset: 0x20E7EB0 VA: 0x20EBEB0
	public List<BCRankingPropertiesData> GetPropertyList() { }
}
