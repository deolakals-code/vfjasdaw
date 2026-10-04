// Assembly: Assembly-CSharp.dll
// Namespace: 
public class OperationReceiver<T> : IReceiver<OperationResponseBase> // TypeDefIndex: 4845
{
	// Fields
	private ReconnectionManager reconnectionManager; // 0x0
	private T checkInstance; // 0x0
	[CompilerGenerated]
	private bool <isReceived>k__BackingField; // 0x0
	[CompilerGenerated]
	private Action<Game, T> callback; // 0x0
	[CompilerGenerated]
	private bool <CallbackClear>k__BackingField; // 0x0

	// Properties
	public bool isReceived { get; set; }
	public bool CallbackClear { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BDDFA0 Offset: 0x2BD9FA0 VA: 0x2BDDFA0
	|-OperationReceiver<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(ReconnectionManager reconnection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BDDFC0 Offset: 0x2BD9FC0 VA: 0x2BDDFC0
	|-OperationReceiver<object>..ctor
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 4
	public bool get_isReceived() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BDE014 Offset: 0x2BDA014 VA: 0x2BDE014
	|-OperationReceiver<object>.get_isReceived
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void set_isReceived(bool value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BDE01C Offset: 0x2BDA01C VA: 0x2BDE01C
	|-OperationReceiver<object>.set_isReceived
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public void add_callback(Action<Game, T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BDE028 Offset: 0x2BDA028 VA: 0x2BDE028
	|-OperationReceiver<object>.add_callback
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public void remove_callback(Action<Game, T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BDE0D4 Offset: 0x2BDA0D4 VA: 0x2BDE0D4
	|-OperationReceiver<object>.remove_callback
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public bool get_CallbackClear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BDE180 Offset: 0x2BDA180 VA: 0x2BDE180
	|-OperationReceiver<object>.get_CallbackClear
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public void set_CallbackClear(bool value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BDE188 Offset: 0x2BDA188 VA: 0x2BDE188
	|-OperationReceiver<object>.set_CallbackClear
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BDE194 Offset: 0x2BDA194 VA: 0x2BDE194
	|-OperationReceiver<object>.Clear
	*/

	// RVA: -1 Offset: -1
	public void Receive(Game game, T response) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BDE1A4 Offset: 0x2BDA1A4 VA: 0x2BDE1A4
	|-OperationReceiver<object>.Receive
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Receive(Game game, OperationResponseBase response) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BDE2CC Offset: 0x2BDA2CC VA: 0x2BDE2CC
	|-OperationReceiver<object>.Receive
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool TypeCheck(OperationResponseBase type) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BDE380 Offset: 0x2BDA380 VA: 0x2BDE380
	|-OperationReceiver<object>.TypeCheck
	*/
}
