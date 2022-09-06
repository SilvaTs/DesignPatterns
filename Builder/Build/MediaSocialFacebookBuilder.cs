using Builder.Products;

namespace Builder.Build
{
    public class MediaSocialFacebookBuilder : MediaSocialBuilder
    {
        public MediaSocialFacebookBuilder()
        {
            _mediaSocial = new MediaSocial("Facebook");
        }

        public override void BuildPost()
        {
            _mediaSocial.Post(
                             title: "Title publication",
                             body: "my first post on Facebook"
                             );
        }

        public override void BuildLike()
        {
            _mediaSocial.Like("publication Microsoft");
        }        
    }
}
