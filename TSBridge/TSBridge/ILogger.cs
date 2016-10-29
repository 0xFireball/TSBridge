namespace TSBridge
{
    public interface ILogger
    {
        bool information();

        bool debug();

        bool warning();

        bool error();

        bool fatal();

        void log(string s);
    }
}