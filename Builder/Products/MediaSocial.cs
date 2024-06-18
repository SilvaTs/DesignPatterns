
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
          Console.WriteLine(this._nameSocialNetwork);
          Console.WriteLine(title);
          Console.WriteLine(body);
        }

        public void Like(string publication)
        {
            Console.WriteLine($"{publication} was liked {this._nameSocialNetwork}");
        }
    }
}
