// Assembly: Assembly-CSharp.dll
// Namespace: 
public class ActionReconnectionManager : Singleton<ActionReconnectionManager> // TypeDefIndex: 4828
{
	// Fields
	private Game engine; // 0x20
	private CountUpIdManager localIdManager; // 0x28
	private Dictionary<ActionCode, Dictionary<int, IActionReconnectionData>> reconnectionData; // 0x30

	// Methods

	// RVA: 0x25E3594 Offset: 0x25DF594 VA: 0x25E3594
	public void Initialize(Game engine) { }

	// RVA: 0x25E35C0 Offset: 0x25DF5C0 VA: 0x25E35C0
	public void Clear() { }

	// RVA: 0x25E3620 Offset: 0x25DF620 VA: 0x25E3620
	public void Cancel() { }

	// RVA: 0x25E396C Offset: 0x25DF96C VA: 0x25E396C
	public int Add(IActionReconnectionData data) { }

	// RVA: 0x25E3BE0 Offset: 0x25DFBE0 VA: 0x25E3BE0
	public void Remove(ActionCode type, int localId) { }

	// RVA: 0x25E3CF4 Offset: 0x25DFCF4 VA: 0x25E3CF4
	public void Invoke() { }

	// RVA: 0x25E4024 Offset: 0x25E0024 VA: 0x25E4024
	public void .ctor() { }
}
