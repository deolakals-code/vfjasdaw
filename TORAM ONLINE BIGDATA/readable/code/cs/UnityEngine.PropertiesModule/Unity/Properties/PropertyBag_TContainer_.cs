// Assembly: UnityEngine.PropertiesModule.dll
// Namespace: Unity.Properties
public abstract class PropertyBag<TContainer> : IPropertyBag<TContainer>, IPropertyBag, IPropertyBagRegister, IConstructor<TContainer>, IConstructor // TypeDefIndex: 17354
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly InstantiationKind <InstantiationKind>k__BackingField; // 0x0

	// Properties
	private InstantiationKind Unity.Properties.IConstructor.InstantiationKind { get; }
	protected virtual InstantiationKind InstantiationKind { get; }

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BE6FF8 Offset: 0x2BE2FF8 VA: 0x2BE6FF8
	|-PropertyBag<Bounds>..cctor
	|
	|-RVA: 0x2BE729C Offset: 0x2BE329C VA: 0x2BE729C
	|-PropertyBag<BoundsInt>..cctor
	|
	|-RVA: 0x2BE7540 Offset: 0x2BE3540 VA: 0x2BE7540
	|-PropertyBag<Color>..cctor
	|
	|-RVA: 0x2BE77B8 Offset: 0x2BE37B8 VA: 0x2BE77B8
	|-PropertyBag<object>..cctor
	|
	|-RVA: 0x2BE7A24 Offset: 0x2BE3A24 VA: 0x2BE7A24
	|-PropertyBag<Rect>..cctor
	|
	|-RVA: 0x2BE7C9C Offset: 0x2BE3C9C VA: 0x2BE7C9C
	|-PropertyBag<RectInt>..cctor
	|
	|-RVA: 0x2BE7F0C Offset: 0x2BE3F0C VA: 0x2BE7F0C
	|-PropertyBag<Vector2>..cctor
	|
	|-RVA: 0x2BE817C Offset: 0x2BE417C VA: 0x2BE817C
	|-PropertyBag<Vector2Int>..cctor
	|
	|-RVA: 0x2BE83E8 Offset: 0x2BE43E8 VA: 0x2BE83E8
	|-PropertyBag<Vector3>..cctor
	|
	|-RVA: 0x2BE865C Offset: 0x2BE465C VA: 0x2BE865C
	|-PropertyBag<Vector3Int>..cctor
	|
	|-RVA: 0x2BE88DC Offset: 0x2BE48DC VA: 0x2BE88DC
	|-PropertyBag<Vector4>..cctor
	|
	|-RVA: 0x2BE8B54 Offset: 0x2BE4B54 VA: 0x2BE8B54
	|-PropertyBag<__Il2CppFullySharedGenericType>..cctor
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private void Unity.Properties.Internal.IPropertyBagRegister.Register() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BE70F4 Offset: 0x2BE30F4 VA: 0x2BE70F4
	|-PropertyBag<Bounds>.Unity.Properties.Internal.IPropertyBagRegister.Register
	|
	|-RVA: 0x2BE7398 Offset: 0x2BE3398 VA: 0x2BE7398
	|-PropertyBag<BoundsInt>.Unity.Properties.Internal.IPropertyBagRegister.Register
	|
	|-RVA: 0x2BE763C Offset: 0x2BE363C VA: 0x2BE763C
	|-PropertyBag<Color>.Unity.Properties.Internal.IPropertyBagRegister.Register
	|
	|-RVA: 0x2BE78B4 Offset: 0x2BE38B4 VA: 0x2BE78B4
	|-PropertyBag<object>.Unity.Properties.Internal.IPropertyBagRegister.Register
	|
	|-RVA: 0x2BE7B20 Offset: 0x2BE3B20 VA: 0x2BE7B20
	|-PropertyBag<Rect>.Unity.Properties.Internal.IPropertyBagRegister.Register
	|
	|-RVA: 0x2BE7D98 Offset: 0x2BE3D98 VA: 0x2BE7D98
	|-PropertyBag<RectInt>.Unity.Properties.Internal.IPropertyBagRegister.Register
	|
	|-RVA: 0x2BE8008 Offset: 0x2BE4008 VA: 0x2BE8008
	|-PropertyBag<Vector2>.Unity.Properties.Internal.IPropertyBagRegister.Register
	|
	|-RVA: 0x2BE8278 Offset: 0x2BE4278 VA: 0x2BE8278
	|-PropertyBag<Vector2Int>.Unity.Properties.Internal.IPropertyBagRegister.Register
	|
	|-RVA: 0x2BE84E4 Offset: 0x2BE44E4 VA: 0x2BE84E4
	|-PropertyBag<Vector3>.Unity.Properties.Internal.IPropertyBagRegister.Register
	|
	|-RVA: 0x2BE8758 Offset: 0x2BE4758 VA: 0x2BE8758
	|-PropertyBag<Vector3Int>.Unity.Properties.Internal.IPropertyBagRegister.Register
	|
	|-RVA: 0x2BE89D8 Offset: 0x2BE49D8 VA: 0x2BE89D8
	|-PropertyBag<Vector4>.Unity.Properties.Internal.IPropertyBagRegister.Register
	|
	|-RVA: 0x2BE8C50 Offset: 0x2BE4C50 VA: 0x2BE8C50
	|-PropertyBag<__Il2CppFullySharedGenericType>.Unity.Properties.Internal.IPropertyBagRegister.Register
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void Accept(ITypeVisitor visitor) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BE7160 Offset: 0x2BE3160 VA: 0x2BE7160
	|-PropertyBag<Bounds>.Accept
	|
	|-RVA: 0x2BE7404 Offset: 0x2BE3404 VA: 0x2BE7404
	|-PropertyBag<BoundsInt>.Accept
	|
	|-RVA: 0x2BE76A8 Offset: 0x2BE36A8 VA: 0x2BE76A8
	|-PropertyBag<Color>.Accept
	|
	|-RVA: 0x2BE7920 Offset: 0x2BE3920 VA: 0x2BE7920
	|-PropertyBag<object>.Accept
	|
	|-RVA: 0x2BE7B8C Offset: 0x2BE3B8C VA: 0x2BE7B8C
	|-PropertyBag<Rect>.Accept
	|
	|-RVA: 0x2BE7E04 Offset: 0x2BE3E04 VA: 0x2BE7E04
	|-PropertyBag<RectInt>.Accept
	|
	|-RVA: 0x2BE8074 Offset: 0x2BE4074 VA: 0x2BE8074
	|-PropertyBag<Vector2>.Accept
	|
	|-RVA: 0x2BE82E4 Offset: 0x2BE42E4 VA: 0x2BE82E4
	|-PropertyBag<Vector2Int>.Accept
	|
	|-RVA: 0x2BE8550 Offset: 0x2BE4550 VA: 0x2BE8550
	|-PropertyBag<Vector3>.Accept
	|
	|-RVA: 0x2BE87C4 Offset: 0x2BE47C4 VA: 0x2BE87C4
	|-PropertyBag<Vector3Int>.Accept
	|
	|-RVA: 0x2BE8A44 Offset: 0x2BE4A44 VA: 0x2BE8A44
	|-PropertyBag<Vector4>.Accept
	|
	|-RVA: 0x2BE8CC0 Offset: 0x2BE4CC0 VA: 0x2BE8CC0
	|-PropertyBag<__Il2CppFullySharedGenericType>.Accept
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private InstantiationKind Unity.Properties.IConstructor.get_InstantiationKind() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BE7230 Offset: 0x2BE3230 VA: 0x2BE7230
	|-PropertyBag<Bounds>.Unity.Properties.IConstructor.get_InstantiationKind
	|
	|-RVA: 0x2BE74D4 Offset: 0x2BE34D4 VA: 0x2BE74D4
	|-PropertyBag<BoundsInt>.Unity.Properties.IConstructor.get_InstantiationKind
	|
	|-RVA: 0x2BE7778 Offset: 0x2BE3778 VA: 0x2BE7778
	|-PropertyBag<Color>.Unity.Properties.IConstructor.get_InstantiationKind
	|
	|-RVA: 0x2BE79F0 Offset: 0x2BE39F0 VA: 0x2BE79F0
	|-PropertyBag<object>.Unity.Properties.IConstructor.get_InstantiationKind
	|
	|-RVA: 0x2BE7C5C Offset: 0x2BE3C5C VA: 0x2BE7C5C
	|-PropertyBag<Rect>.Unity.Properties.IConstructor.get_InstantiationKind
	|
	|-RVA: 0x2BE7ED4 Offset: 0x2BE3ED4 VA: 0x2BE7ED4
	|-PropertyBag<RectInt>.Unity.Properties.IConstructor.get_InstantiationKind
	|
	|-RVA: 0x2BE8144 Offset: 0x2BE4144 VA: 0x2BE8144
	|-PropertyBag<Vector2>.Unity.Properties.IConstructor.get_InstantiationKind
	|
	|-RVA: 0x2BE83B4 Offset: 0x2BE43B4 VA: 0x2BE83B4
	|-PropertyBag<Vector2Int>.Unity.Properties.IConstructor.get_InstantiationKind
	|
	|-RVA: 0x2BE8620 Offset: 0x2BE4620 VA: 0x2BE8620
	|-PropertyBag<Vector3>.Unity.Properties.IConstructor.get_InstantiationKind
	|
	|-RVA: 0x2BE8894 Offset: 0x2BE4894 VA: 0x2BE8894
	|-PropertyBag<Vector3Int>.Unity.Properties.IConstructor.get_InstantiationKind
	|
	|-RVA: 0x2BE8B14 Offset: 0x2BE4B14 VA: 0x2BE8B14
	|-PropertyBag<Vector4>.Unity.Properties.IConstructor.get_InstantiationKind
	|
	|-RVA: 0x2BE8D90 Offset: 0x2BE4D90 VA: 0x2BE8D90
	|-PropertyBag<__Il2CppFullySharedGenericType>.Unity.Properties.IConstructor.get_InstantiationKind
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private TContainer Unity.Properties.IConstructor<TContainer>.Instantiate() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BE723C Offset: 0x2BE323C VA: 0x2BE723C
	|-PropertyBag<Bounds>.Unity.Properties.IConstructor<TContainer>.Instantiate
	|
	|-RVA: 0x2BE74E0 Offset: 0x2BE34E0 VA: 0x2BE74E0
	|-PropertyBag<BoundsInt>.Unity.Properties.IConstructor<TContainer>.Instantiate
	|
	|-RVA: 0x2BE7784 Offset: 0x2BE3784 VA: 0x2BE7784
	|-PropertyBag<Color>.Unity.Properties.IConstructor<TContainer>.Instantiate
	|
	|-RVA: 0x2BE79FC Offset: 0x2BE39FC VA: 0x2BE79FC
	|-PropertyBag<object>.Unity.Properties.IConstructor<TContainer>.Instantiate
	|
	|-RVA: 0x2BE7C68 Offset: 0x2BE3C68 VA: 0x2BE7C68
	|-PropertyBag<Rect>.Unity.Properties.IConstructor<TContainer>.Instantiate
	|
	|-RVA: 0x2BE7EE0 Offset: 0x2BE3EE0 VA: 0x2BE7EE0
	|-PropertyBag<RectInt>.Unity.Properties.IConstructor<TContainer>.Instantiate
	|
	|-RVA: 0x2BE8150 Offset: 0x2BE4150 VA: 0x2BE8150
	|-PropertyBag<Vector2>.Unity.Properties.IConstructor<TContainer>.Instantiate
	|
	|-RVA: 0x2BE83C0 Offset: 0x2BE43C0 VA: 0x2BE83C0
	|-PropertyBag<Vector2Int>.Unity.Properties.IConstructor<TContainer>.Instantiate
	|
	|-RVA: 0x2BE862C Offset: 0x2BE462C VA: 0x2BE862C
	|-PropertyBag<Vector3>.Unity.Properties.IConstructor<TContainer>.Instantiate
	|
	|-RVA: 0x2BE88A0 Offset: 0x2BE48A0 VA: 0x2BE88A0
	|-PropertyBag<Vector3Int>.Unity.Properties.IConstructor<TContainer>.Instantiate
	|
	|-RVA: 0x2BE8B20 Offset: 0x2BE4B20 VA: 0x2BE8B20
	|-PropertyBag<Vector4>.Unity.Properties.IConstructor<TContainer>.Instantiate
	|
	|-RVA: 0x2BE8D9C Offset: 0x2BE4D9C VA: 0x2BE8D9C
	|-PropertyBag<__Il2CppFullySharedGenericType>.Unity.Properties.IConstructor<TContainer>.Instantiate
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 8
	protected virtual InstantiationKind get_InstantiationKind() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BE727C Offset: 0x2BE327C VA: 0x2BE727C
	|-PropertyBag<Bounds>.get_InstantiationKind
	|
	|-RVA: 0x2BE7520 Offset: 0x2BE3520 VA: 0x2BE7520
	|-PropertyBag<BoundsInt>.get_InstantiationKind
	|
	|-RVA: 0x2BE7790 Offset: 0x2BE3790 VA: 0x2BE7790
	|-PropertyBag<Color>.get_InstantiationKind
	|
	|-RVA: 0x2BE7A08 Offset: 0x2BE3A08 VA: 0x2BE7A08
	|-PropertyBag<object>.get_InstantiationKind
	|
	|-RVA: 0x2BE7C74 Offset: 0x2BE3C74 VA: 0x2BE7C74
	|-PropertyBag<Rect>.get_InstantiationKind
	|
	|-RVA: 0x2BE7EEC Offset: 0x2BE3EEC VA: 0x2BE7EEC
	|-PropertyBag<RectInt>.get_InstantiationKind
	|
	|-RVA: 0x2BE815C Offset: 0x2BE415C VA: 0x2BE815C
	|-PropertyBag<Vector2>.get_InstantiationKind
	|
	|-RVA: 0x2BE83CC Offset: 0x2BE43CC VA: 0x2BE83CC
	|-PropertyBag<Vector2Int>.get_InstantiationKind
	|
	|-RVA: 0x2BE8638 Offset: 0x2BE4638 VA: 0x2BE8638
	|-PropertyBag<Vector3>.get_InstantiationKind
	|
	|-RVA: 0x2BE88BC Offset: 0x2BE48BC VA: 0x2BE88BC
	|-PropertyBag<Vector3Int>.get_InstantiationKind
	|
	|-RVA: 0x2BE8B2C Offset: 0x2BE4B2C VA: 0x2BE8B2C
	|-PropertyBag<Vector4>.get_InstantiationKind
	|
	|-RVA: 0x2BE8E84 Offset: 0x2BE4E84 VA: 0x2BE8E84
	|-PropertyBag<__Il2CppFullySharedGenericType>.get_InstantiationKind
	*/

	// RVA: -1 Offset: -1 Slot: 9
	protected virtual TContainer Instantiate() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BE7284 Offset: 0x2BE3284 VA: 0x2BE7284
	|-PropertyBag<Bounds>.Instantiate
	|
	|-RVA: 0x2BE7528 Offset: 0x2BE3528 VA: 0x2BE7528
	|-PropertyBag<BoundsInt>.Instantiate
	|
	|-RVA: 0x2BE7798 Offset: 0x2BE3798 VA: 0x2BE7798
	|-PropertyBag<Color>.Instantiate
	|
	|-RVA: 0x2BE7A10 Offset: 0x2BE3A10 VA: 0x2BE7A10
	|-PropertyBag<object>.Instantiate
	|
	|-RVA: 0x2BE7C7C Offset: 0x2BE3C7C VA: 0x2BE7C7C
	|-PropertyBag<Rect>.Instantiate
	|
	|-RVA: 0x2BE7EF4 Offset: 0x2BE3EF4 VA: 0x2BE7EF4
	|-PropertyBag<RectInt>.Instantiate
	|
	|-RVA: 0x2BE8164 Offset: 0x2BE4164 VA: 0x2BE8164
	|-PropertyBag<Vector2>.Instantiate
	|
	|-RVA: 0x2BE83D4 Offset: 0x2BE43D4 VA: 0x2BE83D4
	|-PropertyBag<Vector2Int>.Instantiate
	|
	|-RVA: 0x2BE8640 Offset: 0x2BE4640 VA: 0x2BE8640
	|-PropertyBag<Vector3>.Instantiate
	|
	|-RVA: 0x2BE88C4 Offset: 0x2BE48C4 VA: 0x2BE88C4
	|-PropertyBag<Vector3Int>.Instantiate
	|
	|-RVA: 0x2BE8B34 Offset: 0x2BE4B34 VA: 0x2BE8B34
	|-PropertyBag<Vector4>.Instantiate
	|
	|-RVA: 0x2BE8E8C Offset: 0x2BE4E8C VA: 0x2BE8E8C
	|-PropertyBag<__Il2CppFullySharedGenericType>.Instantiate
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BE7290 Offset: 0x2BE3290 VA: 0x2BE7290
	|-PropertyBag<Bounds>..ctor
	|
	|-RVA: 0x2BE7534 Offset: 0x2BE3534 VA: 0x2BE7534
	|-PropertyBag<BoundsInt>..ctor
	|
	|-RVA: 0x2BE77AC Offset: 0x2BE37AC VA: 0x2BE77AC
	|-PropertyBag<Color>..ctor
	|
	|-RVA: 0x2BE7A18 Offset: 0x2BE3A18 VA: 0x2BE7A18
	|-PropertyBag<object>..ctor
	|
	|-RVA: 0x2BE7C90 Offset: 0x2BE3C90 VA: 0x2BE7C90
	|-PropertyBag<Rect>..ctor
	|
	|-RVA: 0x2BE7F00 Offset: 0x2BE3F00 VA: 0x2BE7F00
	|-PropertyBag<RectInt>..ctor
	|
	|-RVA: 0x2BE8170 Offset: 0x2BE4170 VA: 0x2BE8170
	|-PropertyBag<Vector2>..ctor
	|
	|-RVA: 0x2BE83DC Offset: 0x2BE43DC VA: 0x2BE83DC
	|-PropertyBag<Vector2Int>..ctor
	|
	|-RVA: 0x2BE8650 Offset: 0x2BE4650 VA: 0x2BE8650
	|-PropertyBag<Vector3>..ctor
	|
	|-RVA: 0x2BE88D0 Offset: 0x2BE48D0 VA: 0x2BE88D0
	|-PropertyBag<Vector3Int>..ctor
	|
	|-RVA: 0x2BE8B48 Offset: 0x2BE4B48 VA: 0x2BE8B48
	|-PropertyBag<Vector4>..ctor
	|
	|-RVA: 0x2BE8F8C Offset: 0x2BE4F8C VA: 0x2BE8F8C
	|-PropertyBag<__Il2CppFullySharedGenericType>..ctor
	*/
}
