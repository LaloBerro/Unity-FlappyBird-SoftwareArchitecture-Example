using Jump.Freezers.Domain;
using UnityEngine;
using Zenject;
using ZenjectExtensions.Zinstallers;

namespace Jump.Freezers.Installers
{
    public class FreezerZinstaller : InstanceZinstaller<Freezer>
    {
        [Header("Config")] [SerializeField] private bool _hasToFreeze;

        [Inject] private readonly IFreezableObject _freezableObject;

        protected override Freezer GetInitializedClass()
        {
            return new Freezer(_hasToFreeze, _freezableObject);
        }
    }
}