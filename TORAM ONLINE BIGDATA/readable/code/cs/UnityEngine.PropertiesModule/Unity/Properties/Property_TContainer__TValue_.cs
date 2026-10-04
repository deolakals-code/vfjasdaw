// Assembly: UnityEngine.PropertiesModule.dll
// Namespace: Unity.Properties
public abstract class Property<TContainer, TValue> : IProperty<TContainer>, IProperty, IAttributes // TypeDefIndex: 17331
{
	// Fields
	private List<Attribute> m_Attributes; // 0x0

	// Properties
	public abstract string Name { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 7
	public abstract string get_Name();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-Property<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Name
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public Type DeclaredValueType() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BE9124 Offset: 0x2BE5124 VA: 0x2BE9124
	|-Property<Bounds, Vector3>.DeclaredValueType
	|
	|-RVA: 0x2BE98A0 Offset: 0x2BE58A0 VA: 0x2BE98A0
	|-Property<BoundsInt, Vector3Int>.DeclaredValueType
	|
	|-RVA: 0x2BEA01C Offset: 0x2BE601C VA: 0x2BEA01C
	|-Property<Color, float>.DeclaredValueType
	|
	|-RVA: 0x2BEA798 Offset: 0x2BE6798 VA: 0x2BEA798
	|-Property<object, int>.DeclaredValueType
	|
	|-RVA: 0x2BEAF14 Offset: 0x2BE6F14 VA: 0x2BEAF14
	|-Property<Rect, float>.DeclaredValueType
	|
	|-RVA: 0x2BEB690 Offset: 0x2BE7690 VA: 0x2BEB690
	|-Property<RectInt, int>.DeclaredValueType
	|
	|-RVA: 0x2BEBE0C Offset: 0x2BE7E0C VA: 0x2BEBE0C
	|-Property<Vector2, float>.DeclaredValueType
	|
	|-RVA: 0x2BEC588 Offset: 0x2BE8588 VA: 0x2BEC588
	|-Property<Vector2Int, int>.DeclaredValueType
	|
	|-RVA: 0x2BECD04 Offset: 0x2BE8D04 VA: 0x2BECD04
	|-Property<Vector3, float>.DeclaredValueType
	|
	|-RVA: 0x2BED480 Offset: 0x2BE9480 VA: 0x2BED480
	|-Property<Vector3Int, int>.DeclaredValueType
	|
	|-RVA: 0x2BEDBFC Offset: 0x2BE9BFC VA: 0x2BEDBFC
	|-Property<Vector4, float>.DeclaredValueType
	|
	|-RVA: 0x2BEE378 Offset: 0x2BEA378 VA: 0x2BEE378
	|-Property<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.DeclaredValueType
	*/

	// RVA: -1 Offset: -1
	protected void AddAttribute(Attribute attribute) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BE9188 Offset: 0x2BE5188 VA: 0x2BE9188
	|-Property<Bounds, Vector3>.AddAttribute
	|
	|-RVA: 0x2BE9904 Offset: 0x2BE5904 VA: 0x2BE9904
	|-Property<BoundsInt, Vector3Int>.AddAttribute
	|
	|-RVA: 0x2BEA080 Offset: 0x2BE6080 VA: 0x2BEA080
	|-Property<Color, float>.AddAttribute
	|
	|-RVA: 0x2BEA7FC Offset: 0x2BE67FC VA: 0x2BEA7FC
	|-Property<object, int>.AddAttribute
	|
	|-RVA: 0x2BEAF78 Offset: 0x2BE6F78 VA: 0x2BEAF78
	|-Property<Rect, float>.AddAttribute
	|
	|-RVA: 0x2BEB6F4 Offset: 0x2BE76F4 VA: 0x2BEB6F4
	|-Property<RectInt, int>.AddAttribute
	|
	|-RVA: 0x2BEBE70 Offset: 0x2BE7E70 VA: 0x2BEBE70
	|-Property<Vector2, float>.AddAttribute
	|
	|-RVA: 0x2BEC5EC Offset: 0x2BE85EC VA: 0x2BEC5EC
	|-Property<Vector2Int, int>.AddAttribute
	|
	|-RVA: 0x2BECD68 Offset: 0x2BE8D68 VA: 0x2BECD68
	|-Property<Vector3, float>.AddAttribute
	|
	|-RVA: 0x2BED4E4 Offset: 0x2BE94E4 VA: 0x2BED4E4
	|-Property<Vector3Int, int>.AddAttribute
	|
	|-RVA: 0x2BEDC60 Offset: 0x2BE9C60 VA: 0x2BEDC60
	|-Property<Vector4, float>.AddAttribute
	|
	|-RVA: 0x2BEE3DC Offset: 0x2BEA3DC VA: 0x2BEE3DC
	|-Property<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.AddAttribute
	*/

	// RVA: -1 Offset: -1
	protected void AddAttributes(IEnumerable<Attribute> attributes) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BE922C Offset: 0x2BE522C VA: 0x2BE922C
	|-Property<Bounds, Vector3>.AddAttributes
	|
	|-RVA: 0x2BE99A8 Offset: 0x2BE59A8 VA: 0x2BE99A8
	|-Property<BoundsInt, Vector3Int>.AddAttributes
	|
	|-RVA: 0x2BEA124 Offset: 0x2BE6124 VA: 0x2BEA124
	|-Property<Color, float>.AddAttributes
	|
	|-RVA: 0x2BEA8A0 Offset: 0x2BE68A0 VA: 0x2BEA8A0
	|-Property<object, int>.AddAttributes
	|
	|-RVA: 0x2BEB01C Offset: 0x2BE701C VA: 0x2BEB01C
	|-Property<Rect, float>.AddAttributes
	|
	|-RVA: 0x2BEB798 Offset: 0x2BE7798 VA: 0x2BEB798
	|-Property<RectInt, int>.AddAttributes
	|
	|-RVA: 0x2BEBF14 Offset: 0x2BE7F14 VA: 0x2BEBF14
	|-Property<Vector2, float>.AddAttributes
	|
	|-RVA: 0x2BEC690 Offset: 0x2BE8690 VA: 0x2BEC690
	|-Property<Vector2Int, int>.AddAttributes
	|
	|-RVA: 0x2BECE0C Offset: 0x2BE8E0C VA: 0x2BECE0C
	|-Property<Vector3, float>.AddAttributes
	|
	|-RVA: 0x2BED588 Offset: 0x2BE9588 VA: 0x2BED588
	|-Property<Vector3Int, int>.AddAttributes
	|
	|-RVA: 0x2BEDD04 Offset: 0x2BE9D04 VA: 0x2BEDD04
	|-Property<Vector4, float>.AddAttributes
	|
	|-RVA: 0x2BEE480 Offset: 0x2BEA480 VA: 0x2BEE480
	|-Property<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.AddAttributes
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private void Unity.Properties.Internal.IAttributes.AddAttribute(Attribute attribute) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BE92D4 Offset: 0x2BE52D4 VA: 0x2BE92D4
	|-Property<Bounds, Vector3>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x2BE9A50 Offset: 0x2BE5A50 VA: 0x2BE9A50
	|-Property<BoundsInt, Vector3Int>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x2BEA1CC Offset: 0x2BE61CC VA: 0x2BEA1CC
	|-Property<Color, float>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x2BEA948 Offset: 0x2BE6948 VA: 0x2BEA948
	|-Property<object, int>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x2BEB0C4 Offset: 0x2BE70C4 VA: 0x2BEB0C4
	|-Property<Rect, float>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x2BEB840 Offset: 0x2BE7840 VA: 0x2BEB840
	|-Property<RectInt, int>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x2BEBFBC Offset: 0x2BE7FBC VA: 0x2BEBFBC
	|-Property<Vector2, float>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x2BEC738 Offset: 0x2BE8738 VA: 0x2BEC738
	|-Property<Vector2Int, int>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x2BECEB4 Offset: 0x2BE8EB4 VA: 0x2BECEB4
	|-Property<Vector3, float>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x2BED630 Offset: 0x2BE9630 VA: 0x2BED630
	|-Property<Vector3Int, int>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x2BEDDAC Offset: 0x2BE9DAC VA: 0x2BEDDAC
	|-Property<Vector4, float>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x2BEE528 Offset: 0x2BEA528 VA: 0x2BEE528
	|-Property<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Unity.Properties.Internal.IAttributes.AddAttribute
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private void Unity.Properties.Internal.IAttributes.AddAttributes(IEnumerable<Attribute> attributes) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BE9464 Offset: 0x2BE5464 VA: 0x2BE9464
	|-Property<Bounds, Vector3>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x2BE9BE0 Offset: 0x2BE5BE0 VA: 0x2BE9BE0
	|-Property<BoundsInt, Vector3Int>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x2BEA35C Offset: 0x2BE635C VA: 0x2BEA35C
	|-Property<Color, float>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x2BEAAD8 Offset: 0x2BE6AD8 VA: 0x2BEAAD8
	|-Property<object, int>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x2BEB254 Offset: 0x2BE7254 VA: 0x2BEB254
	|-Property<Rect, float>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x2BEB9D0 Offset: 0x2BE79D0 VA: 0x2BEB9D0
	|-Property<RectInt, int>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x2BEC14C Offset: 0x2BE814C VA: 0x2BEC14C
	|-Property<Vector2, float>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x2BEC8C8 Offset: 0x2BE88C8 VA: 0x2BEC8C8
	|-Property<Vector2Int, int>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x2BED044 Offset: 0x2BE9044 VA: 0x2BED044
	|-Property<Vector3, float>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x2BED7C0 Offset: 0x2BE97C0 VA: 0x2BED7C0
	|-Property<Vector3Int, int>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x2BEDF3C Offset: 0x2BE9F3C VA: 0x2BEDF3C
	|-Property<Vector4, float>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x2BEE6B8 Offset: 0x2BEA6B8 VA: 0x2BEE6B8
	|-Property<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Unity.Properties.Internal.IAttributes.AddAttributes
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public bool HasAttribute<TAttribute>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x267B99C Offset: 0x267799C VA: 0x267B99C
	|-Property<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.HasAttribute<object>
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BE9898 Offset: 0x2BE5898 VA: 0x2BE9898
	|-Property<Bounds, Vector3>..ctor
	|
	|-RVA: 0x2BEA014 Offset: 0x2BE6014 VA: 0x2BEA014
	|-Property<BoundsInt, Vector3Int>..ctor
	|
	|-RVA: 0x2BEA790 Offset: 0x2BE6790 VA: 0x2BEA790
	|-Property<Color, float>..ctor
	|
	|-RVA: 0x2BEAF0C Offset: 0x2BE6F0C VA: 0x2BEAF0C
	|-Property<object, int>..ctor
	|
	|-RVA: 0x2BEB688 Offset: 0x2BE7688 VA: 0x2BEB688
	|-Property<Rect, float>..ctor
	|
	|-RVA: 0x2BEBE04 Offset: 0x2BE7E04 VA: 0x2BEBE04
	|-Property<RectInt, int>..ctor
	|
	|-RVA: 0x2BEC580 Offset: 0x2BE8580 VA: 0x2BEC580
	|-Property<Vector2, float>..ctor
	|
	|-RVA: 0x2BECCFC Offset: 0x2BE8CFC VA: 0x2BECCFC
	|-Property<Vector2Int, int>..ctor
	|
	|-RVA: 0x2BED478 Offset: 0x2BE9478 VA: 0x2BED478
	|-Property<Vector3, float>..ctor
	|
	|-RVA: 0x2BEDBF4 Offset: 0x2BE9BF4 VA: 0x2BEDBF4
	|-Property<Vector3Int, int>..ctor
	|
	|-RVA: 0x2BEE370 Offset: 0x2BEA370 VA: 0x2BEE370
	|-Property<Vector4, float>..ctor
	|
	|-RVA: 0x2BEEAEC Offset: 0x2BEAAEC VA: 0x2BEEAEC
	|-Property<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/
}
