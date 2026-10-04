// Assembly: Assembly-CSharp.dll
// Namespace: 
public class FieldTextManager : TextManagerBase // TypeDefIndex: 5227
{
	// Fields
	private Dictionary<int, TextManagerDataSingle> TextData; // 0x18

	// Methods

	// RVA: 0x261070C Offset: 0x260C70C VA: 0x261070C Slot: 6
	public override void Initialize(byte[] binary) { }

	// RVA: -1 Offset: -1 Slot: 4
	public override T Get<T>(int id) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26C2328 Offset: 0x26BE328 VA: 0x26C2328
	|-FieldTextManager.Get<object>
	*/

	// RVA: 0x2610BB8 Offset: 0x260CBB8 VA: 0x2610BB8 Slot: 7
	public override void Clear() { }

	// RVA: 0x2610C10 Offset: 0x260CC10 VA: 0x2610C10
	public string GetName(int uid) { }

	// RVA: 0x2610CB0 Offset: 0x260CCB0 VA: 0x2610CB0
	public string GetWorld(int uid) { }

	// RVA: 0x2610D50 Offset: 0x260CD50 VA: 0x2610D50
	public List<int> GetAllFieldId() { }

	// RVA: 0x2610F84 Offset: 0x260CF84 VA: 0x2610F84
	public void .ctor() { }
}
