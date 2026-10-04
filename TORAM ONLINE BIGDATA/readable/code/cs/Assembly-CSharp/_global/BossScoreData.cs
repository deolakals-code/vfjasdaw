// Assembly: Assembly-CSharp.dll
// Namespace: 
public class BossScoreData // TypeDefIndex: 2320
{
	// Fields
	private Dictionary<int, BossScoreData.Score> scores; // 0x10

	// Methods

	// RVA: 0x21849A0 Offset: 0x21809A0 VA: 0x21849A0
	public void .ctor() { }

	// RVA: 0x2184A28 Offset: 0x2180A28 VA: 0x2184A28
	public void Clear() { }

	// RVA: 0x2184A78 Offset: 0x2180A78 VA: 0x2184A78
	public void Update() { }

	// RVA: 0x2184D10 Offset: 0x2180D10 VA: 0x2184D10
	public bool TryGetScore(int archetypeId, out BossScoreData.Score score) { }

	// RVA: 0x2184D78 Offset: 0x2180D78 VA: 0x2184D78
	public void UpdateScore(int archetypeId, byte type, long val, byte flag = 0, int uid = 0) { }
}
