namespace Utilities
{
    public abstract class ApiAccessObject
    {
        public abstract void Connect();
        public abstract void GetData();
        public abstract void Process();

        public void Run()
        {
            Connect();
            GetData();
            Process();
        }
    }
}