// Assembly: Assembly-CSharp.dll
// Namespace: 
public abstract class PlayerObjectBase : ModelObjectBase // TypeDefIndex: 1546
{
	// Fields
	private byte[] cahceSignboardBinary; // 0x80
	private SignboardPropertyData cahceSignboard; // 0x88

	// Properties
	public abstract bool IsGhost { get; }
	public PlayerActionManagerBase ActionManager { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 38
	public abstract bool get_IsGhost();

	// RVA: 0x2089074 Offset: 0x2085074 VA: 0x2089074 Slot: 39
	public PlayerActionManagerBase get_ActionManager() { }

	// RVA: 0x20890EC Offset: 0x20850EC VA: 0x20890EC Slot: 40
	public SignboardPropertyData GetUpdateSignboard() { }

	// RVA: 0x2089190 Offset: 0x2085190 VA: 0x2089190 Slot: 41
	protected virtual byte[] GetSignboardBinary() { }

	// RVA: 0x2089198 Offset: 0x2085198 VA: 0x2089198
	protected void .ctor() { }
}
