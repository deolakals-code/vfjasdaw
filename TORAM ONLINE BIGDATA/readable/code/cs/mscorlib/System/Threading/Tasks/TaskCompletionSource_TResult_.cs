// Assembly: mscorlib.dll
// Namespace: System.Threading.Tasks
public class TaskCompletionSource<TResult> // TypeDefIndex: 9945
{
	// Fields
	private readonly Task<TResult> _task; // 0x0

	// Properties
	public Task<TResult> Task { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA5BD8 Offset: 0x2CA1BD8 VA: 0x2CA5BD8
	|-TaskCompletionSource<bool>..ctor
	|
	|-RVA: 0x2CA5F30 Offset: 0x2CA1F30 VA: 0x2CA5F30
	|-TaskCompletionSource<int>..ctor
	|
	|-RVA: 0x2CA6280 Offset: 0x2CA2280 VA: 0x2CA6280
	|-TaskCompletionSource<object>..ctor
	|
	|-RVA: 0x2CA65D0 Offset: 0x2CA25D0 VA: 0x2CA65D0
	|-TaskCompletionSource<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(TaskCreationOptions creationOptions) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA5C2C Offset: 0x2CA1C2C VA: 0x2CA5C2C
	|-TaskCompletionSource<bool>..ctor
	|
	|-RVA: 0x2CA5F84 Offset: 0x2CA1F84 VA: 0x2CA5F84
	|-TaskCompletionSource<int>..ctor
	|
	|-RVA: 0x2CA62D4 Offset: 0x2CA22D4 VA: 0x2CA62D4
	|-TaskCompletionSource<object>..ctor
	|
	|-RVA: 0x2CA6634 Offset: 0x2CA2634 VA: 0x2CA6634
	|-TaskCompletionSource<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(object state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA5C48 Offset: 0x2CA1C48 VA: 0x2CA5C48
	|-TaskCompletionSource<bool>..ctor
	|
	|-RVA: 0x2CA5FA0 Offset: 0x2CA1FA0 VA: 0x2CA5FA0
	|-TaskCompletionSource<int>..ctor
	|
	|-RVA: 0x2CA62F0 Offset: 0x2CA22F0 VA: 0x2CA62F0
	|-TaskCompletionSource<object>..ctor
	|
	|-RVA: 0x2CA6654 Offset: 0x2CA2654 VA: 0x2CA6654
	|-TaskCompletionSource<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(object state, TaskCreationOptions creationOptions) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA5C5C Offset: 0x2CA1C5C VA: 0x2CA5C5C
	|-TaskCompletionSource<bool>..ctor
	|
	|-RVA: 0x2CA5FB4 Offset: 0x2CA1FB4 VA: 0x2CA5FB4
	|-TaskCompletionSource<int>..ctor
	|
	|-RVA: 0x2CA6304 Offset: 0x2CA2304 VA: 0x2CA6304
	|-TaskCompletionSource<object>..ctor
	|
	|-RVA: 0x2CA666C Offset: 0x2CA266C VA: 0x2CA666C
	|-TaskCompletionSource<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public Task<TResult> get_Task() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA5CC8 Offset: 0x2CA1CC8 VA: 0x2CA5CC8
	|-TaskCompletionSource<bool>.get_Task
	|
	|-RVA: 0x2CA6020 Offset: 0x2CA2020 VA: 0x2CA6020
	|-TaskCompletionSource<int>.get_Task
	|
	|-RVA: 0x2CA6370 Offset: 0x2CA2370 VA: 0x2CA6370
	|-TaskCompletionSource<object>.get_Task
	|
	|-RVA: 0x2CA66E8 Offset: 0x2CA26E8 VA: 0x2CA66E8
	|-TaskCompletionSource<__Il2CppFullySharedGenericType>.get_Task
	*/

	// RVA: -1 Offset: -1
	private void SpinUntilCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA5CD0 Offset: 0x2CA1CD0 VA: 0x2CA5CD0
	|-TaskCompletionSource<bool>.SpinUntilCompleted
	|
	|-RVA: 0x2CA6028 Offset: 0x2CA2028 VA: 0x2CA6028
	|-TaskCompletionSource<int>.SpinUntilCompleted
	|
	|-RVA: 0x2CA6378 Offset: 0x2CA2378 VA: 0x2CA6378
	|-TaskCompletionSource<object>.SpinUntilCompleted
	|
	|-RVA: 0x2CA66F0 Offset: 0x2CA26F0 VA: 0x2CA66F0
	|-TaskCompletionSource<__Il2CppFullySharedGenericType>.SpinUntilCompleted
	*/

	// RVA: -1 Offset: -1
	public bool TrySetException(Exception exception) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA5D50 Offset: 0x2CA1D50 VA: 0x2CA5D50
	|-TaskCompletionSource<bool>.TrySetException
	|
	|-RVA: 0x2CA60A8 Offset: 0x2CA20A8 VA: 0x2CA60A8
	|-TaskCompletionSource<int>.TrySetException
	|
	|-RVA: 0x2CA63F8 Offset: 0x2CA23F8 VA: 0x2CA63F8
	|-TaskCompletionSource<object>.TrySetException
	|
	|-RVA: 0x2CA6770 Offset: 0x2CA2770 VA: 0x2CA6770
	|-TaskCompletionSource<__Il2CppFullySharedGenericType>.TrySetException
	*/

	// RVA: -1 Offset: -1
	public void SetException(Exception exception) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA5DBC Offset: 0x2CA1DBC VA: 0x2CA5DBC
	|-TaskCompletionSource<bool>.SetException
	|
	|-RVA: 0x2CA6114 Offset: 0x2CA2114 VA: 0x2CA6114
	|-TaskCompletionSource<int>.SetException
	|
	|-RVA: 0x2CA6464 Offset: 0x2CA2464 VA: 0x2CA6464
	|-TaskCompletionSource<object>.SetException
	|
	|-RVA: 0x2CA67F0 Offset: 0x2CA27F0 VA: 0x2CA67F0
	|-TaskCompletionSource<__Il2CppFullySharedGenericType>.SetException
	*/

	// RVA: -1 Offset: -1
	public bool TrySetResult(TResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA5E18 Offset: 0x2CA1E18 VA: 0x2CA5E18
	|-TaskCompletionSource<bool>.TrySetResult
	|
	|-RVA: 0x2CA6170 Offset: 0x2CA2170 VA: 0x2CA6170
	|-TaskCompletionSource<int>.TrySetResult
	|
	|-RVA: 0x2CA64C0 Offset: 0x2CA24C0 VA: 0x2CA64C0
	|-TaskCompletionSource<object>.TrySetResult
	|
	|-RVA: 0x2CA6850 Offset: 0x2CA2850 VA: 0x2CA6850
	|-TaskCompletionSource<__Il2CppFullySharedGenericType>.TrySetResult
	*/

	// RVA: -1 Offset: -1
	public void SetResult(TResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA5E58 Offset: 0x2CA1E58 VA: 0x2CA5E58
	|-TaskCompletionSource<bool>.SetResult
	|
	|-RVA: 0x2CA61AC Offset: 0x2CA21AC VA: 0x2CA61AC
	|-TaskCompletionSource<int>.SetResult
	|
	|-RVA: 0x2CA64FC Offset: 0x2CA24FC VA: 0x2CA64FC
	|-TaskCompletionSource<object>.SetResult
	|
	|-RVA: 0x2CA694C Offset: 0x2CA294C VA: 0x2CA694C
	|-TaskCompletionSource<__Il2CppFullySharedGenericType>.SetResult
	*/

	// RVA: -1 Offset: -1
	public bool TrySetCanceled() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA5E8C Offset: 0x2CA1E8C VA: 0x2CA5E8C
	|-TaskCompletionSource<bool>.TrySetCanceled
	|
	|-RVA: 0x2CA61DC Offset: 0x2CA21DC VA: 0x2CA61DC
	|-TaskCompletionSource<int>.TrySetCanceled
	|
	|-RVA: 0x2CA652C Offset: 0x2CA252C VA: 0x2CA652C
	|-TaskCompletionSource<object>.TrySetCanceled
	|
	|-RVA: 0x2CA6A20 Offset: 0x2CA2A20 VA: 0x2CA6A20
	|-TaskCompletionSource<__Il2CppFullySharedGenericType>.TrySetCanceled
	*/

	// RVA: -1 Offset: -1
	public bool TrySetCanceled(CancellationToken cancellationToken) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA5EA0 Offset: 0x2CA1EA0 VA: 0x2CA5EA0
	|-TaskCompletionSource<bool>.TrySetCanceled
	|
	|-RVA: 0x2CA61F0 Offset: 0x2CA21F0 VA: 0x2CA61F0
	|-TaskCompletionSource<int>.TrySetCanceled
	|
	|-RVA: 0x2CA6540 Offset: 0x2CA2540 VA: 0x2CA6540
	|-TaskCompletionSource<object>.TrySetCanceled
	|
	|-RVA: 0x2CA6A38 Offset: 0x2CA2A38 VA: 0x2CA6A38
	|-TaskCompletionSource<__Il2CppFullySharedGenericType>.TrySetCanceled
	*/

	// RVA: -1 Offset: -1
	public void SetCanceled() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA5EF0 Offset: 0x2CA1EF0 VA: 0x2CA5EF0
	|-TaskCompletionSource<bool>.SetCanceled
	|
	|-RVA: 0x2CA6240 Offset: 0x2CA2240 VA: 0x2CA6240
	|-TaskCompletionSource<int>.SetCanceled
	|
	|-RVA: 0x2CA6590 Offset: 0x2CA2590 VA: 0x2CA6590
	|-TaskCompletionSource<object>.SetCanceled
	|
	|-RVA: 0x2CA6AA4 Offset: 0x2CA2AA4 VA: 0x2CA6AA4
	|-TaskCompletionSource<__Il2CppFullySharedGenericType>.SetCanceled
	*/
}
