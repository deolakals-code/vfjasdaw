// Assembly: Assembly-CSharp.dll
// Namespace: 
public class GuildFacilityManager // TypeDefIndex: 1910
{
	// Fields
	public static readonly int[] ActiveGuildFacilityIds; // 0x0
	private Dictionary<int, GuildFacilityDataBase> facilityList; // 0x10
	private Dictionary<byte, short> useElementData; // 0x18

	// Properties
	public bool IsActiveBuffer { get; }

	// Methods

	// RVA: 0x20FB13C Offset: 0x20F713C VA: 0x20FB13C
	public bool get_IsActiveBuffer() { }

	// RVA: 0x20FB23C Offset: 0x20F723C VA: 0x20FB23C
	public void .ctor() { }

	// RVA: 0x20FB2C4 Offset: 0x20F72C4 VA: 0x20FB2C4
	public void UpdateUseElementData(GuildFacilityUseElementData data) { }

	// RVA: 0x20FB2DC Offset: 0x20F72DC VA: 0x20FB2DC
	public void SetActiveBuffer(bool isActive) { }

	// RVA: 0x20FB3CC Offset: 0x20F73CC VA: 0x20FB3CC
	public void UpdateFacilityData(GuildFacilityData data) { }

	// RVA: 0x20FB4E0 Offset: 0x20F74E0 VA: 0x20FB4E0
	public void ClearFacilityData() { }

	// RVA: 0x20FB540 Offset: 0x20F7540 VA: 0x20FB540
	public bool TryGetFacilityData(int id, out GuildFacilityDataBase facilityData) { }

	// RVA: 0x20FB5A8 Offset: 0x20F75A8 VA: 0x20FB5A8
	public Dictionary<short, short> GetBonusData() { }

	// RVA: 0x20FB950 Offset: 0x20F7950 VA: 0x20FB950
	public short GetElementItemUseNum(ElementType element) { }

	// RVA: 0x20FB9C4 Offset: 0x20F79C4 VA: 0x20FB9C4
	private static void .cctor() { }
}
