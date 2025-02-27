namespace EventsDelegates
{
    // creating delegate to handle event
    public delegate void ProcessCompletedEventHandler();
    class ProcessBusinessLogic
    {
        // creating event(ProcessCompleted) and binding it with delegate(ProcessCompletedEventHandler)
        public event ProcessCompletedEventHandler? ProcessCompleted;
        // method to be invoked from main method after instance creation
        // method to start the process, which will later trigger the event
        public void StartProcess()
        {
            Console.WriteLine("Process Started!");
            // method invocation
            OnProcessCompleted();
        }

        protected virtual void OnProcessCompleted()
        {
            // Checking if there are any subscribers before invoking the event
            ProcessCompleted?.Invoke();
        }
    }
}
