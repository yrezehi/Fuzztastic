namespace Fuzztastic.Workers
{
    public class Worker
    {
        public int Id { get; set; }
        public readonly string Description;

        public DateTime StartTime { get; set; }
        public readonly DateTime CreationTime;

        public Thread Thread { get; set; }
        public readonly ParameterizedThreadStart Action;

        public Worker(string description, ParameterizedThreadStart action, bool triggerImmediately = false)
        {
            CreationTime = DateTime.Now;
            Description = description;
            Action = action;

            Thread = new Thread(action);
            Id = Thread.ManagedThreadId;

            if (triggerImmediately)
            {
                StartTime = DateTime.Now;
                Thread.Start();
            }
        }

        public void Trigger()
        {
            if (Thread.ThreadState == ThreadState.Unstarted)
            {
                StartTime = DateTime.Now;
                Thread.Start();
            }
        }
    }
}
