namespace SelfishHttp
{
    public interface IServerConfiguration
    {
        IBodyParser BodyParser { get; set; }
        IBodyWriter BodyWriter { get; set; }
    }
}