using System.ServiceProcess;

namespace SnowPlatformMonitor.Core.Classes
{
    public class ServiceManager
    {
        public string ServiceStatus(string ServiceName)
        {

            ServiceController sc = new ServiceController(ServiceName);

            switch (sc.Status)
            {
                case ServiceControllerStatus.Running:
                    return "Running";
                case ServiceControllerStatus.Stopped:
                    return "Stopped";
                case ServiceControllerStatus.Paused:
                    return "Paused";
                case ServiceControllerStatus.StopPending:
                    return "Stopping";
                case ServiceControllerStatus.StartPending:
                    return "Starting";
                default:
                    return "Status Changing";
            }
        }

        public string Stop(string ServiceName)
        {
            ServiceController sc = new ServiceController(ServiceName);

            if (sc.Status == ServiceControllerStatus.Running)
            {
                sc.Stop();
                return "Service Stopped.";
            }
            else
            {
                return "Service is not running.";
            }
        }

        public string Start(string ServiceName)
        {

            ServiceController sc = new ServiceController(ServiceName);

            if (sc.Status == ServiceControllerStatus.Stopped)
            {
                sc.Start();
                return "Service Started.";
            }
            else
            {
                return "Service is already running.";
            }

        }
    }
}
