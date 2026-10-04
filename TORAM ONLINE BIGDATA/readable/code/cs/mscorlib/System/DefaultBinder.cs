// Assembly: mscorlib.dll
// Namespace: System
[Serializable]
internal class DefaultBinder : Binder // TypeDefIndex: 9748
{
	// Fields
	private static DefaultBinder.Primitives[] _primitiveConversions; // 0x0

	// Methods

	// RVA: 0x30125EC Offset: 0x300E5EC VA: 0x30125EC Slot: 5
	public override MethodBase BindToMethod(BindingFlags bindingAttr, MethodBase[] match, ref object[] args, ParameterModifier[] modifiers, CultureInfo cultureInfo, string[] names, out object state) { }

	// RVA: 0x3014CA8 Offset: 0x3010CA8 VA: 0x3014CA8 Slot: 4
	public override FieldInfo BindToField(BindingFlags bindingAttr, FieldInfo[] match, object value, CultureInfo cultureInfo) { }

	// RVA: 0x3015238 Offset: 0x3011238 VA: 0x3015238 Slot: 9
	public override PropertyInfo SelectProperty(BindingFlags bindingAttr, PropertyInfo[] match, Type returnType, Type[] indexes, ParameterModifier[] modifiers) { }

	// RVA: 0x301673C Offset: 0x301273C VA: 0x301673C Slot: 6
	public override object ChangeType(object value, Type type, CultureInfo cultureInfo) { }

	// RVA: 0x3016794 Offset: 0x3012794 VA: 0x3016794 Slot: 7
	public override void ReorderArgumentArray(ref object[] args, object state) { }

	// RVA: 0x3016AA8 Offset: 0x3012AA8 VA: 0x3016AA8
	public static MethodBase ExactBinding(MethodBase[] match, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x3016E58 Offset: 0x3012E58 VA: 0x3016E58
	public static PropertyInfo ExactPropertyBinding(PropertyInfo[] match, Type returnType, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x3016204 Offset: 0x3012204 VA: 0x3016204
	private static int FindMostSpecific(ParameterInfo[] p1, int[] paramOrder1, Type paramArrayType1, ParameterInfo[] p2, int[] paramOrder2, Type paramArrayType2, Type[] types, object[] args) { }

	// RVA: 0x3015E68 Offset: 0x3011E68 VA: 0x3015E68
	private static int FindMostSpecificType(Type c1, Type c2, Type t) { }

	// RVA: 0x3014B28 Offset: 0x3010B28 VA: 0x3014B28
	private static int FindMostSpecificMethod(MethodBase m1, int[] paramOrder1, Type paramArrayType1, MethodBase m2, int[] paramOrder2, Type paramArrayType2, Type[] types, object[] args) { }

	// RVA: 0x3015150 Offset: 0x3011150 VA: 0x3015150
	private static int FindMostSpecificField(FieldInfo cur1, FieldInfo cur2) { }

	// RVA: 0x3016654 Offset: 0x3012654 VA: 0x3016654
	private static int FindMostSpecificProperty(PropertyInfo cur1, PropertyInfo cur2) { }

	// RVA: 0x30170F0 Offset: 0x30130F0 VA: 0x30170F0
	internal static bool CompareMethodSigAndName(MethodBase m1, MethodBase m2) { }

	// RVA: 0x3017258 Offset: 0x3013258 VA: 0x3017258
	internal static int GetHierarchyDepth(Type t) { }

	// RVA: 0x3016D10 Offset: 0x3012D10 VA: 0x3016D10
	internal static MethodBase FindMostDerivedNewSlotMeth(MethodBase[] match, int cMatches) { }

	// RVA: 0x30149A4 Offset: 0x30109A4 VA: 0x30149A4
	private static void ReorderParams(int[] paramOrder, object[] vars) { }

	// RVA: 0x3014610 Offset: 0x3010610 VA: 0x3014610
	private static bool CreateParamOrder(int[] paramOrder, ParameterInfo[] pars, string[] names) { }

	// RVA: 0x3015C44 Offset: 0x3011C44 VA: 0x3015C44
	private static bool CanConvertPrimitive(RuntimeType source, RuntimeType target) { }

	// RVA: 0x3014848 Offset: 0x3010848 VA: 0x3014848
	private static bool CanConvertPrimitiveObjectToType(object source, RuntimeType type) { }

	// RVA: 0x30172EC Offset: 0x30132EC VA: 0x30172EC
	internal static bool CompareMethodSig(MethodBase m1, MethodBase m2) { }

	// RVA: 0x3017454 Offset: 0x3013454 VA: 0x3017454 Slot: 8
	public sealed override MethodBase SelectMethod(BindingFlags bindingAttr, MethodBase[] match, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x3017B90 Offset: 0x3013B90 VA: 0x3017B90
	private static bool CanChangePrimitive(Type source, Type target) { }

	// RVA: 0x3017BF4 Offset: 0x3013BF4 VA: 0x3017BF4
	private static bool CanPrimitiveWiden(Type source, Type target) { }

	// RVA: 0x3017CC4 Offset: 0x3013CC4 VA: 0x3017CC4
	public void .ctor() { }

	// RVA: 0x3017CCC Offset: 0x3013CCC VA: 0x3017CCC
	private static void .cctor() { }
}
