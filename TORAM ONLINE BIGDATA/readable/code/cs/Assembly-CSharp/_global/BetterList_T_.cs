// Assembly: Assembly-CSharp.dll
// Namespace: 
[DefaultMember("Item")]
public class BetterList<T> // TypeDefIndex: 65
{
	// Fields
	public T[] buffer; // 0x0
	public int size; // 0x0

	// Properties
	public T Item { get; set; }

	// Methods

	[IteratorStateMachine(typeof(BetterList.<GetEnumerator>d__2<T>))]
	// RVA: -1 Offset: -1
	public IEnumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B5170C Offset: 0x2B4D70C VA: 0x2B5170C
	|-BetterList<Color32>.GetEnumerator
	|
	|-RVA: 0x2B521FC Offset: 0x2B4E1FC VA: 0x2B521FC
	|-BetterList<object>.GetEnumerator
	|
	|-RVA: 0x2B52DE4 Offset: 0x2B4EDE4 VA: 0x2B52DE4
	|-BetterList<Vector2>.GetEnumerator
	|
	|-RVA: 0x2C64A14 Offset: 0x2C60A14 VA: 0x2C64A14
	|-BetterList<Vector3>.GetEnumerator
	|
	|-RVA: 0x2C6581C Offset: 0x2C6181C VA: 0x2C6581C
	|-BetterList<Vector4>.GetEnumerator
	|
	|-RVA: 0x2C665A4 Offset: 0x2C625A4 VA: 0x2C665A4
	|-BetterList<__Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1
	public T get_Item(int i) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B51784 Offset: 0x2B4D784 VA: 0x2B51784
	|-BetterList<Color32>.get_Item
	|
	|-RVA: 0x2B52274 Offset: 0x2B4E274 VA: 0x2B52274
	|-BetterList<object>.get_Item
	|
	|-RVA: 0x2B52E5C Offset: 0x2B4EE5C VA: 0x2B52E5C
	|-BetterList<Vector2>.get_Item
	|
	|-RVA: 0x2C64A8C Offset: 0x2C60A8C VA: 0x2C64A8C
	|-BetterList<Vector3>.get_Item
	|
	|-RVA: 0x2C65894 Offset: 0x2C61894 VA: 0x2C65894
	|-BetterList<Vector4>.get_Item
	|
	|-RVA: 0x2C66630 Offset: 0x2C62630 VA: 0x2C66630
	|-BetterList<__Il2CppFullySharedGenericType>.get_Item
	*/

