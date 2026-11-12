using System.Collections.Generic;

namespace LR4Moisieieva
{
    public class CPUScheduler
    {
        private Resource resource;
        private PriorityQueue<Process, long> queue;

        public CPUScheduler(Resource resource, PriorityQueue<Process, long> queue)
        {
            this.resource = resource;
            this.queue = queue;
        }

        public void Session()
        {
            if (queue.Count > 0)
            {
                Process proc = queue.Dequeue();
                proc.Status = ProcessStatus.running;
                resource.ActiveProcess = proc;
            }
        }
    }
}