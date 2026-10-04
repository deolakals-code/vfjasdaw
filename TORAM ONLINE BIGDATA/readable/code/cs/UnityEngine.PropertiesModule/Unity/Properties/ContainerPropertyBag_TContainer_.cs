// Assembly: UnityEngine.PropertiesModule.dll
// Namespace: Unity.Properties
public abstract class ContainerPropertyBag<TContainer> : PropertyBag<TContainer> // TypeDefIndex: 17341
{
	// Fields
	private readonly List<IProperty<TContainer>> m_PropertiesList; // 0x0
	private readonly Dictionary<string, IProperty<TContainer>> m_PropertiesHash; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DC5818 Offset: 0x2DC1818 VA: 0x2DC5818
	|-ContainerPropertyBag<Bounds>..cctor
	|
	|-RVA: 0x2DC5A20 Offset: 0x2DC1A20 VA: 0x2DC5A20
	|-ContainerPropertyBag<BoundsInt>..cctor
	|
	|-RVA: 0x2DC5C28 Offset: 0x2DC1C28 VA: 0x2DC5C28
	|-ContainerPropertyBag<Color>..cctor
	|
	|-RVA: 0x2DC5E30 Offset: 0x2DC1E30 VA: 0x2DC5E30
	|-ContainerPropertyBag<object>..cctor
	|
	|-RVA: 0x2DC6038 Offset: 0x2DC2038 VA: 0x2DC6038
	|-ContainerPropertyBag<Rect>..cctor
	|
	|-RVA: 0x2DC6240 Offset: 0x2DC2240 VA: 0x2DC6240
	|-ContainerPropertyBag<RectInt>..cctor
	|
	|-RVA: 0x2DC6448 Offset: 0x2DC2448 VA: 0x2DC6448
	|-ContainerPropertyBag<Vector2>..cctor
	|
	|-RVA: 0x2DC6650 Offset: 0x2DC2650 VA: 0x2DC6650
	|-ContainerPropertyBag<Vector2Int>..cctor
	|
	|-RVA: 0x2DC6858 Offset: 0x2DC2858 VA: 0x2DC6858
	|-ContainerPropertyBag<Vector3>..cctor
	|
	|-RVA: 0x2DC6A60 Offset: 0x2DC2A60 VA: 0x2DC6A60
	|-ContainerPropertyBag<Vector3Int>..cctor
	|
	|-RVA: 0x2DC6C68 Offset: 0x2DC2C68 VA: 0x2DC6C68
	|-ContainerPropertyBag<Vector4>..cctor
	|
	|-RVA: 0x2DC6E70 Offset: 0x2DC2E70 VA: 0x2DC6E70
	|-ContainerPropertyBag<__Il2CppFullySharedGenericType>..cctor
	*/

