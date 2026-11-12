using System.Collections.Generic;

namespace LR4Moisieieva
{
    public class DeviceScheduler
    {
        private Resource resource;
        private Queue<Process> queue;

        public DeviceScheduler(Resource resource, Queue<Process> queue)
        {
            this.resource = resource;
            this.queue = queue;
        }

        public void Session()
        {
            if (queue.Count > 0)
            {
                Process proc = queue.Dequeue();
                resource.ActiveProcess = proc;
            }
        }
    }
}