// Assembly: UnityEngine.CoreModule.dll
// Namespace: UnityEngine.Pool
public class ObjectPool<T> : IDisposable, IPool // TypeDefIndex: 16591
{
	// Fields
	internal readonly List<T> m_List; // 0x0
	private readonly Func<T> m_CreateFunc; // 0x0
	private readonly Action<T> m_ActionOnGet; // 0x0
	private readonly Action<T> m_ActionOnRelease; // 0x0
	private readonly Action<T> m_ActionOnDestroy; // 0x0
	private readonly int m_MaxSize; // 0x0
	internal bool m_CollectionCheck; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private int <CountAll>k__BackingField; // 0x0

	// Properties
	public int CountAll { get; set; }
	public int CountInactive { get; }

	// Methods

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public int get_CountAll() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BDDA78 Offset: 0x2BD9A78 VA: 0x2BDDA78
	|-ObjectPool<object>.get_CountAll
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void set_CountAll(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BDDA80 Offset: 0x2BD9A80 VA: 0x2BDDA80
	|-ObjectPool<object>.set_CountAll
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public int get_CountInactive() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BDDA88 Offset: 0x2BD9A88 VA: 0x2BDDA88
	|-ObjectPool<object>.get_CountInactive
	*/

	// RVA: -1 Offset: -1
	public void .ctor(Func<T> createFunc, Action<T> actionOnGet, Action<T> actionOnRelease, Action<T> actionOnDestroy, bool collectionCheck = True, int defaultCapacity = 10, int maxSize = 10000) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BDDAA4 Offset: 0x2BD9AA4 VA: 0x2BDDAA4
	|-ObjectPool<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public T Get() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BDDC6C Offset: 0x2BD9C6C VA: 0x2BDDC6C
	|-ObjectPool<object>.Get
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public void Release(T element) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BDDD2C Offset: 0x2BD9D2C VA: 0x2BDDD2C
	|-ObjectPool<object>.Release
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BDDE20 Offset: 0x2BD9E20 VA: 0x2BDDE20
	|-ObjectPool<object>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BDDF90 Offset: 0x2BD9F90 VA: 0x2BDDF90
	|-ObjectPool<object>.Dispose
	*/
}
