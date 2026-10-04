// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MercenaryActionEventReceiver<T> : IReceiver<ArchetypeActionEvent> // TypeDefIndex: 681
{
	// Fields
	[CompilerGenerated]
	private bool <isReceived>k__BackingField; // 0x0
	[CompilerGenerated]
	private Action<Game, T> callback; // 0x0

	// Properties
	public bool isReceived { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 4
	public bool get_isReceived() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BA7AD8 Offset: 0x2BA3AD8 VA: 0x2BA7AD8
	|-MercenaryActionEventReceiver<object>.get_isReceived
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void set_isReceived(bool value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BA7AE0 Offset: 0x2BA3AE0 VA: 0x2BA7AE0
	|-MercenaryActionEventReceiver<object>.set_isReceived
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public void add_callback(Action<Game, T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BA7AEC Offset: 0x2BA3AEC VA: 0x2BA7AEC
	|-MercenaryActionEventReceiver<object>.add_callback
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public void remove_callback(Action<Game, T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BA7B98 Offset: 0x2BA3B98 VA: 0x2BA7B98
	|-MercenaryActionEventReceiver<object>.remove_callback
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BA7C44 Offset: 0x2BA3C44 VA: 0x2BA7C44
	|-MercenaryActionEventReceiver<object>.Clear
	*/

	// RVA: -1 Offset: -1
	public void Receive(Game game, T response) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BA7C54 Offset: 0x2BA3C54 VA: 0x2BA7C54
	|-MercenaryActionEventReceiver<object>.Receive
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Receive(Game game, ArchetypeActionEvent response) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BA7C84 Offset: 0x2BA3C84 VA: 0x2BA7C84
	|-MercenaryActionEventReceiver<object>.Receive
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool TypeCheck(ArchetypeActionEvent type) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BA7D48 Offset: 0x2BA3D48 VA: 0x2BA7D48
	|-MercenaryActionEventReceiver<object>.TypeCheck
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BA7D8C Offset: 0x2BA3D8C VA: 0x2BA7D8C
	|-MercenaryActionEventReceiver<object>..ctor
	*/
}
