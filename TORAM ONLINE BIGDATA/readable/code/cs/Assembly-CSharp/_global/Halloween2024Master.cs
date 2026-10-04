// Assembly: Assembly-CSharp.dll
// Namespace: 
public class Halloween2024Master : MonoBehaviour // TypeDefIndex: 4364
{
	// Fields
	public const int PipeId = 1;
	public const int BowgunId = 2;
	public const int MagnumId = 3;
	public const int RedKeyId = 7;
	public const int RedKeyMapId = 17;
	public const int BlueKeyId = 8;
	public const int BlueKeyMapId = 18;
	public const byte scriptSearchId = 110;
	public const int GoalRedScriptId = 100;
	public const int GoalBlueScriptId = 101;
	[SerializeField]
	[HideInInspector]
	private int[] intParams; // 0x20
	[HideInInspector]
	[SerializeField]
	private float[] floatParams; // 0x28
	[SerializeField]
	private GameObject[] searchPoints; // 0x30
	[SerializeField]
	private GameObject[] popPoints; // 0x38
	[SerializeField]
	private GameObject[] deadPopPoints; // 0x40
	[SerializeField]
	private GameObject[] popPointBFs; // 0x48
	[SerializeField]
	private GameObject[] deadPopPointBFs; // 0x50

	// Properties
	public float HateAreaY { get; }

	// Methods

	// RVA: 0x24DC2AC Offset: 0x24D82AC VA: 0x24DC2AC
	public int GetParam(Halloween2024Master.IntParamType type, int defaultParam = 0) { }

	// RVA: 0x24DC36C Offset: 0x24D836C VA: 0x24DC36C
	public float GetParam(Halloween2024Master.FloatParamType type, float defaultParam = 0) { }

	// RVA: 0x24DC42C Offset: 0x24D842C VA: 0x24DC42C
	public float get_HateAreaY() { }

	// RVA: 0x24DC438 Offset: 0x24D8438 VA: 0x24DC438
	public Dictionary<byte, Halloween2024Master.SearchPointData> GetItemList(byte[] removePoints) { }

	// RVA: 0x24DC6C0 Offset: 0x24D86C0 VA: 0x24DC6C0
	private void CraeteSearchPointData(Dictionary<byte, Halloween2024Master.SearchPointData> searchData, Transform point, byte id, byte action, byte hierarchy) { }

	// RVA: 0x24DCAD8 Offset: 0x24D8AD8 VA: 0x24DCAD8
	public List<HalloweenMobActionManager> SetPopMob(HalloweenEventGameRoomData room) { }

	// RVA: 0x24DD050 Offset: 0x24D9050 VA: 0x24DD050
	private HalloweenMobActionManager CreateMob(HalloweenEventGameRoomData room, Transform trans, byte index, byte floor, bool isDead) { }

	// RVA: 0x24DD214 Offset: 0x24D9214 VA: 0x24DD214
	public float GetPlayerHateDist(int itemNum) { }

	// RVA: 0x24DD29C Offset: 0x24D929C VA: 0x24DD29C
	public void .ctor() { }
}