	// RVA: -1 Offset: -1
	public void set_Item(int i, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B517B4 Offset: 0x2B4D7B4 VA: 0x2B517B4
	|-BetterList<Color32>.set_Item
	|
	|-RVA: 0x2B522A4 Offset: 0x2B4E2A4 VA: 0x2B522A4
	|-BetterList<object>.set_Item
	|
	|-RVA: 0x2B52E90 Offset: 0x2B4EE90 VA: 0x2B52E90
	|-BetterList<Vector2>.set_Item
	|
	|-RVA: 0x2C64AC8 Offset: 0x2C60AC8 VA: 0x2C64AC8
	|-BetterList<Vector3>.set_Item
	|
	|-RVA: 0x2C658CC Offset: 0x2C618CC VA: 0x2C658CC
	|-BetterList<Vector4>.set_Item
	|
	|-RVA: 0x2C666EC Offset: 0x2C626EC VA: 0x2C666EC
	|-BetterList<__Il2CppFullySharedGenericType>.set_Item
	*/

	// RVA: -1 Offset: -1
	private void AllocateMore() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B517E4 Offset: 0x2B4D7E4 VA: 0x2B517E4
	|-BetterList<Color32>.AllocateMore
	|
	|-RVA: 0x2B522D8 Offset: 0x2B4E2D8 VA: 0x2B522D8
	|-BetterList<object>.AllocateMore
	|
	|-RVA: 0x2B52EC4 Offset: 0x2B4EEC4 VA: 0x2B52EC4
	|-BetterList<Vector2>.AllocateMore
	|
	|-RVA: 0x2C64B04 Offset: 0x2C60B04 VA: 0x2C64B04
	|-BetterList<Vector3>.AllocateMore
	|
	|-RVA: 0x2C65904 Offset: 0x2C61904 VA: 0x2C65904
	|-BetterList<Vector4>.AllocateMore
	|
	|-RVA: 0x2C66810 Offset: 0x2C62810 VA: 0x2C66810
	|-BetterList<__Il2CppFullySharedGenericType>.AllocateMore
	*/

	// RVA: -1 Offset: -1
	private void Trim() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B51890 Offset: 0x2B4D890 VA: 0x2B51890
	|-BetterList<Color32>.Trim
	|
	|-RVA: 0x2B52384 Offset: 0x2B4E384 VA: 0x2B52384
	|-BetterList<object>.Trim
	|
	|-RVA: 0x2B52F70 Offset: 0x2B4EF70 VA: 0x2B52F70
	|-BetterList<Vector2>.Trim
	|
	|-RVA: 0x2C64BB0 Offset: 0x2C60BB0 VA: 0x2C64BB0
	|-BetterList<Vector3>.Trim
	|
	|-RVA: 0x2C659B0 Offset: 0x2C619B0 VA: 0x2C659B0
	|-BetterList<Vector4>.Trim
	|
	|-RVA: 0x2C668BC Offset: 0x2C628BC VA: 0x2C668BC
	|-BetterList<__Il2CppFullySharedGenericType>.Trim
	*/

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B51970 Offset: 0x2B4D970 VA: 0x2B51970
	|-BetterList<Color32>.Clear
	|
	|-RVA: 0x2B52484 Offset: 0x2B4E484 VA: 0x2B52484
	|-BetterList<object>.Clear
	|
	|-RVA: 0x2B53050 Offset: 0x2B4F050 VA: 0x2B53050
	|-BetterList<Vector2>.Clear
	|
	|-RVA: 0x2C64CA0 Offset: 0x2C60CA0 VA: 0x2C64CA0
	|-BetterList<Vector3>.Clear
	|
	|-RVA: 0x2C65A90 Offset: 0x2C61A90 VA: 0x2C65A90
	|-BetterList<Vector4>.Clear
	|
	|-RVA: 0x2C66A74 Offset: 0x2C62A74 VA: 0x2C66A74
	|-BetterList<__Il2CppFullySharedGenericType>.Clear
	*/

	// RVA: -1 Offset: -1
	public void Release() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B51978 Offset: 0x2B4D978 VA: 0x2B51978
	|-BetterList<Color32>.Release
	|
	|-RVA: 0x2B5248C Offset: 0x2B4E48C VA: 0x2B5248C
	|-BetterList<object>.Release
	|
	|-RVA: 0x2B53058 Offset: 0x2B4F058 VA: 0x2B53058
	|-BetterList<Vector2>.Release
	|
	|-RVA: 0x2C64CA8 Offset: 0x2C60CA8 VA: 0x2C64CA8
	|-BetterList<Vector3>.Release
	|
	|-RVA: 0x2C65A98 Offset: 0x2C61A98 VA: 0x2C65A98
	|-BetterList<Vector4>.Release
	|
	|-RVA: 0x2C66A7C Offset: 0x2C62A7C VA: 0x2C66A7C
	|-BetterList<__Il2CppFullySharedGenericType>.Release
	*/

	// RVA: -1 Offset: -1
	public void Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B51988 Offset: 0x2B4D988 VA: 0x2B51988
	|-BetterList<Color32>.Add
	|
	|-RVA: 0x2B5249C Offset: 0x2B4E49C VA: 0x2B5249C
	|-BetterList<object>.Add
	|
	|-RVA: 0x2B53068 Offset: 0x2B4F068 VA: 0x2B53068
	|-BetterList<Vector2>.Add
	|
	|-RVA: 0x2C64CB8 Offset: 0x2C60CB8 VA: 0x2C64CB8
	|-BetterList<Vector3>.Add
	|
	|-RVA: 0x2C65AA8 Offset: 0x2C61AA8 VA: 0x2C65AA8
	|-BetterList<Vector4>.Add
	|
	|-RVA: 0x2C66A8C Offset: 0x2C62A8C VA: 0x2C66A8C
	|-BetterList<__Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1
	public void Insert(int index, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B51A08 Offset: 0x2B4DA08 VA: 0x2B51A08
	|-BetterList<Color32>.Insert
	|
	|-RVA: 0x2B52520 Offset: 0x2B4E520 VA: 0x2B52520
	|-BetterList<object>.Insert
	|
	|-RVA: 0x2B530F0 Offset: 0x2B4F0F0 VA: 0x2B530F0
	|-BetterList<Vector2>.Insert
	|
	|-RVA: 0x2C64D54 Offset: 0x2C60D54 VA: 0x2C64D54
	|-BetterList<Vector3>.Insert
	|
	|-RVA: 0x2C65B44 Offset: 0x2C61B44 VA: 0x2C65B44
	|-BetterList<Vector4>.Insert
	|
	|-RVA: 0x2C66BF4 Offset: 0x2C62BF4 VA: 0x2C66BF4
	|-BetterList<__Il2CppFullySharedGenericType>.Insert
	*/

	// RVA: -1 Offset: -1
	public bool Contains(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B51B00 Offset: 0x2B4DB00 VA: 0x2B51B00
	|-BetterList<Color32>.Contains
	|
	|-RVA: 0x2B52644 Offset: 0x2B4E644 VA: 0x2B52644
	|-BetterList<object>.Contains
	|
	|-RVA: 0x2B531F0 Offset: 0x2B4F1F0 VA: 0x2B531F0
	|-BetterList<Vector2>.Contains
	|
	|-RVA: 0x2C64E90 Offset: 0x2C60E90 VA: 0x2C64E90
	|-BetterList<Vector3>.Contains
	|
	|-RVA: 0x2C65C64 Offset: 0x2C61C64 VA: 0x2C65C64
	|-BetterList<Vector4>.Contains
	|
	|-RVA: 0x2C66E94 Offset: 0x2C62E94 VA: 0x2C66E94
	|-BetterList<__Il2CppFullySharedGenericType>.Contains
	*/

	// RVA: -1 Offset: -1
	public bool Remove(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B51BE8 Offset: 0x2B4DBE8 VA: 0x2B51BE8
	|-BetterList<Color32>.Remove
	|
	|-RVA: 0x2B526CC Offset: 0x2B4E6CC VA: 0x2B526CC
	|-BetterList<object>.Remove
	|
	|-RVA: 0x2B5331C Offset: 0x2B4F31C VA: 0x2B5331C
	|-BetterList<Vector2>.Remove
	|
	|-RVA: 0x2C64FE4 Offset: 0x2C60FE4 VA: 0x2C64FE4
	|-BetterList<Vector3>.Remove
	|
	|-RVA: 0x2C65DCC Offset: 0x2C61DCC VA: 0x2C65DCC
	|-BetterList<Vector4>.Remove
	|
	|-RVA: 0x2C6704C Offset: 0x2C6304C VA: 0x2C6704C
	|-BetterList<__Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1
	public void RemoveAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B51D00 Offset: 0x2B4DD00 VA: 0x2B51D00
	|-BetterList<Color32>.RemoveAt
	|
	|-RVA: 0x2B52800 Offset: 0x2B4E800 VA: 0x2B52800
	|-BetterList<object>.RemoveAt
	|
	|-RVA: 0x2B53448 Offset: 0x2B4F448 VA: 0x2B53448
	|-BetterList<Vector2>.RemoveAt
	|
	|-RVA: 0x2C65130 Offset: 0x2C61130 VA: 0x2C65130
	|-BetterList<Vector3>.RemoveAt
	|
	|-RVA: 0x2C65F14 Offset: 0x2C61F14 VA: 0x2C65F14
	|-BetterList<Vector4>.RemoveAt
	|
	|-RVA: 0x2C67370 Offset: 0x2C63370 VA: 0x2C67370
	|-BetterList<__Il2CppFullySharedGenericType>.RemoveAt
	*/

	// RVA: -1 Offset: -1
	public T Pop() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B51D90 Offset: 0x2B4DD90 VA: 0x2B51D90
	|-BetterList<Color32>.Pop
	|
	|-RVA: 0x2B528E4 Offset: 0x2B4E8E4 VA: 0x2B528E4
	|-BetterList<object>.Pop
	|
	|-RVA: 0x2B534D8 Offset: 0x2B4F4D8 VA: 0x2B534D8
	|-BetterList<Vector2>.Pop
	|
	|-RVA: 0x2C651DC Offset: 0x2C611DC VA: 0x2C651DC
	|-BetterList<Vector3>.Pop
	|
	|-RVA: 0x2C65FA4 Offset: 0x2C61FA4 VA: 0x2C65FA4
	|-BetterList<Vector4>.Pop
	|
	|-RVA: 0x2C6758C Offset: 0x2C6358C VA: 0x2C6758C
	|-BetterList<__Il2CppFullySharedGenericType>.Pop
	*/

	// RVA: -1 Offset: -1
	public T[] ToArray() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B51DD8 Offset: 0x2B4DDD8 VA: 0x2B51DD8
	|-BetterList<Color32>.ToArray
	|
	|-RVA: 0x2B52938 Offset: 0x2B4E938 VA: 0x2B52938
	|-BetterList<object>.ToArray
	|
	|-RVA: 0x2B5352C Offset: 0x2B4F52C VA: 0x2B5352C
	|-BetterList<Vector2>.ToArray
	|
	|-RVA: 0x2C65244 Offset: 0x2C61244 VA: 0x2C65244
	|-BetterList<Vector3>.ToArray
	|
	|-RVA: 0x2C6600C Offset: 0x2C6200C VA: 0x2C6600C
	|-BetterList<Vector4>.ToArray
	|
	|-RVA: 0x2C67750 Offset: 0x2C63750 VA: 0x2C67750
	|-BetterList<__Il2CppFullySharedGenericType>.ToArray
	*/

	// RVA: -1 Offset: -1
	public void Sort(Comparison<T> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B51DFC Offset: 0x2B4DDFC VA: 0x2B51DFC
	|-BetterList<Color32>.Sort
	|
	|-RVA: 0x2B5295C Offset: 0x2B4E95C VA: 0x2B5295C
	|-BetterList<object>.Sort
	|
	|-RVA: 0x2B53550 Offset: 0x2B4F550 VA: 0x2B53550
	|-BetterList<Vector2>.Sort
	|
	|-RVA: 0x2C65268 Offset: 0x2C61268 VA: 0x2C65268
	|-BetterList<Vector3>.Sort
	|
	|-RVA: 0x2C66030 Offset: 0x2C62030 VA: 0x2C66030
	|-BetterList<Vector4>.Sort
	|
	|-RVA: 0x2C67778 Offset: 0x2C63778 VA: 0x2C67778
	|-BetterList<__Il2CppFullySharedGenericType>.Sort
	*/

	// RVA: -1 Offset: -1
	private static void QuickSort(T[] a, int first, int last, Comparison<T> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B51E24 Offset: 0x2B4DE24 VA: 0x2B51E24
	|-BetterList<Color32>.QuickSort
	|
	|-RVA: 0x2B52984 Offset: 0x2B4E984 VA: 0x2B52984
	|-BetterList<object>.QuickSort
	|
	|-RVA: 0x2B53578 Offset: 0x2B4F578 VA: 0x2B53578
	|-BetterList<Vector2>.QuickSort
	|
	|-RVA: 0x2C65290 Offset: 0x2C61290 VA: 0x2C65290
	|-BetterList<Vector3>.QuickSort
	|
	|-RVA: 0x2C66058 Offset: 0x2C62058 VA: 0x2C66058
	|-BetterList<Vector4>.QuickSort
	|
	|-RVA: 0x2C677A4 Offset: 0x2C637A4 VA: 0x2C677A4
	|-BetterList<__Il2CppFullySharedGenericType>.QuickSort
	*/

	// RVA: -1 Offset: -1
	private static T Median(T a, T b, T c, Comparison<T> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B520B8 Offset: 0x2B4E0B8 VA: 0x2B520B8
	|-BetterList<Color32>.Median
	|
	|-RVA: 0x2B52C2C Offset: 0x2B4EC2C VA: 0x2B52C2C
	|-BetterList<object>.Median
	|
	|-RVA: 0x2B53844 Offset: 0x2B4F844 VA: 0x2B53844
	|-BetterList<Vector2>.Median
	|
	|-RVA: 0x2C65630 Offset: 0x2C61630 VA: 0x2C65630
	|-BetterList<Vector3>.Median
	|
	|-RVA: 0x2C663A0 Offset: 0x2C623A0 VA: 0x2C663A0
	|-BetterList<Vector4>.Median
	|
	|-RVA: 0x2C67E5C Offset: 0x2C63E5C VA: 0x2C67E5C
	|-BetterList<__Il2CppFullySharedGenericType>.Median
	*/

	// RVA: -1 Offset: -1
	private static void Swap(ref T t1, ref T t2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B521E0 Offset: 0x2B4E1E0 VA: 0x2B521E0
	|-BetterList<Color32>.Swap
	|
	|-RVA: 0x2B52DA8 Offset: 0x2B4EDA8 VA: 0x2B52DA8
	|-BetterList<object>.Swap
	|
	|-RVA: 0x2B539D0 Offset: 0x2B4F9D0 VA: 0x2B539D0
	|-BetterList<Vector2>.Swap
	|
	|-RVA: 0x2C657D8 Offset: 0x2C617D8 VA: 0x2C657D8
	|-BetterList<Vector3>.Swap
	|
	|-RVA: 0x2C6657C Offset: 0x2C6257C VA: 0x2C6657C
	|-BetterList<Vector4>.Swap
	|
	|-RVA: 0x2C68610 Offset: 0x2C64610 VA: 0x2C68610
	|-BetterList<__Il2CppFullySharedGenericType>.Swap
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B521F4 Offset: 0x2B4E1F4 VA: 0x2B521F4
	|-BetterList<Color32>..ctor
	|
	|-RVA: 0x2B52DDC Offset: 0x2B4EDDC VA: 0x2B52DDC
	|-BetterList<object>..ctor
	|
	|-RVA: 0x2B539E4 Offset: 0x2B4F9E4 VA: 0x2B539E4
	|-BetterList<Vector2>..ctor
	|
	|-RVA: 0x2C65814 Offset: 0x2C61814 VA: 0x2C65814
	|-BetterList<Vector3>..ctor
	|
	|-RVA: 0x2C6659C Offset: 0x2C6259C VA: 0x2C6659C
	|-BetterList<Vector4>..ctor
	|
	|-RVA: 0x2C687A8 Offset: 0x2C647A8 VA: 0x2C687A8
	|-BetterList<__Il2CppFullySharedGenericType>..ctor
	*/
}
