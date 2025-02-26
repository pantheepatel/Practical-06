namespace EventsDelegates
{
    public delegate void ProcessCompletedEventHandler();
    class ProcessBusinessLogic
    {
        public event ProcessCompletedEventHandler? ProcessCompleted;

        public void StartProcess()
        {
            Console.WriteLine("Process Started!");

            OnProcessCompleted();
        }

        protected virtual void OnProcessCompleted()
        {
            ProcessCompleted?.Invoke();
        }
    }
}