	// RVA: -1 Offset: -1
	protected void AddProperty<TValue>(Property<TContainer, TValue> property) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26792D4 Offset: 0x26752D4 VA: 0x26792D4
	|-ContainerPropertyBag<Bounds>.AddProperty<Vector3>
	|
	|-RVA: 0x2679398 Offset: 0x2675398 VA: 0x2679398
	|-ContainerPropertyBag<BoundsInt>.AddProperty<Vector3Int>
	|
	|-RVA: 0x267945C Offset: 0x267545C VA: 0x267945C
	|-ContainerPropertyBag<Color>.AddProperty<float>
	|
	|-RVA: 0x2679520 Offset: 0x2675520 VA: 0x2679520
	|-ContainerPropertyBag<object>.AddProperty<int>
	|
	|-RVA: 0x26795E4 Offset: 0x26755E4 VA: 0x26795E4
	|-ContainerPropertyBag<Rect>.AddProperty<float>
	|
	|-RVA: 0x26796A8 Offset: 0x26756A8 VA: 0x26796A8
	|-ContainerPropertyBag<RectInt>.AddProperty<int>
	|
	|-RVA: 0x267976C Offset: 0x267576C VA: 0x267976C
	|-ContainerPropertyBag<Vector2>.AddProperty<float>
	|
	|-RVA: 0x2679830 Offset: 0x2675830 VA: 0x2679830
	|-ContainerPropertyBag<Vector2Int>.AddProperty<int>
	|
	|-RVA: 0x26798F4 Offset: 0x26758F4 VA: 0x26798F4
	|-ContainerPropertyBag<Vector3>.AddProperty<float>
	|
	|-RVA: 0x26799B8 Offset: 0x26759B8 VA: 0x26799B8
	|-ContainerPropertyBag<Vector3Int>.AddProperty<int>
	|
	|-RVA: 0x2679A7C Offset: 0x2675A7C VA: 0x2679A7C
	|-ContainerPropertyBag<Vector4>.AddProperty<float>
	|
	|-RVA: 0x2679B40 Offset: 0x2675B40 VA: 0x2679B40
	|-ContainerPropertyBag<__Il2CppFullySharedGenericType>.AddProperty<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public bool TryGetProperty(ref TContainer container, string name, out IProperty<TContainer> property) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DC5914 Offset: 0x2DC1914 VA: 0x2DC5914
	|-ContainerPropertyBag<Bounds>.TryGetProperty
	|
	|-RVA: 0x2DC5B1C Offset: 0x2DC1B1C VA: 0x2DC5B1C
	|-ContainerPropertyBag<BoundsInt>.TryGetProperty
	|
	|-RVA: 0x2DC5D24 Offset: 0x2DC1D24 VA: 0x2DC5D24
	|-ContainerPropertyBag<Color>.TryGetProperty
	|
	|-RVA: 0x2DC5F2C Offset: 0x2DC1F2C VA: 0x2DC5F2C
	|-ContainerPropertyBag<object>.TryGetProperty
	|
	|-RVA: 0x2DC6134 Offset: 0x2DC2134 VA: 0x2DC6134
	|-ContainerPropertyBag<Rect>.TryGetProperty
	|
	|-RVA: 0x2DC633C Offset: 0x2DC233C VA: 0x2DC633C
	|-ContainerPropertyBag<RectInt>.TryGetProperty
	|
	|-RVA: 0x2DC6544 Offset: 0x2DC2544 VA: 0x2DC6544
	|-ContainerPropertyBag<Vector2>.TryGetProperty
	|
	|-RVA: 0x2DC674C Offset: 0x2DC274C VA: 0x2DC674C
	|-ContainerPropertyBag<Vector2Int>.TryGetProperty
	|
	|-RVA: 0x2DC6954 Offset: 0x2DC2954 VA: 0x2DC6954
	|-ContainerPropertyBag<Vector3>.TryGetProperty
	|
	|-RVA: 0x2DC6B5C Offset: 0x2DC2B5C VA: 0x2DC6B5C
	|-ContainerPropertyBag<Vector3Int>.TryGetProperty
	|
	|-RVA: 0x2DC6D64 Offset: 0x2DC2D64 VA: 0x2DC6D64
	|-ContainerPropertyBag<Vector4>.TryGetProperty
	|
	|-RVA: 0x2DC6F6C Offset: 0x2DC2F6C VA: 0x2DC6F6C
	|-ContainerPropertyBag<__Il2CppFullySharedGenericType>.TryGetProperty
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DC5944 Offset: 0x2DC1944 VA: 0x2DC5944
	|-ContainerPropertyBag<Bounds>..ctor
	|
	|-RVA: 0x2DC5B4C Offset: 0x2DC1B4C VA: 0x2DC5B4C
	|-ContainerPropertyBag<BoundsInt>..ctor
	|
	|-RVA: 0x2DC5D54 Offset: 0x2DC1D54 VA: 0x2DC5D54
	|-ContainerPropertyBag<Color>..ctor
	|
	|-RVA: 0x2DC5F5C Offset: 0x2DC1F5C VA: 0x2DC5F5C
	|-ContainerPropertyBag<object>..ctor
	|
	|-RVA: 0x2DC6164 Offset: 0x2DC2164 VA: 0x2DC6164
	|-ContainerPropertyBag<Rect>..ctor
	|
	|-RVA: 0x2DC636C Offset: 0x2DC236C VA: 0x2DC636C
	|-ContainerPropertyBag<RectInt>..ctor
	|
	|-RVA: 0x2DC6574 Offset: 0x2DC2574 VA: 0x2DC6574
	|-ContainerPropertyBag<Vector2>..ctor
	|
	|-RVA: 0x2DC677C Offset: 0x2DC277C VA: 0x2DC677C
	|-ContainerPropertyBag<Vector2Int>..ctor
	|
	|-RVA: 0x2DC6984 Offset: 0x2DC2984 VA: 0x2DC6984
	|-ContainerPropertyBag<Vector3>..ctor
	|
	|-RVA: 0x2DC6B8C Offset: 0x2DC2B8C VA: 0x2DC6B8C
	|-ContainerPropertyBag<Vector3Int>..ctor
	|
	|-RVA: 0x2DC6D94 Offset: 0x2DC2D94 VA: 0x2DC6D94
	|-ContainerPropertyBag<Vector4>..ctor
	|
	|-RVA: 0x2DC6FB8 Offset: 0x2DC2FB8 VA: 0x2DC6FB8
	|-ContainerPropertyBag<__Il2CppFullySharedGenericType>..ctor
	*/
}
