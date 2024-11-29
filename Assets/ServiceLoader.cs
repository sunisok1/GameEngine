using Common;
using Framework.ServiceImpl;
using Framework.Yggdrasil;
using Framework.Yggdrasil.Services;
using UnityEngine;

public class ServiceLoader : MonoBehaviour
{
    private ServiceInjector m_mInjector;

    private void Awake()
    {
        if (Injector.Initialized) return;
        m_mInjector = Injector.SetInjector<ServiceInjector>();
        m_mInjector.Register<ILoggerService, UnityLogger>();
        m_mInjector.Register<IEventService, EventService>();
        m_mInjector.Register<IResourcesService, ResourcesService>();
        m_mInjector.Register<IUIService, UIService>();
        m_mInjector.Register<IConfigService, ConfigService>();
    }
}