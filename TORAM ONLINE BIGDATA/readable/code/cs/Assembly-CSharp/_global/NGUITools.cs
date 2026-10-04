// Assembly: Assembly-CSharp.dll
// Namespace: 
public static class NGUITools // TypeDefIndex: 76
{
	// Fields
	private static AudioListener mListener; // 0x0
	private static bool mLoaded; // 0x8
	private static float mGlobalVolume; // 0xC
	private static Color mInvisible; // 0x10
	private static PropertyInfo mSystemCopyBuffer; // 0x20

	// Properties
	public static float soundVolume { get; set; }
	public static bool fileAccess { get; }
	public static string clipboard { get; set; }

	// Methods

	// RVA: 0x172619C Offset: 0x172219C VA: 0x172619C
	public static float get_soundVolume() { }

	// RVA: 0x17263E8 Offset: 0x17223E8 VA: 0x17263E8
	public static void set_soundVolume(float value) { }

	// RVA: 0x172F1E4 Offset: 0x172B1E4 VA: 0x172F1E4
	public static bool get_fileAccess() { }

	// RVA: 0x172F1EC Offset: 0x172B1EC VA: 0x172F1EC
	public static AudioSource PlaySound(AudioClip clip) { }

	// RVA: 0x172F72C Offset: 0x172B72C VA: 0x172F72C
	public static AudioSource PlaySound(AudioClip clip, float volume) { }

	// RVA: 0x172F248 Offset: 0x172B248 VA: 0x172F248
	public static AudioSource PlaySound(AudioClip clip, float volume, float pitch) { }

	// RVA: 0x172F794 Offset: 0x172B794 VA: 0x172F794
	public static WWW OpenURL(string url) { }

	// RVA: 0x172F888 Offset: 0x172B888 VA: 0x172F888
	public static WWW OpenURL(string url, WWWForm form) { }

	// RVA: 0x172F9C8 Offset: 0x172B9C8 VA: 0x172F9C8
	public static int RandomRange(int min, int max) { }

	// RVA: 0x172F9E0 Offset: 0x172B9E0 VA: 0x172F9E0
	public static string GetHierarchy(GameObject obj) { }

	// RVA: 0x172FAF4 Offset: 0x172BAF4 VA: 0x172FAF4
	public static Color ParseColor(string text, int offset) { }

	// RVA: 0x172FBCC Offset: 0x172BBCC VA: 0x172FBCC
	public static string EncodeColor(Color c) { }

	// RVA: 0x172FBE0 Offset: 0x172BBE0 VA: 0x172FBE0
	public static int ParseSymbol(string text, int index, List<Color> colors, bool premultiply) { }

	// RVA: 0x172FE84 Offset: 0x172BE84 VA: 0x172FE84
	public static string StripSymbols(string text) { }

	// RVA: -1 Offset: -1
	public static T[] FindActive<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26DC654 Offset: 0x26D8654 VA: 0x26DC654
	|-NGUITools.FindActive<object>
	*/

	// RVA: 0x172FF64 Offset: 0x172BF64 VA: 0x172FF64
	public static Camera FindCameraForLayer(int layer) { }

	// RVA: 0x1730044 Offset: 0x172C044 VA: 0x1730044
	public static BoxCollider AddWidgetCollider(GameObject go) { }

	// RVA: 0x173009C Offset: 0x172C09C VA: 0x173009C
	public static BoxCollider AddWidgetCollider(GameObject go, bool considerInactive) { }

	// RVA: 0x1730478 Offset: 0x172C478 VA: 0x1730478
	public static void UpdateWidgetCollider(GameObject go) { }

	// RVA: 0x17304D0 Offset: 0x172C4D0 VA: 0x17304D0
	public static void UpdateWidgetCollider(GameObject go, bool considerInactive) { }

	// RVA: 0x17305B0 Offset: 0x172C5B0 VA: 0x17305B0
	public static void UpdateWidgetCollider(BoxCollider bc) { }

	// RVA: 0x1730608 Offset: 0x172C608 VA: 0x1730608
	public static void UpdateWidgetCollider(BoxCollider collider, bool considerInactive) { }

	// RVA: 0x1730298 Offset: 0x172C298 VA: 0x1730298
	public static void UpdateWidgetCollider(BoxCollider box, bool considerInactive, bool updateSize) { }

	// RVA: -1 Offset: -1
	public static string GetName<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26DC870 Offset: 0x26D8870 VA: 0x26DC870
	|-NGUITools.GetName<object>
	*/

	// RVA: 0x1730814 Offset: 0x172C814 VA: 0x1730814
	public static GameObject AddChild(GameObject parent) { }

	// RVA: 0x17309C8 Offset: 0x172C9C8 VA: 0x17309C8
	public static GameObject AddChild(GameObject parent, GameObject prefab) { }

	// RVA: 0x1730B9C Offset: 0x172CB9C VA: 0x1730B9C
	public static int CalculateNextDepth(GameObject go) { }

	// RVA: 0x1730670 Offset: 0x172C670 VA: 0x1730670
	public static int CalculateNextDepth(GameObject go, bool ignoreChildrenWithColliders) { }

