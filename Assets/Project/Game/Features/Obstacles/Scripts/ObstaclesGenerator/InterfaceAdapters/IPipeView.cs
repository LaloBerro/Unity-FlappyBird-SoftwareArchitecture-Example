using ObjectPool.Runtime.RecyclableObjectPools.InterfaceAdapters.Presenters;

namespace Obstacles.InterfaceAdapters
{
    public interface IPipeView : IRecyclableObjectView
    {
        void SetClampedHeight(float clampedHeight);
        void SetAperture(float apertureSize);
    }
}