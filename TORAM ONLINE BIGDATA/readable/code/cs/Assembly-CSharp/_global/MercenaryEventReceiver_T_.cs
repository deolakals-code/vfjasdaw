// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MercenaryEventReceiver<T> : IReceiver<PacketBase> // TypeDefIndex: 682
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
	|-RVA: 0x2BA7D94 Offset: 0x2BA3D94 VA: 0x2BA7D94
	|-MercenaryEventReceiver<object>.get_isReceived
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void set_isReceived(bool value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BA7D9C Offset: 0x2BA3D9C VA: 0x2BA7D9C
	|-MercenaryEventReceiver<object>.set_isReceived
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public void add_callback(Action<Game, T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BA7DA8 Offset: 0x2BA3DA8 VA: 0x2BA7DA8
	|-MercenaryEventReceiver<object>.add_callback
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public void remove_callback(Action<Game, T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BA7E54 Offset: 0x2BA3E54 VA: 0x2BA7E54
	|-MercenaryEventReceiver<object>.remove_callback
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BA7F00 Offset: 0x2BA3F00 VA: 0x2BA7F00
	|-MercenaryEventReceiver<object>.Clear
	*/

	// RVA: -1 Offset: -1
	public void Receive(Game game, T response) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BA7F10 Offset: 0x2BA3F10 VA: 0x2BA7F10
	|-MercenaryEventReceiver<object>.Receive
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Receive(Game game, PacketBase response) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BA7F40 Offset: 0x2BA3F40 VA: 0x2BA7F40
	|-MercenaryEventReceiver<object>.Receive
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool TypeCheck(PacketBase type) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BA8004 Offset: 0x2BA4004 VA: 0x2BA8004
	|-MercenaryEventReceiver<object>.TypeCheck
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BA8048 Offset: 0x2BA4048 VA: 0x2BA8048
	|-MercenaryEventReceiver<object>..ctor
	*/
}
