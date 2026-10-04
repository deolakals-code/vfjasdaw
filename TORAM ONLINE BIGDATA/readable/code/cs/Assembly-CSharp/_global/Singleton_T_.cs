// Assembly: Assembly-CSharp.dll
// Namespace: 
public class Singleton<T> : MonoBehaviour // TypeDefIndex: 5577
{
	// Fields
	protected static T instance; // 0x0

	// Properties
	public static T Instance { get; }

	// Methods

	// RVA: -1 Offset: -1
	public static T get_Instance() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C8F770 Offset: 0x2C8B770 VA: 0x2C8F770
	|-Singleton<object>.get_Instance
	*/

	// RVA: -1 Offset: -1
	protected void OnApplicationPause(bool isPause) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C8F9B8 Offset: 0x2C8B9B8 VA: 0x2C8F9B8
	|-Singleton<object>.OnApplicationPause
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C8FB18 Offset: 0x2C8BB18 VA: 0x2C8FB18
	|-Singleton<object>..ctor
	*/
}
