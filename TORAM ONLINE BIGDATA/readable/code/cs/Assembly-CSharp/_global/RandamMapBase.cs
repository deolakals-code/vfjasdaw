// Assembly: Assembly-CSharp.dll
// Namespace: 
[RequireComponent(typeof(RenderSetting))]
public abstract class RandamMapBase : MonoBehaviour // TypeDefIndex: 3993
{
	// Fields
	[SerializeField]
	[HideInInspector]
	private int seed; // 0x20
	[SerializeField]
	protected int mapX; // 0x24
	[SerializeField]
	protected int mapY; // 0x28
	[SerializeField]
	protected int minNum; // 0x2C
	[SerializeField]
	protected int maxNum; // 0x30
	protected Texture2D miniMap; // 0x38
	protected MersenneTwister mersenneTwister; // 0x40
	protected List<Vector3> mobPopPosition; // 0x48
	protected List<Vector3> trapPosition; // 0x50
	protected List<Vector3> itemBoxPosition; // 0x58
	protected Dictionary<int, int> eventScoreList; // 0x60
	protected byte startRoomId; // 0x68
	protected byte goalRoomId; // 0x69

	// Properties
	public int Seed { get; set; }
	public int MapX { get; set; }
	public int MapY { get; set; }
	public int MinNum { get; set; }
	public int MaxNum { get; set; }
	public Texture2D MiniMap { get; }
	public Vector3[] MobPopPosition { get; }
	public Vector3[] TrapPosition { get; }
	public Vector3[] ItemBoxPosition { get; }

	// Methods

	// RVA: 0x2434BC4 Offset: 0x2430BC4 VA: 0x2434BC4
	public int get_Seed() { }

	// RVA: 0x2434BCC Offset: 0x2430BCC VA: 0x2434BCC
	public void set_Seed(int value) { }

	// RVA: 0x2434BD4 Offset: 0x2430BD4 VA: 0x2434BD4
	public int get_MapX() { }

	// RVA: 0x2434BDC Offset: 0x2430BDC VA: 0x2434BDC
	public void set_MapX(int value) { }

	// RVA: 0x2434BE4 Offset: 0x2430BE4 VA: 0x2434BE4
	public int get_MapY() { }

	// RVA: 0x2434BEC Offset: 0x2430BEC VA: 0x2434BEC
	public void set_MapY(int value) { }

	// RVA: 0x2434BF4 Offset: 0x2430BF4 VA: 0x2434BF4
	public int get_MinNum() { }

	// RVA: 0x2434BFC Offset: 0x2430BFC VA: 0x2434BFC
	public void set_MinNum(int value) { }

	// RVA: 0x2434C10 Offset: 0x2430C10 VA: 0x2434C10
	public int get_MaxNum() { }

	// RVA: 0x2434C18 Offset: 0x2430C18 VA: 0x2434C18
	public void set_MaxNum(int value) { }

	// RVA: 0x2434C2C Offset: 0x2430C2C VA: 0x2434C2C
	public Texture2D get_MiniMap() { }

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract void RandamCreate(byte[] roomChipList);

	// RVA: 0x2434C34 Offset: 0x2430C34 VA: 0x2434C34
	public void RandamCreate(int seed, byte[] roomChipList) { }

	// RVA: 0x2434C4C Offset: 0x2430C4C VA: 0x2434C4C Slot: 5
	public virtual Vector3 GetMapChipPosition(byte mapChipId, float y) { }

	// RVA: 0x2434C90 Offset: 0x2430C90 VA: 0x2434C90
	public Vector3[] get_MobPopPosition() { }

	// RVA: 0x2434CE0 Offset: 0x2430CE0 VA: 0x2434CE0
	public Vector3[] get_TrapPosition() { }

	// RVA: 0x2434D30 Offset: 0x2430D30 VA: 0x2434D30
	public Vector3[] get_ItemBoxPosition() { }

	// RVA: 0x24340AC Offset: 0x24300AC VA: 0x24340AC
	protected void RandamMapEvent(int w, int h, Vector3 mapBlock) { }

	// RVA: 0x24310E0 Offset: 0x242D0E0 VA: 0x24310E0
	protected void .ctor() { }
}
