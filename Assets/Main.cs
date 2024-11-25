using Common;
using Framework.ServiceImpl;
using Framework.Yggdrasil;
using Framework.Yggdrasil.Services;
using UnityEngine;

public class Main : MonoBehaviour
{
    private ServiceInjector m_mInjector;

    // Start is called before the first frame update
    void Start()
    {
        m_mInjector = Injector.SetInjector<ServiceInjector>();
        m_mInjector.Register<ILoggerService, UnityLogger>();
        m_mInjector.Register<IEventService, EventService>();
        m_mInjector.Register<IObjectService, ObjectService>();
        m_mInjector.Register<IUIService, UIService>();
    }

    void Test()
    {
        var ui = m_mInjector.GetService<IUIService>();
        ui.Open<FakeUI, FakeUI.FakeCreateArgs>(new());
    }

    // Update is called once per frame
    void Update()
    {
    }
}