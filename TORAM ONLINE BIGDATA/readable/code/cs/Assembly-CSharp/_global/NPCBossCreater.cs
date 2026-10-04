// Assembly: Assembly-CSharp.dll
// Namespace: 
public class NPCBossCreater : MonoBehaviour // TypeDefIndex: 1053
{
	// Fields
	[SerializeField]
	public ModelType Type; // 0x20
	[SerializeField]
	public int Id; // 0x24
	[SerializeField]
	public string NpcAssetName; // 0x28
	[HideInInspector]
	[SerializeField]
	private int bitFlag; // 0x30
	[SerializeField]
	private int natural; // 0x34
	[SerializeField]
	private int run; // 0x38
	[SerializeField]
	private int damage; // 0x3C
	[SerializeField]
	private int down; // 0x40
	[SerializeField]
	private int dead; // 0x44
	[SerializeField]
	private int[] attack; // 0x48

	// Methods

	// RVA: 0x1F3F2A0 Offset: 0x1F3B2A0 VA: 0x1F3F2A0
	public Dictionary<int, int> GetConvertMotion() { }

	// RVA: 0x1F3F408 Offset: 0x1F3B408 VA: 0x1F3F408
	public void .ctor() { }
}
