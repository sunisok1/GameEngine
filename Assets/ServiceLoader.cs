using Common;
using Framework.ServiceImpl;
using Framework.Yggdrasil;
using Framework.Yggdrasil.Services;
using UnityEngine;

public class ServiceLoader : MonoBehaviour
{
    private void Awake()
    {
        if (Injector.Initialized) return;
        Injector.SetInjector<ServiceInjector>();

        Injector.Instance.Register<ILoggerService, UnityLogger>();
        Injector.Instance.Register<IEventService, EventService>();
        Injector.Instance.Register<IResourcesService, ResourcesService>();
        Injector.Instance.Register<IUIService, UIService>();
        Injector.Instance.Register<IConfigService, ConfigService>();
    }
}