// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UICardGameResultPanel // TypeDefIndex: 5722
{
	// Fields
	private Dictionary<int, UICardGameResultElement> elements; // 0x10
	private GameObject scorePanel; // 0x18
	private GameObject memberDataObj; // 0x20
	private PlayerDataManager playerDataManager; // 0x28

	// Methods

	// RVA: 0x17CFB8C Offset: 0x17CBB8C VA: 0x17CFB8C
	public void .ctor(GameObject panel, GameObject memberObject) { }

	// RVA: 0x17CFC5C Offset: 0x17CBC5C VA: 0x17CFC5C
	public void SetRewardDataLabel(Dictionary<int, short> assets) { }

	// RVA: 0x17CFFF4 Offset: 0x17CBFF4 VA: 0x17CFFF4
	public void ElementClear() { }

	[IteratorStateMachine(typeof(UICardGameResultPanel.<OpenSpinaLabel>d__7))]
	// RVA: 0x17D0178 Offset: 0x17CC178 VA: 0x17D0178
	public IEnumerator OpenSpinaLabel() { }

	[IteratorStateMachine(typeof(UICardGameResultPanel.<AddHandSpina>d__8))]
	// RVA: 0x17D020C Offset: 0x17CC20C VA: 0x17D020C
	public IEnumerator AddHandSpina(Dictionary<int, short> totalSpina) { }
}
