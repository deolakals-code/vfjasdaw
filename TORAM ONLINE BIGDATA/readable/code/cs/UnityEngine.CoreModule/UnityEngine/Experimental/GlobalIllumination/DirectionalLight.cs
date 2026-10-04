// Assembly: UnityEngine.CoreModule.dll
// Namespace: UnityEngine.Experimental.GlobalIllumination
public struct DirectionalLight // TypeDefIndex: 16668
{
	// Fields
	public int instanceID; // 0x0
	public bool shadow; // 0x4
	public LightMode mode; // 0x5
	public Vector3 position; // 0x8
	public Quaternion orientation; // 0x14
	public LinearColor color; // 0x24
	public LinearColor indirectColor; // 0x34
	public float penumbraWidthRadian; // 0x44
	[Obsolete("Directional lights support cookies now. In order to position the cookie projection in the world, a position and full orientation are necessary. Use the position and orientation members instead of the direction parameter.", True)]
	public Vector3 direction; // 0x48
}
