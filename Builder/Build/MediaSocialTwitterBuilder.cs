namespace Builder.Build
{
    public class MediaSocialTwitterBuilder : MediaSocialBuilder
    {

        public MediaSocialTwitterBuilder()
        {
            _mediaSocial = new Products.MediaSocial("Twitter");
        }
        public override void BuildPost()
        {
            _mediaSocial.Post(
                              title: "Title publication",
                              body: "my first post on Twitter"
                              );
        }

        public override void BuildLike()
        {
            _mediaSocial.Like("publication Apple");
        }        
    }
}
