// Assembly: Assembly-CSharp.dll
// Namespace: 
public class BlackKnightMobMasterStatus // TypeDefIndex: 4200
{
	// Fields
	private float size; // 0x10
	private float height; // 0x14
	private int mobId; // 0x18
	private int commandNum; // 0x1C
	private List<int> commandIdList; // 0x20
	private Dictionary<int, int> hitAreaNumList; // 0x28
	private Dictionary<int, List<BlackKnightHitAreaData>> hitAreaList; // 0x30

	// Properties
	public int MobId { get; set; }
	public int CommandNum { get; set; }
	public List<int> CommandIdList { get; }
	public Dictionary<int, int> HitAreaNumList { get; }
	public Dictionary<int, List<BlackKnightHitAreaData>> HitAreaList { get; }
	public float Size { get; set; }
	public float Height { get; set; }

	// Methods

	// RVA: 0x24A9AC4 Offset: 0x24A5AC4 VA: 0x24A9AC4
	public int get_MobId() { }

	// RVA: 0x24A9ACC Offset: 0x24A5ACC VA: 0x24A9ACC
	public void set_MobId(int value) { }

	// RVA: 0x24A9AD4 Offset: 0x24A5AD4 VA: 0x24A9AD4
	public int get_CommandNum() { }

	// RVA: 0x24A9ADC Offset: 0x24A5ADC VA: 0x24A9ADC
	public void set_CommandNum(int value) { }

	// RVA: 0x24A9AE4 Offset: 0x24A5AE4 VA: 0x24A9AE4
	public List<int> get_CommandIdList() { }

	// RVA: 0x24A9AEC Offset: 0x24A5AEC VA: 0x24A9AEC
	public Dictionary<int, int> get_HitAreaNumList() { }

	// RVA: 0x24A9AF4 Offset: 0x24A5AF4 VA: 0x24A9AF4
	public Dictionary<int, List<BlackKnightHitAreaData>> get_HitAreaList() { }

	// RVA: 0x24A9AFC Offset: 0x24A5AFC VA: 0x24A9AFC
	public float get_Size() { }

	// RVA: 0x24A9B04 Offset: 0x24A5B04 VA: 0x24A9B04
	public void set_Size(float value) { }

	// RVA: 0x24A9B0C Offset: 0x24A5B0C VA: 0x24A9B0C
	public float get_Height() { }

	// RVA: 0x24A9B14 Offset: 0x24A5B14 VA: 0x24A9B14
	public void set_Height(float value) { }

	// RVA: 0x24A9B1C Offset: 0x24A5B1C VA: 0x24A9B1C
	public void .ctor() { }
}
