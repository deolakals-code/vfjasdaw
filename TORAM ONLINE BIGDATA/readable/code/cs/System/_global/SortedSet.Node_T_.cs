// Assembly: System.dll
// Namespace: 
[Serializable]
internal sealed class SortedSet.Node<T> // TypeDefIndex: 14329
{
	// Fields
	[CompilerGenerated]
	private T <Item>k__BackingField; // 0x0
	[CompilerGenerated]
	private SortedSet.Node<T> <Left>k__BackingField; // 0x0
	[CompilerGenerated]
	private SortedSet.Node<T> <Right>k__BackingField; // 0x0
	[CompilerGenerated]
	private NodeColor <Color>k__BackingField; // 0x0

	// Properties
	public T Item { get; set; }
	public SortedSet.Node<T> Left { get; set; }
	public SortedSet.Node<T> Right { get; set; }
	public NodeColor Color { get; set; }
	public bool IsBlack { get; }
	public bool IsRed { get; }
	public bool Is2Node { get; }
	public bool Is4Node { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(T item, NodeColor color) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB210C Offset: 0x2BAE10C VA: 0x2BB210C
	|-SortedSet.Node<KeyValuePair<byte, object>>..ctor
	|
	|-RVA: 0x2BB26B0 Offset: 0x2BAE6B0 VA: 0x2BB26B0
	|-SortedSet.Node<KeyValuePair<double, int>>..ctor
	|
	|-RVA: 0x2BB2C3C Offset: 0x2BAEC3C VA: 0x2BB2C3C
	|-SortedSet.Node<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public static bool IsNonNullRed(SortedSet.Node<T> node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB2158 Offset: 0x2BAE158 VA: 0x2BB2158
	|-SortedSet.Node<KeyValuePair<byte, object>>.IsNonNullRed
	|
	|-RVA: 0x2BB26EC Offset: 0x2BAE6EC VA: 0x2BB26EC
	|-SortedSet.Node<KeyValuePair<double, int>>.IsNonNullRed
	|
	|-RVA: 0x2BB2D48 Offset: 0x2BAED48 VA: 0x2BB2D48
	|-SortedSet.Node<__Il2CppFullySharedGenericType>.IsNonNullRed
	*/

	// RVA: -1 Offset: -1
	public static bool IsNullOrBlack(SortedSet.Node<T> node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB2188 Offset: 0x2BAE188 VA: 0x2BB2188
	|-SortedSet.Node<KeyValuePair<byte, object>>.IsNullOrBlack
	|
	|-RVA: 0x2BB271C Offset: 0x2BAE71C VA: 0x2BB271C
	|-SortedSet.Node<KeyValuePair<double, int>>.IsNullOrBlack
	|
	|-RVA: 0x2BB2DC8 Offset: 0x2BAEDC8 VA: 0x2BB2DC8
	|-SortedSet.Node<__Il2CppFullySharedGenericType>.IsNullOrBlack
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public T get_Item() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB21C0 Offset: 0x2BAE1C0 VA: 0x2BB21C0
	|-SortedSet.Node<KeyValuePair<byte, object>>.get_Item
	|
	|-RVA: 0x2BB2754 Offset: 0x2BAE754 VA: 0x2BB2754
	|-SortedSet.Node<KeyValuePair<double, int>>.get_Item
	|
	|-RVA: 0x2BB2E4C Offset: 0x2BAEE4C VA: 0x2BB2E4C
	|-SortedSet.Node<__Il2CppFullySharedGenericType>.get_Item
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public void set_Item(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB21CC Offset: 0x2BAE1CC VA: 0x2BB21CC
	|-SortedSet.Node<KeyValuePair<byte, object>>.set_Item
	|
	|-RVA: 0x2BB2760 Offset: 0x2BAE760 VA: 0x2BB2760
	|-SortedSet.Node<KeyValuePair<double, int>>.set_Item
	|
	|-RVA: 0x2BB2EE8 Offset: 0x2BAEEE8 VA: 0x2BB2EE8
	|-SortedSet.Node<__Il2CppFullySharedGenericType>.set_Item
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public SortedSet.Node<T> get_Left() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB21DC Offset: 0x2BAE1DC VA: 0x2BB21DC
	|-SortedSet.Node<KeyValuePair<byte, object>>.get_Left
	|
	|-RVA: 0x2BB2768 Offset: 0x2BAE768 VA: 0x2BB2768
	|-SortedSet.Node<KeyValuePair<double, int>>.get_Left
	|
	|-RVA: 0x2BB2F9C Offset: 0x2BAEF9C VA: 0x2BB2F9C
	|-SortedSet.Node<__Il2CppFullySharedGenericType>.get_Left
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public void set_Left(SortedSet.Node<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB21E4 Offset: 0x2BAE1E4 VA: 0x2BB21E4
	|-SortedSet.Node<KeyValuePair<byte, object>>.set_Left
	|
	|-RVA: 0x2BB2770 Offset: 0x2BAE770 VA: 0x2BB2770
	|-SortedSet.Node<KeyValuePair<double, int>>.set_Left
	|
	|-RVA: 0x2BB2FC4 Offset: 0x2BAEFC4 VA: 0x2BB2FC4
	|-SortedSet.Node<__Il2CppFullySharedGenericType>.set_Left
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public SortedSet.Node<T> get_Right() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB21EC Offset: 0x2BAE1EC VA: 0x2BB21EC
	|-SortedSet.Node<KeyValuePair<byte, object>>.get_Right
	|
	|-RVA: 0x2BB2778 Offset: 0x2BAE778 VA: 0x2BB2778
	|-SortedSet.Node<KeyValuePair<double, int>>.get_Right
	|
	|-RVA: 0x2BB2FE4 Offset: 0x2BAEFE4 VA: 0x2BB2FE4
	|-SortedSet.Node<__Il2CppFullySharedGenericType>.get_Right
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public void set_Right(SortedSet.Node<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB21F4 Offset: 0x2BAE1F4 VA: 0x2BB21F4
	|-SortedSet.Node<KeyValuePair<byte, object>>.set_Right
	|
	|-RVA: 0x2BB2780 Offset: 0x2BAE780 VA: 0x2BB2780
	|-SortedSet.Node<KeyValuePair<double, int>>.set_Right
	|
	|-RVA: 0x2BB300C Offset: 0x2BAF00C VA: 0x2BB300C
	|-SortedSet.Node<__Il2CppFullySharedGenericType>.set_Right
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public NodeColor get_Color() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB21FC Offset: 0x2BAE1FC VA: 0x2BB21FC
	|-SortedSet.Node<KeyValuePair<byte, object>>.get_Color
	|
	|-RVA: 0x2BB2788 Offset: 0x2BAE788 VA: 0x2BB2788
	|-SortedSet.Node<KeyValuePair<double, int>>.get_Color
	|
	|-RVA: 0x2BB302C Offset: 0x2BAF02C VA: 0x2BB302C
	|-SortedSet.Node<__Il2CppFullySharedGenericType>.get_Color
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public void set_Color(NodeColor value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB2204 Offset: 0x2BAE204 VA: 0x2BB2204
	|-SortedSet.Node<KeyValuePair<byte, object>>.set_Color
	|
	|-RVA: 0x2BB2790 Offset: 0x2BAE790 VA: 0x2BB2790
	|-SortedSet.Node<KeyValuePair<double, int>>.set_Color
	|
	|-RVA: 0x2BB3054 Offset: 0x2BAF054 VA: 0x2BB3054
	|-SortedSet.Node<__Il2CppFullySharedGenericType>.set_Color
	*/

	// RVA: -1 Offset: -1
	public bool get_IsBlack() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB220C Offset: 0x2BAE20C VA: 0x2BB220C
	|-SortedSet.Node<KeyValuePair<byte, object>>.get_IsBlack
	|
	|-RVA: 0x2BB2798 Offset: 0x2BAE798 VA: 0x2BB2798
	|-SortedSet.Node<KeyValuePair<double, int>>.get_IsBlack
	|
	|-RVA: 0x2BB3074 Offset: 0x2BAF074 VA: 0x2BB3074
	|-SortedSet.Node<__Il2CppFullySharedGenericType>.get_IsBlack
	*/

	// RVA: -1 Offset: -1
	public bool get_IsRed() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB221C Offset: 0x2BAE21C VA: 0x2BB221C
	|-SortedSet.Node<KeyValuePair<byte, object>>.get_IsRed
	|
	|-RVA: 0x2BB27A8 Offset: 0x2BAE7A8 VA: 0x2BB27A8
	|-SortedSet.Node<KeyValuePair<double, int>>.get_IsRed
	|
	|-RVA: 0x2BB309C Offset: 0x2BAF09C VA: 0x2BB309C
	|-SortedSet.Node<__Il2CppFullySharedGenericType>.get_IsRed
	*/

	// RVA: -1 Offset: -1
	public bool get_Is2Node() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB222C Offset: 0x2BAE22C VA: 0x2BB222C
	|-SortedSet.Node<KeyValuePair<byte, object>>.get_Is2Node
	|
	|-RVA: 0x2BB27B8 Offset: 0x2BAE7B8 VA: 0x2BB27B8
	|-SortedSet.Node<KeyValuePair<double, int>>.get_Is2Node
	|
	|-RVA: 0x2BB30C8 Offset: 0x2BAF0C8 VA: 0x2BB30C8
	|-SortedSet.Node<__Il2CppFullySharedGenericType>.get_Is2Node
	*/

	// RVA: -1 Offset: -1
	public bool get_Is4Node() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB22BC Offset: 0x2BAE2BC VA: 0x2BB22BC
	|-SortedSet.Node<KeyValuePair<byte, object>>.get_Is4Node
	|
	|-RVA: 0x2BB2848 Offset: 0x2BAE848 VA: 0x2BB2848
	|-SortedSet.Node<KeyValuePair<double, int>>.get_Is4Node
	|
	|-RVA: 0x2BB3164 Offset: 0x2BAF164 VA: 0x2BB3164
	|-SortedSet.Node<__Il2CppFullySharedGenericType>.get_Is4Node
	*/

	// RVA: -1 Offset: -1
	public void ColorBlack() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB2340 Offset: 0x2BAE340 VA: 0x2BB2340
	|-SortedSet.Node<KeyValuePair<byte, object>>.ColorBlack
	|
	|-RVA: 0x2BB28CC Offset: 0x2BAE8CC VA: 0x2BB28CC
	|-SortedSet.Node<KeyValuePair<double, int>>.ColorBlack
	|
	|-RVA: 0x2BB31E4 Offset: 0x2BAF1E4 VA: 0x2BB31E4
	|-SortedSet.Node<__Il2CppFullySharedGenericType>.ColorBlack
	*/

	// RVA: -1 Offset: -1
	public void ColorRed() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB2348 Offset: 0x2BAE348 VA: 0x2BB2348
	|-SortedSet.Node<KeyValuePair<byte, object>>.ColorRed
	|
	|-RVA: 0x2BB28D4 Offset: 0x2BAE8D4 VA: 0x2BB28D4
	|-SortedSet.Node<KeyValuePair<double, int>>.ColorRed
	|
	|-RVA: 0x2BB31FC Offset: 0x2BAF1FC VA: 0x2BB31FC
	|-SortedSet.Node<__Il2CppFullySharedGenericType>.ColorRed
	*/

	// RVA: -1 Offset: -1
	public TreeRotation GetRotation(SortedSet.Node<T> current, SortedSet.Node<T> sibling) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB2354 Offset: 0x2BAE354 VA: 0x2BB2354
	|-SortedSet.Node<KeyValuePair<byte, object>>.GetRotation
	|
	|-RVA: 0x2BB28E0 Offset: 0x2BAE8E0 VA: 0x2BB28E0
	|-SortedSet.Node<KeyValuePair<double, int>>.GetRotation
	|
	|-RVA: 0x2BB3214 Offset: 0x2BAF214 VA: 0x2BB3214
	|-SortedSet.Node<__Il2CppFullySharedGenericType>.GetRotation
	*/

	// RVA: -1 Offset: -1
	public SortedSet.Node<T> GetSibling(SortedSet.Node<T> node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB23C0 Offset: 0x2BAE3C0 VA: 0x2BB23C0
	|-SortedSet.Node<KeyValuePair<byte, object>>.GetSibling
	|
	|-RVA: 0x2BB294C Offset: 0x2BAE94C VA: 0x2BB294C
	|-SortedSet.Node<KeyValuePair<double, int>>.GetSibling
	|
	|-RVA: 0x2BB32A0 Offset: 0x2BAF2A0 VA: 0x2BB32A0
	|-SortedSet.Node<__Il2CppFullySharedGenericType>.GetSibling
	*/

	// RVA: -1 Offset: -1
	public void Split4Node() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB23DC Offset: 0x2BAE3DC VA: 0x2BB23DC
	|-SortedSet.Node<KeyValuePair<byte, object>>.Split4Node
	|
	|-RVA: 0x2BB2968 Offset: 0x2BAE968 VA: 0x2BB2968
	|-SortedSet.Node<KeyValuePair<double, int>>.Split4Node
	|
	|-RVA: 0x2BB32F8 Offset: 0x2BAF2F8 VA: 0x2BB32F8
	|-SortedSet.Node<__Il2CppFullySharedGenericType>.Split4Node
	*/

	// RVA: -1 Offset: -1
	public SortedSet.Node<T> Rotate(TreeRotation rotation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB240C Offset: 0x2BAE40C VA: 0x2BB240C
	|-SortedSet.Node<KeyValuePair<byte, object>>.Rotate
	|
	|-RVA: 0x2BB2998 Offset: 0x2BAE998 VA: 0x2BB2998
	|-SortedSet.Node<KeyValuePair<double, int>>.Rotate
	|
	|-RVA: 0x2BB3388 Offset: 0x2BAF388 VA: 0x2BB3388
	|-SortedSet.Node<__Il2CppFullySharedGenericType>.Rotate
	*/

	// RVA: -1 Offset: -1
	public SortedSet.Node<T> RotateLeft() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB24C0 Offset: 0x2BAE4C0 VA: 0x2BB24C0
	|-SortedSet.Node<KeyValuePair<byte, object>>.RotateLeft
	|
	|-RVA: 0x2BB2A4C Offset: 0x2BAEA4C VA: 0x2BB2A4C
	|-SortedSet.Node<KeyValuePair<double, int>>.RotateLeft
	|
	|-RVA: 0x2BB34B4 Offset: 0x2BAF4B4 VA: 0x2BB34B4
	|-SortedSet.Node<__Il2CppFullySharedGenericType>.RotateLeft
	*/

	// RVA: -1 Offset: -1
	public SortedSet.Node<T> RotateLeftRight() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB2508 Offset: 0x2BAE508 VA: 0x2BB2508
	|-SortedSet.Node<KeyValuePair<byte, object>>.RotateLeftRight
	|
	|-RVA: 0x2BB2A94 Offset: 0x2BAEA94 VA: 0x2BB2A94
	|-SortedSet.Node<KeyValuePair<double, int>>.RotateLeftRight
	|
	|-RVA: 0x2BB3540 Offset: 0x2BAF540 VA: 0x2BB3540
	|-SortedSet.Node<__Il2CppFullySharedGenericType>.RotateLeftRight
	*/

	// RVA: -1 Offset: -1
	public SortedSet.Node<T> RotateRight() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB2588 Offset: 0x2BAE588 VA: 0x2BB2588
	|-SortedSet.Node<KeyValuePair<byte, object>>.RotateRight
	|
	|-RVA: 0x2BB2B14 Offset: 0x2BAEB14 VA: 0x2BB2B14
	|-SortedSet.Node<KeyValuePair<double, int>>.RotateRight
	|
	|-RVA: 0x2BB3640 Offset: 0x2BAF640 VA: 0x2BB3640
	|-SortedSet.Node<__Il2CppFullySharedGenericType>.RotateRight
	*/

	// RVA: -1 Offset: -1
	public SortedSet.Node<T> RotateRightLeft() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB25D0 Offset: 0x2BAE5D0 VA: 0x2BB25D0
	|-SortedSet.Node<KeyValuePair<byte, object>>.RotateRightLeft
	|
	|-RVA: 0x2BB2B5C Offset: 0x2BAEB5C VA: 0x2BB2B5C
	|-SortedSet.Node<KeyValuePair<double, int>>.RotateRightLeft
	|
	|-RVA: 0x2BB36CC Offset: 0x2BAF6CC VA: 0x2BB36CC
	|-SortedSet.Node<__Il2CppFullySharedGenericType>.RotateRightLeft
	*/

	// RVA: -1 Offset: -1
	public void Merge2Nodes() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB2650 Offset: 0x2BAE650 VA: 0x2BB2650
	|-SortedSet.Node<KeyValuePair<byte, object>>.Merge2Nodes
	|
	|-RVA: 0x2BB2BDC Offset: 0x2BAEBDC VA: 0x2BB2BDC
	|-SortedSet.Node<KeyValuePair<double, int>>.Merge2Nodes
	|
	|-RVA: 0x2BB37CC Offset: 0x2BAF7CC VA: 0x2BB37CC
	|-SortedSet.Node<__Il2CppFullySharedGenericType>.Merge2Nodes
	*/

	// RVA: -1 Offset: -1
	public void ReplaceChild(SortedSet.Node<T> child, SortedSet.Node<T> newChild) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB2680 Offset: 0x2BAE680 VA: 0x2BB2680
	|-SortedSet.Node<KeyValuePair<byte, object>>.ReplaceChild
	|
	|-RVA: 0x2BB2C0C Offset: 0x2BAEC0C VA: 0x2BB2C0C
	|-SortedSet.Node<KeyValuePair<double, int>>.ReplaceChild
	|
	|-RVA: 0x2BB385C Offset: 0x2BAF85C VA: 0x2BB385C
	|-SortedSet.Node<__Il2CppFullySharedGenericType>.ReplaceChild
	*/
}
