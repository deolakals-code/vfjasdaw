// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIWorldMapPanel.WorldMapData // TypeDefIndex: 7388
{
	// Fields
	[CompilerGenerated]
	private int <ChipId>k__BackingField; // 0x10
	public readonly int MapId; // 0x14
	public readonly Vector3 Position; // 0x18
	public readonly int Root; // 0x24
	public readonly Color32 LabelColor; // 0x28
	public readonly byte ViewType; // 0x2C
	public readonly byte ScenarioId; // 0x2D
	public readonly int SortId; // 0x30
	public readonly UIWorldMapPanel.WorldMapData.MobData[] MobDataList; // 0x38
	[CompilerGenerated]
	private bool <IsWarpMap>k__BackingField; // 0x40
	[CompilerGenerated]
	private bool <IsPickup>k__BackingField; // 0x41

	// Properties
	public int ChipId { get; set; }
	public bool IsWarpMap { get; set; }
	public bool IsPickup { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1B3C43C Offset: 0x1B3843C VA: 0x1B3C43C
	public int get_ChipId() { }

	[CompilerGenerated]
	// RVA: 0x1B3C444 Offset: 0x1B38444 VA: 0x1B3C444
	private void set_ChipId(int value) { }

	[CompilerGenerated]
	// RVA: 0x1B3C44C Offset: 0x1B3844C VA: 0x1B3C44C
	public bool get_IsWarpMap() { }

	[CompilerGenerated]
	// RVA: 0x1B3C454 Offset: 0x1B38454 VA: 0x1B3C454
	private void set_IsWarpMap(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1B3C460 Offset: 0x1B38460 VA: 0x1B3C460
	public bool get_IsPickup() { }

	[CompilerGenerated]
	// RVA: 0x1B3C468 Offset: 0x1B38468 VA: 0x1B3C468
	private void set_IsPickup(bool value) { }

	// RVA: 0x1B3C474 Offset: 0x1B38474 VA: 0x1B3C474
	public void .ctor(int mapId, int chipId, int moveRoot, int x, int z, int type, byte scenarioId, int sortId, UIWorldMapPanel.WorldMapData.MobData[] mobDataList) { }

	// RVA: 0x1B38484 Offset: 0x1B34484 VA: 0x1B38484
	public bool IsBonusMap(int playerLevel) { }

	// RVA: 0x1B3C5AC Offset: 0x1B385AC VA: 0x1B3C5AC
	public void SetWarpMap(bool isWarpMap) { }

	// RVA: 0x1B3C5B8 Offset: 0x1B385B8 VA: 0x1B3C5B8
	public void ChangeChipType(int chipId) { }

	// RVA: 0x1B3C5C0 Offset: 0x1B385C0 VA: 0x1B3C5C0
	public void SetPickUp(bool isPickup) { }
}
