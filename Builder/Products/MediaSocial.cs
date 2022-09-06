
namespace Builder.Products
{
    public class MediaSocial
    {
        private readonly string _nameSocialNetwork;

        public MediaSocial(string nameSocialNetwork)
        {
            _nameSocialNetwork = nameSocialNetwork;
        }

        public void Post(string title, string body)
        { 
          Console.Write(this._nameSocialNetwork);
          Console.Write(title);
          Console.Write(body);
        }

        public void Like(string publication)
        {
            Console.Write($"{publication} was liked {this._nameSocialNetwork}");
        }
    }
}