	// RVA: 0x1730CCC Offset: 0x172CCCC VA: 0x1730CCC
	public static void AdjustDepth(GameObject go, int adjustment) { }

	// RVA: 0x1730E2C Offset: 0x172CE2C VA: 0x1730E2C
	public static void BringForward(GameObject go) { }

	// RVA: 0x1731334 Offset: 0x172D334 VA: 0x1731334
	public static void PushBack(GameObject go) { }

	// RVA: 0x1730E8C Offset: 0x172CE8C VA: 0x1730E8C
	public static void NormalizeDepths() { }

	// RVA: 0x1731228 Offset: 0x172D228 VA: 0x1731228
	public static void UpdateWidgetColliderDepth() { }

	// RVA: 0x1731394 Offset: 0x172D394 VA: 0x1731394
	public static void UpdateWidgetColliderDepth(GameObject go) { }

	// RVA: -1 Offset: -1
	public static T AddChild<T>(GameObject parent) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26DC4D0 Offset: 0x26D84D0 VA: 0x26DC4D0
	|-NGUITools.AddChild<object>
	*/

	// RVA: -1 Offset: -1
	public static T AddWidget<T>(GameObject go) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26DC56C Offset: 0x26D856C VA: 0x26DC56C
	|-NGUITools.AddWidget<object>
	*/

	// RVA: 0x1731468 Offset: 0x172D468 VA: 0x1731468
	public static UISprite AddSprite(GameObject go, UIAtlas atlas, string spriteName) { }

	// RVA: 0x17315A0 Offset: 0x172D5A0 VA: 0x17315A0
	public static GameObject GetRoot(GameObject go) { }

	// RVA: -1 Offset: -1
	public static T FindInParents<T>(GameObject go) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26DC718 Offset: 0x26D8718 VA: 0x26DC718
	|-NGUITools.FindInParents<object>
	*/

	// RVA: 0x1731640 Offset: 0x172D640 VA: 0x1731640
	public static void Destroy(Object obj) { }

	// RVA: 0x1731764 Offset: 0x172D764 VA: 0x1731764
	public static void DestroyImmediate(Object obj) { }

	// RVA: 0x1731830 Offset: 0x172D830 VA: 0x1731830
	public static void Broadcast(string funcName) { }

	// RVA: 0x1731958 Offset: 0x172D958 VA: 0x1731958
	public static void Broadcast(string funcName, object param) { }

	// RVA: 0x1731A88 Offset: 0x172DA88 VA: 0x1731A88
	public static bool IsChild(Transform parent, Transform child) { }

	// RVA: 0x1731B8C Offset: 0x172DB8C VA: 0x1731B8C
	private static void Activate(Transform t) { }

	// RVA: 0x1731CD8 Offset: 0x172DCD8 VA: 0x1731CD8
	private static void Deactivate(Transform t) { }

	// RVA: 0x17280FC Offset: 0x17240FC VA: 0x17280FC
	public static void SetActive(GameObject go, bool state) { }

	// RVA: 0x1731D54 Offset: 0x172DD54 VA: 0x1731D54
	public static void SetActiveChildren(GameObject go, bool state) { }

	// RVA: 0x1726798 Offset: 0x1722798 VA: 0x1726798
	public static bool GetActive(GameObject go) { }

	// RVA: 0x1731CC0 Offset: 0x172DCC0 VA: 0x1731CC0
	public static void SetActiveSelf(GameObject go, bool state) { }

	// RVA: 0x1731E64 Offset: 0x172DE64 VA: 0x1731E64
	public static void SetLayer(GameObject go, int layer) { }

	// RVA: 0x1731F48 Offset: 0x172DF48 VA: 0x1731F48
	public static Vector3 Round(Vector3 v) { }

	// RVA: 0x17320DC Offset: 0x172E0DC VA: 0x17320DC
	public static void MakePixelPerfect(Transform t) { }

	// RVA: 0x1732320 Offset: 0x172E320 VA: 0x1732320
	public static bool Save(string fileName, byte[] bytes) { }

	// RVA: 0x17324F4 Offset: 0x172E4F4 VA: 0x17324F4
	public static byte[] Load(string fileName) { }

	// RVA: 0x17325BC Offset: 0x172E5BC VA: 0x17325BC
	public static Color ApplyPMA(Color c) { }

	// RVA: 0x17325E0 Offset: 0x172E5E0 VA: 0x17325E0
	public static void MarkParentAsChanged(GameObject go) { }

	// RVA: 0x173276C Offset: 0x172E76C VA: 0x173276C
	private static PropertyInfo GetSystemCopyBufferProperty() { }

	// RVA: 0x1732890 Offset: 0x172E890 VA: 0x1732890
	public static string get_clipboard() { }

	// RVA: 0x173294C Offset: 0x172E94C VA: 0x173294C
	public static void set_clipboard(string value) { }

	// RVA: 0x17329E4 Offset: 0x172E9E4 VA: 0x17329E4
	private static void .cctor() { }
}
