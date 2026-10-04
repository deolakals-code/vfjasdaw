// Assembly: Assembly-CSharp.dll
// Namespace: 
public class EnemyTextManager : TextManagerBase // TypeDefIndex: 5226
{
	// Fields
	private Dictionary<int, TextManagerDataSingle> TextData; // 0x18

	// Methods

	// RVA: 0x260FF08 Offset: 0x260BF08 VA: 0x260FF08 Slot: 6
	public override void Initialize(byte[] binary) { }

	// RVA: -1 Offset: -1 Slot: 4
	public override T Get<T>(int id) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27EAB40 Offset: 0x27E6B40 VA: 0x27EAB40
	|-EnemyTextManager.Get<object>
	*/

	// RVA: 0x26103B4 Offset: 0x260C3B4 VA: 0x26103B4 Slot: 7
	public override void Clear() { }

	// RVA: 0x261040C Offset: 0x260C40C VA: 0x261040C
	public string GetName(int uid) { }

	// RVA: 0x26104AC Offset: 0x260C4AC VA: 0x26104AC
	public Dictionary<int, string> GetDatas() { }

	// RVA: 0x2610684 Offset: 0x260C684 VA: 0x2610684
	public void .ctor() { }
}
