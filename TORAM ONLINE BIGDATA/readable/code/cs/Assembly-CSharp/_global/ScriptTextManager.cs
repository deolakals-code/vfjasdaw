// Assembly: Assembly-CSharp.dll
// Namespace: 
public class ScriptTextManager : TextManagerBase // TypeDefIndex: 5270
{
	// Fields
	private Dictionary<int, ScriptTextManagerData> TextData; // 0x18

	// Methods

	// RVA: 0x261D7BC Offset: 0x26197BC VA: 0x261D7BC Slot: 6
	public override void Initialize(byte[] binary) { }

	// RVA: 0x261D808 Offset: 0x2619808 VA: 0x261D808
	public void Initialize(int fieldId, byte[] binary) { }

	// RVA: 0x261D884 Offset: 0x2619884 VA: 0x261D884
	public void AddLoad(int fieldId, byte[] binary) { }

	// RVA: -1 Offset: -1 Slot: 4
	public override T Get<T>(int fieldId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26EE520 Offset: 0x26EA520 VA: 0x26EE520
	|-ScriptTextManager.Get<object>
	*/

	// RVA: 0x261E054 Offset: 0x261A054 VA: 0x261E054 Slot: 7
	public override void Clear() { }

	// RVA: 0x261E0AC Offset: 0x261A0AC VA: 0x261E0AC
	public void Clear(int fieldId) { }

	// RVA: 0x261E104 Offset: 0x261A104 VA: 0x261E104
	public void .ctor() { }
}
