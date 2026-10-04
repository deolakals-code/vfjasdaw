// Assembly: Assembly-CSharp.dll
// Namespace: 
public interface IGuideRailSetting // TypeDefIndex: 4181
{
	// Properties
	public abstract GuideRailSettingType HandleType { get; }
	public abstract int RailNum { get; }
	public abstract float RailLength { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract GuideRailSettingType get_HandleType();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract int get_RailNum();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract float get_RailLength();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void AddRailData(GuideRailSetterBase railData);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract float CalcRate(Vector3 pos, int no);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract Vector3 CalcPosition(float dist);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract float TryMovePosition(float nowDist, float addMove);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract Vector3 CalcVec(float dist);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract bool CheckExistRail(float dist);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract bool GetIsCameraRight(float dist);

	// RVA: -1 Offset: -1 Slot: 10
	public abstract float GetCameraDist(float dist);

	// RVA: -1 Offset: -1 Slot: 11
	public abstract float GetCameraRot(float dist);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract float CalcLength(int no);
}
