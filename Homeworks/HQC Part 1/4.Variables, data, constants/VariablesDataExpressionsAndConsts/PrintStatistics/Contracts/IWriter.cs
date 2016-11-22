namespace PrintStatistics.Contracts
{
    public interface IWriter
    {
        void Print(string message, object numericValue);
    }
}
