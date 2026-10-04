// Assembly: Assembly-CSharp.dll
// Namespace: 
public interface IReceiver<T> // TypeDefIndex: 4844
{
	// Properties
	public abstract bool isReceived { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_isReceived();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IReceiver<object>.get_isReceived
	*/

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void Receive(Game game, T response);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IReceiver<object>.Receive
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool TypeCheck(T type);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IReceiver<object>.TypeCheck
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void Clear();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IReceiver<object>.Clear
	*/
}
