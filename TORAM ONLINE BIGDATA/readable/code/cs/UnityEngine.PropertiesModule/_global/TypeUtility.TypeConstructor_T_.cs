// Assembly: UnityEngine.PropertiesModule.dll
// Namespace: 
private class TypeUtility.TypeConstructor<T> : TypeUtility.ITypeConstructor<T>, TypeUtility.ITypeConstructor // TypeDefIndex: 17366
{
	// Fields
	private Func<T> m_ExplicitConstructor; // 0x0
	private Func<T> m_ImplicitConstructor; // 0x0
	private IConstructor<T> m_OverrideConstructor; // 0x0

	// Properties
	private bool Unity.Properties.TypeUtility.ITypeConstructor.CanBeInstantiated { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 6
	private bool Unity.Properties.TypeUtility.ITypeConstructor.get_CanBeInstantiated() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CC9038 Offset: 0x2CC5038 VA: 0x2CC9038
	|-TypeUtility.TypeConstructor<Bounds>.Unity.Properties.TypeUtility.ITypeConstructor.get_CanBeInstantiated
	|
	|-RVA: 0x2CC9960 Offset: 0x2CC5960 VA: 0x2CC9960
	|-TypeUtility.TypeConstructor<BoundsInt>.Unity.Properties.TypeUtility.ITypeConstructor.get_CanBeInstantiated
	|
	|-RVA: 0x2CCA288 Offset: 0x2CC6288 VA: 0x2CCA288
	|-TypeUtility.TypeConstructor<Color>.Unity.Properties.TypeUtility.ITypeConstructor.get_CanBeInstantiated
	|
	|-RVA: 0x2CCAB38 Offset: 0x2CC6B38 VA: 0x2CCAB38
	|-TypeUtility.TypeConstructor<object>.Unity.Properties.TypeUtility.ITypeConstructor.get_CanBeInstantiated
	|
	|-RVA: 0x2CCB39C Offset: 0x2CC739C VA: 0x2CCB39C
	|-TypeUtility.TypeConstructor<Rect>.Unity.Properties.TypeUtility.ITypeConstructor.get_CanBeInstantiated
	|
	|-RVA: 0x2CCBC4C Offset: 0x2CC7C4C VA: 0x2CCBC4C
	|-TypeUtility.TypeConstructor<RectInt>.Unity.Properties.TypeUtility.ITypeConstructor.get_CanBeInstantiated
	|
	|-RVA: 0x2CCC4F0 Offset: 0x2CC84F0 VA: 0x2CCC4F0
	|-TypeUtility.TypeConstructor<Vector2>.Unity.Properties.TypeUtility.ITypeConstructor.get_CanBeInstantiated
	|
	|-RVA: 0x2CCCD88 Offset: 0x2CC8D88 VA: 0x2CCCD88
	|-TypeUtility.TypeConstructor<Vector2Int>.Unity.Properties.TypeUtility.ITypeConstructor.get_CanBeInstantiated
	|
	|-RVA: 0x2CCD61C Offset: 0x2CC961C VA: 0x2CCD61C
	|-TypeUtility.TypeConstructor<Vector3>.Unity.Properties.TypeUtility.ITypeConstructor.get_CanBeInstantiated
	|
	|-RVA: 0x2CCDEC8 Offset: 0x2CC9EC8 VA: 0x2CCDEC8
	|-TypeUtility.TypeConstructor<Vector3Int>.Unity.Properties.TypeUtility.ITypeConstructor.get_CanBeInstantiated
	|
	|-RVA: 0x2CCE788 Offset: 0x2CCA788 VA: 0x2CCE788
	|-TypeUtility.TypeConstructor<Vector4>.Unity.Properties.TypeUtility.ITypeConstructor.get_CanBeInstantiated
	|
	|-RVA: 0x2CCF038 Offset: 0x2CCB038 VA: 0x2CCF038
	|-TypeUtility.TypeConstructor<__Il2CppFullySharedGenericType>.Unity.Properties.TypeUtility.ITypeConstructor.get_CanBeInstantiated
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CC9170 Offset: 0x2CC5170 VA: 0x2CC9170
	|-TypeUtility.TypeConstructor<Bounds>..ctor
	|
	|-RVA: 0x2CC9A98 Offset: 0x2CC5A98 VA: 0x2CC9A98
	|-TypeUtility.TypeConstructor<BoundsInt>..ctor
	|
	|-RVA: 0x2CCA3C0 Offset: 0x2CC63C0 VA: 0x2CCA3C0
	|-TypeUtility.TypeConstructor<Color>..ctor
	|
	|-RVA: 0x2CCAC70 Offset: 0x2CC6C70 VA: 0x2CCAC70
	|-TypeUtility.TypeConstructor<object>..ctor
	|
	|-RVA: 0x2CCB4D4 Offset: 0x2CC74D4 VA: 0x2CCB4D4
	|-TypeUtility.TypeConstructor<Rect>..ctor
	|
	|-RVA: 0x2CCBD84 Offset: 0x2CC7D84 VA: 0x2CCBD84
	|-TypeUtility.TypeConstructor<RectInt>..ctor
	|
	|-RVA: 0x2CCC628 Offset: 0x2CC8628 VA: 0x2CCC628
	|-TypeUtility.TypeConstructor<Vector2>..ctor
	|
	|-RVA: 0x2CCCEC0 Offset: 0x2CC8EC0 VA: 0x2CCCEC0
	|-TypeUtility.TypeConstructor<Vector2Int>..ctor
	|
	|-RVA: 0x2CCD754 Offset: 0x2CC9754 VA: 0x2CCD754
	|-TypeUtility.TypeConstructor<Vector3>..ctor
	|
	|-RVA: 0x2CCE000 Offset: 0x2CCA000 VA: 0x2CCE000
	|-TypeUtility.TypeConstructor<Vector3Int>..ctor
	|
	|-RVA: 0x2CCE8C0 Offset: 0x2CCA8C0 VA: 0x2CCE8C0
	|-TypeUtility.TypeConstructor<Vector4>..ctor
	|
	|-RVA: 0x2CCF170 Offset: 0x2CCB170 VA: 0x2CCF170
	|-TypeUtility.TypeConstructor<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	private void SetImplicitConstructor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CC9260 Offset: 0x2CC5260 VA: 0x2CC9260
	|-TypeUtility.TypeConstructor<Bounds>.SetImplicitConstructor
	|
	|-RVA: 0x2CC9B88 Offset: 0x2CC5B88 VA: 0x2CC9B88
	|-TypeUtility.TypeConstructor<BoundsInt>.SetImplicitConstructor
	|
	|-RVA: 0x2CCA4B0 Offset: 0x2CC64B0 VA: 0x2CCA4B0
	|-TypeUtility.TypeConstructor<Color>.SetImplicitConstructor
	|
	|-RVA: 0x2CCAD60 Offset: 0x2CC6D60 VA: 0x2CCAD60
	|-TypeUtility.TypeConstructor<object>.SetImplicitConstructor
	|
	|-RVA: 0x2CCB5C4 Offset: 0x2CC75C4 VA: 0x2CCB5C4
	|-TypeUtility.TypeConstructor<Rect>.SetImplicitConstructor
	|
	|-RVA: 0x2CCBE74 Offset: 0x2CC7E74 VA: 0x2CCBE74
	|-TypeUtility.TypeConstructor<RectInt>.SetImplicitConstructor
	|
	|-RVA: 0x2CCC718 Offset: 0x2CC8718 VA: 0x2CCC718
	|-TypeUtility.TypeConstructor<Vector2>.SetImplicitConstructor
	|
	|-RVA: 0x2CCCFB0 Offset: 0x2CC8FB0 VA: 0x2CCCFB0
	|-TypeUtility.TypeConstructor<Vector2Int>.SetImplicitConstructor
	|
	|-RVA: 0x2CCD844 Offset: 0x2CC9844 VA: 0x2CCD844
	|-TypeUtility.TypeConstructor<Vector3>.SetImplicitConstructor
	|
	|-RVA: 0x2CCE0F0 Offset: 0x2CCA0F0 VA: 0x2CCE0F0
	|-TypeUtility.TypeConstructor<Vector3Int>.SetImplicitConstructor
	|
	|-RVA: 0x2CCE9B0 Offset: 0x2CCA9B0 VA: 0x2CCE9B0
	|-TypeUtility.TypeConstructor<Vector4>.SetImplicitConstructor
	|
	|-RVA: 0x2CCF268 Offset: 0x2CCB268 VA: 0x2CCF268
	|-TypeUtility.TypeConstructor<__Il2CppFullySharedGenericType>.SetImplicitConstructor
	*/

	// RVA: -1 Offset: -1
	private static T CreateValueTypeInstance() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CC94A8 Offset: 0x2CC54A8 VA: 0x2CC94A8
	|-TypeUtility.TypeConstructor<Bounds>.CreateValueTypeInstance
	|
	|-RVA: 0x2CC9DD0 Offset: 0x2CC5DD0 VA: 0x2CC9DD0
	|-TypeUtility.TypeConstructor<BoundsInt>.CreateValueTypeInstance
	|
	|-RVA: 0x2CCA6F8 Offset: 0x2CC66F8 VA: 0x2CCA6F8
	|-TypeUtility.TypeConstructor<Color>.CreateValueTypeInstance
	|
	|-RVA: 0x2CCAFA8 Offset: 0x2CC6FA8 VA: 0x2CCAFA8
	|-TypeUtility.TypeConstructor<object>.CreateValueTypeInstance
	|
	|-RVA: 0x2CCB80C Offset: 0x2CC780C VA: 0x2CCB80C
	|-TypeUtility.TypeConstructor<Rect>.CreateValueTypeInstance
	|
	|-RVA: 0x2CCC0BC Offset: 0x2CC80BC VA: 0x2CCC0BC
	|-TypeUtility.TypeConstructor<RectInt>.CreateValueTypeInstance
	|
	|-RVA: 0x2CCC960 Offset: 0x2CC8960 VA: 0x2CCC960
	|-TypeUtility.TypeConstructor<Vector2>.CreateValueTypeInstance
	|
	|-RVA: 0x2CCD1F8 Offset: 0x2CC91F8 VA: 0x2CCD1F8
	|-TypeUtility.TypeConstructor<Vector2Int>.CreateValueTypeInstance
	|
	|-RVA: 0x2CCDA8C Offset: 0x2CC9A8C VA: 0x2CCDA8C
	|-TypeUtility.TypeConstructor<Vector3>.CreateValueTypeInstance
	|
	|-RVA: 0x2CCE338 Offset: 0x2CCA338 VA: 0x2CCE338
	|-TypeUtility.TypeConstructor<Vector3Int>.CreateValueTypeInstance
	|
	|-RVA: 0x2CCEBF8 Offset: 0x2CCABF8 VA: 0x2CCEBF8
	|-TypeUtility.TypeConstructor<Vector4>.CreateValueTypeInstance
	|
	|-RVA: 0x2CCF4C4 Offset: 0x2CCB4C4 VA: 0x2CCF4C4
	|-TypeUtility.TypeConstructor<__Il2CppFullySharedGenericType>.CreateValueTypeInstance
	*/

	// RVA: -1 Offset: -1
	private static T CreateScriptableObjectInstance() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CC94B4 Offset: 0x2CC54B4 VA: 0x2CC94B4
	|-TypeUtility.TypeConstructor<Bounds>.CreateScriptableObjectInstance
	|
	|-RVA: 0x2CC9DDC Offset: 0x2CC5DDC VA: 0x2CC9DDC
	|-TypeUtility.TypeConstructor<BoundsInt>.CreateScriptableObjectInstance
	|
	|-RVA: 0x2CCA70C Offset: 0x2CC670C VA: 0x2CCA70C
	|-TypeUtility.TypeConstructor<Color>.CreateScriptableObjectInstance
	|
	|-RVA: 0x2CCAFB0 Offset: 0x2CC6FB0 VA: 0x2CCAFB0
	|-TypeUtility.TypeConstructor<object>.CreateScriptableObjectInstance
	|
	|-RVA: 0x2CCB820 Offset: 0x2CC7820 VA: 0x2CCB820
	|-TypeUtility.TypeConstructor<Rect>.CreateScriptableObjectInstance
	|
	|-RVA: 0x2CCC0C8 Offset: 0x2CC80C8 VA: 0x2CCC0C8
	|-TypeUtility.TypeConstructor<RectInt>.CreateScriptableObjectInstance
	|
	|-RVA: 0x2CCC96C Offset: 0x2CC896C VA: 0x2CCC96C
	|-TypeUtility.TypeConstructor<Vector2>.CreateScriptableObjectInstance
	|
	|-RVA: 0x2CCD200 Offset: 0x2CC9200 VA: 0x2CCD200
	|-TypeUtility.TypeConstructor<Vector2Int>.CreateScriptableObjectInstance
	|
	|-RVA: 0x2CCDA9C Offset: 0x2CC9A9C VA: 0x2CCDA9C
	|-TypeUtility.TypeConstructor<Vector3>.CreateScriptableObjectInstance
	|
	|-RVA: 0x2CCE344 Offset: 0x2CCA344 VA: 0x2CCE344
	|-TypeUtility.TypeConstructor<Vector3Int>.CreateScriptableObjectInstance
	|
	|-RVA: 0x2CCEC0C Offset: 0x2CCAC0C VA: 0x2CCEC0C
	|-TypeUtility.TypeConstructor<Vector4>.CreateScriptableObjectInstance
	|
	|-RVA: 0x2CCF5D8 Offset: 0x2CCB5D8 VA: 0x2CCF5D8
	|-TypeUtility.TypeConstructor<__Il2CppFullySharedGenericType>.CreateScriptableObjectInstance
	*/

	// RVA: -1 Offset: -1
	private static T CreateClassInstance() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CC95A8 Offset: 0x2CC55A8 VA: 0x2CC95A8
	|-TypeUtility.TypeConstructor<Bounds>.CreateClassInstance
	|
	|-RVA: 0x2CC9ED0 Offset: 0x2CC5ED0 VA: 0x2CC9ED0
	|-TypeUtility.TypeConstructor<BoundsInt>.CreateClassInstance
	|
	|-RVA: 0x2CCA7F4 Offset: 0x2CC67F4 VA: 0x2CCA7F4
	|-TypeUtility.TypeConstructor<Color>.CreateClassInstance
	|
	|-RVA: 0x2CCB08C Offset: 0x2CC708C VA: 0x2CCB08C
	|-TypeUtility.TypeConstructor<object>.CreateClassInstance
	|
	|-RVA: 0x2CCB908 Offset: 0x2CC7908 VA: 0x2CCB908
	|-TypeUtility.TypeConstructor<Rect>.CreateClassInstance
	|
	|-RVA: 0x2CCC1B0 Offset: 0x2CC81B0 VA: 0x2CCC1B0
	|-TypeUtility.TypeConstructor<RectInt>.CreateClassInstance
	|
	|-RVA: 0x2CCCA50 Offset: 0x2CC8A50 VA: 0x2CCCA50
	|-TypeUtility.TypeConstructor<Vector2>.CreateClassInstance
	|
	|-RVA: 0x2CCD2E4 Offset: 0x2CC92E4 VA: 0x2CCD2E4
	|-TypeUtility.TypeConstructor<Vector2Int>.CreateClassInstance
	|
	|-RVA: 0x2CCDB84 Offset: 0x2CC9B84 VA: 0x2CCDB84
	|-TypeUtility.TypeConstructor<Vector3>.CreateClassInstance
	|
	|-RVA: 0x2CCE430 Offset: 0x2CCA430 VA: 0x2CCE430
	|-TypeUtility.TypeConstructor<Vector3Int>.CreateClassInstance
	|
	|-RVA: 0x2CCECF4 Offset: 0x2CCACF4 VA: 0x2CCECF4
	|-TypeUtility.TypeConstructor<Vector4>.CreateClassInstance
	|
	|-RVA: 0x2CCF780 Offset: 0x2CCB780 VA: 0x2CCF780
	|-TypeUtility.TypeConstructor<__Il2CppFullySharedGenericType>.CreateClassInstance
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void SetExplicitConstructor(Func<T> constructor) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CC95F8 Offset: 0x2CC55F8 VA: 0x2CC95F8
	|-TypeUtility.TypeConstructor<Bounds>.SetExplicitConstructor
	|
	|-RVA: 0x2CC9F20 Offset: 0x2CC5F20 VA: 0x2CC9F20
	|-TypeUtility.TypeConstructor<BoundsInt>.SetExplicitConstructor
	|
	|-RVA: 0x2CCA818 Offset: 0x2CC6818 VA: 0x2CCA818
	|-TypeUtility.TypeConstructor<Color>.SetExplicitConstructor
	|
	|-RVA: 0x2CCB0B0 Offset: 0x2CC70B0 VA: 0x2CCB0B0
	|-TypeUtility.TypeConstructor<object>.SetExplicitConstructor
	|
	|-RVA: 0x2CCB92C Offset: 0x2CC792C VA: 0x2CCB92C
	|-TypeUtility.TypeConstructor<Rect>.SetExplicitConstructor
	|
	|-RVA: 0x2CCC1D4 Offset: 0x2CC81D4 VA: 0x2CCC1D4
	|-TypeUtility.TypeConstructor<RectInt>.SetExplicitConstructor
	|
	|-RVA: 0x2CCCA74 Offset: 0x2CC8A74 VA: 0x2CCCA74
	|-TypeUtility.TypeConstructor<Vector2>.SetExplicitConstructor
	|
	|-RVA: 0x2CCD308 Offset: 0x2CC9308 VA: 0x2CCD308
	|-TypeUtility.TypeConstructor<Vector2Int>.SetExplicitConstructor
	|
	|-RVA: 0x2CCDBA8 Offset: 0x2CC9BA8 VA: 0x2CCDBA8
	|-TypeUtility.TypeConstructor<Vector3>.SetExplicitConstructor
	|
	|-RVA: 0x2CCE45C Offset: 0x2CCA45C VA: 0x2CCE45C
	|-TypeUtility.TypeConstructor<Vector3Int>.SetExplicitConstructor
	|
	|-RVA: 0x2CCED18 Offset: 0x2CCAD18 VA: 0x2CCED18
	|-TypeUtility.TypeConstructor<Vector4>.SetExplicitConstructor
	|
	|-RVA: 0x2CCF8D8 Offset: 0x2CCB8D8 VA: 0x2CCF8D8
	|-TypeUtility.TypeConstructor<__Il2CppFullySharedGenericType>.SetExplicitConstructor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private T Unity.Properties.TypeUtility.ITypeConstructor<T>.Instantiate() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CC9600 Offset: 0x2CC5600 VA: 0x2CC9600
	|-TypeUtility.TypeConstructor<Bounds>.Unity.Properties.TypeUtility.ITypeConstructor<T>.Instantiate
	|
	|-RVA: 0x2CC9F28 Offset: 0x2CC5F28 VA: 0x2CC9F28
	|-TypeUtility.TypeConstructor<BoundsInt>.Unity.Properties.TypeUtility.ITypeConstructor<T>.Instantiate
	|
	|-RVA: 0x2CCA820 Offset: 0x2CC6820 VA: 0x2CCA820
	|-TypeUtility.TypeConstructor<Color>.Unity.Properties.TypeUtility.ITypeConstructor<T>.Instantiate
	|
	|-RVA: 0x2CCB0B8 Offset: 0x2CC70B8 VA: 0x2CCB0B8
	|-TypeUtility.TypeConstructor<object>.Unity.Properties.TypeUtility.ITypeConstructor<T>.Instantiate
	|
	|-RVA: 0x2CCB934 Offset: 0x2CC7934 VA: 0x2CCB934
	|-TypeUtility.TypeConstructor<Rect>.Unity.Properties.TypeUtility.ITypeConstructor<T>.Instantiate
	|
	|-RVA: 0x2CCC1DC Offset: 0x2CC81DC VA: 0x2CCC1DC
	|-TypeUtility.TypeConstructor<RectInt>.Unity.Properties.TypeUtility.ITypeConstructor<T>.Instantiate
	|
	|-RVA: 0x2CCCA7C Offset: 0x2CC8A7C VA: 0x2CCCA7C
	|-TypeUtility.TypeConstructor<Vector2>.Unity.Properties.TypeUtility.ITypeConstructor<T>.Instantiate
	|
	|-RVA: 0x2CCD310 Offset: 0x2CC9310 VA: 0x2CCD310
	|-TypeUtility.TypeConstructor<Vector2Int>.Unity.Properties.TypeUtility.ITypeConstructor<T>.Instantiate
	|
	|-RVA: 0x2CCDBB0 Offset: 0x2CC9BB0 VA: 0x2CCDBB0
	|-TypeUtility.TypeConstructor<Vector3>.Unity.Properties.TypeUtility.ITypeConstructor<T>.Instantiate
	|
	|-RVA: 0x2CCE464 Offset: 0x2CCA464 VA: 0x2CCE464
	|-TypeUtility.TypeConstructor<Vector3Int>.Unity.Properties.TypeUtility.ITypeConstructor<T>.Instantiate
	|
	|-RVA: 0x2CCED20 Offset: 0x2CCAD20 VA: 0x2CCED20
	|-TypeUtility.TypeConstructor<Vector4>.Unity.Properties.TypeUtility.ITypeConstructor<T>.Instantiate
	|
	|-RVA: 0x2CCF8E0 Offset: 0x2CCB8E0 VA: 0x2CCF8E0
	|-TypeUtility.TypeConstructor<__Il2CppFullySharedGenericType>.Unity.Properties.TypeUtility.ITypeConstructor<T>.Instantiate
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object Unity.Properties.TypeUtility.ITypeConstructor.Instantiate() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CC9890 Offset: 0x2CC5890 VA: 0x2CC9890
	|-TypeUtility.TypeConstructor<Bounds>.Unity.Properties.TypeUtility.ITypeConstructor.Instantiate
	|
	|-RVA: 0x2CCA1B8 Offset: 0x2CC61B8 VA: 0x2CCA1B8
	|-TypeUtility.TypeConstructor<BoundsInt>.Unity.Properties.TypeUtility.ITypeConstructor.Instantiate
	|
	|-RVA: 0x2CCAA7C Offset: 0x2CC6A7C VA: 0x2CCAA7C
	|-TypeUtility.TypeConstructor<Color>.Unity.Properties.TypeUtility.ITypeConstructor.Instantiate
	|
	|-RVA: 0x2CCB314 Offset: 0x2CC7314 VA: 0x2CCB314
	|-TypeUtility.TypeConstructor<object>.Unity.Properties.TypeUtility.ITypeConstructor.Instantiate
	|
	|-RVA: 0x2CCBB90 Offset: 0x2CC7B90 VA: 0x2CCBB90
	|-TypeUtility.TypeConstructor<Rect>.Unity.Properties.TypeUtility.ITypeConstructor.Instantiate
	|
	|-RVA: 0x2CCC438 Offset: 0x2CC8438 VA: 0x2CCC438
	|-TypeUtility.TypeConstructor<RectInt>.Unity.Properties.TypeUtility.ITypeConstructor.Instantiate
	|
	|-RVA: 0x2CCCCD8 Offset: 0x2CC8CD8 VA: 0x2CCCCD8
	|-TypeUtility.TypeConstructor<Vector2>.Unity.Properties.TypeUtility.ITypeConstructor.Instantiate
	|
	|-RVA: 0x2CCD56C Offset: 0x2CC956C VA: 0x2CCD56C
	|-TypeUtility.TypeConstructor<Vector2Int>.Unity.Properties.TypeUtility.ITypeConstructor.Instantiate
	|
	|-RVA: 0x2CCDE0C Offset: 0x2CC9E0C VA: 0x2CCDE0C
	|-TypeUtility.TypeConstructor<Vector3>.Unity.Properties.TypeUtility.ITypeConstructor.Instantiate
	|
	|-RVA: 0x2CCE6CC Offset: 0x2CCA6CC VA: 0x2CCE6CC
	|-TypeUtility.TypeConstructor<Vector3Int>.Unity.Properties.TypeUtility.ITypeConstructor.Instantiate
	|
	|-RVA: 0x2CCEF7C Offset: 0x2CCAF7C VA: 0x2CCEF7C
	|-TypeUtility.TypeConstructor<Vector4>.Unity.Properties.TypeUtility.ITypeConstructor.Instantiate
	|
	|-RVA: 0x2CCFC20 Offset: 0x2CCBC20 VA: 0x2CCFC20
	|-TypeUtility.TypeConstructor<__Il2CppFullySharedGenericType>.Unity.Properties.TypeUtility.ITypeConstructor.Instantiate
	*/
}
