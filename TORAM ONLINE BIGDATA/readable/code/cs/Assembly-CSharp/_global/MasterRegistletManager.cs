// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MasterRegistletManager : Singleton<MasterRegistletManager> // TypeDefIndex: 2292
{
	// Fields
	private Dictionary<short, GemCartMasterData> masterGemCartDataList; // 0x20

	// Methods

	// RVA: 0x217C74C Offset: 0x217874C VA: 0x217C74C
	public bool ReadRegistletData(byte[] data) { }

	// RVA: 0x217CBD4 Offset: 0x2178BD4 VA: 0x217CBD4
	public GemCartMasterData GetGemCartMaster(short id) { }

	// RVA: 0x217CC68 Offset: 0x2178C68 VA: 0x217CC68
	public void .ctor() { }
}
