namespace Library
{
    public interface IHelloFactory
    {
#if NETSTANDARD
        IHello GetThisPartyStarted(int val);
#endif
#if NETFRAMEWORK
        IHello GetThisPartyStarted(string mess);
#endif
    }
}