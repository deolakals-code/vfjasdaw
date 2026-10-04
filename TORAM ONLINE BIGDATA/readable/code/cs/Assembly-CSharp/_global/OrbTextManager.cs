// Assembly: Assembly-CSharp.dll
// Namespace: 
public class OrbTextManager : TextManagerBase // TypeDefIndex: 5262
{
	// Fields
	private Dictionary<OrbTextManager.TextTypes, Dictionary<int, TextManagerDataSingle>> textData; // 0x18

	// Methods

	// RVA: 0x261B054 Offset: 0x2617054 VA: 0x261B054 Slot: 6
	public override void Initialize(byte[] binary) { }

	// RVA: -1 Offset: -1
	public T Get<T>(OrbTextManager.TextTypes type, int key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26DD4C4 Offset: 0x26D94C4 VA: 0x26DD4C4
	|-OrbTextManager.Get<object>
	*/

	// RVA: 0x261B718 Offset: 0x2617718 VA: 0x261B718
	public string Get(OrbTextManager.TextTypes type, int key) { }

	// RVA: 0x261B840 Offset: 0x2617840 VA: 0x261B840 Slot: 7
	public override void Clear() { }

	// RVA: 0x261B9F0 Offset: 0x26179F0 VA: 0x261B9F0
	public void .ctor() { }
}
